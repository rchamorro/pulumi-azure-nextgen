// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20160601

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Virtual Network resource
type VirtualNetwork struct {
	pulumi.CustomResourceState

	// Gets or sets AddressSpace that contains an array of IP address ranges that can be used by subnets
	AddressSpace AddressSpaceResponsePtrOutput `pulumi:"addressSpace"`
	// Gets or sets DHCPOptions that contains an array of DNS servers available to VMs deployed in the virtual network
	DhcpOptions DhcpOptionsResponsePtrOutput `pulumi:"dhcpOptions"`
	// Gets a unique read-only string that changes whenever the resource is updated
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// Resource location
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// Gets provisioning state of the PublicIP resource Updating/Deleting/Failed
	ProvisioningState pulumi.StringPtrOutput `pulumi:"provisioningState"`
	// Gets or sets resource guid property of the VirtualNetwork resource
	ResourceGuid pulumi.StringPtrOutput `pulumi:"resourceGuid"`
	// Gets or sets list of subnets in a VirtualNetwork
	Subnets SubnetResponseArrayOutput `pulumi:"subnets"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type
	Type pulumi.StringOutput `pulumi:"type"`
	// Gets or sets list of peerings in a VirtualNetwork
	VirtualNetworkPeerings VirtualNetworkPeeringResponseArrayOutput `pulumi:"virtualNetworkPeerings"`
}

// NewVirtualNetwork registers a new resource with the given unique name, arguments, and options.
func NewVirtualNetwork(ctx *pulumi.Context,
	name string, args *VirtualNetworkArgs, opts ...pulumi.ResourceOption) (*VirtualNetwork, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.VirtualNetworkName == nil {
		return nil, errors.New("invalid value for required argument 'VirtualNetworkName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20150501preview:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20150615:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20160330:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20160901:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20161201:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170301:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170601:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170801:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170901:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20171001:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20171101:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180101:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180201:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180401:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180601:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180701:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180801:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181001:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181101:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181201:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190201:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190401:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190601:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190701:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190801:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190901:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191101:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191201:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200301:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200601:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:VirtualNetwork"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200801:VirtualNetwork"),
		},
	})
	opts = append(opts, aliases)
	var resource VirtualNetwork
	err := ctx.RegisterResource("azure-nextgen:network/v20160601:VirtualNetwork", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVirtualNetwork gets an existing VirtualNetwork resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVirtualNetwork(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VirtualNetworkState, opts ...pulumi.ResourceOption) (*VirtualNetwork, error) {
	var resource VirtualNetwork
	err := ctx.ReadResource("azure-nextgen:network/v20160601:VirtualNetwork", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VirtualNetwork resources.
type virtualNetworkState struct {
	// Gets or sets AddressSpace that contains an array of IP address ranges that can be used by subnets
	AddressSpace *AddressSpaceResponse `pulumi:"addressSpace"`
	// Gets or sets DHCPOptions that contains an array of DNS servers available to VMs deployed in the virtual network
	DhcpOptions *DhcpOptionsResponse `pulumi:"dhcpOptions"`
	// Gets a unique read-only string that changes whenever the resource is updated
	Etag *string `pulumi:"etag"`
	// Resource location
	Location *string `pulumi:"location"`
	// Resource name
	Name *string `pulumi:"name"`
	// Gets provisioning state of the PublicIP resource Updating/Deleting/Failed
	ProvisioningState *string `pulumi:"provisioningState"`
	// Gets or sets resource guid property of the VirtualNetwork resource
	ResourceGuid *string `pulumi:"resourceGuid"`
	// Gets or sets list of subnets in a VirtualNetwork
	Subnets []SubnetResponse `pulumi:"subnets"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
	// Gets or sets list of peerings in a VirtualNetwork
	VirtualNetworkPeerings []VirtualNetworkPeeringResponse `pulumi:"virtualNetworkPeerings"`
}

