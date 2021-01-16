// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.Latest.Outputs
{

    [OutputType]
    public sealed class DataFlowStagingInfoResponse
    {
        /// <summary>
        /// Folder path for staging blob. Type: string (or Expression with resultType string)
        /// </summary>
        public readonly object? FolderPath;
        /// <summary>
        /// Staging linked service reference.
        /// </summary>
        public readonly Outputs.LinkedServiceReferenceResponse? LinkedService;

        [OutputConstructor]
        private DataFlowStagingInfoResponse(
            object? folderPath,

            Outputs.LinkedServiceReferenceResponse? linkedService)
        {
            FolderPath = folderPath;
            LinkedService = linkedService;
        }
    }
}
