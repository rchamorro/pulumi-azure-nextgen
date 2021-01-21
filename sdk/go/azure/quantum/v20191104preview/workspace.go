// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20191104preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The resource proxy definition object for quantum workspace.
type Workspace struct {
	pulumi.CustomResourceState

	// The URI of the workspace endpoint.
	EndpointUri pulumi.StringOutput `pulumi:"endpointUri"`
	// Managed Identity information.
	Identity QuantumWorkspaceResponseIdentityPtrOutput `pulumi:"identity"`
	// The geo-location where the resource lives
	Location pulumi.StringOutput `pulumi:"location"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// List of Providers selected for this Workspace
	Providers ProviderResponseArrayOutput `pulumi:"providers"`
	// Provisioning status field
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// ARM Resource Id of the storage account associated with this workspace.
	StorageAccount pulumi.StringPtrOutput `pulumi:"storageAccount"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
	// Whether the current workspace is ready to accept Jobs.
	Usable pulumi.StringOutput `pulumi:"usable"`
}

// NewWorkspace registers a new resource with the given unique name, arguments, and options.
func NewWorkspace(ctx *pulumi.Context,
	name string, args *WorkspaceArgs, opts ...pulumi.ResourceOption) (*Workspace, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Location == nil {
		return nil, errors.New("invalid value for required argument 'Location'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.WorkspaceName == nil {
		return nil, errors.New("invalid value for required argument 'WorkspaceName'")
	}
	var resource Workspace
	err := ctx.RegisterResource("azure-nextgen:quantum/v20191104preview:Workspace", name, args, &resource, opts...)
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
	err := ctx.ReadResource("azure-nextgen:quantum/v20191104preview:Workspace", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Workspace resources.
type workspaceState struct {
	// The URI of the workspace endpoint.
	EndpointUri *string `pulumi:"endpointUri"`
	// Managed Identity information.
	Identity *QuantumWorkspaceResponseIdentity `pulumi:"identity"`
	// The geo-location where the resource lives
	Location *string `pulumi:"location"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// List of Providers selected for this Workspace
	Providers []ProviderResponse `pulumi:"providers"`
	// Provisioning status field
	ProvisioningState *string `pulumi:"provisioningState"`
	// ARM Resource Id of the storage account associated with this workspace.
	StorageAccount *string `pulumi:"storageAccount"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
	// Whether the current workspace is ready to accept Jobs.
	Usable *string `pulumi:"usable"`
}

type WorkspaceState struct {
	// The URI of the workspace endpoint.
	EndpointUri pulumi.StringPtrInput
	// Managed Identity information.
	Identity QuantumWorkspaceResponseIdentityPtrInput
	// The geo-location where the resource lives
	Location pulumi.StringPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// List of Providers selected for this Workspace
	Providers ProviderResponseArrayInput
	// Provisioning status field
	ProvisioningState pulumi.StringPtrInput
	// ARM Resource Id of the storage account associated with this workspace.
	StorageAccount pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
	// Whether the current workspace is ready to accept Jobs.
	Usable pulumi.StringPtrInput
}

func (WorkspaceState) ElementType() reflect.Type {
	return reflect.TypeOf((*workspaceState)(nil)).Elem()
}

type workspaceArgs struct {
	// Managed Identity information.
	Identity *QuantumWorkspaceIdentity `pulumi:"identity"`
	// The geo-location where the resource lives
	Location string `pulumi:"location"`
	// List of Providers selected for this Workspace
	Providers []Provider `pulumi:"providers"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// ARM Resource Id of the storage account associated with this workspace.
	StorageAccount *string `pulumi:"storageAccount"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The name of the quantum workspace resource.
	WorkspaceName string `pulumi:"workspaceName"`
}

// The set of arguments for constructing a Workspace resource.
type WorkspaceArgs struct {
	// Managed Identity information.
	Identity QuantumWorkspaceIdentityPtrInput
	// The geo-location where the resource lives
	Location pulumi.StringInput
	// List of Providers selected for this Workspace
	Providers ProviderArrayInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// ARM Resource Id of the storage account associated with this workspace.
	StorageAccount pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The name of the quantum workspace resource.
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
