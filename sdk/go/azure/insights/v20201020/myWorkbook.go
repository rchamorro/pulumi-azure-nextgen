// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20201020

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// An Application Insights private workbook definition.
type MyWorkbook struct {
	pulumi.CustomResourceState

	// Workbook category, as defined by the user at creation time.
	Category pulumi.StringOutput `pulumi:"category"`
	// The user-defined name of the private workbook.
	DisplayName pulumi.StringOutput `pulumi:"displayName"`
	// Identity used for BYOS
	Identity ManagedIdentityResponsePtrOutput `pulumi:"identity"`
	// The kind of workbook. Choices are user and shared.
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Resource location
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Azure resource name
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// Configuration of this particular private workbook. Configuration data is a string containing valid JSON
	SerializedData pulumi.StringOutput `pulumi:"serializedData"`
	// Optional resourceId for a source resource.
	SourceId pulumi.StringPtrOutput `pulumi:"sourceId"`
	// BYOS Storage Account URI
	StorageUri pulumi.StringPtrOutput `pulumi:"storageUri"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Date and time in UTC of the last modification that was made to this private workbook definition.
	TimeModified pulumi.StringOutput `pulumi:"timeModified"`
	// Azure resource type
	Type pulumi.StringPtrOutput `pulumi:"type"`
	// Unique user id of the specific user that owns this private workbook.
	UserId pulumi.StringOutput `pulumi:"userId"`
	// This instance's version of the data model. This can change as new features are added that can be marked private workbook.
	Version pulumi.StringPtrOutput `pulumi:"version"`
}

// NewMyWorkbook registers a new resource with the given unique name, arguments, and options.
func NewMyWorkbook(ctx *pulumi.Context,
	name string, args *MyWorkbookArgs, opts ...pulumi.ResourceOption) (*MyWorkbook, error) {
	if args == nil || args.Category == nil {
		return nil, errors.New("missing required argument 'Category'")
	}
	if args == nil || args.DisplayName == nil {
		return nil, errors.New("missing required argument 'DisplayName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.ResourceName == nil {
		return nil, errors.New("missing required argument 'ResourceName'")
	}
	if args == nil || args.SerializedData == nil {
		return nil, errors.New("missing required argument 'SerializedData'")
	}
	if args == nil {
		args = &MyWorkbookArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:insights/latest:MyWorkbook"),
		},
		{
			Type: pulumi.String("azure-nextgen:insights/v20150501:MyWorkbook"),
		},
	})
	opts = append(opts, aliases)
	var resource MyWorkbook
	err := ctx.RegisterResource("azure-nextgen:insights/v20201020:MyWorkbook", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMyWorkbook gets an existing MyWorkbook resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMyWorkbook(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MyWorkbookState, opts ...pulumi.ResourceOption) (*MyWorkbook, error) {
	var resource MyWorkbook
	err := ctx.ReadResource("azure-nextgen:insights/v20201020:MyWorkbook", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MyWorkbook resources.
type myWorkbookState struct {
	// Workbook category, as defined by the user at creation time.
	Category *string `pulumi:"category"`
	// The user-defined name of the private workbook.
	DisplayName *string `pulumi:"displayName"`
	// Identity used for BYOS
	Identity *ManagedIdentityResponse `pulumi:"identity"`
	// The kind of workbook. Choices are user and shared.
	Kind *string `pulumi:"kind"`
	// Resource location
	Location *string `pulumi:"location"`
	// Azure resource name
	Name *string `pulumi:"name"`
	// Configuration of this particular private workbook. Configuration data is a string containing valid JSON
	SerializedData *string `pulumi:"serializedData"`
	// Optional resourceId for a source resource.
	SourceId *string `pulumi:"sourceId"`
	// BYOS Storage Account URI
	StorageUri *string `pulumi:"storageUri"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Date and time in UTC of the last modification that was made to this private workbook definition.
	TimeModified *string `pulumi:"timeModified"`
	// Azure resource type
	Type *string `pulumi:"type"`
	// Unique user id of the specific user that owns this private workbook.
	UserId *string `pulumi:"userId"`
	// This instance's version of the data model. This can change as new features are added that can be marked private workbook.
	Version *string `pulumi:"version"`
}

