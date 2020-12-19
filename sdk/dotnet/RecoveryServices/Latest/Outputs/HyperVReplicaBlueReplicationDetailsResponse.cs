// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.Latest.Outputs
{

    [OutputType]
    public sealed class HyperVReplicaBlueReplicationDetailsResponse
    {
        /// <summary>
        /// Initial replication details.
        /// </summary>
        public readonly Outputs.InitialReplicationDetailsResponse? InitialReplicationDetails;
        /// <summary>
        /// Gets the Instance type.
        /// Expected value is 'HyperVReplica2012R2'.
        /// </summary>
        public readonly string InstanceType;
        /// <summary>
        /// The Last replication time.
        /// </summary>
        public readonly string? LastReplicatedTime;
        /// <summary>
        /// VM disk details.
        /// </summary>
        public readonly ImmutableArray<Outputs.DiskDetailsResponse> VMDiskDetails;
        /// <summary>
        /// The virtual machine Id.
        /// </summary>
        public readonly string? VmId;
        /// <summary>
        /// The PE Network details.
        /// </summary>
        public readonly ImmutableArray<Outputs.VMNicDetailsResponse> VmNics;
        /// <summary>
        /// The protection state for the vm.
        /// </summary>
        public readonly string? VmProtectionState;
        /// <summary>
        /// The protection state description for the vm.
        /// </summary>
        public readonly string? VmProtectionStateDescription;

        [OutputConstructor]
        private HyperVReplicaBlueReplicationDetailsResponse(
            Outputs.InitialReplicationDetailsResponse? initialReplicationDetails,

            string instanceType,

            string? lastReplicatedTime,

            ImmutableArray<Outputs.DiskDetailsResponse> vMDiskDetails,

            string? vmId,

            ImmutableArray<Outputs.VMNicDetailsResponse> vmNics,

            string? vmProtectionState,

            string? vmProtectionStateDescription)
        {
            InitialReplicationDetails = initialReplicationDetails;
            InstanceType = instanceType;
            LastReplicatedTime = lastReplicatedTime;
            VMDiskDetails = vMDiskDetails;
            VmId = vmId;
            VmNics = vmNics;
            VmProtectionState = vmProtectionState;
            VmProtectionStateDescription = vmProtectionStateDescription;
        }
    }
}
