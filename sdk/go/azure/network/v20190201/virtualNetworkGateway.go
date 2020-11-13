// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190201

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A common class for general resource information
type VirtualNetworkGateway struct {
	pulumi.CustomResourceState

	// ActiveActive flag
	ActiveActive pulumi.BoolPtrOutput `pulumi:"activeActive"`
	// Virtual network gateway's BGP speaker settings.
	BgpSettings BgpSettingsResponsePtrOutput `pulumi:"bgpSettings"`
	// The reference of the address space resource which represents the custom routes address space specified by the customer for virtual network gateway and VpnClient.
	CustomRoutes AddressSpaceResponsePtrOutput `pulumi:"customRoutes"`
	// Whether BGP is enabled for this virtual network gateway or not.
	EnableBgp pulumi.BoolPtrOutput `pulumi:"enableBgp"`
	// Gets a unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// The reference of the LocalNetworkGateway resource which represents local network site having default routes. Assign Null value in case of removing existing default site setting.
	GatewayDefaultSite SubResourceResponsePtrOutput `pulumi:"gatewayDefaultSite"`
	// The type of this virtual network gateway. Possible values are: 'Vpn' and 'ExpressRoute'.
	GatewayType pulumi.StringPtrOutput `pulumi:"gatewayType"`
	// IP configurations for virtual network gateway.
	IpConfigurations VirtualNetworkGatewayIPConfigurationResponseArrayOutput `pulumi:"ipConfigurations"`
	// Resource location.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The provisioning state of the VirtualNetworkGateway resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The resource GUID property of the VirtualNetworkGateway resource.
	ResourceGuid pulumi.StringPtrOutput `pulumi:"resourceGuid"`
	// The reference of the VirtualNetworkGatewaySku resource which represents the SKU selected for Virtual network gateway.
	Sku VirtualNetworkGatewaySkuResponsePtrOutput `pulumi:"sku"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
	// The reference of the VpnClientConfiguration resource which represents the P2S VpnClient configurations.
	VpnClientConfiguration VpnClientConfigurationResponsePtrOutput `pulumi:"vpnClientConfiguration"`
	// The type of this virtual network gateway. Possible values are: 'PolicyBased' and 'RouteBased'.
	VpnType pulumi.StringPtrOutput `pulumi:"vpnType"`
}

// NewVirtualNetworkGateway registers a new resource with the given unique name, arguments, and options.
func NewVirtualNetworkGateway(ctx *pulumi.Context,
	name string, args *VirtualNetworkGatewayArgs, opts ...pulumi.ResourceOption) (*VirtualNetworkGateway, error) {
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.VirtualNetworkGatewayName == nil {
		return nil, errors.New("missing required argument 'VirtualNetworkGatewayName'")
	}
	if args == nil {
		args = &VirtualNetworkGatewayArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20150615:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20160330:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20160601:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20160901:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20161201:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170301:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170601:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170801:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170901:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20171001:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20171101:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180101:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180201:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180401:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180601:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180701:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180801:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181001:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181101:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181201:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190401:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190601:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190701:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190801:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190901:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191101:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191201:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200301:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200601:VirtualNetworkGateway"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:VirtualNetworkGateway"),
		},
	})
	opts = append(opts, aliases)
	var resource VirtualNetworkGateway
	err := ctx.RegisterResource("azure-nextgen:network/v20190201:VirtualNetworkGateway", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVirtualNetworkGateway gets an existing VirtualNetworkGateway resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVirtualNetworkGateway(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VirtualNetworkGatewayState, opts ...pulumi.ResourceOption) (*VirtualNetworkGateway, error) {
	var resource VirtualNetworkGateway
	err := ctx.ReadResource("azure-nextgen:network/v20190201:VirtualNetworkGateway", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VirtualNetworkGateway resources.
type virtualNetworkGatewayState struct {
	// ActiveActive flag
	ActiveActive *bool `pulumi:"activeActive"`
	// Virtual network gateway's BGP speaker settings.
	BgpSettings *BgpSettingsResponse `pulumi:"bgpSettings"`
	// The reference of the address space resource which represents the custom routes address space specified by the customer for virtual network gateway and VpnClient.
	CustomRoutes *AddressSpaceResponse `pulumi:"customRoutes"`
	// Whether BGP is enabled for this virtual network gateway or not.
	EnableBgp *bool `pulumi:"enableBgp"`
	// Gets a unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// The reference of the LocalNetworkGateway resource which represents local network site having default routes. Assign Null value in case of removing existing default site setting.
	GatewayDefaultSite *SubResourceResponse `pulumi:"gatewayDefaultSite"`
	// The type of this virtual network gateway. Possible values are: 'Vpn' and 'ExpressRoute'.
	GatewayType *string `pulumi:"gatewayType"`
	// IP configurations for virtual network gateway.
	IpConfigurations []VirtualNetworkGatewayIPConfigurationResponse `pulumi:"ipConfigurations"`
	// Resource location.
	Location *string `pulumi:"location"`
	// Resource name.
	Name *string `pulumi:"name"`
	// The provisioning state of the VirtualNetworkGateway resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The resource GUID property of the VirtualNetworkGateway resource.
	ResourceGuid *string `pulumi:"resourceGuid"`
	// The reference of the VirtualNetworkGatewaySku resource which represents the SKU selected for Virtual network gateway.
	Sku *VirtualNetworkGatewaySkuResponse `pulumi:"sku"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type *string `pulumi:"type"`
	// The reference of the VpnClientConfiguration resource which represents the P2S VpnClient configurations.
	VpnClientConfiguration *VpnClientConfigurationResponse `pulumi:"vpnClientConfiguration"`
	// The type of this virtual network gateway. Possible values are: 'PolicyBased' and 'RouteBased'.
	VpnType *string `pulumi:"vpnType"`
}

