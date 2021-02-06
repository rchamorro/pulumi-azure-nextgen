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

__all__ = ['VirtualHub']


class VirtualHub(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 address_prefix: Optional[pulumi.Input[str]] = None,
                 hub_virtual_network_connections: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['HubVirtualNetworkConnectionArgs']]]]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 virtual_hub_name: Optional[pulumi.Input[str]] = None,
                 virtual_wan: Optional[pulumi.Input[pulumi.InputType['SubResourceArgs']]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        VirtualHub Resource.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] address_prefix: Address-prefix for this VirtualHub.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['HubVirtualNetworkConnectionArgs']]]] hub_virtual_network_connections: list of all vnet connections with this VirtualHub.
        :param pulumi.Input[str] id: Resource ID.
        :param pulumi.Input[str] location: Resource location.
        :param pulumi.Input[str] resource_group_name: The resource group name of the VirtualHub.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
        :param pulumi.Input[str] virtual_hub_name: The name of the VirtualHub.
        :param pulumi.Input[pulumi.InputType['SubResourceArgs']] virtual_wan: The VirtualWAN to which the VirtualHub belongs
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

            __props__['address_prefix'] = address_prefix
            __props__['hub_virtual_network_connections'] = hub_virtual_network_connections
            __props__['id'] = id
            __props__['location'] = location
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['tags'] = tags
            if virtual_hub_name is None and not opts.urn:
                raise TypeError("Missing required property 'virtual_hub_name'")
            __props__['virtual_hub_name'] = virtual_hub_name
            __props__['virtual_wan'] = virtual_wan
            __props__['etag'] = None
            __props__['name'] = None
            __props__['provisioning_state'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:network/latest:VirtualHub"), pulumi.Alias(type_="azure-nextgen:network/v20180401:VirtualHub"), pulumi.Alias(type_="azure-nextgen:network/v20180601:VirtualHub"), pulumi.Alias(type_="azure-nextgen:network/v20180801:VirtualHub"), pulumi.Alias(type_="azure-nextgen:network/v20181001:VirtualHub"), pulumi.Alias(type_="azure-nextgen:network/v20181101:VirtualHub"), pulumi.Alias(type_="azure-nextgen:network/v20181201:VirtualHub"), pulumi.Alias(type_="azure-nextgen:network/v20190201:VirtualHub"), pulumi.Alias(type_="azure-nextgen:network/v20190401:VirtualHub"), pulumi.Alias(type_="azure-nextgen:network/v20190601:VirtualHub"), pulumi.Alias(type_="azure-nextgen:network/v20190701:VirtualHub"), pulumi.Alias(type_="azure-nextgen:network/v20190801:VirtualHub"), pulumi.Alias(type_="azure-nextgen:network/v20190901:VirtualHub"), pulumi.Alias(type_="azure-nextgen:network/v20191101:VirtualHub"), pulumi.Alias(type_="azure-nextgen:network/v20191201:VirtualHub"), pulumi.Alias(type_="azure-nextgen:network/v20200301:VirtualHub"), pulumi.Alias(type_="azure-nextgen:network/v20200401:VirtualHub"), pulumi.Alias(type_="azure-nextgen:network/v20200501:VirtualHub"), pulumi.Alias(type_="azure-nextgen:network/v20200601:VirtualHub"), pulumi.Alias(type_="azure-nextgen:network/v20200701:VirtualHub"), pulumi.Alias(type_="azure-nextgen:network/v20200801:VirtualHub")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(VirtualHub, __self__).__init__(
            'azure-nextgen:network/v20180701:VirtualHub',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'VirtualHub':
        """
        Get an existing VirtualHub resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return VirtualHub(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="addressPrefix")
    def address_prefix(self) -> pulumi.Output[Optional[str]]:
        """
        Address-prefix for this VirtualHub.
        """
        return pulumi.get(self, "address_prefix")

    @property
    @pulumi.getter
    def etag(self) -> pulumi.Output[str]:
        """
        Gets a unique read-only string that changes whenever the resource is updated.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter(name="hubVirtualNetworkConnections")
    def hub_virtual_network_connections(self) -> pulumi.Output[Optional[Sequence['outputs.HubVirtualNetworkConnectionResponse']]]:
        """
        list of all vnet connections with this VirtualHub.
        """
        return pulumi.get(self, "hub_virtual_network_connections")

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
    @pulumi.getter(name="virtualWan")
    def virtual_wan(self) -> pulumi.Output[Optional['outputs.SubResourceResponse']]:
        """
        The VirtualWAN to which the VirtualHub belongs
        """
        return pulumi.get(self, "virtual_wan")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

