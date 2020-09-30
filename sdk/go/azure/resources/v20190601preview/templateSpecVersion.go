// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190601preview

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Template Spec Version object.
type TemplateSpecVersion struct {
	pulumi.CustomResourceState

	// An array of Template Spec artifacts.
	Artifacts TemplateSpecTemplateArtifactResponseArrayOutput `pulumi:"artifacts"`
	// Template Spec version description.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The location of the Template Spec Version. It must match the location of the parent Template Spec.
	Location pulumi.StringOutput `pulumi:"location"`
	// Name of this resource.
	Name pulumi.StringOutput `pulumi:"name"`
	// Azure Resource Manager metadata containing createdBy and modifiedBy information.
	SystemData SystemDataResponseOutput `pulumi:"systemData"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The Azure Resource Manager template content.
	Template pulumi.AnyOutput `pulumi:"template"`
	// Type of this resource.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewTemplateSpecVersion registers a new resource with the given unique name, arguments, and options.
func NewTemplateSpecVersion(ctx *pulumi.Context,
	name string, args *TemplateSpecVersionArgs, opts ...pulumi.ResourceOption) (*TemplateSpecVersion, error) {
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.TemplateSpecName == nil {
		return nil, errors.New("missing required argument 'TemplateSpecName'")
	}
	if args == nil || args.TemplateSpecVersion == nil {
		return nil, errors.New("missing required argument 'TemplateSpecVersion'")
	}
	if args == nil {
		args = &TemplateSpecVersionArgs{}
	}
	var resource TemplateSpecVersion
	err := ctx.RegisterResource("azure-nextgen:resources/v20190601preview:TemplateSpecVersion", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTemplateSpecVersion gets an existing TemplateSpecVersion resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTemplateSpecVersion(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TemplateSpecVersionState, opts ...pulumi.ResourceOption) (*TemplateSpecVersion, error) {
	var resource TemplateSpecVersion
	err := ctx.ReadResource("azure-nextgen:resources/v20190601preview:TemplateSpecVersion", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering TemplateSpecVersion resources.
type templateSpecVersionState struct {
	// An array of Template Spec artifacts.
	Artifacts []TemplateSpecTemplateArtifactResponse `pulumi:"artifacts"`
	// Template Spec version description.
	Description *string `pulumi:"description"`
	// The location of the Template Spec Version. It must match the location of the parent Template Spec.
	Location *string `pulumi:"location"`
	// Name of this resource.
	Name *string `pulumi:"name"`
	// Azure Resource Manager metadata containing createdBy and modifiedBy information.
	SystemData *SystemDataResponse `pulumi:"systemData"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The Azure Resource Manager template content.
	Template interface{} `pulumi:"template"`
	// Type of this resource.
	Type *string `pulumi:"type"`
}

type TemplateSpecVersionState struct {
	// An array of Template Spec artifacts.
	Artifacts TemplateSpecTemplateArtifactResponseArrayInput
	// Template Spec version description.
	Description pulumi.StringPtrInput
	// The location of the Template Spec Version. It must match the location of the parent Template Spec.
	Location pulumi.StringPtrInput
	// Name of this resource.
	Name pulumi.StringPtrInput
	// Azure Resource Manager metadata containing createdBy and modifiedBy information.
	SystemData SystemDataResponsePtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The Azure Resource Manager template content.
	Template pulumi.Input
	// Type of this resource.
	Type pulumi.StringPtrInput
}

func (TemplateSpecVersionState) ElementType() reflect.Type {
	return reflect.TypeOf((*templateSpecVersionState)(nil)).Elem()
}

type templateSpecVersionArgs struct {
	// An array of Template Spec artifacts.
	Artifacts []TemplateSpecTemplateArtifact `pulumi:"artifacts"`
	// Template Spec version description.
	Description *string `pulumi:"description"`
	// The location of the Template Spec Version. It must match the location of the parent Template Spec.
	Location string `pulumi:"location"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The Azure Resource Manager template content.
	Template interface{} `pulumi:"template"`
	// Name of the Template Spec.
	TemplateSpecName string `pulumi:"templateSpecName"`
	// The version of the Template Spec.
	TemplateSpecVersion string `pulumi:"templateSpecVersion"`
}

// The set of arguments for constructing a TemplateSpecVersion resource.
type TemplateSpecVersionArgs struct {
	// An array of Template Spec artifacts.
	Artifacts TemplateSpecTemplateArtifactArrayInput
	// Template Spec version description.
	Description pulumi.StringPtrInput
	// The location of the Template Spec Version. It must match the location of the parent Template Spec.
	Location pulumi.StringInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The Azure Resource Manager template content.
	Template pulumi.Input
	// Name of the Template Spec.
	TemplateSpecName pulumi.StringInput
	// The version of the Template Spec.
	TemplateSpecVersion pulumi.StringInput
}

func (TemplateSpecVersionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*templateSpecVersionArgs)(nil)).Elem()
}
