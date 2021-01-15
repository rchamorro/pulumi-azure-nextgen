// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20200601.Inputs
{

    /// <summary>
    /// AML Compute properties
    /// </summary>
    public sealed class AmlComputePropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// State of the public SSH port. Possible values are: Disabled - Indicates that the public ssh port is closed on all nodes of the cluster. Enabled - Indicates that the public ssh port is open on all nodes of the cluster. NotSpecified - Indicates that the public ssh port is closed on all nodes of the cluster if VNet is defined, else is open all public nodes. It can be default only during cluster creation time, after creation it will be either enabled or disabled.
        /// </summary>
        [Input("remoteLoginPortPublicAccess")]
        public InputUnion<string, Pulumi.AzureNextGen.MachineLearningServices.V20200601.RemoteLoginPortPublicAccess>? RemoteLoginPortPublicAccess { get; set; }

        /// <summary>
        /// Scale settings for AML Compute
        /// </summary>
        [Input("scaleSettings")]
        public Input<Inputs.ScaleSettingsArgs>? ScaleSettings { get; set; }

        /// <summary>
        /// Virtual network subnet resource ID the compute nodes belong to.
        /// </summary>
        [Input("subnet")]
        public Input<Inputs.ResourceIdArgs>? Subnet { get; set; }

        /// <summary>
        /// Credentials for an administrator user account that will be created on each compute node.
        /// </summary>
        [Input("userAccountCredentials")]
        public Input<Inputs.UserAccountCredentialsArgs>? UserAccountCredentials { get; set; }

        /// <summary>
        /// Virtual Machine priority
        /// </summary>
        [Input("vmPriority")]
        public InputUnion<string, Pulumi.AzureNextGen.MachineLearningServices.V20200601.VmPriority>? VmPriority { get; set; }

        /// <summary>
        /// Virtual Machine Size
        /// </summary>
        [Input("vmSize")]
        public Input<string>? VmSize { get; set; }

        public AmlComputePropertiesArgs()
        {
            RemoteLoginPortPublicAccess = "NotSpecified";
        }
    }
}
