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
    public sealed class HDInsightStreamingActivityResponse
    {
        /// <summary>
        /// User specified arguments to HDInsightActivity.
        /// </summary>
        public readonly ImmutableArray<object> Arguments;
        /// <summary>
        /// Combiner executable name. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? Combiner;
        /// <summary>
        /// Command line environment values.
        /// </summary>
        public readonly ImmutableArray<object> CommandEnvironment;
        /// <summary>
        /// Allows user to specify defines for streaming job request.
        /// </summary>
        public readonly ImmutableDictionary<string, object>? Defines;
        /// <summary>
        /// Activity depends on condition.
        /// </summary>
        public readonly ImmutableArray<Outputs.ActivityDependencyResponse> DependsOn;
        /// <summary>
        /// Activity description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Linked service reference where the files are located.
        /// </summary>
        public readonly Outputs.LinkedServiceReferenceResponse? FileLinkedService;
        /// <summary>
        /// Paths to streaming job files. Can be directories.
        /// </summary>
        public readonly ImmutableArray<object> FilePaths;
        /// <summary>
        /// Debug info option.
        /// </summary>
        public readonly string? GetDebugInfo;
        /// <summary>
        /// Input blob path. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object Input;
        /// <summary>
        /// Linked service reference.
        /// </summary>
        public readonly Outputs.LinkedServiceReferenceResponse? LinkedServiceName;
        /// <summary>
        /// Mapper executable name. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object Mapper;
        /// <summary>
        /// Activity name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Output blob path. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object Output;
        /// <summary>
        /// Activity policy.
        /// </summary>
        public readonly Outputs.ActivityPolicyResponse? Policy;
        /// <summary>
        /// Reducer executable name. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object Reducer;
        /// <summary>
        /// Storage linked service references.
        /// </summary>
        public readonly ImmutableArray<Outputs.LinkedServiceReferenceResponse> StorageLinkedServices;
        /// <summary>
        /// Type of activity.
        /// Expected value is 'Execution'.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private HDInsightStreamingActivityResponse(
            ImmutableArray<object> arguments,

            object? combiner,

            ImmutableArray<object> commandEnvironment,

            ImmutableDictionary<string, object>? defines,

            ImmutableArray<Outputs.ActivityDependencyResponse> dependsOn,

            string? description,

            Outputs.LinkedServiceReferenceResponse? fileLinkedService,

            ImmutableArray<object> filePaths,

            string? getDebugInfo,

            object input,

            Outputs.LinkedServiceReferenceResponse? linkedServiceName,

            object mapper,

            string name,

            object output,

            Outputs.ActivityPolicyResponse? policy,

            object reducer,

            ImmutableArray<Outputs.LinkedServiceReferenceResponse> storageLinkedServices,

            string type)
        {
            Arguments = arguments;
            Combiner = combiner;
            CommandEnvironment = commandEnvironment;
            Defines = defines;
            DependsOn = dependsOn;
            Description = description;
            FileLinkedService = fileLinkedService;
            FilePaths = filePaths;
            GetDebugInfo = getDebugInfo;
            Input = input;
            LinkedServiceName = linkedServiceName;
            Mapper = mapper;
            Name = name;
            Output = output;
            Policy = policy;
            Reducer = reducer;
            StorageLinkedServices = storageLinkedServices;
            Type = type;
        }
    }
}
