// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180501

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Batch AI Workspace information.
type Workspace struct {
	pulumi.CustomResourceState

	// Time when the Workspace was created.
	CreationTime pulumi.StringOutput `pulumi:"creationTime"`
	// The location of the resource
	Location pulumi.StringOutput `pulumi:"location"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// The provisioned state of the Workspace
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The time at which the workspace entered its current provisioning state.
	ProvisioningStateTransitionTime pulumi.StringOutput `pulumi:"provisioningStateTransitionTime"`
	// The tags of the resource
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the resource
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewWorkspace registers a new resource with the given unique name, arguments, and options.
func NewWorkspace(ctx *pulumi.Context,
	name string, args *WorkspaceArgs, opts ...pulumi.ResourceOption) (*Workspace, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.WorkspaceName == nil {
		return nil, errors.New("invalid value for required argument 'WorkspaceName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:batchai/latest:Workspace"),
		},
	})
	opts = append(opts, aliases)
	var resource Workspace
	err := ctx.RegisterResource("azure-nextgen:batchai/v20180501:Workspace", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWorkspace gets an existing Workspace resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWorkspace(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WorkspaceState, opts ...pulumi.ResourceOption) (*Workspace, error) {
	var resource Workspace
	err := ctx.ReadResource("azure-nextgen:batchai/v20180501:Workspace", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Workspace resources.
type workspaceState struct {
	// Time when the Workspace was created.
	CreationTime *string `pulumi:"creationTime"`
	// The location of the resource
	Location *string `pulumi:"location"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// The provisioned state of the Workspace
	ProvisioningState *string `pulumi:"provisioningState"`
	// The time at which the workspace entered its current provisioning state.
	ProvisioningStateTransitionTime *string `pulumi:"provisioningStateTransitionTime"`
	// The tags of the resource
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource
	Type *string `pulumi:"type"`
}

type WorkspaceState struct {
	// Time when the Workspace was created.
	CreationTime pulumi.StringPtrInput
	// The location of the resource
	Location pulumi.StringPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// The provisioned state of the Workspace
	ProvisioningState pulumi.StringPtrInput
	// The time at which the workspace entered its current provisioning state.
	ProvisioningStateTransitionTime pulumi.StringPtrInput
	// The tags of the resource
	Tags pulumi.StringMapInput
	// The type of the resource
	Type pulumi.StringPtrInput
}

func (WorkspaceState) ElementType() reflect.Type {
	return reflect.TypeOf((*workspaceState)(nil)).Elem()
}

type workspaceArgs struct {
	// The region in which to create the Workspace.
	Location *string `pulumi:"location"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The user specified tags associated with the Workspace.
	Tags map[string]string `pulumi:"tags"`
	// The name of the workspace. Workspace names can only contain a combination of alphanumeric characters along with dash (-) and underscore (_). The name must be from 1 through 64 characters long.
	WorkspaceName string `pulumi:"workspaceName"`
}

// The set of arguments for constructing a Workspace resource.
type WorkspaceArgs struct {
	// The region in which to create the Workspace.
	Location pulumi.StringPtrInput
	// Name of the resource group to which the resource belongs.
	ResourceGroupName pulumi.StringInput
	// The user specified tags associated with the Workspace.
	Tags pulumi.StringMapInput
	// The name of the workspace. Workspace names can only contain a combination of alphanumeric characters along with dash (-) and underscore (_). The name must be from 1 through 64 characters long.
	WorkspaceName pulumi.StringInput
}

func (WorkspaceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*workspaceArgs)(nil)).Elem()
}

type WorkspaceInput interface {
	pulumi.Input

	ToWorkspaceOutput() WorkspaceOutput
	ToWorkspaceOutputWithContext(ctx context.Context) WorkspaceOutput
}

func (*Workspace) ElementType() reflect.Type {
	return reflect.TypeOf((*Workspace)(nil))
}

func (i *Workspace) ToWorkspaceOutput() WorkspaceOutput {
	return i.ToWorkspaceOutputWithContext(context.Background())
}

func (i *Workspace) ToWorkspaceOutputWithContext(ctx context.Context) WorkspaceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WorkspaceOutput)
}

type WorkspaceOutput struct {
	*pulumi.OutputState
}

func (WorkspaceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Workspace)(nil))
}

func (o WorkspaceOutput) ToWorkspaceOutput() WorkspaceOutput {
	return o
}

func (o WorkspaceOutput) ToWorkspaceOutputWithContext(ctx context.Context) WorkspaceOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(WorkspaceOutput{})
}
