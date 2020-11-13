// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20170901

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Contains information about a pool.
type Pool struct {
	pulumi.CustomResourceState

	// Values are:
	//
	//  Steady - The pool is not resizing. There are no changes to the number of nodes in the pool in progress. A pool enters this state when it is created and when no operations are being performed on the pool to change the number of dedicated nodes.
	//  Resizing - The pool is resizing; that is, compute nodes are being added to or removed from the pool.
	//  Stopping - The pool was resizing, but the user has requested that the resize be stopped, but the stop request has not yet been completed.
	AllocationState               pulumi.StringOutput `pulumi:"allocationState"`
	AllocationStateTransitionTime pulumi.StringOutput `pulumi:"allocationStateTransitionTime"`
	// The list of application licenses must be a subset of available Batch service application licenses. If a license is requested which is not supported, pool creation will fail.
	ApplicationLicenses pulumi.StringArrayOutput `pulumi:"applicationLicenses"`
	// Changes to application packages affect all new compute nodes joining the pool, but do not affect compute nodes that are already in the pool until they are rebooted or reimaged.
	ApplicationPackages ApplicationPackageReferenceResponseArrayOutput `pulumi:"applicationPackages"`
	// This property is set only if the pool automatically scales, i.e. autoScaleSettings are used.
	AutoScaleRun AutoScaleRunResponseOutput `pulumi:"autoScaleRun"`
	// For Windows compute nodes, the Batch service installs the certificates to the specified certificate store and location. For Linux compute nodes, the certificates are stored in a directory inside the task working directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is supplied to the task to query for this location. For certificates with visibility of 'remoteUser', a 'certs' directory is created in the user's home directory (e.g., /home/{user-name}/certs) and certificates are placed in that directory.
	Certificates            CertificateReferenceResponseArrayOutput `pulumi:"certificates"`
	CreationTime            pulumi.StringOutput                     `pulumi:"creationTime"`
	CurrentDedicatedNodes   pulumi.IntOutput                        `pulumi:"currentDedicatedNodes"`
	CurrentLowPriorityNodes pulumi.IntOutput                        `pulumi:"currentLowPriorityNodes"`
	// Using CloudServiceConfiguration specifies that the nodes should be creating using Azure Cloud Services (PaaS), while VirtualMachineConfiguration uses Azure Virtual Machines (IaaS).
	DeploymentConfiguration DeploymentConfigurationResponsePtrOutput `pulumi:"deploymentConfiguration"`
	// The display name need not be unique and can contain any Unicode characters up to a maximum length of 1024.
	DisplayName pulumi.StringPtrOutput `pulumi:"displayName"`
	// The ETag of the resource, used for concurrency statements.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// This imposes restrictions on which nodes can be assigned to the pool. Enabling this value can reduce the chance of the requested number of nodes to be allocated in the pool. If not specified, this value defaults to 'Disabled'.
	InterNodeCommunication pulumi.StringPtrOutput `pulumi:"interNodeCommunication"`
	// This is the last time at which the pool level data, such as the targetDedicatedNodes or autoScaleSettings, changed. It does not factor in node-level changes such as a compute node changing state.
	LastModified    pulumi.StringOutput `pulumi:"lastModified"`
	MaxTasksPerNode pulumi.IntPtrOutput `pulumi:"maxTasksPerNode"`
	// The Batch service does not assign any meaning to metadata; it is solely for the use of user code.
	Metadata MetadataItemResponseArrayOutput `pulumi:"metadata"`
	// The name of the resource.
	Name pulumi.StringOutput `pulumi:"name"`
	// The network configuration for a pool.
	NetworkConfiguration NetworkConfigurationResponsePtrOutput `pulumi:"networkConfiguration"`
	// Values are:
	//
	//  Succeeded - The pool is available to run tasks subject to the availability of compute nodes.
	//  Deleting - The user has requested that the pool be deleted, but the delete operation has not yet completed.
	ProvisioningState               pulumi.StringOutput `pulumi:"provisioningState"`
	ProvisioningStateTransitionTime pulumi.StringOutput `pulumi:"provisioningStateTransitionTime"`
	// Describes either the current operation (if the pool AllocationState is Resizing) or the previously completed operation (if the AllocationState is Steady).
	ResizeOperationStatus ResizeOperationStatusResponseOutput `pulumi:"resizeOperationStatus"`
	// Defines the desired size of the pool. This can either be 'fixedScale' where the requested targetDedicatedNodes is specified, or 'autoScale' which defines a formula which is periodically reevaluated. If this property is not specified, the pool will have a fixed scale with 0 targetDedicatedNodes.
	ScaleSettings ScaleSettingsResponsePtrOutput `pulumi:"scaleSettings"`
	// In an PATCH (update) operation, this property can be set to an empty object to remove the start task from the pool.
	StartTask            StartTaskResponsePtrOutput            `pulumi:"startTask"`
	TaskSchedulingPolicy TaskSchedulingPolicyResponsePtrOutput `pulumi:"taskSchedulingPolicy"`
	// The type of the resource.
	Type         pulumi.StringOutput            `pulumi:"type"`
	UserAccounts UserAccountResponseArrayOutput `pulumi:"userAccounts"`
	// For information about available sizes of virtual machines for Cloud Services pools (pools created with cloudServiceConfiguration), see Sizes for Cloud Services (https://azure.microsoft.com/documentation/articles/cloud-services-sizes-specs/). Batch supports all Cloud Services VM sizes except ExtraSmall. For information about available VM sizes for pools using images from the Virtual Machines Marketplace (pools created with virtualMachineConfiguration) see Sizes for Virtual Machines (Linux) (https://azure.microsoft.com/documentation/articles/virtual-machines-linux-sizes/) or Sizes for Virtual Machines (Windows) (https://azure.microsoft.com/documentation/articles/virtual-machines-windows-sizes/). Batch supports all Azure VM sizes except STANDARD_A0 and those with premium storage (STANDARD_GS, STANDARD_DS, and STANDARD_DSV2 series).
	VmSize pulumi.StringPtrOutput `pulumi:"vmSize"`
}

