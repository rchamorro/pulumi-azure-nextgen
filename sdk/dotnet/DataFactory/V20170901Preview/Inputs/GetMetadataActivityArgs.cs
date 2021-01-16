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
    /// Activity to get metadata of dataset
    /// </summary>
    public sealed class GetMetadataActivityArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// GetMetadata activity dataset reference.
        /// </summary>
        [Input("dataset", required: true)]
        public Input<Inputs.DatasetReferenceArgs> Dataset { get; set; } = null!;

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

        [Input("fieldList")]
        private InputList<object>? _fieldList;

        /// <summary>
        /// Fields of metadata to get from dataset.
        /// </summary>
        public InputList<object> FieldList
        {
            get => _fieldList ?? (_fieldList = new InputList<object>());
            set => _fieldList = value;
        }

        /// <summary>
        /// Linked service reference.
        /// </summary>
        [Input("linkedServiceName")]
        public Input<Inputs.LinkedServiceReferenceArgs>? LinkedServiceName { get; set; }

        /// <summary>
        /// Activity name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Activity policy.
        /// </summary>
        [Input("policy")]
        public Input<Inputs.ActivityPolicyArgs>? Policy { get; set; }

        /// <summary>
        /// Type of activity.
        /// Expected value is 'Execution'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public GetMetadataActivityArgs()
        {
        }
    }
}
