// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20191201

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// PrivateEndpointConnection resource.
type PrivateLinkServicePrivateEndpointConnection struct {
	pulumi.CustomResourceState

	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// The consumer link id.
	LinkIdentifier pulumi.StringOutput `pulumi:"linkIdentifier"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// The resource of private end point.
	PrivateEndpoint PrivateEndpointResponseOutput `pulumi:"privateEndpoint"`
	// A collection of information about the state of the connection between service consumer and provider.
	PrivateLinkServiceConnectionState PrivateLinkServiceConnectionStateResponsePtrOutput `pulumi:"privateLinkServiceConnectionState"`
	// The provisioning state of the private endpoint connection resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewPrivateLinkServicePrivateEndpointConnection registers a new resource with the given unique name, arguments, and options.
func NewPrivateLinkServicePrivateEndpointConnection(ctx *pulumi.Context,
	name string, args *PrivateLinkServicePrivateEndpointConnectionArgs, opts ...pulumi.ResourceOption) (*PrivateLinkServicePrivateEndpointConnection, error) {
	if args == nil || args.PeConnectionName == nil {
		return nil, errors.New("missing required argument 'PeConnectionName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.ServiceName == nil {
		return nil, errors.New("missing required argument 'ServiceName'")
	}
	if args == nil {
		args = &PrivateLinkServicePrivateEndpointConnectionArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:PrivateLinkServicePrivateEndpointConnection"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190901:PrivateLinkServicePrivateEndpointConnection"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191101:PrivateLinkServicePrivateEndpointConnection"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200301:PrivateLinkServicePrivateEndpointConnection"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:PrivateLinkServicePrivateEndpointConnection"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:PrivateLinkServicePrivateEndpointConnection"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200601:PrivateLinkServicePrivateEndpointConnection"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:PrivateLinkServicePrivateEndpointConnection"),
		},
	})
	opts = append(opts, aliases)
	var resource PrivateLinkServicePrivateEndpointConnection
	err := ctx.RegisterResource("azure-nextgen:network/v20191201:PrivateLinkServicePrivateEndpointConnection", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPrivateLinkServicePrivateEndpointConnection gets an existing PrivateLinkServicePrivateEndpointConnection resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPrivateLinkServicePrivateEndpointConnection(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PrivateLinkServicePrivateEndpointConnectionState, opts ...pulumi.ResourceOption) (*PrivateLinkServicePrivateEndpointConnection, error) {
	var resource PrivateLinkServicePrivateEndpointConnection
	err := ctx.ReadResource("azure-nextgen:network/v20191201:PrivateLinkServicePrivateEndpointConnection", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PrivateLinkServicePrivateEndpointConnection resources.
type privateLinkServicePrivateEndpointConnectionState struct {
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// The consumer link id.
	LinkIdentifier *string `pulumi:"linkIdentifier"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name *string `pulumi:"name"`
	// The resource of private end point.
	PrivateEndpoint *PrivateEndpointResponse `pulumi:"privateEndpoint"`
	// A collection of information about the state of the connection between service consumer and provider.
	PrivateLinkServiceConnectionState *PrivateLinkServiceConnectionStateResponse `pulumi:"privateLinkServiceConnectionState"`
	// The provisioning state of the private endpoint connection resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The resource type.
	Type *string `pulumi:"type"`
}

type PrivateLinkServicePrivateEndpointConnectionState struct {
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// The consumer link id.
	LinkIdentifier pulumi.StringPtrInput
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrInput
	// The resource of private end point.
	PrivateEndpoint PrivateEndpointResponsePtrInput
	// A collection of information about the state of the connection between service consumer and provider.
	PrivateLinkServiceConnectionState PrivateLinkServiceConnectionStateResponsePtrInput
	// The provisioning state of the private endpoint connection resource.
	ProvisioningState pulumi.StringPtrInput
	// The resource type.
	Type pulumi.StringPtrInput
}

func (PrivateLinkServicePrivateEndpointConnectionState) ElementType() reflect.Type {
	return reflect.TypeOf((*privateLinkServicePrivateEndpointConnectionState)(nil)).Elem()
}

type privateLinkServicePrivateEndpointConnectionArgs struct {
	// Resource ID.
	Id *string `pulumi:"id"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name *string `pulumi:"name"`
	// The name of the private end point connection.
	PeConnectionName string `pulumi:"peConnectionName"`
	// A collection of information about the state of the connection between service consumer and provider.
	PrivateLinkServiceConnectionState *PrivateLinkServiceConnectionState `pulumi:"privateLinkServiceConnectionState"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the private link service.
	ServiceName string `pulumi:"serviceName"`
}

// The set of arguments for constructing a PrivateLinkServicePrivateEndpointConnection resource.
type PrivateLinkServicePrivateEndpointConnectionArgs struct {
	// Resource ID.
	Id pulumi.StringPtrInput
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrInput
	// The name of the private end point connection.
	PeConnectionName pulumi.StringInput
	// A collection of information about the state of the connection between service consumer and provider.
	PrivateLinkServiceConnectionState PrivateLinkServiceConnectionStatePtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// The name of the private link service.
	ServiceName pulumi.StringInput
}

func (PrivateLinkServicePrivateEndpointConnectionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*privateLinkServicePrivateEndpointConnectionArgs)(nil)).Elem()
}
