// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataBoxEdge.V20200901Preview.Outputs
{

    [OutputType]
    public sealed class EdgeProfileSubscriptionResponse
    {
        /// <summary>
        /// ARM ID of the subscription
        /// </summary>
        public readonly string? Id;
        public readonly string? LocationPlacementId;
        public readonly string? QuotaId;
        public readonly ImmutableArray<Outputs.SubscriptionRegisteredFeaturesResponse> RegisteredFeatures;
        public readonly string? RegistrationDate;
        /// <summary>
        /// Edge Subscription Registration ID
        /// </summary>
        public readonly string? RegistrationId;
        public readonly string? SerializedDetails;
        public readonly string? State;
        public readonly string? SubscriptionId;
        public readonly string? TenantId;

        [OutputConstructor]
        private EdgeProfileSubscriptionResponse(
            string? id,

            string? locationPlacementId,

            string? quotaId,

            ImmutableArray<Outputs.SubscriptionRegisteredFeaturesResponse> registeredFeatures,

            string? registrationDate,

            string? registrationId,

            string? serializedDetails,

            string? state,

            string? subscriptionId,

            string? tenantId)
        {
            Id = id;
            LocationPlacementId = locationPlacementId;
            QuotaId = quotaId;
            RegisteredFeatures = registeredFeatures;
            RegistrationDate = registrationDate;
            RegistrationId = registrationId;
            SerializedDetails = serializedDetails;
            State = state;
            SubscriptionId = subscriptionId;
            TenantId = tenantId;
        }
    }
}
