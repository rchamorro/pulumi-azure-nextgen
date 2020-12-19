// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180901preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The resource definition of this association.
type Association struct {
	pulumi.CustomResourceState

	// The association name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The provisioning state of the association.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The REST resource instance of the target resource for this association.
	TargetResourceId pulumi.StringPtrOutput `pulumi:"targetResourceId"`
	// The association type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewAssociation registers a new resource with the given unique name, arguments, and options.
func NewAssociation(ctx *pulumi.Context,
	name string, args *AssociationArgs, opts ...pulumi.ResourceOption) (*Association, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AssociationName == nil {
		return nil, errors.New("invalid value for required argument 'AssociationName'")
	}
	if args.Scope == nil {
		return nil, errors.New("invalid value for required argument 'Scope'")
	}
	var resource Association
	err := ctx.RegisterResource("azure-nextgen:customproviders/v20180901preview:Association", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAssociation gets an existing Association resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAssociation(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AssociationState, opts ...pulumi.ResourceOption) (*Association, error) {
	var resource Association
	err := ctx.ReadResource("azure-nextgen:customproviders/v20180901preview:Association", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Association resources.
type associationState struct {
	// The association name.
	Name *string `pulumi:"name"`
	// The provisioning state of the association.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The REST resource instance of the target resource for this association.
	TargetResourceId *string `pulumi:"targetResourceId"`
	// The association type.
	Type *string `pulumi:"type"`
}

type AssociationState struct {
	// The association name.
	Name pulumi.StringPtrInput
	// The provisioning state of the association.
	ProvisioningState pulumi.StringPtrInput
	// The REST resource instance of the target resource for this association.
	TargetResourceId pulumi.StringPtrInput
	// The association type.
	Type pulumi.StringPtrInput
}

func (AssociationState) ElementType() reflect.Type {
	return reflect.TypeOf((*associationState)(nil)).Elem()
}

type associationArgs struct {
	// The name of the association.
	AssociationName string `pulumi:"associationName"`
	// The scope of the association. The scope can be any valid REST resource instance. For example, use '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/providers/Microsoft.Compute/virtualMachines/{vm-name}' for a virtual machine resource.
	Scope string `pulumi:"scope"`
	// The REST resource instance of the target resource for this association.
	TargetResourceId *string `pulumi:"targetResourceId"`
}

// The set of arguments for constructing a Association resource.
type AssociationArgs struct {
	// The name of the association.
	AssociationName pulumi.StringInput
	// The scope of the association. The scope can be any valid REST resource instance. For example, use '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/providers/Microsoft.Compute/virtualMachines/{vm-name}' for a virtual machine resource.
	Scope pulumi.StringInput
	// The REST resource instance of the target resource for this association.
	TargetResourceId pulumi.StringPtrInput
}

func (AssociationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*associationArgs)(nil)).Elem()
}

type AssociationInput interface {
	pulumi.Input

	ToAssociationOutput() AssociationOutput
	ToAssociationOutputWithContext(ctx context.Context) AssociationOutput
}

func (*Association) ElementType() reflect.Type {
	return reflect.TypeOf((*Association)(nil))
}

func (i *Association) ToAssociationOutput() AssociationOutput {
	return i.ToAssociationOutputWithContext(context.Background())
}

func (i *Association) ToAssociationOutputWithContext(ctx context.Context) AssociationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AssociationOutput)
}

type AssociationOutput struct {
	*pulumi.OutputState
}

func (AssociationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Association)(nil))
}

func (o AssociationOutput) ToAssociationOutput() AssociationOutput {
	return o
}

func (o AssociationOutput) ToAssociationOutputWithContext(ctx context.Context) AssociationOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(AssociationOutput{})
}
