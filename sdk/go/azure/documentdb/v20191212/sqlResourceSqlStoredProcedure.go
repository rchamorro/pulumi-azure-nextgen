// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20191212

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// An Azure Cosmos DB storedProcedure.
type SqlResourceSqlStoredProcedure struct {
	pulumi.CustomResourceState

	// The location of the resource group to which the resource belongs.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// The name of the ARM resource.
	Name     pulumi.StringOutput                                      `pulumi:"name"`
	Resource SqlStoredProcedureGetPropertiesResponseResourcePtrOutput `pulumi:"resource"`
	// Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with "defaultExperience": "Cassandra". Current "defaultExperience" values also include "Table", "Graph", "DocumentDB", and "MongoDB".
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of Azure resource.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewSqlResourceSqlStoredProcedure registers a new resource with the given unique name, arguments, and options.
func NewSqlResourceSqlStoredProcedure(ctx *pulumi.Context,
	name string, args *SqlResourceSqlStoredProcedureArgs, opts ...pulumi.ResourceOption) (*SqlResourceSqlStoredProcedure, error) {
	if args == nil || args.AccountName == nil {
		return nil, errors.New("missing required argument 'AccountName'")
	}
	if args == nil || args.ContainerName == nil {
		return nil, errors.New("missing required argument 'ContainerName'")
	}
	if args == nil || args.DatabaseName == nil {
		return nil, errors.New("missing required argument 'DatabaseName'")
	}
	if args == nil || args.Options == nil {
		return nil, errors.New("missing required argument 'Options'")
	}
	if args == nil || args.Resource == nil {
		return nil, errors.New("missing required argument 'Resource'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.StoredProcedureName == nil {
		return nil, errors.New("missing required argument 'StoredProcedureName'")
	}
	if args == nil {
		args = &SqlResourceSqlStoredProcedureArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:documentdb/latest:SqlResourceSqlStoredProcedure"),
		},
		{
			Type: pulumi.String("azure-nextgen:documentdb/v20190801:SqlResourceSqlStoredProcedure"),
		},
		{
			Type: pulumi.String("azure-nextgen:documentdb/v20200301:SqlResourceSqlStoredProcedure"),
		},
		{
			Type: pulumi.String("azure-nextgen:documentdb/v20200401:SqlResourceSqlStoredProcedure"),
		},
		{
			Type: pulumi.String("azure-nextgen:documentdb/v20200601preview:SqlResourceSqlStoredProcedure"),
		},
		{
			Type: pulumi.String("azure-nextgen:documentdb/v20200901:SqlResourceSqlStoredProcedure"),
		},
	})
	opts = append(opts, aliases)
	var resource SqlResourceSqlStoredProcedure
	err := ctx.RegisterResource("azure-nextgen:documentdb/v20191212:SqlResourceSqlStoredProcedure", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSqlResourceSqlStoredProcedure gets an existing SqlResourceSqlStoredProcedure resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSqlResourceSqlStoredProcedure(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SqlResourceSqlStoredProcedureState, opts ...pulumi.ResourceOption) (*SqlResourceSqlStoredProcedure, error) {
	var resource SqlResourceSqlStoredProcedure
	err := ctx.ReadResource("azure-nextgen:documentdb/v20191212:SqlResourceSqlStoredProcedure", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SqlResourceSqlStoredProcedure resources.
type sqlResourceSqlStoredProcedureState struct {
	// The location of the resource group to which the resource belongs.
	Location *string `pulumi:"location"`
	// The name of the ARM resource.
	Name     *string                                          `pulumi:"name"`
	Resource *SqlStoredProcedureGetPropertiesResponseResource `pulumi:"resource"`
	// Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with "defaultExperience": "Cassandra". Current "defaultExperience" values also include "Table", "Graph", "DocumentDB", and "MongoDB".
	Tags map[string]string `pulumi:"tags"`
	// The type of Azure resource.
	Type *string `pulumi:"type"`
}

type SqlResourceSqlStoredProcedureState struct {
	// The location of the resource group to which the resource belongs.
	Location pulumi.StringPtrInput
	// The name of the ARM resource.
	Name     pulumi.StringPtrInput
	Resource SqlStoredProcedureGetPropertiesResponseResourcePtrInput
	// Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with "defaultExperience": "Cassandra". Current "defaultExperience" values also include "Table", "Graph", "DocumentDB", and "MongoDB".
	Tags pulumi.StringMapInput
	// The type of Azure resource.
	Type pulumi.StringPtrInput
}

func (SqlResourceSqlStoredProcedureState) ElementType() reflect.Type {
	return reflect.TypeOf((*sqlResourceSqlStoredProcedureState)(nil)).Elem()
}

type sqlResourceSqlStoredProcedureArgs struct {
	// Cosmos DB database account name.
	AccountName string `pulumi:"accountName"`
	// Cosmos DB container name.
	ContainerName string `pulumi:"containerName"`
	// Cosmos DB database name.
	DatabaseName string `pulumi:"databaseName"`
	// The location of the resource group to which the resource belongs.
	Location *string `pulumi:"location"`
	// A key-value pair of options to be applied for the request. This corresponds to the headers sent with the request.
	Options CreateUpdateOptions `pulumi:"options"`
	// The standard JSON format of a storedProcedure
	Resource SqlStoredProcedureResource `pulumi:"resource"`
	// Name of an Azure resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Cosmos DB storedProcedure name.
	StoredProcedureName string `pulumi:"storedProcedureName"`
	// Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with "defaultExperience": "Cassandra". Current "defaultExperience" values also include "Table", "Graph", "DocumentDB", and "MongoDB".
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a SqlResourceSqlStoredProcedure resource.
type SqlResourceSqlStoredProcedureArgs struct {
	// Cosmos DB database account name.
	AccountName pulumi.StringInput
	// Cosmos DB container name.
	ContainerName pulumi.StringInput
	// Cosmos DB database name.
	DatabaseName pulumi.StringInput
	// The location of the resource group to which the resource belongs.
	Location pulumi.StringPtrInput
	// A key-value pair of options to be applied for the request. This corresponds to the headers sent with the request.
	Options CreateUpdateOptionsInput
	// The standard JSON format of a storedProcedure
	Resource SqlStoredProcedureResourceInput
	// Name of an Azure resource group.
	ResourceGroupName pulumi.StringInput
	// Cosmos DB storedProcedure name.
	StoredProcedureName pulumi.StringInput
	// Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with "defaultExperience": "Cassandra". Current "defaultExperience" values also include "Table", "Graph", "DocumentDB", and "MongoDB".
	Tags pulumi.StringMapInput
}

func (SqlResourceSqlStoredProcedureArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*sqlResourceSqlStoredProcedureArgs)(nil)).Elem()
}

type SqlResourceSqlStoredProcedureInput interface {
	pulumi.Input

	ToSqlResourceSqlStoredProcedureOutput() SqlResourceSqlStoredProcedureOutput
	ToSqlResourceSqlStoredProcedureOutputWithContext(ctx context.Context) SqlResourceSqlStoredProcedureOutput
}

func (SqlResourceSqlStoredProcedure) ElementType() reflect.Type {
	return reflect.TypeOf((*SqlResourceSqlStoredProcedure)(nil)).Elem()
}

func (i SqlResourceSqlStoredProcedure) ToSqlResourceSqlStoredProcedureOutput() SqlResourceSqlStoredProcedureOutput {
	return i.ToSqlResourceSqlStoredProcedureOutputWithContext(context.Background())
}

func (i SqlResourceSqlStoredProcedure) ToSqlResourceSqlStoredProcedureOutputWithContext(ctx context.Context) SqlResourceSqlStoredProcedureOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SqlResourceSqlStoredProcedureOutput)
}

type SqlResourceSqlStoredProcedureOutput struct {
	*pulumi.OutputState
}

func (SqlResourceSqlStoredProcedureOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SqlResourceSqlStoredProcedureOutput)(nil)).Elem()
}

func (o SqlResourceSqlStoredProcedureOutput) ToSqlResourceSqlStoredProcedureOutput() SqlResourceSqlStoredProcedureOutput {
	return o
}

func (o SqlResourceSqlStoredProcedureOutput) ToSqlResourceSqlStoredProcedureOutputWithContext(ctx context.Context) SqlResourceSqlStoredProcedureOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(SqlResourceSqlStoredProcedureOutput{})
}
