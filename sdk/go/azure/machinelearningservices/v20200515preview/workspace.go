// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200515preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// An object that represents a machine learning workspace.
type Workspace struct {
	pulumi.CustomResourceState

	// The flag to indicate whether to allow public access when behind VNet.
	AllowPublicAccessWhenBehindVnet pulumi.BoolPtrOutput `pulumi:"allowPublicAccessWhenBehindVnet"`
	// ARM id of the application insights associated with this workspace. This cannot be changed once the workspace has been created
	ApplicationInsights pulumi.StringPtrOutput `pulumi:"applicationInsights"`
	// ARM id of the container registry associated with this workspace. This cannot be changed once the workspace has been created
	ContainerRegistry pulumi.StringPtrOutput `pulumi:"containerRegistry"`
	// The creation time of the machine learning workspace in ISO8601 format.
	CreationTime pulumi.StringOutput `pulumi:"creationTime"`
	// The description of this workspace.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Url for the discovery service to identify regional endpoints for machine learning experimentation services
	DiscoveryUrl pulumi.StringPtrOutput `pulumi:"discoveryUrl"`
	// The encryption settings of Azure ML workspace.
	Encryption EncryptionPropertyResponsePtrOutput `pulumi:"encryption"`
	// The friendly name for this workspace. This name in mutable
	FriendlyName pulumi.StringPtrOutput `pulumi:"friendlyName"`
	// The flag to signal HBI data in the workspace and reduce diagnostic data collected by the service
	HbiWorkspace pulumi.BoolPtrOutput `pulumi:"hbiWorkspace"`
	// The identity of the resource.
	Identity IdentityResponsePtrOutput `pulumi:"identity"`
	// The compute name for image build
	ImageBuildCompute pulumi.StringPtrOutput `pulumi:"imageBuildCompute"`
	// ARM id of the key vault associated with this workspace. This cannot be changed once the workspace has been created
	KeyVault pulumi.StringPtrOutput `pulumi:"keyVault"`
	// Specifies the location of the resource.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Specifies the name of the resource.
	Name pulumi.StringOutput `pulumi:"name"`
	// The list of private endpoint connections in the workspace.
	PrivateEndpointConnections PrivateEndpointConnectionResponseArrayOutput `pulumi:"privateEndpointConnections"`
	// Count of private connections in the workspace
	PrivateLinkCount pulumi.IntOutput `pulumi:"privateLinkCount"`
	// The current deployment state of workspace resource. The provisioningState is to indicate states for resource provisioning.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The name of the managed resource group created by workspace RP in customer subscription if the workspace is CMK workspace
	ServiceProvisionedResourceGroup pulumi.StringOutput `pulumi:"serviceProvisionedResourceGroup"`
	// The list of shared private link resources in this workspace.
	SharedPrivateLinkResources SharedPrivateLinkResourceResponseArrayOutput `pulumi:"sharedPrivateLinkResources"`
	// The sku of the workspace.
	Sku SkuResponsePtrOutput `pulumi:"sku"`
	// ARM id of the storage account associated with this workspace. This cannot be changed once the workspace has been created
	StorageAccount pulumi.StringPtrOutput `pulumi:"storageAccount"`
	// Contains resource tags defined as key/value pairs.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Specifies the type of the resource.
	Type pulumi.StringOutput `pulumi:"type"`
	// The immutable id associated with this workspace.
	WorkspaceId pulumi.StringOutput `pulumi:"workspaceId"`
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
	if args.AllowPublicAccessWhenBehindVnet == nil {
		args.AllowPublicAccessWhenBehindVnet = pulumi.BoolPtr(false)
	}
	if args.HbiWorkspace == nil {
		args.HbiWorkspace = pulumi.BoolPtr(false)
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:machinelearningservices/latest:Workspace"),
		},
		{
			Type: pulumi.String("azure-nextgen:machinelearningservices/v20180301preview:Workspace"),
		},
		{
			Type: pulumi.String("azure-nextgen:machinelearningservices/v20181119:Workspace"),
		},
		{
			Type: pulumi.String("azure-nextgen:machinelearningservices/v20190501:Workspace"),
		},
		{
			Type: pulumi.String("azure-nextgen:machinelearningservices/v20190601:Workspace"),
		},
		{
			Type: pulumi.String("azure-nextgen:machinelearningservices/v20191101:Workspace"),
		},
		{
			Type: pulumi.String("azure-nextgen:machinelearningservices/v20200101:Workspace"),
		},
		{
			Type: pulumi.String("azure-nextgen:machinelearningservices/v20200218preview:Workspace"),
		},
		{
			Type: pulumi.String("azure-nextgen:machinelearningservices/v20200301:Workspace"),
		},
		{
			Type: pulumi.String("azure-nextgen:machinelearningservices/v20200401:Workspace"),
		},
		{
			Type: pulumi.String("azure-nextgen:machinelearningservices/v20200501preview:Workspace"),
		},
		{
			Type: pulumi.String("azure-nextgen:machinelearningservices/v20200601:Workspace"),
		},
		{
			Type: pulumi.String("azure-nextgen:machinelearningservices/v20200801:Workspace"),
		},
		{
			Type: pulumi.String("azure-nextgen:machinelearningservices/v20200901preview:Workspace"),
		},
	})
	opts = append(opts, aliases)
	var resource Workspace
	err := ctx.RegisterResource("azure-nextgen:machinelearningservices/v20200515preview:Workspace", name, args, &resource, opts...)
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
	err := ctx.ReadResource("azure-nextgen:machinelearningservices/v20200515preview:Workspace", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Workspace resources.
type workspaceState struct {
	// The flag to indicate whether to allow public access when behind VNet.
	AllowPublicAccessWhenBehindVnet *bool `pulumi:"allowPublicAccessWhenBehindVnet"`
	// ARM id of the application insights associated with this workspace. This cannot be changed once the workspace has been created
	ApplicationInsights *string `pulumi:"applicationInsights"`
	// ARM id of the container registry associated with this workspace. This cannot be changed once the workspace has been created
	ContainerRegistry *string `pulumi:"containerRegistry"`
	// The creation time of the machine learning workspace in ISO8601 format.
	CreationTime *string `pulumi:"creationTime"`
	// The description of this workspace.
	Description *string `pulumi:"description"`
	// Url for the discovery service to identify regional endpoints for machine learning experimentation services
	DiscoveryUrl *string `pulumi:"discoveryUrl"`
	// The encryption settings of Azure ML workspace.
	Encryption *EncryptionPropertyResponse `pulumi:"encryption"`
	// The friendly name for this workspace. This name in mutable
	FriendlyName *string `pulumi:"friendlyName"`
	// The flag to signal HBI data in the workspace and reduce diagnostic data collected by the service
	HbiWorkspace *bool `pulumi:"hbiWorkspace"`
	// The identity of the resource.
	Identity *IdentityResponse `pulumi:"identity"`
	// The compute name for image build
	ImageBuildCompute *string `pulumi:"imageBuildCompute"`
	// ARM id of the key vault associated with this workspace. This cannot be changed once the workspace has been created
	KeyVault *string `pulumi:"keyVault"`
	// Specifies the location of the resource.
	Location *string `pulumi:"location"`
	// Specifies the name of the resource.
	Name *string `pulumi:"name"`
	// The list of private endpoint connections in the workspace.
	PrivateEndpointConnections []PrivateEndpointConnectionResponse `pulumi:"privateEndpointConnections"`
	// Count of private connections in the workspace
	PrivateLinkCount *int `pulumi:"privateLinkCount"`
	// The current deployment state of workspace resource. The provisioningState is to indicate states for resource provisioning.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The name of the managed resource group created by workspace RP in customer subscription if the workspace is CMK workspace
	ServiceProvisionedResourceGroup *string `pulumi:"serviceProvisionedResourceGroup"`
	// The list of shared private link resources in this workspace.
	SharedPrivateLinkResources []SharedPrivateLinkResourceResponse `pulumi:"sharedPrivateLinkResources"`
	// The sku of the workspace.
	Sku *SkuResponse `pulumi:"sku"`
	// ARM id of the storage account associated with this workspace. This cannot be changed once the workspace has been created
	StorageAccount *string `pulumi:"storageAccount"`
	// Contains resource tags defined as key/value pairs.
	Tags map[string]string `pulumi:"tags"`
	// Specifies the type of the resource.
	Type *string `pulumi:"type"`
	// The immutable id associated with this workspace.
	WorkspaceId *string `pulumi:"workspaceId"`
}

type WorkspaceState struct {
	// The flag to indicate whether to allow public access when behind VNet.
	AllowPublicAccessWhenBehindVnet pulumi.BoolPtrInput
	// ARM id of the application insights associated with this workspace. This cannot be changed once the workspace has been created
	ApplicationInsights pulumi.StringPtrInput
	// ARM id of the container registry associated with this workspace. This cannot be changed once the workspace has been created
	ContainerRegistry pulumi.StringPtrInput
	// The creation time of the machine learning workspace in ISO8601 format.
	CreationTime pulumi.StringPtrInput
	// The description of this workspace.
	Description pulumi.StringPtrInput
	// Url for the discovery service to identify regional endpoints for machine learning experimentation services
	DiscoveryUrl pulumi.StringPtrInput
	// The encryption settings of Azure ML workspace.
	Encryption EncryptionPropertyResponsePtrInput
	// The friendly name for this workspace. This name in mutable
	FriendlyName pulumi.StringPtrInput
	// The flag to signal HBI data in the workspace and reduce diagnostic data collected by the service
	HbiWorkspace pulumi.BoolPtrInput
	// The identity of the resource.
	Identity IdentityResponsePtrInput
	// The compute name for image build
	ImageBuildCompute pulumi.StringPtrInput
	// ARM id of the key vault associated with this workspace. This cannot be changed once the workspace has been created
	KeyVault pulumi.StringPtrInput
	// Specifies the location of the resource.
	Location pulumi.StringPtrInput
	// Specifies the name of the resource.
	Name pulumi.StringPtrInput
	// The list of private endpoint connections in the workspace.
	PrivateEndpointConnections PrivateEndpointConnectionResponseArrayInput
	// Count of private connections in the workspace
	PrivateLinkCount pulumi.IntPtrInput
	// The current deployment state of workspace resource. The provisioningState is to indicate states for resource provisioning.
	ProvisioningState pulumi.StringPtrInput
	// The name of the managed resource group created by workspace RP in customer subscription if the workspace is CMK workspace
	ServiceProvisionedResourceGroup pulumi.StringPtrInput
	// The list of shared private link resources in this workspace.
	SharedPrivateLinkResources SharedPrivateLinkResourceResponseArrayInput
	// The sku of the workspace.
	Sku SkuResponsePtrInput
	// ARM id of the storage account associated with this workspace. This cannot be changed once the workspace has been created
	StorageAccount pulumi.StringPtrInput
	// Contains resource tags defined as key/value pairs.
	Tags pulumi.StringMapInput
	// Specifies the type of the resource.
	Type pulumi.StringPtrInput
	// The immutable id associated with this workspace.
	WorkspaceId pulumi.StringPtrInput
}

func (WorkspaceState) ElementType() reflect.Type {
	return reflect.TypeOf((*workspaceState)(nil)).Elem()
}

type workspaceArgs struct {
	// The flag to indicate whether to allow public access when behind VNet.
	AllowPublicAccessWhenBehindVnet *bool `pulumi:"allowPublicAccessWhenBehindVnet"`
	// ARM id of the application insights associated with this workspace. This cannot be changed once the workspace has been created
	ApplicationInsights *string `pulumi:"applicationInsights"`
	// ARM id of the container registry associated with this workspace. This cannot be changed once the workspace has been created
	ContainerRegistry *string `pulumi:"containerRegistry"`
	// The description of this workspace.
	Description *string `pulumi:"description"`
	// Url for the discovery service to identify regional endpoints for machine learning experimentation services
	DiscoveryUrl *string `pulumi:"discoveryUrl"`
	// The encryption settings of Azure ML workspace.
	Encryption *EncryptionProperty `pulumi:"encryption"`
	// The friendly name for this workspace. This name in mutable
	FriendlyName *string `pulumi:"friendlyName"`
	// The flag to signal HBI data in the workspace and reduce diagnostic data collected by the service
	HbiWorkspace *bool `pulumi:"hbiWorkspace"`
	// The identity of the resource.
	Identity *Identity `pulumi:"identity"`
	// The compute name for image build
	ImageBuildCompute *string `pulumi:"imageBuildCompute"`
	// ARM id of the key vault associated with this workspace. This cannot be changed once the workspace has been created
	KeyVault *string `pulumi:"keyVault"`
	// Specifies the location of the resource.
	Location *string `pulumi:"location"`
	// Name of the resource group in which workspace is located.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The list of shared private link resources in this workspace.
	SharedPrivateLinkResources []SharedPrivateLinkResource `pulumi:"sharedPrivateLinkResources"`
	// The sku of the workspace.
	Sku *Sku `pulumi:"sku"`
	// ARM id of the storage account associated with this workspace. This cannot be changed once the workspace has been created
	StorageAccount *string `pulumi:"storageAccount"`
	// Contains resource tags defined as key/value pairs.
	Tags map[string]string `pulumi:"tags"`
	// Name of Azure Machine Learning workspace.
	WorkspaceName string `pulumi:"workspaceName"`
}

// The set of arguments for constructing a Workspace resource.
type WorkspaceArgs struct {
	// The flag to indicate whether to allow public access when behind VNet.
	AllowPublicAccessWhenBehindVnet pulumi.BoolPtrInput
	// ARM id of the application insights associated with this workspace. This cannot be changed once the workspace has been created
	ApplicationInsights pulumi.StringPtrInput
	// ARM id of the container registry associated with this workspace. This cannot be changed once the workspace has been created
	ContainerRegistry pulumi.StringPtrInput
	// The description of this workspace.
	Description pulumi.StringPtrInput
	// Url for the discovery service to identify regional endpoints for machine learning experimentation services
	DiscoveryUrl pulumi.StringPtrInput
	// The encryption settings of Azure ML workspace.
	Encryption EncryptionPropertyPtrInput
	// The friendly name for this workspace. This name in mutable
	FriendlyName pulumi.StringPtrInput
	// The flag to signal HBI data in the workspace and reduce diagnostic data collected by the service
	HbiWorkspace pulumi.BoolPtrInput
	// The identity of the resource.
	Identity IdentityPtrInput
	// The compute name for image build
	ImageBuildCompute pulumi.StringPtrInput
	// ARM id of the key vault associated with this workspace. This cannot be changed once the workspace has been created
	KeyVault pulumi.StringPtrInput
	// Specifies the location of the resource.
	Location pulumi.StringPtrInput
	// Name of the resource group in which workspace is located.
	ResourceGroupName pulumi.StringInput
	// The list of shared private link resources in this workspace.
	SharedPrivateLinkResources SharedPrivateLinkResourceArrayInput
	// The sku of the workspace.
	Sku SkuPtrInput
	// ARM id of the storage account associated with this workspace. This cannot be changed once the workspace has been created
	StorageAccount pulumi.StringPtrInput
	// Contains resource tags defined as key/value pairs.
	Tags pulumi.StringMapInput
	// Name of Azure Machine Learning workspace.
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
