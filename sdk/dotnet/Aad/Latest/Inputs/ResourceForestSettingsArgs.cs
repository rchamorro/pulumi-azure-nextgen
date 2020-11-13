// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Aad.Latest.Inputs
{

    /// <summary>
    /// Settings for Resource Forest
    /// </summary>
    public sealed class ResourceForestSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Resource Forest
        /// </summary>
        [Input("resourceForest")]
        public Input<string>? ResourceForest { get; set; }

        [Input("settings")]
        private InputList<Inputs.ForestTrustArgs>? _settings;

        /// <summary>
        /// List of settings for Resource Forest
        /// </summary>
        public InputList<Inputs.ForestTrustArgs> Settings
        {
            get => _settings ?? (_settings = new InputList<Inputs.ForestTrustArgs>());
            set => _settings = value;
        }

        public ResourceForestSettingsArgs()
        {
        }
    }
}
