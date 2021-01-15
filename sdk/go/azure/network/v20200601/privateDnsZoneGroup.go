// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200601

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Private dns zone group resource.
type PrivateDnsZoneGroup struct {
	pulumi.CustomResourceState

	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// Name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// A collection of private dns zone configurations of the private dns zone group.
	PrivateDnsZoneConfigs PrivateDnsZoneConfigResponseArrayOutput `pulumi:"privateDnsZoneConfigs"`
	// The provisioning state of the private dns zone group resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
}

// NewPrivateDnsZoneGroup registers a new resource with the given unique name, arguments, and options.
func NewPrivateDnsZoneGroup(ctx *pulumi.Context,
	name string, args *PrivateDnsZoneGroupArgs, opts ...pulumi.ResourceOption) (*PrivateDnsZoneGroup, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.PrivateDnsZoneGroupName == nil {
		return nil, errors.New("invalid value for required argument 'PrivateDnsZoneGroupName'")
	}
	if args.PrivateEndpointName == nil {
		return nil, errors.New("invalid value for required argument 'PrivateEndpointName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:PrivateDnsZoneGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200301:PrivateDnsZoneGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:PrivateDnsZoneGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:PrivateDnsZoneGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:PrivateDnsZoneGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200801:PrivateDnsZoneGroup"),
		},
	})
	opts = append(opts, aliases)
	var resource PrivateDnsZoneGroup
	err := ctx.RegisterResource("azure-nextgen:network/v20200601:PrivateDnsZoneGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPrivateDnsZoneGroup gets an existing PrivateDnsZoneGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPrivateDnsZoneGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PrivateDnsZoneGroupState, opts ...pulumi.ResourceOption) (*PrivateDnsZoneGroup, error) {
	var resource PrivateDnsZoneGroup
	err := ctx.ReadResource("azure-nextgen:network/v20200601:PrivateDnsZoneGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PrivateDnsZoneGroup resources.
type privateDnsZoneGroupState struct {
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// Name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name *string `pulumi:"name"`
	// A collection of private dns zone configurations of the private dns zone group.
	PrivateDnsZoneConfigs []PrivateDnsZoneConfigResponse `pulumi:"privateDnsZoneConfigs"`
	// The provisioning state of the private dns zone group resource.
	ProvisioningState *string `pulumi:"provisioningState"`
}

type PrivateDnsZoneGroupState struct {
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// Name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrInput
	// A collection of private dns zone configurations of the private dns zone group.
	PrivateDnsZoneConfigs PrivateDnsZoneConfigResponseArrayInput
	// The provisioning state of the private dns zone group resource.
	ProvisioningState pulumi.StringPtrInput
}

func (PrivateDnsZoneGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*privateDnsZoneGroupState)(nil)).Elem()
}

type privateDnsZoneGroupArgs struct {
	// Resource ID.
	Id *string `pulumi:"id"`
	// Name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name *string `pulumi:"name"`
	// A collection of private dns zone configurations of the private dns zone group.
	PrivateDnsZoneConfigs []PrivateDnsZoneConfig `pulumi:"privateDnsZoneConfigs"`
	// The name of the private dns zone group.
	PrivateDnsZoneGroupName string `pulumi:"privateDnsZoneGroupName"`
	// The name of the private endpoint.
	PrivateEndpointName string `pulumi:"privateEndpointName"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The set of arguments for constructing a PrivateDnsZoneGroup resource.
type PrivateDnsZoneGroupArgs struct {
	// Resource ID.
	Id pulumi.StringPtrInput
	// Name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrInput
	// A collection of private dns zone configurations of the private dns zone group.
	PrivateDnsZoneConfigs PrivateDnsZoneConfigArrayInput
	// The name of the private dns zone group.
	PrivateDnsZoneGroupName pulumi.StringInput
	// The name of the private endpoint.
	PrivateEndpointName pulumi.StringInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
}

func (PrivateDnsZoneGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*privateDnsZoneGroupArgs)(nil)).Elem()
}

type PrivateDnsZoneGroupInput interface {
	pulumi.Input

	ToPrivateDnsZoneGroupOutput() PrivateDnsZoneGroupOutput
	ToPrivateDnsZoneGroupOutputWithContext(ctx context.Context) PrivateDnsZoneGroupOutput
}

func (*PrivateDnsZoneGroup) ElementType() reflect.Type {
	return reflect.TypeOf((*PrivateDnsZoneGroup)(nil))
}

func (i *PrivateDnsZoneGroup) ToPrivateDnsZoneGroupOutput() PrivateDnsZoneGroupOutput {
	return i.ToPrivateDnsZoneGroupOutputWithContext(context.Background())
}

func (i *PrivateDnsZoneGroup) ToPrivateDnsZoneGroupOutputWithContext(ctx context.Context) PrivateDnsZoneGroupOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PrivateDnsZoneGroupOutput)
}

type PrivateDnsZoneGroupOutput struct {
	*pulumi.OutputState
}

func (PrivateDnsZoneGroupOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*PrivateDnsZoneGroup)(nil))
}

func (o PrivateDnsZoneGroupOutput) ToPrivateDnsZoneGroupOutput() PrivateDnsZoneGroupOutput {
	return o
}

func (o PrivateDnsZoneGroupOutput) ToPrivateDnsZoneGroupOutputWithContext(ctx context.Context) PrivateDnsZoneGroupOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(PrivateDnsZoneGroupOutput{})
}
