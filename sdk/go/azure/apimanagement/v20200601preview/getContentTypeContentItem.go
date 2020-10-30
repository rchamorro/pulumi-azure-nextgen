// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200601preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupContentTypeContentItem(ctx *pulumi.Context, args *LookupContentTypeContentItemArgs, opts ...pulumi.InvokeOption) (*LookupContentTypeContentItemResult, error) {
	var rv LookupContentTypeContentItemResult
	err := ctx.Invoke("azure-nextgen:apimanagement/v20200601preview:getContentTypeContentItem", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupContentTypeContentItemArgs struct {
	// Content item identifier.
	ContentItemId string `pulumi:"contentItemId"`
	// Content type identifier.
	ContentTypeId string `pulumi:"contentTypeId"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the API Management service.
	ServiceName string `pulumi:"serviceName"`
}

// Content type contract details.
type LookupContentTypeContentItemResult struct {
	// Resource name.
	Name string `pulumi:"name"`
	// Properties of the content item.
	Properties interface{} `pulumi:"properties"`
	// Resource type for API Management resource.
	Type string `pulumi:"type"`
}