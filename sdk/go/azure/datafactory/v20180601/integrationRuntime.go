// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180601

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Integration runtime resource type.
type IntegrationRuntime struct {
	pulumi.CustomResourceState

	// Etag identifies change in the resource.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// The resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Integration runtime properties.
	Properties pulumi.AnyOutput `pulumi:"properties"`
	// The resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewIntegrationRuntime registers a new resource with the given unique name, arguments, and options.
func NewIntegrationRuntime(ctx *pulumi.Context,
	name string, args *IntegrationRuntimeArgs, opts ...pulumi.ResourceOption) (*IntegrationRuntime, error) {
	if args == nil || args.FactoryName == nil {
		return nil, errors.New("missing required argument 'FactoryName'")
	}
	if args == nil || args.IntegrationRuntimeName == nil {
		return nil, errors.New("missing required argument 'IntegrationRuntimeName'")
	}
	if args == nil || args.Properties == nil {
		return nil, errors.New("missing required argument 'Properties'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &IntegrationRuntimeArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:datafactory/latest:IntegrationRuntime"),
		},
		{
			Type: pulumi.String("azure-nextgen:datafactory/v20170901preview:IntegrationRuntime"),
		},
	})
	opts = append(opts, aliases)
	var resource IntegrationRuntime
	err := ctx.RegisterResource("azure-nextgen:datafactory/v20180601:IntegrationRuntime", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetIntegrationRuntime gets an existing IntegrationRuntime resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIntegrationRuntime(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *IntegrationRuntimeState, opts ...pulumi.ResourceOption) (*IntegrationRuntime, error) {
	var resource IntegrationRuntime
	err := ctx.ReadResource("azure-nextgen:datafactory/v20180601:IntegrationRuntime", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering IntegrationRuntime resources.
type integrationRuntimeState struct {
	// Etag identifies change in the resource.
	Etag *string `pulumi:"etag"`
	// The resource name.
	Name *string `pulumi:"name"`
	// Integration runtime properties.
	Properties interface{} `pulumi:"properties"`
	// The resource type.
	Type *string `pulumi:"type"`
}

type IntegrationRuntimeState struct {
	// Etag identifies change in the resource.
	Etag pulumi.StringPtrInput
	// The resource name.
	Name pulumi.StringPtrInput
	// Integration runtime properties.
	Properties pulumi.Input
	// The resource type.
	Type pulumi.StringPtrInput
}

func (IntegrationRuntimeState) ElementType() reflect.Type {
	return reflect.TypeOf((*integrationRuntimeState)(nil)).Elem()
}

type integrationRuntimeArgs struct {
	// The factory name.
	FactoryName string `pulumi:"factoryName"`
	// The integration runtime name.
	IntegrationRuntimeName string `pulumi:"integrationRuntimeName"`
	// Integration runtime properties.
	Properties interface{} `pulumi:"properties"`
	// The resource group name.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The set of arguments for constructing a IntegrationRuntime resource.
type IntegrationRuntimeArgs struct {
	// The factory name.
	FactoryName pulumi.StringInput
	// The integration runtime name.
	IntegrationRuntimeName pulumi.StringInput
	// Integration runtime properties.
	Properties pulumi.Input
	// The resource group name.
	ResourceGroupName pulumi.StringInput
}

func (IntegrationRuntimeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*integrationRuntimeArgs)(nil)).Elem()
}

type IntegrationRuntimeInput interface {
	pulumi.Input

	ToIntegrationRuntimeOutput() IntegrationRuntimeOutput
	ToIntegrationRuntimeOutputWithContext(ctx context.Context) IntegrationRuntimeOutput
}

func (IntegrationRuntime) ElementType() reflect.Type {
	return reflect.TypeOf((*IntegrationRuntime)(nil)).Elem()
}

func (i IntegrationRuntime) ToIntegrationRuntimeOutput() IntegrationRuntimeOutput {
	return i.ToIntegrationRuntimeOutputWithContext(context.Background())
}

func (i IntegrationRuntime) ToIntegrationRuntimeOutputWithContext(ctx context.Context) IntegrationRuntimeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IntegrationRuntimeOutput)
}

type IntegrationRuntimeOutput struct {
	*pulumi.OutputState
}

func (IntegrationRuntimeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*IntegrationRuntimeOutput)(nil)).Elem()
}

func (o IntegrationRuntimeOutput) ToIntegrationRuntimeOutput() IntegrationRuntimeOutput {
	return o
}

func (o IntegrationRuntimeOutput) ToIntegrationRuntimeOutputWithContext(ctx context.Context) IntegrationRuntimeOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(IntegrationRuntimeOutput{})
}