type VirtualNetworkGatewayState struct {
	// ActiveActive flag
	ActiveActive pulumi.BoolPtrInput
	// Virtual network gateway's BGP speaker settings.
	BgpSettings BgpSettingsResponsePtrInput
	// The reference of the address space resource which represents the custom routes address space specified by the customer for virtual network gateway and VpnClient.
	CustomRoutes AddressSpaceResponsePtrInput
	// Whether BGP is enabled for this virtual network gateway or not.
	EnableBgp pulumi.BoolPtrInput
	// Gets a unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// The reference of the LocalNetworkGateway resource which represents local network site having default routes. Assign Null value in case of removing existing default site setting.
	GatewayDefaultSite SubResourceResponsePtrInput
	// The type of this virtual network gateway. Possible values are: 'Vpn' and 'ExpressRoute'.
	GatewayType pulumi.StringPtrInput
	// IP configurations for virtual network gateway.
	IpConfigurations VirtualNetworkGatewayIPConfigurationResponseArrayInput
	// Resource location.
	Location pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// The provisioning state of the VirtualNetworkGateway resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
	ProvisioningState pulumi.StringPtrInput
	// The resource GUID property of the VirtualNetworkGateway resource.
	ResourceGuid pulumi.StringPtrInput
	// The reference of the VirtualNetworkGatewaySku resource which represents the SKU selected for Virtual network gateway.
	Sku VirtualNetworkGatewaySkuResponsePtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Resource type.
	Type pulumi.StringPtrInput
	// The reference of the VpnClientConfiguration resource which represents the P2S VpnClient configurations.
	VpnClientConfiguration VpnClientConfigurationResponsePtrInput
	// The type of this virtual network gateway. Possible values are: 'PolicyBased' and 'RouteBased'.
	VpnType pulumi.StringPtrInput
}

func (VirtualNetworkGatewayState) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualNetworkGatewayState)(nil)).Elem()
}

