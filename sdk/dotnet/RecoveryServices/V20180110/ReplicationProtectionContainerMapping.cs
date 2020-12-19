// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.V20180110
{
    /// <summary>
    /// Protection container mapping object.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:recoveryservices/v20180110:ReplicationProtectionContainerMapping")]
    public partial class ReplicationProtectionContainerMapping : Pulumi.CustomResource
    {
        /// <summary>
        /// Resource Location
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// Resource Name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The custom data.
        /// </summary>
        [Output("properties")]
        public Output<Outputs.ProtectionContainerMappingPropertiesResponse> Properties { get; private set; } = null!;

        /// <summary>
        /// Resource Type
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a ReplicationProtectionContainerMapping resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ReplicationProtectionContainerMapping(string name, ReplicationProtectionContainerMappingArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:recoveryservices/v20180110:ReplicationProtectionContainerMapping", name, args ?? new ReplicationProtectionContainerMappingArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ReplicationProtectionContainerMapping(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:recoveryservices/v20180110:ReplicationProtectionContainerMapping", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:recoveryservices/latest:ReplicationProtectionContainerMapping"},
                    new Pulumi.Alias { Type = "azure-nextgen:recoveryservices/v20160810:ReplicationProtectionContainerMapping"},
                    new Pulumi.Alias { Type = "azure-nextgen:recoveryservices/v20180710:ReplicationProtectionContainerMapping"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ReplicationProtectionContainerMapping resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ReplicationProtectionContainerMapping Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ReplicationProtectionContainerMapping(name, id, options);
        }
    }

    public sealed class ReplicationProtectionContainerMappingArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Fabric name.
        /// </summary>
        [Input("fabricName", required: true)]
        public Input<string> FabricName { get; set; } = null!;

        /// <summary>
        /// Protection container mapping name.
        /// </summary>
        [Input("mappingName", required: true)]
        public Input<string> MappingName { get; set; } = null!;

        /// <summary>
        /// Configure protection input properties.
        /// </summary>
        [Input("properties")]
        public Input<Inputs.CreateProtectionContainerMappingInputPropertiesArgs>? Properties { get; set; }

        /// <summary>
        /// Protection container name.
        /// </summary>
        [Input("protectionContainerName", required: true)]
        public Input<string> ProtectionContainerName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group where the recovery services vault is present.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the recovery services vault.
        /// </summary>
        [Input("resourceName", required: true)]
        public Input<string> ResourceName { get; set; } = null!;

        public ReplicationProtectionContainerMappingArgs()
        {
        }
    }
}
