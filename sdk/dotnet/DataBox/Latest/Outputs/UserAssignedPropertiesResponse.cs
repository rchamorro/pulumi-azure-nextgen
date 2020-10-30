// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataBox.Latest.Outputs
{

    [OutputType]
    public sealed class UserAssignedPropertiesResponse
    {
        /// <summary>
        /// Arm resource id for user assigned identity to be used to fetch MSI token.
        /// </summary>
        public readonly string? ResourceId;

        [OutputConstructor]
        private UserAssignedPropertiesResponse(string? resourceId)
        {
            ResourceId = resourceId;
        }
    }
}