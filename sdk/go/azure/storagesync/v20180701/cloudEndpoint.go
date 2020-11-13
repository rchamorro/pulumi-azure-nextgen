// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180701

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Cloud Endpoint object.
type CloudEndpoint struct {
	pulumi.CustomResourceState

	// Backup Enabled
	BackupEnabled pulumi.BoolOutput `pulumi:"backupEnabled"`
	// Friendly Name
	FriendlyName pulumi.StringPtrOutput `pulumi:"friendlyName"`
	// Resource Last Operation Name
	LastOperationName pulumi.StringPtrOutput `pulumi:"lastOperationName"`
	// CloudEndpoint lastWorkflowId
	LastWorkflowId pulumi.StringPtrOutput `pulumi:"lastWorkflowId"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// Partnership Id
	PartnershipId pulumi.StringPtrOutput `pulumi:"partnershipId"`
	// CloudEndpoint Provisioning State
	ProvisioningState pulumi.StringPtrOutput `pulumi:"provisioningState"`
	// Storage Account Resource Id
	StorageAccountResourceId pulumi.StringPtrOutput `pulumi:"storageAccountResourceId"`
	// Storage Account Share name
	StorageAccountShareName pulumi.StringPtrOutput `pulumi:"storageAccountShareName"`
	// Storage Account Tenant Id
	StorageAccountTenantId pulumi.StringPtrOutput `pulumi:"storageAccountTenantId"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewCloudEndpoint registers a new resource with the given unique name, arguments, and options.
func NewCloudEndpoint(ctx *pulumi.Context,
	name string, args *CloudEndpointArgs, opts ...pulumi.ResourceOption) (*CloudEndpoint, error) {
	if args == nil || args.CloudEndpointName == nil {
		return nil, errors.New("missing required argument 'CloudEndpointName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.StorageSyncServiceName == nil {
		return nil, errors.New("missing required argument 'StorageSyncServiceName'")
	}
	if args == nil || args.SyncGroupName == nil {
		return nil, errors.New("missing required argument 'SyncGroupName'")
	}
	if args == nil {
		args = &CloudEndpointArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:storagesync/latest:CloudEndpoint"),
		},
		{
			Type: pulumi.String("azure-nextgen:storagesync/v20170605preview:CloudEndpoint"),
		},
		{
			Type: pulumi.String("azure-nextgen:storagesync/v20180402:CloudEndpoint"),
		},
		{
			Type: pulumi.String("azure-nextgen:storagesync/v20181001:CloudEndpoint"),
		},
		{
			Type: pulumi.String("azure-nextgen:storagesync/v20190201:CloudEndpoint"),
		},
		{
			Type: pulumi.String("azure-nextgen:storagesync/v20190301:CloudEndpoint"),
		},
		{
			Type: pulumi.String("azure-nextgen:storagesync/v20190601:CloudEndpoint"),
		},
		{
			Type: pulumi.String("azure-nextgen:storagesync/v20191001:CloudEndpoint"),
		},
		{
			Type: pulumi.String("azure-nextgen:storagesync/v20200301:CloudEndpoint"),
		},
		{
			Type: pulumi.String("azure-nextgen:storagesync/v20200901:CloudEndpoint"),
		},
	})
	opts = append(opts, aliases)
	var resource CloudEndpoint
	err := ctx.RegisterResource("azure-nextgen:storagesync/v20180701:CloudEndpoint", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCloudEndpoint gets an existing CloudEndpoint resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCloudEndpoint(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CloudEndpointState, opts ...pulumi.ResourceOption) (*CloudEndpoint, error) {
	var resource CloudEndpoint
	err := ctx.ReadResource("azure-nextgen:storagesync/v20180701:CloudEndpoint", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CloudEndpoint resources.
type cloudEndpointState struct {
	// Backup Enabled
	BackupEnabled *bool `pulumi:"backupEnabled"`
	// Friendly Name
	FriendlyName *string `pulumi:"friendlyName"`
	// Resource Last Operation Name
	LastOperationName *string `pulumi:"lastOperationName"`
	// CloudEndpoint lastWorkflowId
	LastWorkflowId *string `pulumi:"lastWorkflowId"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// Partnership Id
	PartnershipId *string `pulumi:"partnershipId"`
	// CloudEndpoint Provisioning State
	ProvisioningState *string `pulumi:"provisioningState"`
	// Storage Account Resource Id
	StorageAccountResourceId *string `pulumi:"storageAccountResourceId"`
	// Storage Account Share name
	StorageAccountShareName *string `pulumi:"storageAccountShareName"`
	// Storage Account Tenant Id
	StorageAccountTenantId *string `pulumi:"storageAccountTenantId"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
}

type CloudEndpointState struct {
	// Backup Enabled
	BackupEnabled pulumi.BoolPtrInput
	// Friendly Name
	FriendlyName pulumi.StringPtrInput
	// Resource Last Operation Name
	LastOperationName pulumi.StringPtrInput
	// CloudEndpoint lastWorkflowId
	LastWorkflowId pulumi.StringPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// Partnership Id
	PartnershipId pulumi.StringPtrInput
	// CloudEndpoint Provisioning State
	ProvisioningState pulumi.StringPtrInput
	// Storage Account Resource Id
	StorageAccountResourceId pulumi.StringPtrInput
	// Storage Account Share name
	StorageAccountShareName pulumi.StringPtrInput
	// Storage Account Tenant Id
	StorageAccountTenantId pulumi.StringPtrInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
}

func (CloudEndpointState) ElementType() reflect.Type {
	return reflect.TypeOf((*cloudEndpointState)(nil)).Elem()
}

type cloudEndpointArgs struct {
	// Name of Cloud Endpoint object.
	CloudEndpointName string `pulumi:"cloudEndpointName"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Storage Account Resource Id
	StorageAccountResourceId *string `pulumi:"storageAccountResourceId"`
	// Storage Account Share name
	StorageAccountShareName *string `pulumi:"storageAccountShareName"`
	// Storage Account Tenant Id
	StorageAccountTenantId *string `pulumi:"storageAccountTenantId"`
	// Name of Storage Sync Service resource.
	StorageSyncServiceName string `pulumi:"storageSyncServiceName"`
	// Name of Sync Group resource.
	SyncGroupName string `pulumi:"syncGroupName"`
}

// The set of arguments for constructing a CloudEndpoint resource.
type CloudEndpointArgs struct {
	// Name of Cloud Endpoint object.
	CloudEndpointName pulumi.StringInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// Storage Account Resource Id
	StorageAccountResourceId pulumi.StringPtrInput
	// Storage Account Share name
	StorageAccountShareName pulumi.StringPtrInput
	// Storage Account Tenant Id
	StorageAccountTenantId pulumi.StringPtrInput
	// Name of Storage Sync Service resource.
	StorageSyncServiceName pulumi.StringInput
	// Name of Sync Group resource.
	SyncGroupName pulumi.StringInput
}

func (CloudEndpointArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*cloudEndpointArgs)(nil)).Elem()
}

type CloudEndpointInput interface {
	pulumi.Input

	ToCloudEndpointOutput() CloudEndpointOutput
	ToCloudEndpointOutputWithContext(ctx context.Context) CloudEndpointOutput
}

func (CloudEndpoint) ElementType() reflect.Type {
	return reflect.TypeOf((*CloudEndpoint)(nil)).Elem()
}

func (i CloudEndpoint) ToCloudEndpointOutput() CloudEndpointOutput {
	return i.ToCloudEndpointOutputWithContext(context.Background())
}

func (i CloudEndpoint) ToCloudEndpointOutputWithContext(ctx context.Context) CloudEndpointOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CloudEndpointOutput)
}

type CloudEndpointOutput struct {
	*pulumi.OutputState
}

func (CloudEndpointOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*CloudEndpointOutput)(nil)).Elem()
}

func (o CloudEndpointOutput) ToCloudEndpointOutput() CloudEndpointOutput {
	return o
}

func (o CloudEndpointOutput) ToCloudEndpointOutputWithContext(ctx context.Context) CloudEndpointOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(CloudEndpointOutput{})
}
