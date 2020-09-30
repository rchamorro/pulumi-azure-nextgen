// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20160401

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The policy definition.
type PolicyDefinition struct {
	pulumi.CustomResourceState

	// The policy definition description.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The display name of the policy definition.
	DisplayName pulumi.StringPtrOutput `pulumi:"displayName"`
	// The name of the policy definition. If you do not specify a value for name, the value is inferred from the name value in the request URI.
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// The policy rule.
	PolicyRule pulumi.AnyOutput `pulumi:"policyRule"`
	// The type of policy definition. Possible values are NotSpecified, BuiltIn, and Custom.
	PolicyType pulumi.StringPtrOutput `pulumi:"policyType"`
}

// NewPolicyDefinition registers a new resource with the given unique name, arguments, and options.
func NewPolicyDefinition(ctx *pulumi.Context,
	name string, args *PolicyDefinitionArgs, opts ...pulumi.ResourceOption) (*PolicyDefinition, error) {
	if args == nil || args.PolicyDefinitionName == nil {
		return nil, errors.New("missing required argument 'PolicyDefinitionName'")
	}
	if args == nil {
		args = &PolicyDefinitionArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:authorization/latest:PolicyDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:authorization/v20151001preview:PolicyDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:authorization/v20151101:PolicyDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:authorization/v20161201:PolicyDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:authorization/v20180301:PolicyDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:authorization/v20180501:PolicyDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:authorization/v20190101:PolicyDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:authorization/v20190601:PolicyDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:authorization/v20190901:PolicyDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:authorization/v20200301:PolicyDefinition"),
		},
	})
	opts = append(opts, aliases)
	var resource PolicyDefinition
	err := ctx.RegisterResource("azure-nextgen:authorization/v20160401:PolicyDefinition", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPolicyDefinition gets an existing PolicyDefinition resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPolicyDefinition(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PolicyDefinitionState, opts ...pulumi.ResourceOption) (*PolicyDefinition, error) {
	var resource PolicyDefinition
	err := ctx.ReadResource("azure-nextgen:authorization/v20160401:PolicyDefinition", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PolicyDefinition resources.
type policyDefinitionState struct {
	// The policy definition description.
	Description *string `pulumi:"description"`
	// The display name of the policy definition.
	DisplayName *string `pulumi:"displayName"`
	// The name of the policy definition. If you do not specify a value for name, the value is inferred from the name value in the request URI.
	Name *string `pulumi:"name"`
	// The policy rule.
	PolicyRule interface{} `pulumi:"policyRule"`
	// The type of policy definition. Possible values are NotSpecified, BuiltIn, and Custom.
	PolicyType *string `pulumi:"policyType"`
}

type PolicyDefinitionState struct {
	// The policy definition description.
	Description pulumi.StringPtrInput
	// The display name of the policy definition.
	DisplayName pulumi.StringPtrInput
	// The name of the policy definition. If you do not specify a value for name, the value is inferred from the name value in the request URI.
	Name pulumi.StringPtrInput
	// The policy rule.
	PolicyRule pulumi.Input
	// The type of policy definition. Possible values are NotSpecified, BuiltIn, and Custom.
	PolicyType pulumi.StringPtrInput
}

func (PolicyDefinitionState) ElementType() reflect.Type {
	return reflect.TypeOf((*policyDefinitionState)(nil)).Elem()
}

type policyDefinitionArgs struct {
	// The policy definition description.
	Description *string `pulumi:"description"`
	// The display name of the policy definition.
	DisplayName *string `pulumi:"displayName"`
	// The name of the policy definition. If you do not specify a value for name, the value is inferred from the name value in the request URI.
	Name *string `pulumi:"name"`
	// The name of the policy definition to create.
	PolicyDefinitionName string `pulumi:"policyDefinitionName"`
	// The policy rule.
	PolicyRule interface{} `pulumi:"policyRule"`
	// The type of policy definition. Possible values are NotSpecified, BuiltIn, and Custom.
	PolicyType *string `pulumi:"policyType"`
}

// The set of arguments for constructing a PolicyDefinition resource.
type PolicyDefinitionArgs struct {
	// The policy definition description.
	Description pulumi.StringPtrInput
	// The display name of the policy definition.
	DisplayName pulumi.StringPtrInput
	// The name of the policy definition. If you do not specify a value for name, the value is inferred from the name value in the request URI.
	Name pulumi.StringPtrInput
	// The name of the policy definition to create.
	PolicyDefinitionName pulumi.StringInput
	// The policy rule.
	PolicyRule pulumi.Input
	// The type of policy definition. Possible values are NotSpecified, BuiltIn, and Custom.
	PolicyType pulumi.StringPtrInput
}

func (PolicyDefinitionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*policyDefinitionArgs)(nil)).Elem()
}
