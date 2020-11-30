// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.V20201001Preview.Inputs
{

    public sealed class CloudServiceVaultAndSecretReferenceArgs : Pulumi.ResourceArgs
    {
        [Input("secretUrl")]
        public Input<string>? SecretUrl { get; set; }

        [Input("sourceVault")]
        public Input<Inputs.SubResourceArgs>? SourceVault { get; set; }

        public CloudServiceVaultAndSecretReferenceArgs()
        {
        }
    }
}