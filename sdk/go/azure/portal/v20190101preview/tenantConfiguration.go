// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190101preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Tenant configuration.
type TenantConfiguration struct {
	pulumi.CustomResourceState

	// When flag is set to true Markdown tile will require external storage configuration (URI). The inline content configuration will be prohibited.
	EnforcePrivateMarkdownStorage pulumi.BoolPtrOutput `pulumi:"enforcePrivateMarkdownStorage"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewTenantConfiguration registers a new resource with the given unique name, arguments, and options.
func NewTenantConfiguration(ctx *pulumi.Context,
	name string, args *TenantConfigurationArgs, opts ...pulumi.ResourceOption) (*TenantConfiguration, error) {
	if args == nil || args.ConfigurationName == nil {
		return nil, errors.New("missing required argument 'ConfigurationName'")
	}
	if args == nil {
		args = &TenantConfigurationArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:portal/v20200901preview:TenantConfiguration"),
		},
	})
	opts = append(opts, aliases)
	var resource TenantConfiguration
	err := ctx.RegisterResource("azure-nextgen:portal/v20190101preview:TenantConfiguration", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTenantConfiguration gets an existing TenantConfiguration resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTenantConfiguration(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TenantConfigurationState, opts ...pulumi.ResourceOption) (*TenantConfiguration, error) {
	var resource TenantConfiguration
	err := ctx.ReadResource("azure-nextgen:portal/v20190101preview:TenantConfiguration", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering TenantConfiguration resources.
type tenantConfigurationState struct {
	// When flag is set to true Markdown tile will require external storage configuration (URI). The inline content configuration will be prohibited.
	EnforcePrivateMarkdownStorage *bool `pulumi:"enforcePrivateMarkdownStorage"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
}

type TenantConfigurationState struct {
	// When flag is set to true Markdown tile will require external storage configuration (URI). The inline content configuration will be prohibited.
	EnforcePrivateMarkdownStorage pulumi.BoolPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
}

func (TenantConfigurationState) ElementType() reflect.Type {
	return reflect.TypeOf((*tenantConfigurationState)(nil)).Elem()
}

type tenantConfigurationArgs struct {
	// The configuration name. Value must be 'default'
	ConfigurationName string `pulumi:"configurationName"`
	// When flag is set to true Markdown tile will require external storage configuration (URI). The inline content configuration will be prohibited.
	EnforcePrivateMarkdownStorage *bool `pulumi:"enforcePrivateMarkdownStorage"`
}

// The set of arguments for constructing a TenantConfiguration resource.
type TenantConfigurationArgs struct {
	// The configuration name. Value must be 'default'
	ConfigurationName pulumi.StringInput
	// When flag is set to true Markdown tile will require external storage configuration (URI). The inline content configuration will be prohibited.
	EnforcePrivateMarkdownStorage pulumi.BoolPtrInput
}

func (TenantConfigurationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*tenantConfigurationArgs)(nil)).Elem()
}

type TenantConfigurationInput interface {
	pulumi.Input

	ToTenantConfigurationOutput() TenantConfigurationOutput
	ToTenantConfigurationOutputWithContext(ctx context.Context) TenantConfigurationOutput
}

func (TenantConfiguration) ElementType() reflect.Type {
	return reflect.TypeOf((*TenantConfiguration)(nil)).Elem()
}

func (i TenantConfiguration) ToTenantConfigurationOutput() TenantConfigurationOutput {
	return i.ToTenantConfigurationOutputWithContext(context.Background())
}

func (i TenantConfiguration) ToTenantConfigurationOutputWithContext(ctx context.Context) TenantConfigurationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TenantConfigurationOutput)
}

type TenantConfigurationOutput struct {
	*pulumi.OutputState
}

func (TenantConfigurationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*TenantConfigurationOutput)(nil)).Elem()
}

func (o TenantConfigurationOutput) ToTenantConfigurationOutput() TenantConfigurationOutput {
	return o
}

func (o TenantConfigurationOutput) ToTenantConfigurationOutputWithContext(ctx context.Context) TenantConfigurationOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(TenantConfigurationOutput{})
}
