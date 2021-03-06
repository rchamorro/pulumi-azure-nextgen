# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from . import outputs

__all__ = ['SqlServerInstance']


class SqlServerInstance(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 container_resource_id: Optional[pulumi.Input[str]] = None,
                 edition: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 sql_server_instance_name: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 v_core: Optional[pulumi.Input[str]] = None,
                 version: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        A SqlServerInstance.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] container_resource_id: ARM Resource id of the container resource (Azure Arc for Servers)
        :param pulumi.Input[str] edition: SQL Server edition.
        :param pulumi.Input[str] location: The geo-location where the resource lives
        :param pulumi.Input[str] resource_group_name: The name of the Azure resource group
        :param pulumi.Input[str] sql_server_instance_name: The name of SQL Server Instance
        :param pulumi.Input[str] status: The cloud connectivity status.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
        :param pulumi.Input[str] v_core: The number of logical processors used by the SQL Server instance.
        :param pulumi.Input[str] version: SQL Server version.
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

            if container_resource_id is None and not opts.urn:
                raise TypeError("Missing required property 'container_resource_id'")
            __props__['container_resource_id'] = container_resource_id
            if edition is None and not opts.urn:
                raise TypeError("Missing required property 'edition'")
            __props__['edition'] = edition
            __props__['location'] = location
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if sql_server_instance_name is None and not opts.urn:
                raise TypeError("Missing required property 'sql_server_instance_name'")
            __props__['sql_server_instance_name'] = sql_server_instance_name
            if status is None and not opts.urn:
                raise TypeError("Missing required property 'status'")
            __props__['status'] = status
            __props__['tags'] = tags
            if v_core is None and not opts.urn:
                raise TypeError("Missing required property 'v_core'")
            __props__['v_core'] = v_core
            if version is None and not opts.urn:
                raise TypeError("Missing required property 'version'")
            __props__['version'] = version
            __props__['create_time'] = None
            __props__['name'] = None
            __props__['system_data'] = None
            __props__['type'] = None
            __props__['update_time'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:azuredata/v20190724preview:SqlServerInstance")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(SqlServerInstance, __self__).__init__(
            'azure-nextgen:azuredata/v20200908preview:SqlServerInstance',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'SqlServerInstance':
        """
        Get an existing SqlServerInstance resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return SqlServerInstance(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="containerResourceId")
    def container_resource_id(self) -> pulumi.Output[str]:
        """
        ARM Resource id of the container resource (Azure Arc for Servers)
        """
        return pulumi.get(self, "container_resource_id")

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> pulumi.Output[str]:
        """
        The time when the resource was created.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter
    def edition(self) -> pulumi.Output[str]:
        """
        SQL Server edition.
        """
        return pulumi.get(self, "edition")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        The geo-location where the resource lives
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[str]:
        """
        The cloud connectivity status.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter(name="systemData")
    def system_data(self) -> pulumi.Output['outputs.SystemDataResponse']:
        """
        Read only system data
        """
        return pulumi.get(self, "system_data")

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
        The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="updateTime")
    def update_time(self) -> pulumi.Output[str]:
        """
        The time when the resource was last updated.
        """
        return pulumi.get(self, "update_time")

    @property
    @pulumi.getter(name="vCore")
    def v_core(self) -> pulumi.Output[str]:
        """
        The number of logical processors used by the SQL Server instance.
        """
        return pulumi.get(self, "v_core")

    @property
    @pulumi.getter
    def version(self) -> pulumi.Output[str]:
        """
        SQL Server version.
        """
        return pulumi.get(self, "version")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

