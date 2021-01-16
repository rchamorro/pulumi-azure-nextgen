// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20170901Preview.Inputs
{

    /// <summary>
    /// HDInsight streaming activity type.
    /// </summary>
    public sealed class HDInsightStreamingActivityArgs : Pulumi.ResourceArgs
    {
        [Input("arguments")]
        private InputList<object>? _arguments;

        /// <summary>
        /// User specified arguments to HDInsightActivity.
        /// </summary>
        public InputList<object> Arguments
        {
            get => _arguments ?? (_arguments = new InputList<object>());
            set => _arguments = value;
        }

        /// <summary>
        /// Combiner executable name. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("combiner")]
        public Input<object>? Combiner { get; set; }

        [Input("commandEnvironment")]
        private InputList<object>? _commandEnvironment;

        /// <summary>
        /// Command line environment values.
        /// </summary>
        public InputList<object> CommandEnvironment
        {
            get => _commandEnvironment ?? (_commandEnvironment = new InputList<object>());
            set => _commandEnvironment = value;
        }

        [Input("defines")]
        private InputMap<object>? _defines;

        /// <summary>
        /// Allows user to specify defines for streaming job request.
        /// </summary>
        public InputMap<object> Defines
        {
            get => _defines ?? (_defines = new InputMap<object>());
            set => _defines = value;
        }

        [Input("dependsOn")]
        private InputList<Inputs.ActivityDependencyArgs>? _dependsOn;

        /// <summary>
        /// Activity depends on condition.
        /// </summary>
        public InputList<Inputs.ActivityDependencyArgs> DependsOn
        {
            get => _dependsOn ?? (_dependsOn = new InputList<Inputs.ActivityDependencyArgs>());
            set => _dependsOn = value;
        }

        /// <summary>
        /// Activity description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Linked service reference where the files are located.
        /// </summary>
        [Input("fileLinkedService")]
        public Input<Inputs.LinkedServiceReferenceArgs>? FileLinkedService { get; set; }

        [Input("filePaths", required: true)]
        private InputList<object>? _filePaths;

        /// <summary>
        /// Paths to streaming job files. Can be directories.
        /// </summary>
        public InputList<object> FilePaths
        {
            get => _filePaths ?? (_filePaths = new InputList<object>());
            set => _filePaths = value;
        }

        /// <summary>
        /// Debug info option.
        /// </summary>
        [Input("getDebugInfo")]
        public InputUnion<string, Pulumi.AzureNextGen.DataFactory.V20170901Preview.HDInsightActivityDebugInfoOption>? GetDebugInfo { get; set; }

        /// <summary>
        /// Input blob path. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("input", required: true)]
        public Input<object> Input { get; set; } = null!;

        /// <summary>
        /// Linked service reference.
        /// </summary>
        [Input("linkedServiceName")]
        public Input<Inputs.LinkedServiceReferenceArgs>? LinkedServiceName { get; set; }

        /// <summary>
        /// Mapper executable name. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("mapper", required: true)]
        public Input<object> Mapper { get; set; } = null!;

        /// <summary>
        /// Activity name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Output blob path. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("output", required: true)]
        public Input<object> Output { get; set; } = null!;

        /// <summary>
        /// Activity policy.
        /// </summary>
        [Input("policy")]
        public Input<Inputs.ActivityPolicyArgs>? Policy { get; set; }

        /// <summary>
        /// Reducer executable name. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("reducer", required: true)]
        public Input<object> Reducer { get; set; } = null!;

        [Input("storageLinkedServices")]
        private InputList<Inputs.LinkedServiceReferenceArgs>? _storageLinkedServices;

        /// <summary>
        /// Storage linked service references.
        /// </summary>
        public InputList<Inputs.LinkedServiceReferenceArgs> StorageLinkedServices
        {
            get => _storageLinkedServices ?? (_storageLinkedServices = new InputList<Inputs.LinkedServiceReferenceArgs>());
            set => _storageLinkedServices = value;
        }

        /// <summary>
        /// Type of activity.
        /// Expected value is 'Execution'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public HDInsightStreamingActivityArgs()
        {
        }
    }
}
