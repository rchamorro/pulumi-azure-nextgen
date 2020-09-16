// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Represents an instance of a Dedicated Capacity resource.
type CapacityDetails struct {
	pulumi.CustomResourceState

	// A collection of Dedicated capacity administrators
	Administration DedicatedCapacityAdministratorsResponsePtrOutput `pulumi:"administration"`
	// Location of the PowerBI Dedicated resource.
	Location pulumi.StringOutput `pulumi:"location"`
	// The name of the PowerBI Dedicated resource.
	Name pulumi.StringOutput `pulumi:"name"`
	// The current deployment state of PowerBI Dedicated resource. The provisioningState is to indicate states for resource provisioning.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The SKU of the PowerBI Dedicated resource.
	Sku ResourceSkuResponseOutput `pulumi:"sku"`
	// The current state of PowerBI Dedicated resource. The state is to indicate more states outside of resource provisioning.
	State pulumi.StringOutput `pulumi:"state"`
	// Key-value pairs of additional resource provisioning properties.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the PowerBI Dedicated resource.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewCapacityDetails registers a new resource with the given unique name, arguments, and options.
func NewCapacityDetails(ctx *pulumi.Context,
	name string, args *CapacityDetailsArgs, opts ...pulumi.ResourceOption) (*CapacityDetails, error) {
	if args == nil || args.DedicatedCapacityName == nil {
		return nil, errors.New("missing required argument 'DedicatedCapacityName'")
	}
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.Sku == nil {
		return nil, errors.New("missing required argument 'Sku'")
	}
	if args == nil {
		args = &CapacityDetailsArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:powerbidedicated/v20171001:CapacityDetails"),
		},
	})
	opts = append(opts, aliases)
	var resource CapacityDetails
	err := ctx.RegisterResource("azure-nextgen:powerbidedicated/latest:CapacityDetails", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCapacityDetails gets an existing CapacityDetails resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCapacityDetails(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CapacityDetailsState, opts ...pulumi.ResourceOption) (*CapacityDetails, error) {
	var resource CapacityDetails
	err := ctx.ReadResource("azure-nextgen:powerbidedicated/latest:CapacityDetails", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CapacityDetails resources.
type capacityDetailsState struct {
	// A collection of Dedicated capacity administrators
	Administration *DedicatedCapacityAdministratorsResponse `pulumi:"administration"`
	// Location of the PowerBI Dedicated resource.
	Location *string `pulumi:"location"`
	// The name of the PowerBI Dedicated resource.
	Name *string `pulumi:"name"`
	// The current deployment state of PowerBI Dedicated resource. The provisioningState is to indicate states for resource provisioning.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The SKU of the PowerBI Dedicated resource.
	Sku *ResourceSkuResponse `pulumi:"sku"`
	// The current state of PowerBI Dedicated resource. The state is to indicate more states outside of resource provisioning.
	State *string `pulumi:"state"`
	// Key-value pairs of additional resource provisioning properties.
	Tags map[string]string `pulumi:"tags"`
	// The type of the PowerBI Dedicated resource.
	Type *string `pulumi:"type"`
}

type CapacityDetailsState struct {
	// A collection of Dedicated capacity administrators
	Administration DedicatedCapacityAdministratorsResponsePtrInput
	// Location of the PowerBI Dedicated resource.
	Location pulumi.StringPtrInput
	// The name of the PowerBI Dedicated resource.
	Name pulumi.StringPtrInput
	// The current deployment state of PowerBI Dedicated resource. The provisioningState is to indicate states for resource provisioning.
	ProvisioningState pulumi.StringPtrInput
	// The SKU of the PowerBI Dedicated resource.
	Sku ResourceSkuResponsePtrInput
	// The current state of PowerBI Dedicated resource. The state is to indicate more states outside of resource provisioning.
	State pulumi.StringPtrInput
	// Key-value pairs of additional resource provisioning properties.
	Tags pulumi.StringMapInput
	// The type of the PowerBI Dedicated resource.
	Type pulumi.StringPtrInput
}

func (CapacityDetailsState) ElementType() reflect.Type {
	return reflect.TypeOf((*capacityDetailsState)(nil)).Elem()
}

type capacityDetailsArgs struct {
	// A collection of Dedicated capacity administrators
	Administration *DedicatedCapacityAdministrators `pulumi:"administration"`
	// The name of the Dedicated capacity. It must be a minimum of 3 characters, and a maximum of 63.
	DedicatedCapacityName string `pulumi:"dedicatedCapacityName"`
	// Location of the PowerBI Dedicated resource.
	Location string `pulumi:"location"`
	// The name of the Azure Resource group of which a given PowerBIDedicated capacity is part. This name must be at least 1 character in length, and no more than 90.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The SKU of the PowerBI Dedicated resource.
	Sku ResourceSku `pulumi:"sku"`
	// Key-value pairs of additional resource provisioning properties.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a CapacityDetails resource.
type CapacityDetailsArgs struct {
	// A collection of Dedicated capacity administrators
	Administration DedicatedCapacityAdministratorsPtrInput
	// The name of the Dedicated capacity. It must be a minimum of 3 characters, and a maximum of 63.
	DedicatedCapacityName pulumi.StringInput
	// Location of the PowerBI Dedicated resource.
	Location pulumi.StringInput
	// The name of the Azure Resource group of which a given PowerBIDedicated capacity is part. This name must be at least 1 character in length, and no more than 90.
	ResourceGroupName pulumi.StringInput
	// The SKU of the PowerBI Dedicated resource.
	Sku ResourceSkuInput
	// Key-value pairs of additional resource provisioning properties.
	Tags pulumi.StringMapInput
}

func (CapacityDetailsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*capacityDetailsArgs)(nil)).Elem()
}