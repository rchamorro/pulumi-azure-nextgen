// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20170901Preview.Outputs
{

    [OutputType]
    public sealed class AzureMLUpdateResourceActivityResponse
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
        /// The relative file path in trainedModelLinkedService to represent the .ilearner file that will be uploaded by the update operation.  Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object TrainedModelFilePath;
        /// <summary>
        /// Name of Azure Storage linked service holding the .ilearner file that will be uploaded by the update operation.
        /// </summary>
        public readonly Outputs.LinkedServiceReferenceResponse TrainedModelLinkedServiceName;
        /// <summary>
        /// Name of the Trained Model module in the Web Service experiment to be updated. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object TrainedModelName;
        /// <summary>
        /// Type of activity.
        /// Expected value is 'Execution'.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private AzureMLUpdateResourceActivityResponse(
            ImmutableArray<Outputs.ActivityDependencyResponse> dependsOn,

            string? description,

            Outputs.LinkedServiceReferenceResponse? linkedServiceName,

            string name,

            Outputs.ActivityPolicyResponse? policy,

            object trainedModelFilePath,

            Outputs.LinkedServiceReferenceResponse trainedModelLinkedServiceName,

            object trainedModelName,

            string type)
        {
            DependsOn = dependsOn;
            Description = description;
            LinkedServiceName = linkedServiceName;
            Name = name;
            Policy = policy;
            TrainedModelFilePath = trainedModelFilePath;
            TrainedModelLinkedServiceName = trainedModelLinkedServiceName;
            TrainedModelName = trainedModelName;
            Type = type;
        }
    }
}
