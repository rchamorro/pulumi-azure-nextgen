// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200601

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Premier add-on.
type WebAppPremierAddOn struct {
	pulumi.CustomResourceState

	// Kind of resource.
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Resource Location.
	Location pulumi.StringOutput `pulumi:"location"`
	// Premier add on Marketplace offer.
	MarketplaceOffer pulumi.StringPtrOutput `pulumi:"marketplaceOffer"`
	// Premier add on Marketplace publisher.
	MarketplacePublisher pulumi.StringPtrOutput `pulumi:"marketplacePublisher"`
	// Resource Name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Premier add on Product.
	Product pulumi.StringPtrOutput `pulumi:"product"`
	// Premier add on SKU.
	Sku pulumi.StringPtrOutput `pulumi:"sku"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
	// Premier add on Vendor.
	Vendor pulumi.StringPtrOutput `pulumi:"vendor"`
}

// NewWebAppPremierAddOn registers a new resource with the given unique name, arguments, and options.
func NewWebAppPremierAddOn(ctx *pulumi.Context,
	name string, args *WebAppPremierAddOnArgs, opts ...pulumi.ResourceOption) (*WebAppPremierAddOn, error) {
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.Name == nil {
		return nil, errors.New("missing required argument 'Name'")
	}
	if args == nil || args.PremierAddOnName == nil {
		return nil, errors.New("missing required argument 'PremierAddOnName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &WebAppPremierAddOnArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:web/latest:WebAppPremierAddOn"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20150801:WebAppPremierAddOn"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20160801:WebAppPremierAddOn"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20180201:WebAppPremierAddOn"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20181101:WebAppPremierAddOn"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20190801:WebAppPremierAddOn"),
		},
	})
	opts = append(opts, aliases)
	var resource WebAppPremierAddOn
	err := ctx.RegisterResource("azure-nextgen:web/v20200601:WebAppPremierAddOn", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWebAppPremierAddOn gets an existing WebAppPremierAddOn resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWebAppPremierAddOn(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WebAppPremierAddOnState, opts ...pulumi.ResourceOption) (*WebAppPremierAddOn, error) {
	var resource WebAppPremierAddOn
	err := ctx.ReadResource("azure-nextgen:web/v20200601:WebAppPremierAddOn", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WebAppPremierAddOn resources.
type webAppPremierAddOnState struct {
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Resource Location.
	Location *string `pulumi:"location"`
	// Premier add on Marketplace offer.
	MarketplaceOffer *string `pulumi:"marketplaceOffer"`
	// Premier add on Marketplace publisher.
	MarketplacePublisher *string `pulumi:"marketplacePublisher"`
	// Resource Name.
	Name *string `pulumi:"name"`
	// Premier add on Product.
	Product *string `pulumi:"product"`
	// Premier add on SKU.
	Sku *string `pulumi:"sku"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type *string `pulumi:"type"`
	// Premier add on Vendor.
	Vendor *string `pulumi:"vendor"`
}

type WebAppPremierAddOnState struct {
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Resource Location.
	Location pulumi.StringPtrInput
	// Premier add on Marketplace offer.
	MarketplaceOffer pulumi.StringPtrInput
	// Premier add on Marketplace publisher.
	MarketplacePublisher pulumi.StringPtrInput
	// Resource Name.
	Name pulumi.StringPtrInput
	// Premier add on Product.
	Product pulumi.StringPtrInput
	// Premier add on SKU.
	Sku pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Resource type.
	Type pulumi.StringPtrInput
	// Premier add on Vendor.
	Vendor pulumi.StringPtrInput
}

func (WebAppPremierAddOnState) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppPremierAddOnState)(nil)).Elem()
}

type webAppPremierAddOnArgs struct {
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Resource Location.
	Location string `pulumi:"location"`
	// Premier add on Marketplace offer.
	MarketplaceOffer *string `pulumi:"marketplaceOffer"`
	// Premier add on Marketplace publisher.
	MarketplacePublisher *string `pulumi:"marketplacePublisher"`
	// Name of the app.
	Name string `pulumi:"name"`
	// Add-on name.
	PremierAddOnName string `pulumi:"premierAddOnName"`
	// Premier add on Product.
	Product *string `pulumi:"product"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Premier add on SKU.
	Sku *string `pulumi:"sku"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Premier add on Vendor.
	Vendor *string `pulumi:"vendor"`
}

// The set of arguments for constructing a WebAppPremierAddOn resource.
type WebAppPremierAddOnArgs struct {
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Resource Location.
	Location pulumi.StringInput
	// Premier add on Marketplace offer.
	MarketplaceOffer pulumi.StringPtrInput
	// Premier add on Marketplace publisher.
	MarketplacePublisher pulumi.StringPtrInput
	// Name of the app.
	Name pulumi.StringInput
	// Add-on name.
	PremierAddOnName pulumi.StringInput
	// Premier add on Product.
	Product pulumi.StringPtrInput
	// Name of the resource group to which the resource belongs.
	ResourceGroupName pulumi.StringInput
	// Premier add on SKU.
	Sku pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Premier add on Vendor.
	Vendor pulumi.StringPtrInput
}

func (WebAppPremierAddOnArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppPremierAddOnArgs)(nil)).Elem()
}

type WebAppPremierAddOnInput interface {
	pulumi.Input

	ToWebAppPremierAddOnOutput() WebAppPremierAddOnOutput
	ToWebAppPremierAddOnOutputWithContext(ctx context.Context) WebAppPremierAddOnOutput
}

func (WebAppPremierAddOn) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppPremierAddOn)(nil)).Elem()
}

func (i WebAppPremierAddOn) ToWebAppPremierAddOnOutput() WebAppPremierAddOnOutput {
	return i.ToWebAppPremierAddOnOutputWithContext(context.Background())
}

func (i WebAppPremierAddOn) ToWebAppPremierAddOnOutputWithContext(ctx context.Context) WebAppPremierAddOnOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppPremierAddOnOutput)
}

type WebAppPremierAddOnOutput struct {
	*pulumi.OutputState
}

func (WebAppPremierAddOnOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppPremierAddOnOutput)(nil)).Elem()
}

func (o WebAppPremierAddOnOutput) ToWebAppPremierAddOnOutput() WebAppPremierAddOnOutput {
	return o
}

func (o WebAppPremierAddOnOutput) ToWebAppPremierAddOnOutputWithContext(ctx context.Context) WebAppPremierAddOnOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(WebAppPremierAddOnOutput{})
}
