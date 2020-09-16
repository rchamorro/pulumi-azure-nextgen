// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.StreamAnalytics.Latest.Outputs
{

    [OutputType]
    public sealed class BlobStreamInputDataSourceResponse
    {
        /// <summary>
        /// The name of a container within the associated Storage account. This container contains either the blob(s) to be read from or written to. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        public readonly string? Container;
        /// <summary>
        /// The date format. Wherever {date} appears in pathPattern, the value of this property is used as the date format instead.
        /// </summary>
        public readonly string? DateFormat;
        /// <summary>
        /// The blob path pattern. Not a regular expression. It represents a pattern against which blob names will be matched to determine whether or not they should be included as input or output to the job. See https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-input or https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-output for a more detailed explanation and example.
        /// </summary>
        public readonly string? PathPattern;
        /// <summary>
        /// The partition count of the blob input data source. Range 1 - 256.
        /// </summary>
        public readonly int? SourcePartitionCount;
        /// <summary>
        /// A list of one or more Azure Storage accounts. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        public readonly ImmutableArray<Outputs.StorageAccountResponse> StorageAccounts;
        /// <summary>
        /// The time format. Wherever {time} appears in pathPattern, the value of this property is used as the time format instead.
        /// </summary>
        public readonly string? TimeFormat;
        /// <summary>
        /// Indicates the type of input data source containing stream data. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private BlobStreamInputDataSourceResponse(
            string? container,

            string? dateFormat,

            string? pathPattern,

            int? sourcePartitionCount,

            ImmutableArray<Outputs.StorageAccountResponse> storageAccounts,

            string? timeFormat,

            string? type)
        {
            Container = container;
            DateFormat = dateFormat;
            PathPattern = pathPattern;
            SourcePartitionCount = sourcePartitionCount;
            StorageAccounts = storageAccounts;
            TimeFormat = timeFormat;
            Type = type;
        }
    }
}