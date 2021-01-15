// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190701

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// ExpressRoutePort resource definition.
type ExpressRoutePort struct {
	pulumi.CustomResourceState

	// Date of the physical port allocation to be used in Letter of Authorization.
	AllocationDate pulumi.StringOutput `pulumi:"allocationDate"`
	// Bandwidth of procured ports in Gbps.
	BandwidthInGbps pulumi.IntPtrOutput `pulumi:"bandwidthInGbps"`
	// Reference the ExpressRoute circuit(s) that are provisioned on this ExpressRoutePort resource.
	Circuits SubResourceResponseArrayOutput `pulumi:"circuits"`
	// Encapsulation method on physical ports.
	Encapsulation pulumi.StringPtrOutput `pulumi:"encapsulation"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// Ether type of the physical port.
	EtherType pulumi.StringOutput `pulumi:"etherType"`
	// The identity of ExpressRoutePort, if configured.
	Identity ManagedServiceIdentityResponsePtrOutput `pulumi:"identity"`
	// The set of physical links of the ExpressRoutePort resource.
	Links ExpressRouteLinkResponseArrayOutput `pulumi:"links"`
	// Resource location.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Maximum transmission unit of the physical port pair(s).
	Mtu pulumi.StringOutput `pulumi:"mtu"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The name of the peering location that the ExpressRoutePort is mapped to physically.
	PeeringLocation pulumi.StringPtrOutput `pulumi:"peeringLocation"`
	// Aggregate Gbps of associated circuit bandwidths.
	ProvisionedBandwidthInGbps pulumi.Float64Output `pulumi:"provisionedBandwidthInGbps"`
	// The provisioning state of the express route port resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The resource GUID property of the express route port resource.
	ResourceGuid pulumi.StringPtrOutput `pulumi:"resourceGuid"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewExpressRoutePort registers a new resource with the given unique name, arguments, and options.
func NewExpressRoutePort(ctx *pulumi.Context,
	name string, args *ExpressRoutePortArgs, opts ...pulumi.ResourceOption) (*ExpressRoutePort, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ExpressRoutePortName == nil {
		return nil, errors.New("invalid value for required argument 'ExpressRoutePortName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:ExpressRoutePort"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180801:ExpressRoutePort"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181001:ExpressRoutePort"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181101:ExpressRoutePort"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181201:ExpressRoutePort"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190201:ExpressRoutePort"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190401:ExpressRoutePort"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190601:ExpressRoutePort"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190801:ExpressRoutePort"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190901:ExpressRoutePort"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191101:ExpressRoutePort"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191201:ExpressRoutePort"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200301:ExpressRoutePort"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:ExpressRoutePort"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:ExpressRoutePort"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200601:ExpressRoutePort"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:ExpressRoutePort"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200801:ExpressRoutePort"),
		},
	})
	opts = append(opts, aliases)
	var resource ExpressRoutePort
	err := ctx.RegisterResource("azure-nextgen:network/v20190701:ExpressRoutePort", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetExpressRoutePort gets an existing ExpressRoutePort resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetExpressRoutePort(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ExpressRoutePortState, opts ...pulumi.ResourceOption) (*ExpressRoutePort, error) {
	var resource ExpressRoutePort
	err := ctx.ReadResource("azure-nextgen:network/v20190701:ExpressRoutePort", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ExpressRoutePort resources.
type expressRoutePortState struct {
	// Date of the physical port allocation to be used in Letter of Authorization.
	AllocationDate *string `pulumi:"allocationDate"`
	// Bandwidth of procured ports in Gbps.
	BandwidthInGbps *int `pulumi:"bandwidthInGbps"`
	// Reference the ExpressRoute circuit(s) that are provisioned on this ExpressRoutePort resource.
	Circuits []SubResourceResponse `pulumi:"circuits"`
	// Encapsulation method on physical ports.
	Encapsulation *string `pulumi:"encapsulation"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// Ether type of the physical port.
	EtherType *string `pulumi:"etherType"`
	// The identity of ExpressRoutePort, if configured.
	Identity *ManagedServiceIdentityResponse `pulumi:"identity"`
	// The set of physical links of the ExpressRoutePort resource.
	Links []ExpressRouteLinkResponse `pulumi:"links"`
	// Resource location.
	Location *string `pulumi:"location"`
	// Maximum transmission unit of the physical port pair(s).
	Mtu *string `pulumi:"mtu"`
	// Resource name.
	Name *string `pulumi:"name"`
	// The name of the peering location that the ExpressRoutePort is mapped to physically.
	PeeringLocation *string `pulumi:"peeringLocation"`
	// Aggregate Gbps of associated circuit bandwidths.
	ProvisionedBandwidthInGbps *float64 `pulumi:"provisionedBandwidthInGbps"`
	// The provisioning state of the express route port resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The resource GUID property of the express route port resource.
	ResourceGuid *string `pulumi:"resourceGuid"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type ExpressRoutePortState struct {
	// Date of the physical port allocation to be used in Letter of Authorization.
	AllocationDate pulumi.StringPtrInput
	// Bandwidth of procured ports in Gbps.
	BandwidthInGbps pulumi.IntPtrInput
	// Reference the ExpressRoute circuit(s) that are provisioned on this ExpressRoutePort resource.
	Circuits SubResourceResponseArrayInput
	// Encapsulation method on physical ports.
	Encapsulation pulumi.StringPtrInput
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// Ether type of the physical port.
	EtherType pulumi.StringPtrInput
	// The identity of ExpressRoutePort, if configured.
	Identity ManagedServiceIdentityResponsePtrInput
	// The set of physical links of the ExpressRoutePort resource.
	Links ExpressRouteLinkResponseArrayInput
	// Resource location.
	Location pulumi.StringPtrInput
	// Maximum transmission unit of the physical port pair(s).
	Mtu pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// The name of the peering location that the ExpressRoutePort is mapped to physically.
	PeeringLocation pulumi.StringPtrInput
	// Aggregate Gbps of associated circuit bandwidths.
	ProvisionedBandwidthInGbps pulumi.Float64PtrInput
	// The provisioning state of the express route port resource.
	ProvisioningState pulumi.StringPtrInput
	// The resource GUID property of the express route port resource.
	ResourceGuid pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (ExpressRoutePortState) ElementType() reflect.Type {
	return reflect.TypeOf((*expressRoutePortState)(nil)).Elem()
}

type expressRoutePortArgs struct {
	// Bandwidth of procured ports in Gbps.
	BandwidthInGbps *int `pulumi:"bandwidthInGbps"`
	// Encapsulation method on physical ports.
	Encapsulation *string `pulumi:"encapsulation"`
	// The name of the ExpressRoutePort resource.
	ExpressRoutePortName string `pulumi:"expressRoutePortName"`
	// Resource ID.
	Id *string `pulumi:"id"`
	// The identity of ExpressRoutePort, if configured.
	Identity *ManagedServiceIdentity `pulumi:"identity"`
	// The set of physical links of the ExpressRoutePort resource.
	Links []ExpressRouteLink `pulumi:"links"`
	// Resource location.
	Location *string `pulumi:"location"`
	// The name of the peering location that the ExpressRoutePort is mapped to physically.
	PeeringLocation *string `pulumi:"peeringLocation"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The resource GUID property of the express route port resource.
	ResourceGuid *string `pulumi:"resourceGuid"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a ExpressRoutePort resource.
type ExpressRoutePortArgs struct {
	// Bandwidth of procured ports in Gbps.
	BandwidthInGbps pulumi.IntPtrInput
	// Encapsulation method on physical ports.
	Encapsulation pulumi.StringPtrInput
	// The name of the ExpressRoutePort resource.
	ExpressRoutePortName pulumi.StringInput
	// Resource ID.
	Id pulumi.StringPtrInput
	// The identity of ExpressRoutePort, if configured.
	Identity ManagedServiceIdentityPtrInput
	// The set of physical links of the ExpressRoutePort resource.
	Links ExpressRouteLinkArrayInput
	// Resource location.
	Location pulumi.StringPtrInput
	// The name of the peering location that the ExpressRoutePort is mapped to physically.
	PeeringLocation pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// The resource GUID property of the express route port resource.
	ResourceGuid pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
}

func (ExpressRoutePortArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*expressRoutePortArgs)(nil)).Elem()
}

type ExpressRoutePortInput interface {
	pulumi.Input

	ToExpressRoutePortOutput() ExpressRoutePortOutput
	ToExpressRoutePortOutputWithContext(ctx context.Context) ExpressRoutePortOutput
}

func (*ExpressRoutePort) ElementType() reflect.Type {
	return reflect.TypeOf((*ExpressRoutePort)(nil))
}

func (i *ExpressRoutePort) ToExpressRoutePortOutput() ExpressRoutePortOutput {
	return i.ToExpressRoutePortOutputWithContext(context.Background())
}

func (i *ExpressRoutePort) ToExpressRoutePortOutputWithContext(ctx context.Context) ExpressRoutePortOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ExpressRoutePortOutput)
}

type ExpressRoutePortOutput struct {
	*pulumi.OutputState
}

func (ExpressRoutePortOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ExpressRoutePort)(nil))
}

func (o ExpressRoutePortOutput) ToExpressRoutePortOutput() ExpressRoutePortOutput {
	return o
}

func (o ExpressRoutePortOutput) ToExpressRoutePortOutputWithContext(ctx context.Context) ExpressRoutePortOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ExpressRoutePortOutput{})
}
