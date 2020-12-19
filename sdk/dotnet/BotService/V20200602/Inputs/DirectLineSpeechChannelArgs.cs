// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.BotService.V20200602.Inputs
{

    /// <summary>
    /// DirectLine Speech channel definition
    /// </summary>
    public sealed class DirectLineSpeechChannelArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The channel name
        /// Expected value is 'DirectLineSpeechChannel'.
        /// </summary>
        [Input("channelName", required: true)]
        public Input<string> ChannelName { get; set; } = null!;

        /// <summary>
        /// The set of properties specific to DirectLine Speech channel resource
        /// </summary>
        [Input("properties")]
        public Input<Inputs.DirectLineSpeechChannelPropertiesArgs>? Properties { get; set; }

        public DirectLineSpeechChannelArgs()
        {
        }
    }
}
