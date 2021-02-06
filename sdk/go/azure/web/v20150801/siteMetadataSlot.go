// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20150801

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// String dictionary resource
type SiteMetadataSlot struct {
	pulumi.CustomResourceState

	// Kind of resource
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Resource Location
	Location pulumi.StringOutput `pulumi:"location"`
	// Resource Name
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// Settings
	Properties pulumi.StringMapOutput `pulumi:"properties"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type
	Type pulumi.StringPtrOutput `pulumi:"type"`
}

// NewSiteMetadataSlot registers a new resource with the given unique name, arguments, and options.
func NewSiteMetadataSlot(ctx *pulumi.Context,
	name string, args *SiteMetadataSlotArgs, opts ...pulumi.ResourceOption) (*SiteMetadataSlot, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.Slot == nil {
		return nil, errors.New("invalid value for required argument 'Slot'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:web/latest:SiteMetadataSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20160801:SiteMetadataSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20180201:SiteMetadataSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20181101:SiteMetadataSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20190801:SiteMetadataSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200601:SiteMetadataSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200901:SiteMetadataSlot"),
		},
	})
	opts = append(opts, aliases)
	var resource SiteMetadataSlot
	err := ctx.RegisterResource("azure-nextgen:web/v20150801:SiteMetadataSlot", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSiteMetadataSlot gets an existing SiteMetadataSlot resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSiteMetadataSlot(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SiteMetadataSlotState, opts ...pulumi.ResourceOption) (*SiteMetadataSlot, error) {
	var resource SiteMetadataSlot
	err := ctx.ReadResource("azure-nextgen:web/v20150801:SiteMetadataSlot", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SiteMetadataSlot resources.
type siteMetadataSlotState struct {
	// Kind of resource
	Kind *string `pulumi:"kind"`
	// Resource Location
	Location *string `pulumi:"location"`
	// Resource Name
	Name *string `pulumi:"name"`
	// Settings
	Properties map[string]string `pulumi:"properties"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
}

type SiteMetadataSlotState struct {
	// Kind of resource
	Kind pulumi.StringPtrInput
	// Resource Location
	Location pulumi.StringPtrInput
	// Resource Name
	Name pulumi.StringPtrInput
	// Settings
	Properties pulumi.StringMapInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
}

func (SiteMetadataSlotState) ElementType() reflect.Type {
	return reflect.TypeOf((*siteMetadataSlotState)(nil)).Elem()
}

type siteMetadataSlotArgs struct {
	// Resource Id
	Id *string `pulumi:"id"`
	// Kind of resource
	Kind *string `pulumi:"kind"`
	// Resource Location
	Location *string `pulumi:"location"`
	// Resource Name
	Name string `pulumi:"name"`
	// Settings
	Properties map[string]string `pulumi:"properties"`
	// Name of resource group
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Name of web app slot. If not specified then will default to production slot.
	Slot string `pulumi:"slot"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
}

// The set of arguments for constructing a SiteMetadataSlot resource.
type SiteMetadataSlotArgs struct {
	// Resource Id
	Id pulumi.StringPtrInput
	// Kind of resource
	Kind pulumi.StringPtrInput
	// Resource Location
	Location pulumi.StringPtrInput
	// Resource Name
	Name pulumi.StringInput
	// Settings
	Properties pulumi.StringMapInput
	// Name of resource group
	ResourceGroupName pulumi.StringInput
	// Name of web app slot. If not specified then will default to production slot.
	Slot pulumi.StringInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
}

func (SiteMetadataSlotArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*siteMetadataSlotArgs)(nil)).Elem()
}

type SiteMetadataSlotInput interface {
	pulumi.Input

	ToSiteMetadataSlotOutput() SiteMetadataSlotOutput
	ToSiteMetadataSlotOutputWithContext(ctx context.Context) SiteMetadataSlotOutput
}

func (*SiteMetadataSlot) ElementType() reflect.Type {
	return reflect.TypeOf((*SiteMetadataSlot)(nil))
}

func (i *SiteMetadataSlot) ToSiteMetadataSlotOutput() SiteMetadataSlotOutput {
	return i.ToSiteMetadataSlotOutputWithContext(context.Background())
}

func (i *SiteMetadataSlot) ToSiteMetadataSlotOutputWithContext(ctx context.Context) SiteMetadataSlotOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SiteMetadataSlotOutput)
}

type SiteMetadataSlotOutput struct {
	*pulumi.OutputState
}

func (SiteMetadataSlotOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SiteMetadataSlot)(nil))
}

func (o SiteMetadataSlotOutput) ToSiteMetadataSlotOutput() SiteMetadataSlotOutput {
	return o
}

func (o SiteMetadataSlotOutput) ToSiteMetadataSlotOutputWithContext(ctx context.Context) SiteMetadataSlotOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(SiteMetadataSlotOutput{})
}
