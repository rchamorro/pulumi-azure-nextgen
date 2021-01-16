// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200113preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Definition of the module type.
type Python2Package struct {
	pulumi.CustomResourceState

	// Gets or sets the activity count of the module.
	ActivityCount pulumi.IntPtrOutput `pulumi:"activityCount"`
	// Gets or sets the contentLink of the module.
	ContentLink ContentLinkResponsePtrOutput `pulumi:"contentLink"`
	// Gets or sets the creation time.
	CreationTime pulumi.StringPtrOutput `pulumi:"creationTime"`
	// Gets or sets the description.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Gets or sets the error info of the module.
	Error ModuleErrorInfoResponsePtrOutput `pulumi:"error"`
	// Gets or sets the etag of the resource.
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// Gets or sets type of module, if its composite or not.
	IsComposite pulumi.BoolPtrOutput `pulumi:"isComposite"`
	// Gets or sets the isGlobal flag of the module.
	IsGlobal pulumi.BoolPtrOutput `pulumi:"isGlobal"`
	// Gets or sets the last modified time.
	LastModifiedTime pulumi.StringPtrOutput `pulumi:"lastModifiedTime"`
	// The Azure Region where the resource lives
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// Gets or sets the provisioning state of the module.
	ProvisioningState pulumi.StringPtrOutput `pulumi:"provisioningState"`
	// Gets or sets the size in bytes of the module.
	SizeInBytes pulumi.Float64PtrOutput `pulumi:"sizeInBytes"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the resource.
	Type pulumi.StringOutput `pulumi:"type"`
	// Gets or sets the version of the module.
	Version pulumi.StringPtrOutput `pulumi:"version"`
}

// NewPython2Package registers a new resource with the given unique name, arguments, and options.
func NewPython2Package(ctx *pulumi.Context,
	name string, args *Python2PackageArgs, opts ...pulumi.ResourceOption) (*Python2Package, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AutomationAccountName == nil {
		return nil, errors.New("invalid value for required argument 'AutomationAccountName'")
	}
	if args.ContentLink == nil {
		return nil, errors.New("invalid value for required argument 'ContentLink'")
	}
	if args.PackageName == nil {
		return nil, errors.New("invalid value for required argument 'PackageName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:automation/latest:Python2Package"),
		},
		{
			Type: pulumi.String("azure-nextgen:automation/v20180630:Python2Package"),
		},
		{
			Type: pulumi.String("azure-nextgen:automation/v20190601:Python2Package"),
		},
	})
	opts = append(opts, aliases)
	var resource Python2Package
	err := ctx.RegisterResource("azure-nextgen:automation/v20200113preview:Python2Package", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPython2Package gets an existing Python2Package resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPython2Package(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *Python2PackageState, opts ...pulumi.ResourceOption) (*Python2Package, error) {
	var resource Python2Package
	err := ctx.ReadResource("azure-nextgen:automation/v20200113preview:Python2Package", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Python2Package resources.
type python2PackageState struct {
	// Gets or sets the activity count of the module.
	ActivityCount *int `pulumi:"activityCount"`
	// Gets or sets the contentLink of the module.
	ContentLink *ContentLinkResponse `pulumi:"contentLink"`
	// Gets or sets the creation time.
	CreationTime *string `pulumi:"creationTime"`
	// Gets or sets the description.
	Description *string `pulumi:"description"`
	// Gets or sets the error info of the module.
	Error *ModuleErrorInfoResponse `pulumi:"error"`
	// Gets or sets the etag of the resource.
	Etag *string `pulumi:"etag"`
	// Gets or sets type of module, if its composite or not.
	IsComposite *bool `pulumi:"isComposite"`
	// Gets or sets the isGlobal flag of the module.
	IsGlobal *bool `pulumi:"isGlobal"`
	// Gets or sets the last modified time.
	LastModifiedTime *string `pulumi:"lastModifiedTime"`
	// The Azure Region where the resource lives
	Location *string `pulumi:"location"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// Gets or sets the provisioning state of the module.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Gets or sets the size in bytes of the module.
	SizeInBytes *float64 `pulumi:"sizeInBytes"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource.
	Type *string `pulumi:"type"`
	// Gets or sets the version of the module.
	Version *string `pulumi:"version"`
}

type Python2PackageState struct {
	// Gets or sets the activity count of the module.
	ActivityCount pulumi.IntPtrInput
	// Gets or sets the contentLink of the module.
	ContentLink ContentLinkResponsePtrInput
	// Gets or sets the creation time.
	CreationTime pulumi.StringPtrInput
	// Gets or sets the description.
	Description pulumi.StringPtrInput
	// Gets or sets the error info of the module.
	Error ModuleErrorInfoResponsePtrInput
	// Gets or sets the etag of the resource.
	Etag pulumi.StringPtrInput
	// Gets or sets type of module, if its composite or not.
	IsComposite pulumi.BoolPtrInput
	// Gets or sets the isGlobal flag of the module.
	IsGlobal pulumi.BoolPtrInput
	// Gets or sets the last modified time.
	LastModifiedTime pulumi.StringPtrInput
	// The Azure Region where the resource lives
	Location pulumi.StringPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// Gets or sets the provisioning state of the module.
	ProvisioningState pulumi.StringPtrInput
	// Gets or sets the size in bytes of the module.
	SizeInBytes pulumi.Float64PtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The type of the resource.
	Type pulumi.StringPtrInput
	// Gets or sets the version of the module.
	Version pulumi.StringPtrInput
}

func (Python2PackageState) ElementType() reflect.Type {
	return reflect.TypeOf((*python2PackageState)(nil)).Elem()
}

type python2PackageArgs struct {
	// The name of the automation account.
	AutomationAccountName string `pulumi:"automationAccountName"`
	// Gets or sets the module content link.
	ContentLink ContentLink `pulumi:"contentLink"`
	// The name of python package.
	PackageName string `pulumi:"packageName"`
	// Name of an Azure Resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Gets or sets the tags attached to the resource.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a Python2Package resource.
type Python2PackageArgs struct {
	// The name of the automation account.
	AutomationAccountName pulumi.StringInput
	// Gets or sets the module content link.
	ContentLink ContentLinkInput
	// The name of python package.
	PackageName pulumi.StringInput
	// Name of an Azure Resource group.
	ResourceGroupName pulumi.StringInput
	// Gets or sets the tags attached to the resource.
	Tags pulumi.StringMapInput
}

func (Python2PackageArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*python2PackageArgs)(nil)).Elem()
}

type Python2PackageInput interface {
	pulumi.Input

	ToPython2PackageOutput() Python2PackageOutput
	ToPython2PackageOutputWithContext(ctx context.Context) Python2PackageOutput
}

func (*Python2Package) ElementType() reflect.Type {
	return reflect.TypeOf((*Python2Package)(nil))
}

func (i *Python2Package) ToPython2PackageOutput() Python2PackageOutput {
	return i.ToPython2PackageOutputWithContext(context.Background())
}

func (i *Python2Package) ToPython2PackageOutputWithContext(ctx context.Context) Python2PackageOutput {
	return pulumi.ToOutputWithContext(ctx, i).(Python2PackageOutput)
}

type Python2PackageOutput struct {
	*pulumi.OutputState
}

func (Python2PackageOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Python2Package)(nil))
}

func (o Python2PackageOutput) ToPython2PackageOutput() Python2PackageOutput {
	return o
}

func (o Python2PackageOutput) ToPython2PackageOutputWithContext(ctx context.Context) Python2PackageOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(Python2PackageOutput{})
}
