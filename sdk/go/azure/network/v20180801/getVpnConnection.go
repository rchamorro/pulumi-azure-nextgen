// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180801

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupVpnConnection(ctx *pulumi.Context, args *LookupVpnConnectionArgs, opts ...pulumi.InvokeOption) (*LookupVpnConnectionResult, error) {
	var rv LookupVpnConnectionResult
	err := ctx.Invoke("azure-nextgen:network/v20180801:getVpnConnection", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupVpnConnectionArgs struct {
	// The name of the vpn connection.
	ConnectionName string `pulumi:"connectionName"`
	// The name of the gateway.
	GatewayName string `pulumi:"gatewayName"`
	// The resource group name of the VpnGateway.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// VpnConnection Resource.
type LookupVpnConnectionResult struct {
	// Expected bandwidth in MBPS.
	ConnectionBandwidth *int `pulumi:"connectionBandwidth"`
	// The connection status.
	ConnectionStatus string `pulumi:"connectionStatus"`
	// Egress bytes transferred.
	EgressBytesTransferred float64 `pulumi:"egressBytesTransferred"`
	// EnableBgp flag
	EnableBgp *bool `pulumi:"enableBgp"`
	// Enable internet security
	EnableInternetSecurity *bool `pulumi:"enableInternetSecurity"`
	// EnableBgp flag
	EnableRateLimiting *bool `pulumi:"enableRateLimiting"`
	// Gets a unique read-only string that changes whenever the resource is updated.
	Etag string `pulumi:"etag"`
	// Resource ID.
	Id *string `pulumi:"id"`
	// Ingress bytes transferred.
	IngressBytesTransferred float64 `pulumi:"ingressBytesTransferred"`
	// The IPSec Policies to be considered by this connection.
	IpsecPolicies []IpsecPolicyResponse `pulumi:"ipsecPolicies"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name *string `pulumi:"name"`
	// The provisioning state of the resource.
	ProvisioningState string `pulumi:"provisioningState"`
	// Id of the connected vpn site.
	RemoteVpnSite *SubResourceResponse `pulumi:"remoteVpnSite"`
	// routing weight for vpn connection.
	RoutingWeight *int `pulumi:"routingWeight"`
	// SharedKey for the vpn connection.
	SharedKey *string `pulumi:"sharedKey"`
	// Connection protocol used for this connection
	VpnConnectionProtocolType *string `pulumi:"vpnConnectionProtocolType"`
}
