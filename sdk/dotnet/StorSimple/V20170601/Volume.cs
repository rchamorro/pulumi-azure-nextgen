// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.StorSimple.V20170601
{
    /// <summary>
    /// The volume.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:storsimple/v20170601:Volume")]
    public partial class Volume : Pulumi.CustomResource
    {
        /// <summary>
        /// The IDs of the access control records, associated with the volume.
        /// </summary>
        [Output("accessControlRecordIds")]
        public Output<ImmutableArray<string>> AccessControlRecordIds { get; private set; } = null!;

        /// <summary>
        /// The IDs of the backup policies, in which this volume is part of.
        /// </summary>
        [Output("backupPolicyIds")]
        public Output<ImmutableArray<string>> BackupPolicyIds { get; private set; } = null!;

        /// <summary>
        /// The backup status of the volume.
        /// </summary>
        [Output("backupStatus")]
        public Output<string> BackupStatus { get; private set; } = null!;

        /// <summary>
        /// The Kind of the object. Currently only Series8000 is supported
        /// </summary>
        [Output("kind")]
        public Output<string?> Kind { get; private set; } = null!;

        /// <summary>
        /// The monitoring status of the volume.
        /// </summary>
        [Output("monitoringStatus")]
        public Output<string> MonitoringStatus { get; private set; } = null!;

        /// <summary>
        /// The name of the object.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The operation status on the volume.
        /// </summary>
        [Output("operationStatus")]
        public Output<string> OperationStatus { get; private set; } = null!;

        /// <summary>
        /// The size of the volume in bytes.
        /// </summary>
        [Output("sizeInBytes")]
        public Output<double> SizeInBytes { get; private set; } = null!;

        /// <summary>
        /// The hierarchical type of the object.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// The ID of the volume container, in which this volume is created.
        /// </summary>
        [Output("volumeContainerId")]
        public Output<string> VolumeContainerId { get; private set; } = null!;

        /// <summary>
        /// The volume status.
        /// </summary>
        [Output("volumeStatus")]
        public Output<string> VolumeStatus { get; private set; } = null!;

        /// <summary>
        /// The type of the volume.
        /// </summary>
        [Output("volumeType")]
        public Output<string> VolumeType { get; private set; } = null!;


        /// <summary>
        /// Create a Volume resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Volume(string name, VolumeArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:storsimple/v20170601:Volume", name, args ?? new VolumeArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Volume(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:storsimple/v20170601:Volume", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:storsimple/latest:Volume"},
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
        [Input("accessControlRecordIds", required: true)]
        private InputList<string>? _accessControlRecordIds;

        /// <summary>
        /// The IDs of the access control records, associated with the volume.
        /// </summary>
        public InputList<string> AccessControlRecordIds
        {
            get => _accessControlRecordIds ?? (_accessControlRecordIds = new InputList<string>());
            set => _accessControlRecordIds = value;
        }

        /// <summary>
        /// The device name
        /// </summary>
        [Input("deviceName", required: true)]
        public Input<string> DeviceName { get; set; } = null!;

        /// <summary>
        /// The Kind of the object. Currently only Series8000 is supported
        /// </summary>
        [Input("kind")]
        public Input<Pulumi.AzureNextGen.StorSimple.V20170601.Kind>? Kind { get; set; }

        /// <summary>
        /// The manager name
        /// </summary>
        [Input("managerName", required: true)]
        public Input<string> ManagerName { get; set; } = null!;

        /// <summary>
        /// The monitoring status of the volume.
        /// </summary>
        [Input("monitoringStatus", required: true)]
        public Input<Pulumi.AzureNextGen.StorSimple.V20170601.MonitoringStatus> MonitoringStatus { get; set; } = null!;

        /// <summary>
        /// The resource group name
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The size of the volume in bytes.
        /// </summary>
        [Input("sizeInBytes", required: true)]
        public Input<double> SizeInBytes { get; set; } = null!;

        /// <summary>
        /// The volume container name.
        /// </summary>
        [Input("volumeContainerName", required: true)]
        public Input<string> VolumeContainerName { get; set; } = null!;

        /// <summary>
        /// The volume name.
        /// </summary>
        [Input("volumeName", required: true)]
        public Input<string> VolumeName { get; set; } = null!;

        /// <summary>
        /// The volume status.
        /// </summary>
        [Input("volumeStatus", required: true)]
        public Input<Pulumi.AzureNextGen.StorSimple.V20170601.VolumeStatus> VolumeStatus { get; set; } = null!;

        /// <summary>
        /// The type of the volume.
        /// </summary>
        [Input("volumeType", required: true)]
        public Input<Pulumi.AzureNextGen.StorSimple.V20170601.VolumeType> VolumeType { get; set; } = null!;

        public VolumeArgs()
        {
        }
    }
}
