// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Storage.V20190601.Inputs
{

    /// <summary>
    /// The replication policy rule between two containers.
    /// </summary>
    public sealed class ObjectReplicationPolicyRuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Required. Destination container name.
        /// </summary>
        [Input("destinationContainer", required: true)]
        public Input<string> DestinationContainer { get; set; } = null!;

        /// <summary>
        /// Optional. An object that defines the filter set.
        /// </summary>
        [Input("filters")]
        public Input<Inputs.ObjectReplicationPolicyFilterArgs>? Filters { get; set; }

        /// <summary>
        /// Rule Id is auto-generated for each new rule on destination account. It is required for put policy on source account.
        /// </summary>
        [Input("ruleId")]
        public Input<string>? RuleId { get; set; }

        /// <summary>
        /// Required. Source container name.
        /// </summary>
        [Input("sourceContainer", required: true)]
        public Input<string> SourceContainer { get; set; } = null!;

        public ObjectReplicationPolicyRuleArgs()
        {
        }
    }
}