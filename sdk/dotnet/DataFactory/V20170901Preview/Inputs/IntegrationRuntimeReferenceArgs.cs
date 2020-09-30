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
    /// Integration runtime reference type.
    /// </summary>
    public sealed class IntegrationRuntimeReferenceArgs : Pulumi.ResourceArgs
    {
        [Input("parameters")]
        private InputMap<object>? _parameters;

        /// <summary>
        /// Arguments for integration runtime.
        /// </summary>
        public InputMap<object> Parameters
        {
            get => _parameters ?? (_parameters = new InputMap<object>());
            set => _parameters = value;
        }

        /// <summary>
        /// Reference integration runtime name.
        /// </summary>
        [Input("referenceName", required: true)]
        public Input<string> ReferenceName { get; set; } = null!;

        /// <summary>
        /// Type of integration runtime.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public IntegrationRuntimeReferenceArgs()
        {
        }
    }
}
