// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190601

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type Queue struct {
	pulumi.CustomResourceState

	// Integer indicating an approximate number of messages in the queue. This number is not lower than the actual number of messages in the queue, but could be higher.
	ApproximateMessageCount pulumi.IntOutput `pulumi:"approximateMessageCount"`
	// A name-value pair that represents queue metadata.
	Metadata pulumi.StringMapOutput `pulumi:"metadata"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewQueue registers a new resource with the given unique name, arguments, and options.
func NewQueue(ctx *pulumi.Context,
	name string, args *QueueArgs, opts ...pulumi.ResourceOption) (*Queue, error) {
	if args == nil || args.AccountName == nil {
		return nil, errors.New("missing required argument 'AccountName'")
	}
	if args == nil || args.QueueName == nil {
		return nil, errors.New("missing required argument 'QueueName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &QueueArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:storage/latest:Queue"),
		},
		{
			Type: pulumi.String("azure-nextgen:storage/v20200801preview:Queue"),
		},
	})
	opts = append(opts, aliases)
	var resource Queue
	err := ctx.RegisterResource("azure-nextgen:storage/v20190601:Queue", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetQueue gets an existing Queue resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetQueue(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *QueueState, opts ...pulumi.ResourceOption) (*Queue, error) {
	var resource Queue
	err := ctx.ReadResource("azure-nextgen:storage/v20190601:Queue", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Queue resources.
type queueState struct {
	// Integer indicating an approximate number of messages in the queue. This number is not lower than the actual number of messages in the queue, but could be higher.
	ApproximateMessageCount *int `pulumi:"approximateMessageCount"`
	// A name-value pair that represents queue metadata.
	Metadata map[string]string `pulumi:"metadata"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
}

type QueueState struct {
	// Integer indicating an approximate number of messages in the queue. This number is not lower than the actual number of messages in the queue, but could be higher.
	ApproximateMessageCount pulumi.IntPtrInput
	// A name-value pair that represents queue metadata.
	Metadata pulumi.StringMapInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
}

func (QueueState) ElementType() reflect.Type {
	return reflect.TypeOf((*queueState)(nil)).Elem()
}

type queueArgs struct {
	// The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
	AccountName string `pulumi:"accountName"`
	// A name-value pair that represents queue metadata.
	Metadata map[string]string `pulumi:"metadata"`
	// A queue name must be unique within a storage account and must be between 3 and 63 characters.The name must comprise of lowercase alphanumeric and dash(-) characters only, it should begin and end with an alphanumeric character and it cannot have two consecutive dash(-) characters.
	QueueName string `pulumi:"queueName"`
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The set of arguments for constructing a Queue resource.
type QueueArgs struct {
	// The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
	AccountName pulumi.StringInput
	// A name-value pair that represents queue metadata.
	Metadata pulumi.StringMapInput
	// A queue name must be unique within a storage account and must be between 3 and 63 characters.The name must comprise of lowercase alphanumeric and dash(-) characters only, it should begin and end with an alphanumeric character and it cannot have two consecutive dash(-) characters.
	QueueName pulumi.StringInput
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
}

func (QueueArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*queueArgs)(nil)).Elem()
}

type QueueInput interface {
	pulumi.Input

	ToQueueOutput() QueueOutput
	ToQueueOutputWithContext(ctx context.Context) QueueOutput
}

func (Queue) ElementType() reflect.Type {
	return reflect.TypeOf((*Queue)(nil)).Elem()
}

func (i Queue) ToQueueOutput() QueueOutput {
	return i.ToQueueOutputWithContext(context.Background())
}

func (i Queue) ToQueueOutputWithContext(ctx context.Context) QueueOutput {
	return pulumi.ToOutputWithContext(ctx, i).(QueueOutput)
}

type QueueOutput struct {
	*pulumi.OutputState
}

func (QueueOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*QueueOutput)(nil)).Elem()
}

func (o QueueOutput) ToQueueOutput() QueueOutput {
	return o
}

func (o QueueOutput) ToQueueOutputWithContext(ctx context.Context) QueueOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(QueueOutput{})
}
