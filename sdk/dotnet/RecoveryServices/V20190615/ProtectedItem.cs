// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.V20190615
{
    /// <summary>
    /// Base class for backup items.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:recoveryservices/v20190615:ProtectedItem")]
    public partial class ProtectedItem : Pulumi.CustomResource
    {
        /// <summary>
        /// Optional ETag.
        /// </summary>
        [Output("eTag")]
        public Output<string?> ETag { get; private set; } = null!;

        /// <summary>
        /// Resource location.
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// Resource name associated with the resource.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// ProtectedItemResource properties
        /// </summary>
        [Output("properties")]
        public Output<Union<Outputs.AzureFileshareProtectedItemResponse, Union<Outputs.AzureIaaSVMProtectedItemResponse, Union<Outputs.AzureSqlProtectedItemResponse, Union<Outputs.AzureVmWorkloadProtectedItemResponse, Union<Outputs.DPMProtectedItemResponse, Union<Outputs.GenericProtectedItemResponse, Outputs.MabFileFolderProtectedItemResponse>>>>>>> Properties { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Resource type represents the complete path of the form Namespace/ResourceType/ResourceType/...
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a ProtectedItem resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ProtectedItem(string name, ProtectedItemArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:recoveryservices/v20190615:ProtectedItem", name, args ?? new ProtectedItemArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ProtectedItem(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:recoveryservices/v20190615:ProtectedItem", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:recoveryservices/latest:ProtectedItem"},
                    new Pulumi.Alias { Type = "azure-nextgen:recoveryservices/v20160601:ProtectedItem"},
                    new Pulumi.Alias { Type = "azure-nextgen:recoveryservices/v20190513:ProtectedItem"},
                    new Pulumi.Alias { Type = "azure-nextgen:recoveryservices/v20201001:ProtectedItem"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ProtectedItem resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ProtectedItem Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ProtectedItem(name, id, options);
        }
    }

    public sealed class ProtectedItemArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Container name associated with the backup item.
        /// </summary>
        [Input("containerName", required: true)]
        public Input<string> ContainerName { get; set; } = null!;

        /// <summary>
        /// Optional ETag.
        /// </summary>
        [Input("eTag")]
        public Input<string>? ETag { get; set; }

        /// <summary>
        /// Fabric name associated with the backup item.
        /// </summary>
        [Input("fabricName", required: true)]
        public Input<string> FabricName { get; set; } = null!;

        /// <summary>
        /// Resource location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// ProtectedItemResource properties
        /// </summary>
        [Input("properties")]
        public InputUnion<Inputs.AzureFileshareProtectedItemArgs, InputUnion<Inputs.AzureIaaSVMProtectedItemArgs, InputUnion<Inputs.AzureSqlProtectedItemArgs, InputUnion<Inputs.AzureVmWorkloadProtectedItemArgs, InputUnion<Inputs.DPMProtectedItemArgs, InputUnion<Inputs.GenericProtectedItemArgs, Inputs.MabFileFolderProtectedItemArgs>>>>>>? Properties { get; set; }

        /// <summary>
        /// Item name to be backed up.
        /// </summary>
        [Input("protectedItemName", required: true)]
        public Input<string> ProtectedItemName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group where the recovery services vault is present.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The name of the recovery services vault.
        /// </summary>
        [Input("vaultName", required: true)]
        public Input<string> VaultName { get; set; } = null!;

        public ProtectedItemArgs()
        {
        }
    }
}
