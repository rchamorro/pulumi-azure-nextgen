// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20170901.Inputs
{

    /// <summary>
    /// An SOA record.
    /// </summary>
    public sealed class SoaRecordArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The email contact for this SOA record.
        /// </summary>
        [Input("email")]
        public Input<string>? Email { get; set; }

        /// <summary>
        /// The expire time for this SOA record.
        /// </summary>
        [Input("expireTime")]
        public Input<int>? ExpireTime { get; set; }

        /// <summary>
        /// The domain name of the authoritative name server for this SOA record.
        /// </summary>
        [Input("host")]
        public Input<string>? Host { get; set; }

        /// <summary>
        /// The minimum value for this SOA record. By convention this is used to determine the negative caching duration.
        /// </summary>
        [Input("minimumTtl")]
        public Input<int>? MinimumTtl { get; set; }

        /// <summary>
        /// The refresh value for this SOA record.
        /// </summary>
        [Input("refreshTime")]
        public Input<int>? RefreshTime { get; set; }

        /// <summary>
        /// The retry time for this SOA record.
        /// </summary>
        [Input("retryTime")]
        public Input<int>? RetryTime { get; set; }

        /// <summary>
        /// The serial number for this SOA record.
        /// </summary>
        [Input("serialNumber")]
        public Input<int>? SerialNumber { get; set; }

        public SoaRecordArgs()
        {
        }
    }
}