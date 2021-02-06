// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20181101preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A share data transfer object.
type Share struct {
	pulumi.CustomResourceState

	// Time at which the share was created.
	CreatedAt pulumi.StringOutput `pulumi:"createdAt"`
	// Share description.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Name of the azure resource
	Name pulumi.StringOutput `pulumi:"name"`
	// Gets or sets the provisioning state
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Share kind.
	ShareKind pulumi.StringPtrOutput `pulumi:"shareKind"`
	// Share terms.
	Terms pulumi.StringPtrOutput `pulumi:"terms"`
	// Type of the azure resource
	Type pulumi.StringOutput `pulumi:"type"`
	// Email of the user who created the resource
	UserEmail pulumi.StringOutput `pulumi:"userEmail"`
	// Name of the user who created the resource
	UserName pulumi.StringOutput `pulumi:"userName"`
}

// NewShare registers a new resource with the given unique name, arguments, and options.
func NewShare(ctx *pulumi.Context,
	name string, args *ShareArgs, opts ...pulumi.ResourceOption) (*Share, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AccountName == nil {
		return nil, errors.New("invalid value for required argument 'AccountName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.ShareName == nil {
		return nil, errors.New("invalid value for required argument 'ShareName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:datashare/latest:Share"),
		},
		{
			Type: pulumi.String("azure-nextgen:datashare/v20191101:Share"),
		},
		{
			Type: pulumi.String("azure-nextgen:datashare/v20200901:Share"),
		},
	})
	opts = append(opts, aliases)
	var resource Share
	err := ctx.RegisterResource("azure-nextgen:datashare/v20181101preview:Share", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetShare gets an existing Share resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetShare(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ShareState, opts ...pulumi.ResourceOption) (*Share, error) {
	var resource Share
	err := ctx.ReadResource("azure-nextgen:datashare/v20181101preview:Share", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Share resources.
type shareState struct {
	// Time at which the share was created.
	CreatedAt *string `pulumi:"createdAt"`
	// Share description.
	Description *string `pulumi:"description"`
	// Name of the azure resource
	Name *string `pulumi:"name"`
	// Gets or sets the provisioning state
	ProvisioningState *string `pulumi:"provisioningState"`
	// Share kind.
	ShareKind *string `pulumi:"shareKind"`
	// Share terms.
	Terms *string `pulumi:"terms"`
	// Type of the azure resource
	Type *string `pulumi:"type"`
	// Email of the user who created the resource
	UserEmail *string `pulumi:"userEmail"`
	// Name of the user who created the resource
	UserName *string `pulumi:"userName"`
}

type ShareState struct {
	// Time at which the share was created.
	CreatedAt pulumi.StringPtrInput
	// Share description.
	Description pulumi.StringPtrInput
	// Name of the azure resource
	Name pulumi.StringPtrInput
	// Gets or sets the provisioning state
	ProvisioningState pulumi.StringPtrInput
	// Share kind.
	ShareKind pulumi.StringPtrInput
	// Share terms.
	Terms pulumi.StringPtrInput
	// Type of the azure resource
	Type pulumi.StringPtrInput
	// Email of the user who created the resource
	UserEmail pulumi.StringPtrInput
	// Name of the user who created the resource
	UserName pulumi.StringPtrInput
}

func (ShareState) ElementType() reflect.Type {
	return reflect.TypeOf((*shareState)(nil)).Elem()
}

type shareArgs struct {
	// The name of the share account.
	AccountName string `pulumi:"accountName"`
	// Share description.
	Description *string `pulumi:"description"`
	// The resource group name.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Share kind.
	ShareKind *string `pulumi:"shareKind"`
	// The name of the share.
	ShareName string `pulumi:"shareName"`
	// Share terms.
	Terms *string `pulumi:"terms"`
}

// The set of arguments for constructing a Share resource.
type ShareArgs struct {
	// The name of the share account.
	AccountName pulumi.StringInput
	// Share description.
	Description pulumi.StringPtrInput
	// The resource group name.
	ResourceGroupName pulumi.StringInput
	// Share kind.
	ShareKind pulumi.StringPtrInput
	// The name of the share.
	ShareName pulumi.StringInput
	// Share terms.
	Terms pulumi.StringPtrInput
}

func (ShareArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*shareArgs)(nil)).Elem()
}

type ShareInput interface {
	pulumi.Input

	ToShareOutput() ShareOutput
	ToShareOutputWithContext(ctx context.Context) ShareOutput
}

func (*Share) ElementType() reflect.Type {
	return reflect.TypeOf((*Share)(nil))
}

func (i *Share) ToShareOutput() ShareOutput {
	return i.ToShareOutputWithContext(context.Background())
}

func (i *Share) ToShareOutputWithContext(ctx context.Context) ShareOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ShareOutput)
}

type ShareOutput struct {
	*pulumi.OutputState
}

func (ShareOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Share)(nil))
}

func (o ShareOutput) ToShareOutput() ShareOutput {
	return o
}

func (o ShareOutput) ToShareOutputWithContext(ctx context.Context) ShareOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ShareOutput{})
}
