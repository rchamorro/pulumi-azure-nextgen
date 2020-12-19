// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200101privatepreview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A MariaDB Server key.
type ServerKey struct {
	pulumi.CustomResourceState

	// The key creation date.
	CreationDate pulumi.StringOutput `pulumi:"creationDate"`
	// Kind of encryption protector. This is metadata used for the Azure portal experience.
	Kind pulumi.StringOutput `pulumi:"kind"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// The key type like  'AzureKeyVault'.
	ServerKeyType pulumi.StringOutput `pulumi:"serverKeyType"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
	// The URI of the key.
	Uri pulumi.StringPtrOutput `pulumi:"uri"`
}

// NewServerKey registers a new resource with the given unique name, arguments, and options.
func NewServerKey(ctx *pulumi.Context,
	name string, args *ServerKeyArgs, opts ...pulumi.ResourceOption) (*ServerKey, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.KeyName == nil {
		return nil, errors.New("invalid value for required argument 'KeyName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.ServerKeyType == nil {
		return nil, errors.New("invalid value for required argument 'ServerKeyType'")
	}
	if args.ServerName == nil {
		return nil, errors.New("invalid value for required argument 'ServerName'")
	}
	var resource ServerKey
	err := ctx.RegisterResource("azure-nextgen:dbformariadb/v20200101privatepreview:ServerKey", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetServerKey gets an existing ServerKey resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetServerKey(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ServerKeyState, opts ...pulumi.ResourceOption) (*ServerKey, error) {
	var resource ServerKey
	err := ctx.ReadResource("azure-nextgen:dbformariadb/v20200101privatepreview:ServerKey", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ServerKey resources.
type serverKeyState struct {
	// The key creation date.
	CreationDate *string `pulumi:"creationDate"`
	// Kind of encryption protector. This is metadata used for the Azure portal experience.
	Kind *string `pulumi:"kind"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// The key type like  'AzureKeyVault'.
	ServerKeyType *string `pulumi:"serverKeyType"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
	// The URI of the key.
	Uri *string `pulumi:"uri"`
}

type ServerKeyState struct {
	// The key creation date.
	CreationDate pulumi.StringPtrInput
	// Kind of encryption protector. This is metadata used for the Azure portal experience.
	Kind pulumi.StringPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// The key type like  'AzureKeyVault'.
	ServerKeyType pulumi.StringPtrInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
	// The URI of the key.
	Uri pulumi.StringPtrInput
}

func (ServerKeyState) ElementType() reflect.Type {
	return reflect.TypeOf((*serverKeyState)(nil)).Elem()
}

type serverKeyArgs struct {
	// The name of the MariaDB Server key to be operated on (updated or created).
	KeyName string `pulumi:"keyName"`
	// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The key type like  'AzureKeyVault'.
	ServerKeyType string `pulumi:"serverKeyType"`
	// The name of the server.
	ServerName string `pulumi:"serverName"`
	// The URI of the key.
	Uri *string `pulumi:"uri"`
}

// The set of arguments for constructing a ServerKey resource.
type ServerKeyArgs struct {
	// The name of the MariaDB Server key to be operated on (updated or created).
	KeyName pulumi.StringInput
	// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
	ResourceGroupName pulumi.StringInput
	// The key type like  'AzureKeyVault'.
	ServerKeyType pulumi.StringInput
	// The name of the server.
	ServerName pulumi.StringInput
	// The URI of the key.
	Uri pulumi.StringPtrInput
}

func (ServerKeyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*serverKeyArgs)(nil)).Elem()
}

type ServerKeyInput interface {
	pulumi.Input

	ToServerKeyOutput() ServerKeyOutput
	ToServerKeyOutputWithContext(ctx context.Context) ServerKeyOutput
}

func (*ServerKey) ElementType() reflect.Type {
	return reflect.TypeOf((*ServerKey)(nil))
}

func (i *ServerKey) ToServerKeyOutput() ServerKeyOutput {
	return i.ToServerKeyOutputWithContext(context.Background())
}

func (i *ServerKey) ToServerKeyOutputWithContext(ctx context.Context) ServerKeyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServerKeyOutput)
}

type ServerKeyOutput struct {
	*pulumi.OutputState
}

func (ServerKeyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ServerKey)(nil))
}

func (o ServerKeyOutput) ToServerKeyOutput() ServerKeyOutput {
	return o
}

func (o ServerKeyOutput) ToServerKeyOutputWithContext(ctx context.Context) ServerKeyOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ServerKeyOutput{})
}
