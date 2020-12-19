// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Cdn.V20191231.Inputs
{

    /// <summary>
    /// Defines the url redirect action for the delivery rule.
    /// </summary>
    public sealed class UrlRedirectActionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the action for the delivery rule.
        /// Expected value is 'UrlRedirect'.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Defines the parameters for the action.
        /// </summary>
        [Input("parameters", required: true)]
        public Input<Inputs.UrlRedirectActionParametersArgs> Parameters { get; set; } = null!;

        public UrlRedirectActionArgs()
        {
        }
    }
}
