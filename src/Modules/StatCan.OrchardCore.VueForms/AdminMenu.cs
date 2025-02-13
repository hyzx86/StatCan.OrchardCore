using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Localization;
using OrchardCore.Contents;
using OrchardCore.Contents.Security;
using OrchardCore.Navigation;

namespace StatCan.OrchardCore.VueForms
{
    public class AdminMenu : INavigationProvider
    {
        private readonly IStringLocalizer S;

        public AdminMenu(IStringLocalizer<AdminMenu> localizer)
        {
            S = localizer;
        }

        public Task BuildNavigationAsync(string name, NavigationBuilder builder)
        {
            if (!String.Equals(name, "admin", StringComparison.OrdinalIgnoreCase))
            {
                return Task.CompletedTask;
            }

            var rvd = new RouteValueDictionary
            {
                { "contentTypeId", "VueForm" },
                { "Area", "OrchardCore.Contents" },
                { "Options.SelectedContentType", "VueForm" },
                { "Options.CanCreateSelectedContentType", true }
            };

            builder.Add(S["Content"], design => design
                    .Add(S["Vue Forms"], S["Vue Forms"], menus => menus
                        .Permission(ContentTypePermissionsHelper.CreateDynamicPermission(ContentTypePermissionsHelper.PermissionTemplates[CommonPermissions.EditOwnContent.Name], "VueForm"))
                        .Action("List", "Admin", rvd)
                        .LocalNav()
                        ));

            return Task.CompletedTask;
        }
    }
}
