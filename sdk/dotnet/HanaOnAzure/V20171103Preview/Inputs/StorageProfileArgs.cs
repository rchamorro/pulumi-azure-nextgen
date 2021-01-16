// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.HanaOnAzure.V20171103Preview.Inputs
{

    /// <summary>
    /// Specifies the storage settings for the HANA instance disks.
    /// </summary>
    public sealed class StorageProfileArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// IP Address to connect to storage.
        /// </summary>
        [Input("nfsIpAddress")]
        public Input<string>? NfsIpAddress { get; set; }

        [Input("osDisks")]
        private InputList<Inputs.DiskArgs>? _osDisks;

        /// <summary>
        /// Specifies information about the operating system disk used by the hana instance.
        /// </summary>
        public InputList<Inputs.DiskArgs> OsDisks
        {
            get => _osDisks ?? (_osDisks = new InputList<Inputs.DiskArgs>());
            set => _osDisks = value;
        }

        public StorageProfileArgs()
        {
        }
    }
}
