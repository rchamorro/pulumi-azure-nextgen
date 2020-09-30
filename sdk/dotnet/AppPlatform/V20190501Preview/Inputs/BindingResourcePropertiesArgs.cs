// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.AppPlatform.V20190501Preview.Inputs
{

    /// <summary>
    /// Binding resource properties payload
    /// </summary>
    public sealed class BindingResourcePropertiesArgs : Pulumi.ResourceArgs
    {
        [Input("bindingParameters")]
        private InputMap<object>? _bindingParameters;

        /// <summary>
        /// Binding parameters of the Binding resource
        /// </summary>
        public InputMap<object> BindingParameters
        {
            get => _bindingParameters ?? (_bindingParameters = new InputMap<object>());
            set => _bindingParameters = value;
        }

        /// <summary>
        /// The key of the bound resource
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        /// <summary>
        /// The Azure resource id of the bound resource
        /// </summary>
        [Input("resourceId")]
        public Input<string>? ResourceId { get; set; }

        public BindingResourcePropertiesArgs()
        {
        }
    }
}
