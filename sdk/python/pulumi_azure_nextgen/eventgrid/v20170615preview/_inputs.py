# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from ._enums import *

__all__ = [
    'EventSubscriptionDestinationArgs',
    'EventSubscriptionFilterArgs',
]

@pulumi.input_type
class EventSubscriptionDestinationArgs:
    def __init__(__self__, *,
                 endpoint_type: Optional[pulumi.Input[Union[str, 'EndpointType']]] = None,
                 endpoint_url: Optional[pulumi.Input[str]] = None):
        """
        Information about the destination for an event subscription
        :param pulumi.Input[Union[str, 'EndpointType']] endpoint_type: Type of the endpoint for the event subscription destination
        :param pulumi.Input[str] endpoint_url: The URL that represents the endpoint of the destination of an event subscription.
        """
        if endpoint_type is not None:
            pulumi.set(__self__, "endpoint_type", endpoint_type)
        if endpoint_url is not None:
            pulumi.set(__self__, "endpoint_url", endpoint_url)

    @property
    @pulumi.getter(name="endpointType")
    def endpoint_type(self) -> Optional[pulumi.Input[Union[str, 'EndpointType']]]:
        """
        Type of the endpoint for the event subscription destination
        """
        return pulumi.get(self, "endpoint_type")

    @endpoint_type.setter
    def endpoint_type(self, value: Optional[pulumi.Input[Union[str, 'EndpointType']]]):
        pulumi.set(self, "endpoint_type", value)

    @property
    @pulumi.getter(name="endpointUrl")
    def endpoint_url(self) -> Optional[pulumi.Input[str]]:
        """
        The URL that represents the endpoint of the destination of an event subscription.
        """
        return pulumi.get(self, "endpoint_url")

    @endpoint_url.setter
    def endpoint_url(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "endpoint_url", value)


@pulumi.input_type
class EventSubscriptionFilterArgs:
    def __init__(__self__, *,
                 included_event_types: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 is_subject_case_sensitive: Optional[pulumi.Input[bool]] = None,
                 subject_begins_with: Optional[pulumi.Input[str]] = None,
                 subject_ends_with: Optional[pulumi.Input[str]] = None):
        """
        Filter for the Event Subscription
        :param pulumi.Input[Sequence[pulumi.Input[str]]] included_event_types: A list of applicable event types that need to be part of the event subscription. 
               If it is desired to subscribe to all event types, the string "all" needs to be specified as an element in this list.
        :param pulumi.Input[bool] is_subject_case_sensitive: Specifies if the SubjectBeginsWith and SubjectEndsWith properties of the filter 
               should be compared in a case sensitive manner.
        :param pulumi.Input[str] subject_begins_with: An optional string to filter events for an event subscription based on a resource path prefix.
               The format of this depends on the publisher of the events. 
               Wildcard characters are not supported in this path.
        :param pulumi.Input[str] subject_ends_with: An optional string to filter events for an event subscription based on a resource path suffix.
               Wildcard characters are not supported in this path.
        """
        if included_event_types is not None:
            pulumi.set(__self__, "included_event_types", included_event_types)
        if is_subject_case_sensitive is None:
            is_subject_case_sensitive = False
        if is_subject_case_sensitive is not None:
            pulumi.set(__self__, "is_subject_case_sensitive", is_subject_case_sensitive)
        if subject_begins_with is not None:
            pulumi.set(__self__, "subject_begins_with", subject_begins_with)
        if subject_ends_with is not None:
            pulumi.set(__self__, "subject_ends_with", subject_ends_with)

    @property
    @pulumi.getter(name="includedEventTypes")
    def included_event_types(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        A list of applicable event types that need to be part of the event subscription. 
        If it is desired to subscribe to all event types, the string "all" needs to be specified as an element in this list.
        """
        return pulumi.get(self, "included_event_types")

    @included_event_types.setter
    def included_event_types(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "included_event_types", value)

    @property
    @pulumi.getter(name="isSubjectCaseSensitive")
    def is_subject_case_sensitive(self) -> Optional[pulumi.Input[bool]]:
        """
        Specifies if the SubjectBeginsWith and SubjectEndsWith properties of the filter 
        should be compared in a case sensitive manner.
        """
        return pulumi.get(self, "is_subject_case_sensitive")

    @is_subject_case_sensitive.setter
    def is_subject_case_sensitive(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "is_subject_case_sensitive", value)

    @property
    @pulumi.getter(name="subjectBeginsWith")
    def subject_begins_with(self) -> Optional[pulumi.Input[str]]:
        """
        An optional string to filter events for an event subscription based on a resource path prefix.
        The format of this depends on the publisher of the events. 
        Wildcard characters are not supported in this path.
        """
        return pulumi.get(self, "subject_begins_with")

    @subject_begins_with.setter
    def subject_begins_with(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "subject_begins_with", value)

    @property
    @pulumi.getter(name="subjectEndsWith")
    def subject_ends_with(self) -> Optional[pulumi.Input[str]]:
        """
        An optional string to filter events for an event subscription based on a resource path suffix.
        Wildcard characters are not supported in this path.
        """
        return pulumi.get(self, "subject_ends_with")

    @subject_ends_with.setter
    def subject_ends_with(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "subject_ends_with", value)


