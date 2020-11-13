// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190301

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Deployment information.
type Deployment struct {
	pulumi.CustomResourceState

	// the location of the deployment.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// The name of the deployment.
	Name pulumi.StringOutput `pulumi:"name"`
	// Deployment properties.
	Properties DeploymentPropertiesExtendedResponseOutput `pulumi:"properties"`
	// The type of the deployment.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewDeployment registers a new resource with the given unique name, arguments, and options.
func NewDeployment(ctx *pulumi.Context,
	name string, args *DeploymentArgs, opts ...pulumi.ResourceOption) (*Deployment, error) {
	if args == nil || args.DeploymentName == nil {
		return nil, errors.New("missing required argument 'DeploymentName'")
	}
	if args == nil || args.Properties == nil {
		return nil, errors.New("missing required argument 'Properties'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &DeploymentArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:resources/latest:Deployment"),
		},
		{
			Type: pulumi.String("azure-nextgen:resources/v20151101:Deployment"),
		},
		{
			Type: pulumi.String("azure-nextgen:resources/v20160201:Deployment"),
		},
		{
			Type: pulumi.String("azure-nextgen:resources/v20160701:Deployment"),
		},
		{
			Type: pulumi.String("azure-nextgen:resources/v20160901:Deployment"),
		},
		{
			Type: pulumi.String("azure-nextgen:resources/v20170510:Deployment"),
		},
		{
			Type: pulumi.String("azure-nextgen:resources/v20180201:Deployment"),
		},
		{
			Type: pulumi.String("azure-nextgen:resources/v20180501:Deployment"),
		},
		{
			Type: pulumi.String("azure-nextgen:resources/v20190501:Deployment"),
		},
		{
			Type: pulumi.String("azure-nextgen:resources/v20190510:Deployment"),
		},
		{
			Type: pulumi.String("azure-nextgen:resources/v20190701:Deployment"),
		},
		{
			Type: pulumi.String("azure-nextgen:resources/v20190801:Deployment"),
		},
		{
			Type: pulumi.String("azure-nextgen:resources/v20191001:Deployment"),
		},
		{
			Type: pulumi.String("azure-nextgen:resources/v20200601:Deployment"),
		},
	})
	opts = append(opts, aliases)
	var resource Deployment
	err := ctx.RegisterResource("azure-nextgen:resources/v20190301:Deployment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDeployment gets an existing Deployment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDeployment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DeploymentState, opts ...pulumi.ResourceOption) (*Deployment, error) {
	var resource Deployment
	err := ctx.ReadResource("azure-nextgen:resources/v20190301:Deployment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Deployment resources.
type deploymentState struct {
	// the location of the deployment.
	Location *string `pulumi:"location"`
	// The name of the deployment.
	Name *string `pulumi:"name"`
	// Deployment properties.
	Properties *DeploymentPropertiesExtendedResponse `pulumi:"properties"`
	// The type of the deployment.
	Type *string `pulumi:"type"`
}

type DeploymentState struct {
	// the location of the deployment.
	Location pulumi.StringPtrInput
	// The name of the deployment.
	Name pulumi.StringPtrInput
	// Deployment properties.
	Properties DeploymentPropertiesExtendedResponsePtrInput
	// The type of the deployment.
	Type pulumi.StringPtrInput
}

func (DeploymentState) ElementType() reflect.Type {
	return reflect.TypeOf((*deploymentState)(nil)).Elem()
}

type deploymentArgs struct {
	// The name of the deployment.
	DeploymentName string `pulumi:"deploymentName"`
	// The location to store the deployment data.
	Location *string `pulumi:"location"`
	// The deployment properties.
	Properties DeploymentProperties `pulumi:"properties"`
	// The name of the resource group to deploy the resources to. The name is case insensitive. The resource group must already exist.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The set of arguments for constructing a Deployment resource.
type DeploymentArgs struct {
	// The name of the deployment.
	DeploymentName pulumi.StringInput
	// The location to store the deployment data.
	Location pulumi.StringPtrInput
	// The deployment properties.
	Properties DeploymentPropertiesInput
	// The name of the resource group to deploy the resources to. The name is case insensitive. The resource group must already exist.
	ResourceGroupName pulumi.StringInput
}

func (DeploymentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*deploymentArgs)(nil)).Elem()
}

type DeploymentInput interface {
	pulumi.Input

	ToDeploymentOutput() DeploymentOutput
	ToDeploymentOutputWithContext(ctx context.Context) DeploymentOutput
}

func (Deployment) ElementType() reflect.Type {
	return reflect.TypeOf((*Deployment)(nil)).Elem()
}

func (i Deployment) ToDeploymentOutput() DeploymentOutput {
	return i.ToDeploymentOutputWithContext(context.Background())
}

func (i Deployment) ToDeploymentOutputWithContext(ctx context.Context) DeploymentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DeploymentOutput)
}

type DeploymentOutput struct {
	*pulumi.OutputState
}

func (DeploymentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DeploymentOutput)(nil)).Elem()
}

func (o DeploymentOutput) ToDeploymentOutput() DeploymentOutput {
	return o
}

func (o DeploymentOutput) ToDeploymentOutputWithContext(ctx context.Context) DeploymentOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(DeploymentOutput{})
}
