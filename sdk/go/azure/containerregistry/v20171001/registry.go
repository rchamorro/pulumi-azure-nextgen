// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20171001

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// An object that represents a container registry.
type Registry struct {
	pulumi.CustomResourceState

	// The value that indicates whether the admin user is enabled.
	AdminUserEnabled pulumi.BoolPtrOutput `pulumi:"adminUserEnabled"`
	// The creation date of the container registry in ISO8601 format.
	CreationDate pulumi.StringOutput `pulumi:"creationDate"`
	// The location of the resource. This cannot be changed after the resource is created.
	Location pulumi.StringOutput `pulumi:"location"`
	// The URL that can be used to log into the container registry.
	LoginServer pulumi.StringOutput `pulumi:"loginServer"`
	// The name of the resource.
	Name pulumi.StringOutput `pulumi:"name"`
	// The network rule set for a container registry.
	NetworkRuleSet NetworkRuleSetResponsePtrOutput `pulumi:"networkRuleSet"`
	// The provisioning state of the container registry at the time the operation was called.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The SKU of the container registry.
	Sku SkuResponseOutput `pulumi:"sku"`
	// The status of the container registry at the time the operation was called.
	Status StatusResponseOutput `pulumi:"status"`
	// The properties of the storage account for the container registry. Only applicable to Classic SKU.
	StorageAccount StorageAccountPropertiesResponsePtrOutput `pulumi:"storageAccount"`
	// The tags of the resource.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the resource.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewRegistry registers a new resource with the given unique name, arguments, and options.
func NewRegistry(ctx *pulumi.Context,
	name string, args *RegistryArgs, opts ...pulumi.ResourceOption) (*Registry, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Location == nil {
		return nil, errors.New("invalid value for required argument 'Location'")
	}
	if args.RegistryName == nil {
		return nil, errors.New("invalid value for required argument 'RegistryName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.Sku == nil {
		return nil, errors.New("invalid value for required argument 'Sku'")
	}
	if args.AdminUserEnabled == nil {
		args.AdminUserEnabled = pulumi.BoolPtr(false)
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:containerregistry/latest:Registry"),
		},
		{
			Type: pulumi.String("azure-nextgen:containerregistry/v20160627preview:Registry"),
		},
		{
			Type: pulumi.String("azure-nextgen:containerregistry/v20170301:Registry"),
		},
		{
			Type: pulumi.String("azure-nextgen:containerregistry/v20170601preview:Registry"),
		},
		{
			Type: pulumi.String("azure-nextgen:containerregistry/v20190501:Registry"),
		},
		{
			Type: pulumi.String("azure-nextgen:containerregistry/v20191201preview:Registry"),
		},
		{
			Type: pulumi.String("azure-nextgen:containerregistry/v20201101preview:Registry"),
		},
	})
	opts = append(opts, aliases)
	var resource Registry
	err := ctx.RegisterResource("azure-nextgen:containerregistry/v20171001:Registry", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRegistry gets an existing Registry resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRegistry(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RegistryState, opts ...pulumi.ResourceOption) (*Registry, error) {
	var resource Registry
	err := ctx.ReadResource("azure-nextgen:containerregistry/v20171001:Registry", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Registry resources.
type registryState struct {
	// The value that indicates whether the admin user is enabled.
	AdminUserEnabled *bool `pulumi:"adminUserEnabled"`
	// The creation date of the container registry in ISO8601 format.
	CreationDate *string `pulumi:"creationDate"`
	// The location of the resource. This cannot be changed after the resource is created.
	Location *string `pulumi:"location"`
	// The URL that can be used to log into the container registry.
	LoginServer *string `pulumi:"loginServer"`
	// The name of the resource.
	Name *string `pulumi:"name"`
	// The network rule set for a container registry.
	NetworkRuleSet *NetworkRuleSetResponse `pulumi:"networkRuleSet"`
	// The provisioning state of the container registry at the time the operation was called.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The SKU of the container registry.
	Sku *SkuResponse `pulumi:"sku"`
	// The status of the container registry at the time the operation was called.
	Status *StatusResponse `pulumi:"status"`
	// The properties of the storage account for the container registry. Only applicable to Classic SKU.
	StorageAccount *StorageAccountPropertiesResponse `pulumi:"storageAccount"`
	// The tags of the resource.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource.
	Type *string `pulumi:"type"`
}

type RegistryState struct {
	// The value that indicates whether the admin user is enabled.
	AdminUserEnabled pulumi.BoolPtrInput
	// The creation date of the container registry in ISO8601 format.
	CreationDate pulumi.StringPtrInput
	// The location of the resource. This cannot be changed after the resource is created.
	Location pulumi.StringPtrInput
	// The URL that can be used to log into the container registry.
	LoginServer pulumi.StringPtrInput
	// The name of the resource.
	Name pulumi.StringPtrInput
	// The network rule set for a container registry.
	NetworkRuleSet NetworkRuleSetResponsePtrInput
	// The provisioning state of the container registry at the time the operation was called.
	ProvisioningState pulumi.StringPtrInput
	// The SKU of the container registry.
	Sku SkuResponsePtrInput
	// The status of the container registry at the time the operation was called.
	Status StatusResponsePtrInput
	// The properties of the storage account for the container registry. Only applicable to Classic SKU.
	StorageAccount StorageAccountPropertiesResponsePtrInput
	// The tags of the resource.
	Tags pulumi.StringMapInput
	// The type of the resource.
	Type pulumi.StringPtrInput
}

func (RegistryState) ElementType() reflect.Type {
	return reflect.TypeOf((*registryState)(nil)).Elem()
}

type registryArgs struct {
	// The value that indicates whether the admin user is enabled.
	AdminUserEnabled *bool `pulumi:"adminUserEnabled"`
	// The location of the resource. This cannot be changed after the resource is created.
	Location string `pulumi:"location"`
	// The network rule set for a container registry.
	NetworkRuleSet *NetworkRuleSet `pulumi:"networkRuleSet"`
	// The name of the container registry.
	RegistryName string `pulumi:"registryName"`
	// The name of the resource group to which the container registry belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The SKU of the container registry.
	Sku Sku `pulumi:"sku"`
	// The properties of the storage account for the container registry. Only applicable to Classic SKU.
	StorageAccount *StorageAccountProperties `pulumi:"storageAccount"`
	// The tags of the resource.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a Registry resource.
type RegistryArgs struct {
	// The value that indicates whether the admin user is enabled.
	AdminUserEnabled pulumi.BoolPtrInput
	// The location of the resource. This cannot be changed after the resource is created.
	Location pulumi.StringInput
	// The network rule set for a container registry.
	NetworkRuleSet NetworkRuleSetPtrInput
	// The name of the container registry.
	RegistryName pulumi.StringInput
	// The name of the resource group to which the container registry belongs.
	ResourceGroupName pulumi.StringInput
	// The SKU of the container registry.
	Sku SkuInput
	// The properties of the storage account for the container registry. Only applicable to Classic SKU.
	StorageAccount StorageAccountPropertiesPtrInput
	// The tags of the resource.
	Tags pulumi.StringMapInput
}

func (RegistryArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*registryArgs)(nil)).Elem()
}

type RegistryInput interface {
	pulumi.Input

	ToRegistryOutput() RegistryOutput
	ToRegistryOutputWithContext(ctx context.Context) RegistryOutput
}

func (*Registry) ElementType() reflect.Type {
	return reflect.TypeOf((*Registry)(nil))
}

func (i *Registry) ToRegistryOutput() RegistryOutput {
	return i.ToRegistryOutputWithContext(context.Background())
}

func (i *Registry) ToRegistryOutputWithContext(ctx context.Context) RegistryOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RegistryOutput)
}

type RegistryOutput struct {
	*pulumi.OutputState
}

func (RegistryOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Registry)(nil))
}

func (o RegistryOutput) ToRegistryOutput() RegistryOutput {
	return o
}

func (o RegistryOutput) ToRegistryOutputWithContext(ctx context.Context) RegistryOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(RegistryOutput{})
}
