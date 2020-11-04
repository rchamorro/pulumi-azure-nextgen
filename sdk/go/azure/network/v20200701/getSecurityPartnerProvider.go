// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200701

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupSecurityPartnerProvider(ctx *pulumi.Context, args *LookupSecurityPartnerProviderArgs, opts ...pulumi.InvokeOption) (*LookupSecurityPartnerProviderResult, error) {
	var rv LookupSecurityPartnerProviderResult
	err := ctx.Invoke("azure-nextgen:network/v20200701:getSecurityPartnerProvider", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupSecurityPartnerProviderArgs struct {
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the Security Partner Provider.
	SecurityPartnerProviderName string `pulumi:"securityPartnerProviderName"`
}

// Security Partner Provider resource.
type LookupSecurityPartnerProviderResult struct {
	// The connection status with the Security Partner Provider.
	ConnectionStatus string `pulumi:"connectionStatus"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag string `pulumi:"etag"`
	// Resource location.
	Location *string `pulumi:"location"`
	// Resource name.
	Name string `pulumi:"name"`
	// The provisioning state of the Security Partner Provider resource.
	ProvisioningState string `pulumi:"provisioningState"`
	// The security provider name.
	SecurityProviderName *string `pulumi:"securityProviderName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type string `pulumi:"type"`
	// The virtualHub to which the Security Partner Provider belongs.
	VirtualHub *SubResourceResponse `pulumi:"virtualHub"`
}
