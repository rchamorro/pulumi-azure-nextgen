// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20161201

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupPolicyAssignment(ctx *pulumi.Context, args *LookupPolicyAssignmentArgs, opts ...pulumi.InvokeOption) (*LookupPolicyAssignmentResult, error) {
	var rv LookupPolicyAssignmentResult
	err := ctx.Invoke("azure-nextgen:authorization/v20161201:getPolicyAssignment", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupPolicyAssignmentArgs struct {
	// The name of the policy assignment to get.
	PolicyAssignmentName string `pulumi:"policyAssignmentName"`
	// The scope of the policy assignment.
	Scope string `pulumi:"scope"`
}

// The policy assignment.
type LookupPolicyAssignmentResult struct {
	// This message will be part of response in case of policy violation.
	Description *string `pulumi:"description"`
	// The display name of the policy assignment.
	DisplayName *string `pulumi:"displayName"`
	// The name of the policy assignment.
	Name *string `pulumi:"name"`
	// Required if a parameter is used in policy rule.
	Parameters interface{} `pulumi:"parameters"`
	// The ID of the policy definition.
	PolicyDefinitionId *string `pulumi:"policyDefinitionId"`
	// The scope for the policy assignment.
	Scope *string `pulumi:"scope"`
	// The type of the policy assignment.
	Type *string `pulumi:"type"`
}
