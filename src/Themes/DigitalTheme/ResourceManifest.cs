using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;

namespace StatCan.Themes.DigitalTheme
{
    public class ResourceManagementOptionsConfiguration : IConfigureOptions<ResourceManagementOptions>
    {
        private static ResourceManifest _manifest;
        static ResourceManagementOptionsConfiguration()
        {
            _manifest = new ResourceManifest();

            _manifest
                .DefineStyle("DigitalTheme-stc-bootstrap")
                .SetUrl("~/DigitalTheme/css/digital-bootstrap.min.css", "~/DigitalTheme/css/digital-bootstrap.css")
                .SetVersion("1.0.0");
            _manifest
                .DefineStyle("font-awesome")
                .SetUrl("~/DigitalTheme/Vendor/fontawesome-free/css/all.min.css", "~/DigitalTheme/Vendor/fontawesome-free/css/all.css")
                .SetCdn("https://cdn.jsdelivr.net/npm/@fortawesome/fontawesome-free@5.13.0/css/all.min.css", "https://cdn.jsdelivr.net/npm/@fortawesome/fontawesome-free@5.13.0/css/all.css")
                .SetCdnIntegrity("sha384-Bfad6CLCknfcloXFOyFnlgtENryhrpZCe29RTifKEixXQZ38WheV+i/6YWSzkz3V", "sha384-I4s88/QBf6OKVFMRRyjRY9wYdRoEO/PnNLQ1xY+G0OQfntKp8FxRsOg9qjmtbnvL")
                .SetVersion("5.13.0");
            _manifest
                .DefineScript("font-awesome")
                .SetUrl("~/DigitalTheme/Vendor/fontawesome-free/js/all.min.js", "~/DigitalTheme/Vendor/fontawesome-free/js/all.js")
                .SetCdn("https://cdn.jsdelivr.net/npm/@fortawesome/fontawesome-free@5.13.0/js/all.min.js", "https://cdn.jsdelivr.net/npm/@fortawesome/fontawesome-free@5.13.0/js/all.js")
                .SetCdnIntegrity("sha384-ujbKXb9V3HdK7jcWL6kHL1c+2Lj4MR4Gkjl7UtwpSHg/ClpViddK9TI7yU53frPN", "sha384-Z4FE6Znluj29FL1tQBLSSjn1Pr72aJzuelbmGmqSAFTeFd42hQ4WHTc0JC30kbQi")
                .SetVersion("5.13.0");

            _manifest
                .DefineScript("jQuery")
                .SetUrl("~/DigitalTheme/Scripts/jquery.min.js", "~/DigitalTheme/Scripts/jquery.js")
                .SetCdn("https://code.jquery.com/jquery-3.5.1.min.js", "https://code.jquery.com/jquery-3.5.1.js")
                .SetCdnIntegrity("sha384-ZvpUoO/+PpLXR1lu4jmpXWu80pZlYUAfxl5NsBMWOEPSjUn/6Z/hRTt8+pR6L4N2", "sha384-/LjQZzcpTzaYn7qWqRIWYC5l8FWEZ2bIHIz0D73Uzba4pShEcdLdZyZkI4Kv676E")
                .SetVersion("3.5.1");
            _manifest
                .DefineScript("popper")
                .SetUrl("~/DigitalTheme/Scripts/popper.min.js", "~/DigitalTheme/Scripts/popper.js")
                .SetCdn("https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js", "https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.js")
                .SetCdnIntegrity("sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN", "sha384-cpSm/ilDFOWiMuF2bj03ZzJinb48NO9IGCXcYDtUzdP5y64Ober65chnoOj1XFoA")
                .SetVersion("1.16.1");

            _manifest
                .DefineScript("bootstrap")
                .SetDependencies("jQuery", "popper")
                .SetUrl("~/DigitalTheme/Scripts/bootstrap.min.js", "~/DigitalTheme/Scripts/bootstrap.js")
                .SetCdn("https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js", "https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.js")
                .SetCdnIntegrity("sha384-B4gt1jrGC7Jh4AgTPSdUtOBvfO8shuf57BaghqFfPlYxofvL8/KUEfYiJOMMV+rV", "sha384-PR/NM91PuT7DlZx1yQeKVnw+YgwW1GBT9jWtx05MZ1362zoFpXKl4Bh5ib8q9KYi")
                .SetVersion("4.5.2");
        }

        public void Configure(ResourceManagementOptions options)
        {
            options.ResourceManifests.Add(_manifest);
        }
    }
}
