// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20180601.Outputs
{

    [OutputType]
    public sealed class HdfsSourceResponse
    {
        /// <summary>
        /// Specifies Distcp-related settings.
        /// </summary>
        public readonly Outputs.DistcpSettingsResponse? DistcpSettings;
        /// <summary>
        /// The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer).
        /// </summary>
        public readonly object? MaxConcurrentConnections;
        /// <summary>
        /// If true, files under the folder path will be read recursively. Default is true. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        public readonly object? Recursive;
        /// <summary>
        /// Source retry count. Type: integer (or Expression with resultType integer).
        /// </summary>
        public readonly object? SourceRetryCount;
        /// <summary>
        /// Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        public readonly object? SourceRetryWait;
        /// <summary>
        /// Copy source type.
        /// Expected value is 'HdfsSource'.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private HdfsSourceResponse(
            Outputs.DistcpSettingsResponse? distcpSettings,

            object? maxConcurrentConnections,

            object? recursive,

            object? sourceRetryCount,

            object? sourceRetryWait,

            string type)
        {
            DistcpSettings = distcpSettings;
            MaxConcurrentConnections = maxConcurrentConnections;
            Recursive = recursive;
            SourceRetryCount = sourceRetryCount;
            SourceRetryWait = sourceRetryWait;
            Type = type;
        }
    }
}
