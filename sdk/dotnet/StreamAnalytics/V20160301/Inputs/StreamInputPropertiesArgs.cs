// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.StreamAnalytics.V20160301.Inputs
{

    /// <summary>
    /// The properties that are associated with an input containing stream data.
    /// </summary>
    public sealed class StreamInputPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Describes an input data source that contains stream data. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        [Input("datasource")]
        public InputUnion<Inputs.BlobStreamInputDataSourceArgs, InputUnion<Inputs.EventHubStreamInputDataSourceArgs, Inputs.IoTHubStreamInputDataSourceArgs>>? Datasource { get; set; }

        /// <summary>
        /// Describes how data from an input is serialized or how data is serialized when written to an output. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        [Input("serialization")]
        public InputUnion<Inputs.AvroSerializationArgs, InputUnion<Inputs.CsvSerializationArgs, Inputs.JsonSerializationArgs>>? Serialization { get; set; }

        /// <summary>
        /// Indicates whether the input is a source of reference data or stream data. Required on PUT (CreateOrReplace) requests.
        /// Expected value is 'Stream'.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public StreamInputPropertiesArgs()
        {
        }
    }
}
