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

__all__ = ['IotDpsResource']


class IotDpsResource(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 etag: Optional[pulumi.Input[str]] = None,
                 identity: Optional[pulumi.Input[pulumi.InputType['ArmIdentityArgs']]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 properties: Optional[pulumi.Input[pulumi.InputType['IotDpsPropertiesDescriptionArgs']]] = None,
                 provisioning_service_name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 sku: Optional[pulumi.Input[pulumi.InputType['IotDpsSkuInfoArgs']]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        The description of the provisioning service.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] etag: The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal ETag convention.
        :param pulumi.Input[pulumi.InputType['ArmIdentityArgs']] identity: The managed identities for the IotDps instance.
        :param pulumi.Input[str] location: The resource location.
        :param pulumi.Input[pulumi.InputType['IotDpsPropertiesDescriptionArgs']] properties: Service specific properties for a provisioning service
        :param pulumi.Input[str] provisioning_service_name: Name of provisioning service to create or update.
        :param pulumi.Input[str] resource_group_name: Resource group identifier.
        :param pulumi.Input[pulumi.InputType['IotDpsSkuInfoArgs']] sku: Sku info for a provisioning Service.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: The resource tags.
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
            __props__['identity'] = identity
            if location is None and not opts.urn:
                raise TypeError("Missing required property 'location'")
            __props__['location'] = location
            if properties is None and not opts.urn:
                raise TypeError("Missing required property 'properties'")
            __props__['properties'] = properties
            if provisioning_service_name is None and not opts.urn:
                raise TypeError("Missing required property 'provisioning_service_name'")
            __props__['provisioning_service_name'] = provisioning_service_name
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if sku is None and not opts.urn:
                raise TypeError("Missing required property 'sku'")
            __props__['sku'] = sku
            __props__['tags'] = tags
            __props__['name'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:devices/latest:IotDpsResource"), pulumi.Alias(type_="azure-nextgen:devices/v20170821preview:IotDpsResource"), pulumi.Alias(type_="azure-nextgen:devices/v20171115:IotDpsResource"), pulumi.Alias(type_="azure-nextgen:devices/v20180122:IotDpsResource"), pulumi.Alias(type_="azure-nextgen:devices/v20200101:IotDpsResource"), pulumi.Alias(type_="azure-nextgen:devices/v20200301:IotDpsResource")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(IotDpsResource, __self__).__init__(
            'azure-nextgen:devices/v20200901preview:IotDpsResource',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'IotDpsResource':
        """
        Get an existing IotDpsResource resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return IotDpsResource(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def etag(self) -> pulumi.Output[Optional[str]]:
        """
        The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal ETag convention.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter
    def identity(self) -> pulumi.Output[Optional['outputs.ArmIdentityResponse']]:
        """
        The managed identities for the IotDps instance.
        """
        return pulumi.get(self, "identity")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        The resource location.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def properties(self) -> pulumi.Output['outputs.IotDpsPropertiesDescriptionResponse']:
        """
        Service specific properties for a provisioning service
        """
        return pulumi.get(self, "properties")

    @property
    @pulumi.getter
    def sku(self) -> pulumi.Output['outputs.IotDpsSkuInfoResponse']:
        """
        Sku info for a provisioning Service.
        """
        return pulumi.get(self, "sku")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        The resource tags.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        The resource type.
        """
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

