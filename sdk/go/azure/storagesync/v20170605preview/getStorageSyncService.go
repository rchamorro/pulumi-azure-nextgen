// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20170605preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupStorageSyncService(ctx *pulumi.Context, args *LookupStorageSyncServiceArgs, opts ...pulumi.InvokeOption) (*LookupStorageSyncServiceResult, error) {
	var rv LookupStorageSyncServiceResult
	err := ctx.Invoke("azure-nextgen:storagesync/v20170605preview:getStorageSyncService", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupStorageSyncServiceArgs struct {
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Name of Storage Sync Service resource.
	StorageSyncServiceName string `pulumi:"storageSyncServiceName"`
}

// Storage Sync Service object.
type LookupStorageSyncServiceResult struct {
	// The location of the resource.
	Location *string `pulumi:"location"`
	// The name of the resource.
	Name string `pulumi:"name"`
	// Storage Sync service status.
	StorageSyncServiceStatus int `pulumi:"storageSyncServiceStatus"`
	// Storage Sync service Uid
	StorageSyncServiceUid string `pulumi:"storageSyncServiceUid"`
	// The tags of the resource.
	Tags interface{} `pulumi:"tags"`
	// The type of the resource
	Type string `pulumi:"type"`
}
