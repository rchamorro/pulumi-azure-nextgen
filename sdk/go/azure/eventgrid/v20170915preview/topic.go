// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20170915preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// EventGrid Topic
type Topic struct {
	pulumi.CustomResourceState

	// Endpoint for the topic.
	Endpoint pulumi.StringOutput `pulumi:"endpoint"`
	// Location of the resource
	Location pulumi.StringOutput `pulumi:"location"`
	// Name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// Provisioning state of the topic.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Tags of the resource
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Type of the resource
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewTopic registers a new resource with the given unique name, arguments, and options.
func NewTopic(ctx *pulumi.Context,
	name string, args *TopicArgs, opts ...pulumi.ResourceOption) (*Topic, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.TopicName == nil {
		return nil, errors.New("invalid value for required argument 'TopicName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:eventgrid/latest:Topic"),
		},
		{
			Type: pulumi.String("azure-nextgen:eventgrid/v20170615preview:Topic"),
		},
		{
			Type: pulumi.String("azure-nextgen:eventgrid/v20180101:Topic"),
		},
		{
			Type: pulumi.String("azure-nextgen:eventgrid/v20180501preview:Topic"),
		},
		{
			Type: pulumi.String("azure-nextgen:eventgrid/v20180915preview:Topic"),
		},
		{
			Type: pulumi.String("azure-nextgen:eventgrid/v20190101:Topic"),
		},
		{
			Type: pulumi.String("azure-nextgen:eventgrid/v20190201preview:Topic"),
		},
		{
			Type: pulumi.String("azure-nextgen:eventgrid/v20190601:Topic"),
		},
		{
			Type: pulumi.String("azure-nextgen:eventgrid/v20200101preview:Topic"),
		},
		{
			Type: pulumi.String("azure-nextgen:eventgrid/v20200401preview:Topic"),
		},
		{
			Type: pulumi.String("azure-nextgen:eventgrid/v20200601:Topic"),
		},
		{
			Type: pulumi.String("azure-nextgen:eventgrid/v20201015preview:Topic"),
		},
	})
	opts = append(opts, aliases)
	var resource Topic
	err := ctx.RegisterResource("azure-nextgen:eventgrid/v20170915preview:Topic", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTopic gets an existing Topic resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTopic(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TopicState, opts ...pulumi.ResourceOption) (*Topic, error) {
	var resource Topic
	err := ctx.ReadResource("azure-nextgen:eventgrid/v20170915preview:Topic", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Topic resources.
type topicState struct {
	// Endpoint for the topic.
	Endpoint *string `pulumi:"endpoint"`
	// Location of the resource
	Location *string `pulumi:"location"`
	// Name of the resource
	Name *string `pulumi:"name"`
	// Provisioning state of the topic.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Tags of the resource
	Tags map[string]string `pulumi:"tags"`
	// Type of the resource
	Type *string `pulumi:"type"`
}

type TopicState struct {
	// Endpoint for the topic.
	Endpoint pulumi.StringPtrInput
	// Location of the resource
	Location pulumi.StringPtrInput
	// Name of the resource
	Name pulumi.StringPtrInput
	// Provisioning state of the topic.
	ProvisioningState pulumi.StringPtrInput
	// Tags of the resource
	Tags pulumi.StringMapInput
	// Type of the resource
	Type pulumi.StringPtrInput
}

func (TopicState) ElementType() reflect.Type {
	return reflect.TypeOf((*topicState)(nil)).Elem()
}

type topicArgs struct {
	// Location of the resource
	Location *string `pulumi:"location"`
	// The name of the resource group within the user's subscription.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Tags of the resource
	Tags map[string]string `pulumi:"tags"`
	// Name of the topic
	TopicName string `pulumi:"topicName"`
}

// The set of arguments for constructing a Topic resource.
type TopicArgs struct {
	// Location of the resource
	Location pulumi.StringPtrInput
	// The name of the resource group within the user's subscription.
	ResourceGroupName pulumi.StringInput
	// Tags of the resource
	Tags pulumi.StringMapInput
	// Name of the topic
	TopicName pulumi.StringInput
}

func (TopicArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*topicArgs)(nil)).Elem()
}

type TopicInput interface {
	pulumi.Input

	ToTopicOutput() TopicOutput
	ToTopicOutputWithContext(ctx context.Context) TopicOutput
}

func (*Topic) ElementType() reflect.Type {
	return reflect.TypeOf((*Topic)(nil))
}

func (i *Topic) ToTopicOutput() TopicOutput {
	return i.ToTopicOutputWithContext(context.Background())
}

func (i *Topic) ToTopicOutputWithContext(ctx context.Context) TopicOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TopicOutput)
}

type TopicOutput struct {
	*pulumi.OutputState
}

func (TopicOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Topic)(nil))
}

func (o TopicOutput) ToTopicOutput() TopicOutput {
	return o
}

func (o TopicOutput) ToTopicOutputWithContext(ctx context.Context) TopicOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(TopicOutput{})
}
