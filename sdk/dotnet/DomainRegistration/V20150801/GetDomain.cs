// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DomainRegistration.V20150801
{
    public static class GetDomain
    {
        public static Task<GetDomainResult> InvokeAsync(GetDomainArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDomainResult>("azure-nextgen:domainregistration/v20150801:getDomain", args ?? new GetDomainArgs(), options.WithVersion());
    }


    public sealed class GetDomainArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the domain
        /// </summary>
        [Input("domainName", required: true)]
        public string DomainName { get; set; } = null!;

        /// <summary>
        /// Name of the resource group
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetDomainArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDomainResult
    {
        /// <summary>
        /// If true then domain will renewed automatically
        /// </summary>
        public readonly bool? AutoRenew;
        /// <summary>
        /// Legal agreement consent
        /// </summary>
        public readonly Outputs.DomainPurchaseConsentResponse? Consent;
        /// <summary>
        /// Admin contact information
        /// </summary>
        public readonly Outputs.ContactResponse? ContactAdmin;
        /// <summary>
        /// Billing contact information
        /// </summary>
        public readonly Outputs.ContactResponse? ContactBilling;
        /// <summary>
        /// Registrant contact information
        /// </summary>
        public readonly Outputs.ContactResponse? ContactRegistrant;
        /// <summary>
        /// Technical contact information
        /// </summary>
        public readonly Outputs.ContactResponse? ContactTech;
        /// <summary>
        /// Domain creation timestamp
        /// </summary>
        public readonly string? CreatedTime;
        /// <summary>
        /// Reasons why domain is not renewable
        /// </summary>
        public readonly ImmutableArray<string> DomainNotRenewableReasons;
        /// <summary>
        /// Domain expiration timestamp
        /// </summary>
        public readonly string? ExpirationTime;
        /// <summary>
        /// Kind of resource
        /// </summary>
        public readonly string? Kind;
        /// <summary>
        /// Timestamp when the domain was renewed last time
        /// </summary>
        public readonly string? LastRenewedTime;
        /// <summary>
        /// Resource Location
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// All hostnames derived from the domain and assigned to Azure resources
        /// </summary>
        public readonly ImmutableArray<Outputs.HostNameResponse> ManagedHostNames;
        /// <summary>
        /// Resource Name
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Name servers
        /// </summary>
        public readonly ImmutableArray<string> NameServers;
        /// <summary>
        /// If true then domain privacy is enabled for this domain
        /// </summary>
        public readonly bool? Privacy;
        /// <summary>
        /// Domain provisioning state
        /// </summary>
        public readonly string? ProvisioningState;
        /// <summary>
        /// If true then Azure can assign this domain to Web Apps. This value will be true if domain registration status is active and it is hosted on name servers Azure has programmatic access to
        /// </summary>
        public readonly bool? ReadyForDnsRecordManagement;
        /// <summary>
        /// Domain registration status
        /// </summary>
        public readonly string? RegistrationStatus;
        /// <summary>
        /// Resource tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private GetDomainResult(
            bool? autoRenew,

            Outputs.DomainPurchaseConsentResponse? consent,

            Outputs.ContactResponse? contactAdmin,

            Outputs.ContactResponse? contactBilling,

            Outputs.ContactResponse? contactRegistrant,

            Outputs.ContactResponse? contactTech,

            string? createdTime,

            ImmutableArray<string> domainNotRenewableReasons,

            string? expirationTime,

            string? kind,

            string? lastRenewedTime,

            string location,

            ImmutableArray<Outputs.HostNameResponse> managedHostNames,

            string? name,

            ImmutableArray<string> nameServers,

            bool? privacy,

            string? provisioningState,

            bool? readyForDnsRecordManagement,

            string? registrationStatus,

            ImmutableDictionary<string, string>? tags,

            string? type)
        {
            AutoRenew = autoRenew;
            Consent = consent;
            ContactAdmin = contactAdmin;
            ContactBilling = contactBilling;
            ContactRegistrant = contactRegistrant;
            ContactTech = contactTech;
            CreatedTime = createdTime;
            DomainNotRenewableReasons = domainNotRenewableReasons;
            ExpirationTime = expirationTime;
            Kind = kind;
            LastRenewedTime = lastRenewedTime;
            Location = location;
            ManagedHostNames = managedHostNames;
            Name = name;
            NameServers = nameServers;
            Privacy = privacy;
            ProvisioningState = provisioningState;
            ReadyForDnsRecordManagement = readyForDnsRecordManagement;
            RegistrationStatus = registrationStatus;
            Tags = tags;
            Type = type;
        }
    }
}