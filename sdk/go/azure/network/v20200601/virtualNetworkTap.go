// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200601

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Virtual Network Tap resource.
type VirtualNetworkTap struct {
	pulumi.CustomResourceState

	// The reference to the private IP address on the internal Load Balancer that will receive the tap.
	DestinationLoadBalancerFrontEndIPConfiguration FrontendIPConfigurationResponsePtrOutput `pulumi:"destinationLoadBalancerFrontEndIPConfiguration"`
	// The reference to the private IP Address of the collector nic that will receive the tap.
	DestinationNetworkInterfaceIPConfiguration NetworkInterfaceIPConfigurationResponsePtrOutput `pulumi:"destinationNetworkInterfaceIPConfiguration"`
	// The VXLAN destination port that will receive the tapped traffic.
	DestinationPort pulumi.IntPtrOutput `pulumi:"destinationPort"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// Resource location.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Specifies the list of resource IDs for the network interface IP configuration that needs to be tapped.
	NetworkInterfaceTapConfigurations NetworkInterfaceTapConfigurationResponseArrayOutput `pulumi:"networkInterfaceTapConfigurations"`
	// The provisioning state of the virtual network tap resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The resource GUID property of the virtual network tap resource.
	ResourceGuid pulumi.StringOutput `pulumi:"resourceGuid"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewVirtualNetworkTap registers a new resource with the given unique name, arguments, and options.
func NewVirtualNetworkTap(ctx *pulumi.Context,
	name string, args *VirtualNetworkTapArgs, opts ...pulumi.ResourceOption) (*VirtualNetworkTap, error) {
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.TapName == nil {
		return nil, errors.New("missing required argument 'TapName'")
	}
	if args == nil {
		args = &VirtualNetworkTapArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:VirtualNetworkTap"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180801:VirtualNetworkTap"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181001:VirtualNetworkTap"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181101:VirtualNetworkTap"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181201:VirtualNetworkTap"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190201:VirtualNetworkTap"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190401:VirtualNetworkTap"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190601:VirtualNetworkTap"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190701:VirtualNetworkTap"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190801:VirtualNetworkTap"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190901:VirtualNetworkTap"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191101:VirtualNetworkTap"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191201:VirtualNetworkTap"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200301:VirtualNetworkTap"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:VirtualNetworkTap"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:VirtualNetworkTap"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:VirtualNetworkTap"),
		},
	})
	opts = append(opts, aliases)
	var resource VirtualNetworkTap
	err := ctx.RegisterResource("azure-nextgen:network/v20200601:VirtualNetworkTap", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVirtualNetworkTap gets an existing VirtualNetworkTap resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVirtualNetworkTap(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VirtualNetworkTapState, opts ...pulumi.ResourceOption) (*VirtualNetworkTap, error) {
	var resource VirtualNetworkTap
	err := ctx.ReadResource("azure-nextgen:network/v20200601:VirtualNetworkTap", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VirtualNetworkTap resources.
type virtualNetworkTapState struct {
	// The reference to the private IP address on the internal Load Balancer that will receive the tap.
	DestinationLoadBalancerFrontEndIPConfiguration *FrontendIPConfigurationResponse `pulumi:"destinationLoadBalancerFrontEndIPConfiguration"`
	// The reference to the private IP Address of the collector nic that will receive the tap.
	DestinationNetworkInterfaceIPConfiguration *NetworkInterfaceIPConfigurationResponse `pulumi:"destinationNetworkInterfaceIPConfiguration"`
	// The VXLAN destination port that will receive the tapped traffic.
	DestinationPort *int `pulumi:"destinationPort"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// Resource location.
	Location *string `pulumi:"location"`
	// Resource name.
	Name *string `pulumi:"name"`
	// Specifies the list of resource IDs for the network interface IP configuration that needs to be tapped.
	NetworkInterfaceTapConfigurations []NetworkInterfaceTapConfigurationResponse `pulumi:"networkInterfaceTapConfigurations"`
	// The provisioning state of the virtual network tap resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The resource GUID property of the virtual network tap resource.
	ResourceGuid *string `pulumi:"resourceGuid"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type VirtualNetworkTapState struct {
	// The reference to the private IP address on the internal Load Balancer that will receive the tap.
	DestinationLoadBalancerFrontEndIPConfiguration FrontendIPConfigurationResponsePtrInput
	// The reference to the private IP Address of the collector nic that will receive the tap.
	DestinationNetworkInterfaceIPConfiguration NetworkInterfaceIPConfigurationResponsePtrInput
	// The VXLAN destination port that will receive the tapped traffic.
	DestinationPort pulumi.IntPtrInput
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// Specifies the list of resource IDs for the network interface IP configuration that needs to be tapped.
	NetworkInterfaceTapConfigurations NetworkInterfaceTapConfigurationResponseArrayInput
	// The provisioning state of the virtual network tap resource.
	ProvisioningState pulumi.StringPtrInput
	// The resource GUID property of the virtual network tap resource.
	ResourceGuid pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (VirtualNetworkTapState) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualNetworkTapState)(nil)).Elem()
}

type virtualNetworkTapArgs struct {
	// The reference to the private IP address on the internal Load Balancer that will receive the tap.
	DestinationLoadBalancerFrontEndIPConfiguration *FrontendIPConfiguration `pulumi:"destinationLoadBalancerFrontEndIPConfiguration"`
	// The reference to the private IP Address of the collector nic that will receive the tap.
	DestinationNetworkInterfaceIPConfiguration *NetworkInterfaceIPConfiguration `pulumi:"destinationNetworkInterfaceIPConfiguration"`
	// The VXLAN destination port that will receive the tapped traffic.
	DestinationPort *int `pulumi:"destinationPort"`
	// Resource ID.
	Id *string `pulumi:"id"`
	// Resource location.
	Location *string `pulumi:"location"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The name of the virtual network tap.
	TapName string `pulumi:"tapName"`
}

// The set of arguments for constructing a VirtualNetworkTap resource.
type VirtualNetworkTapArgs struct {
	// The reference to the private IP address on the internal Load Balancer that will receive the tap.
	DestinationLoadBalancerFrontEndIPConfiguration FrontendIPConfigurationPtrInput
	// The reference to the private IP Address of the collector nic that will receive the tap.
	DestinationNetworkInterfaceIPConfiguration NetworkInterfaceIPConfigurationPtrInput
	// The VXLAN destination port that will receive the tapped traffic.
	DestinationPort pulumi.IntPtrInput
	// Resource ID.
	Id pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The name of the virtual network tap.
	TapName pulumi.StringInput
}

func (VirtualNetworkTapArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualNetworkTapArgs)(nil)).Elem()
}

type VirtualNetworkTapInput interface {
	pulumi.Input

	ToVirtualNetworkTapOutput() VirtualNetworkTapOutput
	ToVirtualNetworkTapOutputWithContext(ctx context.Context) VirtualNetworkTapOutput
}

func (VirtualNetworkTap) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualNetworkTap)(nil)).Elem()
}

func (i VirtualNetworkTap) ToVirtualNetworkTapOutput() VirtualNetworkTapOutput {
	return i.ToVirtualNetworkTapOutputWithContext(context.Background())
}

func (i VirtualNetworkTap) ToVirtualNetworkTapOutputWithContext(ctx context.Context) VirtualNetworkTapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VirtualNetworkTapOutput)
}

type VirtualNetworkTapOutput struct {
	*pulumi.OutputState
}

func (VirtualNetworkTapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualNetworkTapOutput)(nil)).Elem()
}

func (o VirtualNetworkTapOutput) ToVirtualNetworkTapOutput() VirtualNetworkTapOutput {
	return o
}

func (o VirtualNetworkTapOutput) ToVirtualNetworkTapOutputWithContext(ctx context.Context) VirtualNetworkTapOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(VirtualNetworkTapOutput{})
}
