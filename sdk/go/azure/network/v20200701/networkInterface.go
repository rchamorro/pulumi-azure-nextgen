// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200701

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A network interface in a resource group.
type NetworkInterface struct {
	pulumi.CustomResourceState

	// The DNS settings in network interface.
	DnsSettings NetworkInterfaceDnsSettingsResponsePtrOutput `pulumi:"dnsSettings"`
	// A reference to the dscp configuration to which the network interface is linked.
	DscpConfiguration SubResourceResponseOutput `pulumi:"dscpConfiguration"`
	// If the network interface is accelerated networking enabled.
	EnableAcceleratedNetworking pulumi.BoolPtrOutput `pulumi:"enableAcceleratedNetworking"`
	// Indicates whether IP forwarding is enabled on this network interface.
	EnableIPForwarding pulumi.BoolPtrOutput `pulumi:"enableIPForwarding"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// The extended location of the network interface.
	ExtendedLocation ExtendedLocationResponsePtrOutput `pulumi:"extendedLocation"`
	// A list of references to linked BareMetal resources.
	HostedWorkloads pulumi.StringArrayOutput `pulumi:"hostedWorkloads"`
	// A list of IPConfigurations of the network interface.
	IpConfigurations NetworkInterfaceIPConfigurationResponseArrayOutput `pulumi:"ipConfigurations"`
	// Resource location.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// The MAC address of the network interface.
	MacAddress pulumi.StringOutput `pulumi:"macAddress"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The reference to the NetworkSecurityGroup resource.
	NetworkSecurityGroup NetworkSecurityGroupResponsePtrOutput `pulumi:"networkSecurityGroup"`
	// Whether this is a primary network interface on a virtual machine.
	Primary pulumi.BoolOutput `pulumi:"primary"`
	// A reference to the private endpoint to which the network interface is linked.
	PrivateEndpoint PrivateEndpointResponseOutput `pulumi:"privateEndpoint"`
	// The provisioning state of the network interface resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The resource GUID property of the network interface resource.
	ResourceGuid pulumi.StringOutput `pulumi:"resourceGuid"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// A list of TapConfigurations of the network interface.
	TapConfigurations NetworkInterfaceTapConfigurationResponseArrayOutput `pulumi:"tapConfigurations"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
	// The reference to a virtual machine.
	VirtualMachine SubResourceResponseOutput `pulumi:"virtualMachine"`
}

