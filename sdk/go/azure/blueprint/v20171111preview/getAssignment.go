// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20171111preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupAssignment(ctx *pulumi.Context, args *LookupAssignmentArgs, opts ...pulumi.InvokeOption) (*LookupAssignmentResult, error) {
	var rv LookupAssignmentResult
	err := ctx.Invoke("azure-nextgen:blueprint/v20171111preview:getAssignment", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupAssignmentArgs struct {
	// name of the assignment.
	AssignmentName string `pulumi:"assignmentName"`
	// azure subscriptionId, which we assign the blueprint to.
	SubscriptionId *string `pulumi:"subscriptionId"`
}

// Represents a Blueprint assignment.
type LookupAssignmentResult struct {
	// ID of the Blueprint definition resource.
	BlueprintId *string `pulumi:"blueprintId"`
	// Multi-line explain this resource.
	Description *string `pulumi:"description"`
	// One-liner string explain this resource.
	DisplayName *string `pulumi:"displayName"`
	// String Id used to locate any resource on Azure.
	Id string `pulumi:"id"`
	// Managed Service Identity for this Blueprint assignment
	Identity ManagedServiceIdentityResponse `pulumi:"identity"`
	// The location of this Blueprint assignment.
	Location string `pulumi:"location"`
	// Defines how Blueprint-managed resources will be locked.
	Locks *AssignmentLockSettingsResponse `pulumi:"locks"`
	// Name of this resource.
	Name string `pulumi:"name"`
	// Blueprint parameter values.
	Parameters map[string]ParameterValueBaseResponse `pulumi:"parameters"`
	// State of the assignment.
	ProvisioningState string `pulumi:"provisioningState"`
	// Names and locations of resource group placeholders.
	ResourceGroups map[string]ResourceGroupValueResponse `pulumi:"resourceGroups"`
	// Status of Blueprint assignment. This field is readonly.
	Status AssignmentStatusResponse `pulumi:"status"`
	// Type of this resource.
	Type string `pulumi:"type"`
}
