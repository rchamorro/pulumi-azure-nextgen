// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200401preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Event Subscription
type PartnerTopicEventSubscription struct {
	pulumi.CustomResourceState

	// The dead letter destination of the event subscription. Any event that cannot be delivered to its' destination is sent to the dead letter destination.
	// Uses Azure Event Grid's identity to acquire the authentication tokens being used during delivery / dead-lettering.
	DeadLetterDestination StorageBlobDeadLetterDestinationResponsePtrOutput `pulumi:"deadLetterDestination"`
	// The dead letter destination of the event subscription. Any event that cannot be delivered to its' destination is sent to the dead letter destination.
	// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens being used during delivery / dead-lettering.
	DeadLetterWithResourceIdentity DeadLetterWithResourceIdentityResponsePtrOutput `pulumi:"deadLetterWithResourceIdentity"`
	// Information about the destination where events have to be delivered for the event subscription.
	// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens being used during delivery / dead-lettering.
	DeliveryWithResourceIdentity DeliveryWithResourceIdentityResponsePtrOutput `pulumi:"deliveryWithResourceIdentity"`
	// Information about the destination where events have to be delivered for the event subscription.
	// Uses Azure Event Grid's identity to acquire the authentication tokens being used during delivery / dead-lettering.
	Destination pulumi.AnyOutput `pulumi:"destination"`
	// The event delivery schema for the event subscription.
	EventDeliverySchema pulumi.StringPtrOutput `pulumi:"eventDeliverySchema"`
	// Expiration time of the event subscription.
	ExpirationTimeUtc pulumi.StringPtrOutput `pulumi:"expirationTimeUtc"`
	// Information about the filter for the event subscription.
	Filter EventSubscriptionFilterResponsePtrOutput `pulumi:"filter"`
	// List of user defined labels.
	Labels pulumi.StringArrayOutput `pulumi:"labels"`
	// Name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// Provisioning state of the event subscription.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The retry policy for events. This can be used to configure maximum number of delivery attempts and time to live for events.
	RetryPolicy RetryPolicyResponsePtrOutput `pulumi:"retryPolicy"`
	// Name of the topic of the event subscription.
	Topic pulumi.StringOutput `pulumi:"topic"`
	// Type of the resource
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewPartnerTopicEventSubscription registers a new resource with the given unique name, arguments, and options.
func NewPartnerTopicEventSubscription(ctx *pulumi.Context,
	name string, args *PartnerTopicEventSubscriptionArgs, opts ...pulumi.ResourceOption) (*PartnerTopicEventSubscription, error) {
	if args == nil || args.EventSubscriptionName == nil {
		return nil, errors.New("missing required argument 'EventSubscriptionName'")
	}
	if args == nil || args.PartnerTopicName == nil {
		return nil, errors.New("missing required argument 'PartnerTopicName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &PartnerTopicEventSubscriptionArgs{}
	}
	var resource PartnerTopicEventSubscription
	err := ctx.RegisterResource("azure-nextgen:eventgrid/v20200401preview:PartnerTopicEventSubscription", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPartnerTopicEventSubscription gets an existing PartnerTopicEventSubscription resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPartnerTopicEventSubscription(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PartnerTopicEventSubscriptionState, opts ...pulumi.ResourceOption) (*PartnerTopicEventSubscription, error) {
	var resource PartnerTopicEventSubscription
	err := ctx.ReadResource("azure-nextgen:eventgrid/v20200401preview:PartnerTopicEventSubscription", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PartnerTopicEventSubscription resources.
type partnerTopicEventSubscriptionState struct {
	// The dead letter destination of the event subscription. Any event that cannot be delivered to its' destination is sent to the dead letter destination.
	// Uses Azure Event Grid's identity to acquire the authentication tokens being used during delivery / dead-lettering.
	DeadLetterDestination *StorageBlobDeadLetterDestinationResponse `pulumi:"deadLetterDestination"`
	// The dead letter destination of the event subscription. Any event that cannot be delivered to its' destination is sent to the dead letter destination.
	// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens being used during delivery / dead-lettering.
	DeadLetterWithResourceIdentity *DeadLetterWithResourceIdentityResponse `pulumi:"deadLetterWithResourceIdentity"`
	// Information about the destination where events have to be delivered for the event subscription.
	// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens being used during delivery / dead-lettering.
	DeliveryWithResourceIdentity *DeliveryWithResourceIdentityResponse `pulumi:"deliveryWithResourceIdentity"`
	// Information about the destination where events have to be delivered for the event subscription.
	// Uses Azure Event Grid's identity to acquire the authentication tokens being used during delivery / dead-lettering.
	Destination interface{} `pulumi:"destination"`
	// The event delivery schema for the event subscription.
	EventDeliverySchema *string `pulumi:"eventDeliverySchema"`
	// Expiration time of the event subscription.
	ExpirationTimeUtc *string `pulumi:"expirationTimeUtc"`
	// Information about the filter for the event subscription.
	Filter *EventSubscriptionFilterResponse `pulumi:"filter"`
	// List of user defined labels.
	Labels []string `pulumi:"labels"`
	// Name of the resource
	Name *string `pulumi:"name"`
	// Provisioning state of the event subscription.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The retry policy for events. This can be used to configure maximum number of delivery attempts and time to live for events.
	RetryPolicy *RetryPolicyResponse `pulumi:"retryPolicy"`
	// Name of the topic of the event subscription.
	Topic *string `pulumi:"topic"`
	// Type of the resource
	Type *string `pulumi:"type"`
}

type PartnerTopicEventSubscriptionState struct {
	// The dead letter destination of the event subscription. Any event that cannot be delivered to its' destination is sent to the dead letter destination.
	// Uses Azure Event Grid's identity to acquire the authentication tokens being used during delivery / dead-lettering.
	DeadLetterDestination StorageBlobDeadLetterDestinationResponsePtrInput
	// The dead letter destination of the event subscription. Any event that cannot be delivered to its' destination is sent to the dead letter destination.
	// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens being used during delivery / dead-lettering.
	DeadLetterWithResourceIdentity DeadLetterWithResourceIdentityResponsePtrInput
	// Information about the destination where events have to be delivered for the event subscription.
	// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens being used during delivery / dead-lettering.
	DeliveryWithResourceIdentity DeliveryWithResourceIdentityResponsePtrInput
	// Information about the destination where events have to be delivered for the event subscription.
	// Uses Azure Event Grid's identity to acquire the authentication tokens being used during delivery / dead-lettering.
	Destination pulumi.Input
	// The event delivery schema for the event subscription.
	EventDeliverySchema pulumi.StringPtrInput
	// Expiration time of the event subscription.
	ExpirationTimeUtc pulumi.StringPtrInput
	// Information about the filter for the event subscription.
	Filter EventSubscriptionFilterResponsePtrInput
	// List of user defined labels.
	Labels pulumi.StringArrayInput
	// Name of the resource
	Name pulumi.StringPtrInput
	// Provisioning state of the event subscription.
	ProvisioningState pulumi.StringPtrInput
	// The retry policy for events. This can be used to configure maximum number of delivery attempts and time to live for events.
	RetryPolicy RetryPolicyResponsePtrInput
	// Name of the topic of the event subscription.
	Topic pulumi.StringPtrInput
	// Type of the resource
	Type pulumi.StringPtrInput
}

func (PartnerTopicEventSubscriptionState) ElementType() reflect.Type {
	return reflect.TypeOf((*partnerTopicEventSubscriptionState)(nil)).Elem()
}

type partnerTopicEventSubscriptionArgs struct {
	// The dead letter destination of the event subscription. Any event that cannot be delivered to its' destination is sent to the dead letter destination.
	// Uses Azure Event Grid's identity to acquire the authentication tokens being used during delivery / dead-lettering.
	DeadLetterDestination *StorageBlobDeadLetterDestination `pulumi:"deadLetterDestination"`
	// The dead letter destination of the event subscription. Any event that cannot be delivered to its' destination is sent to the dead letter destination.
	// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens being used during delivery / dead-lettering.
	DeadLetterWithResourceIdentity *DeadLetterWithResourceIdentity `pulumi:"deadLetterWithResourceIdentity"`
	// Information about the destination where events have to be delivered for the event subscription.
	// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens being used during delivery / dead-lettering.
	DeliveryWithResourceIdentity *DeliveryWithResourceIdentity `pulumi:"deliveryWithResourceIdentity"`
	// Information about the destination where events have to be delivered for the event subscription.
	// Uses Azure Event Grid's identity to acquire the authentication tokens being used during delivery / dead-lettering.
	Destination interface{} `pulumi:"destination"`
	// The event delivery schema for the event subscription.
	EventDeliverySchema *string `pulumi:"eventDeliverySchema"`
	// Name of the event subscription to be created. Event subscription names must be between 3 and 100 characters in length and use alphanumeric letters only.
	EventSubscriptionName string `pulumi:"eventSubscriptionName"`
	// Expiration time of the event subscription.
	ExpirationTimeUtc *string `pulumi:"expirationTimeUtc"`
	// Information about the filter for the event subscription.
	Filter *EventSubscriptionFilter `pulumi:"filter"`
	// List of user defined labels.
	Labels []string `pulumi:"labels"`
	// Name of the partner topic.
	PartnerTopicName string `pulumi:"partnerTopicName"`
	// The name of the resource group within the user's subscription.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The retry policy for events. This can be used to configure maximum number of delivery attempts and time to live for events.
	RetryPolicy *RetryPolicy `pulumi:"retryPolicy"`
}

// The set of arguments for constructing a PartnerTopicEventSubscription resource.
type PartnerTopicEventSubscriptionArgs struct {
	// The dead letter destination of the event subscription. Any event that cannot be delivered to its' destination is sent to the dead letter destination.
	// Uses Azure Event Grid's identity to acquire the authentication tokens being used during delivery / dead-lettering.
	DeadLetterDestination StorageBlobDeadLetterDestinationPtrInput
	// The dead letter destination of the event subscription. Any event that cannot be delivered to its' destination is sent to the dead letter destination.
	// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens being used during delivery / dead-lettering.
	DeadLetterWithResourceIdentity DeadLetterWithResourceIdentityPtrInput
	// Information about the destination where events have to be delivered for the event subscription.
	// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens being used during delivery / dead-lettering.
	DeliveryWithResourceIdentity DeliveryWithResourceIdentityPtrInput
	// Information about the destination where events have to be delivered for the event subscription.
	// Uses Azure Event Grid's identity to acquire the authentication tokens being used during delivery / dead-lettering.
	Destination pulumi.Input
	// The event delivery schema for the event subscription.
	EventDeliverySchema pulumi.StringPtrInput
	// Name of the event subscription to be created. Event subscription names must be between 3 and 100 characters in length and use alphanumeric letters only.
	EventSubscriptionName pulumi.StringInput
	// Expiration time of the event subscription.
	ExpirationTimeUtc pulumi.StringPtrInput
	// Information about the filter for the event subscription.
	Filter EventSubscriptionFilterPtrInput
	// List of user defined labels.
	Labels pulumi.StringArrayInput
	// Name of the partner topic.
	PartnerTopicName pulumi.StringInput
	// The name of the resource group within the user's subscription.
	ResourceGroupName pulumi.StringInput
	// The retry policy for events. This can be used to configure maximum number of delivery attempts and time to live for events.
	RetryPolicy RetryPolicyPtrInput
}

func (PartnerTopicEventSubscriptionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*partnerTopicEventSubscriptionArgs)(nil)).Elem()
}

type PartnerTopicEventSubscriptionInput interface {
	pulumi.Input

	ToPartnerTopicEventSubscriptionOutput() PartnerTopicEventSubscriptionOutput
	ToPartnerTopicEventSubscriptionOutputWithContext(ctx context.Context) PartnerTopicEventSubscriptionOutput
}

func (PartnerTopicEventSubscription) ElementType() reflect.Type {
	return reflect.TypeOf((*PartnerTopicEventSubscription)(nil)).Elem()
}

func (i PartnerTopicEventSubscription) ToPartnerTopicEventSubscriptionOutput() PartnerTopicEventSubscriptionOutput {
	return i.ToPartnerTopicEventSubscriptionOutputWithContext(context.Background())
}

func (i PartnerTopicEventSubscription) ToPartnerTopicEventSubscriptionOutputWithContext(ctx context.Context) PartnerTopicEventSubscriptionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PartnerTopicEventSubscriptionOutput)
}

type PartnerTopicEventSubscriptionOutput struct {
	*pulumi.OutputState
}

func (PartnerTopicEventSubscriptionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*PartnerTopicEventSubscriptionOutput)(nil)).Elem()
}

func (o PartnerTopicEventSubscriptionOutput) ToPartnerTopicEventSubscriptionOutput() PartnerTopicEventSubscriptionOutput {
	return o
}

func (o PartnerTopicEventSubscriptionOutput) ToPartnerTopicEventSubscriptionOutputWithContext(ctx context.Context) PartnerTopicEventSubscriptionOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(PartnerTopicEventSubscriptionOutput{})
}
