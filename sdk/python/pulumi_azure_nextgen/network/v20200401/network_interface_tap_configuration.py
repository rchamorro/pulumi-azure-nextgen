# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from . import outputs
from ._inputs import *

__all__ = ['NetworkInterfaceTapConfiguration']


class NetworkInterfaceTapConfiguration(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 network_interface_name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 tap_configuration_name: Optional[pulumi.Input[str]] = None,
                 virtual_network_tap: Optional[pulumi.Input[pulumi.InputType['VirtualNetworkTapArgs']]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Tap configuration in a Network Interface.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] id: Resource ID.
        :param pulumi.Input[str] name: The name of the resource that is unique within a resource group. This name can be used to access the resource.
        :param pulumi.Input[str] network_interface_name: The name of the network interface.
        :param pulumi.Input[str] resource_group_name: The name of the resource group.
        :param pulumi.Input[str] tap_configuration_name: The name of the tap configuration.
        :param pulumi.Input[pulumi.InputType['VirtualNetworkTapArgs']] virtual_network_tap: The reference to the Virtual Network Tap resource.
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

            __props__['id'] = id
            __props__['name'] = name
            if network_interface_name is None:
                raise TypeError("Missing required property 'network_interface_name'")
            __props__['network_interface_name'] = network_interface_name
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if tap_configuration_name is None:
                raise TypeError("Missing required property 'tap_configuration_name'")
            __props__['tap_configuration_name'] = tap_configuration_name
            __props__['virtual_network_tap'] = virtual_network_tap
            __props__['etag'] = None
            __props__['provisioning_state'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:network/latest:NetworkInterfaceTapConfiguration"), pulumi.Alias(type_="azure-nextgen:network/v20180801:NetworkInterfaceTapConfiguration"), pulumi.Alias(type_="azure-nextgen:network/v20181001:NetworkInterfaceTapConfiguration"), pulumi.Alias(type_="azure-nextgen:network/v20181101:NetworkInterfaceTapConfiguration"), pulumi.Alias(type_="azure-nextgen:network/v20181201:NetworkInterfaceTapConfiguration"), pulumi.Alias(type_="azure-nextgen:network/v20190201:NetworkInterfaceTapConfiguration"), pulumi.Alias(type_="azure-nextgen:network/v20190401:NetworkInterfaceTapConfiguration"), pulumi.Alias(type_="azure-nextgen:network/v20190601:NetworkInterfaceTapConfiguration"), pulumi.Alias(type_="azure-nextgen:network/v20190701:NetworkInterfaceTapConfiguration"), pulumi.Alias(type_="azure-nextgen:network/v20190801:NetworkInterfaceTapConfiguration"), pulumi.Alias(type_="azure-nextgen:network/v20190901:NetworkInterfaceTapConfiguration"), pulumi.Alias(type_="azure-nextgen:network/v20191101:NetworkInterfaceTapConfiguration"), pulumi.Alias(type_="azure-nextgen:network/v20191201:NetworkInterfaceTapConfiguration"), pulumi.Alias(type_="azure-nextgen:network/v20200301:NetworkInterfaceTapConfiguration"), pulumi.Alias(type_="azure-nextgen:network/v20200501:NetworkInterfaceTapConfiguration"), pulumi.Alias(type_="azure-nextgen:network/v20200601:NetworkInterfaceTapConfiguration"), pulumi.Alias(type_="azure-nextgen:network/v20200701:NetworkInterfaceTapConfiguration")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(NetworkInterfaceTapConfiguration, __self__).__init__(
            'azure-nextgen:network/v20200401:NetworkInterfaceTapConfiguration',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'NetworkInterfaceTapConfiguration':
        """
        Get an existing NetworkInterfaceTapConfiguration resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return NetworkInterfaceTapConfiguration(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def etag(self) -> pulumi.Output[str]:
        """
        A unique read-only string that changes whenever the resource is updated.
        """
        return pulumi.get(self, "etag")

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
        The provisioning state of the network interface tap configuration resource.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Sub Resource type.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="virtualNetworkTap")
    def virtual_network_tap(self) -> pulumi.Output[Optional['outputs.VirtualNetworkTapResponse']]:
        """
        The reference to the Virtual Network Tap resource.
        """
        return pulumi.get(self, "virtual_network_tap")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

