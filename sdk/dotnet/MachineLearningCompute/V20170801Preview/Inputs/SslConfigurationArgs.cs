// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningCompute.V20170801Preview.Inputs
{

    /// <summary>
    /// SSL configuration. If configured data-plane calls to user services will be exposed over SSL only.
    /// </summary>
    public sealed class SslConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The SSL cert data in PEM format.
        /// </summary>
        [Input("cert")]
        public Input<string>? Cert { get; set; }

        /// <summary>
        /// The CName of the certificate.
        /// </summary>
        [Input("cname")]
        public Input<string>? Cname { get; set; }

        /// <summary>
        /// The SSL key data in PEM format. This is not returned in response of GET/PUT on the resource. To see this please call listKeys API.
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        /// <summary>
        /// SSL status. Allowed values are Enabled and Disabled.
        /// </summary>
        [Input("status")]
        public InputUnion<string, Pulumi.AzureNextGen.MachineLearningCompute.V20170801Preview.Status>? Status { get; set; }

        public SslConfigurationArgs()
        {
            Status = "Enabled";
        }
    }
}
