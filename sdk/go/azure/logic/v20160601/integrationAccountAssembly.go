// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20160601

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The assembly definition.
type IntegrationAccountAssembly struct {
	pulumi.CustomResourceState

	// The resource location.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Gets the resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The assembly properties.
	Properties AssemblyPropertiesResponseOutput `pulumi:"properties"`
	// The resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Gets the resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewIntegrationAccountAssembly registers a new resource with the given unique name, arguments, and options.
func NewIntegrationAccountAssembly(ctx *pulumi.Context,
	name string, args *IntegrationAccountAssemblyArgs, opts ...pulumi.ResourceOption) (*IntegrationAccountAssembly, error) {
	if args == nil || args.AssemblyArtifactName == nil {
		return nil, errors.New("missing required argument 'AssemblyArtifactName'")
	}
	if args == nil || args.IntegrationAccountName == nil {
		return nil, errors.New("missing required argument 'IntegrationAccountName'")
	}
	if args == nil || args.Properties == nil {
		return nil, errors.New("missing required argument 'Properties'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &IntegrationAccountAssemblyArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:logic/latest:IntegrationAccountAssembly"),
		},
		{
			Type: pulumi.String("azure-nextgen:logic/v20180701preview:IntegrationAccountAssembly"),
		},
		{
			Type: pulumi.String("azure-nextgen:logic/v20190501:IntegrationAccountAssembly"),
		},
	})
	opts = append(opts, aliases)
	var resource IntegrationAccountAssembly
	err := ctx.RegisterResource("azure-nextgen:logic/v20160601:IntegrationAccountAssembly", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetIntegrationAccountAssembly gets an existing IntegrationAccountAssembly resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIntegrationAccountAssembly(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *IntegrationAccountAssemblyState, opts ...pulumi.ResourceOption) (*IntegrationAccountAssembly, error) {
	var resource IntegrationAccountAssembly
	err := ctx.ReadResource("azure-nextgen:logic/v20160601:IntegrationAccountAssembly", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering IntegrationAccountAssembly resources.
type integrationAccountAssemblyState struct {
	// The resource location.
	Location *string `pulumi:"location"`
	// Gets the resource name.
	Name *string `pulumi:"name"`
	// The assembly properties.
	Properties *AssemblyPropertiesResponse `pulumi:"properties"`
	// The resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Gets the resource type.
	Type *string `pulumi:"type"`
}

type IntegrationAccountAssemblyState struct {
	// The resource location.
	Location pulumi.StringPtrInput
	// Gets the resource name.
	Name pulumi.StringPtrInput
	// The assembly properties.
	Properties AssemblyPropertiesResponsePtrInput
	// The resource tags.
	Tags pulumi.StringMapInput
	// Gets the resource type.
	Type pulumi.StringPtrInput
}

func (IntegrationAccountAssemblyState) ElementType() reflect.Type {
	return reflect.TypeOf((*integrationAccountAssemblyState)(nil)).Elem()
}

type integrationAccountAssemblyArgs struct {
	// The assembly artifact name.
	AssemblyArtifactName string `pulumi:"assemblyArtifactName"`
	// The integration account name.
	IntegrationAccountName string `pulumi:"integrationAccountName"`
	// The resource location.
	Location *string `pulumi:"location"`
	// The assembly properties.
	Properties AssemblyProperties `pulumi:"properties"`
	// The resource group name.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a IntegrationAccountAssembly resource.
type IntegrationAccountAssemblyArgs struct {
	// The assembly artifact name.
	AssemblyArtifactName pulumi.StringInput
	// The integration account name.
	IntegrationAccountName pulumi.StringInput
	// The resource location.
	Location pulumi.StringPtrInput
	// The assembly properties.
	Properties AssemblyPropertiesInput
	// The resource group name.
	ResourceGroupName pulumi.StringInput
	// The resource tags.
	Tags pulumi.StringMapInput
}

func (IntegrationAccountAssemblyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*integrationAccountAssemblyArgs)(nil)).Elem()
}

type IntegrationAccountAssemblyInput interface {
	pulumi.Input

	ToIntegrationAccountAssemblyOutput() IntegrationAccountAssemblyOutput
	ToIntegrationAccountAssemblyOutputWithContext(ctx context.Context) IntegrationAccountAssemblyOutput
}

func (IntegrationAccountAssembly) ElementType() reflect.Type {
	return reflect.TypeOf((*IntegrationAccountAssembly)(nil)).Elem()
}

func (i IntegrationAccountAssembly) ToIntegrationAccountAssemblyOutput() IntegrationAccountAssemblyOutput {
	return i.ToIntegrationAccountAssemblyOutputWithContext(context.Background())
}

func (i IntegrationAccountAssembly) ToIntegrationAccountAssemblyOutputWithContext(ctx context.Context) IntegrationAccountAssemblyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IntegrationAccountAssemblyOutput)
}

type IntegrationAccountAssemblyOutput struct {
	*pulumi.OutputState
}

func (IntegrationAccountAssemblyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*IntegrationAccountAssemblyOutput)(nil)).Elem()
}

func (o IntegrationAccountAssemblyOutput) ToIntegrationAccountAssemblyOutput() IntegrationAccountAssemblyOutput {
	return o
}

func (o IntegrationAccountAssemblyOutput) ToIntegrationAccountAssemblyOutputWithContext(ctx context.Context) IntegrationAccountAssemblyOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(IntegrationAccountAssemblyOutput{})
}
