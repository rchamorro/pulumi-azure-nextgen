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
    'IdentityArgs',
    'IpRuleArgs',
    'NetworkRuleSetArgs',
    'PrivateEndpointConnectionPropertiesArgs',
    'PrivateEndpointConnectionPropertiesPrivateEndpointArgs',
    'PrivateEndpointConnectionPropertiesPrivateLinkServiceConnectionStateArgs',
    'SkuArgs',
]

@pulumi.input_type
class IdentityArgs:
    def __init__(__self__, *,
                 type: pulumi.Input['IdentityType']):
        """
        Identity for the resource.
        :param pulumi.Input['IdentityType'] type: The identity type.
        """
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input['IdentityType']:
        """
        The identity type.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input['IdentityType']):
        pulumi.set(self, "type", value)


@pulumi.input_type
class IpRuleArgs:
    def __init__(__self__, *,
                 value: Optional[pulumi.Input[str]] = None):
        """
        The IP restriction rule of the Azure Cognitive Search service.
        :param pulumi.Input[str] value: Value corresponding to a single IPv4 address (eg., 123.1.2.3) or an IP range in CIDR format (eg., 123.1.2.3/24) to be allowed.
        """
        if value is not None:
            pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def value(self) -> Optional[pulumi.Input[str]]:
        """
        Value corresponding to a single IPv4 address (eg., 123.1.2.3) or an IP range in CIDR format (eg., 123.1.2.3/24) to be allowed.
        """
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "value", value)


@pulumi.input_type
class NetworkRuleSetArgs:
    def __init__(__self__, *,
                 ip_rules: Optional[pulumi.Input[Sequence[pulumi.Input['IpRuleArgs']]]] = None):
        """
        Network specific rules that determine how the Azure Cognitive Search service may be reached.
        :param pulumi.Input[Sequence[pulumi.Input['IpRuleArgs']]] ip_rules: A list of IP restriction rules that defines the inbound network(s) with allowing access to the search service endpoint. At the meantime, all other public IP networks are blocked by the firewall. These restriction rules are applied only when the 'publicNetworkAccess' of the search service is 'enabled'; otherwise, traffic over public interface is not allowed even with any public IP rules, and private endpoint connections would be the exclusive access method.
        """
        if ip_rules is not None:
            pulumi.set(__self__, "ip_rules", ip_rules)

    @property
    @pulumi.getter(name="ipRules")
    def ip_rules(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['IpRuleArgs']]]]:
        """
        A list of IP restriction rules that defines the inbound network(s) with allowing access to the search service endpoint. At the meantime, all other public IP networks are blocked by the firewall. These restriction rules are applied only when the 'publicNetworkAccess' of the search service is 'enabled'; otherwise, traffic over public interface is not allowed even with any public IP rules, and private endpoint connections would be the exclusive access method.
        """
        return pulumi.get(self, "ip_rules")

    @ip_rules.setter
    def ip_rules(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['IpRuleArgs']]]]):
        pulumi.set(self, "ip_rules", value)


@pulumi.input_type
class PrivateEndpointConnectionPropertiesArgs:
    def __init__(__self__, *,
                 private_endpoint: Optional[pulumi.Input['PrivateEndpointConnectionPropertiesPrivateEndpointArgs']] = None,
                 private_link_service_connection_state: Optional[pulumi.Input['PrivateEndpointConnectionPropertiesPrivateLinkServiceConnectionStateArgs']] = None):
        """
        Describes the properties of an existing Private Endpoint connection to the Azure Cognitive Search service.
        :param pulumi.Input['PrivateEndpointConnectionPropertiesPrivateEndpointArgs'] private_endpoint: The private endpoint resource from Microsoft.Network provider.
        :param pulumi.Input['PrivateEndpointConnectionPropertiesPrivateLinkServiceConnectionStateArgs'] private_link_service_connection_state: Describes the current state of an existing Private Link Service connection to the Azure Private Endpoint.
        """
        if private_endpoint is not None:
            pulumi.set(__self__, "private_endpoint", private_endpoint)
        if private_link_service_connection_state is not None:
            pulumi.set(__self__, "private_link_service_connection_state", private_link_service_connection_state)

    @property
    @pulumi.getter(name="privateEndpoint")
    def private_endpoint(self) -> Optional[pulumi.Input['PrivateEndpointConnectionPropertiesPrivateEndpointArgs']]:
        """
        The private endpoint resource from Microsoft.Network provider.
        """
        return pulumi.get(self, "private_endpoint")

    @private_endpoint.setter
    def private_endpoint(self, value: Optional[pulumi.Input['PrivateEndpointConnectionPropertiesPrivateEndpointArgs']]):
        pulumi.set(self, "private_endpoint", value)

    @property
    @pulumi.getter(name="privateLinkServiceConnectionState")
    def private_link_service_connection_state(self) -> Optional[pulumi.Input['PrivateEndpointConnectionPropertiesPrivateLinkServiceConnectionStateArgs']]:
        """
        Describes the current state of an existing Private Link Service connection to the Azure Private Endpoint.
        """
        return pulumi.get(self, "private_link_service_connection_state")

    @private_link_service_connection_state.setter
    def private_link_service_connection_state(self, value: Optional[pulumi.Input['PrivateEndpointConnectionPropertiesPrivateLinkServiceConnectionStateArgs']]):
        pulumi.set(self, "private_link_service_connection_state", value)


@pulumi.input_type
class PrivateEndpointConnectionPropertiesPrivateEndpointArgs:
    def __init__(__self__, *,
                 id: Optional[pulumi.Input[str]] = None):
        """
        The private endpoint resource from Microsoft.Network provider.
        :param pulumi.Input[str] id: The resource id of the private endpoint resource from Microsoft.Network provider.
        """
        if id is not None:
            pulumi.set(__self__, "id", id)

    @property
    @pulumi.getter
    def id(self) -> Optional[pulumi.Input[str]]:
        """
        The resource id of the private endpoint resource from Microsoft.Network provider.
        """
        return pulumi.get(self, "id")

    @id.setter
    def id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "id", value)


@pulumi.input_type
class PrivateEndpointConnectionPropertiesPrivateLinkServiceConnectionStateArgs:
    def __init__(__self__, *,
                 actions_required: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input['PrivateLinkServiceConnectionStatus']] = None):
        """
        Describes the current state of an existing Private Link Service connection to the Azure Private Endpoint.
        :param pulumi.Input[str] actions_required: A description of any extra actions that may be required.
        :param pulumi.Input[str] description: The description for the private link service connection state.
        :param pulumi.Input['PrivateLinkServiceConnectionStatus'] status: Status of the the private link service connection. Can be Pending, Approved, Rejected, or Disconnected.
        """
        if actions_required is None:
            actions_required = 'None'
        if actions_required is not None:
            pulumi.set(__self__, "actions_required", actions_required)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if status is not None:
            pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter(name="actionsRequired")
    def actions_required(self) -> Optional[pulumi.Input[str]]:
        """
        A description of any extra actions that may be required.
        """
        return pulumi.get(self, "actions_required")

    @actions_required.setter
    def actions_required(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "actions_required", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        The description for the private link service connection state.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input['PrivateLinkServiceConnectionStatus']]:
        """
        Status of the the private link service connection. Can be Pending, Approved, Rejected, or Disconnected.
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input['PrivateLinkServiceConnectionStatus']]):
        pulumi.set(self, "status", value)


