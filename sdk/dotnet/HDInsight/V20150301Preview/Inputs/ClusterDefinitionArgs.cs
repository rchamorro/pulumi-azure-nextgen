// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.HDInsight.V20150301Preview.Inputs
{

    /// <summary>
    /// The cluster definition.
    /// </summary>
    public sealed class ClusterDefinitionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The link to the blueprint.
        /// </summary>
        [Input("blueprint")]
        public Input<string>? Blueprint { get; set; }

        [Input("componentVersion")]
        private InputMap<string>? _componentVersion;

        /// <summary>
        /// The versions of different services in the cluster.
        /// </summary>
        public InputMap<string> ComponentVersion
        {
            get => _componentVersion ?? (_componentVersion = new InputMap<string>());
            set => _componentVersion = value;
        }

        /// <summary>
        /// The cluster configurations.
        /// </summary>
        [Input("configurations")]
        public Input<object>? Configurations { get; set; }

        /// <summary>
        /// The type of cluster.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        public ClusterDefinitionArgs()
        {
        }
    }
}
