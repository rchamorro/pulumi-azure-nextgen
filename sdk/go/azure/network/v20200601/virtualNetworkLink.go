// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200601

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Describes a link to virtual network for a Private DNS zone.
type VirtualNetworkLink struct {
	pulumi.CustomResourceState

	// The ETag of the virtual network link.
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// The Azure Region where the resource lives
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// The provisioning state of the resource. This is a read-only property and any attempt to set this value will be ignored.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Is auto-registration of virtual machine records in the virtual network in the Private DNS zone enabled?
	RegistrationEnabled pulumi.BoolPtrOutput `pulumi:"registrationEnabled"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the resource. Example - 'Microsoft.Network/privateDnsZones'.
	Type pulumi.StringOutput `pulumi:"type"`
	// The reference of the virtual network.
	VirtualNetwork SubResourceResponsePtrOutput `pulumi:"virtualNetwork"`
	// The status of the virtual network link to the Private DNS zone. Possible values are 'InProgress' and 'Done'. This is a read-only property and any attempt to set this value will be ignored.
	VirtualNetworkLinkState pulumi.StringOutput `pulumi:"virtualNetworkLinkState"`
}

// NewVirtualNetworkLink registers a new resource with the given unique name, arguments, and options.
func NewVirtualNetworkLink(ctx *pulumi.Context,
	name string, args *VirtualNetworkLinkArgs, opts ...pulumi.ResourceOption) (*VirtualNetworkLink, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.PrivateZoneName == nil {
		return nil, errors.New("invalid value for required argument 'PrivateZoneName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.VirtualNetworkLinkName == nil {
		return nil, errors.New("invalid value for required argument 'VirtualNetworkLinkName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:VirtualNetworkLink"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180901:VirtualNetworkLink"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200101:VirtualNetworkLink"),
		},
	})
	opts = append(opts, aliases)
	var resource VirtualNetworkLink
	err := ctx.RegisterResource("azure-nextgen:network/v20200601:VirtualNetworkLink", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVirtualNetworkLink gets an existing VirtualNetworkLink resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVirtualNetworkLink(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VirtualNetworkLinkState, opts ...pulumi.ResourceOption) (*VirtualNetworkLink, error) {
	var resource VirtualNetworkLink
	err := ctx.ReadResource("azure-nextgen:network/v20200601:VirtualNetworkLink", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VirtualNetworkLink resources.
type virtualNetworkLinkState struct {
	// The ETag of the virtual network link.
	Etag *string `pulumi:"etag"`
	// The Azure Region where the resource lives
	Location *string `pulumi:"location"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// The provisioning state of the resource. This is a read-only property and any attempt to set this value will be ignored.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Is auto-registration of virtual machine records in the virtual network in the Private DNS zone enabled?
	RegistrationEnabled *bool `pulumi:"registrationEnabled"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource. Example - 'Microsoft.Network/privateDnsZones'.
	Type *string `pulumi:"type"`
	// The reference of the virtual network.
	VirtualNetwork *SubResourceResponse `pulumi:"virtualNetwork"`
	// The status of the virtual network link to the Private DNS zone. Possible values are 'InProgress' and 'Done'. This is a read-only property and any attempt to set this value will be ignored.
	VirtualNetworkLinkState *string `pulumi:"virtualNetworkLinkState"`
}

type VirtualNetworkLinkState struct {
	// The ETag of the virtual network link.
	Etag pulumi.StringPtrInput
	// The Azure Region where the resource lives
	Location pulumi.StringPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// The provisioning state of the resource. This is a read-only property and any attempt to set this value will be ignored.
	ProvisioningState pulumi.StringPtrInput
	// Is auto-registration of virtual machine records in the virtual network in the Private DNS zone enabled?
	RegistrationEnabled pulumi.BoolPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The type of the resource. Example - 'Microsoft.Network/privateDnsZones'.
	Type pulumi.StringPtrInput
	// The reference of the virtual network.
	VirtualNetwork SubResourceResponsePtrInput
	// The status of the virtual network link to the Private DNS zone. Possible values are 'InProgress' and 'Done'. This is a read-only property and any attempt to set this value will be ignored.
	VirtualNetworkLinkState pulumi.StringPtrInput
}

func (VirtualNetworkLinkState) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualNetworkLinkState)(nil)).Elem()
}

type virtualNetworkLinkArgs struct {
	// The ETag of the virtual network link.
	Etag *string `pulumi:"etag"`
	// The Azure Region where the resource lives
	Location *string `pulumi:"location"`
	// The name of the Private DNS zone (without a terminating dot).
	PrivateZoneName string `pulumi:"privateZoneName"`
	// Is auto-registration of virtual machine records in the virtual network in the Private DNS zone enabled?
	RegistrationEnabled *bool `pulumi:"registrationEnabled"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The reference of the virtual network.
	VirtualNetwork *SubResource `pulumi:"virtualNetwork"`
	// The name of the virtual network link.
	VirtualNetworkLinkName string `pulumi:"virtualNetworkLinkName"`
}

// The set of arguments for constructing a VirtualNetworkLink resource.
type VirtualNetworkLinkArgs struct {
	// The ETag of the virtual network link.
	Etag pulumi.StringPtrInput
	// The Azure Region where the resource lives
	Location pulumi.StringPtrInput
	// The name of the Private DNS zone (without a terminating dot).
	PrivateZoneName pulumi.StringInput
	// Is auto-registration of virtual machine records in the virtual network in the Private DNS zone enabled?
	RegistrationEnabled pulumi.BoolPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The reference of the virtual network.
	VirtualNetwork SubResourcePtrInput
	// The name of the virtual network link.
	VirtualNetworkLinkName pulumi.StringInput
}

func (VirtualNetworkLinkArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualNetworkLinkArgs)(nil)).Elem()
}

type VirtualNetworkLinkInput interface {
	pulumi.Input

	ToVirtualNetworkLinkOutput() VirtualNetworkLinkOutput
	ToVirtualNetworkLinkOutputWithContext(ctx context.Context) VirtualNetworkLinkOutput
}

func (*VirtualNetworkLink) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualNetworkLink)(nil))
}

func (i *VirtualNetworkLink) ToVirtualNetworkLinkOutput() VirtualNetworkLinkOutput {
	return i.ToVirtualNetworkLinkOutputWithContext(context.Background())
}

func (i *VirtualNetworkLink) ToVirtualNetworkLinkOutputWithContext(ctx context.Context) VirtualNetworkLinkOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VirtualNetworkLinkOutput)
}

type VirtualNetworkLinkOutput struct {
	*pulumi.OutputState
}

func (VirtualNetworkLinkOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualNetworkLink)(nil))
}

func (o VirtualNetworkLinkOutput) ToVirtualNetworkLinkOutput() VirtualNetworkLinkOutput {
	return o
}

func (o VirtualNetworkLinkOutput) ToVirtualNetworkLinkOutputWithContext(ctx context.Context) VirtualNetworkLinkOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(VirtualNetworkLinkOutput{})
}
