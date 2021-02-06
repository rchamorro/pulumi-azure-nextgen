// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200908preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A SqlManagedInstance.
type SqlManagedInstance struct {
	pulumi.CustomResourceState

	// The instance admin user
	Admin pulumi.StringPtrOutput `pulumi:"admin"`
	// null
	DataControllerId pulumi.StringPtrOutput `pulumi:"dataControllerId"`
	// The instance end time
	EndTime pulumi.StringPtrOutput `pulumi:"endTime"`
	// The on premise instance endpoint
	InstanceEndpoint pulumi.StringPtrOutput `pulumi:"instanceEndpoint"`
	// The raw kubernetes information
	K8sRaw pulumi.AnyOutput `pulumi:"k8sRaw"`
	// Last uploaded date from on premise cluster. Defaults to current date time
	LastUploadedDate pulumi.StringPtrOutput `pulumi:"lastUploadedDate"`
	// The geo-location where the resource lives
	Location pulumi.StringOutput `pulumi:"location"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// The instance start time
	StartTime pulumi.StringPtrOutput `pulumi:"startTime"`
	// Read only system data
	SystemData SystemDataResponseOutput `pulumi:"systemData"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
	Type pulumi.StringOutput `pulumi:"type"`
	// The instance vCore
	VCore pulumi.StringPtrOutput `pulumi:"vCore"`
}

// NewSqlManagedInstance registers a new resource with the given unique name, arguments, and options.
func NewSqlManagedInstance(ctx *pulumi.Context,
	name string, args *SqlManagedInstanceArgs, opts ...pulumi.ResourceOption) (*SqlManagedInstance, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.SqlManagedInstanceName == nil {
		return nil, errors.New("invalid value for required argument 'SqlManagedInstanceName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:azuredata/v20190724preview:SqlManagedInstance"),
		},
	})
	opts = append(opts, aliases)
	var resource SqlManagedInstance
	err := ctx.RegisterResource("azure-nextgen:azuredata/v20200908preview:SqlManagedInstance", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSqlManagedInstance gets an existing SqlManagedInstance resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSqlManagedInstance(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SqlManagedInstanceState, opts ...pulumi.ResourceOption) (*SqlManagedInstance, error) {
	var resource SqlManagedInstance
	err := ctx.ReadResource("azure-nextgen:azuredata/v20200908preview:SqlManagedInstance", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SqlManagedInstance resources.
type sqlManagedInstanceState struct {
	// The instance admin user
	Admin *string `pulumi:"admin"`
	// null
	DataControllerId *string `pulumi:"dataControllerId"`
	// The instance end time
	EndTime *string `pulumi:"endTime"`
	// The on premise instance endpoint
	InstanceEndpoint *string `pulumi:"instanceEndpoint"`
	// The raw kubernetes information
	K8sRaw interface{} `pulumi:"k8sRaw"`
	// Last uploaded date from on premise cluster. Defaults to current date time
	LastUploadedDate *string `pulumi:"lastUploadedDate"`
	// The geo-location where the resource lives
	Location *string `pulumi:"location"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// The instance start time
	StartTime *string `pulumi:"startTime"`
	// Read only system data
	SystemData *SystemDataResponse `pulumi:"systemData"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
	Type *string `pulumi:"type"`
	// The instance vCore
	VCore *string `pulumi:"vCore"`
}

type SqlManagedInstanceState struct {
	// The instance admin user
	Admin pulumi.StringPtrInput
	// null
	DataControllerId pulumi.StringPtrInput
	// The instance end time
	EndTime pulumi.StringPtrInput
	// The on premise instance endpoint
	InstanceEndpoint pulumi.StringPtrInput
	// The raw kubernetes information
	K8sRaw pulumi.Input
	// Last uploaded date from on premise cluster. Defaults to current date time
	LastUploadedDate pulumi.StringPtrInput
	// The geo-location where the resource lives
	Location pulumi.StringPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// The instance start time
	StartTime pulumi.StringPtrInput
	// Read only system data
	SystemData SystemDataResponsePtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
	Type pulumi.StringPtrInput
	// The instance vCore
	VCore pulumi.StringPtrInput
}

func (SqlManagedInstanceState) ElementType() reflect.Type {
	return reflect.TypeOf((*sqlManagedInstanceState)(nil)).Elem()
}

type sqlManagedInstanceArgs struct {
	// The instance admin user
	Admin *string `pulumi:"admin"`
	// null
	DataControllerId *string `pulumi:"dataControllerId"`
	// The instance end time
	EndTime *string `pulumi:"endTime"`
	// The on premise instance endpoint
	InstanceEndpoint *string `pulumi:"instanceEndpoint"`
	// The raw kubernetes information
	K8sRaw interface{} `pulumi:"k8sRaw"`
	// Last uploaded date from on premise cluster. Defaults to current date time
	LastUploadedDate *string `pulumi:"lastUploadedDate"`
	// The geo-location where the resource lives
	Location *string `pulumi:"location"`
	// The name of the Azure resource group
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of SQL Managed Instances
	SqlManagedInstanceName string `pulumi:"sqlManagedInstanceName"`
	// The instance start time
	StartTime *string `pulumi:"startTime"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The instance vCore
	VCore *string `pulumi:"vCore"`
}

// The set of arguments for constructing a SqlManagedInstance resource.
type SqlManagedInstanceArgs struct {
	// The instance admin user
	Admin pulumi.StringPtrInput
	// null
	DataControllerId pulumi.StringPtrInput
	// The instance end time
	EndTime pulumi.StringPtrInput
	// The on premise instance endpoint
	InstanceEndpoint pulumi.StringPtrInput
	// The raw kubernetes information
	K8sRaw pulumi.Input
	// Last uploaded date from on premise cluster. Defaults to current date time
	LastUploadedDate pulumi.StringPtrInput
	// The geo-location where the resource lives
	Location pulumi.StringPtrInput
	// The name of the Azure resource group
	ResourceGroupName pulumi.StringInput
	// The name of SQL Managed Instances
	SqlManagedInstanceName pulumi.StringInput
	// The instance start time
	StartTime pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The instance vCore
	VCore pulumi.StringPtrInput
}

func (SqlManagedInstanceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*sqlManagedInstanceArgs)(nil)).Elem()
}

type SqlManagedInstanceInput interface {
	pulumi.Input

	ToSqlManagedInstanceOutput() SqlManagedInstanceOutput
	ToSqlManagedInstanceOutputWithContext(ctx context.Context) SqlManagedInstanceOutput
}

func (*SqlManagedInstance) ElementType() reflect.Type {
	return reflect.TypeOf((*SqlManagedInstance)(nil))
}

func (i *SqlManagedInstance) ToSqlManagedInstanceOutput() SqlManagedInstanceOutput {
	return i.ToSqlManagedInstanceOutputWithContext(context.Background())
}

func (i *SqlManagedInstance) ToSqlManagedInstanceOutputWithContext(ctx context.Context) SqlManagedInstanceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SqlManagedInstanceOutput)
}

type SqlManagedInstanceOutput struct {
	*pulumi.OutputState
}

func (SqlManagedInstanceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SqlManagedInstance)(nil))
}

func (o SqlManagedInstanceOutput) ToSqlManagedInstanceOutput() SqlManagedInstanceOutput {
	return o
}

func (o SqlManagedInstanceOutput) ToSqlManagedInstanceOutputWithContext(ctx context.Context) SqlManagedInstanceOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(SqlManagedInstanceOutput{})
}
