// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190601preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Template Spec object.
type TemplateSpec struct {
	pulumi.CustomResourceState

	// Template Spec description.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Template Spec display name.
	DisplayName pulumi.StringPtrOutput `pulumi:"displayName"`
	// The location of the Template Spec. It cannot be changed after Template Spec creation. It must be one of the supported Azure locations.
	Location pulumi.StringOutput `pulumi:"location"`
	// Name of this resource.
	Name pulumi.StringOutput `pulumi:"name"`
	// Azure Resource Manager metadata containing createdBy and modifiedBy information.
	SystemData SystemDataResponseOutput `pulumi:"systemData"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Type of this resource.
	Type pulumi.StringOutput `pulumi:"type"`
	// High-level information about the versions within this Template Spec. The keys are the version names. Only populated if the $expand query parameter is set to 'versions'.
	Versions TemplateSpecVersionInfoResponseMapOutput `pulumi:"versions"`
}

// NewTemplateSpec registers a new resource with the given unique name, arguments, and options.
func NewTemplateSpec(ctx *pulumi.Context,
	name string, args *TemplateSpecArgs, opts ...pulumi.ResourceOption) (*TemplateSpec, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.TemplateSpecName == nil {
		return nil, errors.New("invalid value for required argument 'TemplateSpecName'")
	}
	var resource TemplateSpec
	err := ctx.RegisterResource("azure-nextgen:resources/v20190601preview:TemplateSpec", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTemplateSpec gets an existing TemplateSpec resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTemplateSpec(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TemplateSpecState, opts ...pulumi.ResourceOption) (*TemplateSpec, error) {
	var resource TemplateSpec
	err := ctx.ReadResource("azure-nextgen:resources/v20190601preview:TemplateSpec", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering TemplateSpec resources.
type templateSpecState struct {
	// Template Spec description.
	Description *string `pulumi:"description"`
	// Template Spec display name.
	DisplayName *string `pulumi:"displayName"`
	// The location of the Template Spec. It cannot be changed after Template Spec creation. It must be one of the supported Azure locations.
	Location *string `pulumi:"location"`
	// Name of this resource.
	Name *string `pulumi:"name"`
	// Azure Resource Manager metadata containing createdBy and modifiedBy information.
	SystemData *SystemDataResponse `pulumi:"systemData"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Type of this resource.
	Type *string `pulumi:"type"`
	// High-level information about the versions within this Template Spec. The keys are the version names. Only populated if the $expand query parameter is set to 'versions'.
	Versions map[string]TemplateSpecVersionInfoResponse `pulumi:"versions"`
}

type TemplateSpecState struct {
	// Template Spec description.
	Description pulumi.StringPtrInput
	// Template Spec display name.
	DisplayName pulumi.StringPtrInput
	// The location of the Template Spec. It cannot be changed after Template Spec creation. It must be one of the supported Azure locations.
	Location pulumi.StringPtrInput
	// Name of this resource.
	Name pulumi.StringPtrInput
	// Azure Resource Manager metadata containing createdBy and modifiedBy information.
	SystemData SystemDataResponsePtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Type of this resource.
	Type pulumi.StringPtrInput
	// High-level information about the versions within this Template Spec. The keys are the version names. Only populated if the $expand query parameter is set to 'versions'.
	Versions TemplateSpecVersionInfoResponseMapInput
}

func (TemplateSpecState) ElementType() reflect.Type {
	return reflect.TypeOf((*templateSpecState)(nil)).Elem()
}

type templateSpecArgs struct {
	// Template Spec description.
	Description *string `pulumi:"description"`
	// Template Spec display name.
	DisplayName *string `pulumi:"displayName"`
	// The location of the Template Spec. It cannot be changed after Template Spec creation. It must be one of the supported Azure locations.
	Location *string `pulumi:"location"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Name of the Template Spec.
	TemplateSpecName string `pulumi:"templateSpecName"`
}

// The set of arguments for constructing a TemplateSpec resource.
type TemplateSpecArgs struct {
	// Template Spec description.
	Description pulumi.StringPtrInput
	// Template Spec display name.
	DisplayName pulumi.StringPtrInput
	// The location of the Template Spec. It cannot be changed after Template Spec creation. It must be one of the supported Azure locations.
	Location pulumi.StringPtrInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Name of the Template Spec.
	TemplateSpecName pulumi.StringInput
}

func (TemplateSpecArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*templateSpecArgs)(nil)).Elem()
}

type TemplateSpecInput interface {
	pulumi.Input

	ToTemplateSpecOutput() TemplateSpecOutput
	ToTemplateSpecOutputWithContext(ctx context.Context) TemplateSpecOutput
}

func (*TemplateSpec) ElementType() reflect.Type {
	return reflect.TypeOf((*TemplateSpec)(nil))
}

func (i *TemplateSpec) ToTemplateSpecOutput() TemplateSpecOutput {
	return i.ToTemplateSpecOutputWithContext(context.Background())
}

func (i *TemplateSpec) ToTemplateSpecOutputWithContext(ctx context.Context) TemplateSpecOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TemplateSpecOutput)
}

type TemplateSpecOutput struct {
	*pulumi.OutputState
}

func (TemplateSpecOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*TemplateSpec)(nil))
}

func (o TemplateSpecOutput) ToTemplateSpecOutput() TemplateSpecOutput {
	return o
}

func (o TemplateSpecOutput) ToTemplateSpecOutputWithContext(ctx context.Context) TemplateSpecOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(TemplateSpecOutput{})
}
