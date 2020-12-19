// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190701

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The remediation definition.
type RemediationAtResource struct {
	pulumi.CustomResourceState

	// The time at which the remediation was created.
	CreatedOn pulumi.StringOutput `pulumi:"createdOn"`
	// The deployment status summary for all deployments created by the remediation.
	DeploymentStatus RemediationDeploymentSummaryResponseOutput `pulumi:"deploymentStatus"`
	// The filters that will be applied to determine which resources to remediate.
	Filters RemediationFiltersResponsePtrOutput `pulumi:"filters"`
	// The time at which the remediation was last updated.
	LastUpdatedOn pulumi.StringOutput `pulumi:"lastUpdatedOn"`
	// The name of the remediation.
	Name pulumi.StringOutput `pulumi:"name"`
	// The resource ID of the policy assignment that should be remediated.
	PolicyAssignmentId pulumi.StringPtrOutput `pulumi:"policyAssignmentId"`
	// The policy definition reference ID of the individual definition that should be remediated. Required when the policy assignment being remediated assigns a policy set definition.
	PolicyDefinitionReferenceId pulumi.StringPtrOutput `pulumi:"policyDefinitionReferenceId"`
	// The status of the remediation.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The way resources to remediate are discovered. Defaults to ExistingNonCompliant if not specified.
	ResourceDiscoveryMode pulumi.StringPtrOutput `pulumi:"resourceDiscoveryMode"`
	// The type of the remediation.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewRemediationAtResource registers a new resource with the given unique name, arguments, and options.
func NewRemediationAtResource(ctx *pulumi.Context,
	name string, args *RemediationAtResourceArgs, opts ...pulumi.ResourceOption) (*RemediationAtResource, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.RemediationName == nil {
		return nil, errors.New("invalid value for required argument 'RemediationName'")
	}
	if args.ResourceId == nil {
		return nil, errors.New("invalid value for required argument 'ResourceId'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:policyinsights/latest:RemediationAtResource"),
		},
		{
			Type: pulumi.String("azure-nextgen:policyinsights/v20180701preview:RemediationAtResource"),
		},
	})
	opts = append(opts, aliases)
	var resource RemediationAtResource
	err := ctx.RegisterResource("azure-nextgen:policyinsights/v20190701:RemediationAtResource", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRemediationAtResource gets an existing RemediationAtResource resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRemediationAtResource(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RemediationAtResourceState, opts ...pulumi.ResourceOption) (*RemediationAtResource, error) {
	var resource RemediationAtResource
	err := ctx.ReadResource("azure-nextgen:policyinsights/v20190701:RemediationAtResource", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RemediationAtResource resources.
type remediationAtResourceState struct {
	// The time at which the remediation was created.
	CreatedOn *string `pulumi:"createdOn"`
	// The deployment status summary for all deployments created by the remediation.
	DeploymentStatus *RemediationDeploymentSummaryResponse `pulumi:"deploymentStatus"`
	// The filters that will be applied to determine which resources to remediate.
	Filters *RemediationFiltersResponse `pulumi:"filters"`
	// The time at which the remediation was last updated.
	LastUpdatedOn *string `pulumi:"lastUpdatedOn"`
	// The name of the remediation.
	Name *string `pulumi:"name"`
	// The resource ID of the policy assignment that should be remediated.
	PolicyAssignmentId *string `pulumi:"policyAssignmentId"`
	// The policy definition reference ID of the individual definition that should be remediated. Required when the policy assignment being remediated assigns a policy set definition.
	PolicyDefinitionReferenceId *string `pulumi:"policyDefinitionReferenceId"`
	// The status of the remediation.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The way resources to remediate are discovered. Defaults to ExistingNonCompliant if not specified.
	ResourceDiscoveryMode *string `pulumi:"resourceDiscoveryMode"`
	// The type of the remediation.
	Type *string `pulumi:"type"`
}

type RemediationAtResourceState struct {
	// The time at which the remediation was created.
	CreatedOn pulumi.StringPtrInput
	// The deployment status summary for all deployments created by the remediation.
	DeploymentStatus RemediationDeploymentSummaryResponsePtrInput
	// The filters that will be applied to determine which resources to remediate.
	Filters RemediationFiltersResponsePtrInput
	// The time at which the remediation was last updated.
	LastUpdatedOn pulumi.StringPtrInput
	// The name of the remediation.
	Name pulumi.StringPtrInput
	// The resource ID of the policy assignment that should be remediated.
	PolicyAssignmentId pulumi.StringPtrInput
	// The policy definition reference ID of the individual definition that should be remediated. Required when the policy assignment being remediated assigns a policy set definition.
	PolicyDefinitionReferenceId pulumi.StringPtrInput
	// The status of the remediation.
	ProvisioningState pulumi.StringPtrInput
	// The way resources to remediate are discovered. Defaults to ExistingNonCompliant if not specified.
	ResourceDiscoveryMode pulumi.StringPtrInput
	// The type of the remediation.
	Type pulumi.StringPtrInput
}

func (RemediationAtResourceState) ElementType() reflect.Type {
	return reflect.TypeOf((*remediationAtResourceState)(nil)).Elem()
}

type remediationAtResourceArgs struct {
	// The filters that will be applied to determine which resources to remediate.
	Filters *RemediationFilters `pulumi:"filters"`
	// The resource ID of the policy assignment that should be remediated.
	PolicyAssignmentId *string `pulumi:"policyAssignmentId"`
	// The policy definition reference ID of the individual definition that should be remediated. Required when the policy assignment being remediated assigns a policy set definition.
	PolicyDefinitionReferenceId *string `pulumi:"policyDefinitionReferenceId"`
	// The name of the remediation.
	RemediationName string `pulumi:"remediationName"`
	// The way resources to remediate are discovered. Defaults to ExistingNonCompliant if not specified.
	ResourceDiscoveryMode *string `pulumi:"resourceDiscoveryMode"`
	// Resource ID.
	ResourceId string `pulumi:"resourceId"`
}

// The set of arguments for constructing a RemediationAtResource resource.
type RemediationAtResourceArgs struct {
	// The filters that will be applied to determine which resources to remediate.
	Filters RemediationFiltersPtrInput
	// The resource ID of the policy assignment that should be remediated.
	PolicyAssignmentId pulumi.StringPtrInput
	// The policy definition reference ID of the individual definition that should be remediated. Required when the policy assignment being remediated assigns a policy set definition.
	PolicyDefinitionReferenceId pulumi.StringPtrInput
	// The name of the remediation.
	RemediationName pulumi.StringInput
	// The way resources to remediate are discovered. Defaults to ExistingNonCompliant if not specified.
	ResourceDiscoveryMode pulumi.StringPtrInput
	// Resource ID.
	ResourceId pulumi.StringInput
}

func (RemediationAtResourceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*remediationAtResourceArgs)(nil)).Elem()
}

type RemediationAtResourceInput interface {
	pulumi.Input

	ToRemediationAtResourceOutput() RemediationAtResourceOutput
	ToRemediationAtResourceOutputWithContext(ctx context.Context) RemediationAtResourceOutput
}

func (*RemediationAtResource) ElementType() reflect.Type {
	return reflect.TypeOf((*RemediationAtResource)(nil))
}

func (i *RemediationAtResource) ToRemediationAtResourceOutput() RemediationAtResourceOutput {
	return i.ToRemediationAtResourceOutputWithContext(context.Background())
}

func (i *RemediationAtResource) ToRemediationAtResourceOutputWithContext(ctx context.Context) RemediationAtResourceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RemediationAtResourceOutput)
}

type RemediationAtResourceOutput struct {
	*pulumi.OutputState
}

func (RemediationAtResourceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*RemediationAtResource)(nil))
}

func (o RemediationAtResourceOutput) ToRemediationAtResourceOutput() RemediationAtResourceOutput {
	return o
}

func (o RemediationAtResourceOutput) ToRemediationAtResourceOutputWithContext(ctx context.Context) RemediationAtResourceOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(RemediationAtResourceOutput{})
}
