// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180617preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// An Application Insights workbook definition.
type Workbook struct {
	pulumi.CustomResourceState

	// Workbook category, as defined by the user at creation time.
	Category pulumi.StringOutput `pulumi:"category"`
	// The user-defined name (display name) of the workbook.
	DisplayName pulumi.StringOutput `pulumi:"displayName"`
	// The kind of workbook. Choices are user and shared.
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Resource location
	Location pulumi.StringOutput `pulumi:"location"`
	// Azure resource name. This is GUID value. The display name should be assigned within properties field.
	Name pulumi.StringOutput `pulumi:"name"`
	// Configuration of this particular workbook. Configuration data is a string containing valid JSON
	SerializedData pulumi.StringOutput `pulumi:"serializedData"`
	// ResourceId for a source resource.
	SourceId pulumi.StringPtrOutput `pulumi:"sourceId"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Date and time in UTC of the last modification that was made to this workbook definition.
	TimeModified pulumi.StringOutput `pulumi:"timeModified"`
	// Azure resource type
	Type pulumi.StringOutput `pulumi:"type"`
	// Unique user id of the specific user that owns this workbook.
	UserId pulumi.StringOutput `pulumi:"userId"`
	// Workbook version
	Version pulumi.StringPtrOutput `pulumi:"version"`
}

// NewWorkbook registers a new resource with the given unique name, arguments, and options.
func NewWorkbook(ctx *pulumi.Context,
	name string, args *WorkbookArgs, opts ...pulumi.ResourceOption) (*Workbook, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Category == nil {
		return nil, errors.New("invalid value for required argument 'Category'")
	}
	if args.DisplayName == nil {
		return nil, errors.New("invalid value for required argument 'DisplayName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.ResourceName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceName'")
	}
	if args.SerializedData == nil {
		return nil, errors.New("invalid value for required argument 'SerializedData'")
	}
	if args.SourceId == nil {
		return nil, errors.New("invalid value for required argument 'SourceId'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:insights/latest:Workbook"),
		},
		{
			Type: pulumi.String("azure-nextgen:insights/v20150501:Workbook"),
		},
		{
			Type: pulumi.String("azure-nextgen:insights/v20201020:Workbook"),
		},
	})
	opts = append(opts, aliases)
	var resource Workbook
	err := ctx.RegisterResource("azure-nextgen:insights/v20180617preview:Workbook", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWorkbook gets an existing Workbook resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWorkbook(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WorkbookState, opts ...pulumi.ResourceOption) (*Workbook, error) {
	var resource Workbook
	err := ctx.ReadResource("azure-nextgen:insights/v20180617preview:Workbook", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Workbook resources.
type workbookState struct {
	// Workbook category, as defined by the user at creation time.
	Category *string `pulumi:"category"`
	// The user-defined name (display name) of the workbook.
	DisplayName *string `pulumi:"displayName"`
	// The kind of workbook. Choices are user and shared.
	Kind *string `pulumi:"kind"`
	// Resource location
	Location *string `pulumi:"location"`
	// Azure resource name. This is GUID value. The display name should be assigned within properties field.
	Name *string `pulumi:"name"`
	// Configuration of this particular workbook. Configuration data is a string containing valid JSON
	SerializedData *string `pulumi:"serializedData"`
	// ResourceId for a source resource.
	SourceId *string `pulumi:"sourceId"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Date and time in UTC of the last modification that was made to this workbook definition.
	TimeModified *string `pulumi:"timeModified"`
	// Azure resource type
	Type *string `pulumi:"type"`
	// Unique user id of the specific user that owns this workbook.
	UserId *string `pulumi:"userId"`
	// Workbook version
	Version *string `pulumi:"version"`
}

type WorkbookState struct {
	// Workbook category, as defined by the user at creation time.
	Category pulumi.StringPtrInput
	// The user-defined name (display name) of the workbook.
	DisplayName pulumi.StringPtrInput
	// The kind of workbook. Choices are user and shared.
	Kind pulumi.StringPtrInput
	// Resource location
	Location pulumi.StringPtrInput
	// Azure resource name. This is GUID value. The display name should be assigned within properties field.
	Name pulumi.StringPtrInput
	// Configuration of this particular workbook. Configuration data is a string containing valid JSON
	SerializedData pulumi.StringPtrInput
	// ResourceId for a source resource.
	SourceId pulumi.StringPtrInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Date and time in UTC of the last modification that was made to this workbook definition.
	TimeModified pulumi.StringPtrInput
	// Azure resource type
	Type pulumi.StringPtrInput
	// Unique user id of the specific user that owns this workbook.
	UserId pulumi.StringPtrInput
	// Workbook version
	Version pulumi.StringPtrInput
}

func (WorkbookState) ElementType() reflect.Type {
	return reflect.TypeOf((*workbookState)(nil)).Elem()
}

type workbookArgs struct {
	// Workbook category, as defined by the user at creation time.
	Category string `pulumi:"category"`
	// The user-defined name (display name) of the workbook.
	DisplayName string `pulumi:"displayName"`
	// The kind of workbook. Choices are user and shared.
	Kind *string `pulumi:"kind"`
	// Resource location
	Location *string `pulumi:"location"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the Application Insights component resource.
	ResourceName string `pulumi:"resourceName"`
	// Configuration of this particular workbook. Configuration data is a string containing valid JSON
	SerializedData string `pulumi:"serializedData"`
	// ResourceId for a source resource.
	SourceId string `pulumi:"sourceId"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Workbook version
	Version *string `pulumi:"version"`
}

// The set of arguments for constructing a Workbook resource.
type WorkbookArgs struct {
	// Workbook category, as defined by the user at creation time.
	Category pulumi.StringInput
	// The user-defined name (display name) of the workbook.
	DisplayName pulumi.StringInput
	// The kind of workbook. Choices are user and shared.
	Kind pulumi.StringPtrInput
	// Resource location
	Location pulumi.StringPtrInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// The name of the Application Insights component resource.
	ResourceName pulumi.StringInput
	// Configuration of this particular workbook. Configuration data is a string containing valid JSON
	SerializedData pulumi.StringInput
	// ResourceId for a source resource.
	SourceId pulumi.StringInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Workbook version
	Version pulumi.StringPtrInput
}

func (WorkbookArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*workbookArgs)(nil)).Elem()
}

type WorkbookInput interface {
	pulumi.Input

	ToWorkbookOutput() WorkbookOutput
	ToWorkbookOutputWithContext(ctx context.Context) WorkbookOutput
}

func (*Workbook) ElementType() reflect.Type {
	return reflect.TypeOf((*Workbook)(nil))
}

func (i *Workbook) ToWorkbookOutput() WorkbookOutput {
	return i.ToWorkbookOutputWithContext(context.Background())
}

func (i *Workbook) ToWorkbookOutputWithContext(ctx context.Context) WorkbookOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WorkbookOutput)
}

type WorkbookOutput struct {
	*pulumi.OutputState
}

func (WorkbookOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Workbook)(nil))
}

func (o WorkbookOutput) ToWorkbookOutput() WorkbookOutput {
	return o
}

func (o WorkbookOutput) ToWorkbookOutputWithContext(ctx context.Context) WorkbookOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(WorkbookOutput{})
}
