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
from ._inputs import *

__all__ = ['AzureFirewall']


class AzureFirewall(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 additional_properties: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 application_rule_collections: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AzureFirewallApplicationRuleCollectionArgs']]]]] = None,
                 azure_firewall_name: Optional[pulumi.Input[str]] = None,
                 firewall_policy: Optional[pulumi.Input[pulumi.InputType['SubResourceArgs']]] = None,
                 hub_ip_addresses: Optional[pulumi.Input[pulumi.InputType['HubIPAddressesArgs']]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 ip_configurations: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AzureFirewallIPConfigurationArgs']]]]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 management_ip_configuration: Optional[pulumi.Input[pulumi.InputType['AzureFirewallIPConfigurationArgs']]] = None,
                 nat_rule_collections: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AzureFirewallNatRuleCollectionArgs']]]]] = None,
                 network_rule_collections: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AzureFirewallNetworkRuleCollectionArgs']]]]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 sku: Optional[pulumi.Input[pulumi.InputType['AzureFirewallSkuArgs']]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 threat_intel_mode: Optional[pulumi.Input[Union[str, 'AzureFirewallThreatIntelMode']]] = None,
                 virtual_hub: Optional[pulumi.Input[pulumi.InputType['SubResourceArgs']]] = None,
                 zones: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Azure Firewall resource.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] additional_properties: The additional properties used to further config this azure firewall.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AzureFirewallApplicationRuleCollectionArgs']]]] application_rule_collections: Collection of application rule collections used by Azure Firewall.
        :param pulumi.Input[str] azure_firewall_name: The name of the Azure Firewall.
        :param pulumi.Input[pulumi.InputType['SubResourceArgs']] firewall_policy: The firewallPolicy associated with this azure firewall.
        :param pulumi.Input[pulumi.InputType['HubIPAddressesArgs']] hub_ip_addresses: IP addresses associated with AzureFirewall.
        :param pulumi.Input[str] id: Resource ID.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AzureFirewallIPConfigurationArgs']]]] ip_configurations: IP configuration of the Azure Firewall resource.
        :param pulumi.Input[str] location: Resource location.
        :param pulumi.Input[pulumi.InputType['AzureFirewallIPConfigurationArgs']] management_ip_configuration: IP configuration of the Azure Firewall used for management traffic.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AzureFirewallNatRuleCollectionArgs']]]] nat_rule_collections: Collection of NAT rule collections used by Azure Firewall.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AzureFirewallNetworkRuleCollectionArgs']]]] network_rule_collections: Collection of network rule collections used by Azure Firewall.
        :param pulumi.Input[str] resource_group_name: The name of the resource group.
        :param pulumi.Input[pulumi.InputType['AzureFirewallSkuArgs']] sku: The Azure Firewall Resource SKU.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
        :param pulumi.Input[Union[str, 'AzureFirewallThreatIntelMode']] threat_intel_mode: The operation mode for Threat Intelligence.
        :param pulumi.Input[pulumi.InputType['SubResourceArgs']] virtual_hub: The virtualHub to which the firewall belongs.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] zones: A list of availability zones denoting where the resource needs to come from.
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

            __props__['additional_properties'] = additional_properties
            __props__['application_rule_collections'] = application_rule_collections
            if azure_firewall_name is None and not opts.urn:
                raise TypeError("Missing required property 'azure_firewall_name'")
            __props__['azure_firewall_name'] = azure_firewall_name
            __props__['firewall_policy'] = firewall_policy
            __props__['hub_ip_addresses'] = hub_ip_addresses
            __props__['id'] = id
            __props__['ip_configurations'] = ip_configurations
            __props__['location'] = location
            __props__['management_ip_configuration'] = management_ip_configuration
            __props__['nat_rule_collections'] = nat_rule_collections
            __props__['network_rule_collections'] = network_rule_collections
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['sku'] = sku
            __props__['tags'] = tags
            __props__['threat_intel_mode'] = threat_intel_mode
            __props__['virtual_hub'] = virtual_hub
            __props__['zones'] = zones
            __props__['etag'] = None
            __props__['ip_groups'] = None
            __props__['name'] = None
            __props__['provisioning_state'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:network/latest:AzureFirewall"), pulumi.Alias(type_="azure-nextgen:network/v20180401:AzureFirewall"), pulumi.Alias(type_="azure-nextgen:network/v20180601:AzureFirewall"), pulumi.Alias(type_="azure-nextgen:network/v20180701:AzureFirewall"), pulumi.Alias(type_="azure-nextgen:network/v20180801:AzureFirewall"), pulumi.Alias(type_="azure-nextgen:network/v20181001:AzureFirewall"), pulumi.Alias(type_="azure-nextgen:network/v20181101:AzureFirewall"), pulumi.Alias(type_="azure-nextgen:network/v20181201:AzureFirewall"), pulumi.Alias(type_="azure-nextgen:network/v20190201:AzureFirewall"), pulumi.Alias(type_="azure-nextgen:network/v20190401:AzureFirewall"), pulumi.Alias(type_="azure-nextgen:network/v20190601:AzureFirewall"), pulumi.Alias(type_="azure-nextgen:network/v20190701:AzureFirewall"), pulumi.Alias(type_="azure-nextgen:network/v20190801:AzureFirewall"), pulumi.Alias(type_="azure-nextgen:network/v20190901:AzureFirewall"), pulumi.Alias(type_="azure-nextgen:network/v20191101:AzureFirewall"), pulumi.Alias(type_="azure-nextgen:network/v20191201:AzureFirewall"), pulumi.Alias(type_="azure-nextgen:network/v20200301:AzureFirewall"), pulumi.Alias(type_="azure-nextgen:network/v20200401:AzureFirewall"), pulumi.Alias(type_="azure-nextgen:network/v20200501:AzureFirewall"), pulumi.Alias(type_="azure-nextgen:network/v20200601:AzureFirewall"), pulumi.Alias(type_="azure-nextgen:network/v20200801:AzureFirewall")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(AzureFirewall, __self__).__init__(
            'azure-nextgen:network/v20200701:AzureFirewall',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'AzureFirewall':
        """
        Get an existing AzureFirewall resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return AzureFirewall(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="additionalProperties")
    def additional_properties(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        The additional properties used to further config this azure firewall.
        """
        return pulumi.get(self, "additional_properties")

    @property
    @pulumi.getter(name="applicationRuleCollections")
    def application_rule_collections(self) -> pulumi.Output[Optional[Sequence['outputs.AzureFirewallApplicationRuleCollectionResponse']]]:
        """
        Collection of application rule collections used by Azure Firewall.
        """
        return pulumi.get(self, "application_rule_collections")

    @property
    @pulumi.getter
    def etag(self) -> pulumi.Output[str]:
        """
        A unique read-only string that changes whenever the resource is updated.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter(name="firewallPolicy")
    def firewall_policy(self) -> pulumi.Output[Optional['outputs.SubResourceResponse']]:
        """
        The firewallPolicy associated with this azure firewall.
        """
        return pulumi.get(self, "firewall_policy")

    @property
    @pulumi.getter(name="hubIPAddresses")
    def hub_ip_addresses(self) -> pulumi.Output[Optional['outputs.HubIPAddressesResponse']]:
        """
        IP addresses associated with AzureFirewall.
        """
        return pulumi.get(self, "hub_ip_addresses")

    @property
    @pulumi.getter(name="ipConfigurations")
    def ip_configurations(self) -> pulumi.Output[Optional[Sequence['outputs.AzureFirewallIPConfigurationResponse']]]:
        """
        IP configuration of the Azure Firewall resource.
        """
        return pulumi.get(self, "ip_configurations")

    @property
    @pulumi.getter(name="ipGroups")
    def ip_groups(self) -> pulumi.Output[Sequence['outputs.AzureFirewallIpGroupsResponse']]:
        """
        IpGroups associated with AzureFirewall.
        """
        return pulumi.get(self, "ip_groups")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[Optional[str]]:
        """
        Resource location.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="managementIpConfiguration")
    def management_ip_configuration(self) -> pulumi.Output[Optional['outputs.AzureFirewallIPConfigurationResponse']]:
        """
        IP configuration of the Azure Firewall used for management traffic.
        """
        return pulumi.get(self, "management_ip_configuration")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="natRuleCollections")
    def nat_rule_collections(self) -> pulumi.Output[Optional[Sequence['outputs.AzureFirewallNatRuleCollectionResponse']]]:
        """
        Collection of NAT rule collections used by Azure Firewall.
        """
        return pulumi.get(self, "nat_rule_collections")

    @property
    @pulumi.getter(name="networkRuleCollections")
    def network_rule_collections(self) -> pulumi.Output[Optional[Sequence['outputs.AzureFirewallNetworkRuleCollectionResponse']]]:
        """
        Collection of network rule collections used by Azure Firewall.
        """
        return pulumi.get(self, "network_rule_collections")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        The provisioning state of the Azure firewall resource.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter
    def sku(self) -> pulumi.Output[Optional['outputs.AzureFirewallSkuResponse']]:
        """
        The Azure Firewall Resource SKU.
        """
        return pulumi.get(self, "sku")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Resource tags.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="threatIntelMode")
    def threat_intel_mode(self) -> pulumi.Output[Optional[str]]:
        """
        The operation mode for Threat Intelligence.
        """
        return pulumi.get(self, "threat_intel_mode")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Resource type.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="virtualHub")
    def virtual_hub(self) -> pulumi.Output[Optional['outputs.SubResourceResponse']]:
        """
        The virtualHub to which the firewall belongs.
        """
        return pulumi.get(self, "virtual_hub")

    @property
    @pulumi.getter
    def zones(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        A list of availability zones denoting where the resource needs to come from.
        """
        return pulumi.get(self, "zones")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

