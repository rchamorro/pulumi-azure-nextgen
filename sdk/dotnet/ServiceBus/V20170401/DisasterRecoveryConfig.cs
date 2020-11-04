// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ServiceBus.V20170401
{
    /// <summary>
    /// Single item in List or Get Alias(Disaster Recovery configuration) operation
    /// </summary>
    public partial class DisasterRecoveryConfig : Pulumi.CustomResource
    {
        /// <summary>
        /// Primary/Secondary eventhub namespace name, which is part of GEO DR pairing
        /// </summary>
        [Output("alternateName")]
        public Output<string?> AlternateName { get; private set; } = null!;

        /// <summary>
        /// Resource name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// ARM Id of the Primary/Secondary eventhub namespace name, which is part of GEO DR pairing
        /// </summary>
        [Output("partnerNamespace")]
        public Output<string?> PartnerNamespace { get; private set; } = null!;

        /// <summary>
        /// Number of entities pending to be replicated.
        /// </summary>
        [Output("pendingReplicationOperationsCount")]
        public Output<int> PendingReplicationOperationsCount { get; private set; } = null!;

        /// <summary>
        /// Provisioning state of the Alias(Disaster Recovery configuration) - possible values 'Accepted' or 'Succeeded' or 'Failed'
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// role of namespace in GEO DR - possible values 'Primary' or 'PrimaryNotReplicating' or 'Secondary'
        /// </summary>
        [Output("role")]
        public Output<string> Role { get; private set; } = null!;

        /// <summary>
        /// Resource type
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a DisasterRecoveryConfig resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DisasterRecoveryConfig(string name, DisasterRecoveryConfigArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:servicebus/v20170401:DisasterRecoveryConfig", name, args ?? new DisasterRecoveryConfigArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DisasterRecoveryConfig(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:servicebus/v20170401:DisasterRecoveryConfig", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:servicebus/latest:DisasterRecoveryConfig"},
                    new Pulumi.Alias { Type = "azure-nextgen:servicebus/v20180101preview:DisasterRecoveryConfig"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing DisasterRecoveryConfig resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DisasterRecoveryConfig Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new DisasterRecoveryConfig(name, id, options);
        }
    }

    public sealed class DisasterRecoveryConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Disaster Recovery configuration name
        /// </summary>
        [Input("alias", required: true)]
        public Input<string> Alias { get; set; } = null!;

        /// <summary>
        /// Primary/Secondary eventhub namespace name, which is part of GEO DR pairing
        /// </summary>
        [Input("alternateName")]
        public Input<string>? AlternateName { get; set; }

        /// <summary>
        /// The namespace name
        /// </summary>
        [Input("namespaceName", required: true)]
        public Input<string> NamespaceName { get; set; } = null!;

        /// <summary>
        /// ARM Id of the Primary/Secondary eventhub namespace name, which is part of GEO DR pairing
        /// </summary>
        [Input("partnerNamespace")]
        public Input<string>? PartnerNamespace { get; set; }

        /// <summary>
        /// Name of the Resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public DisasterRecoveryConfigArgs()
        {
        }
    }
}
