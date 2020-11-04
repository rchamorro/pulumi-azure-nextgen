// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20170901

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Virtual Network resource.
type VirtualNetwork struct {
	pulumi.CustomResourceState

	// The AddressSpace that contains an array of IP address ranges that can be used by subnets.
	AddressSpace AddressSpaceResponsePtrOutput `pulumi:"addressSpace"`
	// The dhcpOptions that contains an array of DNS servers available to VMs deployed in the virtual network.
	DhcpOptions DhcpOptionsResponsePtrOutput `pulumi:"dhcpOptions"`
	// Indicates if DDoS protection is enabled for all the protected resources in a Virtual Network.
	EnableDdosProtection pulumi.BoolPtrOutput `pulumi:"enableDdosProtection"`
	// Indicates if Vm protection is enabled for all the subnets in a Virtual Network.
	EnableVmProtection pulumi.BoolPtrOutput `pulumi:"enableVmProtection"`
	// Gets a unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// Resource location.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The provisioning state of the PublicIP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
	ProvisioningState pulumi.StringPtrOutput `pulumi:"provisioningState"`
	// The resourceGuid property of the Virtual Network resource.
	ResourceGuid pulumi.StringPtrOutput `pulumi:"resourceGuid"`
	// A list of subnets in a Virtual Network.
	Subnets SubnetResponseArrayOutput `pulumi:"subnets"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
	// A list of peerings in a Virtual Network.
	VirtualNetworkPeerings VirtualNetworkPeeringResponseArrayOutput `pulumi:"virtualNetworkPeerings"`
}

// NewVirtualNetwork registers a new resource with the given unique name, arguments, and options.
func NewVirtualNetwork(ctx *pulumi.Context,
	name string, args *VirtualNetworkArgs, opts ...pulumi.ResourceOption) (*VirtualNetwork, error) {
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.VirtualNetworkName == nil {
		return nil, errors.New("missing required argument 'VirtualNetworkName'")
	}
	if args == nil {
		args = &VirtualNetworkArgs{}
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
			Type: pulumi.String("azure-nextgen:network/v20160601:VirtualNetwork"),
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
	})
	opts = append(opts, aliases)
	var resource VirtualNetwork
	err := ctx.RegisterResource("azure-nextgen:network/v20170901:VirtualNetwork", name, args, &resource, opts...)
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
	err := ctx.ReadResource("azure-nextgen:network/v20170901:VirtualNetwork", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VirtualNetwork resources.
type virtualNetworkState struct {
	// The AddressSpace that contains an array of IP address ranges that can be used by subnets.
	AddressSpace *AddressSpaceResponse `pulumi:"addressSpace"`
	// The dhcpOptions that contains an array of DNS servers available to VMs deployed in the virtual network.
	DhcpOptions *DhcpOptionsResponse `pulumi:"dhcpOptions"`
	// Indicates if DDoS protection is enabled for all the protected resources in a Virtual Network.
	EnableDdosProtection *bool `pulumi:"enableDdosProtection"`
	// Indicates if Vm protection is enabled for all the subnets in a Virtual Network.
	EnableVmProtection *bool `pulumi:"enableVmProtection"`
	// Gets a unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// Resource location.
	Location *string `pulumi:"location"`
	// Resource name.
	Name *string `pulumi:"name"`
	// The provisioning state of the PublicIP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The resourceGuid property of the Virtual Network resource.
	ResourceGuid *string `pulumi:"resourceGuid"`
	// A list of subnets in a Virtual Network.
	Subnets []SubnetResponse `pulumi:"subnets"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type *string `pulumi:"type"`
	// A list of peerings in a Virtual Network.
	VirtualNetworkPeerings []VirtualNetworkPeeringResponse `pulumi:"virtualNetworkPeerings"`
}

type VirtualNetworkState struct {
	// The AddressSpace that contains an array of IP address ranges that can be used by subnets.
	AddressSpace AddressSpaceResponsePtrInput
	// The dhcpOptions that contains an array of DNS servers available to VMs deployed in the virtual network.
	DhcpOptions DhcpOptionsResponsePtrInput
	// Indicates if DDoS protection is enabled for all the protected resources in a Virtual Network.
	EnableDdosProtection pulumi.BoolPtrInput
	// Indicates if Vm protection is enabled for all the subnets in a Virtual Network.
	EnableVmProtection pulumi.BoolPtrInput
	// Gets a unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// The provisioning state of the PublicIP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
	ProvisioningState pulumi.StringPtrInput
	// The resourceGuid property of the Virtual Network resource.
	ResourceGuid pulumi.StringPtrInput
	// A list of subnets in a Virtual Network.
	Subnets SubnetResponseArrayInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Resource type.
	Type pulumi.StringPtrInput
	// A list of peerings in a Virtual Network.
	VirtualNetworkPeerings VirtualNetworkPeeringResponseArrayInput
}

func (VirtualNetworkState) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualNetworkState)(nil)).Elem()
}

type virtualNetworkArgs struct {
	// The AddressSpace that contains an array of IP address ranges that can be used by subnets.
	AddressSpace *AddressSpace `pulumi:"addressSpace"`
	// The dhcpOptions that contains an array of DNS servers available to VMs deployed in the virtual network.
	DhcpOptions *DhcpOptions `pulumi:"dhcpOptions"`
	// Indicates if DDoS protection is enabled for all the protected resources in a Virtual Network.
	EnableDdosProtection *bool `pulumi:"enableDdosProtection"`
	// Indicates if Vm protection is enabled for all the subnets in a Virtual Network.
	EnableVmProtection *bool `pulumi:"enableVmProtection"`
	// Gets a unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// Resource ID.
	Id *string `pulumi:"id"`
	// Resource location.
	Location *string `pulumi:"location"`
	// The provisioning state of the PublicIP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The resourceGuid property of the Virtual Network resource.
	ResourceGuid *string `pulumi:"resourceGuid"`
	// A list of subnets in a Virtual Network.
	Subnets []SubnetType `pulumi:"subnets"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The name of the virtual network.
	VirtualNetworkName string `pulumi:"virtualNetworkName"`
	// A list of peerings in a Virtual Network.
	VirtualNetworkPeerings []VirtualNetworkPeeringType `pulumi:"virtualNetworkPeerings"`
}

// The set of arguments for constructing a VirtualNetwork resource.
type VirtualNetworkArgs struct {
	// The AddressSpace that contains an array of IP address ranges that can be used by subnets.
	AddressSpace AddressSpacePtrInput
	// The dhcpOptions that contains an array of DNS servers available to VMs deployed in the virtual network.
	DhcpOptions DhcpOptionsPtrInput
	// Indicates if DDoS protection is enabled for all the protected resources in a Virtual Network.
	EnableDdosProtection pulumi.BoolPtrInput
	// Indicates if Vm protection is enabled for all the subnets in a Virtual Network.
	EnableVmProtection pulumi.BoolPtrInput
	// Gets a unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// Resource ID.
	Id pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// The provisioning state of the PublicIP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
	ProvisioningState pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// The resourceGuid property of the Virtual Network resource.
	ResourceGuid pulumi.StringPtrInput
	// A list of subnets in a Virtual Network.
	Subnets SubnetTypeArrayInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The name of the virtual network.
	VirtualNetworkName pulumi.StringInput
	// A list of peerings in a Virtual Network.
	VirtualNetworkPeerings VirtualNetworkPeeringTypeArrayInput
}

func (VirtualNetworkArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualNetworkArgs)(nil)).Elem()
}
