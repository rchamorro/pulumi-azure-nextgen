// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190601preview

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A workspace
type Workspace struct {
	pulumi.CustomResourceState

	// Babylon Configuration
	BabylonConfiguration BabylonConfigurationResponsePtrOutput `pulumi:"babylonConfiguration"`
	// Connectivity endpoints
	ConnectivityEndpoints pulumi.StringMapOutput `pulumi:"connectivityEndpoints"`
	// Workspace default data lake storage account details
	DefaultDataLakeStorage DataLakeStorageAccountDetailsResponsePtrOutput `pulumi:"defaultDataLakeStorage"`
	// The encryption details of the workspace
	Encryption EncryptionDetailsResponsePtrOutput `pulumi:"encryption"`
	// Workspace level configs and feature flags
	ExtraProperties pulumi.MapOutput `pulumi:"extraProperties"`
	// Identity of the workspace
	Identity ManagedIdentityResponsePtrOutput `pulumi:"identity"`
	// The geo-location where the resource lives
	Location pulumi.StringOutput `pulumi:"location"`
	// Workspace managed resource group. The resource group name uniquely identifies the resource group within the user subscriptionId. The resource group name must be no longer than 90 characters long, and must be alphanumeric characters (Char.IsLetterOrDigit()) and '-', '_', '(', ')' and'.'. Note that the name cannot end with '.'
	ManagedResourceGroupName pulumi.StringPtrOutput `pulumi:"managedResourceGroupName"`
	// Setting this to 'default' will ensure that all compute for this workspace is in a virtual network managed on behalf of the user.
	ManagedVirtualNetwork pulumi.StringPtrOutput `pulumi:"managedVirtualNetwork"`
	// Managed Virtual Network Settings
	ManagedVirtualNetworkSettings ManagedVirtualNetworkSettingsResponsePtrOutput `pulumi:"managedVirtualNetworkSettings"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// Private endpoint connections to the workspace
	PrivateEndpointConnections PrivateEndpointConnectionResponseArrayOutput `pulumi:"privateEndpointConnections"`
	// Resource provisioning state
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Login for workspace SQL active directory administrator
	SqlAdministratorLogin pulumi.StringPtrOutput `pulumi:"sqlAdministratorLogin"`
	// SQL administrator login password
	SqlAdministratorLoginPassword pulumi.StringPtrOutput `pulumi:"sqlAdministratorLoginPassword"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
	// Virtual Network profile
	VirtualNetworkProfile VirtualNetworkProfileResponsePtrOutput `pulumi:"virtualNetworkProfile"`
	// The workspace unique identifier
	WorkspaceUID pulumi.StringOutput `pulumi:"workspaceUID"`
}

