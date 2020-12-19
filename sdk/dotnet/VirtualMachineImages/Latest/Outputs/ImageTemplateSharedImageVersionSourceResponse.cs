// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.VirtualMachineImages.Latest.Outputs
{

    [OutputType]
    public sealed class ImageTemplateSharedImageVersionSourceResponse
    {
        /// <summary>
        /// ARM resource id of the image version in the shared image gallery
        /// </summary>
        public readonly string ImageVersionId;
        /// <summary>
        /// Specifies the type of source image you want to start with.
        /// Expected value is 'SharedImageVersion'.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ImageTemplateSharedImageVersionSourceResponse(
            string imageVersionId,

            string type)
        {
            ImageVersionId = imageVersionId;
            Type = type;
        }
    }
}
