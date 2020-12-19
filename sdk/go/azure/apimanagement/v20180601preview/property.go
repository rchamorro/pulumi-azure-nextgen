// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180601preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Property details.
type Property struct {
	pulumi.CustomResourceState

	// Unique name of Property. It may contain only letters, digits, period, dash, and underscore characters.
	DisplayName pulumi.StringOutput `pulumi:"displayName"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Determines whether the value is a secret and should be encrypted or not. Default value is false.
	Secret pulumi.BoolPtrOutput `pulumi:"secret"`
	// Optional tags that when provided can be used to filter the property list.
	Tags pulumi.StringArrayOutput `pulumi:"tags"`
	// Resource type for API Management resource.
	Type pulumi.StringOutput `pulumi:"type"`
	// Value of the property. Can contain policy expressions. It may not be empty or consist only of whitespace.
	Value pulumi.StringOutput `pulumi:"value"`
}

// NewProperty registers a new resource with the given unique name, arguments, and options.
func NewProperty(ctx *pulumi.Context,
	name string, args *PropertyArgs, opts ...pulumi.ResourceOption) (*Property, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DisplayName == nil {
		return nil, errors.New("invalid value for required argument 'DisplayName'")
	}
	if args.PropId == nil {
		return nil, errors.New("invalid value for required argument 'PropId'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.ServiceName == nil {
		return nil, errors.New("invalid value for required argument 'ServiceName'")
	}
	if args.Value == nil {
		return nil, errors.New("invalid value for required argument 'Value'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:apimanagement/latest:Property"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20160707:Property"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20161010:Property"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20170301:Property"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20180101:Property"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20190101:Property"),
		},
	})
	opts = append(opts, aliases)
	var resource Property
	err := ctx.RegisterResource("azure-nextgen:apimanagement/v20180601preview:Property", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetProperty gets an existing Property resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetProperty(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PropertyState, opts ...pulumi.ResourceOption) (*Property, error) {
	var resource Property
	err := ctx.ReadResource("azure-nextgen:apimanagement/v20180601preview:Property", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Property resources.
type propertyState struct {
	// Unique name of Property. It may contain only letters, digits, period, dash, and underscore characters.
	DisplayName *string `pulumi:"displayName"`
	// Resource name.
	Name *string `pulumi:"name"`
	// Determines whether the value is a secret and should be encrypted or not. Default value is false.
	Secret *bool `pulumi:"secret"`
	// Optional tags that when provided can be used to filter the property list.
	Tags []string `pulumi:"tags"`
	// Resource type for API Management resource.
	Type *string `pulumi:"type"`
	// Value of the property. Can contain policy expressions. It may not be empty or consist only of whitespace.
	Value *string `pulumi:"value"`
}

type PropertyState struct {
	// Unique name of Property. It may contain only letters, digits, period, dash, and underscore characters.
	DisplayName pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// Determines whether the value is a secret and should be encrypted or not. Default value is false.
	Secret pulumi.BoolPtrInput
	// Optional tags that when provided can be used to filter the property list.
	Tags pulumi.StringArrayInput
	// Resource type for API Management resource.
	Type pulumi.StringPtrInput
	// Value of the property. Can contain policy expressions. It may not be empty or consist only of whitespace.
	Value pulumi.StringPtrInput
}

func (PropertyState) ElementType() reflect.Type {
	return reflect.TypeOf((*propertyState)(nil)).Elem()
}

type propertyArgs struct {
	// Unique name of Property. It may contain only letters, digits, period, dash, and underscore characters.
	DisplayName string `pulumi:"displayName"`
	// Identifier of the property.
	PropId string `pulumi:"propId"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Determines whether the value is a secret and should be encrypted or not. Default value is false.
	Secret *bool `pulumi:"secret"`
	// The name of the API Management service.
	ServiceName string `pulumi:"serviceName"`
	// Optional tags that when provided can be used to filter the property list.
	Tags []string `pulumi:"tags"`
	// Value of the property. Can contain policy expressions. It may not be empty or consist only of whitespace.
	Value string `pulumi:"value"`
}

// The set of arguments for constructing a Property resource.
type PropertyArgs struct {
	// Unique name of Property. It may contain only letters, digits, period, dash, and underscore characters.
	DisplayName pulumi.StringInput
	// Identifier of the property.
	PropId pulumi.StringInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// Determines whether the value is a secret and should be encrypted or not. Default value is false.
	Secret pulumi.BoolPtrInput
	// The name of the API Management service.
	ServiceName pulumi.StringInput
	// Optional tags that when provided can be used to filter the property list.
	Tags pulumi.StringArrayInput
	// Value of the property. Can contain policy expressions. It may not be empty or consist only of whitespace.
	Value pulumi.StringInput
}

func (PropertyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*propertyArgs)(nil)).Elem()
}

type PropertyInput interface {
	pulumi.Input

	ToPropertyOutput() PropertyOutput
	ToPropertyOutputWithContext(ctx context.Context) PropertyOutput
}

func (*Property) ElementType() reflect.Type {
	return reflect.TypeOf((*Property)(nil))
}

func (i *Property) ToPropertyOutput() PropertyOutput {
	return i.ToPropertyOutputWithContext(context.Background())
}

func (i *Property) ToPropertyOutputWithContext(ctx context.Context) PropertyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PropertyOutput)
}

type PropertyOutput struct {
	*pulumi.OutputState
}

func (PropertyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Property)(nil))
}

func (o PropertyOutput) ToPropertyOutput() PropertyOutput {
	return o
}

func (o PropertyOutput) ToPropertyOutputWithContext(ctx context.Context) PropertyOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(PropertyOutput{})
}
