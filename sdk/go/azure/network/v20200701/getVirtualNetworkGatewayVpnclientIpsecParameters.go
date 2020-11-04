// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200701

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func GetVirtualNetworkGatewayVpnclientIpsecParameters(ctx *pulumi.Context, args *GetVirtualNetworkGatewayVpnclientIpsecParametersArgs, opts ...pulumi.InvokeOption) (*GetVirtualNetworkGatewayVpnclientIpsecParametersResult, error) {
	var rv GetVirtualNetworkGatewayVpnclientIpsecParametersResult
	err := ctx.Invoke("azure-nextgen:network/v20200701:getVirtualNetworkGatewayVpnclientIpsecParameters", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type GetVirtualNetworkGatewayVpnclientIpsecParametersArgs struct {
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The virtual network gateway name.
	VirtualNetworkGatewayName string `pulumi:"virtualNetworkGatewayName"`
}

// An IPSec parameters for a virtual network gateway P2S connection.
type GetVirtualNetworkGatewayVpnclientIpsecParametersResult struct {
	// The DH Group used in IKE Phase 1 for initial SA.
	DhGroup string `pulumi:"dhGroup"`
	// The IKE encryption algorithm (IKE phase 2).
	IkeEncryption string `pulumi:"ikeEncryption"`
	// The IKE integrity algorithm (IKE phase 2).
	IkeIntegrity string `pulumi:"ikeIntegrity"`
	// The IPSec encryption algorithm (IKE phase 1).
	IpsecEncryption string `pulumi:"ipsecEncryption"`
	// The IPSec integrity algorithm (IKE phase 1).
	IpsecIntegrity string `pulumi:"ipsecIntegrity"`
	// The Pfs Group used in IKE Phase 2 for new child SA.
	PfsGroup string `pulumi:"pfsGroup"`
	// The IPSec Security Association (also called Quick Mode or Phase 2 SA) payload size in KB for P2S client..
	SaDataSizeKilobytes int `pulumi:"saDataSizeKilobytes"`
	// The IPSec Security Association (also called Quick Mode or Phase 2 SA) lifetime in seconds for P2S client.
	SaLifeTimeSeconds int `pulumi:"saLifeTimeSeconds"`
}