@pulumi.input_type
class SkuArgs:
    def __init__(__self__, *,
                 name: Optional[pulumi.Input['SkuName']] = None):
        """
        Defines the SKU of an Azure Cognitive Search Service, which determines price tier and capacity limits.
        :param pulumi.Input['SkuName'] name: The SKU of the Search service. Valid values include: 'free': Shared service. 'basic': Dedicated service with up to 3 replicas. 'standard': Dedicated service with up to 12 partitions and 12 replicas. 'standard2': Similar to standard, but with more capacity per search unit. 'standard3': The largest Standard offering with up to 12 partitions and 12 replicas (or up to 3 partitions with more indexes if you also set the hostingMode property to 'highDensity'). 'storage_optimized_l1': Supports 1TB per partition, up to 12 partitions. 'storage_optimized_l2': Supports 2TB per partition, up to 12 partitions.'
        """
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input['SkuName']]:
        """
        The SKU of the Search service. Valid values include: 'free': Shared service. 'basic': Dedicated service with up to 3 replicas. 'standard': Dedicated service with up to 12 partitions and 12 replicas. 'standard2': Similar to standard, but with more capacity per search unit. 'standard3': The largest Standard offering with up to 12 partitions and 12 replicas (or up to 3 partitions with more indexes if you also set the hostingMode property to 'highDensity'). 'storage_optimized_l1': Supports 1TB per partition, up to 12 partitions. 'storage_optimized_l2': Supports 2TB per partition, up to 12 partitions.'
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input['SkuName']]):
        pulumi.set(self, "name", value)


