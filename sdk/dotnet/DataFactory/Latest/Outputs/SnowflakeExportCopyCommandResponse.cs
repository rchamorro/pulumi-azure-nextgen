// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.Latest.Outputs
{

    [OutputType]
    public sealed class SnowflakeExportCopyCommandResponse
    {
        /// <summary>
        /// Additional copy options directly passed to snowflake Copy Command. Type: key value pairs (value should be string type) (or Expression with resultType object). Example: "additionalCopyOptions": { "DATE_FORMAT": "MM/DD/YYYY", "TIME_FORMAT": "'HH24:MI:SS.FF'" }
        /// </summary>
        public readonly ImmutableDictionary<string, object>? AdditionalCopyOptions;
        /// <summary>
        /// Additional format options directly passed to snowflake Copy Command. Type: key value pairs (value should be string type) (or Expression with resultType object). Example: "additionalFormatOptions": { "OVERWRITE": "TRUE", "MAX_FILE_SIZE": "'FALSE'" }
        /// </summary>
        public readonly ImmutableDictionary<string, object>? AdditionalFormatOptions;
        /// <summary>
        /// The export setting type.
        /// Expected value is 'SnowflakeExportCopyCommand'.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private SnowflakeExportCopyCommandResponse(
            ImmutableDictionary<string, object>? additionalCopyOptions,

            ImmutableDictionary<string, object>? additionalFormatOptions,

            string type)
        {
            AdditionalCopyOptions = additionalCopyOptions;
            AdditionalFormatOptions = additionalFormatOptions;
            Type = type;
        }
    }
}
