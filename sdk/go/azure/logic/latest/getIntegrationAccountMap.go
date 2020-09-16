// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupIntegrationAccountMap(ctx *pulumi.Context, args *LookupIntegrationAccountMapArgs, opts ...pulumi.InvokeOption) (*LookupIntegrationAccountMapResult, error) {
	var rv LookupIntegrationAccountMapResult
	err := ctx.Invoke("azure-nextgen:logic/latest:getIntegrationAccountMap", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupIntegrationAccountMapArgs struct {
	// The integration account name.
	IntegrationAccountName string `pulumi:"integrationAccountName"`
	// The integration account map name.
	MapName string `pulumi:"mapName"`
	// The resource group name.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The integration account map.
type LookupIntegrationAccountMapResult struct {
	// The changed time.
	ChangedTime string `pulumi:"changedTime"`
	// The content.
	Content *string `pulumi:"content"`
	// The content link.
	ContentLink ContentLinkResponse `pulumi:"contentLink"`
	// The content type.
	ContentType *string `pulumi:"contentType"`
	// The created time.
	CreatedTime string `pulumi:"createdTime"`
	// The resource location.
	Location *string `pulumi:"location"`
	// The map type.
	MapType string `pulumi:"mapType"`
	// The metadata.
	Metadata map[string]interface{} `pulumi:"metadata"`
	// Gets the resource name.
	Name string `pulumi:"name"`
	// The parameters schema of integration account map.
	ParametersSchema *IntegrationAccountMapPropertiesResponseParametersSchema `pulumi:"parametersSchema"`
	// The resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Gets the resource type.
	Type string `pulumi:"type"`
}