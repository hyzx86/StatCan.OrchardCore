using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;
using OrchardCore.Scripting;

namespace StatCan.OrchardCore.Scripting
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGlobalMethodProvider, FormsGlobalMethodsProvider>();
            services.AddSingleton<IGlobalMethodProvider, HttpGlobalMethodsProvider>();
        }
    }

    [RequireFeatures("OrchardCore.Contents")]
    public class ContentStartup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGlobalMethodProvider, ContentGlobalMethodsProvider>();
        }
    }

    [RequireFeatures("OrchardCore.Taxonomies")]
    public class TaxonomyStartup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGlobalMethodProvider, TaxonomyGlobalMethodsProvider>();
        }
    }

    [RequireFeatures("OrchardCore.ContentLocalization")]
    public class ContentLocalizationStartup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGlobalMethodProvider, LocalizationGlobalMethodsProvider>();
        }
    }

    [RequireFeatures("OrchardCore.Users")]
    public class UsersStartup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGlobalMethodProvider, UserGlobalMethodsProvider>();
        }
    }

    [RequireFeatures("OrchardCore.Deployment")]
    public class RecipeStartup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGlobalMethodProvider, RecipeGlobalMethodsProvider>();
        }
    }

    [RequireFeatures("OrchardCore.Media")]
    public class MediaStartup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGlobalMethodProvider, MediaGlobalMethodsProvider>();
        }
    }
}
