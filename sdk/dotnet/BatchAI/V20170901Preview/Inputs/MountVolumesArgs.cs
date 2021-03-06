// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.BatchAI.V20170901Preview.Inputs
{

    /// <summary>
    /// Details of volumes to mount on the cluster.
    /// </summary>
    public sealed class MountVolumesArgs : Pulumi.ResourceArgs
    {
        [Input("azureBlobFileSystems")]
        private InputList<Inputs.AzureBlobFileSystemReferenceArgs>? _azureBlobFileSystems;

        /// <summary>
        /// References to Azure Blob FUSE that are to be mounted to the cluster nodes.
        /// </summary>
        public InputList<Inputs.AzureBlobFileSystemReferenceArgs> AzureBlobFileSystems
        {
            get => _azureBlobFileSystems ?? (_azureBlobFileSystems = new InputList<Inputs.AzureBlobFileSystemReferenceArgs>());
            set => _azureBlobFileSystems = value;
        }

        [Input("azureFileShares")]
        private InputList<Inputs.AzureFileShareReferenceArgs>? _azureFileShares;

        /// <summary>
        /// References to Azure File Shares that are to be mounted to the cluster nodes.
        /// </summary>
        public InputList<Inputs.AzureFileShareReferenceArgs> AzureFileShares
        {
            get => _azureFileShares ?? (_azureFileShares = new InputList<Inputs.AzureFileShareReferenceArgs>());
            set => _azureFileShares = value;
        }

        [Input("fileServers")]
        private InputList<Inputs.FileServerReferenceArgs>? _fileServers;
        public InputList<Inputs.FileServerReferenceArgs> FileServers
        {
            get => _fileServers ?? (_fileServers = new InputList<Inputs.FileServerReferenceArgs>());
            set => _fileServers = value;
        }

        [Input("unmanagedFileSystems")]
        private InputList<Inputs.UnmanagedFileSystemReferenceArgs>? _unmanagedFileSystems;
        public InputList<Inputs.UnmanagedFileSystemReferenceArgs> UnmanagedFileSystems
        {
            get => _unmanagedFileSystems ?? (_unmanagedFileSystems = new InputList<Inputs.UnmanagedFileSystemReferenceArgs>());
            set => _unmanagedFileSystems = value;
        }

        public MountVolumesArgs()
        {
        }
    }
}
