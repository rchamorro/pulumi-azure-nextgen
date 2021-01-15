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

__all__ = ['VirtualApplianceSite']


class VirtualApplianceSite(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 address_prefix: Optional[pulumi.Input[str]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 network_virtual_appliance_name: Optional[pulumi.Input[str]] = None,
                 o365_policy: Optional[pulumi.Input[pulumi.InputType['Office365PolicyPropertiesArgs']]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 site_name: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Virtual Appliance Site resource.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] address_prefix: Address Prefix.
        :param pulumi.Input[str] id: Resource ID.
        :param pulumi.Input[str] name: Name of the virtual appliance site.
        :param pulumi.Input[str] network_virtual_appliance_name: The name of the Network Virtual Appliance.
        :param pulumi.Input[pulumi.InputType['Office365PolicyPropertiesArgs']] o365_policy: Office 365 Policy.
        :param pulumi.Input[str] resource_group_name: The name of the resource group.
        :param pulumi.Input[str] site_name: The name of the site.
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
            __props__['id'] = id
            __props__['name'] = name
            if network_virtual_appliance_name is None and not opts.urn:
                raise TypeError("Missing required property 'network_virtual_appliance_name'")
            __props__['network_virtual_appliance_name'] = network_virtual_appliance_name
            __props__['o365_policy'] = o365_policy
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if site_name is None and not opts.urn:
                raise TypeError("Missing required property 'site_name'")
            __props__['site_name'] = site_name
            __props__['etag'] = None
            __props__['provisioning_state'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:network/latest:VirtualApplianceSite"), pulumi.Alias(type_="azure-nextgen:network/v20200501:VirtualApplianceSite"), pulumi.Alias(type_="azure-nextgen:network/v20200601:VirtualApplianceSite"), pulumi.Alias(type_="azure-nextgen:network/v20200801:VirtualApplianceSite")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(VirtualApplianceSite, __self__).__init__(
            'azure-nextgen:network/v20200701:VirtualApplianceSite',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'VirtualApplianceSite':
        """
        Get an existing VirtualApplianceSite resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return VirtualApplianceSite(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="addressPrefix")
    def address_prefix(self) -> pulumi.Output[Optional[str]]:
        """
        Address Prefix.
        """
        return pulumi.get(self, "address_prefix")

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
        Name of the virtual appliance site.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="o365Policy")
    def o365_policy(self) -> pulumi.Output[Optional['outputs.Office365PolicyPropertiesResponse']]:
        """
        Office 365 Policy.
        """
        return pulumi.get(self, "o365_policy")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        The provisioning state of the resource.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Site type.
        """
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

