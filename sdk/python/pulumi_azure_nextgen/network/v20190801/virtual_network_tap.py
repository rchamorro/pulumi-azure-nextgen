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

__all__ = ['VirtualNetworkTap']


class VirtualNetworkTap(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 destination_load_balancer_front_end_ip_configuration: Optional[pulumi.Input[pulumi.InputType['FrontendIPConfigurationArgs']]] = None,
                 destination_network_interface_ip_configuration: Optional[pulumi.Input[pulumi.InputType['NetworkInterfaceIPConfigurationArgs']]] = None,
                 destination_port: Optional[pulumi.Input[int]] = None,
                 etag: Optional[pulumi.Input[str]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 tap_name: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Virtual Network Tap resource.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['FrontendIPConfigurationArgs']] destination_load_balancer_front_end_ip_configuration: The reference to the private IP address on the internal Load Balancer that will receive the tap.
        :param pulumi.Input[pulumi.InputType['NetworkInterfaceIPConfigurationArgs']] destination_network_interface_ip_configuration: The reference to the private IP Address of the collector nic that will receive the tap.
        :param pulumi.Input[int] destination_port: The VXLAN destination port that will receive the tapped traffic.
        :param pulumi.Input[str] etag: A unique read-only string that changes whenever the resource is updated.
        :param pulumi.Input[str] id: Resource ID.
        :param pulumi.Input[str] location: Resource location.
        :param pulumi.Input[str] resource_group_name: The name of the resource group.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
        :param pulumi.Input[str] tap_name: The name of the virtual network tap.
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

            __props__['destination_load_balancer_front_end_ip_configuration'] = destination_load_balancer_front_end_ip_configuration
            __props__['destination_network_interface_ip_configuration'] = destination_network_interface_ip_configuration
            __props__['destination_port'] = destination_port
            __props__['etag'] = etag
            __props__['id'] = id
            __props__['location'] = location
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['tags'] = tags
            if tap_name is None and not opts.urn:
                raise TypeError("Missing required property 'tap_name'")
            __props__['tap_name'] = tap_name
            __props__['name'] = None
            __props__['network_interface_tap_configurations'] = None
            __props__['provisioning_state'] = None
            __props__['resource_guid'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:network/latest:VirtualNetworkTap"), pulumi.Alias(type_="azure-nextgen:network/v20180801:VirtualNetworkTap"), pulumi.Alias(type_="azure-nextgen:network/v20181001:VirtualNetworkTap"), pulumi.Alias(type_="azure-nextgen:network/v20181101:VirtualNetworkTap"), pulumi.Alias(type_="azure-nextgen:network/v20181201:VirtualNetworkTap"), pulumi.Alias(type_="azure-nextgen:network/v20190201:VirtualNetworkTap"), pulumi.Alias(type_="azure-nextgen:network/v20190401:VirtualNetworkTap"), pulumi.Alias(type_="azure-nextgen:network/v20190601:VirtualNetworkTap"), pulumi.Alias(type_="azure-nextgen:network/v20190701:VirtualNetworkTap"), pulumi.Alias(type_="azure-nextgen:network/v20190901:VirtualNetworkTap"), pulumi.Alias(type_="azure-nextgen:network/v20191101:VirtualNetworkTap"), pulumi.Alias(type_="azure-nextgen:network/v20191201:VirtualNetworkTap"), pulumi.Alias(type_="azure-nextgen:network/v20200301:VirtualNetworkTap"), pulumi.Alias(type_="azure-nextgen:network/v20200401:VirtualNetworkTap"), pulumi.Alias(type_="azure-nextgen:network/v20200501:VirtualNetworkTap"), pulumi.Alias(type_="azure-nextgen:network/v20200601:VirtualNetworkTap"), pulumi.Alias(type_="azure-nextgen:network/v20200701:VirtualNetworkTap"), pulumi.Alias(type_="azure-nextgen:network/v20200801:VirtualNetworkTap")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(VirtualNetworkTap, __self__).__init__(
            'azure-nextgen:network/v20190801:VirtualNetworkTap',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'VirtualNetworkTap':
        """
        Get an existing VirtualNetworkTap resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return VirtualNetworkTap(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="destinationLoadBalancerFrontEndIPConfiguration")
    def destination_load_balancer_front_end_ip_configuration(self) -> pulumi.Output[Optional['outputs.FrontendIPConfigurationResponse']]:
        """
        The reference to the private IP address on the internal Load Balancer that will receive the tap.
        """
        return pulumi.get(self, "destination_load_balancer_front_end_ip_configuration")

    @property
    @pulumi.getter(name="destinationNetworkInterfaceIPConfiguration")
    def destination_network_interface_ip_configuration(self) -> pulumi.Output[Optional['outputs.NetworkInterfaceIPConfigurationResponse']]:
        """
        The reference to the private IP Address of the collector nic that will receive the tap.
        """
        return pulumi.get(self, "destination_network_interface_ip_configuration")

    @property
    @pulumi.getter(name="destinationPort")
    def destination_port(self) -> pulumi.Output[Optional[int]]:
        """
        The VXLAN destination port that will receive the tapped traffic.
        """
        return pulumi.get(self, "destination_port")

    @property
    @pulumi.getter
    def etag(self) -> pulumi.Output[Optional[str]]:
        """
        A unique read-only string that changes whenever the resource is updated.
        """
        return pulumi.get(self, "etag")

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
    @pulumi.getter(name="networkInterfaceTapConfigurations")
    def network_interface_tap_configurations(self) -> pulumi.Output[Sequence['outputs.NetworkInterfaceTapConfigurationResponse']]:
        """
        Specifies the list of resource IDs for the network interface IP configuration that needs to be tapped.
        """
        return pulumi.get(self, "network_interface_tap_configurations")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        The provisioning state of the virtual network tap resource.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="resourceGuid")
    def resource_guid(self) -> pulumi.Output[str]:
        """
        The resource GUID property of the virtual network tap resource.
        """
        return pulumi.get(self, "resource_guid")

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

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

