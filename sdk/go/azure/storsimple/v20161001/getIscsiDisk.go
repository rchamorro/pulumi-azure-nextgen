// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20161001

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupIscsiDisk(ctx *pulumi.Context, args *LookupIscsiDiskArgs, opts ...pulumi.InvokeOption) (*LookupIscsiDiskResult, error) {
	var rv LookupIscsiDiskResult
	err := ctx.Invoke("azure-nextgen:storsimple/v20161001:getIscsiDisk", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupIscsiDiskArgs struct {
	// The device name.
	DeviceName string `pulumi:"deviceName"`
	// The disk name.
	DiskName string `pulumi:"diskName"`
	// The iSCSI server name.
	IscsiServerName string `pulumi:"iscsiServerName"`
	// The manager name
	ManagerName string `pulumi:"managerName"`
	// The resource group name
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The iSCSI disk.
type LookupIscsiDiskResult struct {
	// The access control records.
	AccessControlRecords []string `pulumi:"accessControlRecords"`
	// The data policy.
	DataPolicy string `pulumi:"dataPolicy"`
	// The description.
	Description *string `pulumi:"description"`
	// The disk status.
	DiskStatus string `pulumi:"diskStatus"`
	// The identifier.
	Id string `pulumi:"id"`
	// The local used capacity in bytes.
	LocalUsedCapacityInBytes float64 `pulumi:"localUsedCapacityInBytes"`
	// The monitoring.
	MonitoringStatus string `pulumi:"monitoringStatus"`
	// The name.
	Name string `pulumi:"name"`
	// The provisioned capacity in bytes.
	ProvisionedCapacityInBytes float64 `pulumi:"provisionedCapacityInBytes"`
	// The type.
	Type string `pulumi:"type"`
	// The used capacity in bytes.
	UsedCapacityInBytes float64 `pulumi:"usedCapacityInBytes"`
}
