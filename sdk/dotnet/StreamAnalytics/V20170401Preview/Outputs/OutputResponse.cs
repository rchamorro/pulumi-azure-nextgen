// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.StreamAnalytics.V20170401Preview.Outputs
{

    [OutputType]
    public sealed class OutputResponse
    {
        /// <summary>
        /// Describes the data source that output will be written to. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        public readonly object? Datasource;
        /// <summary>
        /// Describes conditions applicable to the Input, Output, or the job overall, that warrant customer attention.
        /// </summary>
        public readonly Outputs.DiagnosticsResponse Diagnostics;
        /// <summary>
        /// The current entity tag for the output. This is an opaque string. You can use it to detect whether the resource has changed between requests. You can also use it in the If-Match or If-None-Match headers for write operations for optimistic concurrency.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Resource Id
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Describes how data from an input is serialized or how data is serialized when written to an output. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        public readonly object? Serialization;
        public readonly double? SizeWindow;
        public readonly string? TimeWindow;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private OutputResponse(
            object? datasource,

            Outputs.DiagnosticsResponse diagnostics,

            string etag,

            string id,

            string? name,

            object? serialization,

            double? sizeWindow,

            string? timeWindow,

            string type)
        {
            Datasource = datasource;
            Diagnostics = diagnostics;
            Etag = etag;
            Id = id;
            Name = name;
            Serialization = serialization;
            SizeWindow = sizeWindow;
            TimeWindow = timeWindow;
            Type = type;
        }
    }
}
