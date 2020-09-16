// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Insights.Latest.Outputs
{

    [OutputType]
    public sealed class WebtestLocationAvailabilityCriteriaResponse
    {
        /// <summary>
        /// The Application Insights resource Id.
        /// </summary>
        public readonly string ComponentId;
        /// <summary>
        /// The number of failed locations.
        /// </summary>
        public readonly double FailedLocationCount;
        /// <summary>
        /// specifies the type of the alert criteria.
        /// </summary>
        public readonly string OdataType;
        /// <summary>
        /// The Application Insights web test Id.
        /// </summary>
        public readonly string WebTestId;

        [OutputConstructor]
        private WebtestLocationAvailabilityCriteriaResponse(
            string componentId,

            double failedLocationCount,

            string odataType,

            string webTestId)
        {
            ComponentId = componentId;
            FailedLocationCount = failedLocationCount;
            OdataType = odataType;
            WebTestId = webTestId;
        }
    }
}