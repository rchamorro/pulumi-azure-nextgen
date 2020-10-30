// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.HealthcareApis.V20200330.Inputs
{

    /// <summary>
    /// Export operation configuration information
    /// </summary>
    public sealed class ServiceExportConfigurationInfoArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the default export storage account.
        /// </summary>
        [Input("storageAccountName")]
        public Input<string>? StorageAccountName { get; set; }

        public ServiceExportConfigurationInfoArgs()
        {
        }
    }
}