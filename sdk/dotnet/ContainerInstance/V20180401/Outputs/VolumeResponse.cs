// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ContainerInstance.V20180401.Outputs
{

    [OutputType]
    public sealed class VolumeResponse
    {
        /// <summary>
        /// The Azure File volume.
        /// </summary>
        public readonly Outputs.AzureFileVolumeResponse? AzureFile;
        /// <summary>
        /// The empty directory volume.
        /// </summary>
        public readonly object? EmptyDir;
        /// <summary>
        /// The git repo volume.
        /// </summary>
        public readonly Outputs.GitRepoVolumeResponse? GitRepo;
        /// <summary>
        /// The name of the volume.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The secret volume.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Secret;

        [OutputConstructor]
        private VolumeResponse(
            Outputs.AzureFileVolumeResponse? azureFile,

            object? emptyDir,

            Outputs.GitRepoVolumeResponse? gitRepo,

            string name,

            ImmutableDictionary<string, string>? secret)
        {
            AzureFile = azureFile;
            EmptyDir = emptyDir;
            GitRepo = gitRepo;
            Name = name;
            Secret = secret;
        }
    }
}
