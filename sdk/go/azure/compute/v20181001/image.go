// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20181001

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The source user image virtual hard disk. The virtual hard disk will be copied before being attached to the virtual machine. If SourceImage is provided, the destination virtual hard drive must not exist.
type Image struct {
	pulumi.CustomResourceState

	// Resource location
	Location pulumi.StringOutput `pulumi:"location"`
	// Resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// The provisioning state.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The source virtual machine from which Image is created.
	SourceVirtualMachine SubResourceResponsePtrOutput `pulumi:"sourceVirtualMachine"`
	// Specifies the storage settings for the virtual machine disks.
	StorageProfile ImageStorageProfileResponsePtrOutput `pulumi:"storageProfile"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewImage registers a new resource with the given unique name, arguments, and options.
func NewImage(ctx *pulumi.Context,
	name string, args *ImageArgs, opts ...pulumi.ResourceOption) (*Image, error) {
	if args == nil || args.ImageName == nil {
		return nil, errors.New("missing required argument 'ImageName'")
	}
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &ImageArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:compute/latest:Image"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20160430preview:Image"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20170330:Image"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20171201:Image"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20180401:Image"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20180601:Image"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20190301:Image"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20190701:Image"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20191201:Image"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20200601:Image"),
		},
	})
	opts = append(opts, aliases)
	var resource Image
	err := ctx.RegisterResource("azure-nextgen:compute/v20181001:Image", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetImage gets an existing Image resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetImage(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ImageState, opts ...pulumi.ResourceOption) (*Image, error) {
	var resource Image
	err := ctx.ReadResource("azure-nextgen:compute/v20181001:Image", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Image resources.
type imageState struct {
	// Resource location
	Location *string `pulumi:"location"`
	// Resource name
	Name *string `pulumi:"name"`
	// The provisioning state.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The source virtual machine from which Image is created.
	SourceVirtualMachine *SubResourceResponse `pulumi:"sourceVirtualMachine"`
	// Specifies the storage settings for the virtual machine disks.
	StorageProfile *ImageStorageProfileResponse `pulumi:"storageProfile"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
}

type ImageState struct {
	// Resource location
	Location pulumi.StringPtrInput
	// Resource name
	Name pulumi.StringPtrInput
	// The provisioning state.
	ProvisioningState pulumi.StringPtrInput
	// The source virtual machine from which Image is created.
	SourceVirtualMachine SubResourceResponsePtrInput
	// Specifies the storage settings for the virtual machine disks.
	StorageProfile ImageStorageProfileResponsePtrInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
}

func (ImageState) ElementType() reflect.Type {
	return reflect.TypeOf((*imageState)(nil)).Elem()
}

type imageArgs struct {
	// The name of the image.
	ImageName string `pulumi:"imageName"`
	// Resource location
	Location string `pulumi:"location"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The source virtual machine from which Image is created.
	SourceVirtualMachine *SubResource `pulumi:"sourceVirtualMachine"`
	// Specifies the storage settings for the virtual machine disks.
	StorageProfile *ImageStorageProfile `pulumi:"storageProfile"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a Image resource.
type ImageArgs struct {
	// The name of the image.
	ImageName pulumi.StringInput
	// Resource location
	Location pulumi.StringInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// The source virtual machine from which Image is created.
	SourceVirtualMachine SubResourcePtrInput
	// Specifies the storage settings for the virtual machine disks.
	StorageProfile ImageStorageProfilePtrInput
	// Resource tags
	Tags pulumi.StringMapInput
}

func (ImageArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*imageArgs)(nil)).Elem()
}

type ImageInput interface {
	pulumi.Input

	ToImageOutput() ImageOutput
	ToImageOutputWithContext(ctx context.Context) ImageOutput
}

func (Image) ElementType() reflect.Type {
	return reflect.TypeOf((*Image)(nil)).Elem()
}

func (i Image) ToImageOutput() ImageOutput {
	return i.ToImageOutputWithContext(context.Background())
}

func (i Image) ToImageOutputWithContext(ctx context.Context) ImageOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ImageOutput)
}

type ImageOutput struct {
	*pulumi.OutputState
}

func (ImageOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ImageOutput)(nil)).Elem()
}

func (o ImageOutput) ToImageOutput() ImageOutput {
	return o
}

func (o ImageOutput) ToImageOutputWithContext(ctx context.Context) ImageOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ImageOutput{})
}
