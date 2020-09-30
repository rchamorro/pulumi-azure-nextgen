// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupApiSchema(ctx *pulumi.Context, args *LookupApiSchemaArgs, opts ...pulumi.InvokeOption) (*LookupApiSchemaResult, error) {
	var rv LookupApiSchemaResult
	err := ctx.Invoke("azure-nextgen:apimanagement/latest:getApiSchema", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupApiSchemaArgs struct {
	// API revision identifier. Must be unique in the current API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number.
	ApiId string `pulumi:"apiId"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Schema identifier within an API. Must be unique in the current API Management service instance.
	SchemaId string `pulumi:"schemaId"`
	// The name of the API Management service.
	ServiceName string `pulumi:"serviceName"`
}

// Schema Contract details.
type LookupApiSchemaResult struct {
	// Must be a valid a media type used in a Content-Type header as defined in the RFC 2616. Media type of the schema document (e.g. application/json, application/xml). </br> - `Swagger` Schema use `application/vnd.ms-azure-apim.swagger.definitions+json` </br> - `WSDL` Schema use `application/vnd.ms-azure-apim.xsd+xml` </br> - `OpenApi` Schema use `application/vnd.oai.openapi.components+json` </br> - `WADL Schema` use `application/vnd.ms-azure-apim.wadl.grammars+xml`.
	ContentType string `pulumi:"contentType"`
	// Types definitions. Used for Swagger/OpenAPI schemas only, null otherwise.
	Definitions interface{} `pulumi:"definitions"`
	// Resource name.
	Name string `pulumi:"name"`
	// Resource type for API Management resource.
	Type string `pulumi:"type"`
	// Json escaped string defining the document representing the Schema. Used for schemas other than Swagger/OpenAPI.
	Value *string `pulumi:"value"`
}
