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
    /// Azure specific enable protection input.
    /// </summary>
    public sealed class HyperVReplicaAzureEnableProtectionInputArgs : Pulumi.ResourceArgs
    {
        [Input("disksToInclude")]
        private InputList<string>? _disksToInclude;

        /// <summary>
        /// The list of VHD IDs of disks to be protected.
        /// </summary>
        public InputList<string> DisksToInclude
        {
            get => _disksToInclude ?? (_disksToInclude = new InputList<string>());
            set => _disksToInclude = value;
        }

        /// <summary>
        /// The selected option to enable RDP\SSH on target vm after failover. String value of {SrsDataContract.EnableRDPOnTargetOption} enum.
        /// </summary>
        [Input("enableRdpOnTargetOption")]
        public Input<string>? EnableRdpOnTargetOption { get; set; }

        /// <summary>
        /// The Hyper-V host Vm Id.
        /// </summary>
        [Input("hvHostVmId")]
        public Input<string>? HvHostVmId { get; set; }

        /// <summary>
        /// The class type.
        /// Expected value is 'HyperVReplicaAzure'.
        /// </summary>
        [Input("instanceType")]
        public Input<string>? InstanceType { get; set; }

        /// <summary>
        /// The storage account to be used for logging during replication.
        /// </summary>
        [Input("logStorageAccountId")]
        public Input<string>? LogStorageAccountId { get; set; }

        /// <summary>
        /// The OS type associated with vm.
        /// </summary>
        [Input("osType")]
        public Input<string>? OsType { get; set; }

        /// <summary>
        /// The target availability zone.
        /// </summary>
        [Input("targetAvailabilityZone")]
        public Input<string>? TargetAvailabilityZone { get; set; }

        /// <summary>
        /// The selected target Azure network Id.
        /// </summary>
        [Input("targetAzureNetworkId")]
        public Input<string>? TargetAzureNetworkId { get; set; }

        /// <summary>
        /// The selected target Azure subnet Id.
        /// </summary>
        [Input("targetAzureSubnetId")]
        public Input<string>? TargetAzureSubnetId { get; set; }

        /// <summary>
        /// The Id of the target resource group (for classic deployment) in which the failover VM is to be created.
        /// </summary>
        [Input("targetAzureV1ResourceGroupId")]
        public Input<string>? TargetAzureV1ResourceGroupId { get; set; }

        /// <summary>
        /// The Id of the target resource group (for resource manager deployment) in which the failover VM is to be created.
        /// </summary>
        [Input("targetAzureV2ResourceGroupId")]
        public Input<string>? TargetAzureV2ResourceGroupId { get; set; }

        /// <summary>
        /// The target azure Vm Name.
        /// </summary>
        [Input("targetAzureVmName")]
        public Input<string>? TargetAzureVmName { get; set; }

        /// <summary>
        /// The proximity placement group ARM Id.
        /// </summary>
        [Input("targetProximityPlacementGroupId")]
        public Input<string>? TargetProximityPlacementGroupId { get; set; }

        /// <summary>
        /// The storage account name.
        /// </summary>
        [Input("targetStorageAccountId")]
        public Input<string>? TargetStorageAccountId { get; set; }

        /// <summary>
        /// A value indicating whether managed disks should be used during failover.
        /// </summary>
        [Input("useManagedDisks")]
        public Input<string>? UseManagedDisks { get; set; }

        /// <summary>
        /// The OS disk VHD id associated with vm.
        /// </summary>
        [Input("vhdId")]
        public Input<string>? VhdId { get; set; }

        /// <summary>
        /// The Vm Name.
        /// </summary>
        [Input("vmName")]
        public Input<string>? VmName { get; set; }

        public HyperVReplicaAzureEnableProtectionInputArgs()
        {
        }
    }
}
