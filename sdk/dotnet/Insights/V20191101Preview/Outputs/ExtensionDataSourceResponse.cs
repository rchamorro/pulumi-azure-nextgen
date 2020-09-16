// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Insights.V20191101Preview.Outputs
{

    [OutputType]
    public sealed class ExtensionDataSourceResponse
    {
        /// <summary>
        /// The name of the VM extension.
        /// </summary>
        public readonly string ExtensionName;
        /// <summary>
        /// The extension settings. The format is specific for particular extension.
        /// </summary>
        public readonly ImmutableDictionary<string, object>? ExtensionSettings;
        /// <summary>
        /// A friendly name for the data source. 
        /// This name should be unique across all data sources (regardless of type) within the data collection rule.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// List of streams that this data source will be sent to.
        /// A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.
        /// </summary>
        public readonly ImmutableArray<string> Streams;

        [OutputConstructor]
        private ExtensionDataSourceResponse(
            string extensionName,

            ImmutableDictionary<string, object>? extensionSettings,

            string name,

            ImmutableArray<string> streams)
        {
            ExtensionName = extensionName;
            ExtensionSettings = extensionSettings;
            Name = name;
            Streams = streams;
        }
    }
}