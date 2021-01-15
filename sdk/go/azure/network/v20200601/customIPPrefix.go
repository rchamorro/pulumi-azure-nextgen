// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200601

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Custom IP prefix resource.
type CustomIPPrefix struct {
	pulumi.CustomResourceState

	// The prefix range in CIDR notation. Should include the start address and the prefix length.
	Cidr pulumi.StringPtrOutput `pulumi:"cidr"`
	// The commissioned state of the Custom IP Prefix.
	CommissionedState pulumi.StringPtrOutput `pulumi:"commissionedState"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// Resource location.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The provisioning state of the custom IP prefix resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The list of all referenced PublicIpPrefixes.
	PublicIpPrefixes SubResourceResponseArrayOutput `pulumi:"publicIpPrefixes"`
	// The resource GUID property of the custom IP prefix resource.
	ResourceGuid pulumi.StringOutput `pulumi:"resourceGuid"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
	// A list of availability zones denoting the IP allocated for the resource needs to come from.
	Zones pulumi.StringArrayOutput `pulumi:"zones"`
}

// NewCustomIPPrefix registers a new resource with the given unique name, arguments, and options.
func NewCustomIPPrefix(ctx *pulumi.Context,
	name string, args *CustomIPPrefixArgs, opts ...pulumi.ResourceOption) (*CustomIPPrefix, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.CustomIpPrefixName == nil {
		return nil, errors.New("invalid value for required argument 'CustomIpPrefixName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:CustomIPPrefix"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:CustomIPPrefix"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200801:CustomIPPrefix"),
		},
	})
	opts = append(opts, aliases)
	var resource CustomIPPrefix
	err := ctx.RegisterResource("azure-nextgen:network/v20200601:CustomIPPrefix", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCustomIPPrefix gets an existing CustomIPPrefix resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCustomIPPrefix(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CustomIPPrefixState, opts ...pulumi.ResourceOption) (*CustomIPPrefix, error) {
	var resource CustomIPPrefix
	err := ctx.ReadResource("azure-nextgen:network/v20200601:CustomIPPrefix", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CustomIPPrefix resources.
type customIPPrefixState struct {
	// The prefix range in CIDR notation. Should include the start address and the prefix length.
	Cidr *string `pulumi:"cidr"`
	// The commissioned state of the Custom IP Prefix.
	CommissionedState *string `pulumi:"commissionedState"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// Resource location.
	Location *string `pulumi:"location"`
	// Resource name.
	Name *string `pulumi:"name"`
	// The provisioning state of the custom IP prefix resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The list of all referenced PublicIpPrefixes.
	PublicIpPrefixes []SubResourceResponse `pulumi:"publicIpPrefixes"`
	// The resource GUID property of the custom IP prefix resource.
	ResourceGuid *string `pulumi:"resourceGuid"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type *string `pulumi:"type"`
	// A list of availability zones denoting the IP allocated for the resource needs to come from.
	Zones []string `pulumi:"zones"`
}

type CustomIPPrefixState struct {
	// The prefix range in CIDR notation. Should include the start address and the prefix length.
	Cidr pulumi.StringPtrInput
	// The commissioned state of the Custom IP Prefix.
	CommissionedState pulumi.StringPtrInput
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// The provisioning state of the custom IP prefix resource.
	ProvisioningState pulumi.StringPtrInput
	// The list of all referenced PublicIpPrefixes.
	PublicIpPrefixes SubResourceResponseArrayInput
	// The resource GUID property of the custom IP prefix resource.
	ResourceGuid pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Resource type.
	Type pulumi.StringPtrInput
	// A list of availability zones denoting the IP allocated for the resource needs to come from.
	Zones pulumi.StringArrayInput
}

func (CustomIPPrefixState) ElementType() reflect.Type {
	return reflect.TypeOf((*customIPPrefixState)(nil)).Elem()
}

type customIPPrefixArgs struct {
	// The prefix range in CIDR notation. Should include the start address and the prefix length.
	Cidr *string `pulumi:"cidr"`
	// The commissioned state of the Custom IP Prefix.
	CommissionedState *string `pulumi:"commissionedState"`
	// The name of the custom IP prefix.
	CustomIpPrefixName string `pulumi:"customIpPrefixName"`
	// Resource ID.
	Id *string `pulumi:"id"`
	// Resource location.
	Location *string `pulumi:"location"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// A list of availability zones denoting the IP allocated for the resource needs to come from.
	Zones []string `pulumi:"zones"`
}

// The set of arguments for constructing a CustomIPPrefix resource.
type CustomIPPrefixArgs struct {
	// The prefix range in CIDR notation. Should include the start address and the prefix length.
	Cidr pulumi.StringPtrInput
	// The commissioned state of the Custom IP Prefix.
	CommissionedState pulumi.StringPtrInput
	// The name of the custom IP prefix.
	CustomIpPrefixName pulumi.StringInput
	// Resource ID.
	Id pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// A list of availability zones denoting the IP allocated for the resource needs to come from.
	Zones pulumi.StringArrayInput
}

func (CustomIPPrefixArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*customIPPrefixArgs)(nil)).Elem()
}

type CustomIPPrefixInput interface {
	pulumi.Input

	ToCustomIPPrefixOutput() CustomIPPrefixOutput
	ToCustomIPPrefixOutputWithContext(ctx context.Context) CustomIPPrefixOutput
}

func (*CustomIPPrefix) ElementType() reflect.Type {
	return reflect.TypeOf((*CustomIPPrefix)(nil))
}

func (i *CustomIPPrefix) ToCustomIPPrefixOutput() CustomIPPrefixOutput {
	return i.ToCustomIPPrefixOutputWithContext(context.Background())
}

func (i *CustomIPPrefix) ToCustomIPPrefixOutputWithContext(ctx context.Context) CustomIPPrefixOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CustomIPPrefixOutput)
}

type CustomIPPrefixOutput struct {
	*pulumi.OutputState
}

func (CustomIPPrefixOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*CustomIPPrefix)(nil))
}

func (o CustomIPPrefixOutput) ToCustomIPPrefixOutput() CustomIPPrefixOutput {
	return o
}

func (o CustomIPPrefixOutput) ToCustomIPPrefixOutputWithContext(ctx context.Context) CustomIPPrefixOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(CustomIPPrefixOutput{})
}
