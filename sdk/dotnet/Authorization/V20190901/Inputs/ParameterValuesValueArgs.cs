// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Authorization.V20190901.Inputs
{

    /// <summary>
    /// The value of a parameter.
    /// </summary>
    public sealed class ParameterValuesValueArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The value of the parameter.
        /// </summary>
        [Input("value")]
        public Input<object>? Value { get; set; }

        public ParameterValuesValueArgs()
        {
        }
    }
}
