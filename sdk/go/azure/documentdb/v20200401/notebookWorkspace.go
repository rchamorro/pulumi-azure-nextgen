// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200401

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A notebook workspace resource
type NotebookWorkspace struct {
	pulumi.CustomResourceState

	// The name of the database account.
	Name pulumi.StringOutput `pulumi:"name"`
	// Specifies the endpoint of Notebook server.
	NotebookServerEndpoint pulumi.StringOutput `pulumi:"notebookServerEndpoint"`
	// Status of the notebook workspace. Possible values are: Creating, Online, Deleting, Failed, Updating.
	Status pulumi.StringOutput `pulumi:"status"`
	// The type of Azure resource.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewNotebookWorkspace registers a new resource with the given unique name, arguments, and options.
func NewNotebookWorkspace(ctx *pulumi.Context,
	name string, args *NotebookWorkspaceArgs, opts ...pulumi.ResourceOption) (*NotebookWorkspace, error) {
	if args == nil || args.AccountName == nil {
		return nil, errors.New("missing required argument 'AccountName'")
	}
	if args == nil || args.NotebookWorkspaceName == nil {
		return nil, errors.New("missing required argument 'NotebookWorkspaceName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &NotebookWorkspaceArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:documentdb/latest:NotebookWorkspace"),
		},
		{
			Type: pulumi.String("azure-nextgen:documentdb/v20190801:NotebookWorkspace"),
		},
		{
			Type: pulumi.String("azure-nextgen:documentdb/v20191212:NotebookWorkspace"),
		},
		{
			Type: pulumi.String("azure-nextgen:documentdb/v20200301:NotebookWorkspace"),
		},
		{
			Type: pulumi.String("azure-nextgen:documentdb/v20200601preview:NotebookWorkspace"),
		},
		{
			Type: pulumi.String("azure-nextgen:documentdb/v20200901:NotebookWorkspace"),
		},
	})
	opts = append(opts, aliases)
	var resource NotebookWorkspace
	err := ctx.RegisterResource("azure-nextgen:documentdb/v20200401:NotebookWorkspace", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNotebookWorkspace gets an existing NotebookWorkspace resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNotebookWorkspace(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NotebookWorkspaceState, opts ...pulumi.ResourceOption) (*NotebookWorkspace, error) {
	var resource NotebookWorkspace
	err := ctx.ReadResource("azure-nextgen:documentdb/v20200401:NotebookWorkspace", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering NotebookWorkspace resources.
type notebookWorkspaceState struct {
	// The name of the database account.
	Name *string `pulumi:"name"`
	// Specifies the endpoint of Notebook server.
	NotebookServerEndpoint *string `pulumi:"notebookServerEndpoint"`
	// Status of the notebook workspace. Possible values are: Creating, Online, Deleting, Failed, Updating.
	Status *string `pulumi:"status"`
	// The type of Azure resource.
	Type *string `pulumi:"type"`
}

type NotebookWorkspaceState struct {
	// The name of the database account.
	Name pulumi.StringPtrInput
	// Specifies the endpoint of Notebook server.
	NotebookServerEndpoint pulumi.StringPtrInput
	// Status of the notebook workspace. Possible values are: Creating, Online, Deleting, Failed, Updating.
	Status pulumi.StringPtrInput
	// The type of Azure resource.
	Type pulumi.StringPtrInput
}

func (NotebookWorkspaceState) ElementType() reflect.Type {
	return reflect.TypeOf((*notebookWorkspaceState)(nil)).Elem()
}

type notebookWorkspaceArgs struct {
	// Cosmos DB database account name.
	AccountName string `pulumi:"accountName"`
	// The name of the notebook workspace resource.
	NotebookWorkspaceName string `pulumi:"notebookWorkspaceName"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The set of arguments for constructing a NotebookWorkspace resource.
type NotebookWorkspaceArgs struct {
	// Cosmos DB database account name.
	AccountName pulumi.StringInput
	// The name of the notebook workspace resource.
	NotebookWorkspaceName pulumi.StringInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
}

func (NotebookWorkspaceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*notebookWorkspaceArgs)(nil)).Elem()
}

type NotebookWorkspaceInput interface {
	pulumi.Input

	ToNotebookWorkspaceOutput() NotebookWorkspaceOutput
	ToNotebookWorkspaceOutputWithContext(ctx context.Context) NotebookWorkspaceOutput
}

func (NotebookWorkspace) ElementType() reflect.Type {
	return reflect.TypeOf((*NotebookWorkspace)(nil)).Elem()
}

func (i NotebookWorkspace) ToNotebookWorkspaceOutput() NotebookWorkspaceOutput {
	return i.ToNotebookWorkspaceOutputWithContext(context.Background())
}

func (i NotebookWorkspace) ToNotebookWorkspaceOutputWithContext(ctx context.Context) NotebookWorkspaceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NotebookWorkspaceOutput)
}

type NotebookWorkspaceOutput struct {
	*pulumi.OutputState
}

func (NotebookWorkspaceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*NotebookWorkspaceOutput)(nil)).Elem()
}

func (o NotebookWorkspaceOutput) ToNotebookWorkspaceOutput() NotebookWorkspaceOutput {
	return o
}

func (o NotebookWorkspaceOutput) ToNotebookWorkspaceOutputWithContext(ctx context.Context) NotebookWorkspaceOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(NotebookWorkspaceOutput{})
}
