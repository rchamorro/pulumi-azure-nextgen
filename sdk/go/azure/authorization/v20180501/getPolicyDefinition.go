// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180501

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupPolicyDefinition(ctx *pulumi.Context, args *LookupPolicyDefinitionArgs, opts ...pulumi.InvokeOption) (*LookupPolicyDefinitionResult, error) {
	var rv LookupPolicyDefinitionResult
	err := ctx.Invoke("azure-nextgen:authorization/v20180501:getPolicyDefinition", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupPolicyDefinitionArgs struct {
	// The name of the policy definition to get.
	PolicyDefinitionName string `pulumi:"policyDefinitionName"`
}

// The policy definition.
type LookupPolicyDefinitionResult struct {
	// The policy definition description.
	Description *string `pulumi:"description"`
	// The display name of the policy definition.
	DisplayName *string `pulumi:"displayName"`
	// The policy definition metadata.
	Metadata interface{} `pulumi:"metadata"`
	// The policy definition mode. Possible values are NotSpecified, Indexed, and All.
	Mode *string `pulumi:"mode"`
	// The name of the policy definition.
	Name string `pulumi:"name"`
	// Required if a parameter is used in policy rule.
	Parameters interface{} `pulumi:"parameters"`
	// The policy rule.
	PolicyRule interface{} `pulumi:"policyRule"`
	// The type of policy definition. Possible values are NotSpecified, BuiltIn, and Custom.
	PolicyType *string `pulumi:"policyType"`
	// The type of the resource (Microsoft.Authorization/policyDefinitions).
	Type string `pulumi:"type"`
}
