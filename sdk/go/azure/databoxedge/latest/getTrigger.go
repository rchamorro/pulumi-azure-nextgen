// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupTrigger(ctx *pulumi.Context, args *LookupTriggerArgs, opts ...pulumi.InvokeOption) (*LookupTriggerResult, error) {
	var rv LookupTriggerResult
	err := ctx.Invoke("azure-nextgen:databoxedge/latest:getTrigger", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupTriggerArgs struct {
	// The device name.
	DeviceName string `pulumi:"deviceName"`
	// The trigger name.
	Name string `pulumi:"name"`
	// The resource group name.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// Trigger details.
type LookupTriggerResult struct {
	// The path ID that uniquely identifies the object.
	Id string `pulumi:"id"`
	// Trigger Kind.
	Kind string `pulumi:"kind"`
	// The object name.
	Name string `pulumi:"name"`
	// Trigger in DataBoxEdge Resource
	SystemData SystemDataResponse `pulumi:"systemData"`
	// The hierarchical type of the object.
	Type string `pulumi:"type"`
}
