// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20201020preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// HealthBot resource definition
type Getbot struct {
	pulumi.CustomResourceState

	// The geo-location where the resource lives
	Location pulumi.StringOutput `pulumi:"location"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// The set of properties specific to healthcare bot resource.
	Properties HealthBotPropertiesResponseOutput `pulumi:"properties"`
	// SKU of the HealthBot.
	Sku SkuResponsePtrOutput `pulumi:"sku"`
	// Metadata pertaining to creation and last modification of the resource
	SystemData SystemDataResponseOutput `pulumi:"systemData"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the resource.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewGetbot registers a new resource with the given unique name, arguments, and options.
func NewGetbot(ctx *pulumi.Context,
	name string, args *GetbotArgs, opts ...pulumi.ResourceOption) (*Getbot, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.ResourceName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:healthbot/latest:getbot"),
		},
		{
			Type: pulumi.String("azure-nextgen:healthbot/v20201020:getbot"),
		},
		{
			Type: pulumi.String("azure-nextgen:healthbot/v20201208:getbot"),
		},
		{
			Type: pulumi.String("azure-nextgen:healthbot/v20201208preview:getbot"),
		},
	})
	opts = append(opts, aliases)
	var resource Getbot
	err := ctx.RegisterResource("azure-nextgen:healthbot/v20201020preview:getbot", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetGetbot gets an existing Getbot resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetGetbot(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *GetbotState, opts ...pulumi.ResourceOption) (*Getbot, error) {
	var resource Getbot
	err := ctx.ReadResource("azure-nextgen:healthbot/v20201020preview:getbot", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Getbot resources.
type getbotState struct {
	// The geo-location where the resource lives
	Location *string `pulumi:"location"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// The set of properties specific to healthcare bot resource.
	Properties *HealthBotPropertiesResponse `pulumi:"properties"`
	// SKU of the HealthBot.
	Sku *SkuResponse `pulumi:"sku"`
	// Metadata pertaining to creation and last modification of the resource
	SystemData *SystemDataResponse `pulumi:"systemData"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource.
	Type *string `pulumi:"type"`
}

type GetbotState struct {
	// The geo-location where the resource lives
	Location pulumi.StringPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// The set of properties specific to healthcare bot resource.
	Properties HealthBotPropertiesResponsePtrInput
	// SKU of the HealthBot.
	Sku SkuResponsePtrInput
	// Metadata pertaining to creation and last modification of the resource
	SystemData SystemDataResponsePtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The type of the resource.
	Type pulumi.StringPtrInput
}

func (GetbotState) ElementType() reflect.Type {
	return reflect.TypeOf((*getbotState)(nil)).Elem()
}

type getbotArgs struct {
	// The geo-location where the resource lives
	Location *string `pulumi:"location"`
	// The name of the Bot resource group in the user subscription.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the Bot resource.
	ResourceName string `pulumi:"resourceName"`
	// SKU of the HealthBot.
	Sku *Sku `pulumi:"sku"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a Getbot resource.
type GetbotArgs struct {
	// The geo-location where the resource lives
	Location pulumi.StringPtrInput
	// The name of the Bot resource group in the user subscription.
	ResourceGroupName pulumi.StringInput
	// The name of the Bot resource.
	ResourceName pulumi.StringInput
	// SKU of the HealthBot.
	Sku SkuPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
}

func (GetbotArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*getbotArgs)(nil)).Elem()
}

type GetbotInput interface {
	pulumi.Input

	ToGetbotOutput() GetbotOutput
	ToGetbotOutputWithContext(ctx context.Context) GetbotOutput
}

func (*Getbot) ElementType() reflect.Type {
	return reflect.TypeOf((*Getbot)(nil))
}

func (i *Getbot) ToGetbotOutput() GetbotOutput {
	return i.ToGetbotOutputWithContext(context.Background())
}

func (i *Getbot) ToGetbotOutputWithContext(ctx context.Context) GetbotOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetbotOutput)
}

type GetbotOutput struct {
	*pulumi.OutputState
}

func (GetbotOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Getbot)(nil))
}

func (o GetbotOutput) ToGetbotOutput() GetbotOutput {
	return o
}

func (o GetbotOutput) ToGetbotOutputWithContext(ctx context.Context) GetbotOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(GetbotOutput{})
}
