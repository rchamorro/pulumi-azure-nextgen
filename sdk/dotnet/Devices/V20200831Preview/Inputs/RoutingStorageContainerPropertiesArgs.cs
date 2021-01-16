// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Devices.V20200831Preview.Inputs
{

    /// <summary>
    /// The properties related to a storage container endpoint.
    /// </summary>
    public sealed class RoutingStorageContainerPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Method used to authenticate against the storage endpoint
        /// </summary>
        [Input("authenticationType")]
        public InputUnion<string, Pulumi.AzureNextGen.Devices.V20200831Preview.AuthenticationType>? AuthenticationType { get; set; }

        /// <summary>
        /// Time interval at which blobs are written to storage. Value should be between 60 and 720 seconds. Default value is 300 seconds.
        /// </summary>
        [Input("batchFrequencyInSeconds")]
        public Input<int>? BatchFrequencyInSeconds { get; set; }

        /// <summary>
        /// The connection string of the storage account.
        /// </summary>
        [Input("connectionString")]
        public Input<string>? ConnectionString { get; set; }

        /// <summary>
        /// The name of storage container in the storage account.
        /// </summary>
        [Input("containerName", required: true)]
        public Input<string> ContainerName { get; set; } = null!;

        /// <summary>
        /// Encoding that is used to serialize messages to blobs. Supported values are 'avro', 'avrodeflate', and 'JSON'. Default value is 'avro'.
        /// </summary>
        [Input("encoding")]
        public Input<string>? Encoding { get; set; }

        /// <summary>
        /// The url of the storage endpoint. It must include the protocol https://
        /// </summary>
        [Input("endpointUri")]
        public Input<string>? EndpointUri { get; set; }

        /// <summary>
        /// File name format for the blob. Default format is {iothub}/{partition}/{YYYY}/{MM}/{DD}/{HH}/{mm}. All parameters are mandatory but can be reordered.
        /// </summary>
        [Input("fileNameFormat")]
        public Input<string>? FileNameFormat { get; set; }

        /// <summary>
        /// Id of the storage container endpoint
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Maximum number of bytes for each blob written to storage. Value should be between 10485760(10MB) and 524288000(500MB). Default value is 314572800(300MB).
        /// </summary>
        [Input("maxChunkSizeInBytes")]
        public Input<int>? MaxChunkSizeInBytes { get; set; }

        /// <summary>
        /// The name that identifies this endpoint. The name can only include alphanumeric characters, periods, underscores, hyphens and has a maximum length of 64 characters. The following names are reserved:  events, fileNotifications, $default. Endpoint names must be unique across endpoint types.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The name of the resource group of the storage account.
        /// </summary>
        [Input("resourceGroup")]
        public Input<string>? ResourceGroup { get; set; }

        /// <summary>
        /// The subscription identifier of the storage account.
        /// </summary>
        [Input("subscriptionId")]
        public Input<string>? SubscriptionId { get; set; }

        public RoutingStorageContainerPropertiesArgs()
        {
        }
    }
}
