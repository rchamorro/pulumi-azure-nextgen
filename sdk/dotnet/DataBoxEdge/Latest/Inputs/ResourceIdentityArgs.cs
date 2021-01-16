// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataBoxEdge.Latest.Inputs
{

    /// <summary>
    /// Msi identity details of the resource
    /// </summary>
    public sealed class ResourceIdentityArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Identity type
        /// </summary>
        [Input("type")]
        public InputUnion<string, Pulumi.AzureNextGen.DataBoxEdge.Latest.MsiIdentityType>? Type { get; set; }

        public ResourceIdentityArgs()
        {
        }
    }
}
