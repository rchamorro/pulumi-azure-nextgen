// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.Latest.Inputs
{

    /// <summary>
    /// Sftp read settings.
    /// </summary>
    public sealed class HttpReadSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The additional HTTP headers in the request to the RESTful API. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("additionalHeaders")]
        public Input<object>? AdditionalHeaders { get; set; }

        /// <summary>
        /// Indicates whether to enable partition discovery.
        /// </summary>
        [Input("enablePartitionDiscovery")]
        public Input<bool>? EnablePartitionDiscovery { get; set; }

        /// <summary>
        /// The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer).
        /// </summary>
        [Input("maxConcurrentConnections")]
        public Input<object>? MaxConcurrentConnections { get; set; }

        /// <summary>
        /// Specify the root path where partition discovery starts from. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("partitionRootPath")]
        public Input<object>? PartitionRootPath { get; set; }

        /// <summary>
        /// The HTTP request body to the RESTful API if requestMethod is POST. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("requestBody")]
        public Input<object>? RequestBody { get; set; }

        /// <summary>
        /// The HTTP method used to call the RESTful API. The default is GET. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("requestMethod")]
        public Input<object>? RequestMethod { get; set; }

        /// <summary>
        /// Specifies the timeout for a HTTP client to get HTTP response from HTTP server.
        /// </summary>
        [Input("requestTimeout")]
        public Input<object>? RequestTimeout { get; set; }

        /// <summary>
        /// The read setting type.
        /// Expected value is 'HttpReadSettings'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public HttpReadSettingsArgs()
        {
        }
    }
}
