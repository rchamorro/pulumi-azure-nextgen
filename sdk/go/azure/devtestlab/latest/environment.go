// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// An environment, which is essentially an ARM template deployment.
type Environment struct {
	pulumi.CustomResourceState

	// The display name of the Azure Resource Manager template that produced the environment.
	ArmTemplateDisplayName pulumi.StringPtrOutput `pulumi:"armTemplateDisplayName"`
	// The creator of the environment.
	CreatedByUser pulumi.StringOutput `pulumi:"createdByUser"`
	// The deployment properties of the environment.
	DeploymentProperties EnvironmentDeploymentPropertiesResponsePtrOutput `pulumi:"deploymentProperties"`
	// The location of the resource.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// The name of the resource.
	Name pulumi.StringOutput `pulumi:"name"`
	// The provisioning status of the resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The identifier of the resource group containing the environment's resources.
	ResourceGroupId pulumi.StringOutput `pulumi:"resourceGroupId"`
	// The tags of the resource.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the resource.
	Type pulumi.StringOutput `pulumi:"type"`
	// The unique immutable identifier of a resource (Guid).
	UniqueIdentifier pulumi.StringOutput `pulumi:"uniqueIdentifier"`
}

// NewEnvironment registers a new resource with the given unique name, arguments, and options.
func NewEnvironment(ctx *pulumi.Context,
	name string, args *EnvironmentArgs, opts ...pulumi.ResourceOption) (*Environment, error) {
	if args == nil || args.LabName == nil {
		return nil, errors.New("missing required argument 'LabName'")
	}
	if args == nil || args.Name == nil {
		return nil, errors.New("missing required argument 'Name'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.UserName == nil {
		return nil, errors.New("missing required argument 'UserName'")
	}
	if args == nil {
		args = &EnvironmentArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:devtestlab/v20160515:Environment"),
		},
		{
			Type: pulumi.String("azure-nextgen:devtestlab/v20180915:Environment"),
		},
	})
	opts = append(opts, aliases)
	var resource Environment
	err := ctx.RegisterResource("azure-nextgen:devtestlab/latest:Environment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetEnvironment gets an existing Environment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetEnvironment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *EnvironmentState, opts ...pulumi.ResourceOption) (*Environment, error) {
	var resource Environment
	err := ctx.ReadResource("azure-nextgen:devtestlab/latest:Environment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Environment resources.
type environmentState struct {
	// The display name of the Azure Resource Manager template that produced the environment.
	ArmTemplateDisplayName *string `pulumi:"armTemplateDisplayName"`
	// The creator of the environment.
	CreatedByUser *string `pulumi:"createdByUser"`
	// The deployment properties of the environment.
	DeploymentProperties *EnvironmentDeploymentPropertiesResponse `pulumi:"deploymentProperties"`
	// The location of the resource.
	Location *string `pulumi:"location"`
	// The name of the resource.
	Name *string `pulumi:"name"`
	// The provisioning status of the resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The identifier of the resource group containing the environment's resources.
	ResourceGroupId *string `pulumi:"resourceGroupId"`
	// The tags of the resource.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource.
	Type *string `pulumi:"type"`
	// The unique immutable identifier of a resource (Guid).
	UniqueIdentifier *string `pulumi:"uniqueIdentifier"`
}

type EnvironmentState struct {
	// The display name of the Azure Resource Manager template that produced the environment.
	ArmTemplateDisplayName pulumi.StringPtrInput
	// The creator of the environment.
	CreatedByUser pulumi.StringPtrInput
	// The deployment properties of the environment.
	DeploymentProperties EnvironmentDeploymentPropertiesResponsePtrInput
	// The location of the resource.
	Location pulumi.StringPtrInput
	// The name of the resource.
	Name pulumi.StringPtrInput
	// The provisioning status of the resource.
	ProvisioningState pulumi.StringPtrInput
	// The identifier of the resource group containing the environment's resources.
	ResourceGroupId pulumi.StringPtrInput
	// The tags of the resource.
	Tags pulumi.StringMapInput
	// The type of the resource.
	Type pulumi.StringPtrInput
	// The unique immutable identifier of a resource (Guid).
	UniqueIdentifier pulumi.StringPtrInput
}

func (EnvironmentState) ElementType() reflect.Type {
	return reflect.TypeOf((*environmentState)(nil)).Elem()
}

type environmentArgs struct {
	// The display name of the Azure Resource Manager template that produced the environment.
	ArmTemplateDisplayName *string `pulumi:"armTemplateDisplayName"`
	// The deployment properties of the environment.
	DeploymentProperties *EnvironmentDeploymentProperties `pulumi:"deploymentProperties"`
	// The name of the lab.
	LabName string `pulumi:"labName"`
	// The location of the resource.
	Location *string `pulumi:"location"`
	// The name of the environment.
	Name string `pulumi:"name"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The tags of the resource.
	Tags map[string]string `pulumi:"tags"`
	// The name of the user profile.
	UserName string `pulumi:"userName"`
}

// The set of arguments for constructing a Environment resource.
type EnvironmentArgs struct {
	// The display name of the Azure Resource Manager template that produced the environment.
	ArmTemplateDisplayName pulumi.StringPtrInput
	// The deployment properties of the environment.
	DeploymentProperties EnvironmentDeploymentPropertiesPtrInput
	// The name of the lab.
	LabName pulumi.StringInput
	// The location of the resource.
	Location pulumi.StringPtrInput
	// The name of the environment.
	Name pulumi.StringInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// The tags of the resource.
	Tags pulumi.StringMapInput
	// The name of the user profile.
	UserName pulumi.StringInput
}

func (EnvironmentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*environmentArgs)(nil)).Elem()
}

type EnvironmentInput interface {
	pulumi.Input

	ToEnvironmentOutput() EnvironmentOutput
	ToEnvironmentOutputWithContext(ctx context.Context) EnvironmentOutput
}

func (Environment) ElementType() reflect.Type {
	return reflect.TypeOf((*Environment)(nil)).Elem()
}

func (i Environment) ToEnvironmentOutput() EnvironmentOutput {
	return i.ToEnvironmentOutputWithContext(context.Background())
}

func (i Environment) ToEnvironmentOutputWithContext(ctx context.Context) EnvironmentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EnvironmentOutput)
}

type EnvironmentOutput struct {
	*pulumi.OutputState
}

func (EnvironmentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*EnvironmentOutput)(nil)).Elem()
}

func (o EnvironmentOutput) ToEnvironmentOutput() EnvironmentOutput {
	return o
}

func (o EnvironmentOutput) ToEnvironmentOutputWithContext(ctx context.Context) EnvironmentOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(EnvironmentOutput{})
}
