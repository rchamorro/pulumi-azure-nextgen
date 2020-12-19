// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.V20200501.Inputs
{

    /// <summary>
    /// Specifies a configuration for Widevine licenses.
    /// </summary>
    public sealed class ContentKeyPolicyWidevineConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The discriminator for derived types.
        /// Expected value is '#Microsoft.Media.ContentKeyPolicyWidevineConfiguration'.
        /// </summary>
        [Input("odataType", required: true)]
        public Input<string> OdataType { get; set; } = null!;

        /// <summary>
        /// The Widevine template.
        /// </summary>
        [Input("widevineTemplate", required: true)]
        public Input<string> WidevineTemplate { get; set; } = null!;

        public ContentKeyPolicyWidevineConfigurationArgs()
        {
        }
    }
}
