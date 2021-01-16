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

__all__ = ['NatRule']


class NatRule(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 external_mappings: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VpnNatRuleMappingArgs']]]]] = None,
                 gateway_name: Optional[pulumi.Input[str]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 internal_mappings: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VpnNatRuleMappingArgs']]]]] = None,
                 ip_configuration_id: Optional[pulumi.Input[str]] = None,
                 mode: Optional[pulumi.Input[Union[str, 'VpnNatRuleMode']]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 nat_rule_name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[Union[str, 'VpnNatRuleType']]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        VpnGatewayNatRule Resource.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VpnNatRuleMappingArgs']]]] external_mappings: The private IP address external mapping for NAT.
        :param pulumi.Input[str] gateway_name: The name of the gateway.
        :param pulumi.Input[str] id: Resource ID.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VpnNatRuleMappingArgs']]]] internal_mappings: The private IP address internal mapping for NAT.
        :param pulumi.Input[str] ip_configuration_id: The IP Configuration ID this NAT rule applies to.
        :param pulumi.Input[Union[str, 'VpnNatRuleMode']] mode: The Source NAT direction of a VPN NAT.
        :param pulumi.Input[str] name: The name of the resource that is unique within a resource group. This name can be used to access the resource.
        :param pulumi.Input[str] nat_rule_name: The name of the nat rule.
        :param pulumi.Input[str] resource_group_name: The resource group name of the VpnGateway.
        :param pulumi.Input[Union[str, 'VpnNatRuleType']] type: The type of NAT rule for VPN NAT.
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

            __props__['external_mappings'] = external_mappings
            if gateway_name is None and not opts.urn:
                raise TypeError("Missing required property 'gateway_name'")
            __props__['gateway_name'] = gateway_name
            __props__['id'] = id
            __props__['internal_mappings'] = internal_mappings
            __props__['ip_configuration_id'] = ip_configuration_id
            __props__['mode'] = mode
            __props__['name'] = name
            if nat_rule_name is None and not opts.urn:
                raise TypeError("Missing required property 'nat_rule_name'")
            __props__['nat_rule_name'] = nat_rule_name
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['type'] = type
            __props__['egress_vpn_site_link_connections'] = None
            __props__['etag'] = None
            __props__['ingress_vpn_site_link_connections'] = None
            __props__['provisioning_state'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:network/latest:NatRule")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(NatRule, __self__).__init__(
            'azure-nextgen:network/v20200801:NatRule',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'NatRule':
        """
        Get an existing NatRule resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return NatRule(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="egressVpnSiteLinkConnections")
    def egress_vpn_site_link_connections(self) -> pulumi.Output[Sequence['outputs.SubResourceResponse']]:
        """
        List of egress VpnSiteLinkConnections.
        """
        return pulumi.get(self, "egress_vpn_site_link_connections")

    @property
    @pulumi.getter
    def etag(self) -> pulumi.Output[str]:
        """
        A unique read-only string that changes whenever the resource is updated.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter(name="externalMappings")
    def external_mappings(self) -> pulumi.Output[Optional[Sequence['outputs.VpnNatRuleMappingResponse']]]:
        """
        The private IP address external mapping for NAT.
        """
        return pulumi.get(self, "external_mappings")

    @property
    @pulumi.getter(name="ingressVpnSiteLinkConnections")
    def ingress_vpn_site_link_connections(self) -> pulumi.Output[Sequence['outputs.SubResourceResponse']]:
        """
        List of ingress VpnSiteLinkConnections.
        """
        return pulumi.get(self, "ingress_vpn_site_link_connections")

    @property
    @pulumi.getter(name="internalMappings")
    def internal_mappings(self) -> pulumi.Output[Optional[Sequence['outputs.VpnNatRuleMappingResponse']]]:
        """
        The private IP address internal mapping for NAT.
        """
        return pulumi.get(self, "internal_mappings")

    @property
    @pulumi.getter(name="ipConfigurationId")
    def ip_configuration_id(self) -> pulumi.Output[Optional[str]]:
        """
        The IP Configuration ID this NAT rule applies to.
        """
        return pulumi.get(self, "ip_configuration_id")

    @property
    @pulumi.getter
    def mode(self) -> pulumi.Output[Optional[str]]:
        """
        The Source NAT direction of a VPN NAT.
        """
        return pulumi.get(self, "mode")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[Optional[str]]:
        """
        The name of the resource that is unique within a resource group. This name can be used to access the resource.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        The provisioning state of the NAT Rule resource.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Resource type.
        """
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

