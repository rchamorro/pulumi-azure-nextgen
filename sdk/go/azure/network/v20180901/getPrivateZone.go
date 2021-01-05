// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180901

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupPrivateZone(ctx *pulumi.Context, args *LookupPrivateZoneArgs, opts ...pulumi.InvokeOption) (*LookupPrivateZoneResult, error) {
	var rv LookupPrivateZoneResult
	err := ctx.Invoke("azure-nextgen:network/v20180901:getPrivateZone", args, &rv, opts...)
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
	// Fully qualified resource Id for the resource. Example - '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateDnsZoneName}'.
	Id string `pulumi:"id"`
	// The Azure Region where the resource lives
	Location *string `pulumi:"location"`
	// The maximum number of record sets that can be created in this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored.
	MaxNumberOfRecordSets float64 `pulumi:"maxNumberOfRecordSets"`
	// The maximum number of virtual networks that can be linked to this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored.
	MaxNumberOfVirtualNetworkLinks float64 `pulumi:"maxNumberOfVirtualNetworkLinks"`
	// The maximum number of virtual networks that can be linked to this Private DNS zone with registration enabled. This is a read-only property and any attempt to set this value will be ignored.
	MaxNumberOfVirtualNetworkLinksWithRegistration float64 `pulumi:"maxNumberOfVirtualNetworkLinksWithRegistration"`
	// The name of the resource
	Name string `pulumi:"name"`
	// The current number of record sets in this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored.
	NumberOfRecordSets float64 `pulumi:"numberOfRecordSets"`
	// The current number of virtual networks that are linked to this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored.
	NumberOfVirtualNetworkLinks float64 `pulumi:"numberOfVirtualNetworkLinks"`
	// The current number of virtual networks that are linked to this Private DNS zone with registration enabled. This is a read-only property and any attempt to set this value will be ignored.
	NumberOfVirtualNetworkLinksWithRegistration float64 `pulumi:"numberOfVirtualNetworkLinksWithRegistration"`
	// The provisioning state of the resource. This is a read-only property and any attempt to set this value will be ignored.
	ProvisioningState string `pulumi:"provisioningState"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource. Example - 'Microsoft.Network/privateDnsZones'.
	Type string `pulumi:"type"`
}
