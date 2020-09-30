// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.OperationalInsights.V20200301Preview
{
    public static class GetDataSource
    {
        public static Task<GetDataSourceResult> InvokeAsync(GetDataSourceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDataSourceResult>("azure-nextgen:operationalinsights/v20200301preview:getDataSource", args ?? new GetDataSourceArgs(), options.WithVersion());
    }


    public sealed class GetDataSourceArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the datasource
        /// </summary>
        [Input("dataSourceName", required: true)]
        public string DataSourceName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the workspace.
        /// </summary>
        [Input("workspaceName", required: true)]
        public string WorkspaceName { get; set; } = null!;

        public GetDataSourceArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDataSourceResult
    {
        /// <summary>
        /// The ETag of the data source.
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// The kind of the DataSource.
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The data source properties in raw json format, each kind of data source have it's own schema.
        /// </summary>
        public readonly object Properties;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetDataSourceResult(
            string? etag,

            string kind,

            string name,

            object properties,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            Etag = etag;
            Kind = kind;
            Name = name;
            Properties = properties;
            Tags = tags;
            Type = type;
        }
    }
}
