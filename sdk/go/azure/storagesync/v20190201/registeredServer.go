// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190201

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Registered Server resource.
type RegisteredServer struct {
	pulumi.CustomResourceState

	// Registered Server Agent Version
	AgentVersion pulumi.StringPtrOutput `pulumi:"agentVersion"`
	// Registered Server clusterId
	ClusterId pulumi.StringPtrOutput `pulumi:"clusterId"`
	// Registered Server clusterName
	ClusterName pulumi.StringPtrOutput `pulumi:"clusterName"`
	// Resource discoveryEndpointUri
	DiscoveryEndpointUri pulumi.StringPtrOutput `pulumi:"discoveryEndpointUri"`
	// Friendly Name
	FriendlyName pulumi.StringPtrOutput `pulumi:"friendlyName"`
	// Registered Server last heart beat
	LastHeartBeat pulumi.StringPtrOutput `pulumi:"lastHeartBeat"`
	// Resource Last Operation Name
	LastOperationName pulumi.StringPtrOutput `pulumi:"lastOperationName"`
	// Registered Server lastWorkflowId
	LastWorkflowId pulumi.StringPtrOutput `pulumi:"lastWorkflowId"`
	// Management Endpoint Uri
	ManagementEndpointUri pulumi.StringPtrOutput `pulumi:"managementEndpointUri"`
	// Monitoring Configuration
	MonitoringConfiguration pulumi.StringPtrOutput `pulumi:"monitoringConfiguration"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// Registered Server Provisioning State
	ProvisioningState pulumi.StringPtrOutput `pulumi:"provisioningState"`
	// Resource Location
	ResourceLocation pulumi.StringPtrOutput `pulumi:"resourceLocation"`
	// Registered Server Certificate
	ServerCertificate pulumi.StringPtrOutput `pulumi:"serverCertificate"`
	// Registered Server serverId
	ServerId pulumi.StringPtrOutput `pulumi:"serverId"`
	// Registered Server Management Error Code
	ServerManagementErrorCode pulumi.IntPtrOutput `pulumi:"serverManagementErrorCode"`
	// Registered Server OS Version
	ServerOSVersion pulumi.StringPtrOutput `pulumi:"serverOSVersion"`
	// Registered Server serverRole
	ServerRole pulumi.StringPtrOutput `pulumi:"serverRole"`
	// Service Location
	ServiceLocation pulumi.StringPtrOutput `pulumi:"serviceLocation"`
	// Registered Server storageSyncServiceUid
	StorageSyncServiceUid pulumi.StringPtrOutput `pulumi:"storageSyncServiceUid"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewRegisteredServer registers a new resource with the given unique name, arguments, and options.
func NewRegisteredServer(ctx *pulumi.Context,
	name string, args *RegisteredServerArgs, opts ...pulumi.ResourceOption) (*RegisteredServer, error) {
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.ServerId == nil {
		return nil, errors.New("missing required argument 'ServerId'")
	}
	if args == nil || args.StorageSyncServiceName == nil {
		return nil, errors.New("missing required argument 'StorageSyncServiceName'")
	}
	if args == nil {
		args = &RegisteredServerArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:storagesync/latest:RegisteredServer"),
		},
		{
			Type: pulumi.String("azure-nextgen:storagesync/v20170605preview:RegisteredServer"),
		},
		{
			Type: pulumi.String("azure-nextgen:storagesync/v20180402:RegisteredServer"),
		},
		{
			Type: pulumi.String("azure-nextgen:storagesync/v20180701:RegisteredServer"),
		},
		{
			Type: pulumi.String("azure-nextgen:storagesync/v20181001:RegisteredServer"),
		},
		{
			Type: pulumi.String("azure-nextgen:storagesync/v20190301:RegisteredServer"),
		},
		{
			Type: pulumi.String("azure-nextgen:storagesync/v20190601:RegisteredServer"),
		},
		{
			Type: pulumi.String("azure-nextgen:storagesync/v20191001:RegisteredServer"),
		},
		{
			Type: pulumi.String("azure-nextgen:storagesync/v20200301:RegisteredServer"),
		},
		{
			Type: pulumi.String("azure-nextgen:storagesync/v20200901:RegisteredServer"),
		},
	})
	opts = append(opts, aliases)
	var resource RegisteredServer
	err := ctx.RegisterResource("azure-nextgen:storagesync/v20190201:RegisteredServer", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRegisteredServer gets an existing RegisteredServer resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRegisteredServer(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RegisteredServerState, opts ...pulumi.ResourceOption) (*RegisteredServer, error) {
	var resource RegisteredServer
	err := ctx.ReadResource("azure-nextgen:storagesync/v20190201:RegisteredServer", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RegisteredServer resources.
type registeredServerState struct {
	// Registered Server Agent Version
	AgentVersion *string `pulumi:"agentVersion"`
	// Registered Server clusterId
	ClusterId *string `pulumi:"clusterId"`
	// Registered Server clusterName
	ClusterName *string `pulumi:"clusterName"`
	// Resource discoveryEndpointUri
	DiscoveryEndpointUri *string `pulumi:"discoveryEndpointUri"`
	// Friendly Name
	FriendlyName *string `pulumi:"friendlyName"`
	// Registered Server last heart beat
	LastHeartBeat *string `pulumi:"lastHeartBeat"`
	// Resource Last Operation Name
	LastOperationName *string `pulumi:"lastOperationName"`
	// Registered Server lastWorkflowId
	LastWorkflowId *string `pulumi:"lastWorkflowId"`
	// Management Endpoint Uri
	ManagementEndpointUri *string `pulumi:"managementEndpointUri"`
	// Monitoring Configuration
	MonitoringConfiguration *string `pulumi:"monitoringConfiguration"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// Registered Server Provisioning State
	ProvisioningState *string `pulumi:"provisioningState"`
	// Resource Location
	ResourceLocation *string `pulumi:"resourceLocation"`
	// Registered Server Certificate
	ServerCertificate *string `pulumi:"serverCertificate"`
	// Registered Server serverId
	ServerId *string `pulumi:"serverId"`
	// Registered Server Management Error Code
	ServerManagementErrorCode *int `pulumi:"serverManagementErrorCode"`
	// Registered Server OS Version
	ServerOSVersion *string `pulumi:"serverOSVersion"`
	// Registered Server serverRole
	ServerRole *string `pulumi:"serverRole"`
	// Service Location
	ServiceLocation *string `pulumi:"serviceLocation"`
	// Registered Server storageSyncServiceUid
	StorageSyncServiceUid *string `pulumi:"storageSyncServiceUid"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
}

type RegisteredServerState struct {
	// Registered Server Agent Version
	AgentVersion pulumi.StringPtrInput
	// Registered Server clusterId
	ClusterId pulumi.StringPtrInput
	// Registered Server clusterName
	ClusterName pulumi.StringPtrInput
	// Resource discoveryEndpointUri
	DiscoveryEndpointUri pulumi.StringPtrInput
	// Friendly Name
	FriendlyName pulumi.StringPtrInput
	// Registered Server last heart beat
	LastHeartBeat pulumi.StringPtrInput
	// Resource Last Operation Name
	LastOperationName pulumi.StringPtrInput
	// Registered Server lastWorkflowId
	LastWorkflowId pulumi.StringPtrInput
	// Management Endpoint Uri
	ManagementEndpointUri pulumi.StringPtrInput
	// Monitoring Configuration
	MonitoringConfiguration pulumi.StringPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// Registered Server Provisioning State
	ProvisioningState pulumi.StringPtrInput
	// Resource Location
	ResourceLocation pulumi.StringPtrInput
	// Registered Server Certificate
	ServerCertificate pulumi.StringPtrInput
	// Registered Server serverId
	ServerId pulumi.StringPtrInput
	// Registered Server Management Error Code
	ServerManagementErrorCode pulumi.IntPtrInput
	// Registered Server OS Version
	ServerOSVersion pulumi.StringPtrInput
	// Registered Server serverRole
	ServerRole pulumi.StringPtrInput
	// Service Location
	ServiceLocation pulumi.StringPtrInput
	// Registered Server storageSyncServiceUid
	StorageSyncServiceUid pulumi.StringPtrInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
}

func (RegisteredServerState) ElementType() reflect.Type {
	return reflect.TypeOf((*registeredServerState)(nil)).Elem()
}

type registeredServerArgs struct {
	// Registered Server Agent Version
	AgentVersion *string `pulumi:"agentVersion"`
	// Registered Server clusterId
	ClusterId *string `pulumi:"clusterId"`
	// Registered Server clusterName
	ClusterName *string `pulumi:"clusterName"`
	// Friendly Name
	FriendlyName *string `pulumi:"friendlyName"`
	// Registered Server last heart beat
	LastHeartBeat *string `pulumi:"lastHeartBeat"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Registered Server Certificate
	ServerCertificate *string `pulumi:"serverCertificate"`
	// Registered Server serverId
	ServerId string `pulumi:"serverId"`
	// Registered Server OS Version
	ServerOSVersion *string `pulumi:"serverOSVersion"`
	// Registered Server serverRole
	ServerRole *string `pulumi:"serverRole"`
	// Name of Storage Sync Service resource.
	StorageSyncServiceName string `pulumi:"storageSyncServiceName"`
}

// The set of arguments for constructing a RegisteredServer resource.
type RegisteredServerArgs struct {
	// Registered Server Agent Version
	AgentVersion pulumi.StringPtrInput
	// Registered Server clusterId
	ClusterId pulumi.StringPtrInput
	// Registered Server clusterName
	ClusterName pulumi.StringPtrInput
	// Friendly Name
	FriendlyName pulumi.StringPtrInput
	// Registered Server last heart beat
	LastHeartBeat pulumi.StringPtrInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// Registered Server Certificate
	ServerCertificate pulumi.StringPtrInput
	// Registered Server serverId
	ServerId pulumi.StringInput
	// Registered Server OS Version
	ServerOSVersion pulumi.StringPtrInput
	// Registered Server serverRole
	ServerRole pulumi.StringPtrInput
	// Name of Storage Sync Service resource.
	StorageSyncServiceName pulumi.StringInput
}

func (RegisteredServerArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*registeredServerArgs)(nil)).Elem()
}

type RegisteredServerInput interface {
	pulumi.Input

	ToRegisteredServerOutput() RegisteredServerOutput
	ToRegisteredServerOutputWithContext(ctx context.Context) RegisteredServerOutput
}

func (RegisteredServer) ElementType() reflect.Type {
	return reflect.TypeOf((*RegisteredServer)(nil)).Elem()
}

func (i RegisteredServer) ToRegisteredServerOutput() RegisteredServerOutput {
	return i.ToRegisteredServerOutputWithContext(context.Background())
}

func (i RegisteredServer) ToRegisteredServerOutputWithContext(ctx context.Context) RegisteredServerOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RegisteredServerOutput)
}

type RegisteredServerOutput struct {
	*pulumi.OutputState
}

func (RegisteredServerOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*RegisteredServerOutput)(nil)).Elem()
}

func (o RegisteredServerOutput) ToRegisteredServerOutput() RegisteredServerOutput {
	return o
}

func (o RegisteredServerOutput) ToRegisteredServerOutputWithContext(ctx context.Context) RegisteredServerOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(RegisteredServerOutput{})
}
