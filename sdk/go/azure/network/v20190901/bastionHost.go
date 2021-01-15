// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190901

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Bastion Host resource.
type BastionHost struct {
	pulumi.CustomResourceState

	// FQDN for the endpoint on which bastion host is accessible.
	DnsName pulumi.StringPtrOutput `pulumi:"dnsName"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// IP configuration of the Bastion Host resource.
	IpConfigurations BastionHostIPConfigurationResponseArrayOutput `pulumi:"ipConfigurations"`
	// Resource location.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The provisioning state of the bastion host resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewBastionHost registers a new resource with the given unique name, arguments, and options.
func NewBastionHost(ctx *pulumi.Context,
	name string, args *BastionHostArgs, opts ...pulumi.ResourceOption) (*BastionHost, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.BastionHostName == nil {
		return nil, errors.New("invalid value for required argument 'BastionHostName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:BastionHost"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190401:BastionHost"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190601:BastionHost"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190701:BastionHost"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190801:BastionHost"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191101:BastionHost"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191201:BastionHost"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200301:BastionHost"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:BastionHost"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:BastionHost"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200601:BastionHost"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:BastionHost"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200801:BastionHost"),
		},
	})
	opts = append(opts, aliases)
	var resource BastionHost
	err := ctx.RegisterResource("azure-nextgen:network/v20190901:BastionHost", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBastionHost gets an existing BastionHost resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBastionHost(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BastionHostState, opts ...pulumi.ResourceOption) (*BastionHost, error) {
	var resource BastionHost
	err := ctx.ReadResource("azure-nextgen:network/v20190901:BastionHost", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering BastionHost resources.
type bastionHostState struct {
	// FQDN for the endpoint on which bastion host is accessible.
	DnsName *string `pulumi:"dnsName"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// IP configuration of the Bastion Host resource.
	IpConfigurations []BastionHostIPConfigurationResponse `pulumi:"ipConfigurations"`
	// Resource location.
	Location *string `pulumi:"location"`
	// Resource name.
	Name *string `pulumi:"name"`
	// The provisioning state of the bastion host resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type BastionHostState struct {
	// FQDN for the endpoint on which bastion host is accessible.
	DnsName pulumi.StringPtrInput
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// IP configuration of the Bastion Host resource.
	IpConfigurations BastionHostIPConfigurationResponseArrayInput
	// Resource location.
	Location pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// The provisioning state of the bastion host resource.
	ProvisioningState pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (BastionHostState) ElementType() reflect.Type {
	return reflect.TypeOf((*bastionHostState)(nil)).Elem()
}

type bastionHostArgs struct {
	// The name of the Bastion Host.
	BastionHostName string `pulumi:"bastionHostName"`
	// FQDN for the endpoint on which bastion host is accessible.
	DnsName *string `pulumi:"dnsName"`
	// Resource ID.
	Id *string `pulumi:"id"`
	// IP configuration of the Bastion Host resource.
	IpConfigurations []BastionHostIPConfiguration `pulumi:"ipConfigurations"`
	// Resource location.
	Location *string `pulumi:"location"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a BastionHost resource.
type BastionHostArgs struct {
	// The name of the Bastion Host.
	BastionHostName pulumi.StringInput
	// FQDN for the endpoint on which bastion host is accessible.
	DnsName pulumi.StringPtrInput
	// Resource ID.
	Id pulumi.StringPtrInput
	// IP configuration of the Bastion Host resource.
	IpConfigurations BastionHostIPConfigurationArrayInput
	// Resource location.
	Location pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
}

func (BastionHostArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*bastionHostArgs)(nil)).Elem()
}

type BastionHostInput interface {
	pulumi.Input

	ToBastionHostOutput() BastionHostOutput
	ToBastionHostOutputWithContext(ctx context.Context) BastionHostOutput
}

func (*BastionHost) ElementType() reflect.Type {
	return reflect.TypeOf((*BastionHost)(nil))
}

func (i *BastionHost) ToBastionHostOutput() BastionHostOutput {
	return i.ToBastionHostOutputWithContext(context.Background())
}

func (i *BastionHost) ToBastionHostOutputWithContext(ctx context.Context) BastionHostOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BastionHostOutput)
}

type BastionHostOutput struct {
	*pulumi.OutputState
}

func (BastionHostOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*BastionHost)(nil))
}

func (o BastionHostOutput) ToBastionHostOutput() BastionHostOutput {
	return o
}

func (o BastionHostOutput) ToBastionHostOutputWithContext(ctx context.Context) BastionHostOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(BastionHostOutput{})
}
