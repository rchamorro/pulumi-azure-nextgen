// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearning.Latest.Outputs
{

    [OutputType]
    public sealed class WebServiceParameterResponse
    {
        /// <summary>
        /// If the parameter value in 'value' field is encrypted, the thumbprint of the certificate should be put here.
        /// </summary>
        public readonly string? CertificateThumbprint;
        /// <summary>
        /// The parameter value
        /// </summary>
        public readonly object? Value;

        [OutputConstructor]
        private WebServiceParameterResponse(
            string? certificateThumbprint,

            object? value)
        {
            CertificateThumbprint = certificateThumbprint;
            Value = value;
        }
    }
}
