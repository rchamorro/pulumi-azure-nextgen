// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Definition of the dsc node configuration.
// Latest API Version: 2018-01-15.
type DscNodeConfiguration struct {
	pulumi.CustomResourceState

	// Gets or sets the configuration of the node.
	Configuration DscConfigurationAssociationPropertyResponsePtrOutput `pulumi:"configuration"`
	// Gets or sets creation time.
	CreationTime pulumi.StringPtrOutput `pulumi:"creationTime"`
	// If a new build version of NodeConfiguration is required.
	IncrementNodeConfigurationBuild pulumi.BoolPtrOutput `pulumi:"incrementNodeConfigurationBuild"`
	// Gets or sets the last modified time.
	LastModifiedTime pulumi.StringPtrOutput `pulumi:"lastModifiedTime"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// Number of nodes with this node configuration assigned
	NodeCount pulumi.Float64PtrOutput `pulumi:"nodeCount"`
	// Source of node configuration.
	Source pulumi.StringPtrOutput `pulumi:"source"`
	// The type of the resource.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewDscNodeConfiguration registers a new resource with the given unique name, arguments, and options.
func NewDscNodeConfiguration(ctx *pulumi.Context,
	name string, args *DscNodeConfigurationArgs, opts ...pulumi.ResourceOption) (*DscNodeConfiguration, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AutomationAccountName == nil {
		return nil, errors.New("invalid value for required argument 'AutomationAccountName'")
	}
	if args.Configuration == nil {
		return nil, errors.New("invalid value for required argument 'Configuration'")
	}
	if args.NodeConfigurationName == nil {
		return nil, errors.New("invalid value for required argument 'NodeConfigurationName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.Source == nil {
		return nil, errors.New("invalid value for required argument 'Source'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:automation/v20151031:DscNodeConfiguration"),
		},
		{
			Type: pulumi.String("azure-nextgen:automation/v20180115:DscNodeConfiguration"),
		},
	})
	opts = append(opts, aliases)
	var resource DscNodeConfiguration
	err := ctx.RegisterResource("azure-nextgen:automation/latest:DscNodeConfiguration", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDscNodeConfiguration gets an existing DscNodeConfiguration resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDscNodeConfiguration(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DscNodeConfigurationState, opts ...pulumi.ResourceOption) (*DscNodeConfiguration, error) {
	var resource DscNodeConfiguration
	err := ctx.ReadResource("azure-nextgen:automation/latest:DscNodeConfiguration", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DscNodeConfiguration resources.
type dscNodeConfigurationState struct {
	// Gets or sets the configuration of the node.
	Configuration *DscConfigurationAssociationPropertyResponse `pulumi:"configuration"`
	// Gets or sets creation time.
	CreationTime *string `pulumi:"creationTime"`
	// If a new build version of NodeConfiguration is required.
	IncrementNodeConfigurationBuild *bool `pulumi:"incrementNodeConfigurationBuild"`
	// Gets or sets the last modified time.
	LastModifiedTime *string `pulumi:"lastModifiedTime"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// Number of nodes with this node configuration assigned
	NodeCount *float64 `pulumi:"nodeCount"`
	// Source of node configuration.
	Source *string `pulumi:"source"`
	// The type of the resource.
	Type *string `pulumi:"type"`
}

type DscNodeConfigurationState struct {
	// Gets or sets the configuration of the node.
	Configuration DscConfigurationAssociationPropertyResponsePtrInput
	// Gets or sets creation time.
	CreationTime pulumi.StringPtrInput
	// If a new build version of NodeConfiguration is required.
	IncrementNodeConfigurationBuild pulumi.BoolPtrInput
	// Gets or sets the last modified time.
	LastModifiedTime pulumi.StringPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// Number of nodes with this node configuration assigned
	NodeCount pulumi.Float64PtrInput
	// Source of node configuration.
	Source pulumi.StringPtrInput
	// The type of the resource.
	Type pulumi.StringPtrInput
}

func (DscNodeConfigurationState) ElementType() reflect.Type {
	return reflect.TypeOf((*dscNodeConfigurationState)(nil)).Elem()
}

type dscNodeConfigurationArgs struct {
	// The name of the automation account.
	AutomationAccountName string `pulumi:"automationAccountName"`
	// Gets or sets the configuration of the node.
	Configuration DscConfigurationAssociationProperty `pulumi:"configuration"`
	// If a new build version of NodeConfiguration is required.
	IncrementNodeConfigurationBuild *bool `pulumi:"incrementNodeConfigurationBuild"`
	// Name of the node configuration.
	Name *string `pulumi:"name"`
	// The Dsc node configuration name.
	NodeConfigurationName string `pulumi:"nodeConfigurationName"`
	// Name of an Azure Resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Gets or sets the source.
	Source ContentSource `pulumi:"source"`
	// Gets or sets the tags attached to the resource.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a DscNodeConfiguration resource.
type DscNodeConfigurationArgs struct {
	// The name of the automation account.
	AutomationAccountName pulumi.StringInput
	// Gets or sets the configuration of the node.
	Configuration DscConfigurationAssociationPropertyInput
	// If a new build version of NodeConfiguration is required.
	IncrementNodeConfigurationBuild pulumi.BoolPtrInput
	// Name of the node configuration.
	Name pulumi.StringPtrInput
	// The Dsc node configuration name.
	NodeConfigurationName pulumi.StringInput
	// Name of an Azure Resource group.
	ResourceGroupName pulumi.StringInput
	// Gets or sets the source.
	Source ContentSourceInput
	// Gets or sets the tags attached to the resource.
	Tags pulumi.StringMapInput
}

func (DscNodeConfigurationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*dscNodeConfigurationArgs)(nil)).Elem()
}

type DscNodeConfigurationInput interface {
	pulumi.Input

	ToDscNodeConfigurationOutput() DscNodeConfigurationOutput
	ToDscNodeConfigurationOutputWithContext(ctx context.Context) DscNodeConfigurationOutput
}

func (*DscNodeConfiguration) ElementType() reflect.Type {
	return reflect.TypeOf((*DscNodeConfiguration)(nil))
}

func (i *DscNodeConfiguration) ToDscNodeConfigurationOutput() DscNodeConfigurationOutput {
	return i.ToDscNodeConfigurationOutputWithContext(context.Background())
}

func (i *DscNodeConfiguration) ToDscNodeConfigurationOutputWithContext(ctx context.Context) DscNodeConfigurationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DscNodeConfigurationOutput)
}

type DscNodeConfigurationOutput struct {
	*pulumi.OutputState
}

func (DscNodeConfigurationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DscNodeConfiguration)(nil))
}

func (o DscNodeConfigurationOutput) ToDscNodeConfigurationOutput() DscNodeConfigurationOutput {
	return o
}

func (o DscNodeConfigurationOutput) ToDscNodeConfigurationOutputWithContext(ctx context.Context) DscNodeConfigurationOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(DscNodeConfigurationOutput{})
}
