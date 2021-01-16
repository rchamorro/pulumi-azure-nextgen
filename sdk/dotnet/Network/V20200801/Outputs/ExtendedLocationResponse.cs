// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200801.Outputs
{

    [OutputType]
    public sealed class ExtendedLocationResponse
    {
        /// <summary>
        /// The name of the extended location.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The type of the extended location.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ExtendedLocationResponse(
            string name,

            string type)
        {
            Name = name;
            Type = type;
        }
    }
}
