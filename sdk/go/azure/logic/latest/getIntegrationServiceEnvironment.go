// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupIntegrationServiceEnvironment(ctx *pulumi.Context, args *LookupIntegrationServiceEnvironmentArgs, opts ...pulumi.InvokeOption) (*LookupIntegrationServiceEnvironmentResult, error) {
	var rv LookupIntegrationServiceEnvironmentResult
	err := ctx.Invoke("azure-nextgen:logic/latest:getIntegrationServiceEnvironment", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupIntegrationServiceEnvironmentArgs struct {
	// The integration service environment name.
	IntegrationServiceEnvironmentName string `pulumi:"integrationServiceEnvironmentName"`
	// The resource group.
	ResourceGroup string `pulumi:"resourceGroup"`
}

// The integration service environment.
type LookupIntegrationServiceEnvironmentResult struct {
	// The resource location.
	Location *string `pulumi:"location"`
	// Gets the resource name.
	Name string `pulumi:"name"`
	// The integration service environment properties.
	Properties IntegrationServiceEnvironmentPropertiesResponse `pulumi:"properties"`
	// The sku.
	Sku *IntegrationServiceEnvironmentSkuResponse `pulumi:"sku"`
	// The resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Gets the resource type.
	Type string `pulumi:"type"`
}