// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.HanaOnAzure.V20171103Preview.Inputs
{

    /// <summary>
    /// Specifies the hardware settings for the HANA instance.
    /// </summary>
    public sealed class HardwareProfileArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the HANA instance SKU.
        /// </summary>
        [Input("hanaInstanceSize")]
        public InputUnion<string, Pulumi.AzureNextGen.HanaOnAzure.V20171103Preview.HanaInstanceSizeNamesEnum>? HanaInstanceSize { get; set; }

        /// <summary>
        /// Name of the hardware type (vendor and/or their product name)
        /// </summary>
        [Input("hardwareType")]
        public InputUnion<string, Pulumi.AzureNextGen.HanaOnAzure.V20171103Preview.HanaHardwareTypeNamesEnum>? HardwareType { get; set; }

        public HardwareProfileArgs()
        {
        }
    }
}