type virtualNetworkGatewayArgs struct {
	// ActiveActive flag
	ActiveActive *bool `pulumi:"activeActive"`
	// Virtual network gateway's BGP speaker settings.
	BgpSettings *BgpSettings `pulumi:"bgpSettings"`
	// The reference of the address space resource which represents the custom routes address space specified by the customer for virtual network gateway and VpnClient.
	CustomRoutes *AddressSpace `pulumi:"customRoutes"`
	// Whether BGP is enabled for this virtual network gateway or not.
	EnableBgp *bool `pulumi:"enableBgp"`
	// Gets a unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// The reference of the LocalNetworkGateway resource which represents local network site having default routes. Assign Null value in case of removing existing default site setting.
	GatewayDefaultSite *SubResource `pulumi:"gatewayDefaultSite"`
	// The type of this virtual network gateway. Possible values are: 'Vpn' and 'ExpressRoute'.
	GatewayType *string `pulumi:"gatewayType"`
	// Resource ID.
	Id *string `pulumi:"id"`
	// IP configurations for virtual network gateway.
	IpConfigurations []VirtualNetworkGatewayIPConfiguration `pulumi:"ipConfigurations"`
	// Resource location.
	Location *string `pulumi:"location"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The resource GUID property of the VirtualNetworkGateway resource.
	ResourceGuid *string `pulumi:"resourceGuid"`
	// The reference of the VirtualNetworkGatewaySku resource which represents the SKU selected for Virtual network gateway.
	Sku *VirtualNetworkGatewaySku `pulumi:"sku"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The name of the virtual network gateway.
	VirtualNetworkGatewayName string `pulumi:"virtualNetworkGatewayName"`
	// The reference of the VpnClientConfiguration resource which represents the P2S VpnClient configurations.
	VpnClientConfiguration *VpnClientConfiguration `pulumi:"vpnClientConfiguration"`
	// The type of this virtual network gateway. Possible values are: 'PolicyBased' and 'RouteBased'.
	VpnType *string `pulumi:"vpnType"`
}

// The set of arguments for constructing a VirtualNetworkGateway resource.
type VirtualNetworkGatewayArgs struct {
	// ActiveActive flag
	ActiveActive pulumi.BoolPtrInput
	// Virtual network gateway's BGP speaker settings.
	BgpSettings BgpSettingsPtrInput
	// The reference of the address space resource which represents the custom routes address space specified by the customer for virtual network gateway and VpnClient.
	CustomRoutes AddressSpacePtrInput
	// Whether BGP is enabled for this virtual network gateway or not.
	EnableBgp pulumi.BoolPtrInput
	// Gets a unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// The reference of the LocalNetworkGateway resource which represents local network site having default routes. Assign Null value in case of removing existing default site setting.
	GatewayDefaultSite SubResourcePtrInput
	// The type of this virtual network gateway. Possible values are: 'Vpn' and 'ExpressRoute'.
	GatewayType pulumi.StringPtrInput
	// Resource ID.
	Id pulumi.StringPtrInput
	// IP configurations for virtual network gateway.
	IpConfigurations VirtualNetworkGatewayIPConfigurationArrayInput
	// Resource location.
	Location pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// The resource GUID property of the VirtualNetworkGateway resource.
	ResourceGuid pulumi.StringPtrInput
	// The reference of the VirtualNetworkGatewaySku resource which represents the SKU selected for Virtual network gateway.
	Sku VirtualNetworkGatewaySkuPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The name of the virtual network gateway.
	VirtualNetworkGatewayName pulumi.StringInput
	// The reference of the VpnClientConfiguration resource which represents the P2S VpnClient configurations.
	VpnClientConfiguration VpnClientConfigurationPtrInput
	// The type of this virtual network gateway. Possible values are: 'PolicyBased' and 'RouteBased'.
	VpnType pulumi.StringPtrInput
}

func (VirtualNetworkGatewayArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualNetworkGatewayArgs)(nil)).Elem()
}

type VirtualNetworkGatewayInput interface {
	pulumi.Input

	ToVirtualNetworkGatewayOutput() VirtualNetworkGatewayOutput
	ToVirtualNetworkGatewayOutputWithContext(ctx context.Context) VirtualNetworkGatewayOutput
}

func (VirtualNetworkGateway) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualNetworkGateway)(nil)).Elem()
}

func (i VirtualNetworkGateway) ToVirtualNetworkGatewayOutput() VirtualNetworkGatewayOutput {
	return i.ToVirtualNetworkGatewayOutputWithContext(context.Background())
}

func (i VirtualNetworkGateway) ToVirtualNetworkGatewayOutputWithContext(ctx context.Context) VirtualNetworkGatewayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VirtualNetworkGatewayOutput)
}

type VirtualNetworkGatewayOutput struct {
	*pulumi.OutputState
}

func (VirtualNetworkGatewayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualNetworkGatewayOutput)(nil)).Elem()
}

func (o VirtualNetworkGatewayOutput) ToVirtualNetworkGatewayOutput() VirtualNetworkGatewayOutput {
	return o
}

func (o VirtualNetworkGatewayOutput) ToVirtualNetworkGatewayOutputWithContext(ctx context.Context) VirtualNetworkGatewayOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(VirtualNetworkGatewayOutput{})
}
