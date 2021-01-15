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

__all__ = ['VirtualNetworkGateway']


class VirtualNetworkGateway(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 active_active: Optional[pulumi.Input[bool]] = None,
                 bgp_settings: Optional[pulumi.Input[pulumi.InputType['BgpSettingsArgs']]] = None,
                 custom_routes: Optional[pulumi.Input[pulumi.InputType['AddressSpaceArgs']]] = None,
                 enable_bgp: Optional[pulumi.Input[bool]] = None,
                 enable_dns_forwarding: Optional[pulumi.Input[bool]] = None,
                 enable_private_ip_address: Optional[pulumi.Input[bool]] = None,
                 gateway_default_site: Optional[pulumi.Input[pulumi.InputType['SubResourceArgs']]] = None,
                 gateway_type: Optional[pulumi.Input[Union[str, 'VirtualNetworkGatewayType']]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 ip_configurations: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VirtualNetworkGatewayIPConfigurationArgs']]]]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 sku: Optional[pulumi.Input[pulumi.InputType['VirtualNetworkGatewaySkuArgs']]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 virtual_network_gateway_name: Optional[pulumi.Input[str]] = None,
                 vpn_client_configuration: Optional[pulumi.Input[pulumi.InputType['VpnClientConfigurationArgs']]] = None,
                 vpn_gateway_generation: Optional[pulumi.Input[Union[str, 'VpnGatewayGeneration']]] = None,
                 vpn_type: Optional[pulumi.Input[Union[str, 'VpnType']]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        A common class for general resource information.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] active_active: ActiveActive flag.
        :param pulumi.Input[pulumi.InputType['BgpSettingsArgs']] bgp_settings: Virtual network gateway's BGP speaker settings.
        :param pulumi.Input[pulumi.InputType['AddressSpaceArgs']] custom_routes: The reference to the address space resource which represents the custom routes address space specified by the customer for virtual network gateway and VpnClient.
        :param pulumi.Input[bool] enable_bgp: Whether BGP is enabled for this virtual network gateway or not.
        :param pulumi.Input[bool] enable_dns_forwarding: Whether dns forwarding is enabled or not.
        :param pulumi.Input[bool] enable_private_ip_address: Whether private IP needs to be enabled on this gateway for connections or not.
        :param pulumi.Input[pulumi.InputType['SubResourceArgs']] gateway_default_site: The reference to the LocalNetworkGateway resource which represents local network site having default routes. Assign Null value in case of removing existing default site setting.
        :param pulumi.Input[Union[str, 'VirtualNetworkGatewayType']] gateway_type: The type of this virtual network gateway.
        :param pulumi.Input[str] id: Resource ID.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VirtualNetworkGatewayIPConfigurationArgs']]]] ip_configurations: IP configurations for virtual network gateway.
        :param pulumi.Input[str] location: Resource location.
        :param pulumi.Input[str] resource_group_name: The name of the resource group.
        :param pulumi.Input[pulumi.InputType['VirtualNetworkGatewaySkuArgs']] sku: The reference to the VirtualNetworkGatewaySku resource which represents the SKU selected for Virtual network gateway.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
        :param pulumi.Input[str] virtual_network_gateway_name: The name of the virtual network gateway.
        :param pulumi.Input[pulumi.InputType['VpnClientConfigurationArgs']] vpn_client_configuration: The reference to the VpnClientConfiguration resource which represents the P2S VpnClient configurations.
        :param pulumi.Input[Union[str, 'VpnGatewayGeneration']] vpn_gateway_generation: The generation for this VirtualNetworkGateway. Must be None if gatewayType is not VPN.
        :param pulumi.Input[Union[str, 'VpnType']] vpn_type: The type of this virtual network gateway.
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

            __props__['active_active'] = active_active
            __props__['bgp_settings'] = bgp_settings
            __props__['custom_routes'] = custom_routes
            __props__['enable_bgp'] = enable_bgp
            __props__['enable_dns_forwarding'] = enable_dns_forwarding
            __props__['enable_private_ip_address'] = enable_private_ip_address
            __props__['gateway_default_site'] = gateway_default_site
            __props__['gateway_type'] = gateway_type
            __props__['id'] = id
            __props__['ip_configurations'] = ip_configurations
            __props__['location'] = location
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['sku'] = sku
            __props__['tags'] = tags
            if virtual_network_gateway_name is None and not opts.urn:
                raise TypeError("Missing required property 'virtual_network_gateway_name'")
            __props__['virtual_network_gateway_name'] = virtual_network_gateway_name
            __props__['vpn_client_configuration'] = vpn_client_configuration
            __props__['vpn_gateway_generation'] = vpn_gateway_generation
            __props__['vpn_type'] = vpn_type
            __props__['etag'] = None
            __props__['inbound_dns_forwarding_endpoint'] = None
            __props__['name'] = None
            __props__['provisioning_state'] = None
            __props__['resource_guid'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:network/latest:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20150615:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20160330:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20160601:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20160901:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20161201:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20170301:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20170601:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20170801:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20170901:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20171001:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20171101:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20180101:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20180201:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20180401:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20180601:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20180701:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20180801:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20181001:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20181101:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20181201:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20190201:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20190401:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20190601:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20190701:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20190801:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20190901:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20191101:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20191201:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20200301:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20200401:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20200601:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20200701:VirtualNetworkGateway"), pulumi.Alias(type_="azure-nextgen:network/v20200801:VirtualNetworkGateway")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(VirtualNetworkGateway, __self__).__init__(
            'azure-nextgen:network/v20200501:VirtualNetworkGateway',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'VirtualNetworkGateway':
        """
        Get an existing VirtualNetworkGateway resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return VirtualNetworkGateway(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="activeActive")
    def active_active(self) -> pulumi.Output[Optional[bool]]:
        """
        ActiveActive flag.
        """
        return pulumi.get(self, "active_active")

    @property
    @pulumi.getter(name="bgpSettings")
    def bgp_settings(self) -> pulumi.Output[Optional['outputs.BgpSettingsResponse']]:
        """
        Virtual network gateway's BGP speaker settings.
        """
        return pulumi.get(self, "bgp_settings")

    @property
    @pulumi.getter(name="customRoutes")
    def custom_routes(self) -> pulumi.Output[Optional['outputs.AddressSpaceResponse']]:
        """
        The reference to the address space resource which represents the custom routes address space specified by the customer for virtual network gateway and VpnClient.
        """
        return pulumi.get(self, "custom_routes")

    @property
    @pulumi.getter(name="enableBgp")
    def enable_bgp(self) -> pulumi.Output[Optional[bool]]:
        """
        Whether BGP is enabled for this virtual network gateway or not.
        """
        return pulumi.get(self, "enable_bgp")

    @property
    @pulumi.getter(name="enableDnsForwarding")
    def enable_dns_forwarding(self) -> pulumi.Output[Optional[bool]]:
        """
        Whether dns forwarding is enabled or not.
        """
        return pulumi.get(self, "enable_dns_forwarding")

    @property
    @pulumi.getter(name="enablePrivateIpAddress")
    def enable_private_ip_address(self) -> pulumi.Output[Optional[bool]]:
        """
        Whether private IP needs to be enabled on this gateway for connections or not.
        """
        return pulumi.get(self, "enable_private_ip_address")

    @property
    @pulumi.getter
    def etag(self) -> pulumi.Output[str]:
        """
        A unique read-only string that changes whenever the resource is updated.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter(name="gatewayDefaultSite")
    def gateway_default_site(self) -> pulumi.Output[Optional['outputs.SubResourceResponse']]:
        """
        The reference to the LocalNetworkGateway resource which represents local network site having default routes. Assign Null value in case of removing existing default site setting.
        """
        return pulumi.get(self, "gateway_default_site")

    @property
    @pulumi.getter(name="gatewayType")
    def gateway_type(self) -> pulumi.Output[Optional[str]]:
        """
        The type of this virtual network gateway.
        """
        return pulumi.get(self, "gateway_type")

    @property
    @pulumi.getter(name="inboundDnsForwardingEndpoint")
    def inbound_dns_forwarding_endpoint(self) -> pulumi.Output[str]:
        """
        The IP address allocated by the gateway to which dns requests can be sent.
        """
        return pulumi.get(self, "inbound_dns_forwarding_endpoint")

    @property
    @pulumi.getter(name="ipConfigurations")
    def ip_configurations(self) -> pulumi.Output[Optional[Sequence['outputs.VirtualNetworkGatewayIPConfigurationResponse']]]:
        """
        IP configurations for virtual network gateway.
        """
        return pulumi.get(self, "ip_configurations")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[Optional[str]]:
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
        The provisioning state of the virtual network gateway resource.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="resourceGuid")
    def resource_guid(self) -> pulumi.Output[str]:
        """
        The resource GUID property of the virtual network gateway resource.
        """
        return pulumi.get(self, "resource_guid")

    @property
    @pulumi.getter
    def sku(self) -> pulumi.Output[Optional['outputs.VirtualNetworkGatewaySkuResponse']]:
        """
        The reference to the VirtualNetworkGatewaySku resource which represents the SKU selected for Virtual network gateway.
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
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Resource type.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="vpnClientConfiguration")
    def vpn_client_configuration(self) -> pulumi.Output[Optional['outputs.VpnClientConfigurationResponse']]:
        """
        The reference to the VpnClientConfiguration resource which represents the P2S VpnClient configurations.
        """
        return pulumi.get(self, "vpn_client_configuration")

    @property
    @pulumi.getter(name="vpnGatewayGeneration")
    def vpn_gateway_generation(self) -> pulumi.Output[Optional[str]]:
        """
        The generation for this VirtualNetworkGateway. Must be None if gatewayType is not VPN.
        """
        return pulumi.get(self, "vpn_gateway_generation")

    @property
    @pulumi.getter(name="vpnType")
    def vpn_type(self) -> pulumi.Output[Optional[str]]:
        """
        The type of this virtual network gateway.
        """
        return pulumi.get(self, "vpn_type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

