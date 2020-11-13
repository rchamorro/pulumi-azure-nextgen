// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200801

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Linked storage accounts top level resource container.
type LinkedStorageAccount struct {
	pulumi.CustomResourceState

	// Linked storage accounts type.
	DataSourceType pulumi.StringOutput `pulumi:"dataSourceType"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// Linked storage accounts resources ids.
	StorageAccountIds pulumi.StringArrayOutput `pulumi:"storageAccountIds"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewLinkedStorageAccount registers a new resource with the given unique name, arguments, and options.
func NewLinkedStorageAccount(ctx *pulumi.Context,
	name string, args *LinkedStorageAccountArgs, opts ...pulumi.ResourceOption) (*LinkedStorageAccount, error) {
	if args == nil || args.DataSourceType == nil {
		return nil, errors.New("missing required argument 'DataSourceType'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.WorkspaceName == nil {
		return nil, errors.New("missing required argument 'WorkspaceName'")
	}
	if args == nil {
		args = &LinkedStorageAccountArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:operationalinsights/latest:LinkedStorageAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:operationalinsights/v20190801preview:LinkedStorageAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:operationalinsights/v20200301preview:LinkedStorageAccount"),
		},
	})
	opts = append(opts, aliases)
	var resource LinkedStorageAccount
	err := ctx.RegisterResource("azure-nextgen:operationalinsights/v20200801:LinkedStorageAccount", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetLinkedStorageAccount gets an existing LinkedStorageAccount resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetLinkedStorageAccount(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *LinkedStorageAccountState, opts ...pulumi.ResourceOption) (*LinkedStorageAccount, error) {
	var resource LinkedStorageAccount
	err := ctx.ReadResource("azure-nextgen:operationalinsights/v20200801:LinkedStorageAccount", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering LinkedStorageAccount resources.
type linkedStorageAccountState struct {
	// Linked storage accounts type.
	DataSourceType *string `pulumi:"dataSourceType"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// Linked storage accounts resources ids.
	StorageAccountIds []string `pulumi:"storageAccountIds"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
}

type LinkedStorageAccountState struct {
	// Linked storage accounts type.
	DataSourceType pulumi.StringPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// Linked storage accounts resources ids.
	StorageAccountIds pulumi.StringArrayInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
}

func (LinkedStorageAccountState) ElementType() reflect.Type {
	return reflect.TypeOf((*linkedStorageAccountState)(nil)).Elem()
}

type linkedStorageAccountArgs struct {
	// Linked storage accounts type.
	DataSourceType string `pulumi:"dataSourceType"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Linked storage accounts resources ids.
	StorageAccountIds []string `pulumi:"storageAccountIds"`
	// The name of the workspace.
	WorkspaceName string `pulumi:"workspaceName"`
}

// The set of arguments for constructing a LinkedStorageAccount resource.
type LinkedStorageAccountArgs struct {
	// Linked storage accounts type.
	DataSourceType pulumi.StringInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// Linked storage accounts resources ids.
	StorageAccountIds pulumi.StringArrayInput
	// The name of the workspace.
	WorkspaceName pulumi.StringInput
}

func (LinkedStorageAccountArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*linkedStorageAccountArgs)(nil)).Elem()
}

type LinkedStorageAccountInput interface {
	pulumi.Input

	ToLinkedStorageAccountOutput() LinkedStorageAccountOutput
	ToLinkedStorageAccountOutputWithContext(ctx context.Context) LinkedStorageAccountOutput
}

func (LinkedStorageAccount) ElementType() reflect.Type {
	return reflect.TypeOf((*LinkedStorageAccount)(nil)).Elem()
}

func (i LinkedStorageAccount) ToLinkedStorageAccountOutput() LinkedStorageAccountOutput {
	return i.ToLinkedStorageAccountOutputWithContext(context.Background())
}

func (i LinkedStorageAccount) ToLinkedStorageAccountOutputWithContext(ctx context.Context) LinkedStorageAccountOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LinkedStorageAccountOutput)
}

type LinkedStorageAccountOutput struct {
	*pulumi.OutputState
}

func (LinkedStorageAccountOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LinkedStorageAccountOutput)(nil)).Elem()
}

func (o LinkedStorageAccountOutput) ToLinkedStorageAccountOutput() LinkedStorageAccountOutput {
	return o
}

func (o LinkedStorageAccountOutput) ToLinkedStorageAccountOutputWithContext(ctx context.Context) LinkedStorageAccountOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(LinkedStorageAccountOutput{})
}
