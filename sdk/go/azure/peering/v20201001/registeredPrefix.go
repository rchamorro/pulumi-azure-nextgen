// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20201001

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The customer's prefix that is registered by the peering service provider.
type RegisteredPrefix struct {
	pulumi.CustomResourceState

	// The error message associated with the validation state, if any.
	ErrorMessage pulumi.StringOutput `pulumi:"errorMessage"`
	// The name of the resource.
	Name pulumi.StringOutput `pulumi:"name"`
	// The peering service prefix key that is to be shared with the customer.
	PeeringServicePrefixKey pulumi.StringOutput `pulumi:"peeringServicePrefixKey"`
	// The customer's prefix from which traffic originates.
	Prefix pulumi.StringPtrOutput `pulumi:"prefix"`
	// The prefix validation state.
	PrefixValidationState pulumi.StringOutput `pulumi:"prefixValidationState"`
	// The provisioning state of the resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The type of the resource.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewRegisteredPrefix registers a new resource with the given unique name, arguments, and options.
func NewRegisteredPrefix(ctx *pulumi.Context,
	name string, args *RegisteredPrefixArgs, opts ...pulumi.ResourceOption) (*RegisteredPrefix, error) {
	if args == nil || args.PeeringName == nil {
		return nil, errors.New("missing required argument 'PeeringName'")
	}
	if args == nil || args.RegisteredPrefixName == nil {
		return nil, errors.New("missing required argument 'RegisteredPrefixName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &RegisteredPrefixArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:peering/latest:RegisteredPrefix"),
		},
		{
			Type: pulumi.String("azure-nextgen:peering/v20200101preview:RegisteredPrefix"),
		},
		{
			Type: pulumi.String("azure-nextgen:peering/v20200401:RegisteredPrefix"),
		},
	})
	opts = append(opts, aliases)
	var resource RegisteredPrefix
	err := ctx.RegisterResource("azure-nextgen:peering/v20201001:RegisteredPrefix", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRegisteredPrefix gets an existing RegisteredPrefix resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRegisteredPrefix(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RegisteredPrefixState, opts ...pulumi.ResourceOption) (*RegisteredPrefix, error) {
	var resource RegisteredPrefix
	err := ctx.ReadResource("azure-nextgen:peering/v20201001:RegisteredPrefix", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RegisteredPrefix resources.
type registeredPrefixState struct {
	// The error message associated with the validation state, if any.
	ErrorMessage *string `pulumi:"errorMessage"`
	// The name of the resource.
	Name *string `pulumi:"name"`
	// The peering service prefix key that is to be shared with the customer.
	PeeringServicePrefixKey *string `pulumi:"peeringServicePrefixKey"`
	// The customer's prefix from which traffic originates.
	Prefix *string `pulumi:"prefix"`
	// The prefix validation state.
	PrefixValidationState *string `pulumi:"prefixValidationState"`
	// The provisioning state of the resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The type of the resource.
	Type *string `pulumi:"type"`
}

type RegisteredPrefixState struct {
	// The error message associated with the validation state, if any.
	ErrorMessage pulumi.StringPtrInput
	// The name of the resource.
	Name pulumi.StringPtrInput
	// The peering service prefix key that is to be shared with the customer.
	PeeringServicePrefixKey pulumi.StringPtrInput
	// The customer's prefix from which traffic originates.
	Prefix pulumi.StringPtrInput
	// The prefix validation state.
	PrefixValidationState pulumi.StringPtrInput
	// The provisioning state of the resource.
	ProvisioningState pulumi.StringPtrInput
	// The type of the resource.
	Type pulumi.StringPtrInput
}

func (RegisteredPrefixState) ElementType() reflect.Type {
	return reflect.TypeOf((*registeredPrefixState)(nil)).Elem()
}

type registeredPrefixArgs struct {
	// The name of the peering.
	PeeringName string `pulumi:"peeringName"`
	// The customer's prefix from which traffic originates.
	Prefix *string `pulumi:"prefix"`
	// The name of the registered prefix.
	RegisteredPrefixName string `pulumi:"registeredPrefixName"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The set of arguments for constructing a RegisteredPrefix resource.
type RegisteredPrefixArgs struct {
	// The name of the peering.
	PeeringName pulumi.StringInput
	// The customer's prefix from which traffic originates.
	Prefix pulumi.StringPtrInput
	// The name of the registered prefix.
	RegisteredPrefixName pulumi.StringInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
}

func (RegisteredPrefixArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*registeredPrefixArgs)(nil)).Elem()
}