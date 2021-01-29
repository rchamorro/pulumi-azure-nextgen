// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20210101

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupAttestationAtResource(ctx *pulumi.Context, args *LookupAttestationAtResourceArgs, opts ...pulumi.InvokeOption) (*LookupAttestationAtResourceResult, error) {
	var rv LookupAttestationAtResourceResult
	err := ctx.Invoke("azure-nextgen:policyinsights/v20210101:getAttestationAtResource", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupAttestationAtResourceArgs struct {
	// The name of the attestation.
	AttestationName string `pulumi:"attestationName"`
	// Resource ID.
	ResourceId string `pulumi:"resourceId"`
}

// An attestation resource.
type LookupAttestationAtResourceResult struct {
	// Comments describing why this attestation was created.
	Comments *string `pulumi:"comments"`
	// The compliance state that should be set on the resource.
	ComplianceState *string `pulumi:"complianceState"`
	// The evidence supporting the compliance state set in this attestation.
	Evidence []AttestationEvidenceResponse `pulumi:"evidence"`
	// The time the compliance state should expire.
	ExpiresOn *string `pulumi:"expiresOn"`
	// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
	Id string `pulumi:"id"`
	// The time the compliance state was last changed in this attestation.
	LastComplianceStateChangeAt string `pulumi:"lastComplianceStateChangeAt"`
	// The name of the resource
	Name string `pulumi:"name"`
	// The person responsible for setting the state of the resource. This value is typically an Azure Active Directory object ID.
	Owner *string `pulumi:"owner"`
	// The resource ID of the policy assignment that the attestation is setting the state for.
	PolicyAssignmentId string `pulumi:"policyAssignmentId"`
	// The policy definition reference ID from a policy set definition that the attestation is setting the state for. If the policy assignment assigns a policy set definition the attestation can choose a definition within the set definition with this property or omit this and set the state for the entire set definition.
	PolicyDefinitionReferenceId *string `pulumi:"policyDefinitionReferenceId"`
	// The status of the attestation.
	ProvisioningState string `pulumi:"provisioningState"`
	// Azure Resource Manager metadata containing createdBy and modifiedBy information.
	SystemData SystemDataResponse `pulumi:"systemData"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type string `pulumi:"type"`
}