type VirtualNetworkState struct {
	// Gets or sets AddressSpace that contains an array of IP address ranges that can be used by subnets
	AddressSpace AddressSpaceResponsePtrInput
	// Gets or sets DHCPOptions that contains an array of DNS servers available to VMs deployed in the virtual network
	DhcpOptions DhcpOptionsResponsePtrInput
	// Gets a unique read-only string that changes whenever the resource is updated
	Etag pulumi.StringPtrInput
	// Resource location
	Location pulumi.StringPtrInput
	// Resource name
	Name pulumi.StringPtrInput
	// Gets provisioning state of the PublicIP resource Updating/Deleting/Failed
	ProvisioningState pulumi.StringPtrInput
	// Gets or sets resource guid property of the VirtualNetwork resource
	ResourceGuid pulumi.StringPtrInput
	// Gets or sets list of subnets in a VirtualNetwork
	Subnets SubnetResponseArrayInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
	// Gets or sets list of peerings in a VirtualNetwork
	VirtualNetworkPeerings VirtualNetworkPeeringResponseArrayInput
}

func (VirtualNetworkState) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualNetworkState)(nil)).Elem()
}

type virtualNetworkArgs struct {
	// Gets or sets AddressSpace that contains an array of IP address ranges that can be used by subnets
	AddressSpace *AddressSpace `pulumi:"addressSpace"`
	// Gets or sets DHCPOptions that contains an array of DNS servers available to VMs deployed in the virtual network
	DhcpOptions *DhcpOptions `pulumi:"dhcpOptions"`
	// Gets a unique read-only string that changes whenever the resource is updated
	Etag *string `pulumi:"etag"`
	// Resource Id
	Id *string `pulumi:"id"`
	// Resource location
	Location *string `pulumi:"location"`
	// Gets provisioning state of the PublicIP resource Updating/Deleting/Failed
	ProvisioningState *string `pulumi:"provisioningState"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Gets or sets resource guid property of the VirtualNetwork resource
	ResourceGuid *string `pulumi:"resourceGuid"`
	// Gets or sets list of subnets in a VirtualNetwork
	Subnets []SubnetType `pulumi:"subnets"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// The name of the virtual network.
	VirtualNetworkName string `pulumi:"virtualNetworkName"`
	// Gets or sets list of peerings in a VirtualNetwork
	VirtualNetworkPeerings []VirtualNetworkPeeringType `pulumi:"virtualNetworkPeerings"`
}

// The set of arguments for constructing a VirtualNetwork resource.
type VirtualNetworkArgs struct {
	// Gets or sets AddressSpace that contains an array of IP address ranges that can be used by subnets
	AddressSpace AddressSpacePtrInput
	// Gets or sets DHCPOptions that contains an array of DNS servers available to VMs deployed in the virtual network
	DhcpOptions DhcpOptionsPtrInput
	// Gets a unique read-only string that changes whenever the resource is updated
	Etag pulumi.StringPtrInput
	// Resource Id
	Id pulumi.StringPtrInput
	// Resource location
	Location pulumi.StringPtrInput
	// Gets provisioning state of the PublicIP resource Updating/Deleting/Failed
	ProvisioningState pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// Gets or sets resource guid property of the VirtualNetwork resource
	ResourceGuid pulumi.StringPtrInput
	// Gets or sets list of subnets in a VirtualNetwork
	Subnets SubnetTypeArrayInput
	// Resource tags
	Tags pulumi.StringMapInput
	// The name of the virtual network.
	VirtualNetworkName pulumi.StringInput
	// Gets or sets list of peerings in a VirtualNetwork
	VirtualNetworkPeerings VirtualNetworkPeeringTypeArrayInput
}

func (VirtualNetworkArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualNetworkArgs)(nil)).Elem()
}

type VirtualNetworkInput interface {
	pulumi.Input

	ToVirtualNetworkOutput() VirtualNetworkOutput
	ToVirtualNetworkOutputWithContext(ctx context.Context) VirtualNetworkOutput
}

func (*VirtualNetwork) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualNetwork)(nil))
}

func (i *VirtualNetwork) ToVirtualNetworkOutput() VirtualNetworkOutput {
	return i.ToVirtualNetworkOutputWithContext(context.Background())
}

func (i *VirtualNetwork) ToVirtualNetworkOutputWithContext(ctx context.Context) VirtualNetworkOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VirtualNetworkOutput)
}

type VirtualNetworkOutput struct {
	*pulumi.OutputState
}

func (VirtualNetworkOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualNetwork)(nil))
}

func (o VirtualNetworkOutput) ToVirtualNetworkOutput() VirtualNetworkOutput {
	return o
}

func (o VirtualNetworkOutput) ToVirtualNetworkOutputWithContext(ctx context.Context) VirtualNetworkOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(VirtualNetworkOutput{})
}
