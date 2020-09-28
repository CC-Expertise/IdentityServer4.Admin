namespace Skoruba.IdentityServer4.STS.Identity.Configuration
{
    public class ExternalProvidersConfiguration
    {
        public bool UseGenesysCloudProvider { get; set; }
        public string GenesysCloudClientId { get; set; }
        public string GenesysCloudClientSecret { get; set; }
        public string GenesysCloudRedirectUri { get; set; }
    }
}
