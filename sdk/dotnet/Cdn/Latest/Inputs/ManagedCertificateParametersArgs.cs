// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Cdn.Latest.Inputs
{

    /// <summary>
    /// Managed Certificate used for https
    /// </summary>
    public sealed class ManagedCertificateParametersArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Certificate expiration date.
        /// </summary>
        [Input("expirationDate")]
        public Input<string>? ExpirationDate { get; set; }

        /// <summary>
        /// Subject name in the certificate.
        /// </summary>
        [Input("subject")]
        public Input<string>? Subject { get; set; }

        /// <summary>
        /// Certificate thumbprint.
        /// </summary>
        [Input("thumbprint")]
        public Input<string>? Thumbprint { get; set; }

        /// <summary>
        /// The type of the Secret to create.
        /// Expected value is 'ManagedCertificate'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public ManagedCertificateParametersArgs()
        {
        }
    }
}
