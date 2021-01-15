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

__all__ = ['VpnGateway']


class VpnGateway(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 bgp_settings: Optional[pulumi.Input[pulumi.InputType['BgpSettingsArgs']]] = None,
                 connections: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VpnConnectionArgs']]]]] = None,
                 gateway_name: Optional[pulumi.Input[str]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 virtual_hub: Optional[pulumi.Input[pulumi.InputType['SubResourceArgs']]] = None,
                 vpn_gateway_scale_unit: Optional[pulumi.Input[int]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        VpnGateway Resource.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['BgpSettingsArgs']] bgp_settings: Local network gateway's BGP speaker settings.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VpnConnectionArgs']]]] connections: List of all vpn connections to the gateway.
        :param pulumi.Input[str] gateway_name: The name of the gateway.
        :param pulumi.Input[str] id: Resource ID.
        :param pulumi.Input[str] location: Resource location.
        :param pulumi.Input[str] resource_group_name: The resource group name of the VpnGateway.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
        :param pulumi.Input[pulumi.InputType['SubResourceArgs']] virtual_hub: The VirtualHub to which the gateway belongs
        :param pulumi.Input[int] vpn_gateway_scale_unit: The scale unit for this vpn gateway.
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

            __props__['bgp_settings'] = bgp_settings
            __props__['connections'] = connections
            if gateway_name is None and not opts.urn:
                raise TypeError("Missing required property 'gateway_name'")
            __props__['gateway_name'] = gateway_name
            __props__['id'] = id
            if location is None and not opts.urn:
                raise TypeError("Missing required property 'location'")
            __props__['location'] = location
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['tags'] = tags
            __props__['virtual_hub'] = virtual_hub
            __props__['vpn_gateway_scale_unit'] = vpn_gateway_scale_unit
            __props__['etag'] = None
            __props__['name'] = None
            __props__['provisioning_state'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:network/latest:VpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20180401:VpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20180601:VpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20180701:VpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20180801:VpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20181001:VpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20181101:VpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20190201:VpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20190401:VpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20190601:VpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20190701:VpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20190801:VpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20190901:VpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20191101:VpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20191201:VpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20200301:VpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20200401:VpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20200501:VpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20200601:VpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20200701:VpnGateway"), pulumi.Alias(type_="azure-nextgen:network/v20200801:VpnGateway")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(VpnGateway, __self__).__init__(
            'azure-nextgen:network/v20181201:VpnGateway',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'VpnGateway':
        """
        Get an existing VpnGateway resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return VpnGateway(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="bgpSettings")
    def bgp_settings(self) -> pulumi.Output[Optional['outputs.BgpSettingsResponse']]:
        """
        Local network gateway's BGP speaker settings.
        """
        return pulumi.get(self, "bgp_settings")

    @property
    @pulumi.getter
    def connections(self) -> pulumi.Output[Optional[Sequence['outputs.VpnConnectionResponse']]]:
        """
        List of all vpn connections to the gateway.
        """
        return pulumi.get(self, "connections")

    @property
    @pulumi.getter
    def etag(self) -> pulumi.Output[str]:
        """
        Gets a unique read-only string that changes whenever the resource is updated.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        Resource location.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        The provisioning state of the resource.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Resource tags.
        """
        return pulumi.get(self, "tags")

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
        The VirtualHub to which the gateway belongs
        """
        return pulumi.get(self, "virtual_hub")

    @property
    @pulumi.getter(name="vpnGatewayScaleUnit")
    def vpn_gateway_scale_unit(self) -> pulumi.Output[Optional[int]]:
        """
        The scale unit for this vpn gateway.
        """
        return pulumi.get(self, "vpn_gateway_scale_unit")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

