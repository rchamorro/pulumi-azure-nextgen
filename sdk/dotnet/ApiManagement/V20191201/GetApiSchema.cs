// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ApiManagement.V20191201
{
    public static class GetApiSchema
    {
        public static Task<GetApiSchemaResult> InvokeAsync(GetApiSchemaArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetApiSchemaResult>("azure-nextgen:apimanagement/v20191201:getApiSchema", args ?? new GetApiSchemaArgs(), options.WithVersion());
    }


    public sealed class GetApiSchemaArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// API revision identifier. Must be unique in the current API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number.
        /// </summary>
        [Input("apiId", required: true)]
        public string ApiId { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Schema identifier within an API. Must be unique in the current API Management service instance.
        /// </summary>
        [Input("schemaId", required: true)]
        public string SchemaId { get; set; } = null!;

        /// <summary>
        /// The name of the API Management service.
        /// </summary>
        [Input("serviceName", required: true)]
        public string ServiceName { get; set; } = null!;

        public GetApiSchemaArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetApiSchemaResult
    {
        /// <summary>
        /// Must be a valid a media type used in a Content-Type header as defined in the RFC 2616. Media type of the schema document (e.g. application/json, application/xml). &lt;/br&gt; - `Swagger` Schema use `application/vnd.ms-azure-apim.swagger.definitions+json` &lt;/br&gt; - `WSDL` Schema use `application/vnd.ms-azure-apim.xsd+xml` &lt;/br&gt; - `OpenApi` Schema use `application/vnd.oai.openapi.components+json` &lt;/br&gt; - `WADL Schema` use `application/vnd.ms-azure-apim.wadl.grammars+xml`.
        /// </summary>
        public readonly string ContentType;
        /// <summary>
        /// Types definitions. Used for Swagger/OpenAPI schemas only, null otherwise.
        /// </summary>
        public readonly object? Definitions;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Resource type for API Management resource.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Json escaped string defining the document representing the Schema. Used for schemas other than Swagger/OpenAPI.
        /// </summary>
        public readonly string? Value;

        [OutputConstructor]
        private GetApiSchemaResult(
            string contentType,

            object? definitions,

            string name,

            string type,

            string? value)
        {
            ContentType = contentType;
            Definitions = definitions;
            Name = name;
            Type = type;
            Value = value;
        }
    }
}
