// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200301preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The cost allocation rule model definition
type CostAllocationRule struct {
	pulumi.CustomResourceState

	// Name of the rule. This is a read only value.
	Name pulumi.StringOutput `pulumi:"name"`
	// Cost allocation rule properties
	Properties CostAllocationRulePropertiesResponseOutput `pulumi:"properties"`
	// Resource type of the rule. This is a read only value of Microsoft.CostManagement/CostAllocationRule.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewCostAllocationRule registers a new resource with the given unique name, arguments, and options.
func NewCostAllocationRule(ctx *pulumi.Context,
	name string, args *CostAllocationRuleArgs, opts ...pulumi.ResourceOption) (*CostAllocationRule, error) {
	if args == nil || args.BillingAccountId == nil {
		return nil, errors.New("missing required argument 'BillingAccountId'")
	}
	if args == nil || args.RuleName == nil {
		return nil, errors.New("missing required argument 'RuleName'")
	}
	if args == nil {
		args = &CostAllocationRuleArgs{}
	}
	var resource CostAllocationRule
	err := ctx.RegisterResource("azure-nextgen:billing/v20200301preview:CostAllocationRule", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCostAllocationRule gets an existing CostAllocationRule resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCostAllocationRule(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CostAllocationRuleState, opts ...pulumi.ResourceOption) (*CostAllocationRule, error) {
	var resource CostAllocationRule
	err := ctx.ReadResource("azure-nextgen:billing/v20200301preview:CostAllocationRule", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CostAllocationRule resources.
type costAllocationRuleState struct {
	// Name of the rule. This is a read only value.
	Name *string `pulumi:"name"`
	// Cost allocation rule properties
	Properties *CostAllocationRulePropertiesResponse `pulumi:"properties"`
	// Resource type of the rule. This is a read only value of Microsoft.CostManagement/CostAllocationRule.
	Type *string `pulumi:"type"`
}

type CostAllocationRuleState struct {
	// Name of the rule. This is a read only value.
	Name pulumi.StringPtrInput
	// Cost allocation rule properties
	Properties CostAllocationRulePropertiesResponsePtrInput
	// Resource type of the rule. This is a read only value of Microsoft.CostManagement/CostAllocationRule.
	Type pulumi.StringPtrInput
}

func (CostAllocationRuleState) ElementType() reflect.Type {
	return reflect.TypeOf((*costAllocationRuleState)(nil)).Elem()
}

type costAllocationRuleArgs struct {
	// BillingAccount ID
	BillingAccountId string `pulumi:"billingAccountId"`
	// Cost allocation rule properties
	Properties *CostAllocationRuleProperties `pulumi:"properties"`
	// Cost allocation rule name. The name cannot include spaces or any non alphanumeric characters other than '_' and '-'. The max length is 260 characters.
	RuleName string `pulumi:"ruleName"`
}

// The set of arguments for constructing a CostAllocationRule resource.
type CostAllocationRuleArgs struct {
	// BillingAccount ID
	BillingAccountId pulumi.StringInput
	// Cost allocation rule properties
	Properties CostAllocationRulePropertiesPtrInput
	// Cost allocation rule name. The name cannot include spaces or any non alphanumeric characters other than '_' and '-'. The max length is 260 characters.
	RuleName pulumi.StringInput
}

func (CostAllocationRuleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*costAllocationRuleArgs)(nil)).Elem()
}

type CostAllocationRuleInput interface {
	pulumi.Input

	ToCostAllocationRuleOutput() CostAllocationRuleOutput
	ToCostAllocationRuleOutputWithContext(ctx context.Context) CostAllocationRuleOutput
}

func (CostAllocationRule) ElementType() reflect.Type {
	return reflect.TypeOf((*CostAllocationRule)(nil)).Elem()
}

func (i CostAllocationRule) ToCostAllocationRuleOutput() CostAllocationRuleOutput {
	return i.ToCostAllocationRuleOutputWithContext(context.Background())
}

func (i CostAllocationRule) ToCostAllocationRuleOutputWithContext(ctx context.Context) CostAllocationRuleOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CostAllocationRuleOutput)
}

type CostAllocationRuleOutput struct {
	*pulumi.OutputState
}

func (CostAllocationRuleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*CostAllocationRuleOutput)(nil)).Elem()
}

func (o CostAllocationRuleOutput) ToCostAllocationRuleOutput() CostAllocationRuleOutput {
	return o
}

func (o CostAllocationRuleOutput) ToCostAllocationRuleOutputWithContext(ctx context.Context) CostAllocationRuleOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(CostAllocationRuleOutput{})
}
