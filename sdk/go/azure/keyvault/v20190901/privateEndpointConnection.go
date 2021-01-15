// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190901

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Private endpoint connection resource.
type PrivateEndpointConnection struct {
	pulumi.CustomResourceState

	// Modified whenever there is a change in the state of private endpoint connection.
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// Azure location of the key vault resource.
	Location pulumi.StringOutput `pulumi:"location"`
	// Name of the key vault resource.
	Name pulumi.StringOutput `pulumi:"name"`
	// Properties of the private endpoint object.
	PrivateEndpoint PrivateEndpointResponsePtrOutput `pulumi:"privateEndpoint"`
	// Approval state of the private link connection.
	PrivateLinkServiceConnectionState PrivateLinkServiceConnectionStateResponsePtrOutput `pulumi:"privateLinkServiceConnectionState"`
	// Provisioning state of the private endpoint connection.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Tags assigned to the key vault resource.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type of the key vault resource.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewPrivateEndpointConnection registers a new resource with the given unique name, arguments, and options.
func NewPrivateEndpointConnection(ctx *pulumi.Context,
	name string, args *PrivateEndpointConnectionArgs, opts ...pulumi.ResourceOption) (*PrivateEndpointConnection, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.PrivateEndpointConnectionName == nil {
		return nil, errors.New("invalid value for required argument 'PrivateEndpointConnectionName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.VaultName == nil {
		return nil, errors.New("invalid value for required argument 'VaultName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:keyvault/latest:PrivateEndpointConnection"),
		},
		{
			Type: pulumi.String("azure-nextgen:keyvault/v20180214:PrivateEndpointConnection"),
		},
		{
			Type: pulumi.String("azure-nextgen:keyvault/v20200401preview:PrivateEndpointConnection"),
		},
	})
	opts = append(opts, aliases)
	var resource PrivateEndpointConnection
	err := ctx.RegisterResource("azure-nextgen:keyvault/v20190901:PrivateEndpointConnection", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPrivateEndpointConnection gets an existing PrivateEndpointConnection resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPrivateEndpointConnection(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PrivateEndpointConnectionState, opts ...pulumi.ResourceOption) (*PrivateEndpointConnection, error) {
	var resource PrivateEndpointConnection
	err := ctx.ReadResource("azure-nextgen:keyvault/v20190901:PrivateEndpointConnection", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PrivateEndpointConnection resources.
type privateEndpointConnectionState struct {
	// Modified whenever there is a change in the state of private endpoint connection.
	Etag *string `pulumi:"etag"`
	// Azure location of the key vault resource.
	Location *string `pulumi:"location"`
	// Name of the key vault resource.
	Name *string `pulumi:"name"`
	// Properties of the private endpoint object.
	PrivateEndpoint *PrivateEndpointResponse `pulumi:"privateEndpoint"`
	// Approval state of the private link connection.
	PrivateLinkServiceConnectionState *PrivateLinkServiceConnectionStateResponse `pulumi:"privateLinkServiceConnectionState"`
	// Provisioning state of the private endpoint connection.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Tags assigned to the key vault resource.
	Tags map[string]string `pulumi:"tags"`
	// Resource type of the key vault resource.
	Type *string `pulumi:"type"`
}

type PrivateEndpointConnectionState struct {
	// Modified whenever there is a change in the state of private endpoint connection.
	Etag pulumi.StringPtrInput
	// Azure location of the key vault resource.
	Location pulumi.StringPtrInput
	// Name of the key vault resource.
	Name pulumi.StringPtrInput
	// Properties of the private endpoint object.
	PrivateEndpoint PrivateEndpointResponsePtrInput
	// Approval state of the private link connection.
	PrivateLinkServiceConnectionState PrivateLinkServiceConnectionStateResponsePtrInput
	// Provisioning state of the private endpoint connection.
	ProvisioningState pulumi.StringPtrInput
	// Tags assigned to the key vault resource.
	Tags pulumi.StringMapInput
	// Resource type of the key vault resource.
	Type pulumi.StringPtrInput
}

func (PrivateEndpointConnectionState) ElementType() reflect.Type {
	return reflect.TypeOf((*privateEndpointConnectionState)(nil)).Elem()
}

type privateEndpointConnectionArgs struct {
	// Modified whenever there is a change in the state of private endpoint connection.
	Etag *string `pulumi:"etag"`
	// Name of the private endpoint connection associated with the key vault.
	PrivateEndpointConnectionName string `pulumi:"privateEndpointConnectionName"`
	// Approval state of the private link connection.
	PrivateLinkServiceConnectionState *PrivateLinkServiceConnectionState `pulumi:"privateLinkServiceConnectionState"`
	// Name of the resource group that contains the key vault.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the key vault.
	VaultName string `pulumi:"vaultName"`
}

// The set of arguments for constructing a PrivateEndpointConnection resource.
type PrivateEndpointConnectionArgs struct {
	// Modified whenever there is a change in the state of private endpoint connection.
	Etag pulumi.StringPtrInput
	// Name of the private endpoint connection associated with the key vault.
	PrivateEndpointConnectionName pulumi.StringInput
	// Approval state of the private link connection.
	PrivateLinkServiceConnectionState PrivateLinkServiceConnectionStatePtrInput
	// Name of the resource group that contains the key vault.
	ResourceGroupName pulumi.StringInput
	// The name of the key vault.
	VaultName pulumi.StringInput
}

func (PrivateEndpointConnectionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*privateEndpointConnectionArgs)(nil)).Elem()
}

type PrivateEndpointConnectionInput interface {
	pulumi.Input

	ToPrivateEndpointConnectionOutput() PrivateEndpointConnectionOutput
	ToPrivateEndpointConnectionOutputWithContext(ctx context.Context) PrivateEndpointConnectionOutput
}

func (*PrivateEndpointConnection) ElementType() reflect.Type {
	return reflect.TypeOf((*PrivateEndpointConnection)(nil))
}

func (i *PrivateEndpointConnection) ToPrivateEndpointConnectionOutput() PrivateEndpointConnectionOutput {
	return i.ToPrivateEndpointConnectionOutputWithContext(context.Background())
}

func (i *PrivateEndpointConnection) ToPrivateEndpointConnectionOutputWithContext(ctx context.Context) PrivateEndpointConnectionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PrivateEndpointConnectionOutput)
}

type PrivateEndpointConnectionOutput struct {
	*pulumi.OutputState
}

func (PrivateEndpointConnectionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*PrivateEndpointConnection)(nil))
}

func (o PrivateEndpointConnectionOutput) ToPrivateEndpointConnectionOutput() PrivateEndpointConnectionOutput {
	return o
}

func (o PrivateEndpointConnectionOutput) ToPrivateEndpointConnectionOutputWithContext(ctx context.Context) PrivateEndpointConnectionOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(PrivateEndpointConnectionOutput{})
}