// NewNetworkInterface registers a new resource with the given unique name, arguments, and options.
func NewNetworkInterface(ctx *pulumi.Context,
	name string, args *NetworkInterfaceArgs, opts ...pulumi.ResourceOption) (*NetworkInterface, error) {
	if args == nil || args.NetworkInterfaceName == nil {
		return nil, errors.New("missing required argument 'NetworkInterfaceName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &NetworkInterfaceArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20150501preview:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20150615:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20160330:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20160601:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20160901:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20161201:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170301:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170601:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170801:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170901:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20171001:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20171101:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180101:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180201:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180401:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180601:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180701:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180801:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181001:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181101:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181201:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190201:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190401:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190601:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190701:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190801:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190901:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191101:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191201:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200301:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:NetworkInterface"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200601:NetworkInterface"),
		},
	})
	opts = append(opts, aliases)
	var resource NetworkInterface
	err := ctx.RegisterResource("azure-nextgen:network/v20200701:NetworkInterface", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNetworkInterface gets an existing NetworkInterface resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNetworkInterface(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NetworkInterfaceState, opts ...pulumi.ResourceOption) (*NetworkInterface, error) {
	var resource NetworkInterface
	err := ctx.ReadResource("azure-nextgen:network/v20200701:NetworkInterface", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering NetworkInterface resources.
type networkInterfaceState struct {
	// The DNS settings in network interface.
	DnsSettings *NetworkInterfaceDnsSettingsResponse `pulumi:"dnsSettings"`
	// A reference to the dscp configuration to which the network interface is linked.
	DscpConfiguration *SubResourceResponse `pulumi:"dscpConfiguration"`
	// If the network interface is accelerated networking enabled.
	EnableAcceleratedNetworking *bool `pulumi:"enableAcceleratedNetworking"`
	// Indicates whether IP forwarding is enabled on this network interface.
	EnableIPForwarding *bool `pulumi:"enableIPForwarding"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// The extended location of the network interface.
	ExtendedLocation *ExtendedLocationResponse `pulumi:"extendedLocation"`
	// A list of references to linked BareMetal resources.
	HostedWorkloads []string `pulumi:"hostedWorkloads"`
	// A list of IPConfigurations of the network interface.
	IpConfigurations []NetworkInterfaceIPConfigurationResponse `pulumi:"ipConfigurations"`
	// Resource location.
	Location *string `pulumi:"location"`
	// The MAC address of the network interface.
	MacAddress *string `pulumi:"macAddress"`
	// Resource name.
	Name *string `pulumi:"name"`
	// The reference to the NetworkSecurityGroup resource.
	NetworkSecurityGroup *NetworkSecurityGroupResponse `pulumi:"networkSecurityGroup"`
	// Whether this is a primary network interface on a virtual machine.
	Primary *bool `pulumi:"primary"`
	// A reference to the private endpoint to which the network interface is linked.
	PrivateEndpoint *PrivateEndpointResponse `pulumi:"privateEndpoint"`
	// The provisioning state of the network interface resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The resource GUID property of the network interface resource.
	ResourceGuid *string `pulumi:"resourceGuid"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// A list of TapConfigurations of the network interface.
	TapConfigurations []NetworkInterfaceTapConfigurationResponse `pulumi:"tapConfigurations"`
	// Resource type.
	Type *string `pulumi:"type"`
	// The reference to a virtual machine.
	VirtualMachine *SubResourceResponse `pulumi:"virtualMachine"`
}

type NetworkInterfaceState struct {
	// The DNS settings in network interface.
	DnsSettings NetworkInterfaceDnsSettingsResponsePtrInput
	// A reference to the dscp configuration to which the network interface is linked.
	DscpConfiguration SubResourceResponsePtrInput
	// If the network interface is accelerated networking enabled.
	EnableAcceleratedNetworking pulumi.BoolPtrInput
	// Indicates whether IP forwarding is enabled on this network interface.
	EnableIPForwarding pulumi.BoolPtrInput
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// The extended location of the network interface.
	ExtendedLocation ExtendedLocationResponsePtrInput
	// A list of references to linked BareMetal resources.
	HostedWorkloads pulumi.StringArrayInput
	// A list of IPConfigurations of the network interface.
	IpConfigurations NetworkInterfaceIPConfigurationResponseArrayInput
	// Resource location.
	Location pulumi.StringPtrInput
	// The MAC address of the network interface.
	MacAddress pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// The reference to the NetworkSecurityGroup resource.
	NetworkSecurityGroup NetworkSecurityGroupResponsePtrInput
	// Whether this is a primary network interface on a virtual machine.
	Primary pulumi.BoolPtrInput
	// A reference to the private endpoint to which the network interface is linked.
	PrivateEndpoint PrivateEndpointResponsePtrInput
	// The provisioning state of the network interface resource.
	ProvisioningState pulumi.StringPtrInput
	// The resource GUID property of the network interface resource.
	ResourceGuid pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// A list of TapConfigurations of the network interface.
	TapConfigurations NetworkInterfaceTapConfigurationResponseArrayInput
	// Resource type.
	Type pulumi.StringPtrInput
	// The reference to a virtual machine.
	VirtualMachine SubResourceResponsePtrInput
}

func (NetworkInterfaceState) ElementType() reflect.Type {
	return reflect.TypeOf((*networkInterfaceState)(nil)).Elem()
}

type networkInterfaceArgs struct {
	// The DNS settings in network interface.
	DnsSettings *NetworkInterfaceDnsSettings `pulumi:"dnsSettings"`
	// If the network interface is accelerated networking enabled.
	EnableAcceleratedNetworking *bool `pulumi:"enableAcceleratedNetworking"`
	// Indicates whether IP forwarding is enabled on this network interface.
	EnableIPForwarding *bool `pulumi:"enableIPForwarding"`
	// The extended location of the network interface.
	ExtendedLocation *ExtendedLocation `pulumi:"extendedLocation"`
	// Resource ID.
	Id *string `pulumi:"id"`
	// A list of IPConfigurations of the network interface.
	IpConfigurations []NetworkInterfaceIPConfiguration `pulumi:"ipConfigurations"`
	// Resource location.
	Location *string `pulumi:"location"`
	// The name of the network interface.
	NetworkInterfaceName string `pulumi:"networkInterfaceName"`
	// The reference to the NetworkSecurityGroup resource.
	NetworkSecurityGroup *NetworkSecurityGroupType `pulumi:"networkSecurityGroup"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a NetworkInterface resource.
type NetworkInterfaceArgs struct {
	// The DNS settings in network interface.
	DnsSettings NetworkInterfaceDnsSettingsPtrInput
	// If the network interface is accelerated networking enabled.
	EnableAcceleratedNetworking pulumi.BoolPtrInput
	// Indicates whether IP forwarding is enabled on this network interface.
	EnableIPForwarding pulumi.BoolPtrInput
	// The extended location of the network interface.
	ExtendedLocation ExtendedLocationPtrInput
	// Resource ID.
	Id pulumi.StringPtrInput
	// A list of IPConfigurations of the network interface.
	IpConfigurations NetworkInterfaceIPConfigurationArrayInput
	// Resource location.
	Location pulumi.StringPtrInput
	// The name of the network interface.
	NetworkInterfaceName pulumi.StringInput
	// The reference to the NetworkSecurityGroup resource.
	NetworkSecurityGroup NetworkSecurityGroupTypePtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
}

func (NetworkInterfaceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*networkInterfaceArgs)(nil)).Elem()
}

type NetworkInterfaceInput interface {
	pulumi.Input

	ToNetworkInterfaceOutput() NetworkInterfaceOutput
	ToNetworkInterfaceOutputWithContext(ctx context.Context) NetworkInterfaceOutput
}

func (NetworkInterface) ElementType() reflect.Type {
	return reflect.TypeOf((*NetworkInterface)(nil)).Elem()
}

func (i NetworkInterface) ToNetworkInterfaceOutput() NetworkInterfaceOutput {
	return i.ToNetworkInterfaceOutputWithContext(context.Background())
}

func (i NetworkInterface) ToNetworkInterfaceOutputWithContext(ctx context.Context) NetworkInterfaceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NetworkInterfaceOutput)
}

type NetworkInterfaceOutput struct {
	*pulumi.OutputState
}

func (NetworkInterfaceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*NetworkInterfaceOutput)(nil)).Elem()
}

func (o NetworkInterfaceOutput) ToNetworkInterfaceOutput() NetworkInterfaceOutput {
	return o
}

func (o NetworkInterfaceOutput) ToNetworkInterfaceOutputWithContext(ctx context.Context) NetworkInterfaceOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(NetworkInterfaceOutput{})
}
