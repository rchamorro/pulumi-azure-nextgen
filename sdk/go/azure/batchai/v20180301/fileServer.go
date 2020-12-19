// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180301

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Contains information about the File Server.
type FileServer struct {
	pulumi.CustomResourceState

	CreationTime pulumi.StringOutput `pulumi:"creationTime"`
	// Settings for the data disk which would be created for the File Server.
	DataDisks DataDisksResponsePtrOutput `pulumi:"dataDisks"`
	// The location of the resource
	Location pulumi.StringOutput `pulumi:"location"`
	// Details of the File Server.
	MountSettings MountSettingsResponseOutput `pulumi:"mountSettings"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// Possible values: creating - The File Server is getting created. updating - The File Server creation has been accepted and it is getting updated. deleting - The user has requested that the File Server be deleted, and it is in the process of being deleted. failed - The File Server creation has failed with the specified errorCode. Details about the error code are specified in the message field. succeeded - The File Server creation has succeeded.
	ProvisioningState               pulumi.StringOutput `pulumi:"provisioningState"`
	ProvisioningStateTransitionTime pulumi.StringOutput `pulumi:"provisioningStateTransitionTime"`
	// SSH configuration settings for the VM
	SshConfiguration SshConfigurationResponsePtrOutput `pulumi:"sshConfiguration"`
	// Represents a resource ID. For example, for a subnet, it is the resource URL for the subnet.
	Subnet ResourceIdResponsePtrOutput `pulumi:"subnet"`
	// The tags of the resource
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the resource
	Type pulumi.StringOutput `pulumi:"type"`
	// For information about available VM sizes for File Server from the Virtual Machines Marketplace, see Sizes for Virtual Machines (Linux).
	VmSize pulumi.StringPtrOutput `pulumi:"vmSize"`
}

// NewFileServer registers a new resource with the given unique name, arguments, and options.
func NewFileServer(ctx *pulumi.Context,
	name string, args *FileServerArgs, opts ...pulumi.ResourceOption) (*FileServer, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DataDisks == nil {
		return nil, errors.New("invalid value for required argument 'DataDisks'")
	}
	if args.FileServerName == nil {
		return nil, errors.New("invalid value for required argument 'FileServerName'")
	}
	if args.Location == nil {
		return nil, errors.New("invalid value for required argument 'Location'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.SshConfiguration == nil {
		return nil, errors.New("invalid value for required argument 'SshConfiguration'")
	}
	if args.VmSize == nil {
		return nil, errors.New("invalid value for required argument 'VmSize'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:batchai/v20170901preview:FileServer"),
		},
	})
	opts = append(opts, aliases)
	var resource FileServer
	err := ctx.RegisterResource("azure-nextgen:batchai/v20180301:FileServer", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetFileServer gets an existing FileServer resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetFileServer(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *FileServerState, opts ...pulumi.ResourceOption) (*FileServer, error) {
	var resource FileServer
	err := ctx.ReadResource("azure-nextgen:batchai/v20180301:FileServer", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering FileServer resources.
type fileServerState struct {
	CreationTime *string `pulumi:"creationTime"`
	// Settings for the data disk which would be created for the File Server.
	DataDisks *DataDisksResponse `pulumi:"dataDisks"`
	// The location of the resource
	Location *string `pulumi:"location"`
	// Details of the File Server.
	MountSettings *MountSettingsResponse `pulumi:"mountSettings"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// Possible values: creating - The File Server is getting created. updating - The File Server creation has been accepted and it is getting updated. deleting - The user has requested that the File Server be deleted, and it is in the process of being deleted. failed - The File Server creation has failed with the specified errorCode. Details about the error code are specified in the message field. succeeded - The File Server creation has succeeded.
	ProvisioningState               *string `pulumi:"provisioningState"`
	ProvisioningStateTransitionTime *string `pulumi:"provisioningStateTransitionTime"`
	// SSH configuration settings for the VM
	SshConfiguration *SshConfigurationResponse `pulumi:"sshConfiguration"`
	// Represents a resource ID. For example, for a subnet, it is the resource URL for the subnet.
	Subnet *ResourceIdResponse `pulumi:"subnet"`
	// The tags of the resource
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource
	Type *string `pulumi:"type"`
	// For information about available VM sizes for File Server from the Virtual Machines Marketplace, see Sizes for Virtual Machines (Linux).
	VmSize *string `pulumi:"vmSize"`
}

