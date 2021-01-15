# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from ._enums import *

__all__ = ['Route']


class Route(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 address_prefix: Optional[pulumi.Input[str]] = None,
                 etag: Optional[pulumi.Input[str]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 next_hop_ip_address: Optional[pulumi.Input[str]] = None,
                 next_hop_type: Optional[pulumi.Input[Union[str, 'RouteNextHopType']]] = None,
                 provisioning_state: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 route_name: Optional[pulumi.Input[str]] = None,
                 route_table_name: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Route resource

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] address_prefix: The destination CIDR to which the route applies.
        :param pulumi.Input[str] etag: A unique read-only string that changes whenever the resource is updated.
        :param pulumi.Input[str] id: Resource ID.
        :param pulumi.Input[str] name: The name of the resource that is unique within a resource group. This name can be used to access the resource.
        :param pulumi.Input[str] next_hop_ip_address: The IP address packets should be forwarded to. Next hop values are only allowed in routes where the next hop type is VirtualAppliance.
        :param pulumi.Input[Union[str, 'RouteNextHopType']] next_hop_type: The type of Azure hop the packet should be sent to. Possible values are: 'VirtualNetworkGateway', 'VnetLocal', 'Internet', 'VirtualAppliance', and 'None'
        :param pulumi.Input[str] provisioning_state: The provisioning state of the resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
        :param pulumi.Input[str] resource_group_name: The name of the resource group.
        :param pulumi.Input[str] route_name: The name of the route.
        :param pulumi.Input[str] route_table_name: The name of the route table.
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
            __props__['etag'] = etag
            __props__['id'] = id
            __props__['name'] = name
            __props__['next_hop_ip_address'] = next_hop_ip_address
            if next_hop_type is None and not opts.urn:
                raise TypeError("Missing required property 'next_hop_type'")
            __props__['next_hop_type'] = next_hop_type
            __props__['provisioning_state'] = provisioning_state
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if route_name is None and not opts.urn:
                raise TypeError("Missing required property 'route_name'")
            __props__['route_name'] = route_name
            if route_table_name is None and not opts.urn:
                raise TypeError("Missing required property 'route_table_name'")
            __props__['route_table_name'] = route_table_name
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:network/latest:Route"), pulumi.Alias(type_="azure-nextgen:network/v20150501preview:Route"), pulumi.Alias(type_="azure-nextgen:network/v20150615:Route"), pulumi.Alias(type_="azure-nextgen:network/v20160330:Route"), pulumi.Alias(type_="azure-nextgen:network/v20160601:Route"), pulumi.Alias(type_="azure-nextgen:network/v20160901:Route"), pulumi.Alias(type_="azure-nextgen:network/v20161201:Route"), pulumi.Alias(type_="azure-nextgen:network/v20170301:Route"), pulumi.Alias(type_="azure-nextgen:network/v20170601:Route"), pulumi.Alias(type_="azure-nextgen:network/v20170801:Route"), pulumi.Alias(type_="azure-nextgen:network/v20170901:Route"), pulumi.Alias(type_="azure-nextgen:network/v20171001:Route"), pulumi.Alias(type_="azure-nextgen:network/v20171101:Route"), pulumi.Alias(type_="azure-nextgen:network/v20180201:Route"), pulumi.Alias(type_="azure-nextgen:network/v20180401:Route"), pulumi.Alias(type_="azure-nextgen:network/v20180601:Route"), pulumi.Alias(type_="azure-nextgen:network/v20180701:Route"), pulumi.Alias(type_="azure-nextgen:network/v20180801:Route"), pulumi.Alias(type_="azure-nextgen:network/v20181001:Route"), pulumi.Alias(type_="azure-nextgen:network/v20181101:Route"), pulumi.Alias(type_="azure-nextgen:network/v20181201:Route"), pulumi.Alias(type_="azure-nextgen:network/v20190201:Route"), pulumi.Alias(type_="azure-nextgen:network/v20190401:Route"), pulumi.Alias(type_="azure-nextgen:network/v20190601:Route"), pulumi.Alias(type_="azure-nextgen:network/v20190701:Route"), pulumi.Alias(type_="azure-nextgen:network/v20190801:Route"), pulumi.Alias(type_="azure-nextgen:network/v20190901:Route"), pulumi.Alias(type_="azure-nextgen:network/v20191101:Route"), pulumi.Alias(type_="azure-nextgen:network/v20191201:Route"), pulumi.Alias(type_="azure-nextgen:network/v20200301:Route"), pulumi.Alias(type_="azure-nextgen:network/v20200401:Route"), pulumi.Alias(type_="azure-nextgen:network/v20200501:Route"), pulumi.Alias(type_="azure-nextgen:network/v20200601:Route"), pulumi.Alias(type_="azure-nextgen:network/v20200701:Route"), pulumi.Alias(type_="azure-nextgen:network/v20200801:Route")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(Route, __self__).__init__(
            'azure-nextgen:network/v20180101:Route',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Route':
        """
        Get an existing Route resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return Route(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="addressPrefix")
    def address_prefix(self) -> pulumi.Output[Optional[str]]:
        """
        The destination CIDR to which the route applies.
        """
        return pulumi.get(self, "address_prefix")

    @property
    @pulumi.getter
    def etag(self) -> pulumi.Output[Optional[str]]:
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
    @pulumi.getter(name="nextHopIpAddress")
    def next_hop_ip_address(self) -> pulumi.Output[Optional[str]]:
        """
        The IP address packets should be forwarded to. Next hop values are only allowed in routes where the next hop type is VirtualAppliance.
        """
        return pulumi.get(self, "next_hop_ip_address")

    @property
    @pulumi.getter(name="nextHopType")
    def next_hop_type(self) -> pulumi.Output[str]:
        """
        The type of Azure hop the packet should be sent to. Possible values are: 'VirtualNetworkGateway', 'VnetLocal', 'Internet', 'VirtualAppliance', and 'None'
        """
        return pulumi.get(self, "next_hop_type")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[Optional[str]]:
        """
        The provisioning state of the resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
        """
        return pulumi.get(self, "provisioning_state")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

