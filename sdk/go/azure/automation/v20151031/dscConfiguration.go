// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20151031

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Definition of the configuration type.
type DscConfiguration struct {
	pulumi.CustomResourceState

	// Gets or sets the creation time.
	CreationTime pulumi.StringPtrOutput `pulumi:"creationTime"`
	// Gets or sets the description.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Gets or sets the etag of the resource.
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// Gets or sets the job count of the configuration.
	JobCount pulumi.IntPtrOutput `pulumi:"jobCount"`
	// Gets or sets the last modified time.
	LastModifiedTime pulumi.StringPtrOutput `pulumi:"lastModifiedTime"`
	// The Azure Region where the resource lives
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Gets or sets verbose log option.
	LogVerbose pulumi.BoolPtrOutput `pulumi:"logVerbose"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// Gets the number of compiled node configurations.
	NodeConfigurationCount pulumi.IntPtrOutput `pulumi:"nodeConfigurationCount"`
	// Gets or sets the configuration parameters.
	Parameters DscConfigurationParameterResponseMapOutput `pulumi:"parameters"`
	// Gets or sets the provisioning state of the configuration.
	ProvisioningState pulumi.StringPtrOutput `pulumi:"provisioningState"`
	// Gets or sets the source.
	Source ContentSourceResponsePtrOutput `pulumi:"source"`
	// Gets or sets the state of the configuration.
	State pulumi.StringPtrOutput `pulumi:"state"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the resource.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewDscConfiguration registers a new resource with the given unique name, arguments, and options.
func NewDscConfiguration(ctx *pulumi.Context,
	name string, args *DscConfigurationArgs, opts ...pulumi.ResourceOption) (*DscConfiguration, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AutomationAccountName == nil {
		return nil, errors.New("invalid value for required argument 'AutomationAccountName'")
	}
	if args.ConfigurationName == nil {
		return nil, errors.New("invalid value for required argument 'ConfigurationName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.Source == nil {
		return nil, errors.New("invalid value for required argument 'Source'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:automation/latest:DscConfiguration"),
		},
		{
			Type: pulumi.String("azure-nextgen:automation/v20190601:DscConfiguration"),
		},
	})
	opts = append(opts, aliases)
	var resource DscConfiguration
	err := ctx.RegisterResource("azure-nextgen:automation/v20151031:DscConfiguration", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDscConfiguration gets an existing DscConfiguration resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDscConfiguration(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DscConfigurationState, opts ...pulumi.ResourceOption) (*DscConfiguration, error) {
	var resource DscConfiguration
	err := ctx.ReadResource("azure-nextgen:automation/v20151031:DscConfiguration", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DscConfiguration resources.
type dscConfigurationState struct {
	// Gets or sets the creation time.
	CreationTime *string `pulumi:"creationTime"`
	// Gets or sets the description.
	Description *string `pulumi:"description"`
	// Gets or sets the etag of the resource.
	Etag *string `pulumi:"etag"`
	// Gets or sets the job count of the configuration.
	JobCount *int `pulumi:"jobCount"`
	// Gets or sets the last modified time.
	LastModifiedTime *string `pulumi:"lastModifiedTime"`
	// The Azure Region where the resource lives
	Location *string `pulumi:"location"`
	// Gets or sets verbose log option.
	LogVerbose *bool `pulumi:"logVerbose"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// Gets the number of compiled node configurations.
	NodeConfigurationCount *int `pulumi:"nodeConfigurationCount"`
	// Gets or sets the configuration parameters.
	Parameters map[string]DscConfigurationParameterResponse `pulumi:"parameters"`
	// Gets or sets the provisioning state of the configuration.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Gets or sets the source.
	Source *ContentSourceResponse `pulumi:"source"`
	// Gets or sets the state of the configuration.
	State *string `pulumi:"state"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource.
	Type *string `pulumi:"type"`
}

type DscConfigurationState struct {
	// Gets or sets the creation time.
	CreationTime pulumi.StringPtrInput
	// Gets or sets the description.
	Description pulumi.StringPtrInput
	// Gets or sets the etag of the resource.
	Etag pulumi.StringPtrInput
	// Gets or sets the job count of the configuration.
	JobCount pulumi.IntPtrInput
	// Gets or sets the last modified time.
	LastModifiedTime pulumi.StringPtrInput
	// The Azure Region where the resource lives
	Location pulumi.StringPtrInput
	// Gets or sets verbose log option.
	LogVerbose pulumi.BoolPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// Gets the number of compiled node configurations.
	NodeConfigurationCount pulumi.IntPtrInput
	// Gets or sets the configuration parameters.
	Parameters DscConfigurationParameterResponseMapInput
	// Gets or sets the provisioning state of the configuration.
	ProvisioningState pulumi.StringPtrInput
	// Gets or sets the source.
	Source ContentSourceResponsePtrInput
	// Gets or sets the state of the configuration.
	State pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The type of the resource.
	Type pulumi.StringPtrInput
}

func (DscConfigurationState) ElementType() reflect.Type {
	return reflect.TypeOf((*dscConfigurationState)(nil)).Elem()
}

type dscConfigurationArgs struct {
	// The name of the automation account.
	AutomationAccountName string `pulumi:"automationAccountName"`
	// The create or update parameters for configuration.
	ConfigurationName string `pulumi:"configurationName"`
	// Gets or sets the description of the configuration.
	Description *string `pulumi:"description"`
	// Gets or sets the location of the resource.
	Location *string `pulumi:"location"`
	// Gets or sets progress log option.
	LogProgress *bool `pulumi:"logProgress"`
	// Gets or sets verbose log option.
	LogVerbose *bool `pulumi:"logVerbose"`
	// Gets or sets name of the resource.
	Name *string `pulumi:"name"`
	// Gets or sets the configuration parameters.
	Parameters map[string]DscConfigurationParameter `pulumi:"parameters"`
	// Name of an Azure Resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Gets or sets the source.
	Source ContentSource `pulumi:"source"`
	// Gets or sets the tags attached to the resource.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a DscConfiguration resource.
type DscConfigurationArgs struct {
	// The name of the automation account.
	AutomationAccountName pulumi.StringInput
	// The create or update parameters for configuration.
	ConfigurationName pulumi.StringInput
	// Gets or sets the description of the configuration.
	Description pulumi.StringPtrInput
	// Gets or sets the location of the resource.
	Location pulumi.StringPtrInput
	// Gets or sets progress log option.
	LogProgress pulumi.BoolPtrInput
	// Gets or sets verbose log option.
	LogVerbose pulumi.BoolPtrInput
	// Gets or sets name of the resource.
	Name pulumi.StringPtrInput
	// Gets or sets the configuration parameters.
	Parameters DscConfigurationParameterMapInput
	// Name of an Azure Resource group.
	ResourceGroupName pulumi.StringInput
	// Gets or sets the source.
	Source ContentSourceInput
	// Gets or sets the tags attached to the resource.
	Tags pulumi.StringMapInput
}

func (DscConfigurationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*dscConfigurationArgs)(nil)).Elem()
}

type DscConfigurationInput interface {
	pulumi.Input

	ToDscConfigurationOutput() DscConfigurationOutput
	ToDscConfigurationOutputWithContext(ctx context.Context) DscConfigurationOutput
}

func (*DscConfiguration) ElementType() reflect.Type {
	return reflect.TypeOf((*DscConfiguration)(nil))
}

func (i *DscConfiguration) ToDscConfigurationOutput() DscConfigurationOutput {
	return i.ToDscConfigurationOutputWithContext(context.Background())
}

func (i *DscConfiguration) ToDscConfigurationOutputWithContext(ctx context.Context) DscConfigurationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DscConfigurationOutput)
}

type DscConfigurationOutput struct {
	*pulumi.OutputState
}

func (DscConfigurationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DscConfiguration)(nil))
}

func (o DscConfigurationOutput) ToDscConfigurationOutput() DscConfigurationOutput {
	return o
}

func (o DscConfigurationOutput) ToDscConfigurationOutputWithContext(ctx context.Context) DscConfigurationOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(DscConfigurationOutput{})
}
