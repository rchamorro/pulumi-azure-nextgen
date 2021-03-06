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

__all__ = ['Controller']


class Controller(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 sku: Optional[pulumi.Input[pulumi.InputType['SkuArgs']]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 target_container_host_credentials_base64: Optional[pulumi.Input[str]] = None,
                 target_container_host_resource_id: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Create a Controller resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] location: Region where the Azure resource is located.
        :param pulumi.Input[str] name: Name of the resource.
        :param pulumi.Input[str] resource_group_name: Resource group to which the resource belongs.
        :param pulumi.Input[pulumi.InputType['SkuArgs']] sku: Model representing SKU for Azure Dev Spaces Controller.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Tags for the Azure resource.
        :param pulumi.Input[str] target_container_host_credentials_base64: Credentials of the target container host (base64).
        :param pulumi.Input[str] target_container_host_resource_id: Resource ID of the target container host
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

            __props__['location'] = location
            if name is None and not opts.urn:
                raise TypeError("Missing required property 'name'")
            __props__['name'] = name
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if sku is None and not opts.urn:
                raise TypeError("Missing required property 'sku'")
            __props__['sku'] = sku
            __props__['tags'] = tags
            if target_container_host_credentials_base64 is None and not opts.urn:
                raise TypeError("Missing required property 'target_container_host_credentials_base64'")
            __props__['target_container_host_credentials_base64'] = target_container_host_credentials_base64
            if target_container_host_resource_id is None and not opts.urn:
                raise TypeError("Missing required property 'target_container_host_resource_id'")
            __props__['target_container_host_resource_id'] = target_container_host_resource_id
            __props__['data_plane_fqdn'] = None
            __props__['host_suffix'] = None
            __props__['provisioning_state'] = None
            __props__['target_container_host_api_server_fqdn'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:devspaces/latest:Controller")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(Controller, __self__).__init__(
            'azure-nextgen:devspaces/v20190401:Controller',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Controller':
        """
        Get an existing Controller resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return Controller(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="dataPlaneFqdn")
    def data_plane_fqdn(self) -> pulumi.Output[str]:
        """
        DNS name for accessing DataPlane services
        """
        return pulumi.get(self, "data_plane_fqdn")

    @property
    @pulumi.getter(name="hostSuffix")
    def host_suffix(self) -> pulumi.Output[str]:
        """
        DNS suffix for public endpoints running in the Azure Dev Spaces Controller.
        """
        return pulumi.get(self, "host_suffix")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        Region where the Azure resource is located.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the resource.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        Provisioning state of the Azure Dev Spaces Controller.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter
    def sku(self) -> pulumi.Output['outputs.SkuResponse']:
        """
        Model representing SKU for Azure Dev Spaces Controller.
        """
        return pulumi.get(self, "sku")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Tags for the Azure resource.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="targetContainerHostApiServerFqdn")
    def target_container_host_api_server_fqdn(self) -> pulumi.Output[str]:
        """
        DNS of the target container host's API server
        """
        return pulumi.get(self, "target_container_host_api_server_fqdn")

    @property
    @pulumi.getter(name="targetContainerHostCredentialsBase64")
    def target_container_host_credentials_base64(self) -> pulumi.Output[str]:
        """
        Credentials of the target container host (base64).
        """
        return pulumi.get(self, "target_container_host_credentials_base64")

    @property
    @pulumi.getter(name="targetContainerHostResourceId")
    def target_container_host_resource_id(self) -> pulumi.Output[str]:
        """
        Resource ID of the target container host
        """
        return pulumi.get(self, "target_container_host_resource_id")

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

