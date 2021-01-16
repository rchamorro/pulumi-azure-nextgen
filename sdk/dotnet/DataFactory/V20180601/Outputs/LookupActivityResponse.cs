// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20180601.Outputs
{

    [OutputType]
    public sealed class LookupActivityResponse
    {
        /// <summary>
        /// Lookup activity dataset reference.
        /// </summary>
        public readonly Outputs.DatasetReferenceResponse Dataset;
        /// <summary>
        /// Activity depends on condition.
        /// </summary>
        public readonly ImmutableArray<Outputs.ActivityDependencyResponse> DependsOn;
        /// <summary>
        /// Activity description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Whether to return first row or all rows. Default value is true. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        public readonly object? FirstRowOnly;
        /// <summary>
        /// Linked service reference.
        /// </summary>
        public readonly Outputs.LinkedServiceReferenceResponse? LinkedServiceName;
        /// <summary>
        /// Activity name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Activity policy.
        /// </summary>
        public readonly Outputs.ActivityPolicyResponse? Policy;
        /// <summary>
        /// Dataset-specific source properties, same as copy activity source.
        /// </summary>
        public readonly object Source;
        /// <summary>
        /// Type of activity.
        /// Expected value is 'Execution'.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Activity user properties.
        /// </summary>
        public readonly ImmutableArray<Outputs.UserPropertyResponse> UserProperties;

        [OutputConstructor]
        private LookupActivityResponse(
            Outputs.DatasetReferenceResponse dataset,

            ImmutableArray<Outputs.ActivityDependencyResponse> dependsOn,

            string? description,

            object? firstRowOnly,

            Outputs.LinkedServiceReferenceResponse? linkedServiceName,

            string name,

            Outputs.ActivityPolicyResponse? policy,

            object source,

            string type,

            ImmutableArray<Outputs.UserPropertyResponse> userProperties)
        {
            Dataset = dataset;
            DependsOn = dependsOn;
            Description = description;
            FirstRowOnly = firstRowOnly;
            LinkedServiceName = linkedServiceName;
            Name = name;
            Policy = policy;
            Source = source;
            Type = type;
            UserProperties = userProperties;
        }
    }
}
