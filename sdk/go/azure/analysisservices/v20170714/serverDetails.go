// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20170714

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Represents an instance of an Analysis Services resource.
type ServerDetails struct {
	pulumi.CustomResourceState

	// A collection of AS server administrators
	AsAdministrators ServerAdministratorsResponsePtrOutput `pulumi:"asAdministrators"`
	// The SAS container URI to the backup container.
	BackupBlobContainerUri pulumi.StringPtrOutput `pulumi:"backupBlobContainerUri"`
	// The gateway details configured for the AS server.
	GatewayDetails GatewayDetailsResponsePtrOutput `pulumi:"gatewayDetails"`
	// Location of the Analysis Services resource.
	Location pulumi.StringOutput `pulumi:"location"`
	// The managed mode of the server (0 = not managed, 1 = managed).
	ManagedMode pulumi.IntPtrOutput `pulumi:"managedMode"`
	// The name of the Analysis Services resource.
	Name pulumi.StringOutput `pulumi:"name"`
	// The current deployment state of Analysis Services resource. The provisioningState is to indicate states for resource provisioning.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The full name of the Analysis Services resource.
	ServerFullName pulumi.StringOutput `pulumi:"serverFullName"`
	// The server monitor mode for AS server
	ServerMonitorMode pulumi.IntPtrOutput `pulumi:"serverMonitorMode"`
	// The SKU of the Analysis Services resource.
	Sku ResourceSkuResponseOutput `pulumi:"sku"`
	// The current state of Analysis Services resource. The state is to indicate more states outside of resource provisioning.
	State pulumi.StringOutput `pulumi:"state"`
	// Key-value pairs of additional resource provisioning properties.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the Analysis Services resource.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewServerDetails registers a new resource with the given unique name, arguments, and options.
func NewServerDetails(ctx *pulumi.Context,
	name string, args *ServerDetailsArgs, opts ...pulumi.ResourceOption) (*ServerDetails, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.ServerName == nil {
		return nil, errors.New("invalid value for required argument 'ServerName'")
	}
	if args.Sku == nil {
		return nil, errors.New("invalid value for required argument 'Sku'")
	}
	if args.ManagedMode == nil {
		args.ManagedMode = pulumi.IntPtr(1)
	}
	if args.ServerMonitorMode == nil {
		args.ServerMonitorMode = pulumi.IntPtr(1)
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:analysisservices/latest:ServerDetails"),
		},
		{
			Type: pulumi.String("azure-nextgen:analysisservices/v20160516:ServerDetails"),
		},
		{
			Type: pulumi.String("azure-nextgen:analysisservices/v20170801:ServerDetails"),
		},
		{
			Type: pulumi.String("azure-nextgen:analysisservices/v20170801beta:ServerDetails"),
		},
	})
	opts = append(opts, aliases)
	var resource ServerDetails
	err := ctx.RegisterResource("azure-nextgen:analysisservices/v20170714:ServerDetails", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetServerDetails gets an existing ServerDetails resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetServerDetails(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ServerDetailsState, opts ...pulumi.ResourceOption) (*ServerDetails, error) {
	var resource ServerDetails
	err := ctx.ReadResource("azure-nextgen:analysisservices/v20170714:ServerDetails", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ServerDetails resources.
type serverDetailsState struct {
	// A collection of AS server administrators
	AsAdministrators *ServerAdministratorsResponse `pulumi:"asAdministrators"`
	// The SAS container URI to the backup container.
	BackupBlobContainerUri *string `pulumi:"backupBlobContainerUri"`
	// The gateway details configured for the AS server.
	GatewayDetails *GatewayDetailsResponse `pulumi:"gatewayDetails"`
	// Location of the Analysis Services resource.
	Location *string `pulumi:"location"`
	// The managed mode of the server (0 = not managed, 1 = managed).
	ManagedMode *int `pulumi:"managedMode"`
	// The name of the Analysis Services resource.
	Name *string `pulumi:"name"`
	// The current deployment state of Analysis Services resource. The provisioningState is to indicate states for resource provisioning.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The full name of the Analysis Services resource.
	ServerFullName *string `pulumi:"serverFullName"`
	// The server monitor mode for AS server
	ServerMonitorMode *int `pulumi:"serverMonitorMode"`
	// The SKU of the Analysis Services resource.
	Sku *ResourceSkuResponse `pulumi:"sku"`
	// The current state of Analysis Services resource. The state is to indicate more states outside of resource provisioning.
	State *string `pulumi:"state"`
	// Key-value pairs of additional resource provisioning properties.
	Tags map[string]string `pulumi:"tags"`
	// The type of the Analysis Services resource.
	Type *string `pulumi:"type"`
}

type ServerDetailsState struct {
	// A collection of AS server administrators
	AsAdministrators ServerAdministratorsResponsePtrInput
	// The SAS container URI to the backup container.
	BackupBlobContainerUri pulumi.StringPtrInput
	// The gateway details configured for the AS server.
	GatewayDetails GatewayDetailsResponsePtrInput
	// Location of the Analysis Services resource.
	Location pulumi.StringPtrInput
	// The managed mode of the server (0 = not managed, 1 = managed).
	ManagedMode pulumi.IntPtrInput
	// The name of the Analysis Services resource.
	Name pulumi.StringPtrInput
	// The current deployment state of Analysis Services resource. The provisioningState is to indicate states for resource provisioning.
	ProvisioningState pulumi.StringPtrInput
	// The full name of the Analysis Services resource.
	ServerFullName pulumi.StringPtrInput
	// The server monitor mode for AS server
	ServerMonitorMode pulumi.IntPtrInput
	// The SKU of the Analysis Services resource.
	Sku ResourceSkuResponsePtrInput
	// The current state of Analysis Services resource. The state is to indicate more states outside of resource provisioning.
	State pulumi.StringPtrInput
	// Key-value pairs of additional resource provisioning properties.
	Tags pulumi.StringMapInput
	// The type of the Analysis Services resource.
	Type pulumi.StringPtrInput
}

func (ServerDetailsState) ElementType() reflect.Type {
	return reflect.TypeOf((*serverDetailsState)(nil)).Elem()
}

type serverDetailsArgs struct {
	// A collection of AS server administrators
	AsAdministrators *ServerAdministrators `pulumi:"asAdministrators"`
	// The SAS container URI to the backup container.
	BackupBlobContainerUri *string `pulumi:"backupBlobContainerUri"`
	// The gateway details configured for the AS server.
	GatewayDetails *GatewayDetails `pulumi:"gatewayDetails"`
	// Location of the Analysis Services resource.
	Location *string `pulumi:"location"`
	// The managed mode of the server (0 = not managed, 1 = managed).
	ManagedMode *int `pulumi:"managedMode"`
	// The name of the Azure Resource group of which a given Analysis Services server is part. This name must be at least 1 character in length, and no more than 90.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The server monitor mode for AS server
	ServerMonitorMode *int `pulumi:"serverMonitorMode"`
	// The name of the Analysis Services server. It must be a minimum of 3 characters, and a maximum of 63.
	ServerName string `pulumi:"serverName"`
	// The SKU of the Analysis Services resource.
	Sku ResourceSku `pulumi:"sku"`
	// Key-value pairs of additional resource provisioning properties.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a ServerDetails resource.
type ServerDetailsArgs struct {
	// A collection of AS server administrators
	AsAdministrators ServerAdministratorsPtrInput
	// The SAS container URI to the backup container.
	BackupBlobContainerUri pulumi.StringPtrInput
	// The gateway details configured for the AS server.
	GatewayDetails GatewayDetailsPtrInput
	// Location of the Analysis Services resource.
	Location pulumi.StringPtrInput
	// The managed mode of the server (0 = not managed, 1 = managed).
	ManagedMode pulumi.IntPtrInput
	// The name of the Azure Resource group of which a given Analysis Services server is part. This name must be at least 1 character in length, and no more than 90.
	ResourceGroupName pulumi.StringInput
	// The server monitor mode for AS server
	ServerMonitorMode pulumi.IntPtrInput
	// The name of the Analysis Services server. It must be a minimum of 3 characters, and a maximum of 63.
	ServerName pulumi.StringInput
	// The SKU of the Analysis Services resource.
	Sku ResourceSkuInput
	// Key-value pairs of additional resource provisioning properties.
	Tags pulumi.StringMapInput
}

func (ServerDetailsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*serverDetailsArgs)(nil)).Elem()
}

type ServerDetailsInput interface {
	pulumi.Input

	ToServerDetailsOutput() ServerDetailsOutput
	ToServerDetailsOutputWithContext(ctx context.Context) ServerDetailsOutput
}

func (*ServerDetails) ElementType() reflect.Type {
	return reflect.TypeOf((*ServerDetails)(nil))
}

func (i *ServerDetails) ToServerDetailsOutput() ServerDetailsOutput {
	return i.ToServerDetailsOutputWithContext(context.Background())
}

func (i *ServerDetails) ToServerDetailsOutputWithContext(ctx context.Context) ServerDetailsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServerDetailsOutput)
}

type ServerDetailsOutput struct {
	*pulumi.OutputState
}

func (ServerDetailsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ServerDetails)(nil))
}

func (o ServerDetailsOutput) ToServerDetailsOutput() ServerDetailsOutput {
	return o
}

func (o ServerDetailsOutput) ToServerDetailsOutputWithContext(ctx context.Context) ServerDetailsOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ServerDetailsOutput{})
}