// NewPool registers a new resource with the given unique name, arguments, and options.
func NewPool(ctx *pulumi.Context,
	name string, args *PoolArgs, opts ...pulumi.ResourceOption) (*Pool, error) {
	if args == nil || args.AccountName == nil {
		return nil, errors.New("missing required argument 'AccountName'")
	}
	if args == nil || args.PoolName == nil {
		return nil, errors.New("missing required argument 'PoolName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &PoolArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:batch/latest:Pool"),
		},
		{
			Type: pulumi.String("azure-nextgen:batch/v20181201:Pool"),
		},
		{
			Type: pulumi.String("azure-nextgen:batch/v20190401:Pool"),
		},
		{
			Type: pulumi.String("azure-nextgen:batch/v20190801:Pool"),
		},
		{
			Type: pulumi.String("azure-nextgen:batch/v20200301:Pool"),
		},
		{
			Type: pulumi.String("azure-nextgen:batch/v20200501:Pool"),
		},
		{
			Type: pulumi.String("azure-nextgen:batch/v20200901:Pool"),
		},
	})
	opts = append(opts, aliases)
	var resource Pool
	err := ctx.RegisterResource("azure-nextgen:batch/v20170901:Pool", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPool gets an existing Pool resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPool(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PoolState, opts ...pulumi.ResourceOption) (*Pool, error) {
	var resource Pool
	err := ctx.ReadResource("azure-nextgen:batch/v20170901:Pool", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Pool resources.
type poolState struct {
	// Values are:
	//
	//  Steady - The pool is not resizing. There are no changes to the number of nodes in the pool in progress. A pool enters this state when it is created and when no operations are being performed on the pool to change the number of dedicated nodes.
	//  Resizing - The pool is resizing; that is, compute nodes are being added to or removed from the pool.
	//  Stopping - The pool was resizing, but the user has requested that the resize be stopped, but the stop request has not yet been completed.
	AllocationState               *string `pulumi:"allocationState"`
	AllocationStateTransitionTime *string `pulumi:"allocationStateTransitionTime"`
	// The list of application licenses must be a subset of available Batch service application licenses. If a license is requested which is not supported, pool creation will fail.
	ApplicationLicenses []string `pulumi:"applicationLicenses"`
	// Changes to application packages affect all new compute nodes joining the pool, but do not affect compute nodes that are already in the pool until they are rebooted or reimaged.
	ApplicationPackages []ApplicationPackageReferenceResponse `pulumi:"applicationPackages"`
	// This property is set only if the pool automatically scales, i.e. autoScaleSettings are used.
	AutoScaleRun *AutoScaleRunResponse `pulumi:"autoScaleRun"`
	// For Windows compute nodes, the Batch service installs the certificates to the specified certificate store and location. For Linux compute nodes, the certificates are stored in a directory inside the task working directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is supplied to the task to query for this location. For certificates with visibility of 'remoteUser', a 'certs' directory is created in the user's home directory (e.g., /home/{user-name}/certs) and certificates are placed in that directory.
	Certificates            []CertificateReferenceResponse `pulumi:"certificates"`
	CreationTime            *string                        `pulumi:"creationTime"`
	CurrentDedicatedNodes   *int                           `pulumi:"currentDedicatedNodes"`
	CurrentLowPriorityNodes *int                           `pulumi:"currentLowPriorityNodes"`
	// Using CloudServiceConfiguration specifies that the nodes should be creating using Azure Cloud Services (PaaS), while VirtualMachineConfiguration uses Azure Virtual Machines (IaaS).
	DeploymentConfiguration *DeploymentConfigurationResponse `pulumi:"deploymentConfiguration"`
	// The display name need not be unique and can contain any Unicode characters up to a maximum length of 1024.
	DisplayName *string `pulumi:"displayName"`
	// The ETag of the resource, used for concurrency statements.
	Etag *string `pulumi:"etag"`
	// This imposes restrictions on which nodes can be assigned to the pool. Enabling this value can reduce the chance of the requested number of nodes to be allocated in the pool. If not specified, this value defaults to 'Disabled'.
	InterNodeCommunication *string `pulumi:"interNodeCommunication"`
	// This is the last time at which the pool level data, such as the targetDedicatedNodes or autoScaleSettings, changed. It does not factor in node-level changes such as a compute node changing state.
	LastModified    *string `pulumi:"lastModified"`
	MaxTasksPerNode *int    `pulumi:"maxTasksPerNode"`
	// The Batch service does not assign any meaning to metadata; it is solely for the use of user code.
	Metadata []MetadataItemResponse `pulumi:"metadata"`
	// The name of the resource.
	Name *string `pulumi:"name"`
	// The network configuration for a pool.
	NetworkConfiguration *NetworkConfigurationResponse `pulumi:"networkConfiguration"`
	// Values are:
	//
	//  Succeeded - The pool is available to run tasks subject to the availability of compute nodes.
	//  Deleting - The user has requested that the pool be deleted, but the delete operation has not yet completed.
	ProvisioningState               *string `pulumi:"provisioningState"`
	ProvisioningStateTransitionTime *string `pulumi:"provisioningStateTransitionTime"`
	// Describes either the current operation (if the pool AllocationState is Resizing) or the previously completed operation (if the AllocationState is Steady).
	ResizeOperationStatus *ResizeOperationStatusResponse `pulumi:"resizeOperationStatus"`
	// Defines the desired size of the pool. This can either be 'fixedScale' where the requested targetDedicatedNodes is specified, or 'autoScale' which defines a formula which is periodically reevaluated. If this property is not specified, the pool will have a fixed scale with 0 targetDedicatedNodes.
	ScaleSettings *ScaleSettingsResponse `pulumi:"scaleSettings"`
	// In an PATCH (update) operation, this property can be set to an empty object to remove the start task from the pool.
	StartTask            *StartTaskResponse            `pulumi:"startTask"`
	TaskSchedulingPolicy *TaskSchedulingPolicyResponse `pulumi:"taskSchedulingPolicy"`
	// The type of the resource.
	Type         *string               `pulumi:"type"`
	UserAccounts []UserAccountResponse `pulumi:"userAccounts"`
	// For information about available sizes of virtual machines for Cloud Services pools (pools created with cloudServiceConfiguration), see Sizes for Cloud Services (https://azure.microsoft.com/documentation/articles/cloud-services-sizes-specs/). Batch supports all Cloud Services VM sizes except ExtraSmall. For information about available VM sizes for pools using images from the Virtual Machines Marketplace (pools created with virtualMachineConfiguration) see Sizes for Virtual Machines (Linux) (https://azure.microsoft.com/documentation/articles/virtual-machines-linux-sizes/) or Sizes for Virtual Machines (Windows) (https://azure.microsoft.com/documentation/articles/virtual-machines-windows-sizes/). Batch supports all Azure VM sizes except STANDARD_A0 and those with premium storage (STANDARD_GS, STANDARD_DS, and STANDARD_DSV2 series).
	VmSize *string `pulumi:"vmSize"`
}

type PoolState struct {
	// Values are:
	//
	//  Steady - The pool is not resizing. There are no changes to the number of nodes in the pool in progress. A pool enters this state when it is created and when no operations are being performed on the pool to change the number of dedicated nodes.
	//  Resizing - The pool is resizing; that is, compute nodes are being added to or removed from the pool.
	//  Stopping - The pool was resizing, but the user has requested that the resize be stopped, but the stop request has not yet been completed.
	AllocationState               pulumi.StringPtrInput
	AllocationStateTransitionTime pulumi.StringPtrInput
	// The list of application licenses must be a subset of available Batch service application licenses. If a license is requested which is not supported, pool creation will fail.
	ApplicationLicenses pulumi.StringArrayInput
	// Changes to application packages affect all new compute nodes joining the pool, but do not affect compute nodes that are already in the pool until they are rebooted or reimaged.
	ApplicationPackages ApplicationPackageReferenceResponseArrayInput
	// This property is set only if the pool automatically scales, i.e. autoScaleSettings are used.
	AutoScaleRun AutoScaleRunResponsePtrInput
	// For Windows compute nodes, the Batch service installs the certificates to the specified certificate store and location. For Linux compute nodes, the certificates are stored in a directory inside the task working directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is supplied to the task to query for this location. For certificates with visibility of 'remoteUser', a 'certs' directory is created in the user's home directory (e.g., /home/{user-name}/certs) and certificates are placed in that directory.
	Certificates            CertificateReferenceResponseArrayInput
	CreationTime            pulumi.StringPtrInput
	CurrentDedicatedNodes   pulumi.IntPtrInput
	CurrentLowPriorityNodes pulumi.IntPtrInput
	// Using CloudServiceConfiguration specifies that the nodes should be creating using Azure Cloud Services (PaaS), while VirtualMachineConfiguration uses Azure Virtual Machines (IaaS).
	DeploymentConfiguration DeploymentConfigurationResponsePtrInput
	// The display name need not be unique and can contain any Unicode characters up to a maximum length of 1024.
	DisplayName pulumi.StringPtrInput
	// The ETag of the resource, used for concurrency statements.
	Etag pulumi.StringPtrInput
	// This imposes restrictions on which nodes can be assigned to the pool. Enabling this value can reduce the chance of the requested number of nodes to be allocated in the pool. If not specified, this value defaults to 'Disabled'.
	InterNodeCommunication pulumi.StringPtrInput
	// This is the last time at which the pool level data, such as the targetDedicatedNodes or autoScaleSettings, changed. It does not factor in node-level changes such as a compute node changing state.
	LastModified    pulumi.StringPtrInput
	MaxTasksPerNode pulumi.IntPtrInput
	// The Batch service does not assign any meaning to metadata; it is solely for the use of user code.
	Metadata MetadataItemResponseArrayInput
	// The name of the resource.
	Name pulumi.StringPtrInput
	// The network configuration for a pool.
	NetworkConfiguration NetworkConfigurationResponsePtrInput
	// Values are:
	//
	//  Succeeded - The pool is available to run tasks subject to the availability of compute nodes.
	//  Deleting - The user has requested that the pool be deleted, but the delete operation has not yet completed.
	ProvisioningState               pulumi.StringPtrInput
	ProvisioningStateTransitionTime pulumi.StringPtrInput
	// Describes either the current operation (if the pool AllocationState is Resizing) or the previously completed operation (if the AllocationState is Steady).
	ResizeOperationStatus ResizeOperationStatusResponsePtrInput
	// Defines the desired size of the pool. This can either be 'fixedScale' where the requested targetDedicatedNodes is specified, or 'autoScale' which defines a formula which is periodically reevaluated. If this property is not specified, the pool will have a fixed scale with 0 targetDedicatedNodes.
	ScaleSettings ScaleSettingsResponsePtrInput
	// In an PATCH (update) operation, this property can be set to an empty object to remove the start task from the pool.
	StartTask            StartTaskResponsePtrInput
	TaskSchedulingPolicy TaskSchedulingPolicyResponsePtrInput
	// The type of the resource.
	Type         pulumi.StringPtrInput
	UserAccounts UserAccountResponseArrayInput
	// For information about available sizes of virtual machines for Cloud Services pools (pools created with cloudServiceConfiguration), see Sizes for Cloud Services (https://azure.microsoft.com/documentation/articles/cloud-services-sizes-specs/). Batch supports all Cloud Services VM sizes except ExtraSmall. For information about available VM sizes for pools using images from the Virtual Machines Marketplace (pools created with virtualMachineConfiguration) see Sizes for Virtual Machines (Linux) (https://azure.microsoft.com/documentation/articles/virtual-machines-linux-sizes/) or Sizes for Virtual Machines (Windows) (https://azure.microsoft.com/documentation/articles/virtual-machines-windows-sizes/). Batch supports all Azure VM sizes except STANDARD_A0 and those with premium storage (STANDARD_GS, STANDARD_DS, and STANDARD_DSV2 series).
	VmSize pulumi.StringPtrInput
}

func (PoolState) ElementType() reflect.Type {
	return reflect.TypeOf((*poolState)(nil)).Elem()
}

type poolArgs struct {
	// The name of the Batch account.
	AccountName string `pulumi:"accountName"`
	// The list of application licenses must be a subset of available Batch service application licenses. If a license is requested which is not supported, pool creation will fail.
	ApplicationLicenses []string `pulumi:"applicationLicenses"`
	// Changes to application packages affect all new compute nodes joining the pool, but do not affect compute nodes that are already in the pool until they are rebooted or reimaged.
	ApplicationPackages []ApplicationPackageReference `pulumi:"applicationPackages"`
	// For Windows compute nodes, the Batch service installs the certificates to the specified certificate store and location. For Linux compute nodes, the certificates are stored in a directory inside the task working directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is supplied to the task to query for this location. For certificates with visibility of 'remoteUser', a 'certs' directory is created in the user's home directory (e.g., /home/{user-name}/certs) and certificates are placed in that directory.
	Certificates []CertificateReference `pulumi:"certificates"`
	// Using CloudServiceConfiguration specifies that the nodes should be creating using Azure Cloud Services (PaaS), while VirtualMachineConfiguration uses Azure Virtual Machines (IaaS).
	DeploymentConfiguration *DeploymentConfiguration `pulumi:"deploymentConfiguration"`
	// The display name need not be unique and can contain any Unicode characters up to a maximum length of 1024.
	DisplayName *string `pulumi:"displayName"`
	// This imposes restrictions on which nodes can be assigned to the pool. Enabling this value can reduce the chance of the requested number of nodes to be allocated in the pool. If not specified, this value defaults to 'Disabled'.
	InterNodeCommunication *string `pulumi:"interNodeCommunication"`
	MaxTasksPerNode        *int    `pulumi:"maxTasksPerNode"`
	// The Batch service does not assign any meaning to metadata; it is solely for the use of user code.
	Metadata []MetadataItem `pulumi:"metadata"`
	// The network configuration for a pool.
	NetworkConfiguration *NetworkConfiguration `pulumi:"networkConfiguration"`
	// The pool name. This must be unique within the account.
	PoolName string `pulumi:"poolName"`
	// The name of the resource group that contains the Batch account.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Defines the desired size of the pool. This can either be 'fixedScale' where the requested targetDedicatedNodes is specified, or 'autoScale' which defines a formula which is periodically reevaluated. If this property is not specified, the pool will have a fixed scale with 0 targetDedicatedNodes.
	ScaleSettings *ScaleSettings `pulumi:"scaleSettings"`
	// In an PATCH (update) operation, this property can be set to an empty object to remove the start task from the pool.
	StartTask            *StartTask            `pulumi:"startTask"`
	TaskSchedulingPolicy *TaskSchedulingPolicy `pulumi:"taskSchedulingPolicy"`
	UserAccounts         []UserAccount         `pulumi:"userAccounts"`
	// For information about available sizes of virtual machines for Cloud Services pools (pools created with cloudServiceConfiguration), see Sizes for Cloud Services (https://azure.microsoft.com/documentation/articles/cloud-services-sizes-specs/). Batch supports all Cloud Services VM sizes except ExtraSmall. For information about available VM sizes for pools using images from the Virtual Machines Marketplace (pools created with virtualMachineConfiguration) see Sizes for Virtual Machines (Linux) (https://azure.microsoft.com/documentation/articles/virtual-machines-linux-sizes/) or Sizes for Virtual Machines (Windows) (https://azure.microsoft.com/documentation/articles/virtual-machines-windows-sizes/). Batch supports all Azure VM sizes except STANDARD_A0 and those with premium storage (STANDARD_GS, STANDARD_DS, and STANDARD_DSV2 series).
	VmSize *string `pulumi:"vmSize"`
}

// The set of arguments for constructing a Pool resource.
type PoolArgs struct {
	// The name of the Batch account.
	AccountName pulumi.StringInput
	// The list of application licenses must be a subset of available Batch service application licenses. If a license is requested which is not supported, pool creation will fail.
	ApplicationLicenses pulumi.StringArrayInput
	// Changes to application packages affect all new compute nodes joining the pool, but do not affect compute nodes that are already in the pool until they are rebooted or reimaged.
	ApplicationPackages ApplicationPackageReferenceArrayInput
	// For Windows compute nodes, the Batch service installs the certificates to the specified certificate store and location. For Linux compute nodes, the certificates are stored in a directory inside the task working directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is supplied to the task to query for this location. For certificates with visibility of 'remoteUser', a 'certs' directory is created in the user's home directory (e.g., /home/{user-name}/certs) and certificates are placed in that directory.
	Certificates CertificateReferenceArrayInput
	// Using CloudServiceConfiguration specifies that the nodes should be creating using Azure Cloud Services (PaaS), while VirtualMachineConfiguration uses Azure Virtual Machines (IaaS).
	DeploymentConfiguration DeploymentConfigurationPtrInput
	// The display name need not be unique and can contain any Unicode characters up to a maximum length of 1024.
	DisplayName pulumi.StringPtrInput
	// This imposes restrictions on which nodes can be assigned to the pool. Enabling this value can reduce the chance of the requested number of nodes to be allocated in the pool. If not specified, this value defaults to 'Disabled'.
	InterNodeCommunication pulumi.StringPtrInput
	MaxTasksPerNode        pulumi.IntPtrInput
	// The Batch service does not assign any meaning to metadata; it is solely for the use of user code.
	Metadata MetadataItemArrayInput
	// The network configuration for a pool.
	NetworkConfiguration NetworkConfigurationPtrInput
	// The pool name. This must be unique within the account.
	PoolName pulumi.StringInput
	// The name of the resource group that contains the Batch account.
	ResourceGroupName pulumi.StringInput
	// Defines the desired size of the pool. This can either be 'fixedScale' where the requested targetDedicatedNodes is specified, or 'autoScale' which defines a formula which is periodically reevaluated. If this property is not specified, the pool will have a fixed scale with 0 targetDedicatedNodes.
	ScaleSettings ScaleSettingsPtrInput
	// In an PATCH (update) operation, this property can be set to an empty object to remove the start task from the pool.
	StartTask            StartTaskPtrInput
	TaskSchedulingPolicy TaskSchedulingPolicyPtrInput
	UserAccounts         UserAccountArrayInput
	// For information about available sizes of virtual machines for Cloud Services pools (pools created with cloudServiceConfiguration), see Sizes for Cloud Services (https://azure.microsoft.com/documentation/articles/cloud-services-sizes-specs/). Batch supports all Cloud Services VM sizes except ExtraSmall. For information about available VM sizes for pools using images from the Virtual Machines Marketplace (pools created with virtualMachineConfiguration) see Sizes for Virtual Machines (Linux) (https://azure.microsoft.com/documentation/articles/virtual-machines-linux-sizes/) or Sizes for Virtual Machines (Windows) (https://azure.microsoft.com/documentation/articles/virtual-machines-windows-sizes/). Batch supports all Azure VM sizes except STANDARD_A0 and those with premium storage (STANDARD_GS, STANDARD_DS, and STANDARD_DSV2 series).
	VmSize pulumi.StringPtrInput
}

func (PoolArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*poolArgs)(nil)).Elem()
}

type PoolInput interface {
	pulumi.Input

	ToPoolOutput() PoolOutput
	ToPoolOutputWithContext(ctx context.Context) PoolOutput
}

func (Pool) ElementType() reflect.Type {
	return reflect.TypeOf((*Pool)(nil)).Elem()
}

func (i Pool) ToPoolOutput() PoolOutput {
	return i.ToPoolOutputWithContext(context.Background())
}

func (i Pool) ToPoolOutputWithContext(ctx context.Context) PoolOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PoolOutput)
}

type PoolOutput struct {
	*pulumi.OutputState
}

func (PoolOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*PoolOutput)(nil)).Elem()
}

func (o PoolOutput) ToPoolOutput() PoolOutput {
	return o
}

func (o PoolOutput) ToPoolOutputWithContext(ctx context.Context) PoolOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(PoolOutput{})
}
