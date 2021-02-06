// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20170821preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The description of the provisioning service.
type IotDpsResource struct {
	pulumi.CustomResourceState

	// The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal ETag convention.
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// The resource location.
	Location pulumi.StringOutput `pulumi:"location"`
	// The resource name.
	Name       pulumi.StringOutput                       `pulumi:"name"`
	Properties IotDpsPropertiesDescriptionResponseOutput `pulumi:"properties"`
	// List of possible provisioning service SKUs.
	Sku IotDpsSkuInfoResponseOutput `pulumi:"sku"`
	// The resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewIotDpsResource registers a new resource with the given unique name, arguments, and options.
func NewIotDpsResource(ctx *pulumi.Context,
	name string, args *IotDpsResourceArgs, opts ...pulumi.ResourceOption) (*IotDpsResource, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Properties == nil {
		return nil, errors.New("invalid value for required argument 'Properties'")
	}
	if args.ProvisioningServiceName == nil {
		return nil, errors.New("invalid value for required argument 'ProvisioningServiceName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.Sku == nil {
		return nil, errors.New("invalid value for required argument 'Sku'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:devices/latest:IotDpsResource"),
		},
		{
			Type: pulumi.String("azure-nextgen:devices/v20171115:IotDpsResource"),
		},
		{
			Type: pulumi.String("azure-nextgen:devices/v20180122:IotDpsResource"),
		},
		{
			Type: pulumi.String("azure-nextgen:devices/v20200101:IotDpsResource"),
		},
		{
			Type: pulumi.String("azure-nextgen:devices/v20200301:IotDpsResource"),
		},
		{
			Type: pulumi.String("azure-nextgen:devices/v20200901preview:IotDpsResource"),
		},
	})
	opts = append(opts, aliases)
	var resource IotDpsResource
	err := ctx.RegisterResource("azure-nextgen:devices/v20170821preview:IotDpsResource", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetIotDpsResource gets an existing IotDpsResource resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIotDpsResource(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *IotDpsResourceState, opts ...pulumi.ResourceOption) (*IotDpsResource, error) {
	var resource IotDpsResource
	err := ctx.ReadResource("azure-nextgen:devices/v20170821preview:IotDpsResource", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering IotDpsResource resources.
type iotDpsResourceState struct {
	// The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal ETag convention.
	Etag *string `pulumi:"etag"`
	// The resource location.
	Location *string `pulumi:"location"`
	// The resource name.
	Name       *string                              `pulumi:"name"`
	Properties *IotDpsPropertiesDescriptionResponse `pulumi:"properties"`
	// List of possible provisioning service SKUs.
	Sku *IotDpsSkuInfoResponse `pulumi:"sku"`
	// The resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The resource type.
	Type *string `pulumi:"type"`
}

type IotDpsResourceState struct {
	// The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal ETag convention.
	Etag pulumi.StringPtrInput
	// The resource location.
	Location pulumi.StringPtrInput
	// The resource name.
	Name       pulumi.StringPtrInput
	Properties IotDpsPropertiesDescriptionResponsePtrInput
	// List of possible provisioning service SKUs.
	Sku IotDpsSkuInfoResponsePtrInput
	// The resource tags.
	Tags pulumi.StringMapInput
	// The resource type.
	Type pulumi.StringPtrInput
}

func (IotDpsResourceState) ElementType() reflect.Type {
	return reflect.TypeOf((*iotDpsResourceState)(nil)).Elem()
}

type iotDpsResourceArgs struct {
	// The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal ETag convention.
	Etag *string `pulumi:"etag"`
	// The resource location.
	Location   *string                     `pulumi:"location"`
	Properties IotDpsPropertiesDescription `pulumi:"properties"`
	// Name of provisioning service to create or update.
	ProvisioningServiceName string `pulumi:"provisioningServiceName"`
	// Resource group identifier.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// List of possible provisioning service SKUs.
	Sku IotDpsSkuInfo `pulumi:"sku"`
	// The resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a IotDpsResource resource.
type IotDpsResourceArgs struct {
	// The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal ETag convention.
	Etag pulumi.StringPtrInput
	// The resource location.
	Location   pulumi.StringPtrInput
	Properties IotDpsPropertiesDescriptionInput
	// Name of provisioning service to create or update.
	ProvisioningServiceName pulumi.StringInput
	// Resource group identifier.
	ResourceGroupName pulumi.StringInput
	// List of possible provisioning service SKUs.
	Sku IotDpsSkuInfoInput
	// The resource tags.
	Tags pulumi.StringMapInput
}

func (IotDpsResourceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*iotDpsResourceArgs)(nil)).Elem()
}

type IotDpsResourceInput interface {
	pulumi.Input

	ToIotDpsResourceOutput() IotDpsResourceOutput
	ToIotDpsResourceOutputWithContext(ctx context.Context) IotDpsResourceOutput
}

func (*IotDpsResource) ElementType() reflect.Type {
	return reflect.TypeOf((*IotDpsResource)(nil))
}

func (i *IotDpsResource) ToIotDpsResourceOutput() IotDpsResourceOutput {
	return i.ToIotDpsResourceOutputWithContext(context.Background())
}

func (i *IotDpsResource) ToIotDpsResourceOutputWithContext(ctx context.Context) IotDpsResourceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IotDpsResourceOutput)
}

type IotDpsResourceOutput struct {
	*pulumi.OutputState
}

func (IotDpsResourceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*IotDpsResource)(nil))
}

func (o IotDpsResourceOutput) ToIotDpsResourceOutput() IotDpsResourceOutput {
	return o
}

func (o IotDpsResourceOutput) ToIotDpsResourceOutputWithContext(ctx context.Context) IotDpsResourceOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(IotDpsResourceOutput{})
}
