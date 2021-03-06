// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20201001preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Role management policy
type RoleManagementPolicy struct {
	pulumi.CustomResourceState

	// The role management policy description.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The role management policy display name.
	DisplayName pulumi.StringPtrOutput `pulumi:"displayName"`
	// The readonly computed rule applied to the policy.
	EffectiveRules pulumi.ArrayOutput `pulumi:"effectiveRules"`
	// The role management policy is default policy.
	IsOrganizationDefault pulumi.BoolPtrOutput `pulumi:"isOrganizationDefault"`
	// The last updated date time.
	LastUpdatedDateTime pulumi.StringOutput `pulumi:"lastUpdatedDateTime"`
	// The role management policy name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The rule applied to the policy.
	Rules pulumi.ArrayOutput `pulumi:"rules"`
	// The role management policy scope.
	Scope pulumi.StringPtrOutput `pulumi:"scope"`
	// The role management policy type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewRoleManagementPolicy registers a new resource with the given unique name, arguments, and options.
func NewRoleManagementPolicy(ctx *pulumi.Context,
	name string, args *RoleManagementPolicyArgs, opts ...pulumi.ResourceOption) (*RoleManagementPolicy, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.RoleManagementPolicyName == nil {
		return nil, errors.New("invalid value for required argument 'RoleManagementPolicyName'")
	}
	if args.Scope == nil {
		return nil, errors.New("invalid value for required argument 'Scope'")
	}
	var resource RoleManagementPolicy
	err := ctx.RegisterResource("azure-nextgen:authorization/v20201001preview:RoleManagementPolicy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRoleManagementPolicy gets an existing RoleManagementPolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRoleManagementPolicy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RoleManagementPolicyState, opts ...pulumi.ResourceOption) (*RoleManagementPolicy, error) {
	var resource RoleManagementPolicy
	err := ctx.ReadResource("azure-nextgen:authorization/v20201001preview:RoleManagementPolicy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RoleManagementPolicy resources.
type roleManagementPolicyState struct {
	// The role management policy description.
	Description *string `pulumi:"description"`
	// The role management policy display name.
	DisplayName *string `pulumi:"displayName"`
	// The readonly computed rule applied to the policy.
	EffectiveRules []interface{} `pulumi:"effectiveRules"`
	// The role management policy is default policy.
	IsOrganizationDefault *bool `pulumi:"isOrganizationDefault"`
	// The last updated date time.
	LastUpdatedDateTime *string `pulumi:"lastUpdatedDateTime"`
	// The role management policy name.
	Name *string `pulumi:"name"`
	// The rule applied to the policy.
	Rules []interface{} `pulumi:"rules"`
	// The role management policy scope.
	Scope *string `pulumi:"scope"`
	// The role management policy type.
	Type *string `pulumi:"type"`
}

type RoleManagementPolicyState struct {
	// The role management policy description.
	Description pulumi.StringPtrInput
	// The role management policy display name.
	DisplayName pulumi.StringPtrInput
	// The readonly computed rule applied to the policy.
	EffectiveRules pulumi.ArrayInput
	// The role management policy is default policy.
	IsOrganizationDefault pulumi.BoolPtrInput
	// The last updated date time.
	LastUpdatedDateTime pulumi.StringPtrInput
	// The role management policy name.
	Name pulumi.StringPtrInput
	// The rule applied to the policy.
	Rules pulumi.ArrayInput
	// The role management policy scope.
	Scope pulumi.StringPtrInput
	// The role management policy type.
	Type pulumi.StringPtrInput
}

func (RoleManagementPolicyState) ElementType() reflect.Type {
	return reflect.TypeOf((*roleManagementPolicyState)(nil)).Elem()
}

type roleManagementPolicyArgs struct {
	// The role management policy description.
	Description *string `pulumi:"description"`
	// The role management policy display name.
	DisplayName *string `pulumi:"displayName"`
	// The role management policy is default policy.
	IsOrganizationDefault *bool `pulumi:"isOrganizationDefault"`
	// The name (guid) of the role management policy to upsert.
	RoleManagementPolicyName string `pulumi:"roleManagementPolicyName"`
	// The rule applied to the policy.
	Rules []interface{} `pulumi:"rules"`
	// The role management policy scope.
	Scope string `pulumi:"scope"`
}

// The set of arguments for constructing a RoleManagementPolicy resource.
type RoleManagementPolicyArgs struct {
	// The role management policy description.
	Description pulumi.StringPtrInput
	// The role management policy display name.
	DisplayName pulumi.StringPtrInput
	// The role management policy is default policy.
	IsOrganizationDefault pulumi.BoolPtrInput
	// The name (guid) of the role management policy to upsert.
	RoleManagementPolicyName pulumi.StringInput
	// The rule applied to the policy.
	Rules pulumi.ArrayInput
	// The role management policy scope.
	Scope pulumi.StringInput
}

func (RoleManagementPolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*roleManagementPolicyArgs)(nil)).Elem()
}

type RoleManagementPolicyInput interface {
	pulumi.Input

	ToRoleManagementPolicyOutput() RoleManagementPolicyOutput
	ToRoleManagementPolicyOutputWithContext(ctx context.Context) RoleManagementPolicyOutput
}

func (*RoleManagementPolicy) ElementType() reflect.Type {
	return reflect.TypeOf((*RoleManagementPolicy)(nil))
}

func (i *RoleManagementPolicy) ToRoleManagementPolicyOutput() RoleManagementPolicyOutput {
	return i.ToRoleManagementPolicyOutputWithContext(context.Background())
}

func (i *RoleManagementPolicy) ToRoleManagementPolicyOutputWithContext(ctx context.Context) RoleManagementPolicyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RoleManagementPolicyOutput)
}

type RoleManagementPolicyOutput struct {
	*pulumi.OutputState
}

func (RoleManagementPolicyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*RoleManagementPolicy)(nil))
}

func (o RoleManagementPolicyOutput) ToRoleManagementPolicyOutput() RoleManagementPolicyOutput {
	return o
}

func (o RoleManagementPolicyOutput) ToRoleManagementPolicyOutputWithContext(ctx context.Context) RoleManagementPolicyOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(RoleManagementPolicyOutput{})
}
