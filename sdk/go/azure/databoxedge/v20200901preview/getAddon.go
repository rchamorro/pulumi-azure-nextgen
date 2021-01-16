// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200901preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupAddon(ctx *pulumi.Context, args *LookupAddonArgs, opts ...pulumi.InvokeOption) (*LookupAddonResult, error) {
	var rv LookupAddonResult
	err := ctx.Invoke("azure-nextgen:databoxedge/v20200901preview:getAddon", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupAddonArgs struct {
	// The addon name.
	AddonName string `pulumi:"addonName"`
	// The device name.
	DeviceName string `pulumi:"deviceName"`
	// The resource group name.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The role name.
	RoleName string `pulumi:"roleName"`
}

// Role Addon
type LookupAddonResult struct {
	// The path ID that uniquely identifies the object.
	Id string `pulumi:"id"`
	// Addon type.
	Kind string `pulumi:"kind"`
	// The object name.
	Name string `pulumi:"name"`
	// Addon type
	SystemData SystemDataResponse `pulumi:"systemData"`
	// The hierarchical type of the object.
	Type string `pulumi:"type"`
}
