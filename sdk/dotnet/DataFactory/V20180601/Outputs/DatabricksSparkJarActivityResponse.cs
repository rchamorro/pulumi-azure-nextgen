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
    public sealed class DatabricksSparkJarActivityResponse
    {
        /// <summary>
        /// Activity depends on condition.
        /// </summary>
        public readonly ImmutableArray<Outputs.ActivityDependencyResponse> DependsOn;
        /// <summary>
        /// Activity description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// A list of libraries to be installed on the cluster that will execute the job.
        /// </summary>
        public readonly ImmutableArray<ImmutableDictionary<string, object>> Libraries;
        /// <summary>
        /// Linked service reference.
        /// </summary>
        public readonly Outputs.LinkedServiceReferenceResponse? LinkedServiceName;
        /// <summary>
        /// The full name of the class containing the main method to be executed. This class must be contained in a JAR provided as a library. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object MainClassName;
        /// <summary>
        /// Activity name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Parameters that will be passed to the main method.
        /// </summary>
        public readonly ImmutableArray<object> Parameters;
        /// <summary>
        /// Activity policy.
        /// </summary>
        public readonly Outputs.ActivityPolicyResponse? Policy;
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
        private DatabricksSparkJarActivityResponse(
            ImmutableArray<Outputs.ActivityDependencyResponse> dependsOn,

            string? description,

            ImmutableArray<ImmutableDictionary<string, object>> libraries,

            Outputs.LinkedServiceReferenceResponse? linkedServiceName,

            object mainClassName,

            string name,

            ImmutableArray<object> parameters,

            Outputs.ActivityPolicyResponse? policy,

            string type,

            ImmutableArray<Outputs.UserPropertyResponse> userProperties)
        {
            DependsOn = dependsOn;
            Description = description;
            Libraries = libraries;
            LinkedServiceName = linkedServiceName;
            MainClassName = mainClassName;
            Name = name;
            Parameters = parameters;
            Policy = policy;
            Type = type;
            UserProperties = userProperties;
        }
    }
}
