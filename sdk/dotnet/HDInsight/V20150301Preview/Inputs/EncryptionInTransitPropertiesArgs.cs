// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.HDInsight.V20150301Preview.Inputs
{

    /// <summary>
    /// The encryption-in-transit properties.
    /// </summary>
    public sealed class EncryptionInTransitPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Indicates whether or not inter cluster node communication is encrypted in transit.
        /// </summary>
        [Input("isEncryptionInTransitEnabled")]
        public Input<bool>? IsEncryptionInTransitEnabled { get; set; }

        public EncryptionInTransitPropertiesArgs()
        {
            IsEncryptionInTransitEnabled = false;
        }
    }
}