// NewWorkspace registers a new resource with the given unique name, arguments, and options.
func NewWorkspace(ctx *pulumi.Context,
	name string, args *WorkspaceArgs, opts ...pulumi.ResourceOption) (*Workspace, error) {
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.WorkspaceName == nil {
		return nil, errors.New("missing required argument 'WorkspaceName'")
	}
	if args == nil {
		args = &WorkspaceArgs{}
	}
	var resource Workspace
	err := ctx.RegisterResource("azure-nextgen:synapse/v20190601preview:Workspace", name, args, &resource, opts...)
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
	err := ctx.ReadResource("azure-nextgen:synapse/v20190601preview:Workspace", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Workspace resources.
type workspaceState struct {
	// Babylon Configuration
	BabylonConfiguration *BabylonConfigurationResponse `pulumi:"babylonConfiguration"`
	// Connectivity endpoints
	ConnectivityEndpoints map[string]string `pulumi:"connectivityEndpoints"`
	// Workspace default data lake storage account details
	DefaultDataLakeStorage *DataLakeStorageAccountDetailsResponse `pulumi:"defaultDataLakeStorage"`
	// The encryption details of the workspace
	Encryption *EncryptionDetailsResponse `pulumi:"encryption"`
	// Workspace level configs and feature flags
	ExtraProperties map[string]interface{} `pulumi:"extraProperties"`
	// Identity of the workspace
	Identity *ManagedIdentityResponse `pulumi:"identity"`
	// The geo-location where the resource lives
	Location *string `pulumi:"location"`
	// Workspace managed resource group. The resource group name uniquely identifies the resource group within the user subscriptionId. The resource group name must be no longer than 90 characters long, and must be alphanumeric characters (Char.IsLetterOrDigit()) and '-', '_', '(', ')' and'.'. Note that the name cannot end with '.'
	ManagedResourceGroupName *string `pulumi:"managedResourceGroupName"`
	// Setting this to 'default' will ensure that all compute for this workspace is in a virtual network managed on behalf of the user.
	ManagedVirtualNetwork *string `pulumi:"managedVirtualNetwork"`
	// Managed Virtual Network Settings
	ManagedVirtualNetworkSettings *ManagedVirtualNetworkSettingsResponse `pulumi:"managedVirtualNetworkSettings"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// Private endpoint connections to the workspace
	PrivateEndpointConnections []PrivateEndpointConnectionResponse `pulumi:"privateEndpointConnections"`
	// Resource provisioning state
	ProvisioningState *string `pulumi:"provisioningState"`
	// Login for workspace SQL active directory administrator
	SqlAdministratorLogin *string `pulumi:"sqlAdministratorLogin"`
	// SQL administrator login password
	SqlAdministratorLoginPassword *string `pulumi:"sqlAdministratorLoginPassword"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
	// Virtual Network profile
	VirtualNetworkProfile *VirtualNetworkProfileResponse `pulumi:"virtualNetworkProfile"`
	// The workspace unique identifier
	WorkspaceUID *string `pulumi:"workspaceUID"`
}

type WorkspaceState struct {
	// Babylon Configuration
	BabylonConfiguration BabylonConfigurationResponsePtrInput
	// Connectivity endpoints
	ConnectivityEndpoints pulumi.StringMapInput
	// Workspace default data lake storage account details
	DefaultDataLakeStorage DataLakeStorageAccountDetailsResponsePtrInput
	// The encryption details of the workspace
	Encryption EncryptionDetailsResponsePtrInput
	// Workspace level configs and feature flags
	ExtraProperties pulumi.MapInput
	// Identity of the workspace
	Identity ManagedIdentityResponsePtrInput
	// The geo-location where the resource lives
	Location pulumi.StringPtrInput
	// Workspace managed resource group. The resource group name uniquely identifies the resource group within the user subscriptionId. The resource group name must be no longer than 90 characters long, and must be alphanumeric characters (Char.IsLetterOrDigit()) and '-', '_', '(', ')' and'.'. Note that the name cannot end with '.'
	ManagedResourceGroupName pulumi.StringPtrInput
	// Setting this to 'default' will ensure that all compute for this workspace is in a virtual network managed on behalf of the user.
	ManagedVirtualNetwork pulumi.StringPtrInput
	// Managed Virtual Network Settings
	ManagedVirtualNetworkSettings ManagedVirtualNetworkSettingsResponsePtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// Private endpoint connections to the workspace
	PrivateEndpointConnections PrivateEndpointConnectionResponseArrayInput
	// Resource provisioning state
	ProvisioningState pulumi.StringPtrInput
	// Login for workspace SQL active directory administrator
	SqlAdministratorLogin pulumi.StringPtrInput
	// SQL administrator login password
	SqlAdministratorLoginPassword pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
	// Virtual Network profile
	VirtualNetworkProfile VirtualNetworkProfileResponsePtrInput
	// The workspace unique identifier
	WorkspaceUID pulumi.StringPtrInput
}

func (WorkspaceState) ElementType() reflect.Type {
	return reflect.TypeOf((*workspaceState)(nil)).Elem()
}

type workspaceArgs struct {
	// Babylon Configuration
	BabylonConfiguration *BabylonConfiguration `pulumi:"babylonConfiguration"`
	// Connectivity endpoints
	ConnectivityEndpoints map[string]string `pulumi:"connectivityEndpoints"`
	// Workspace default data lake storage account details
	DefaultDataLakeStorage *DataLakeStorageAccountDetails `pulumi:"defaultDataLakeStorage"`
	// The encryption details of the workspace
	Encryption *EncryptionDetails `pulumi:"encryption"`
	// Identity of the workspace
	Identity *ManagedIdentity `pulumi:"identity"`
	// The geo-location where the resource lives
	Location string `pulumi:"location"`
	// Workspace managed resource group. The resource group name uniquely identifies the resource group within the user subscriptionId. The resource group name must be no longer than 90 characters long, and must be alphanumeric characters (Char.IsLetterOrDigit()) and '-', '_', '(', ')' and'.'. Note that the name cannot end with '.'
	ManagedResourceGroupName *string `pulumi:"managedResourceGroupName"`
	// Setting this to 'default' will ensure that all compute for this workspace is in a virtual network managed on behalf of the user.
	ManagedVirtualNetwork *string `pulumi:"managedVirtualNetwork"`
	// Managed Virtual Network Settings
	ManagedVirtualNetworkSettings *ManagedVirtualNetworkSettings `pulumi:"managedVirtualNetworkSettings"`
	// Private endpoint connections to the workspace
	PrivateEndpointConnections []PrivateEndpointConnectionType `pulumi:"privateEndpointConnections"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Login for workspace SQL active directory administrator
	SqlAdministratorLogin *string `pulumi:"sqlAdministratorLogin"`
	// SQL administrator login password
	SqlAdministratorLoginPassword *string `pulumi:"sqlAdministratorLoginPassword"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Virtual Network profile
	VirtualNetworkProfile *VirtualNetworkProfile `pulumi:"virtualNetworkProfile"`
	// The name of the workspace
	WorkspaceName string `pulumi:"workspaceName"`
}

// The set of arguments for constructing a Workspace resource.
type WorkspaceArgs struct {
	// Babylon Configuration
	BabylonConfiguration BabylonConfigurationPtrInput
	// Connectivity endpoints
	ConnectivityEndpoints pulumi.StringMapInput
	// Workspace default data lake storage account details
	DefaultDataLakeStorage DataLakeStorageAccountDetailsPtrInput
	// The encryption details of the workspace
	Encryption EncryptionDetailsPtrInput
	// Identity of the workspace
	Identity ManagedIdentityPtrInput
	// The geo-location where the resource lives
	Location pulumi.StringInput
	// Workspace managed resource group. The resource group name uniquely identifies the resource group within the user subscriptionId. The resource group name must be no longer than 90 characters long, and must be alphanumeric characters (Char.IsLetterOrDigit()) and '-', '_', '(', ')' and'.'. Note that the name cannot end with '.'
	ManagedResourceGroupName pulumi.StringPtrInput
	// Setting this to 'default' will ensure that all compute for this workspace is in a virtual network managed on behalf of the user.
	ManagedVirtualNetwork pulumi.StringPtrInput
	// Managed Virtual Network Settings
	ManagedVirtualNetworkSettings ManagedVirtualNetworkSettingsPtrInput
	// Private endpoint connections to the workspace
	PrivateEndpointConnections PrivateEndpointConnectionTypeArrayInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// Login for workspace SQL active directory administrator
	SqlAdministratorLogin pulumi.StringPtrInput
	// SQL administrator login password
	SqlAdministratorLoginPassword pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Virtual Network profile
	VirtualNetworkProfile VirtualNetworkProfilePtrInput
	// The name of the workspace
	WorkspaceName pulumi.StringInput
}

func (WorkspaceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*workspaceArgs)(nil)).Elem()
}
