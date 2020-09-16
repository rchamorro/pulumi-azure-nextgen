// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20191001preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupMoveResource(ctx *pulumi.Context, args *LookupMoveResourceArgs, opts ...pulumi.InvokeOption) (*LookupMoveResourceResult, error) {
	var rv LookupMoveResourceResult
	err := ctx.Invoke("azure-nextgen:migrate/v20191001preview:getMoveResource", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupMoveResourceArgs struct {
	// The Move Collection Name.
	MoveCollectionName string `pulumi:"moveCollectionName"`
	// The Move Resource Name.
	MoveResourceName string `pulumi:"moveResourceName"`
	// The Resource Group Name.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// Defines the move resource.
type LookupMoveResourceResult struct {
	// The name of the resource
	Name string `pulumi:"name"`
	// Defines the move resource properties.
	Properties MoveResourcePropertiesResponse `pulumi:"properties"`
	// The type of the resource.
	Type string `pulumi:"type"`
}