type MyWorkbookState struct {
	// Workbook category, as defined by the user at creation time.
	Category pulumi.StringPtrInput
	// The user-defined name of the private workbook.
	DisplayName pulumi.StringPtrInput
	// Identity used for BYOS
	Identity ManagedIdentityResponsePtrInput
	// The kind of workbook. Choices are user and shared.
	Kind pulumi.StringPtrInput
	// Resource location
	Location pulumi.StringPtrInput
	// Azure resource name
	Name pulumi.StringPtrInput
	// Configuration of this particular private workbook. Configuration data is a string containing valid JSON
	SerializedData pulumi.StringPtrInput
	// Optional resourceId for a source resource.
	SourceId pulumi.StringPtrInput
	// BYOS Storage Account URI
	StorageUri pulumi.StringPtrInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Date and time in UTC of the last modification that was made to this private workbook definition.
	TimeModified pulumi.StringPtrInput
	// Azure resource type
	Type pulumi.StringPtrInput
	// Unique user id of the specific user that owns this private workbook.
	UserId pulumi.StringPtrInput
	// This instance's version of the data model. This can change as new features are added that can be marked private workbook.
	Version pulumi.StringPtrInput
}

func (MyWorkbookState) ElementType() reflect.Type {
	return reflect.TypeOf((*myWorkbookState)(nil)).Elem()
}

type myWorkbookArgs struct {
	// Workbook category, as defined by the user at creation time.
	Category string `pulumi:"category"`
	// The user-defined name of the private workbook.
	DisplayName string `pulumi:"displayName"`
	// Azure resource Id
	Id *string `pulumi:"id"`
	// Identity used for BYOS
	Identity *ManagedIdentity `pulumi:"identity"`
	// The kind of workbook. Choices are user and shared.
	Kind *string `pulumi:"kind"`
	// Resource location
	Location *string `pulumi:"location"`
	// Azure resource name
	Name *string `pulumi:"name"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the Application Insights component resource.
	ResourceName string `pulumi:"resourceName"`
	// Configuration of this particular private workbook. Configuration data is a string containing valid JSON
	SerializedData string `pulumi:"serializedData"`
	// Optional resourceId for a source resource.
	SourceId *string `pulumi:"sourceId"`
	// BYOS Storage Account URI
	StorageUri *string `pulumi:"storageUri"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Azure resource type
	Type *string `pulumi:"type"`
	// This instance's version of the data model. This can change as new features are added that can be marked private workbook.
	Version *string `pulumi:"version"`
}

// The set of arguments for constructing a MyWorkbook resource.
type MyWorkbookArgs struct {
	// Workbook category, as defined by the user at creation time.
	Category pulumi.StringInput
	// The user-defined name of the private workbook.
	DisplayName pulumi.StringInput
	// Azure resource Id
	Id pulumi.StringPtrInput
	// Identity used for BYOS
	Identity ManagedIdentityPtrInput
	// The kind of workbook. Choices are user and shared.
	Kind pulumi.StringPtrInput
	// Resource location
	Location pulumi.StringPtrInput
	// Azure resource name
	Name pulumi.StringPtrInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// The name of the Application Insights component resource.
	ResourceName pulumi.StringInput
	// Configuration of this particular private workbook. Configuration data is a string containing valid JSON
	SerializedData pulumi.StringInput
	// Optional resourceId for a source resource.
	SourceId pulumi.StringPtrInput
	// BYOS Storage Account URI
	StorageUri pulumi.StringPtrInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Azure resource type
	Type pulumi.StringPtrInput
	// This instance's version of the data model. This can change as new features are added that can be marked private workbook.
	Version pulumi.StringPtrInput
}

func (MyWorkbookArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*myWorkbookArgs)(nil)).Elem()
}

type MyWorkbookInput interface {
	pulumi.Input

	ToMyWorkbookOutput() MyWorkbookOutput
	ToMyWorkbookOutputWithContext(ctx context.Context) MyWorkbookOutput
}

func (MyWorkbook) ElementType() reflect.Type {
	return reflect.TypeOf((*MyWorkbook)(nil)).Elem()
}

func (i MyWorkbook) ToMyWorkbookOutput() MyWorkbookOutput {
	return i.ToMyWorkbookOutputWithContext(context.Background())
}

func (i MyWorkbook) ToMyWorkbookOutputWithContext(ctx context.Context) MyWorkbookOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MyWorkbookOutput)
}

type MyWorkbookOutput struct {
	*pulumi.OutputState
}

func (MyWorkbookOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*MyWorkbookOutput)(nil)).Elem()
}

func (o MyWorkbookOutput) ToMyWorkbookOutput() MyWorkbookOutput {
	return o
}

func (o MyWorkbookOutput) ToMyWorkbookOutputWithContext(ctx context.Context) MyWorkbookOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(MyWorkbookOutput{})
}
