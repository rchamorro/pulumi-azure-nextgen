// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.NetApp.V20190801
{
    /// <summary>
    /// Volume resource
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:netapp/v20190801:Volume")]
    public partial class Volume : Pulumi.CustomResource
    {
        /// <summary>
        /// Unique Baremetal Tenant Identifier.
        /// </summary>
        [Output("baremetalTenantId")]
        public Output<string> BaremetalTenantId { get; private set; } = null!;

        /// <summary>
        /// A unique file path for the volume. Used when creating mount targets
        /// </summary>
        [Output("creationToken")]
        public Output<string> CreationToken { get; private set; } = null!;

        /// <summary>
        /// DataProtection volume, can have a replication object
        /// </summary>
        [Output("dataProtection")]
        public Output<Outputs.VolumePropertiesResponseDataProtection?> DataProtection { get; private set; } = null!;

        /// <summary>
        /// Set of export policy rules
        /// </summary>
        [Output("exportPolicy")]
        public Output<Outputs.VolumePropertiesResponseExportPolicy?> ExportPolicy { get; private set; } = null!;

        /// <summary>
        /// Unique FileSystem Identifier.
        /// </summary>
        [Output("fileSystemId")]
        public Output<string> FileSystemId { get; private set; } = null!;

        /// <summary>
        /// Resource location
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// List of mount targets
        /// </summary>
        [Output("mountTargets")]
        public Output<ImmutableArray<Outputs.MountTargetPropertiesResponse>> MountTargets { get; private set; } = null!;

        /// <summary>
        /// Resource name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Set of protocol types
        /// </summary>
        [Output("protocolTypes")]
        public Output<ImmutableArray<string>> ProtocolTypes { get; private set; } = null!;

        /// <summary>
        /// Azure lifecycle management
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The service level of the file system
        /// </summary>
        [Output("serviceLevel")]
        public Output<string?> ServiceLevel { get; private set; } = null!;

        /// <summary>
        /// UUID v4 or resource identifier used to identify the Snapshot.
        /// </summary>
        [Output("snapshotId")]
        public Output<string?> SnapshotId { get; private set; } = null!;

        /// <summary>
        /// The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes
        /// </summary>
        [Output("subnetId")]
        public Output<string> SubnetId { get; private set; } = null!;

        /// <summary>
        /// Resource tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Resource type
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// Maximum storage quota allowed for a file system in bytes. This is a soft quota used for alerting only. Minimum size is 100 GiB. Upper limit is 100TiB. Specified in bytes.
        /// </summary>
        [Output("usageThreshold")]
        public Output<double> UsageThreshold { get; private set; } = null!;

        /// <summary>
        /// What type of volume is this
        /// </summary>
        [Output("volumeType")]
        public Output<string?> VolumeType { get; private set; } = null!;


        /// <summary>
        /// Create a Volume resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Volume(string name, VolumeArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:netapp/v20190801:Volume", name, args ?? new VolumeArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Volume(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:netapp/v20190801:Volume", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/latest:Volume"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20170815:Volume"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20190501:Volume"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20190601:Volume"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20190701:Volume"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20191001:Volume"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20191101:Volume"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20200201:Volume"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20200301:Volume"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20200501:Volume"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20200601:Volume"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20200701:Volume"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20200801:Volume"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20200901:Volume"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Volume resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Volume Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Volume(name, id, options);
        }
    }

    public sealed class VolumeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the NetApp account
        /// </summary>
        [Input("accountName", required: true)]
        public Input<string> AccountName { get; set; } = null!;

        /// <summary>
        /// A unique file path for the volume. Used when creating mount targets
        /// </summary>
        [Input("creationToken", required: true)]
        public Input<string> CreationToken { get; set; } = null!;

        /// <summary>
        /// DataProtection volume, can have a replication object
        /// </summary>
        [Input("dataProtection")]
        public Input<Inputs.VolumePropertiesDataProtectionArgs>? DataProtection { get; set; }

        /// <summary>
        /// Set of export policy rules
        /// </summary>
        [Input("exportPolicy")]
        public Input<Inputs.VolumePropertiesExportPolicyArgs>? ExportPolicy { get; set; }

        /// <summary>
        /// Resource location
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        [Input("mountTargets")]
        private InputList<Inputs.MountTargetPropertiesArgs>? _mountTargets;

        /// <summary>
        /// List of mount targets
        /// </summary>
        public InputList<Inputs.MountTargetPropertiesArgs> MountTargets
        {
            get => _mountTargets ?? (_mountTargets = new InputList<Inputs.MountTargetPropertiesArgs>());
            set => _mountTargets = value;
        }

        /// <summary>
        /// The name of the capacity pool
        /// </summary>
        [Input("poolName", required: true)]
        public Input<string> PoolName { get; set; } = null!;

        [Input("protocolTypes")]
        private InputList<string>? _protocolTypes;

        /// <summary>
        /// Set of protocol types
        /// </summary>
        public InputList<string> ProtocolTypes
        {
            get => _protocolTypes ?? (_protocolTypes = new InputList<string>());
            set => _protocolTypes = value;
        }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The service level of the file system
        /// </summary>
        [Input("serviceLevel")]
        public InputUnion<string, Pulumi.AzureNextGen.NetApp.V20190801.ServiceLevel>? ServiceLevel { get; set; }

        /// <summary>
        /// UUID v4 or resource identifier used to identify the Snapshot.
        /// </summary>
        [Input("snapshotId")]
        public Input<string>? SnapshotId { get; set; }

        /// <summary>
        /// The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes
        /// </summary>
        [Input("subnetId", required: true)]
        public Input<string> SubnetId { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// Maximum storage quota allowed for a file system in bytes. This is a soft quota used for alerting only. Minimum size is 100 GiB. Upper limit is 100TiB. Specified in bytes.
        /// </summary>
        [Input("usageThreshold", required: true)]
        public Input<double> UsageThreshold { get; set; } = null!;

        /// <summary>
        /// The name of the volume
        /// </summary>
        [Input("volumeName", required: true)]
        public Input<string> VolumeName { get; set; } = null!;

        /// <summary>
        /// What type of volume is this
        /// </summary>
        [Input("volumeType")]
        public Input<string>? VolumeType { get; set; }

        public VolumeArgs()
        {
        }
    }
}
