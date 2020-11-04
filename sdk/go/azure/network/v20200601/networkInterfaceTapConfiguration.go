// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200601

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Tap configuration in a Network Interface.
type NetworkInterfaceTapConfiguration struct {
	pulumi.CustomResourceState

	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// The provisioning state of the network interface tap configuration resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Sub Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
	// The reference to the Virtual Network Tap resource.
	VirtualNetworkTap VirtualNetworkTapResponsePtrOutput `pulumi:"virtualNetworkTap"`
}

// NewNetworkInterfaceTapConfiguration registers a new resource with the given unique name, arguments, and options.
func NewNetworkInterfaceTapConfiguration(ctx *pulumi.Context,
	name string, args *NetworkInterfaceTapConfigurationArgs, opts ...pulumi.ResourceOption) (*NetworkInterfaceTapConfiguration, error) {
	if args == nil || args.NetworkInterfaceName == nil {
		return nil, errors.New("missing required argument 'NetworkInterfaceName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.TapConfigurationName == nil {
		return nil, errors.New("missing required argument 'TapConfigurationName'")
	}
	if args == nil {
		args = &NetworkInterfaceTapConfigurationArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:NetworkInterfaceTapConfiguration"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180801:NetworkInterfaceTapConfiguration"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181001:NetworkInterfaceTapConfiguration"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181101:NetworkInterfaceTapConfiguration"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181201:NetworkInterfaceTapConfiguration"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190201:NetworkInterfaceTapConfiguration"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190401:NetworkInterfaceTapConfiguration"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190601:NetworkInterfaceTapConfiguration"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190701:NetworkInterfaceTapConfiguration"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190801:NetworkInterfaceTapConfiguration"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190901:NetworkInterfaceTapConfiguration"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191101:NetworkInterfaceTapConfiguration"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191201:NetworkInterfaceTapConfiguration"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200301:NetworkInterfaceTapConfiguration"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:NetworkInterfaceTapConfiguration"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:NetworkInterfaceTapConfiguration"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:NetworkInterfaceTapConfiguration"),
		},
	})
	opts = append(opts, aliases)
	var resource NetworkInterfaceTapConfiguration
	err := ctx.RegisterResource("azure-nextgen:network/v20200601:NetworkInterfaceTapConfiguration", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNetworkInterfaceTapConfiguration gets an existing NetworkInterfaceTapConfiguration resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNetworkInterfaceTapConfiguration(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NetworkInterfaceTapConfigurationState, opts ...pulumi.ResourceOption) (*NetworkInterfaceTapConfiguration, error) {
	var resource NetworkInterfaceTapConfiguration
	err := ctx.ReadResource("azure-nextgen:network/v20200601:NetworkInterfaceTapConfiguration", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering NetworkInterfaceTapConfiguration resources.
type networkInterfaceTapConfigurationState struct {
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name *string `pulumi:"name"`
	// The provisioning state of the network interface tap configuration resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Sub Resource type.
	Type *string `pulumi:"type"`
	// The reference to the Virtual Network Tap resource.
	VirtualNetworkTap *VirtualNetworkTapResponse `pulumi:"virtualNetworkTap"`
}

type NetworkInterfaceTapConfigurationState struct {
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrInput
	// The provisioning state of the network interface tap configuration resource.
	ProvisioningState pulumi.StringPtrInput
	// Sub Resource type.
	Type pulumi.StringPtrInput
	// The reference to the Virtual Network Tap resource.
	VirtualNetworkTap VirtualNetworkTapResponsePtrInput
}

func (NetworkInterfaceTapConfigurationState) ElementType() reflect.Type {
	return reflect.TypeOf((*networkInterfaceTapConfigurationState)(nil)).Elem()
}

type networkInterfaceTapConfigurationArgs struct {
	// Resource ID.
	Id *string `pulumi:"id"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name *string `pulumi:"name"`
	// The name of the network interface.
	NetworkInterfaceName string `pulumi:"networkInterfaceName"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the tap configuration.
	TapConfigurationName string `pulumi:"tapConfigurationName"`
	// The reference to the Virtual Network Tap resource.
	VirtualNetworkTap *VirtualNetworkTapType `pulumi:"virtualNetworkTap"`
}

// The set of arguments for constructing a NetworkInterfaceTapConfiguration resource.
type NetworkInterfaceTapConfigurationArgs struct {
	// Resource ID.
	Id pulumi.StringPtrInput
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrInput
	// The name of the network interface.
	NetworkInterfaceName pulumi.StringInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// The name of the tap configuration.
	TapConfigurationName pulumi.StringInput
	// The reference to the Virtual Network Tap resource.
	VirtualNetworkTap VirtualNetworkTapTypePtrInput
}

func (NetworkInterfaceTapConfigurationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*networkInterfaceTapConfigurationArgs)(nil)).Elem()
}
