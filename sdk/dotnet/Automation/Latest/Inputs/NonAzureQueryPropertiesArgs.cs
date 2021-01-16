// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Automation.Latest.Inputs
{

    /// <summary>
    /// Non Azure query for the update configuration.
    /// </summary>
    public sealed class NonAzureQueryPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Log Analytics Saved Search name.
        /// </summary>
        [Input("functionAlias")]
        public Input<string>? FunctionAlias { get; set; }

        /// <summary>
        /// Workspace Id for Log Analytics in which the saved Search is resided.
        /// </summary>
        [Input("workspaceId")]
        public Input<string>? WorkspaceId { get; set; }

        public NonAzureQueryPropertiesArgs()
        {
        }
    }
}
