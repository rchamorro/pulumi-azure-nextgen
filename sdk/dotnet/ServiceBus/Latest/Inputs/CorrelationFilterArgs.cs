// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ServiceBus.Latest.Inputs
{

    /// <summary>
    /// Represents the correlation filter expression.
    /// </summary>
    public sealed class CorrelationFilterArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Content type of the message.
        /// </summary>
        [Input("contentType")]
        public Input<string>? ContentType { get; set; }

        /// <summary>
        /// Identifier of the correlation.
        /// </summary>
        [Input("correlationId")]
        public Input<string>? CorrelationId { get; set; }

        /// <summary>
        /// Application specific label.
        /// </summary>
        [Input("label")]
        public Input<string>? Label { get; set; }

        /// <summary>
        /// Identifier of the message.
        /// </summary>
        [Input("messageId")]
        public Input<string>? MessageId { get; set; }

        [Input("properties")]
        private InputMap<string>? _properties;

        /// <summary>
        /// dictionary object for custom filters
        /// </summary>
        public InputMap<string> Properties
        {
            get => _properties ?? (_properties = new InputMap<string>());
            set => _properties = value;
        }

        /// <summary>
        /// Address of the queue to reply to.
        /// </summary>
        [Input("replyTo")]
        public Input<string>? ReplyTo { get; set; }

        /// <summary>
        /// Session identifier to reply to.
        /// </summary>
        [Input("replyToSessionId")]
        public Input<string>? ReplyToSessionId { get; set; }

        /// <summary>
        /// Value that indicates whether the rule action requires preprocessing.
        /// </summary>
        [Input("requiresPreprocessing")]
        public Input<bool>? RequiresPreprocessing { get; set; }

        /// <summary>
        /// Session identifier.
        /// </summary>
        [Input("sessionId")]
        public Input<string>? SessionId { get; set; }

        /// <summary>
        /// Address to send to.
        /// </summary>
        [Input("to")]
        public Input<string>? To { get; set; }

        public CorrelationFilterArgs()
        {
            RequiresPreprocessing = true;
        }
    }
}
