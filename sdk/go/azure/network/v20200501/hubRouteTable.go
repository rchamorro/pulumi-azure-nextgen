// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200501

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// RouteTable resource in a virtual hub.
type HubRouteTable struct {
	pulumi.CustomResourceState

	// List of all connections associated with this route table.
	AssociatedConnections pulumi.StringArrayOutput `pulumi:"associatedConnections"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// List of labels associated with this route table.
	Labels pulumi.StringArrayOutput `pulumi:"labels"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// List of all connections that advertise to this route table.
	PropagatingConnections pulumi.StringArrayOutput `pulumi:"propagatingConnections"`
	// The provisioning state of the RouteTable resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// List of all routes.
	Routes HubRouteResponseArrayOutput `pulumi:"routes"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewHubRouteTable registers a new resource with the given unique name, arguments, and options.
func NewHubRouteTable(ctx *pulumi.Context,
	name string, args *HubRouteTableArgs, opts ...pulumi.ResourceOption) (*HubRouteTable, error) {
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
		args = &HubRouteTableArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:HubRouteTable"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:HubRouteTable"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200601:HubRouteTable"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:HubRouteTable"),
		},
	})
	opts = append(opts, aliases)
	var resource HubRouteTable
	err := ctx.RegisterResource("azure-nextgen:network/v20200501:HubRouteTable", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetHubRouteTable gets an existing HubRouteTable resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetHubRouteTable(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *HubRouteTableState, opts ...pulumi.ResourceOption) (*HubRouteTable, error) {
	var resource HubRouteTable
	err := ctx.ReadResource("azure-nextgen:network/v20200501:HubRouteTable", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering HubRouteTable resources.
type hubRouteTableState struct {
	// List of all connections associated with this route table.
	AssociatedConnections []string `pulumi:"associatedConnections"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// List of labels associated with this route table.
	Labels []string `pulumi:"labels"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name *string `pulumi:"name"`
	// List of all connections that advertise to this route table.
	PropagatingConnections []string `pulumi:"propagatingConnections"`
	// The provisioning state of the RouteTable resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// List of all routes.
	Routes []HubRouteResponse `pulumi:"routes"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type HubRouteTableState struct {
	// List of all connections associated with this route table.
	AssociatedConnections pulumi.StringArrayInput
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// List of labels associated with this route table.
	Labels pulumi.StringArrayInput
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrInput
	// List of all connections that advertise to this route table.
	PropagatingConnections pulumi.StringArrayInput
	// The provisioning state of the RouteTable resource.
	ProvisioningState pulumi.StringPtrInput
	// List of all routes.
	Routes HubRouteResponseArrayInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (HubRouteTableState) ElementType() reflect.Type {
	return reflect.TypeOf((*hubRouteTableState)(nil)).Elem()
}

type hubRouteTableArgs struct {
	// Resource ID.
	Id *string `pulumi:"id"`
	// List of labels associated with this route table.
	Labels []string `pulumi:"labels"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name *string `pulumi:"name"`
	// The resource group name of the VirtualHub.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the RouteTable.
	RouteTableName string `pulumi:"routeTableName"`
	// List of all routes.
	Routes []HubRoute `pulumi:"routes"`
	// The name of the VirtualHub.
	VirtualHubName string `pulumi:"virtualHubName"`
}

// The set of arguments for constructing a HubRouteTable resource.
type HubRouteTableArgs struct {
	// Resource ID.
	Id pulumi.StringPtrInput
	// List of labels associated with this route table.
	Labels pulumi.StringArrayInput
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrInput
	// The resource group name of the VirtualHub.
	ResourceGroupName pulumi.StringInput
	// The name of the RouteTable.
	RouteTableName pulumi.StringInput
	// List of all routes.
	Routes HubRouteArrayInput
	// The name of the VirtualHub.
	VirtualHubName pulumi.StringInput
}

func (HubRouteTableArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*hubRouteTableArgs)(nil)).Elem()
}

type HubRouteTableInput interface {
	pulumi.Input

	ToHubRouteTableOutput() HubRouteTableOutput
	ToHubRouteTableOutputWithContext(ctx context.Context) HubRouteTableOutput
}

func (HubRouteTable) ElementType() reflect.Type {
	return reflect.TypeOf((*HubRouteTable)(nil)).Elem()
}

func (i HubRouteTable) ToHubRouteTableOutput() HubRouteTableOutput {
	return i.ToHubRouteTableOutputWithContext(context.Background())
}

func (i HubRouteTable) ToHubRouteTableOutputWithContext(ctx context.Context) HubRouteTableOutput {
	return pulumi.ToOutputWithContext(ctx, i).(HubRouteTableOutput)
}

type HubRouteTableOutput struct {
	*pulumi.OutputState
}

func (HubRouteTableOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*HubRouteTableOutput)(nil)).Elem()
}

func (o HubRouteTableOutput) ToHubRouteTableOutput() HubRouteTableOutput {
	return o
}

func (o HubRouteTableOutput) ToHubRouteTableOutputWithContext(ctx context.Context) HubRouteTableOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(HubRouteTableOutput{})
}
