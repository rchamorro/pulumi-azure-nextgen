// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20181101preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Represents a Blueprint definition.
type Blueprint struct {
	pulumi.CustomResourceState

	// Multi-line explain this resource.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// One-liner string explain this resource.
	DisplayName pulumi.StringPtrOutput `pulumi:"displayName"`
	// Layout view of the blueprint definition for UI reference.
	Layout pulumi.AnyOutput `pulumi:"layout"`
	// Name of this resource.
	Name pulumi.StringOutput `pulumi:"name"`
	// Parameters required by this blueprint definition.
	Parameters ParameterDefinitionResponseMapOutput `pulumi:"parameters"`
	// Resource group placeholders defined by this blueprint definition.
	ResourceGroups ResourceGroupDefinitionResponseMapOutput `pulumi:"resourceGroups"`
	// Status of the blueprint. This field is readonly.
	Status BlueprintStatusResponseOutput `pulumi:"status"`
	// The scope where this blueprint definition can be assigned.
	TargetScope pulumi.StringOutput `pulumi:"targetScope"`
	// Type of this resource.
	Type pulumi.StringOutput `pulumi:"type"`
	// Published versions of this blueprint definition.
	Versions pulumi.AnyOutput `pulumi:"versions"`
}

// NewBlueprint registers a new resource with the given unique name, arguments, and options.
func NewBlueprint(ctx *pulumi.Context,
	name string, args *BlueprintArgs, opts ...pulumi.ResourceOption) (*Blueprint, error) {
	if args == nil || args.BlueprintName == nil {
		return nil, errors.New("missing required argument 'BlueprintName'")
	}
	if args == nil || args.ResourceScope == nil {
		return nil, errors.New("missing required argument 'ResourceScope'")
	}
	if args == nil || args.TargetScope == nil {
		return nil, errors.New("missing required argument 'TargetScope'")
	}
	if args == nil {
		args = &BlueprintArgs{}
	}
	var resource Blueprint
	err := ctx.RegisterResource("azure-nextgen:blueprint/v20181101preview:Blueprint", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBlueprint gets an existing Blueprint resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBlueprint(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BlueprintState, opts ...pulumi.ResourceOption) (*Blueprint, error) {
	var resource Blueprint
	err := ctx.ReadResource("azure-nextgen:blueprint/v20181101preview:Blueprint", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Blueprint resources.
type blueprintState struct {
	// Multi-line explain this resource.
	Description *string `pulumi:"description"`
	// One-liner string explain this resource.
	DisplayName *string `pulumi:"displayName"`
	// Layout view of the blueprint definition for UI reference.
	Layout interface{} `pulumi:"layout"`
	// Name of this resource.
	Name *string `pulumi:"name"`
	// Parameters required by this blueprint definition.
	Parameters map[string]ParameterDefinitionResponse `pulumi:"parameters"`
	// Resource group placeholders defined by this blueprint definition.
	ResourceGroups map[string]ResourceGroupDefinitionResponse `pulumi:"resourceGroups"`
	// Status of the blueprint. This field is readonly.
	Status *BlueprintStatusResponse `pulumi:"status"`
	// The scope where this blueprint definition can be assigned.
	TargetScope *string `pulumi:"targetScope"`
	// Type of this resource.
	Type *string `pulumi:"type"`
	// Published versions of this blueprint definition.
	Versions interface{} `pulumi:"versions"`
}

type BlueprintState struct {
	// Multi-line explain this resource.
	Description pulumi.StringPtrInput
	// One-liner string explain this resource.
	DisplayName pulumi.StringPtrInput
	// Layout view of the blueprint definition for UI reference.
	Layout pulumi.Input
	// Name of this resource.
	Name pulumi.StringPtrInput
	// Parameters required by this blueprint definition.
	Parameters ParameterDefinitionResponseMapInput
	// Resource group placeholders defined by this blueprint definition.
	ResourceGroups ResourceGroupDefinitionResponseMapInput
	// Status of the blueprint. This field is readonly.
	Status BlueprintStatusResponsePtrInput
	// The scope where this blueprint definition can be assigned.
	TargetScope pulumi.StringPtrInput
	// Type of this resource.
	Type pulumi.StringPtrInput
	// Published versions of this blueprint definition.
	Versions pulumi.Input
}

func (BlueprintState) ElementType() reflect.Type {
	return reflect.TypeOf((*blueprintState)(nil)).Elem()
}

type blueprintArgs struct {
	// Name of the blueprint definition.
	BlueprintName string `pulumi:"blueprintName"`
	// Multi-line explain this resource.
	Description *string `pulumi:"description"`
	// One-liner string explain this resource.
	DisplayName *string `pulumi:"displayName"`
	// Layout view of the blueprint definition for UI reference.
	Layout interface{} `pulumi:"layout"`
	// Parameters required by this blueprint definition.
	Parameters map[string]ParameterDefinition `pulumi:"parameters"`
	// Resource group placeholders defined by this blueprint definition.
	ResourceGroups map[string]ResourceGroupDefinition `pulumi:"resourceGroups"`
	// The scope of the resource. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}').
	ResourceScope string `pulumi:"resourceScope"`
	// The scope where this blueprint definition can be assigned.
	TargetScope string `pulumi:"targetScope"`
	// Published versions of this blueprint definition.
	Versions interface{} `pulumi:"versions"`
}

// The set of arguments for constructing a Blueprint resource.
type BlueprintArgs struct {
	// Name of the blueprint definition.
	BlueprintName pulumi.StringInput
	// Multi-line explain this resource.
	Description pulumi.StringPtrInput
	// One-liner string explain this resource.
	DisplayName pulumi.StringPtrInput
	// Layout view of the blueprint definition for UI reference.
	Layout pulumi.Input
	// Parameters required by this blueprint definition.
	Parameters ParameterDefinitionMapInput
	// Resource group placeholders defined by this blueprint definition.
	ResourceGroups ResourceGroupDefinitionMapInput
	// The scope of the resource. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}').
	ResourceScope pulumi.StringInput
	// The scope where this blueprint definition can be assigned.
	TargetScope pulumi.StringInput
	// Published versions of this blueprint definition.
	Versions pulumi.Input
}

func (BlueprintArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*blueprintArgs)(nil)).Elem()
}

type BlueprintInput interface {
	pulumi.Input

	ToBlueprintOutput() BlueprintOutput
	ToBlueprintOutputWithContext(ctx context.Context) BlueprintOutput
}

func (Blueprint) ElementType() reflect.Type {
	return reflect.TypeOf((*Blueprint)(nil)).Elem()
}

func (i Blueprint) ToBlueprintOutput() BlueprintOutput {
	return i.ToBlueprintOutputWithContext(context.Background())
}

func (i Blueprint) ToBlueprintOutputWithContext(ctx context.Context) BlueprintOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BlueprintOutput)
}

type BlueprintOutput struct {
	*pulumi.OutputState
}

func (BlueprintOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*BlueprintOutput)(nil)).Elem()
}

func (o BlueprintOutput) ToBlueprintOutput() BlueprintOutput {
	return o
}

func (o BlueprintOutput) ToBlueprintOutputWithContext(ctx context.Context) BlueprintOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(BlueprintOutput{})
}
