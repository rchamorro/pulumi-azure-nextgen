// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Devices.V20200301.Inputs
{

    /// <summary>
    /// List of possible provisioning service SKUs.
    /// </summary>
    public sealed class IotDpsSkuInfoArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The number of units to provision
        /// </summary>
        [Input("capacity")]
        public Input<double>? Capacity { get; set; }

        /// <summary>
        /// Sku name.
        /// </summary>
        [Input("name")]
        public InputUnion<string, Pulumi.AzureNextGen.Devices.V20200301.IotDpsSku>? Name { get; set; }

        public IotDpsSkuInfoArgs()
        {
        }
    }
}
