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
    /// The runbook property associated with the entity.
    /// </summary>
    public sealed class RunbookAssociationPropertyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Gets or sets the name of the runbook.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public RunbookAssociationPropertyArgs()
        {
        }
    }
}
