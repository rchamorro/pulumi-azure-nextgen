// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ApiManagement.Latest
{
    /// <summary>
    /// Schema Contract details.
    /// </summary>
    public partial class ApiSchema : Pulumi.CustomResource
    {
        /// <summary>
        /// Must be a valid a media type used in a Content-Type header as defined in the RFC 2616. Media type of the schema document (e.g. application/json, application/xml). &lt;/br&gt; - `Swagger` Schema use `application/vnd.ms-azure-apim.swagger.definitions+json` &lt;/br&gt; - `WSDL` Schema use `application/vnd.ms-azure-apim.xsd+xml` &lt;/br&gt; - `OpenApi` Schema use `application/vnd.oai.openapi.components+json` &lt;/br&gt; - `WADL Schema` use `application/vnd.ms-azure-apim.wadl.grammars+xml`.
        /// </summary>
        [Output("contentType")]
        public Output<string> ContentType { get; private set; } = null!;

        /// <summary>
        /// Types definitions. Used for Swagger/OpenAPI schemas only, null otherwise.
        /// </summary>
        [Output("definitions")]
        public Output<ImmutableDictionary<string, object>?> Definitions { get; private set; } = null!;

        /// <summary>
        /// Resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Resource type for API Management resource.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// Json escaped string defining the document representing the Schema. Used for schemas other than Swagger/OpenAPI.
        /// </summary>
        [Output("value")]
        public Output<string?> Value { get; private set; } = null!;


        /// <summary>
        /// Create a ApiSchema resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ApiSchema(string name, ApiSchemaArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:apimanagement/latest:ApiSchema", name, args ?? new ApiSchemaArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ApiSchema(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:apimanagement/latest:ApiSchema", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20170301:ApiSchema"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20180101:ApiSchema"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20180601preview:ApiSchema"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20190101:ApiSchema"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20191201:ApiSchema"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20191201preview:ApiSchema"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ApiSchema resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ApiSchema Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ApiSchema(name, id, options);
        }
    }

    public sealed class ApiSchemaArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// API revision identifier. Must be unique in the current API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number.
        /// </summary>
        [Input("apiId", required: true)]
        public Input<string> ApiId { get; set; } = null!;

        /// <summary>
        /// Must be a valid a media type used in a Content-Type header as defined in the RFC 2616. Media type of the schema document (e.g. application/json, application/xml). &lt;/br&gt; - `Swagger` Schema use `application/vnd.ms-azure-apim.swagger.definitions+json` &lt;/br&gt; - `WSDL` Schema use `application/vnd.ms-azure-apim.xsd+xml` &lt;/br&gt; - `OpenApi` Schema use `application/vnd.oai.openapi.components+json` &lt;/br&gt; - `WADL Schema` use `application/vnd.ms-azure-apim.wadl.grammars+xml`.
        /// </summary>
        [Input("contentType", required: true)]
        public Input<string> ContentType { get; set; } = null!;

        [Input("definitions")]
        private InputMap<object>? _definitions;

        /// <summary>
        /// Types definitions. Used for Swagger/OpenAPI schemas only, null otherwise.
        /// </summary>
        public InputMap<object> Definitions
        {
            get => _definitions ?? (_definitions = new InputMap<object>());
            set => _definitions = value;
        }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Schema identifier within an API. Must be unique in the current API Management service instance.
        /// </summary>
        [Input("schemaId", required: true)]
        public Input<string> SchemaId { get; set; } = null!;

        /// <summary>
        /// The name of the API Management service.
        /// </summary>
        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

        /// <summary>
        /// Json escaped string defining the document representing the Schema. Used for schemas other than Swagger/OpenAPI.
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public ApiSchemaArgs()
        {
        }
    }
}