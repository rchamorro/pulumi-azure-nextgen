// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.V20180710.Inputs
{

    /// <summary>
    /// Recovery plan A2A input.
    /// </summary>
    public sealed class RecoveryPlanA2AInputArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Gets the Instance type.
        /// Expected value is 'A2A'.
        /// </summary>
        [Input("instanceType")]
        public Input<string>? InstanceType { get; set; }

        /// <summary>
        /// The primary zone.
        /// </summary>
        [Input("primaryZone")]
        public Input<string>? PrimaryZone { get; set; }

        /// <summary>
        /// The recovery zone.
        /// </summary>
        [Input("recoveryZone")]
        public Input<string>? RecoveryZone { get; set; }

        public RecoveryPlanA2AInputArgs()
        {
        }
    }
}
