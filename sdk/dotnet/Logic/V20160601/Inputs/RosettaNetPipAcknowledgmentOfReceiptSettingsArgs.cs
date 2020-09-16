// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Logic.V20160601.Inputs
{

    /// <summary>
    /// The integration account RosettaNet ProcessConfiguration Acknowledgement settings.
    /// </summary>
    public sealed class RosettaNetPipAcknowledgmentOfReceiptSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The non-repudiation is required or not.
        /// </summary>
        [Input("isNonRepudiationRequired", required: true)]
        public Input<bool> IsNonRepudiationRequired { get; set; } = null!;

        /// <summary>
        /// The time to acknowledge in seconds.
        /// </summary>
        [Input("timeToAcknowledgeInSeconds", required: true)]
        public Input<int> TimeToAcknowledgeInSeconds { get; set; } = null!;

        public RosettaNetPipAcknowledgmentOfReceiptSettingsArgs()
        {
        }
    }
}