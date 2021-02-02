// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200701preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupPolicyExemption(ctx *pulumi.Context, args *LookupPolicyExemptionArgs, opts ...pulumi.InvokeOption) (*LookupPolicyExemptionResult, error) {
	var rv LookupPolicyExemptionResult
	err := ctx.Invoke("azure-nextgen:authorization/v20200701preview:getPolicyExemption", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupPolicyExemptionArgs struct {
	// The name of the policy exemption to delete.
	PolicyExemptionName string `pulumi:"policyExemptionName"`
	// The scope of the policy exemption. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'), resource group (format: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}', or resource (format: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/[{parentResourcePath}/]{resourceType}/{resourceName}'
	Scope string `pulumi:"scope"`
}

// The policy exemption.
type LookupPolicyExemptionResult struct {
	// The description of the policy exemption.
	Description *string `pulumi:"description"`
	// The display name of the policy exemption.
	DisplayName *string `pulumi:"displayName"`
	// The policy exemption category. Possible values are Waiver and Mitigated.
	ExemptionCategory string `pulumi:"exemptionCategory"`
	// The expiration date and time (in UTC ISO 8601 format yyyy-MM-ddTHH:mm:ssZ) of the policy exemption.
	ExpiresOn *string `pulumi:"expiresOn"`
	// The ID of the policy exemption.
	Id string `pulumi:"id"`
	// The policy exemption metadata. Metadata is an open ended object and is typically a collection of key value pairs.
	Metadata interface{} `pulumi:"metadata"`
	// The name of the policy exemption.
	Name string `pulumi:"name"`
	// The ID of the policy assignment that is being exempted.
	PolicyAssignmentId string `pulumi:"policyAssignmentId"`
	// The policy definition reference ID list when the associated policy assignment is an assignment of a policy set definition.
	PolicyDefinitionReferenceIds []string `pulumi:"policyDefinitionReferenceIds"`
	// Azure Resource Manager metadata containing createdBy and modifiedBy information.
	SystemData SystemDataResponse `pulumi:"systemData"`
	// The type of the resource (Microsoft.Authorization/policyExemptions).
	Type string `pulumi:"type"`
}
