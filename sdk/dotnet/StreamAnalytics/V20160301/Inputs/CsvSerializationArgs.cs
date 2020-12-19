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
    /// Describes how data from an input is serialized or how data is serialized when written to an output in CSV format.
    /// </summary>
    public sealed class CsvSerializationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the encoding of the incoming data in the case of input and the encoding of outgoing data in the case of output. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        [Input("encoding")]
        public InputUnion<string, Pulumi.AzureNextGen.StreamAnalytics.V20160301.Encoding>? Encoding { get; set; }

        /// <summary>
        /// Specifies the delimiter that will be used to separate comma-separated value (CSV) records. See https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-input or https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-output for a list of supported values. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        [Input("fieldDelimiter")]
        public Input<string>? FieldDelimiter { get; set; }

        /// <summary>
        /// Indicates the type of serialization that the input or output uses. Required on PUT (CreateOrReplace) requests.
        /// Expected value is 'Csv'.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public CsvSerializationArgs()
        {
        }
    }
}
