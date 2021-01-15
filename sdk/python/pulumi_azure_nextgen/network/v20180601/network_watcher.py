# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = ['NetworkWatcher']


class NetworkWatcher(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 etag: Optional[pulumi.Input[str]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 network_watcher_name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Network watcher in a resource group.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] etag: A unique read-only string that changes whenever the resource is updated.
        :param pulumi.Input[str] id: Resource ID.
        :param pulumi.Input[str] location: Resource location.
        :param pulumi.Input[str] network_watcher_name: The name of the network watcher.
        :param pulumi.Input[str] resource_group_name: The name of the resource group.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
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

            __props__['etag'] = etag
            __props__['id'] = id
            __props__['location'] = location
            if network_watcher_name is None and not opts.urn:
                raise TypeError("Missing required property 'network_watcher_name'")
            __props__['network_watcher_name'] = network_watcher_name
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['tags'] = tags
            __props__['name'] = None
            __props__['provisioning_state'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:network/latest:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20160901:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20161201:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20170301:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20170601:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20170801:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20170901:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20171001:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20171101:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20180101:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20180201:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20180401:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20180701:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20180801:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20181001:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20181101:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20181201:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20190201:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20190401:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20190601:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20190701:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20190801:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20190901:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20191101:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20191201:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20200301:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20200401:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20200501:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20200601:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20200701:NetworkWatcher"), pulumi.Alias(type_="azure-nextgen:network/v20200801:NetworkWatcher")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(NetworkWatcher, __self__).__init__(
            'azure-nextgen:network/v20180601:NetworkWatcher',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'NetworkWatcher':
        """
        Get an existing NetworkWatcher resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return NetworkWatcher(resource_name, opts=opts, __props__=__props__)

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

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

