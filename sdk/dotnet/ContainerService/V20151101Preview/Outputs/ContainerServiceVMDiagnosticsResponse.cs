// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ContainerService.V20151101Preview.Outputs
{

    [OutputType]
    public sealed class ContainerServiceVMDiagnosticsResponse
    {
        /// <summary>
        /// Gets or sets whether VM Diagnostic Agent should be provisioned on the Virtual Machine.
        /// </summary>
        public readonly bool? Enabled;
        /// <summary>
        /// Gets or sets whether VM Diagnostic Agent should be provisioned on the Virtual Machine.
        /// </summary>
        public readonly string StorageUri;

        [OutputConstructor]
        private ContainerServiceVMDiagnosticsResponse(
            bool? enabled,

            string storageUri)
        {
            Enabled = enabled;
            StorageUri = storageUri;
        }
    }
}