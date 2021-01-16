// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20170901Preview.Inputs
{

    /// <summary>
    /// Staging settings.
    /// </summary>
    public sealed class StagingSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies whether to use compression when copying data via an interim staging. Default value is false. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        [Input("enableCompression")]
        public Input<object>? EnableCompression { get; set; }

        /// <summary>
        /// Staging linked service reference.
        /// </summary>
        [Input("linkedServiceName", required: true)]
        public Input<Inputs.LinkedServiceReferenceArgs> LinkedServiceName { get; set; } = null!;

        /// <summary>
        /// The path to storage for storing the interim data. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("path")]
        public Input<object>? Path { get; set; }

        public StagingSettingsArgs()
        {
        }
    }
}
