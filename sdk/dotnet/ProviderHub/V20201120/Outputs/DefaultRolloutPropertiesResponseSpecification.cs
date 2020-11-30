// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ProviderHub.V20201120.Outputs
{

    [OutputType]
    public sealed class DefaultRolloutPropertiesResponseSpecification
    {
        public readonly Outputs.DefaultRolloutSpecificationResponseCanary? Canary;
        public readonly Outputs.DefaultRolloutSpecificationResponseHighTraffic? HighTraffic;
        public readonly Outputs.DefaultRolloutSpecificationResponseLowTraffic? LowTraffic;
        public readonly Outputs.DefaultRolloutSpecificationResponseMediumTraffic? MediumTraffic;
        public readonly Outputs.DefaultRolloutSpecificationResponseProviderRegistration? ProviderRegistration;
        public readonly ImmutableArray<Outputs.ResourceTypeRegistrationResponse> ResourceTypeRegistrations;
        public readonly Outputs.DefaultRolloutSpecificationResponseRestOfTheWorldGroupOne? RestOfTheWorldGroupOne;
        public readonly Outputs.DefaultRolloutSpecificationResponseRestOfTheWorldGroupTwo? RestOfTheWorldGroupTwo;

        [OutputConstructor]
        private DefaultRolloutPropertiesResponseSpecification(
            Outputs.DefaultRolloutSpecificationResponseCanary? canary,

            Outputs.DefaultRolloutSpecificationResponseHighTraffic? highTraffic,

            Outputs.DefaultRolloutSpecificationResponseLowTraffic? lowTraffic,

            Outputs.DefaultRolloutSpecificationResponseMediumTraffic? mediumTraffic,

            Outputs.DefaultRolloutSpecificationResponseProviderRegistration? providerRegistration,

            ImmutableArray<Outputs.ResourceTypeRegistrationResponse> resourceTypeRegistrations,

            Outputs.DefaultRolloutSpecificationResponseRestOfTheWorldGroupOne? restOfTheWorldGroupOne,

            Outputs.DefaultRolloutSpecificationResponseRestOfTheWorldGroupTwo? restOfTheWorldGroupTwo)
        {
            Canary = canary;
            HighTraffic = highTraffic;
            LowTraffic = lowTraffic;
            MediumTraffic = mediumTraffic;
            ProviderRegistration = providerRegistration;
            ResourceTypeRegistrations = resourceTypeRegistrations;
            RestOfTheWorldGroupOne = restOfTheWorldGroupOne;
            RestOfTheWorldGroupTwo = restOfTheWorldGroupTwo;
        }
    }
}