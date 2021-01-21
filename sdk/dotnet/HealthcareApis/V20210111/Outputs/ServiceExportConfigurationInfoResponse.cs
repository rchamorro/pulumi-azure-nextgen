// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.HealthcareApis.V20210111.Outputs
{

    [OutputType]
    public sealed class ServiceExportConfigurationInfoResponse
    {
        /// <summary>
        /// The name of the default export storage account.
        /// </summary>
        public readonly string? StorageAccountName;

        [OutputConstructor]
        private ServiceExportConfigurationInfoResponse(string? storageAccountName)
        {
            StorageAccountName = storageAccountName;
        }
    }
}
