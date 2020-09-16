// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ContainerInstance.V20170801Preview.Outputs
{

    [OutputType]
    public sealed class VolumeResponse
    {
        /// <summary>
        /// The name of the Azure File volume.
        /// </summary>
        public readonly Outputs.AzureFileVolumeResponse AzureFile;
        /// <summary>
        /// The name of the volume.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private VolumeResponse(
            Outputs.AzureFileVolumeResponse azureFile,

            string name)
        {
            AzureFile = azureFile;
            Name = name;
        }
    }
}