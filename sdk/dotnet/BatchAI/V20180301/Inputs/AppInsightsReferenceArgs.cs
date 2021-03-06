// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.BatchAI.V20180301.Inputs
{

    /// <summary>
    /// Specifies Azure Application Insights information for performance counters reporting.
    /// </summary>
    public sealed class AppInsightsReferenceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Represents a resource ID. For example, for a subnet, it is the resource URL for the subnet.
        /// </summary>
        [Input("component", required: true)]
        public Input<Inputs.ResourceIdArgs> Component { get; set; } = null!;

        [Input("instrumentationKey")]
        public Input<string>? InstrumentationKey { get; set; }

        /// <summary>
        /// Specifies KeyVault Store and Secret which contains Azure Application Insights instrumentation key. One of instrumentationKey or instrumentationKeySecretReference must be specified.
        /// </summary>
        [Input("instrumentationKeySecretReference")]
        public Input<Inputs.KeyVaultSecretReferenceArgs>? InstrumentationKeySecretReference { get; set; }

        public AppInsightsReferenceArgs()
        {
        }
    }
}
