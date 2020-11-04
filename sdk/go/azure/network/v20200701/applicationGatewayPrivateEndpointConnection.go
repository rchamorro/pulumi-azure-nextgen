// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200701

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Private Endpoint connection on an application gateway.
type ApplicationGatewayPrivateEndpointConnection struct {
	pulumi.CustomResourceState

	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// The consumer link id.
	LinkIdentifier pulumi.StringOutput `pulumi:"linkIdentifier"`
	// Name of the private endpoint connection on an application gateway.
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// The resource of private end point.
	PrivateEndpoint PrivateEndpointResponseOutput `pulumi:"privateEndpoint"`
	// A collection of information about the state of the connection between service consumer and provider.
	PrivateLinkServiceConnectionState PrivateLinkServiceConnectionStateResponsePtrOutput `pulumi:"privateLinkServiceConnectionState"`
	// The provisioning state of the application gateway private endpoint connection resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Type of the resource.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewApplicationGatewayPrivateEndpointConnection registers a new resource with the given unique name, arguments, and options.
func NewApplicationGatewayPrivateEndpointConnection(ctx *pulumi.Context,
	name string, args *ApplicationGatewayPrivateEndpointConnectionArgs, opts ...pulumi.ResourceOption) (*ApplicationGatewayPrivateEndpointConnection, error) {
	if args == nil || args.ApplicationGatewayName == nil {
		return nil, errors.New("missing required argument 'ApplicationGatewayName'")
	}
	if args == nil || args.ConnectionName == nil {
		return nil, errors.New("missing required argument 'ConnectionName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &ApplicationGatewayPrivateEndpointConnectionArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:ApplicationGatewayPrivateEndpointConnection"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:ApplicationGatewayPrivateEndpointConnection"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200601:ApplicationGatewayPrivateEndpointConnection"),
		},
	})
	opts = append(opts, aliases)
	var resource ApplicationGatewayPrivateEndpointConnection
	err := ctx.RegisterResource("azure-nextgen:network/v20200701:ApplicationGatewayPrivateEndpointConnection", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetApplicationGatewayPrivateEndpointConnection gets an existing ApplicationGatewayPrivateEndpointConnection resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetApplicationGatewayPrivateEndpointConnection(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ApplicationGatewayPrivateEndpointConnectionState, opts ...pulumi.ResourceOption) (*ApplicationGatewayPrivateEndpointConnection, error) {
	var resource ApplicationGatewayPrivateEndpointConnection
	err := ctx.ReadResource("azure-nextgen:network/v20200701:ApplicationGatewayPrivateEndpointConnection", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ApplicationGatewayPrivateEndpointConnection resources.
type applicationGatewayPrivateEndpointConnectionState struct {
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// The consumer link id.
	LinkIdentifier *string `pulumi:"linkIdentifier"`
	// Name of the private endpoint connection on an application gateway.
	Name *string `pulumi:"name"`
	// The resource of private end point.
	PrivateEndpoint *PrivateEndpointResponse `pulumi:"privateEndpoint"`
	// A collection of information about the state of the connection between service consumer and provider.
	PrivateLinkServiceConnectionState *PrivateLinkServiceConnectionStateResponse `pulumi:"privateLinkServiceConnectionState"`
	// The provisioning state of the application gateway private endpoint connection resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Type of the resource.
	Type *string `pulumi:"type"`
}

type ApplicationGatewayPrivateEndpointConnectionState struct {
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// The consumer link id.
	LinkIdentifier pulumi.StringPtrInput
	// Name of the private endpoint connection on an application gateway.
	Name pulumi.StringPtrInput
	// The resource of private end point.
	PrivateEndpoint PrivateEndpointResponsePtrInput
	// A collection of information about the state of the connection between service consumer and provider.
	PrivateLinkServiceConnectionState PrivateLinkServiceConnectionStateResponsePtrInput
	// The provisioning state of the application gateway private endpoint connection resource.
	ProvisioningState pulumi.StringPtrInput
	// Type of the resource.
	Type pulumi.StringPtrInput
}

func (ApplicationGatewayPrivateEndpointConnectionState) ElementType() reflect.Type {
	return reflect.TypeOf((*applicationGatewayPrivateEndpointConnectionState)(nil)).Elem()
}

type applicationGatewayPrivateEndpointConnectionArgs struct {
	// The name of the application gateway.
	ApplicationGatewayName string `pulumi:"applicationGatewayName"`
	// The name of the application gateway private endpoint connection.
	ConnectionName string `pulumi:"connectionName"`
	// Resource ID.
	Id *string `pulumi:"id"`
	// Name of the private endpoint connection on an application gateway.
	Name *string `pulumi:"name"`
	// A collection of information about the state of the connection between service consumer and provider.
	PrivateLinkServiceConnectionState *PrivateLinkServiceConnectionState `pulumi:"privateLinkServiceConnectionState"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The set of arguments for constructing a ApplicationGatewayPrivateEndpointConnection resource.
type ApplicationGatewayPrivateEndpointConnectionArgs struct {
	// The name of the application gateway.
	ApplicationGatewayName pulumi.StringInput
	// The name of the application gateway private endpoint connection.
	ConnectionName pulumi.StringInput
	// Resource ID.
	Id pulumi.StringPtrInput
	// Name of the private endpoint connection on an application gateway.
	Name pulumi.StringPtrInput
	// A collection of information about the state of the connection between service consumer and provider.
	PrivateLinkServiceConnectionState PrivateLinkServiceConnectionStatePtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
}

func (ApplicationGatewayPrivateEndpointConnectionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*applicationGatewayPrivateEndpointConnectionArgs)(nil)).Elem()
}
