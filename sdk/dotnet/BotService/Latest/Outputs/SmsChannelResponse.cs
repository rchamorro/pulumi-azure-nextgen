// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.BotService.Latest.Outputs
{

    [OutputType]
    public sealed class SmsChannelResponse
    {
        /// <summary>
        /// The channel name
        /// Expected value is 'SmsChannel'.
        /// </summary>
        public readonly string ChannelName;
        /// <summary>
        /// The set of properties specific to Sms channel resource
        /// </summary>
        public readonly Outputs.SmsChannelPropertiesResponse? Properties;

        [OutputConstructor]
        private SmsChannelResponse(
            string channelName,

            Outputs.SmsChannelPropertiesResponse? properties)
        {
            ChannelName = channelName;
            Properties = properties;
        }
    }
}
