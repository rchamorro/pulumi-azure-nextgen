// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200801

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func GetVirtualNetworkGatewayVpnclientConnectionHealth(ctx *pulumi.Context, args *GetVirtualNetworkGatewayVpnclientConnectionHealthArgs, opts ...pulumi.InvokeOption) (*GetVirtualNetworkGatewayVpnclientConnectionHealthResult, error) {
	var rv GetVirtualNetworkGatewayVpnclientConnectionHealthResult
	err := ctx.Invoke("azure-nextgen:network/v20200801:getVirtualNetworkGatewayVpnclientConnectionHealth", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type GetVirtualNetworkGatewayVpnclientConnectionHealthArgs struct {
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the virtual network gateway.
	VirtualNetworkGatewayName string `pulumi:"virtualNetworkGatewayName"`
}

// List of virtual network gateway vpn client connection health.
type GetVirtualNetworkGatewayVpnclientConnectionHealthResult struct {
	// List of vpn client connection health.
	Value []VpnClientConnectionHealthDetailResponse `pulumi:"value"`
}
