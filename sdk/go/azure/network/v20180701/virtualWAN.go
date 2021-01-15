// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180701

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// VirtualWAN Resource.
type VirtualWAN struct {
	pulumi.CustomResourceState

	// Vpn encryption to be disabled or not.
	DisableVpnEncryption pulumi.BoolPtrOutput `pulumi:"disableVpnEncryption"`
	// Gets a unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// Resource location.
	Location pulumi.StringOutput `pulumi:"location"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The provisioning state of the resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
	// List of VirtualHubs in the VirtualWAN.
	VirtualHubs SubResourceResponseArrayOutput `pulumi:"virtualHubs"`
	VpnSites    SubResourceResponseArrayOutput `pulumi:"vpnSites"`
}

// NewVirtualWAN registers a new resource with the given unique name, arguments, and options.
func NewVirtualWAN(ctx *pulumi.Context,
	name string, args *VirtualWANArgs, opts ...pulumi.ResourceOption) (*VirtualWAN, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Location == nil {
		return nil, errors.New("invalid value for required argument 'Location'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.VirtualWANName == nil {
		return nil, errors.New("invalid value for required argument 'VirtualWANName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:VirtualWAN"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180401:VirtualWAN"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180601:VirtualWAN"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180801:VirtualWAN"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181001:VirtualWAN"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181101:VirtualWAN"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181201:VirtualWAN"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190201:VirtualWAN"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190401:VirtualWAN"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190601:VirtualWAN"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190701:VirtualWAN"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190801:VirtualWAN"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190901:VirtualWAN"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191101:VirtualWAN"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191201:VirtualWAN"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200301:VirtualWAN"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:VirtualWAN"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:VirtualWAN"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200601:VirtualWAN"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:VirtualWAN"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200801:VirtualWAN"),
		},
	})
	opts = append(opts, aliases)
	var resource VirtualWAN
	err := ctx.RegisterResource("azure-nextgen:network/v20180701:VirtualWAN", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVirtualWAN gets an existing VirtualWAN resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVirtualWAN(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VirtualWANState, opts ...pulumi.ResourceOption) (*VirtualWAN, error) {
	var resource VirtualWAN
	err := ctx.ReadResource("azure-nextgen:network/v20180701:VirtualWAN", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VirtualWAN resources.
type virtualWANState struct {
	// Vpn encryption to be disabled or not.
	DisableVpnEncryption *bool `pulumi:"disableVpnEncryption"`
	// Gets a unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// Resource location.
	Location *string `pulumi:"location"`
	// Resource name.
	Name *string `pulumi:"name"`
	// The provisioning state of the resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type *string `pulumi:"type"`
	// List of VirtualHubs in the VirtualWAN.
	VirtualHubs []SubResourceResponse `pulumi:"virtualHubs"`
	VpnSites    []SubResourceResponse `pulumi:"vpnSites"`
}

type VirtualWANState struct {
	// Vpn encryption to be disabled or not.
	DisableVpnEncryption pulumi.BoolPtrInput
	// Gets a unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// The provisioning state of the resource.
	ProvisioningState pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Resource type.
	Type pulumi.StringPtrInput
	// List of VirtualHubs in the VirtualWAN.
	VirtualHubs SubResourceResponseArrayInput
	VpnSites    SubResourceResponseArrayInput
}

func (VirtualWANState) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualWANState)(nil)).Elem()
}

type virtualWANArgs struct {
	// Vpn encryption to be disabled or not.
	DisableVpnEncryption *bool `pulumi:"disableVpnEncryption"`
	// Resource ID.
	Id *string `pulumi:"id"`
	// Resource location.
	Location string `pulumi:"location"`
	// The resource group name of the VirtualWan.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The name of the VirtualWAN being created or updated.
	VirtualWANName string `pulumi:"virtualWANName"`
}

// The set of arguments for constructing a VirtualWAN resource.
type VirtualWANArgs struct {
	// Vpn encryption to be disabled or not.
	DisableVpnEncryption pulumi.BoolPtrInput
	// Resource ID.
	Id pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringInput
	// The resource group name of the VirtualWan.
	ResourceGroupName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The name of the VirtualWAN being created or updated.
	VirtualWANName pulumi.StringInput
}

func (VirtualWANArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualWANArgs)(nil)).Elem()
}

type VirtualWANInput interface {
	pulumi.Input

	ToVirtualWANOutput() VirtualWANOutput
	ToVirtualWANOutputWithContext(ctx context.Context) VirtualWANOutput
}

func (*VirtualWAN) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualWAN)(nil))
}

func (i *VirtualWAN) ToVirtualWANOutput() VirtualWANOutput {
	return i.ToVirtualWANOutputWithContext(context.Background())
}

func (i *VirtualWAN) ToVirtualWANOutputWithContext(ctx context.Context) VirtualWANOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VirtualWANOutput)
}

type VirtualWANOutput struct {
	*pulumi.OutputState
}

func (VirtualWANOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualWAN)(nil))
}

func (o VirtualWANOutput) ToVirtualWANOutput() VirtualWANOutput {
	return o
}

func (o VirtualWANOutput) ToVirtualWANOutputWithContext(ctx context.Context) VirtualWANOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(VirtualWANOutput{})
}
