// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.V20201001.Inputs
{

    /// <summary>
    /// Extended information of the container.
    /// </summary>
    public sealed class AzureWorkloadContainerExtendedInfoArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Host Os Name in case of Stand Alone and Cluster Name in case of distributed container.
        /// </summary>
        [Input("hostServerName")]
        public Input<string>? HostServerName { get; set; }

        /// <summary>
        /// Inquiry Status for the container.
        /// </summary>
        [Input("inquiryInfo")]
        public Input<Inputs.InquiryInfoArgs>? InquiryInfo { get; set; }

        [Input("nodesList")]
        private InputList<Inputs.DistributedNodesInfoArgs>? _nodesList;

        /// <summary>
        /// List of the nodes in case of distributed container.
        /// </summary>
        public InputList<Inputs.DistributedNodesInfoArgs> NodesList
        {
            get => _nodesList ?? (_nodesList = new InputList<Inputs.DistributedNodesInfoArgs>());
            set => _nodesList = value;
        }

        public AzureWorkloadContainerExtendedInfoArgs()
        {
        }
    }
}