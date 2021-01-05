# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = ['Watcher']


class Watcher(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 automation_account_name: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 etag: Optional[pulumi.Input[str]] = None,
                 execution_frequency_in_seconds: Optional[pulumi.Input[float]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 script_name: Optional[pulumi.Input[str]] = None,
                 script_parameters: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 script_run_on: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 watcher_name: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Definition of the watcher type.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] automation_account_name: The name of the automation account.
        :param pulumi.Input[str] description: Gets or sets the description.
        :param pulumi.Input[str] etag: Gets or sets the etag of the resource.
        :param pulumi.Input[float] execution_frequency_in_seconds: Gets or sets the frequency at which the watcher is invoked.
        :param pulumi.Input[str] location: The Azure Region where the resource lives
        :param pulumi.Input[str] resource_group_name: Name of an Azure Resource group.
        :param pulumi.Input[str] script_name: Gets or sets the name of the script the watcher is attached to, i.e. the name of an existing runbook.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] script_parameters: Gets or sets the parameters of the script.
        :param pulumi.Input[str] script_run_on: Gets or sets the name of the hybrid worker group the watcher will run on.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
        :param pulumi.Input[str] watcher_name: The watcher name.
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

            if automation_account_name is None and not opts.urn:
                raise TypeError("Missing required property 'automation_account_name'")
            __props__['automation_account_name'] = automation_account_name
            __props__['description'] = description
            __props__['etag'] = etag
            __props__['execution_frequency_in_seconds'] = execution_frequency_in_seconds
            __props__['location'] = location
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['script_name'] = script_name
            __props__['script_parameters'] = script_parameters
            __props__['script_run_on'] = script_run_on
            __props__['tags'] = tags
            if watcher_name is None and not opts.urn:
                raise TypeError("Missing required property 'watcher_name'")
            __props__['watcher_name'] = watcher_name
            __props__['creation_time'] = None
            __props__['last_modified_by'] = None
            __props__['last_modified_time'] = None
            __props__['name'] = None
            __props__['status'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:automation/latest:Watcher")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(Watcher, __self__).__init__(
            'azure-nextgen:automation/v20151031:Watcher',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Watcher':
        """
        Get an existing Watcher resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return Watcher(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="creationTime")
    def creation_time(self) -> pulumi.Output[str]:
        """
        Gets or sets the creation time.
        """
        return pulumi.get(self, "creation_time")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        Gets or sets the description.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def etag(self) -> pulumi.Output[Optional[str]]:
        """
        Gets or sets the etag of the resource.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter(name="executionFrequencyInSeconds")
    def execution_frequency_in_seconds(self) -> pulumi.Output[Optional[float]]:
        """
        Gets or sets the frequency at which the watcher is invoked.
        """
        return pulumi.get(self, "execution_frequency_in_seconds")

    @property
    @pulumi.getter(name="lastModifiedBy")
    def last_modified_by(self) -> pulumi.Output[str]:
        """
        Details of the user who last modified the watcher.
        """
        return pulumi.get(self, "last_modified_by")

    @property
    @pulumi.getter(name="lastModifiedTime")
    def last_modified_time(self) -> pulumi.Output[str]:
        """
        Gets or sets the last modified time.
        """
        return pulumi.get(self, "last_modified_time")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[Optional[str]]:
        """
        The Azure Region where the resource lives
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
    @pulumi.getter(name="scriptName")
    def script_name(self) -> pulumi.Output[Optional[str]]:
        """
        Gets or sets the name of the script the watcher is attached to, i.e. the name of an existing runbook.
        """
        return pulumi.get(self, "script_name")

    @property
    @pulumi.getter(name="scriptParameters")
    def script_parameters(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Gets or sets the parameters of the script.
        """
        return pulumi.get(self, "script_parameters")

    @property
    @pulumi.getter(name="scriptRunOn")
    def script_run_on(self) -> pulumi.Output[Optional[str]]:
        """
        Gets or sets the name of the hybrid worker group the watcher will run on.
        """
        return pulumi.get(self, "script_run_on")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[str]:
        """
        Gets the current status of the watcher.
        """
        return pulumi.get(self, "status")

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
        The type of the resource.
        """
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

