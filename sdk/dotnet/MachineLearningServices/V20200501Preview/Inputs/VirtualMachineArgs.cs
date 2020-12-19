// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20200501Preview.Inputs
{

    /// <summary>
    /// A Machine Learning compute based on Azure Virtual Machines.
    /// </summary>
    public sealed class VirtualMachineArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Location for the underlying compute
        /// </summary>
        [Input("computeLocation")]
        public Input<string>? ComputeLocation { get; set; }

        /// <summary>
        /// The type of compute
        /// Expected value is 'VirtualMachine'.
        /// </summary>
        [Input("computeType", required: true)]
        public Input<string> ComputeType { get; set; } = null!;

        /// <summary>
        /// The description of the Machine Learning compute.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("properties")]
        public Input<Inputs.VirtualMachinePropertiesArgs>? Properties { get; set; }

        /// <summary>
        /// ARM resource id of the underlying compute
        /// </summary>
        [Input("resourceId")]
        public Input<string>? ResourceId { get; set; }

        public VirtualMachineArgs()
        {
        }
    }
}
