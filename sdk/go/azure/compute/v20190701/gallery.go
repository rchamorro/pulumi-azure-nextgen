// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190701

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Specifies information about the Shared Image Gallery that you want to create or update.
type Gallery struct {
	pulumi.CustomResourceState

	// The description of this Shared Image Gallery resource. This property is updatable.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Describes the gallery unique name.
	Identifier GalleryIdentifierResponsePtrOutput `pulumi:"identifier"`
	// Resource location
	Location pulumi.StringOutput `pulumi:"location"`
	// Resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// The provisioning state, which only appears in the response.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewGallery registers a new resource with the given unique name, arguments, and options.
func NewGallery(ctx *pulumi.Context,
	name string, args *GalleryArgs, opts ...pulumi.ResourceOption) (*Gallery, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.GalleryName == nil {
		return nil, errors.New("invalid value for required argument 'GalleryName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:compute/latest:Gallery"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20180601:Gallery"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20190301:Gallery"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20191201:Gallery"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20200930:Gallery"),
		},
	})
	opts = append(opts, aliases)
	var resource Gallery
	err := ctx.RegisterResource("azure-nextgen:compute/v20190701:Gallery", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetGallery gets an existing Gallery resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetGallery(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *GalleryState, opts ...pulumi.ResourceOption) (*Gallery, error) {
	var resource Gallery
	err := ctx.ReadResource("azure-nextgen:compute/v20190701:Gallery", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Gallery resources.
type galleryState struct {
	// The description of this Shared Image Gallery resource. This property is updatable.
	Description *string `pulumi:"description"`
	// Describes the gallery unique name.
	Identifier *GalleryIdentifierResponse `pulumi:"identifier"`
	// Resource location
	Location *string `pulumi:"location"`
	// Resource name
	Name *string `pulumi:"name"`
	// The provisioning state, which only appears in the response.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
}

type GalleryState struct {
	// The description of this Shared Image Gallery resource. This property is updatable.
	Description pulumi.StringPtrInput
	// Describes the gallery unique name.
	Identifier GalleryIdentifierResponsePtrInput
	// Resource location
	Location pulumi.StringPtrInput
	// Resource name
	Name pulumi.StringPtrInput
	// The provisioning state, which only appears in the response.
	ProvisioningState pulumi.StringPtrInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
}

func (GalleryState) ElementType() reflect.Type {
	return reflect.TypeOf((*galleryState)(nil)).Elem()
}

type galleryArgs struct {
	// The description of this Shared Image Gallery resource. This property is updatable.
	Description *string `pulumi:"description"`
	// The name of the Shared Image Gallery. The allowed characters are alphabets and numbers with dots and periods allowed in the middle. The maximum length is 80 characters.
	GalleryName string `pulumi:"galleryName"`
	// Resource location
	Location *string `pulumi:"location"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a Gallery resource.
type GalleryArgs struct {
	// The description of this Shared Image Gallery resource. This property is updatable.
	Description pulumi.StringPtrInput
	// The name of the Shared Image Gallery. The allowed characters are alphabets and numbers with dots and periods allowed in the middle. The maximum length is 80 characters.
	GalleryName pulumi.StringInput
	// Resource location
	Location pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// Resource tags
	Tags pulumi.StringMapInput
}

func (GalleryArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*galleryArgs)(nil)).Elem()
}

type GalleryInput interface {
	pulumi.Input

	ToGalleryOutput() GalleryOutput
	ToGalleryOutputWithContext(ctx context.Context) GalleryOutput
}

func (*Gallery) ElementType() reflect.Type {
	return reflect.TypeOf((*Gallery)(nil))
}

func (i *Gallery) ToGalleryOutput() GalleryOutput {
	return i.ToGalleryOutputWithContext(context.Background())
}

func (i *Gallery) ToGalleryOutputWithContext(ctx context.Context) GalleryOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GalleryOutput)
}

type GalleryOutput struct {
	*pulumi.OutputState
}

func (GalleryOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Gallery)(nil))
}

func (o GalleryOutput) ToGalleryOutput() GalleryOutput {
	return o
}

func (o GalleryOutput) ToGalleryOutputWithContext(ctx context.Context) GalleryOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(GalleryOutput{})
}
