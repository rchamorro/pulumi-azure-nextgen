// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180801

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Network profile resource.
type NetworkProfile struct {
	pulumi.CustomResourceState

	// List of chid container network interface configurations.
	ContainerNetworkInterfaceConfigurations ContainerNetworkInterfaceConfigurationResponseArrayOutput `pulumi:"containerNetworkInterfaceConfigurations"`
	// List of child container network interfaces.
	ContainerNetworkInterfaces ContainerNetworkInterfaceResponseArrayOutput `pulumi:"containerNetworkInterfaces"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// Resource location.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The provisioning state of the resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The resource GUID property of the network interface resource.
	ResourceGuid pulumi.StringOutput `pulumi:"resourceGuid"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewNetworkProfile registers a new resource with the given unique name, arguments, and options.
func NewNetworkProfile(ctx *pulumi.Context,
	name string, args *NetworkProfileArgs, opts ...pulumi.ResourceOption) (*NetworkProfile, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.NetworkProfileName == nil {
		return nil, errors.New("invalid value for required argument 'NetworkProfileName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:NetworkProfile"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181001:NetworkProfile"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181101:NetworkProfile"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181201:NetworkProfile"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190201:NetworkProfile"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190401:NetworkProfile"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190601:NetworkProfile"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190701:NetworkProfile"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190801:NetworkProfile"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190901:NetworkProfile"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191101:NetworkProfile"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191201:NetworkProfile"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200301:NetworkProfile"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:NetworkProfile"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:NetworkProfile"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200601:NetworkProfile"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:NetworkProfile"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200801:NetworkProfile"),
		},
	})
	opts = append(opts, aliases)
	var resource NetworkProfile
	err := ctx.RegisterResource("azure-nextgen:network/v20180801:NetworkProfile", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNetworkProfile gets an existing NetworkProfile resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNetworkProfile(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NetworkProfileState, opts ...pulumi.ResourceOption) (*NetworkProfile, error) {
	var resource NetworkProfile
	err := ctx.ReadResource("azure-nextgen:network/v20180801:NetworkProfile", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering NetworkProfile resources.
type networkProfileState struct {
	// List of chid container network interface configurations.
	ContainerNetworkInterfaceConfigurations []ContainerNetworkInterfaceConfigurationResponse `pulumi:"containerNetworkInterfaceConfigurations"`
	// List of child container network interfaces.
	ContainerNetworkInterfaces []ContainerNetworkInterfaceResponse `pulumi:"containerNetworkInterfaces"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// Resource location.
	Location *string `pulumi:"location"`
	// Resource name.
	Name *string `pulumi:"name"`
	// The provisioning state of the resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The resource GUID property of the network interface resource.
	ResourceGuid *string `pulumi:"resourceGuid"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type NetworkProfileState struct {
	// List of chid container network interface configurations.
	ContainerNetworkInterfaceConfigurations ContainerNetworkInterfaceConfigurationResponseArrayInput
	// List of child container network interfaces.
	ContainerNetworkInterfaces ContainerNetworkInterfaceResponseArrayInput
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// The provisioning state of the resource.
	ProvisioningState pulumi.StringPtrInput
	// The resource GUID property of the network interface resource.
	ResourceGuid pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (NetworkProfileState) ElementType() reflect.Type {
	return reflect.TypeOf((*networkProfileState)(nil)).Elem()
}

type networkProfileArgs struct {
	// List of chid container network interface configurations.
	ContainerNetworkInterfaceConfigurations []ContainerNetworkInterfaceConfiguration `pulumi:"containerNetworkInterfaceConfigurations"`
	// List of child container network interfaces.
	ContainerNetworkInterfaces []ContainerNetworkInterface `pulumi:"containerNetworkInterfaces"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// Resource ID.
	Id *string `pulumi:"id"`
	// Resource location.
	Location *string `pulumi:"location"`
	// The name of the network profile.
	NetworkProfileName string `pulumi:"networkProfileName"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a NetworkProfile resource.
type NetworkProfileArgs struct {
	// List of chid container network interface configurations.
	ContainerNetworkInterfaceConfigurations ContainerNetworkInterfaceConfigurationArrayInput
	// List of child container network interfaces.
	ContainerNetworkInterfaces ContainerNetworkInterfaceArrayInput
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// Resource ID.
	Id pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// The name of the network profile.
	NetworkProfileName pulumi.StringInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
}

func (NetworkProfileArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*networkProfileArgs)(nil)).Elem()
}

type NetworkProfileInput interface {
	pulumi.Input

	ToNetworkProfileOutput() NetworkProfileOutput
	ToNetworkProfileOutputWithContext(ctx context.Context) NetworkProfileOutput
}

func (*NetworkProfile) ElementType() reflect.Type {
	return reflect.TypeOf((*NetworkProfile)(nil))
}

func (i *NetworkProfile) ToNetworkProfileOutput() NetworkProfileOutput {
	return i.ToNetworkProfileOutputWithContext(context.Background())
}

func (i *NetworkProfile) ToNetworkProfileOutputWithContext(ctx context.Context) NetworkProfileOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NetworkProfileOutput)
}

type NetworkProfileOutput struct {
	*pulumi.OutputState
}

func (NetworkProfileOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*NetworkProfile)(nil))
}

func (o NetworkProfileOutput) ToNetworkProfileOutput() NetworkProfileOutput {
	return o
}

func (o NetworkProfileOutput) ToNetworkProfileOutputWithContext(ctx context.Context) NetworkProfileOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(NetworkProfileOutput{})
}
