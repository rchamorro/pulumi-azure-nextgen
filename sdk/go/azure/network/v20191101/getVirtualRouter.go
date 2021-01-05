// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20191101

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupVirtualRouter(ctx *pulumi.Context, args *LookupVirtualRouterArgs, opts ...pulumi.InvokeOption) (*LookupVirtualRouterResult, error) {
	var rv LookupVirtualRouterResult
	err := ctx.Invoke("azure-nextgen:network/v20191101:getVirtualRouter", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupVirtualRouterArgs struct {
	// Expands referenced resources.
	Expand *string `pulumi:"expand"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the Virtual Router.
	VirtualRouterName string `pulumi:"virtualRouterName"`
}

// VirtualRouter Resource.
type LookupVirtualRouterResult struct {
	// A unique read-only string that changes whenever the resource is updated.
	Etag string `pulumi:"etag"`
	// The Gateway on which VirtualRouter is hosted.
	HostedGateway *SubResourceResponse `pulumi:"hostedGateway"`
	// The Subnet on which VirtualRouter is hosted.
	HostedSubnet *SubResourceResponse `pulumi:"hostedSubnet"`
	// Resource ID.
	Id *string `pulumi:"id"`
	// Resource location.
	Location *string `pulumi:"location"`
	// Resource name.
	Name string `pulumi:"name"`
	// List of references to VirtualRouterPeerings.
	Peerings []SubResourceResponse `pulumi:"peerings"`
	// The provisioning state of the resource.
	ProvisioningState string `pulumi:"provisioningState"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type string `pulumi:"type"`
	// VirtualRouter ASN.
	VirtualRouterAsn *float64 `pulumi:"virtualRouterAsn"`
	// VirtualRouter IPs.
	VirtualRouterIps []string `pulumi:"virtualRouterIps"`
}
