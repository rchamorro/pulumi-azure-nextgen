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
    /// Email channel definition
    /// </summary>
    public sealed class EmailChannelArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The channel name
        /// Expected value is 'EmailChannel'.
        /// </summary>
        [Input("channelName", required: true)]
        public Input<string> ChannelName { get; set; } = null!;

        /// <summary>
        /// The set of properties specific to email channel resource
        /// </summary>
        [Input("properties")]
        public Input<Inputs.EmailChannelPropertiesArgs>? Properties { get; set; }

        public EmailChannelArgs()
        {
        }
    }
}
