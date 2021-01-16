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
    /// A copy activity Salesforce sink.
    /// </summary>
    public sealed class SalesforceSinkArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the external ID field for upsert operation. Default value is 'Id' column. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("externalIdFieldName")]
        public Input<object>? ExternalIdFieldName { get; set; }

        /// <summary>
        /// The flag indicating whether or not to ignore null values from input dataset (except key fields) during write operation. Default value is false. If set it to true, it means ADF will leave the data in the destination object unchanged when doing upsert/update operation and insert defined default value when doing insert operation, versus ADF will update the data in the destination object to NULL when doing upsert/update operation and insert NULL value when doing insert operation. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        [Input("ignoreNullValues")]
        public Input<object>? IgnoreNullValues { get; set; }

        /// <summary>
        /// Sink retry count. Type: integer (or Expression with resultType integer).
        /// </summary>
        [Input("sinkRetryCount")]
        public Input<object>? SinkRetryCount { get; set; }

        /// <summary>
        /// Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        [Input("sinkRetryWait")]
        public Input<object>? SinkRetryWait { get; set; }

        /// <summary>
        /// Copy sink type.
        /// Expected value is 'SalesforceSink'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// Write batch size. Type: integer (or Expression with resultType integer), minimum: 0.
        /// </summary>
        [Input("writeBatchSize")]
        public Input<object>? WriteBatchSize { get; set; }

        /// <summary>
        /// Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        [Input("writeBatchTimeout")]
        public Input<object>? WriteBatchTimeout { get; set; }

        /// <summary>
        /// The write behavior for the operation. Default is Insert.
        /// </summary>
        [Input("writeBehavior")]
        public InputUnion<string, Pulumi.AzureNextGen.DataFactory.V20170901Preview.SalesforceSinkWriteBehavior>? WriteBehavior { get; set; }

        public SalesforceSinkArgs()
        {
        }
    }
}
