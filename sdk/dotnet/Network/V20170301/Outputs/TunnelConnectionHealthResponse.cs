// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20170301.Outputs
{

    [OutputType]
    public sealed class TunnelConnectionHealthResponse
    {
        /// <summary>
        /// Virtual network Gateway connection status
        /// </summary>
        public readonly string ConnectionStatus;
        /// <summary>
        /// The Egress Bytes Transferred in this connection
        /// </summary>
        public readonly double EgressBytesTransferred;
        /// <summary>
        /// The Ingress Bytes Transferred in this connection
        /// </summary>
        public readonly double IngressBytesTransferred;
        /// <summary>
        /// The time at which connection was established in Utc format.
        /// </summary>
        public readonly string LastConnectionEstablishedUtcTime;
        /// <summary>
        /// Tunnel name.
        /// </summary>
        public readonly string Tunnel;

        [OutputConstructor]
        private TunnelConnectionHealthResponse(
            string connectionStatus,

            double egressBytesTransferred,

            double ingressBytesTransferred,

            string lastConnectionEstablishedUtcTime,

            string tunnel)
        {
            ConnectionStatus = connectionStatus;
            EgressBytesTransferred = egressBytesTransferred;
            IngressBytesTransferred = ingressBytesTransferred;
            LastConnectionEstablishedUtcTime = lastConnectionEstablishedUtcTime;
            Tunnel = tunnel;
        }
    }
}
