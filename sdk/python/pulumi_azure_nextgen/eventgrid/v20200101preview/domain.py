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

__all__ = ['Domain']


class Domain(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 domain_name: Optional[pulumi.Input[str]] = None,
                 input_schema: Optional[pulumi.Input[Union[str, 'InputSchema']]] = None,
                 input_schema_mapping: Optional[pulumi.Input[pulumi.InputType['JsonInputSchemaMappingArgs']]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        EventGrid Domain

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] domain_name: Name of the domain
        :param pulumi.Input[Union[str, 'InputSchema']] input_schema: This determines the format that Event Grid should expect for incoming events published to the domain.
        :param pulumi.Input[pulumi.InputType['JsonInputSchemaMappingArgs']] input_schema_mapping: Information about the InputSchemaMapping which specified the info about mapping event payload.
        :param pulumi.Input[str] location: Location of the resource
        :param pulumi.Input[str] resource_group_name: The name of the resource group within the user's subscription.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Tags of the resource
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

            if domain_name is None and not opts.urn:
                raise TypeError("Missing required property 'domain_name'")
            __props__['domain_name'] = domain_name
            if input_schema is None:
                input_schema = 'EventGridSchema'
            __props__['input_schema'] = input_schema
            __props__['input_schema_mapping'] = input_schema_mapping
            if location is None and not opts.urn:
                raise TypeError("Missing required property 'location'")
            __props__['location'] = location
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['tags'] = tags
            __props__['endpoint'] = None
            __props__['metric_resource_id'] = None
            __props__['name'] = None
            __props__['provisioning_state'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:eventgrid/latest:Domain"), pulumi.Alias(type_="azure-nextgen:eventgrid/v20180915preview:Domain"), pulumi.Alias(type_="azure-nextgen:eventgrid/v20190201preview:Domain"), pulumi.Alias(type_="azure-nextgen:eventgrid/v20190601:Domain"), pulumi.Alias(type_="azure-nextgen:eventgrid/v20200401preview:Domain"), pulumi.Alias(type_="azure-nextgen:eventgrid/v20200601:Domain")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(Domain, __self__).__init__(
            'azure-nextgen:eventgrid/v20200101preview:Domain',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Domain':
        """
        Get an existing Domain resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return Domain(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def endpoint(self) -> pulumi.Output[str]:
        """
        Endpoint for the domain.
        """
        return pulumi.get(self, "endpoint")

    @property
    @pulumi.getter(name="inputSchema")
    def input_schema(self) -> pulumi.Output[Optional[str]]:
        """
        This determines the format that Event Grid should expect for incoming events published to the domain.
        """
        return pulumi.get(self, "input_schema")

    @property
    @pulumi.getter(name="inputSchemaMapping")
    def input_schema_mapping(self) -> pulumi.Output[Optional['outputs.JsonInputSchemaMappingResponse']]:
        """
        Information about the InputSchemaMapping which specified the info about mapping event payload.
        """
        return pulumi.get(self, "input_schema_mapping")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        Location of the resource
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="metricResourceId")
    def metric_resource_id(self) -> pulumi.Output[str]:
        """
        Metric resource id for the domain.
        """
        return pulumi.get(self, "metric_resource_id")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        Provisioning state of the domain.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Tags of the resource
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Type of the resource
        """
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

