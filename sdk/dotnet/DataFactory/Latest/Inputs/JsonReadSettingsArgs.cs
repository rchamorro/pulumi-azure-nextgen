// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.Latest.Inputs
{

    /// <summary>
    /// Json read settings.
    /// </summary>
    public sealed class JsonReadSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Compression settings.
        /// </summary>
        [Input("compressionProperties")]
        public Input<object>? CompressionProperties { get; set; }

        /// <summary>
        /// The read setting type.
        /// Expected value is 'JsonReadSettings'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public JsonReadSettingsArgs()
        {
        }
    }
}
