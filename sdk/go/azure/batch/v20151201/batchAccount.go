// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20151201

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Contains information about an Azure Batch account.
type BatchAccount struct {
	pulumi.CustomResourceState

	// The endpoint used by this account to interact with the Batch services.
	AccountEndpoint pulumi.StringOutput `pulumi:"accountEndpoint"`
	// The active job and job schedule quota for this Batch account.
	ActiveJobAndJobScheduleQuota pulumi.IntOutput `pulumi:"activeJobAndJobScheduleQuota"`
	// The properties and status of any auto storage account associated with the account.
	AutoStorage AutoStoragePropertiesResponsePtrOutput `pulumi:"autoStorage"`
	// The core quota for this Batch account.
	CoreQuota pulumi.IntOutput `pulumi:"coreQuota"`
	// The location of the resource
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// The pool quota for this Batch account.
	PoolQuota pulumi.IntOutput `pulumi:"poolQuota"`
	// The provisioned state of the resource
	ProvisioningState pulumi.StringPtrOutput `pulumi:"provisioningState"`
	// The tags of the resource
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the resource
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewBatchAccount registers a new resource with the given unique name, arguments, and options.
func NewBatchAccount(ctx *pulumi.Context,
	name string, args *BatchAccountArgs, opts ...pulumi.ResourceOption) (*BatchAccount, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AccountName == nil {
		return nil, errors.New("invalid value for required argument 'AccountName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:batch/latest:BatchAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:batch/v20170101:BatchAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:batch/v20170501:BatchAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:batch/v20170901:BatchAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:batch/v20181201:BatchAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:batch/v20190401:BatchAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:batch/v20190801:BatchAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:batch/v20200301:BatchAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:batch/v20200501:BatchAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:batch/v20200901:BatchAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:batch/v20210101:BatchAccount"),
		},
	})
	opts = append(opts, aliases)
	var resource BatchAccount
	err := ctx.RegisterResource("azure-nextgen:batch/v20151201:BatchAccount", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBatchAccount gets an existing BatchAccount resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBatchAccount(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BatchAccountState, opts ...pulumi.ResourceOption) (*BatchAccount, error) {
	var resource BatchAccount
	err := ctx.ReadResource("azure-nextgen:batch/v20151201:BatchAccount", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering BatchAccount resources.
type batchAccountState struct {
	// The endpoint used by this account to interact with the Batch services.
	AccountEndpoint *string `pulumi:"accountEndpoint"`
	// The active job and job schedule quota for this Batch account.
	ActiveJobAndJobScheduleQuota *int `pulumi:"activeJobAndJobScheduleQuota"`
	// The properties and status of any auto storage account associated with the account.
	AutoStorage *AutoStoragePropertiesResponse `pulumi:"autoStorage"`
	// The core quota for this Batch account.
	CoreQuota *int `pulumi:"coreQuota"`
	// The location of the resource
	Location *string `pulumi:"location"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// The pool quota for this Batch account.
	PoolQuota *int `pulumi:"poolQuota"`
	// The provisioned state of the resource
	ProvisioningState *string `pulumi:"provisioningState"`
	// The tags of the resource
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource
	Type *string `pulumi:"type"`
}

type BatchAccountState struct {
	// The endpoint used by this account to interact with the Batch services.
	AccountEndpoint pulumi.StringPtrInput
	// The active job and job schedule quota for this Batch account.
	ActiveJobAndJobScheduleQuota pulumi.IntPtrInput
	// The properties and status of any auto storage account associated with the account.
	AutoStorage AutoStoragePropertiesResponsePtrInput
	// The core quota for this Batch account.
	CoreQuota pulumi.IntPtrInput
	// The location of the resource
	Location pulumi.StringPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// The pool quota for this Batch account.
	PoolQuota pulumi.IntPtrInput
	// The provisioned state of the resource
	ProvisioningState pulumi.StringPtrInput
	// The tags of the resource
	Tags pulumi.StringMapInput
	// The type of the resource
	Type pulumi.StringPtrInput
}

func (BatchAccountState) ElementType() reflect.Type {
	return reflect.TypeOf((*batchAccountState)(nil)).Elem()
}

type batchAccountArgs struct {
	// A name for the Batch account which must be unique within the region. Batch account names must be between 3 and 24 characters in length and must use only numbers and lowercase letters. This name is used as part of the DNS name that is used to access the Batch service in the region in which the account is created. For example: http://accountname.region.batch.azure.com/.
	AccountName string `pulumi:"accountName"`
	// The properties related to auto storage account.
	AutoStorage *AutoStorageBaseProperties `pulumi:"autoStorage"`
	// The region in which to create the account.
	Location *string `pulumi:"location"`
	// The name of the resource group that contains the new Batch account.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The user specified tags associated with the account.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a BatchAccount resource.
type BatchAccountArgs struct {
	// A name for the Batch account which must be unique within the region. Batch account names must be between 3 and 24 characters in length and must use only numbers and lowercase letters. This name is used as part of the DNS name that is used to access the Batch service in the region in which the account is created. For example: http://accountname.region.batch.azure.com/.
	AccountName pulumi.StringInput
	// The properties related to auto storage account.
	AutoStorage AutoStorageBasePropertiesPtrInput
	// The region in which to create the account.
	Location pulumi.StringPtrInput
	// The name of the resource group that contains the new Batch account.
	ResourceGroupName pulumi.StringInput
	// The user specified tags associated with the account.
	Tags pulumi.StringMapInput
}

func (BatchAccountArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*batchAccountArgs)(nil)).Elem()
}

type BatchAccountInput interface {
	pulumi.Input

	ToBatchAccountOutput() BatchAccountOutput
	ToBatchAccountOutputWithContext(ctx context.Context) BatchAccountOutput
}

func (*BatchAccount) ElementType() reflect.Type {
	return reflect.TypeOf((*BatchAccount)(nil))
}

func (i *BatchAccount) ToBatchAccountOutput() BatchAccountOutput {
	return i.ToBatchAccountOutputWithContext(context.Background())
}

func (i *BatchAccount) ToBatchAccountOutputWithContext(ctx context.Context) BatchAccountOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BatchAccountOutput)
}

type BatchAccountOutput struct {
	*pulumi.OutputState
}

func (BatchAccountOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*BatchAccount)(nil))
}

func (o BatchAccountOutput) ToBatchAccountOutput() BatchAccountOutput {
	return o
}

func (o BatchAccountOutput) ToBatchAccountOutputWithContext(ctx context.Context) BatchAccountOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(BatchAccountOutput{})
}
