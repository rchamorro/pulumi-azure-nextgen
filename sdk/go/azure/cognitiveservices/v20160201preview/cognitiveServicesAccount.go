// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20160201preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Cognitive Services Account is an Azure resource representing the provisioned account, its type, location and SKU.
type CognitiveServicesAccount struct {
	pulumi.CustomResourceState

	// Endpoint of the created account
	Endpoint pulumi.StringPtrOutput `pulumi:"endpoint"`
	// Entity Tag
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// Type of cognitive service account.
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// The location of the resource
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// The name of the created account
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// Gets the status of the cognitive services account at the time the operation was called.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The SKU of the cognitive services account.
	Sku SkuResponsePtrOutput `pulumi:"sku"`
	// Gets or sets a list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type
	Type pulumi.StringPtrOutput `pulumi:"type"`
}

// NewCognitiveServicesAccount registers a new resource with the given unique name, arguments, and options.
func NewCognitiveServicesAccount(ctx *pulumi.Context,
	name string, args *CognitiveServicesAccountArgs, opts ...pulumi.ResourceOption) (*CognitiveServicesAccount, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AccountName == nil {
		return nil, errors.New("invalid value for required argument 'AccountName'")
	}
	if args.Kind == nil {
		return nil, errors.New("invalid value for required argument 'Kind'")
	}
	if args.Location == nil {
		return nil, errors.New("invalid value for required argument 'Location'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.Sku == nil {
		return nil, errors.New("invalid value for required argument 'Sku'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:cognitiveservices/latest:CognitiveServicesAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:cognitiveservices/v20170418:CognitiveServicesAccount"),
		},
	})
	opts = append(opts, aliases)
	var resource CognitiveServicesAccount
	err := ctx.RegisterResource("azure-nextgen:cognitiveservices/v20160201preview:CognitiveServicesAccount", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCognitiveServicesAccount gets an existing CognitiveServicesAccount resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCognitiveServicesAccount(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CognitiveServicesAccountState, opts ...pulumi.ResourceOption) (*CognitiveServicesAccount, error) {
	var resource CognitiveServicesAccount
	err := ctx.ReadResource("azure-nextgen:cognitiveservices/v20160201preview:CognitiveServicesAccount", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CognitiveServicesAccount resources.
type cognitiveServicesAccountState struct {
	// Endpoint of the created account
	Endpoint *string `pulumi:"endpoint"`
	// Entity Tag
	Etag *string `pulumi:"etag"`
	// Type of cognitive service account.
	Kind *string `pulumi:"kind"`
	// The location of the resource
	Location *string `pulumi:"location"`
	// The name of the created account
	Name *string `pulumi:"name"`
	// Gets the status of the cognitive services account at the time the operation was called.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The SKU of the cognitive services account.
	Sku *SkuResponse `pulumi:"sku"`
	// Gets or sets a list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters.
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
}

type CognitiveServicesAccountState struct {
	// Endpoint of the created account
	Endpoint pulumi.StringPtrInput
	// Entity Tag
	Etag pulumi.StringPtrInput
	// Type of cognitive service account.
	Kind pulumi.StringPtrInput
	// The location of the resource
	Location pulumi.StringPtrInput
	// The name of the created account
	Name pulumi.StringPtrInput
	// Gets the status of the cognitive services account at the time the operation was called.
	ProvisioningState pulumi.StringPtrInput
	// The SKU of the cognitive services account.
	Sku SkuResponsePtrInput
	// Gets or sets a list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters.
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
}

func (CognitiveServicesAccountState) ElementType() reflect.Type {
	return reflect.TypeOf((*cognitiveServicesAccountState)(nil)).Elem()
}

type cognitiveServicesAccountArgs struct {
	// The name of the cognitive services account within the specified resource group. Cognitive Services account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
	AccountName string `pulumi:"accountName"`
	// Required. Indicates the type of cognitive service account.
	Kind string `pulumi:"kind"`
	// Required. Gets or sets the location of the resource. This will be one of the supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The geo region of a resource cannot be changed once it is created, but if an identical geo region is specified on update the request will succeed.
	Location string `pulumi:"location"`
	// The name of the resource group within the user's subscription.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The SKU of the cognitive services account.
	Sku Sku `pulumi:"sku"`
	// Gets or sets a list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a CognitiveServicesAccount resource.
type CognitiveServicesAccountArgs struct {
	// The name of the cognitive services account within the specified resource group. Cognitive Services account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
	AccountName pulumi.StringInput
	// Required. Indicates the type of cognitive service account.
	Kind pulumi.StringInput
	// Required. Gets or sets the location of the resource. This will be one of the supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The geo region of a resource cannot be changed once it is created, but if an identical geo region is specified on update the request will succeed.
	Location pulumi.StringInput
	// The name of the resource group within the user's subscription.
	ResourceGroupName pulumi.StringInput
	// The SKU of the cognitive services account.
	Sku SkuInput
	// Gets or sets a list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters.
	Tags pulumi.StringMapInput
}

func (CognitiveServicesAccountArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*cognitiveServicesAccountArgs)(nil)).Elem()
}

type CognitiveServicesAccountInput interface {
	pulumi.Input

	ToCognitiveServicesAccountOutput() CognitiveServicesAccountOutput
	ToCognitiveServicesAccountOutputWithContext(ctx context.Context) CognitiveServicesAccountOutput
}

func (*CognitiveServicesAccount) ElementType() reflect.Type {
	return reflect.TypeOf((*CognitiveServicesAccount)(nil))
}

func (i *CognitiveServicesAccount) ToCognitiveServicesAccountOutput() CognitiveServicesAccountOutput {
	return i.ToCognitiveServicesAccountOutputWithContext(context.Background())
}

func (i *CognitiveServicesAccount) ToCognitiveServicesAccountOutputWithContext(ctx context.Context) CognitiveServicesAccountOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CognitiveServicesAccountOutput)
}

type CognitiveServicesAccountOutput struct {
	*pulumi.OutputState
}

func (CognitiveServicesAccountOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*CognitiveServicesAccount)(nil))
}

func (o CognitiveServicesAccountOutput) ToCognitiveServicesAccountOutput() CognitiveServicesAccountOutput {
	return o
}

func (o CognitiveServicesAccountOutput) ToCognitiveServicesAccountOutputWithContext(ctx context.Context) CognitiveServicesAccountOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(CognitiveServicesAccountOutput{})
}
