// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// An Azure Cosmos DB trigger.
type SqlResourceSqlTrigger struct {
	pulumi.CustomResourceState

	// The location of the resource group to which the resource belongs.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// The name of the ARM resource.
	Name     pulumi.StringOutput                              `pulumi:"name"`
	Resource SqlTriggerGetPropertiesResponseResourcePtrOutput `pulumi:"resource"`
	// Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with "defaultExperience": "Cassandra". Current "defaultExperience" values also include "Table", "Graph", "DocumentDB", and "MongoDB".
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of Azure resource.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewSqlResourceSqlTrigger registers a new resource with the given unique name, arguments, and options.
func NewSqlResourceSqlTrigger(ctx *pulumi.Context,
	name string, args *SqlResourceSqlTriggerArgs, opts ...pulumi.ResourceOption) (*SqlResourceSqlTrigger, error) {
	if args == nil || args.AccountName == nil {
		return nil, errors.New("missing required argument 'AccountName'")
	}
	if args == nil || args.ContainerName == nil {
		return nil, errors.New("missing required argument 'ContainerName'")
	}
	if args == nil || args.DatabaseName == nil {
		return nil, errors.New("missing required argument 'DatabaseName'")
	}
	if args == nil || args.Resource == nil {
		return nil, errors.New("missing required argument 'Resource'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.TriggerName == nil {
		return nil, errors.New("missing required argument 'TriggerName'")
	}
	if args == nil {
		args = &SqlResourceSqlTriggerArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:documentdb/v20190801:SqlResourceSqlTrigger"),
		},
		{
			Type: pulumi.String("azure-nextgen:documentdb/v20191212:SqlResourceSqlTrigger"),
		},
		{
			Type: pulumi.String("azure-nextgen:documentdb/v20200301:SqlResourceSqlTrigger"),
		},
		{
			Type: pulumi.String("azure-nextgen:documentdb/v20200401:SqlResourceSqlTrigger"),
		},
		{
			Type: pulumi.String("azure-nextgen:documentdb/v20200601preview:SqlResourceSqlTrigger"),
		},
		{
			Type: pulumi.String("azure-nextgen:documentdb/v20200901:SqlResourceSqlTrigger"),
		},
	})
	opts = append(opts, aliases)
	var resource SqlResourceSqlTrigger
	err := ctx.RegisterResource("azure-nextgen:documentdb/latest:SqlResourceSqlTrigger", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSqlResourceSqlTrigger gets an existing SqlResourceSqlTrigger resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSqlResourceSqlTrigger(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SqlResourceSqlTriggerState, opts ...pulumi.ResourceOption) (*SqlResourceSqlTrigger, error) {
	var resource SqlResourceSqlTrigger
	err := ctx.ReadResource("azure-nextgen:documentdb/latest:SqlResourceSqlTrigger", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SqlResourceSqlTrigger resources.
type sqlResourceSqlTriggerState struct {
	// The location of the resource group to which the resource belongs.
	Location *string `pulumi:"location"`
	// The name of the ARM resource.
	Name     *string                                  `pulumi:"name"`
	Resource *SqlTriggerGetPropertiesResponseResource `pulumi:"resource"`
	// Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with "defaultExperience": "Cassandra". Current "defaultExperience" values also include "Table", "Graph", "DocumentDB", and "MongoDB".
	Tags map[string]string `pulumi:"tags"`
	// The type of Azure resource.
	Type *string `pulumi:"type"`
}

type SqlResourceSqlTriggerState struct {
	// The location of the resource group to which the resource belongs.
	Location pulumi.StringPtrInput
	// The name of the ARM resource.
	Name     pulumi.StringPtrInput
	Resource SqlTriggerGetPropertiesResponseResourcePtrInput
	// Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with "defaultExperience": "Cassandra". Current "defaultExperience" values also include "Table", "Graph", "DocumentDB", and "MongoDB".
	Tags pulumi.StringMapInput
	// The type of Azure resource.
	Type pulumi.StringPtrInput
}

func (SqlResourceSqlTriggerState) ElementType() reflect.Type {
	return reflect.TypeOf((*sqlResourceSqlTriggerState)(nil)).Elem()
}

type sqlResourceSqlTriggerArgs struct {
	// Cosmos DB database account name.
	AccountName string `pulumi:"accountName"`
	// Cosmos DB container name.
	ContainerName string `pulumi:"containerName"`
	// Cosmos DB database name.
	DatabaseName string `pulumi:"databaseName"`
	// The location of the resource group to which the resource belongs.
	Location *string `pulumi:"location"`
	// A key-value pair of options to be applied for the request. This corresponds to the headers sent with the request.
	Options *CreateUpdateOptions `pulumi:"options"`
	// The standard JSON format of a trigger
	Resource SqlTriggerResource `pulumi:"resource"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with "defaultExperience": "Cassandra". Current "defaultExperience" values also include "Table", "Graph", "DocumentDB", and "MongoDB".
	Tags map[string]string `pulumi:"tags"`
	// Cosmos DB trigger name.
	TriggerName string `pulumi:"triggerName"`
}

// The set of arguments for constructing a SqlResourceSqlTrigger resource.
type SqlResourceSqlTriggerArgs struct {
	// Cosmos DB database account name.
	AccountName pulumi.StringInput
	// Cosmos DB container name.
	ContainerName pulumi.StringInput
	// Cosmos DB database name.
	DatabaseName pulumi.StringInput
	// The location of the resource group to which the resource belongs.
	Location pulumi.StringPtrInput
	// A key-value pair of options to be applied for the request. This corresponds to the headers sent with the request.
	Options CreateUpdateOptionsPtrInput
	// The standard JSON format of a trigger
	Resource SqlTriggerResourceInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with "defaultExperience": "Cassandra". Current "defaultExperience" values also include "Table", "Graph", "DocumentDB", and "MongoDB".
	Tags pulumi.StringMapInput
	// Cosmos DB trigger name.
	TriggerName pulumi.StringInput
}

func (SqlResourceSqlTriggerArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*sqlResourceSqlTriggerArgs)(nil)).Elem()
}

type SqlResourceSqlTriggerInput interface {
	pulumi.Input

	ToSqlResourceSqlTriggerOutput() SqlResourceSqlTriggerOutput
	ToSqlResourceSqlTriggerOutputWithContext(ctx context.Context) SqlResourceSqlTriggerOutput
}

func (SqlResourceSqlTrigger) ElementType() reflect.Type {
	return reflect.TypeOf((*SqlResourceSqlTrigger)(nil)).Elem()
}

func (i SqlResourceSqlTrigger) ToSqlResourceSqlTriggerOutput() SqlResourceSqlTriggerOutput {
	return i.ToSqlResourceSqlTriggerOutputWithContext(context.Background())
}

func (i SqlResourceSqlTrigger) ToSqlResourceSqlTriggerOutputWithContext(ctx context.Context) SqlResourceSqlTriggerOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SqlResourceSqlTriggerOutput)
}

type SqlResourceSqlTriggerOutput struct {
	*pulumi.OutputState
}

func (SqlResourceSqlTriggerOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SqlResourceSqlTriggerOutput)(nil)).Elem()
}

func (o SqlResourceSqlTriggerOutput) ToSqlResourceSqlTriggerOutput() SqlResourceSqlTriggerOutput {
	return o
}

func (o SqlResourceSqlTriggerOutput) ToSqlResourceSqlTriggerOutputWithContext(ctx context.Context) SqlResourceSqlTriggerOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(SqlResourceSqlTriggerOutput{})
}
