using OrchardCore.Modules.Manifest;
using static StatCan.OrchardCore.Manifest.StatCanManifestConstants;
using StatCan.OrchardCore.VueForms;

[assembly: Module(
    Name = "StatCan VueForms",
    Author = DigitalInnovationTeam,
    Website = DigitalInnovationWebsite,
    Version = Version,
    Description = "The VueForm module provides a form ContentType that simplifies using VueJs forms in the frontend.",
    Category = "Form"
)]

[assembly: Feature(
    Id = Constants.Features.VueForms,
    Name = "VueForms",
    Description = "The VueForm module provides a form ContentType that simplifies using VueJs forms in the frontend.",
    Category = "Form",
    Dependencies = new[]
    {
        "OrchardCore.Title",
        "OrchardCore.Contents",
        "OrchardCore.Alias",
        "OrchardCore.Liquid",
        "StatCan.OrchardCore.Scripting",
        "StatCan.OrchardCore.ContentFields",
        "StatCan.OrchardCore.ContentPermissions"
    }
)]

[assembly: Feature(
    Id = Constants.Features.Localized,
    Name = "VueForms Localized",
    Description = "Welds the LocalizedText part to your VueForms ",
    Category = "Form",
    Dependencies = new[] { Constants.Features.VueForms, "StatCan.OrchardCore.LocalizedText" }
)]

[assembly: Feature(
    Id = Constants.Features.Survey,
    Name = "VueForms SurveyJS integration",
    Description = "Adds SurveyJS support to VueForms",
    Category = "Form",
    Dependencies = new[] { Constants.Features.VueForms }
)]
