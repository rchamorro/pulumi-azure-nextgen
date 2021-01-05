// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataMigration.V20180715Preview
{
    public static class GetServiceTask
    {
        public static Task<GetServiceTaskResult> InvokeAsync(GetServiceTaskArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetServiceTaskResult>("azure-nextgen:datamigration/v20180715preview:getServiceTask", args ?? new GetServiceTaskArgs(), options.WithVersion());
    }


    public sealed class GetServiceTaskArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Expand the response
        /// </summary>
        [Input("expand")]
        public string? Expand { get; set; }

        /// <summary>
        /// Name of the resource group
        /// </summary>
        [Input("groupName", required: true)]
        public string GroupName { get; set; } = null!;

        /// <summary>
        /// Name of the service
        /// </summary>
        [Input("serviceName", required: true)]
        public string ServiceName { get; set; } = null!;

        /// <summary>
        /// Name of the Task
        /// </summary>
        [Input("taskName", required: true)]
        public string TaskName { get; set; } = null!;

        public GetServiceTaskArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetServiceTaskResult
    {
        /// <summary>
        /// HTTP strong entity tag value. This is ignored if submitted.
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Custom task properties
        /// </summary>
        public readonly object Properties;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetServiceTaskResult(
            string? etag,

            string id,

            string name,

            object properties,

            string type)
        {
            Etag = etag;
            Id = id;
            Name = name;
            Properties = properties;
            Type = type;
        }
    }
}
