// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.Latest.Inputs
{

    /// <summary>
    /// A copy activity source for an Office 365 service.
    /// </summary>
    public sealed class Office365SourceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The groups containing all the users. Type: array of strings (or Expression with resultType array of strings).
        /// </summary>
        [Input("allowedGroups")]
        public Input<object>? AllowedGroups { get; set; }

        /// <summary>
        /// The Column to apply the &lt;paramref name="StartTime"/&gt; and &lt;paramref name="EndTime"/&gt;. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("dateFilterColumn")]
        public Input<object>? DateFilterColumn { get; set; }

        /// <summary>
        /// End time of the requested range for this dataset. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("endTime")]
        public Input<object>? EndTime { get; set; }

        /// <summary>
        /// The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer).
        /// </summary>
        [Input("maxConcurrentConnections")]
        public Input<object>? MaxConcurrentConnections { get; set; }

        /// <summary>
        /// The columns to be read out from the Office 365 table. Type: array of objects (or Expression with resultType array of objects). Example: [ { "name": "Id" }, { "name": "CreatedDateTime" } ]
        /// </summary>
        [Input("outputColumns")]
        public Input<object>? OutputColumns { get; set; }

        /// <summary>
        /// Source retry count. Type: integer (or Expression with resultType integer).
        /// </summary>
        [Input("sourceRetryCount")]
        public Input<object>? SourceRetryCount { get; set; }

        /// <summary>
        /// Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        [Input("sourceRetryWait")]
        public Input<object>? SourceRetryWait { get; set; }

        /// <summary>
        /// Start time of the requested range for this dataset. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("startTime")]
        public Input<object>? StartTime { get; set; }

        /// <summary>
        /// Copy source type.
        /// Expected value is 'Office365Source'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// The user scope uri. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("userScopeFilterUri")]
        public Input<object>? UserScopeFilterUri { get; set; }

        public Office365SourceArgs()
        {
        }
    }
}
