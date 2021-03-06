// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;

namespace Pulumi.AzureNextGen
{
    public static class Config
    {
        private static readonly Pulumi.Config __config = new Pulumi.Config("azure-nextgen");
        public static ImmutableArray<string> AuxiliaryTenantIds { get; set; } = __config.GetObject<ImmutableArray<string>>("auxiliaryTenantIds");

        /// <summary>
        /// The password associated with the Client Certificate. For use when authenticating as a Service Principal using a Client Certificate
        /// </summary>
        public static string? ClientCertificatePassword { get; set; } = __config.Get("clientCertificatePassword");

        /// <summary>
        /// The path to the Client Certificate associated with the Service Principal for use when authenticating as a Service Principal using a Client Certificate.
        /// </summary>
        public static string? ClientCertificatePath { get; set; } = __config.Get("clientCertificatePath");

        /// <summary>
        /// The Client ID which should be used.
        /// </summary>
        public static string? ClientId { get; set; } = __config.Get("clientId");

        /// <summary>
        /// The Client Secret which should be used. For use When authenticating as a Service Principal using a Client Secret.
        /// </summary>
        public static string? ClientSecret { get; set; } = __config.Get("clientSecret");

        /// <summary>
        /// This will disable the Pulumi Partner ID which is used if a custom `partnerId` isn't specified.
        /// </summary>
        public static bool? DisablePulumiPartnerId { get; set; } = __config.GetBoolean("disablePulumiPartnerId");

        /// <summary>
        /// The Cloud Environment which should be used. Possible values are public, usgovernment, german, and china. Defaults to public.
        /// </summary>
        public static string? Environment { get; set; } = __config.Get("environment");

        /// <summary>
        /// The path to a custom endpoint for Managed Service Identity - in most circumstances this should be detected automatically. 
        /// </summary>
        public static string? MsiEndpoint { get; set; } = __config.Get("msiEndpoint");

        /// <summary>
        /// A GUID/UUID that is registered with Microsoft to facilitate partner resource usage attribution.
        /// </summary>
        public static string? PartnerId { get; set; } = __config.Get("partnerId");

        /// <summary>
        /// The Subscription ID which should be used.
        /// </summary>
        public static string? SubscriptionId { get; set; } = __config.Get("subscriptionId");

        /// <summary>
        /// The Tenant ID which should be used.
        /// </summary>
        public static string? TenantId { get; set; } = __config.Get("tenantId");

        /// <summary>
        /// Allowed Managed Service Identity be used for Authentication.
        /// </summary>
        public static bool? UseMsi { get; set; } = __config.GetBoolean("useMsi");

    }
}
