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
    public sealed class IntegrationRuntimeDataProxyPropertiesResponse
    {
        /// <summary>
        /// The self-hosted integration runtime reference.
        /// </summary>
        public readonly Outputs.EntityReferenceResponse? ConnectVia;
        /// <summary>
        /// The path to contain the staged data in the Blob storage.
        /// </summary>
        public readonly string? Path;
        /// <summary>
        /// The staging linked service reference.
        /// </summary>
        public readonly Outputs.EntityReferenceResponse? StagingLinkedService;

        [OutputConstructor]
        private IntegrationRuntimeDataProxyPropertiesResponse(
            Outputs.EntityReferenceResponse? connectVia,

            string? path,

            Outputs.EntityReferenceResponse? stagingLinkedService)
        {
            ConnectVia = connectVia;
            Path = path;
            StagingLinkedService = stagingLinkedService;
        }
    }
}