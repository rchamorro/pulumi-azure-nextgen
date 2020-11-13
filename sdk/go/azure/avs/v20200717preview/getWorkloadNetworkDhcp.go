// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200717preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupWorkloadNetworkDhcp(ctx *pulumi.Context, args *LookupWorkloadNetworkDhcpArgs, opts ...pulumi.InvokeOption) (*LookupWorkloadNetworkDhcpResult, error) {
	var rv LookupWorkloadNetworkDhcpResult
	err := ctx.Invoke("azure-nextgen:avs/v20200717preview:getWorkloadNetworkDhcp", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupWorkloadNetworkDhcpArgs struct {
	// NSX DHCP identifier. Generally the same as the DHCP display name
	DhcpId string `pulumi:"dhcpId"`
	// Name of the private cloud
	PrivateCloudName string `pulumi:"privateCloudName"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// NSX DHCP
type LookupWorkloadNetworkDhcpResult struct {
	// Type of DHCP: SERVER or RELAY.
	DhcpType string `pulumi:"dhcpType"`
	// Display name of the DHCP entity.
	DisplayName *string `pulumi:"displayName"`
	// Resource name.
	Name string `pulumi:"name"`
	// The provisioning state
	ProvisioningState string `pulumi:"provisioningState"`
	// NSX revision number.
	Revision *int `pulumi:"revision"`
	// NSX Segments consuming DHCP.
	Segments []string `pulumi:"segments"`
	// Resource type.
	Type string `pulumi:"type"`
}
