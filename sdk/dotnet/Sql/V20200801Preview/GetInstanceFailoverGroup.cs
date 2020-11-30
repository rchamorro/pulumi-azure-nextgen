// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Sql.V20200801Preview
{
    public static class GetInstanceFailoverGroup
    {
        public static Task<GetInstanceFailoverGroupResult> InvokeAsync(GetInstanceFailoverGroupArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetInstanceFailoverGroupResult>("azure-nextgen:sql/v20200801preview:getInstanceFailoverGroup", args ?? new GetInstanceFailoverGroupArgs(), options.WithVersion());
    }


    public sealed class GetInstanceFailoverGroupArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the failover group.
        /// </summary>
        [Input("failoverGroupName", required: true)]
        public string FailoverGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the region where the resource is located.
        /// </summary>
        [Input("locationName", required: true)]
        public string LocationName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetInstanceFailoverGroupArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetInstanceFailoverGroupResult
    {
        /// <summary>
        /// List of managed instance pairs in the failover group.
        /// </summary>
        public readonly ImmutableArray<Outputs.ManagedInstancePairInfoResponse> ManagedInstancePairs;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Partner region information for the failover group.
        /// </summary>
        public readonly ImmutableArray<Outputs.PartnerRegionInfoResponse> PartnerRegions;
        /// <summary>
        /// Read-only endpoint of the failover group instance.
        /// </summary>
        public readonly Outputs.InstanceFailoverGroupReadOnlyEndpointResponse? ReadOnlyEndpoint;
        /// <summary>
        /// Read-write endpoint of the failover group instance.
        /// </summary>
        public readonly Outputs.InstanceFailoverGroupReadWriteEndpointResponse ReadWriteEndpoint;
        /// <summary>
        /// Local replication role of the failover group instance.
        /// </summary>
        public readonly string ReplicationRole;
        /// <summary>
        /// Replication state of the failover group instance.
        /// </summary>
        public readonly string ReplicationState;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetInstanceFailoverGroupResult(
            ImmutableArray<Outputs.ManagedInstancePairInfoResponse> managedInstancePairs,

            string name,

            ImmutableArray<Outputs.PartnerRegionInfoResponse> partnerRegions,

            Outputs.InstanceFailoverGroupReadOnlyEndpointResponse? readOnlyEndpoint,

            Outputs.InstanceFailoverGroupReadWriteEndpointResponse readWriteEndpoint,

            string replicationRole,

            string replicationState,

            string type)
        {
            ManagedInstancePairs = managedInstancePairs;
            Name = name;
            PartnerRegions = partnerRegions;
            ReadOnlyEndpoint = readOnlyEndpoint;
            ReadWriteEndpoint = readWriteEndpoint;
            ReplicationRole = replicationRole;
            ReplicationState = replicationState;
            Type = type;
        }
    }
}