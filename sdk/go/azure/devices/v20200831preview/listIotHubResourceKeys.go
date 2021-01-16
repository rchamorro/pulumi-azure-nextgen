// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200831preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func ListIotHubResourceKeys(ctx *pulumi.Context, args *ListIotHubResourceKeysArgs, opts ...pulumi.InvokeOption) (*ListIotHubResourceKeysResult, error) {
	var rv ListIotHubResourceKeysResult
	err := ctx.Invoke("azure-nextgen:devices/v20200831preview:listIotHubResourceKeys", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type ListIotHubResourceKeysArgs struct {
	// The name of the resource group that contains the IoT hub.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the IoT hub.
	ResourceName string `pulumi:"resourceName"`
}

// The list of shared access policies with a next link.
type ListIotHubResourceKeysResult struct {
	// The next link.
	NextLink string `pulumi:"nextLink"`
	// The list of shared access policies.
	Value []SharedAccessSignatureAuthorizationRuleResponse `pulumi:"value"`
}
