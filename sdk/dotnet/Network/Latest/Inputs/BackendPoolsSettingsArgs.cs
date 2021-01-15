// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.Latest.Inputs
{

    /// <summary>
    /// Settings that apply to all backend pools.
    /// </summary>
    public sealed class BackendPoolsSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether to enforce certificate name check on HTTPS requests to all backend pools. No effect on non-HTTPS requests.
        /// </summary>
        [Input("enforceCertificateNameCheck")]
        public InputUnion<string, Pulumi.AzureNextGen.Network.Latest.EnforceCertificateNameCheckEnabledState>? EnforceCertificateNameCheck { get; set; }

        /// <summary>
        /// Send and receive timeout on forwarding request to the backend. When timeout is reached, the request fails and returns.
        /// </summary>
        [Input("sendRecvTimeoutSeconds")]
        public Input<int>? SendRecvTimeoutSeconds { get; set; }

        public BackendPoolsSettingsArgs()
        {
            EnforceCertificateNameCheck = "Enabled";
        }
    }
}
