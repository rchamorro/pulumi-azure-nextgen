// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.V20180701.Inputs
{

    /// <summary>
    /// Describes a list of inputs to a Job.
    /// </summary>
    public sealed class JobInputsArgs : Pulumi.ResourceArgs
    {
        [Input("inputs")]
        private InputList<object>? _inputs;

        /// <summary>
        /// List of inputs to a Job.
        /// </summary>
        public InputList<object> Inputs
        {
            get => _inputs ?? (_inputs = new InputList<object>());
            set => _inputs = value;
        }

        /// <summary>
        /// The discriminator for derived types.
        /// Expected value is '#Microsoft.Media.JobInputs'.
        /// </summary>
        [Input("odataType", required: true)]
        public Input<string> OdataType { get; set; } = null!;

        public JobInputsArgs()
        {
        }
    }
}
