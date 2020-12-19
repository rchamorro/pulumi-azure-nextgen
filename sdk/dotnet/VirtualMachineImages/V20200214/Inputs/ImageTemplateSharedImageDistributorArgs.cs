// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.VirtualMachineImages.V20200214.Inputs
{

    /// <summary>
    /// Distribute via Shared Image Gallery.
    /// </summary>
    public sealed class ImageTemplateSharedImageDistributorArgs : Pulumi.ResourceArgs
    {
        [Input("artifactTags")]
        private InputMap<string>? _artifactTags;

        /// <summary>
        /// Tags that will be applied to the artifact once it has been created/updated by the distributor.
        /// </summary>
        public InputMap<string> ArtifactTags
        {
            get => _artifactTags ?? (_artifactTags = new InputMap<string>());
            set => _artifactTags = value;
        }

        /// <summary>
        /// Flag that indicates whether created image version should be excluded from latest. Omit to use the default (false).
        /// </summary>
        [Input("excludeFromLatest")]
        public Input<bool>? ExcludeFromLatest { get; set; }

        /// <summary>
        /// Resource Id of the Shared Image Gallery image
        /// </summary>
        [Input("galleryImageId", required: true)]
        public Input<string> GalleryImageId { get; set; } = null!;

        [Input("replicationRegions", required: true)]
        private InputList<string>? _replicationRegions;

        /// <summary>
        /// A list of regions that the image will be replicated to
        /// </summary>
        public InputList<string> ReplicationRegions
        {
            get => _replicationRegions ?? (_replicationRegions = new InputList<string>());
            set => _replicationRegions = value;
        }

        /// <summary>
        /// The name to be used for the associated RunOutput.
        /// </summary>
        [Input("runOutputName", required: true)]
        public Input<string> RunOutputName { get; set; } = null!;

        /// <summary>
        /// Storage account type to be used to store the shared image. Omit to use the default (Standard_LRS).
        /// </summary>
        [Input("storageAccountType")]
        public InputUnion<string, Pulumi.AzureNextGen.VirtualMachineImages.V20200214.SharedImageStorageAccountType>? StorageAccountType { get; set; }

        /// <summary>
        /// Type of distribution.
        /// Expected value is 'SharedImage'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public ImageTemplateSharedImageDistributorArgs()
        {
        }
    }
}
