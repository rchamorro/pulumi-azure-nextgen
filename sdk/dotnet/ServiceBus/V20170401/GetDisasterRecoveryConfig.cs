// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ServiceBus.V20170401
{
    public static class GetDisasterRecoveryConfig
    {
        public static Task<GetDisasterRecoveryConfigResult> InvokeAsync(GetDisasterRecoveryConfigArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDisasterRecoveryConfigResult>("azure-nextgen:servicebus/v20170401:getDisasterRecoveryConfig", args ?? new GetDisasterRecoveryConfigArgs(), options.WithVersion());
    }


    public sealed class GetDisasterRecoveryConfigArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The Disaster Recovery configuration name
        /// </summary>
        [Input("alias", required: true)]
        public string Alias { get; set; } = null!;

        /// <summary>
        /// The namespace name
        /// </summary>
        [Input("namespaceName", required: true)]
        public string NamespaceName { get; set; } = null!;

        /// <summary>
        /// Name of the Resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetDisasterRecoveryConfigArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDisasterRecoveryConfigResult
    {
        /// <summary>
        /// Primary/Secondary eventhub namespace name, which is part of GEO DR pairing
        /// </summary>
        public readonly string? AlternateName;
        /// <summary>
        /// Resource Id
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// ARM Id of the Primary/Secondary eventhub namespace name, which is part of GEO DR pairing
        /// </summary>
        public readonly string? PartnerNamespace;
        /// <summary>
        /// Number of entities pending to be replicated.
        /// </summary>
        public readonly double PendingReplicationOperationsCount;
        /// <summary>
        /// Provisioning state of the Alias(Disaster Recovery configuration) - possible values 'Accepted' or 'Succeeded' or 'Failed'
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// role of namespace in GEO DR - possible values 'Primary' or 'PrimaryNotReplicating' or 'Secondary'
        /// </summary>
        public readonly string Role;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetDisasterRecoveryConfigResult(
            string? alternateName,

            string id,

            string name,

            string? partnerNamespace,

            double pendingReplicationOperationsCount,

            string provisioningState,

            string role,

            string type)
        {
            AlternateName = alternateName;
            Id = id;
            Name = name;
            PartnerNamespace = partnerNamespace;
            PendingReplicationOperationsCount = pendingReplicationOperationsCount;
            ProvisioningState = provisioningState;
            Role = role;
            Type = type;
        }
    }
}