type FileServerState struct {
	CreationTime pulumi.StringPtrInput
	// Settings for the data disk which would be created for the File Server.
	DataDisks DataDisksResponsePtrInput
	// The location of the resource
	Location pulumi.StringPtrInput
	// Details of the File Server.
	MountSettings MountSettingsResponsePtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// Possible values: creating - The File Server is getting created. updating - The File Server creation has been accepted and it is getting updated. deleting - The user has requested that the File Server be deleted, and it is in the process of being deleted. failed - The File Server creation has failed with the specified errorCode. Details about the error code are specified in the message field. succeeded - The File Server creation has succeeded.
	ProvisioningState               pulumi.StringPtrInput
	ProvisioningStateTransitionTime pulumi.StringPtrInput
	// SSH configuration settings for the VM
	SshConfiguration SshConfigurationResponsePtrInput
	// Represents a resource ID. For example, for a subnet, it is the resource URL for the subnet.
	Subnet ResourceIdResponsePtrInput
	// The tags of the resource
	Tags pulumi.StringMapInput
	// The type of the resource
	Type pulumi.StringPtrInput
	// For information about available VM sizes for File Server from the Virtual Machines Marketplace, see Sizes for Virtual Machines (Linux).
	VmSize pulumi.StringPtrInput
}

func (FileServerState) ElementType() reflect.Type {
	return reflect.TypeOf((*fileServerState)(nil)).Elem()
}

type fileServerArgs struct {
	// Settings for the data disk which would be created for the File Server.
	DataDisks DataDisks `pulumi:"dataDisks"`
	// The name of the file server within the specified resource group. File server names can only contain a combination of alphanumeric characters along with dash (-) and underscore (_). The name must be from 1 through 64 characters long.
	FileServerName string `pulumi:"fileServerName"`
	// The region in which to create the File Server.
	Location string `pulumi:"location"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// SSH configuration settings for the VM
	SshConfiguration SshConfiguration `pulumi:"sshConfiguration"`
	// Represents a resource ID. For example, for a subnet, it is the resource URL for the subnet.
	Subnet *ResourceId `pulumi:"subnet"`
	// The user specified tags associated with the File Server.
	Tags map[string]string `pulumi:"tags"`
	// For information about available VM sizes for fileservers from the Virtual Machines Marketplace, see Sizes for Virtual Machines (Linux).
	VmSize string `pulumi:"vmSize"`
}

// The set of arguments for constructing a FileServer resource.
type FileServerArgs struct {
	// Settings for the data disk which would be created for the File Server.
	DataDisks DataDisksInput
	// The name of the file server within the specified resource group. File server names can only contain a combination of alphanumeric characters along with dash (-) and underscore (_). The name must be from 1 through 64 characters long.
	FileServerName pulumi.StringInput
	// The region in which to create the File Server.
	Location pulumi.StringInput
	// Name of the resource group to which the resource belongs.
	ResourceGroupName pulumi.StringInput
	// SSH configuration settings for the VM
	SshConfiguration SshConfigurationInput
	// Represents a resource ID. For example, for a subnet, it is the resource URL for the subnet.
	Subnet ResourceIdPtrInput
	// The user specified tags associated with the File Server.
	Tags pulumi.StringMapInput
	// For information about available VM sizes for fileservers from the Virtual Machines Marketplace, see Sizes for Virtual Machines (Linux).
	VmSize pulumi.StringInput
}

func (FileServerArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*fileServerArgs)(nil)).Elem()
}

type FileServerInput interface {
	pulumi.Input

	ToFileServerOutput() FileServerOutput
	ToFileServerOutputWithContext(ctx context.Context) FileServerOutput
}

func (*FileServer) ElementType() reflect.Type {
	return reflect.TypeOf((*FileServer)(nil))
}

func (i *FileServer) ToFileServerOutput() FileServerOutput {
	return i.ToFileServerOutputWithContext(context.Background())
}

func (i *FileServer) ToFileServerOutputWithContext(ctx context.Context) FileServerOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FileServerOutput)
}

type FileServerOutput struct {
	*pulumi.OutputState
}

func (FileServerOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*FileServer)(nil))
}

func (o FileServerOutput) ToFileServerOutput() FileServerOutput {
	return o
}

func (o FileServerOutput) ToFileServerOutputWithContext(ctx context.Context) FileServerOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(FileServerOutput{})
}
