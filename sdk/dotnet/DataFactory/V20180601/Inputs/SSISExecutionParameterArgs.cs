// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20180601.Inputs
{

    /// <summary>
    /// SSIS execution parameter.
    /// </summary>
    public sealed class SSISExecutionParameterArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// SSIS package execution parameter value. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("value", required: true)]
        public Input<object> Value { get; set; } = null!;

        public SSISExecutionParameterArgs()
        {
        }
    }
}
