// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// VirtualHubRouteTableV2 Resource.
type VirtualHubRouteTableV2 struct {
	pulumi.CustomResourceState

	// List of all connections attached to this route table v2.
	AttachedConnections pulumi.StringArrayOutput `pulumi:"attachedConnections"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// The provisioning state of the virtual hub route table v2 resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// List of all routes.
	Routes VirtualHubRouteV2ResponseArrayOutput `pulumi:"routes"`
}

// NewVirtualHubRouteTableV2 registers a new resource with the given unique name, arguments, and options.
func NewVirtualHubRouteTableV2(ctx *pulumi.Context,
	name string, args *VirtualHubRouteTableV2Args, opts ...pulumi.ResourceOption) (*VirtualHubRouteTableV2, error) {
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.RouteTableName == nil {
		return nil, errors.New("missing required argument 'RouteTableName'")
	}
	if args == nil || args.VirtualHubName == nil {
		return nil, errors.New("missing required argument 'VirtualHubName'")
	}
	if args == nil {
		args = &VirtualHubRouteTableV2Args{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/v20190901:VirtualHubRouteTableV2"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191101:VirtualHubRouteTableV2"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191201:VirtualHubRouteTableV2"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200301:VirtualHubRouteTableV2"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:VirtualHubRouteTableV2"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:VirtualHubRouteTableV2"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200601:VirtualHubRouteTableV2"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:VirtualHubRouteTableV2"),
		},
	})
	opts = append(opts, aliases)
	var resource VirtualHubRouteTableV2
	err := ctx.RegisterResource("azure-nextgen:network/latest:VirtualHubRouteTableV2", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVirtualHubRouteTableV2 gets an existing VirtualHubRouteTableV2 resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVirtualHubRouteTableV2(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VirtualHubRouteTableV2State, opts ...pulumi.ResourceOption) (*VirtualHubRouteTableV2, error) {
	var resource VirtualHubRouteTableV2
	err := ctx.ReadResource("azure-nextgen:network/latest:VirtualHubRouteTableV2", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VirtualHubRouteTableV2 resources.
type virtualHubRouteTableV2State struct {
	// List of all connections attached to this route table v2.
	AttachedConnections []string `pulumi:"attachedConnections"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name *string `pulumi:"name"`
	// The provisioning state of the virtual hub route table v2 resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// List of all routes.
	Routes []VirtualHubRouteV2Response `pulumi:"routes"`
}

type VirtualHubRouteTableV2State struct {
	// List of all connections attached to this route table v2.
	AttachedConnections pulumi.StringArrayInput
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrInput
	// The provisioning state of the virtual hub route table v2 resource.
	ProvisioningState pulumi.StringPtrInput
	// List of all routes.
	Routes VirtualHubRouteV2ResponseArrayInput
}

func (VirtualHubRouteTableV2State) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualHubRouteTableV2State)(nil)).Elem()
}

type virtualHubRouteTableV2Args struct {
	// List of all connections attached to this route table v2.
	AttachedConnections []string `pulumi:"attachedConnections"`
	// Resource ID.
	Id *string `pulumi:"id"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name *string `pulumi:"name"`
	// The resource group name of the VirtualHub.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the VirtualHubRouteTableV2.
	RouteTableName string `pulumi:"routeTableName"`
	// List of all routes.
	Routes []VirtualHubRouteV2 `pulumi:"routes"`
	// The name of the VirtualHub.
	VirtualHubName string `pulumi:"virtualHubName"`
}

// The set of arguments for constructing a VirtualHubRouteTableV2 resource.
type VirtualHubRouteTableV2Args struct {
	// List of all connections attached to this route table v2.
	AttachedConnections pulumi.StringArrayInput
	// Resource ID.
	Id pulumi.StringPtrInput
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrInput
	// The resource group name of the VirtualHub.
	ResourceGroupName pulumi.StringInput
	// The name of the VirtualHubRouteTableV2.
	RouteTableName pulumi.StringInput
	// List of all routes.
	Routes VirtualHubRouteV2ArrayInput
	// The name of the VirtualHub.
	VirtualHubName pulumi.StringInput
}

func (VirtualHubRouteTableV2Args) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualHubRouteTableV2Args)(nil)).Elem()
}

type VirtualHubRouteTableV2Input interface {
	pulumi.Input

	ToVirtualHubRouteTableV2Output() VirtualHubRouteTableV2Output
	ToVirtualHubRouteTableV2OutputWithContext(ctx context.Context) VirtualHubRouteTableV2Output
}

func (VirtualHubRouteTableV2) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualHubRouteTableV2)(nil)).Elem()
}

func (i VirtualHubRouteTableV2) ToVirtualHubRouteTableV2Output() VirtualHubRouteTableV2Output {
	return i.ToVirtualHubRouteTableV2OutputWithContext(context.Background())
}

func (i VirtualHubRouteTableV2) ToVirtualHubRouteTableV2OutputWithContext(ctx context.Context) VirtualHubRouteTableV2Output {
	return pulumi.ToOutputWithContext(ctx, i).(VirtualHubRouteTableV2Output)
}

type VirtualHubRouteTableV2Output struct {
	*pulumi.OutputState
}

func (VirtualHubRouteTableV2Output) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualHubRouteTableV2Output)(nil)).Elem()
}

func (o VirtualHubRouteTableV2Output) ToVirtualHubRouteTableV2Output() VirtualHubRouteTableV2Output {
	return o
}

func (o VirtualHubRouteTableV2Output) ToVirtualHubRouteTableV2OutputWithContext(ctx context.Context) VirtualHubRouteTableV2Output {
	return o
}

func init() {
	pulumi.RegisterOutputType(VirtualHubRouteTableV2Output{})
}
