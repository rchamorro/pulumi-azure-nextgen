// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Sql.V20140401
{
    /// <summary>
    /// Represents a disaster recovery configuration.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:sql/v20140401:DisasterRecoveryConfiguration")]
    public partial class DisasterRecoveryConfiguration : Pulumi.CustomResource
    {
        /// <summary>
        /// Whether or not failover can be done automatically.
        /// </summary>
        [Output("autoFailover")]
        public Output<string> AutoFailover { get; private set; } = null!;

        /// <summary>
        /// How aggressive the automatic failover should be.
        /// </summary>
        [Output("failoverPolicy")]
        public Output<string> FailoverPolicy { get; private set; } = null!;

        /// <summary>
        /// Location of the server that contains this disaster recovery configuration.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Logical name of the server.
        /// </summary>
        [Output("logicalServerName")]
        public Output<string> LogicalServerName { get; private set; } = null!;

        /// <summary>
        /// Resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Logical name of the partner server.
        /// </summary>
        [Output("partnerLogicalServerName")]
        public Output<string> PartnerLogicalServerName { get; private set; } = null!;

        /// <summary>
        /// Id of the partner server.
        /// </summary>
        [Output("partnerServerId")]
        public Output<string> PartnerServerId { get; private set; } = null!;

        /// <summary>
        /// The role of the current server in the disaster recovery configuration.
        /// </summary>
        [Output("role")]
        public Output<string> Role { get; private set; } = null!;

        /// <summary>
        /// The status of the disaster recovery configuration.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// Resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a DisasterRecoveryConfiguration resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DisasterRecoveryConfiguration(string name, DisasterRecoveryConfigurationArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:sql/v20140401:DisasterRecoveryConfiguration", name, args ?? new DisasterRecoveryConfigurationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DisasterRecoveryConfiguration(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:sql/v20140401:DisasterRecoveryConfiguration", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:sql/latest:DisasterRecoveryConfiguration"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing DisasterRecoveryConfiguration resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DisasterRecoveryConfiguration Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new DisasterRecoveryConfiguration(name, id, options);
        }
    }

    public sealed class DisasterRecoveryConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the disaster recovery configuration to be created/updated.
        /// </summary>
        [Input("disasterRecoveryConfigurationName", required: true)]
        public Input<string> DisasterRecoveryConfigurationName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the server.
        /// </summary>
        [Input("serverName", required: true)]
        public Input<string> ServerName { get; set; } = null!;

        public DisasterRecoveryConfigurationArgs()
        {
        }
    }
}
