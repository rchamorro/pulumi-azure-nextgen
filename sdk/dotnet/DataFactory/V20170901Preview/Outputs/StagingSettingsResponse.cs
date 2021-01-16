// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20170901Preview.Outputs
{

    [OutputType]
    public sealed class StagingSettingsResponse
    {
        /// <summary>
        /// Specifies whether to use compression when copying data via an interim staging. Default value is false. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        public readonly object? EnableCompression;
        /// <summary>
        /// Staging linked service reference.
        /// </summary>
        public readonly Outputs.LinkedServiceReferenceResponse LinkedServiceName;
        /// <summary>
        /// The path to storage for storing the interim data. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? Path;

        [OutputConstructor]
        private StagingSettingsResponse(
            object? enableCompression,

            Outputs.LinkedServiceReferenceResponse linkedServiceName,

            object? path)
        {
            EnableCompression = enableCompression;
            LinkedServiceName = linkedServiceName;
            Path = path;
        }
    }
}
