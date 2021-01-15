// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearning.V20170101.Inputs
{

    /// <summary>
    /// Asset input port
    /// </summary>
    public sealed class InputPortArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Port data type.
        /// </summary>
        [Input("type")]
        public InputUnion<string, Pulumi.AzureNextGen.MachineLearning.V20170101.InputPortType>? Type { get; set; }

        public InputPortArgs()
        {
            Type = "Dataset";
        }
    }
}
