// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Automation.V20200113Preview.Inputs
{

    /// <summary>
    /// The Dsc configuration property associated with the entity.
    /// </summary>
    public sealed class DscConfigurationAssociationPropertyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Gets or sets the name of the Dsc configuration.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public DscConfigurationAssociationPropertyArgs()
        {
        }
    }
}
