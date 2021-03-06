// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.AppPlatform.V20190501Preview.Inputs
{

    /// <summary>
    /// Trace properties payload
    /// </summary>
    public sealed class TracePropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Target application insight instrumentation key
        /// </summary>
        [Input("appInsightInstrumentationKey")]
        public Input<string>? AppInsightInstrumentationKey { get; set; }

        /// <summary>
        /// Indicates whether enable the tracing functionality
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Error when apply trace proxy changes.
        /// </summary>
        [Input("error")]
        public Input<Inputs.ErrorArgs>? Error { get; set; }

        public TracePropertiesArgs()
        {
        }
    }
}
