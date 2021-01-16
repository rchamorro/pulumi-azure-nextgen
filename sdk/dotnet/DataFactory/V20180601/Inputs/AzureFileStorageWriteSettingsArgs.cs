// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20180601.Inputs
{

    /// <summary>
    /// Azure File Storage write settings.
    /// </summary>
    public sealed class AzureFileStorageWriteSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The type of copy behavior for copy sink.
        /// </summary>
        [Input("copyBehavior")]
        public Input<object>? CopyBehavior { get; set; }

        /// <summary>
        /// The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer).
        /// </summary>
        [Input("maxConcurrentConnections")]
        public Input<object>? MaxConcurrentConnections { get; set; }

        /// <summary>
        /// The write setting type.
        /// Expected value is 'AzureFileStorageWriteSettings'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public AzureFileStorageWriteSettingsArgs()
        {
        }
    }
}
