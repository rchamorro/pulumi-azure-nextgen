// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Automation.V20190601.Outputs
{

    [OutputType]
    public sealed class NonAzureQueryPropertiesResponse
    {
        /// <summary>
        /// Log Analytics Saved Search name.
        /// </summary>
        public readonly string? FunctionAlias;
        /// <summary>
        /// Workspace Id for Log Analytics in which the saved Search is resided.
        /// </summary>
        public readonly string? WorkspaceId;

        [OutputConstructor]
        private NonAzureQueryPropertiesResponse(
            string? functionAlias,

            string? workspaceId)
        {
            FunctionAlias = functionAlias;
            WorkspaceId = workspaceId;
        }
    }
}
