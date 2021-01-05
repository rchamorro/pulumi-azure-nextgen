# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from . import outputs
from ._enums import *

__all__ = ['Subscription']


class Subscription(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 auto_delete_on_idle: Optional[pulumi.Input[str]] = None,
                 dead_lettering_on_filter_evaluation_exceptions: Optional[pulumi.Input[bool]] = None,
                 dead_lettering_on_message_expiration: Optional[pulumi.Input[bool]] = None,
                 default_message_time_to_live: Optional[pulumi.Input[str]] = None,
                 duplicate_detection_history_time_window: Optional[pulumi.Input[str]] = None,
                 enable_batched_operations: Optional[pulumi.Input[bool]] = None,
                 forward_dead_lettered_messages_to: Optional[pulumi.Input[str]] = None,
                 forward_to: Optional[pulumi.Input[str]] = None,
                 lock_duration: Optional[pulumi.Input[str]] = None,
                 max_delivery_count: Optional[pulumi.Input[int]] = None,
                 namespace_name: Optional[pulumi.Input[str]] = None,
                 requires_session: Optional[pulumi.Input[bool]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input['EntityStatus']] = None,
                 subscription_name: Optional[pulumi.Input[str]] = None,
                 topic_name: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Description of subscription resource.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] auto_delete_on_idle: ISO 8061 timeSpan idle interval after which the topic is automatically deleted. The minimum duration is 5 minutes.
        :param pulumi.Input[bool] dead_lettering_on_filter_evaluation_exceptions: Value that indicates whether a subscription has dead letter support on filter evaluation exceptions.
        :param pulumi.Input[bool] dead_lettering_on_message_expiration: Value that indicates whether a subscription has dead letter support when a message expires.
        :param pulumi.Input[str] default_message_time_to_live: ISO 8061 Default message timespan to live value. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not set on a message itself.
        :param pulumi.Input[str] duplicate_detection_history_time_window: ISO 8601 timeSpan structure that defines the duration of the duplicate detection history. The default value is 10 minutes.
        :param pulumi.Input[bool] enable_batched_operations: Value that indicates whether server-side batched operations are enabled.
        :param pulumi.Input[str] forward_dead_lettered_messages_to: Queue/Topic name to forward the Dead Letter message
        :param pulumi.Input[str] forward_to: Queue/Topic name to forward the messages
        :param pulumi.Input[str] lock_duration: ISO 8061 lock duration timespan for the subscription. The default value is 1 minute.
        :param pulumi.Input[int] max_delivery_count: Number of maximum deliveries.
        :param pulumi.Input[str] namespace_name: The namespace name
        :param pulumi.Input[bool] requires_session: Value indicating if a subscription supports the concept of sessions.
        :param pulumi.Input[str] resource_group_name: Name of the Resource group within the Azure subscription.
        :param pulumi.Input['EntityStatus'] status: Enumerates the possible values for the status of a messaging entity.
        :param pulumi.Input[str] subscription_name: The subscription name.
        :param pulumi.Input[str] topic_name: The topic name.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            __props__['auto_delete_on_idle'] = auto_delete_on_idle
            __props__['dead_lettering_on_filter_evaluation_exceptions'] = dead_lettering_on_filter_evaluation_exceptions
            __props__['dead_lettering_on_message_expiration'] = dead_lettering_on_message_expiration
            __props__['default_message_time_to_live'] = default_message_time_to_live
            __props__['duplicate_detection_history_time_window'] = duplicate_detection_history_time_window
            __props__['enable_batched_operations'] = enable_batched_operations
            __props__['forward_dead_lettered_messages_to'] = forward_dead_lettered_messages_to
            __props__['forward_to'] = forward_to
            __props__['lock_duration'] = lock_duration
            __props__['max_delivery_count'] = max_delivery_count
            if namespace_name is None and not opts.urn:
                raise TypeError("Missing required property 'namespace_name'")
            __props__['namespace_name'] = namespace_name
            __props__['requires_session'] = requires_session
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['status'] = status
            if subscription_name is None and not opts.urn:
                raise TypeError("Missing required property 'subscription_name'")
            __props__['subscription_name'] = subscription_name
            if topic_name is None and not opts.urn:
                raise TypeError("Missing required property 'topic_name'")
            __props__['topic_name'] = topic_name
            __props__['accessed_at'] = None
            __props__['count_details'] = None
            __props__['created_at'] = None
            __props__['message_count'] = None
            __props__['name'] = None
            __props__['type'] = None
            __props__['updated_at'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:servicebus/latest:Subscription"), pulumi.Alias(type_="azure-nextgen:servicebus/v20140901:Subscription"), pulumi.Alias(type_="azure-nextgen:servicebus/v20150801:Subscription"), pulumi.Alias(type_="azure-nextgen:servicebus/v20180101preview:Subscription")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(Subscription, __self__).__init__(
            'azure-nextgen:servicebus/v20170401:Subscription',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Subscription':
        """
        Get an existing Subscription resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return Subscription(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="accessedAt")
    def accessed_at(self) -> pulumi.Output[str]:
        """
        Last time there was a receive request to this subscription.
        """
        return pulumi.get(self, "accessed_at")

    @property
    @pulumi.getter(name="autoDeleteOnIdle")
    def auto_delete_on_idle(self) -> pulumi.Output[Optional[str]]:
        """
        ISO 8061 timeSpan idle interval after which the topic is automatically deleted. The minimum duration is 5 minutes.
        """
        return pulumi.get(self, "auto_delete_on_idle")

    @property
    @pulumi.getter(name="countDetails")
    def count_details(self) -> pulumi.Output['outputs.MessageCountDetailsResponse']:
        """
        Message count details
        """
        return pulumi.get(self, "count_details")

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> pulumi.Output[str]:
        """
        Exact time the message was created.
        """
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter(name="deadLetteringOnFilterEvaluationExceptions")
    def dead_lettering_on_filter_evaluation_exceptions(self) -> pulumi.Output[Optional[bool]]:
        """
        Value that indicates whether a subscription has dead letter support on filter evaluation exceptions.
        """
        return pulumi.get(self, "dead_lettering_on_filter_evaluation_exceptions")

    @property
    @pulumi.getter(name="deadLetteringOnMessageExpiration")
    def dead_lettering_on_message_expiration(self) -> pulumi.Output[Optional[bool]]:
        """
        Value that indicates whether a subscription has dead letter support when a message expires.
        """
        return pulumi.get(self, "dead_lettering_on_message_expiration")

    @property
    @pulumi.getter(name="defaultMessageTimeToLive")
    def default_message_time_to_live(self) -> pulumi.Output[Optional[str]]:
        """
        ISO 8061 Default message timespan to live value. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not set on a message itself.
        """
        return pulumi.get(self, "default_message_time_to_live")

    @property
    @pulumi.getter(name="duplicateDetectionHistoryTimeWindow")
    def duplicate_detection_history_time_window(self) -> pulumi.Output[Optional[str]]:
        """
        ISO 8601 timeSpan structure that defines the duration of the duplicate detection history. The default value is 10 minutes.
        """
        return pulumi.get(self, "duplicate_detection_history_time_window")

    @property
    @pulumi.getter(name="enableBatchedOperations")
    def enable_batched_operations(self) -> pulumi.Output[Optional[bool]]:
        """
        Value that indicates whether server-side batched operations are enabled.
        """
        return pulumi.get(self, "enable_batched_operations")

    @property
    @pulumi.getter(name="forwardDeadLetteredMessagesTo")
    def forward_dead_lettered_messages_to(self) -> pulumi.Output[Optional[str]]:
        """
        Queue/Topic name to forward the Dead Letter message
        """
        return pulumi.get(self, "forward_dead_lettered_messages_to")

    @property
    @pulumi.getter(name="forwardTo")
    def forward_to(self) -> pulumi.Output[Optional[str]]:
        """
        Queue/Topic name to forward the messages
        """
        return pulumi.get(self, "forward_to")

    @property
    @pulumi.getter(name="lockDuration")
    def lock_duration(self) -> pulumi.Output[Optional[str]]:
        """
        ISO 8061 lock duration timespan for the subscription. The default value is 1 minute.
        """
        return pulumi.get(self, "lock_duration")

    @property
    @pulumi.getter(name="maxDeliveryCount")
    def max_delivery_count(self) -> pulumi.Output[Optional[int]]:
        """
        Number of maximum deliveries.
        """
        return pulumi.get(self, "max_delivery_count")

    @property
    @pulumi.getter(name="messageCount")
    def message_count(self) -> pulumi.Output[float]:
        """
        Number of messages.
        """
        return pulumi.get(self, "message_count")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="requiresSession")
    def requires_session(self) -> pulumi.Output[Optional[bool]]:
        """
        Value indicating if a subscription supports the concept of sessions.
        """
        return pulumi.get(self, "requires_session")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[Optional[str]]:
        """
        Enumerates the possible values for the status of a messaging entity.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Resource type
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="updatedAt")
    def updated_at(self) -> pulumi.Output[str]:
        """
        The exact time the message was updated.
        """
        return pulumi.get(self, "updated_at")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

