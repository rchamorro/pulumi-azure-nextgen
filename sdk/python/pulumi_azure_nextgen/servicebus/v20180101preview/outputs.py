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

__all__ = [
    'ActionResponse',
    'ConnectionStateResponse',
    'CorrelationFilterResponse',
    'KeyVaultPropertiesResponse',
    'MessageCountDetailsResponse',
    'NWRuleSetIpRulesResponse',
    'NWRuleSetVirtualNetworkRulesResponse',
    'PrivateEndpointResponse',
    'SBSkuResponse',
    'SqlFilterResponse',
    'SubnetResponse',
]

@pulumi.output_type
class ActionResponse(dict):
    """
    Represents the filter actions which are allowed for the transformation of a message that have been matched by a filter expression.
    """
    def __init__(__self__, *,
                 compatibility_level: Optional[int] = None,
                 requires_preprocessing: Optional[bool] = None,
                 sql_expression: Optional[str] = None):
        """
        Represents the filter actions which are allowed for the transformation of a message that have been matched by a filter expression.
        :param int compatibility_level: This property is reserved for future use. An integer value showing the compatibility level, currently hard-coded to 20.
        :param bool requires_preprocessing: Value that indicates whether the rule action requires preprocessing.
        :param str sql_expression: SQL expression. e.g. MyProperty='ABC'
        """
        if compatibility_level is not None:
            pulumi.set(__self__, "compatibility_level", compatibility_level)
        if requires_preprocessing is not None:
            pulumi.set(__self__, "requires_preprocessing", requires_preprocessing)
        if sql_expression is not None:
            pulumi.set(__self__, "sql_expression", sql_expression)

    @property
    @pulumi.getter(name="compatibilityLevel")
    def compatibility_level(self) -> Optional[int]:
        """
        This property is reserved for future use. An integer value showing the compatibility level, currently hard-coded to 20.
        """
        return pulumi.get(self, "compatibility_level")

    @property
    @pulumi.getter(name="requiresPreprocessing")
    def requires_preprocessing(self) -> Optional[bool]:
        """
        Value that indicates whether the rule action requires preprocessing.
        """
        return pulumi.get(self, "requires_preprocessing")

    @property
    @pulumi.getter(name="sqlExpression")
    def sql_expression(self) -> Optional[str]:
        """
        SQL expression. e.g. MyProperty='ABC'
        """
        return pulumi.get(self, "sql_expression")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ConnectionStateResponse(dict):
    """
    ConnectionState information.
    """
    def __init__(__self__, *,
                 description: Optional[str] = None,
                 status: Optional[str] = None):
        """
        ConnectionState information.
        :param str description: Description of the connection state.
        :param str status: Status of the connection.
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if status is not None:
            pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter
    def description(self) -> Optional[str]:
        """
        Description of the connection state.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def status(self) -> Optional[str]:
        """
        Status of the connection.
        """
        return pulumi.get(self, "status")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class CorrelationFilterResponse(dict):
    """
    Represents the correlation filter expression.
    """
    def __init__(__self__, *,
                 content_type: Optional[str] = None,
                 correlation_id: Optional[str] = None,
                 label: Optional[str] = None,
                 message_id: Optional[str] = None,
                 properties: Optional[Mapping[str, str]] = None,
                 reply_to: Optional[str] = None,
                 reply_to_session_id: Optional[str] = None,
                 requires_preprocessing: Optional[bool] = None,
                 session_id: Optional[str] = None,
                 to: Optional[str] = None):
        """
        Represents the correlation filter expression.
        :param str content_type: Content type of the message.
        :param str correlation_id: Identifier of the correlation.
        :param str label: Application specific label.
        :param str message_id: Identifier of the message.
        :param Mapping[str, str] properties: dictionary object for custom filters
        :param str reply_to: Address of the queue to reply to.
        :param str reply_to_session_id: Session identifier to reply to.
        :param bool requires_preprocessing: Value that indicates whether the rule action requires preprocessing.
        :param str session_id: Session identifier.
        :param str to: Address to send to.
        """
        if content_type is not None:
            pulumi.set(__self__, "content_type", content_type)
        if correlation_id is not None:
            pulumi.set(__self__, "correlation_id", correlation_id)
        if label is not None:
            pulumi.set(__self__, "label", label)
        if message_id is not None:
            pulumi.set(__self__, "message_id", message_id)
        if properties is not None:
            pulumi.set(__self__, "properties", properties)
        if reply_to is not None:
            pulumi.set(__self__, "reply_to", reply_to)
        if reply_to_session_id is not None:
            pulumi.set(__self__, "reply_to_session_id", reply_to_session_id)
        if requires_preprocessing is not None:
            pulumi.set(__self__, "requires_preprocessing", requires_preprocessing)
        if session_id is not None:
            pulumi.set(__self__, "session_id", session_id)
        if to is not None:
            pulumi.set(__self__, "to", to)

    @property
    @pulumi.getter(name="contentType")
    def content_type(self) -> Optional[str]:
        """
        Content type of the message.
        """
        return pulumi.get(self, "content_type")

    @property
    @pulumi.getter(name="correlationId")
    def correlation_id(self) -> Optional[str]:
        """
        Identifier of the correlation.
        """
        return pulumi.get(self, "correlation_id")

    @property
    @pulumi.getter
    def label(self) -> Optional[str]:
        """
        Application specific label.
        """
        return pulumi.get(self, "label")

    @property
    @pulumi.getter(name="messageId")
    def message_id(self) -> Optional[str]:
        """
        Identifier of the message.
        """
        return pulumi.get(self, "message_id")

    @property
    @pulumi.getter
    def properties(self) -> Optional[Mapping[str, str]]:
        """
        dictionary object for custom filters
        """
        return pulumi.get(self, "properties")

    @property
    @pulumi.getter(name="replyTo")
    def reply_to(self) -> Optional[str]:
        """
        Address of the queue to reply to.
        """
        return pulumi.get(self, "reply_to")

    @property
    @pulumi.getter(name="replyToSessionId")
    def reply_to_session_id(self) -> Optional[str]:
        """
        Session identifier to reply to.
        """
        return pulumi.get(self, "reply_to_session_id")

    @property
    @pulumi.getter(name="requiresPreprocessing")
    def requires_preprocessing(self) -> Optional[bool]:
        """
        Value that indicates whether the rule action requires preprocessing.
        """
        return pulumi.get(self, "requires_preprocessing")

    @property
    @pulumi.getter(name="sessionId")
    def session_id(self) -> Optional[str]:
        """
        Session identifier.
        """
        return pulumi.get(self, "session_id")

    @property
    @pulumi.getter
    def to(self) -> Optional[str]:
        """
        Address to send to.
        """
        return pulumi.get(self, "to")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class KeyVaultPropertiesResponse(dict):
    """
    Properties to configure keyVault Properties
    """
    def __init__(__self__, *,
                 key_name: Optional[str] = None,
                 key_vault_uri: Optional[str] = None):
        """
        Properties to configure keyVault Properties
        :param str key_name: Name of the Key from KeyVault
        :param str key_vault_uri: Uri of KeyVault
        """
        if key_name is not None:
            pulumi.set(__self__, "key_name", key_name)
        if key_vault_uri is not None:
            pulumi.set(__self__, "key_vault_uri", key_vault_uri)

    @property
    @pulumi.getter(name="keyName")
    def key_name(self) -> Optional[str]:
        """
        Name of the Key from KeyVault
        """
        return pulumi.get(self, "key_name")

    @property
    @pulumi.getter(name="keyVaultUri")
    def key_vault_uri(self) -> Optional[str]:
        """
        Uri of KeyVault
        """
        return pulumi.get(self, "key_vault_uri")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class MessageCountDetailsResponse(dict):
    """
    Message Count Details.
    """
    def __init__(__self__, *,
                 active_message_count: float,
                 dead_letter_message_count: float,
                 scheduled_message_count: float,
                 transfer_dead_letter_message_count: float,
                 transfer_message_count: float):
        """
        Message Count Details.
        :param float active_message_count: Number of active messages in the queue, topic, or subscription.
        :param float dead_letter_message_count: Number of messages that are dead lettered.
        :param float scheduled_message_count: Number of scheduled messages.
        :param float transfer_dead_letter_message_count: Number of messages transferred into dead letters.
        :param float transfer_message_count: Number of messages transferred to another queue, topic, or subscription.
        """
        pulumi.set(__self__, "active_message_count", active_message_count)
        pulumi.set(__self__, "dead_letter_message_count", dead_letter_message_count)
        pulumi.set(__self__, "scheduled_message_count", scheduled_message_count)
        pulumi.set(__self__, "transfer_dead_letter_message_count", transfer_dead_letter_message_count)
        pulumi.set(__self__, "transfer_message_count", transfer_message_count)

    @property
    @pulumi.getter(name="activeMessageCount")
    def active_message_count(self) -> float:
        """
        Number of active messages in the queue, topic, or subscription.
        """
        return pulumi.get(self, "active_message_count")

    @property
    @pulumi.getter(name="deadLetterMessageCount")
    def dead_letter_message_count(self) -> float:
        """
        Number of messages that are dead lettered.
        """
        return pulumi.get(self, "dead_letter_message_count")

    @property
    @pulumi.getter(name="scheduledMessageCount")
    def scheduled_message_count(self) -> float:
        """
        Number of scheduled messages.
        """
        return pulumi.get(self, "scheduled_message_count")

    @property
    @pulumi.getter(name="transferDeadLetterMessageCount")
    def transfer_dead_letter_message_count(self) -> float:
        """
        Number of messages transferred into dead letters.
        """
        return pulumi.get(self, "transfer_dead_letter_message_count")

    @property
    @pulumi.getter(name="transferMessageCount")
    def transfer_message_count(self) -> float:
        """
        Number of messages transferred to another queue, topic, or subscription.
        """
        return pulumi.get(self, "transfer_message_count")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class NWRuleSetIpRulesResponse(dict):
    """
    Description of NetWorkRuleSet - IpRules resource.
    """
    def __init__(__self__, *,
                 action: Optional[str] = None,
                 ip_mask: Optional[str] = None):
        """
        Description of NetWorkRuleSet - IpRules resource.
        :param str action: The IP Filter Action
        :param str ip_mask: IP Mask
        """
        if action is not None:
            pulumi.set(__self__, "action", action)
        if ip_mask is not None:
            pulumi.set(__self__, "ip_mask", ip_mask)

    @property
    @pulumi.getter
    def action(self) -> Optional[str]:
        """
        The IP Filter Action
        """
        return pulumi.get(self, "action")

    @property
    @pulumi.getter(name="ipMask")
    def ip_mask(self) -> Optional[str]:
        """
        IP Mask
        """
        return pulumi.get(self, "ip_mask")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class NWRuleSetVirtualNetworkRulesResponse(dict):
    """
    Description of VirtualNetworkRules - NetworkRules resource.
    """
    def __init__(__self__, *,
                 ignore_missing_vnet_service_endpoint: Optional[bool] = None,
                 subnet: Optional['outputs.SubnetResponse'] = None):
        """
        Description of VirtualNetworkRules - NetworkRules resource.
        :param bool ignore_missing_vnet_service_endpoint: Value that indicates whether to ignore missing VNet Service Endpoint
        :param 'SubnetResponseArgs' subnet: Subnet properties
        """
        if ignore_missing_vnet_service_endpoint is not None:
            pulumi.set(__self__, "ignore_missing_vnet_service_endpoint", ignore_missing_vnet_service_endpoint)
        if subnet is not None:
            pulumi.set(__self__, "subnet", subnet)

    @property
    @pulumi.getter(name="ignoreMissingVnetServiceEndpoint")
    def ignore_missing_vnet_service_endpoint(self) -> Optional[bool]:
        """
        Value that indicates whether to ignore missing VNet Service Endpoint
        """
        return pulumi.get(self, "ignore_missing_vnet_service_endpoint")

    @property
    @pulumi.getter
    def subnet(self) -> Optional['outputs.SubnetResponse']:
        """
        Subnet properties
        """
        return pulumi.get(self, "subnet")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class PrivateEndpointResponse(dict):
    """
    PrivateEndpoint information.
    """
    def __init__(__self__, *,
                 id: Optional[str] = None):
        """
        PrivateEndpoint information.
        :param str id: The ARM identifier for Private Endpoint.
        """
        if id is not None:
            pulumi.set(__self__, "id", id)

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        """
        The ARM identifier for Private Endpoint.
        """
        return pulumi.get(self, "id")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class SBSkuResponse(dict):
    """
    SKU of the namespace.
    """
    def __init__(__self__, *,
                 name: str,
                 capacity: Optional[int] = None,
                 tier: Optional[str] = None):
        """
        SKU of the namespace.
        :param str name: Name of this SKU.
        :param int capacity: The specified messaging units for the tier. For Premium tier, capacity are 1,2 and 4.
        :param str tier: The billing tier of this particular SKU.
        """
        pulumi.set(__self__, "name", name)
        if capacity is not None:
            pulumi.set(__self__, "capacity", capacity)
        if tier is not None:
            pulumi.set(__self__, "tier", tier)

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Name of this SKU.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def capacity(self) -> Optional[int]:
        """
        The specified messaging units for the tier. For Premium tier, capacity are 1,2 and 4.
        """
        return pulumi.get(self, "capacity")

    @property
    @pulumi.getter
    def tier(self) -> Optional[str]:
        """
        The billing tier of this particular SKU.
        """
        return pulumi.get(self, "tier")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class SqlFilterResponse(dict):
    """
    Represents a filter which is a composition of an expression and an action that is executed in the pub/sub pipeline.
    """
    def __init__(__self__, *,
                 compatibility_level: Optional[int] = None,
                 requires_preprocessing: Optional[bool] = None,
                 sql_expression: Optional[str] = None):
        """
        Represents a filter which is a composition of an expression and an action that is executed in the pub/sub pipeline.
        :param int compatibility_level: This property is reserved for future use. An integer value showing the compatibility level, currently hard-coded to 20.
        :param bool requires_preprocessing: Value that indicates whether the rule action requires preprocessing.
        :param str sql_expression: The SQL expression. e.g. MyProperty='ABC'
        """
        if compatibility_level is not None:
            pulumi.set(__self__, "compatibility_level", compatibility_level)
        if requires_preprocessing is not None:
            pulumi.set(__self__, "requires_preprocessing", requires_preprocessing)
        if sql_expression is not None:
            pulumi.set(__self__, "sql_expression", sql_expression)

    @property
    @pulumi.getter(name="compatibilityLevel")
    def compatibility_level(self) -> Optional[int]:
        """
        This property is reserved for future use. An integer value showing the compatibility level, currently hard-coded to 20.
        """
        return pulumi.get(self, "compatibility_level")

    @property
    @pulumi.getter(name="requiresPreprocessing")
    def requires_preprocessing(self) -> Optional[bool]:
        """
        Value that indicates whether the rule action requires preprocessing.
        """
        return pulumi.get(self, "requires_preprocessing")

    @property
    @pulumi.getter(name="sqlExpression")
    def sql_expression(self) -> Optional[str]:
        """
        The SQL expression. e.g. MyProperty='ABC'
        """
        return pulumi.get(self, "sql_expression")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class SubnetResponse(dict):
    """
    Properties supplied for Subnet
    """
    def __init__(__self__, *,
                 id: str):
        """
        Properties supplied for Subnet
        :param str id: Resource ID of Virtual Network Subnet
        """
        pulumi.set(__self__, "id", id)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Resource ID of Virtual Network Subnet
        """
        return pulumi.get(self, "id")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


