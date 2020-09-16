// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupPrivateZone(ctx *pulumi.Context, args *LookupPrivateZoneArgs, opts ...pulumi.InvokeOption) (*LookupPrivateZoneResult, error) {
	var rv LookupPrivateZoneResult
	err := ctx.Invoke("azure-nextgen:network/latest:getPrivateZone", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupPrivateZoneArgs struct {
	// The name of the Private DNS zone (without a terminating dot).
	PrivateZoneName string `pulumi:"privateZoneName"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// Describes a Private DNS zone.
type LookupPrivateZoneResult struct {
	// The ETag of the zone.
	Etag *string `pulumi:"etag"`
	// The Azure Region where the resource lives
	Location *string `pulumi:"location"`
	// The maximum number of record sets that can be created in this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored.
	MaxNumberOfRecordSets int `pulumi:"maxNumberOfRecordSets"`
	// The maximum number of virtual networks that can be linked to this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored.
	MaxNumberOfVirtualNetworkLinks int `pulumi:"maxNumberOfVirtualNetworkLinks"`
	// The maximum number of virtual networks that can be linked to this Private DNS zone with registration enabled. This is a read-only property and any attempt to set this value will be ignored.
	MaxNumberOfVirtualNetworkLinksWithRegistration int `pulumi:"maxNumberOfVirtualNetworkLinksWithRegistration"`
	// The name of the resource
	Name string `pulumi:"name"`
	// The current number of record sets in this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored.
	NumberOfRecordSets int `pulumi:"numberOfRecordSets"`
	// The current number of virtual networks that are linked to this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored.
	NumberOfVirtualNetworkLinks int `pulumi:"numberOfVirtualNetworkLinks"`
	// The current number of virtual networks that are linked to this Private DNS zone with registration enabled. This is a read-only property and any attempt to set this value will be ignored.
	NumberOfVirtualNetworkLinksWithRegistration int `pulumi:"numberOfVirtualNetworkLinksWithRegistration"`
	// The provisioning state of the resource. This is a read-only property and any attempt to set this value will be ignored.
	ProvisioningState string `pulumi:"provisioningState"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource. Example - 'Microsoft.Network/privateDnsZones'.
	Type string `pulumi:"type"`
}