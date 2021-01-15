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

__all__ = ['PublicIPAddress']


class PublicIPAddress(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 dns_settings: Optional[pulumi.Input[pulumi.InputType['PublicIPAddressDnsSettingsArgs']]] = None,
                 etag: Optional[pulumi.Input[str]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 idle_timeout_in_minutes: Optional[pulumi.Input[int]] = None,
                 ip_address: Optional[pulumi.Input[str]] = None,
                 ip_tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['IpTagArgs']]]]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 provisioning_state: Optional[pulumi.Input[str]] = None,
                 public_ip_address_version: Optional[pulumi.Input[Union[str, 'IPVersion']]] = None,
                 public_ip_allocation_method: Optional[pulumi.Input[Union[str, 'IPAllocationMethod']]] = None,
                 public_ip_address_name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 resource_guid: Optional[pulumi.Input[str]] = None,
                 sku: Optional[pulumi.Input[pulumi.InputType['PublicIPAddressSkuArgs']]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 zones: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Public IP address resource.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['PublicIPAddressDnsSettingsArgs']] dns_settings: The FQDN of the DNS record associated with the public IP address.
        :param pulumi.Input[str] etag: A unique read-only string that changes whenever the resource is updated.
        :param pulumi.Input[str] id: Resource ID.
        :param pulumi.Input[int] idle_timeout_in_minutes: The idle timeout of the public IP address.
        :param pulumi.Input[str] ip_address: The IP address associated with the public IP address resource.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['IpTagArgs']]]] ip_tags: The list of tags associated with the public IP address.
        :param pulumi.Input[str] location: Resource location.
        :param pulumi.Input[str] provisioning_state: The provisioning state of the PublicIP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
        :param pulumi.Input[Union[str, 'IPVersion']] public_ip_address_version: The public IP address version. Possible values are: 'IPv4' and 'IPv6'.
        :param pulumi.Input[Union[str, 'IPAllocationMethod']] public_ip_allocation_method: The public IP allocation method. Possible values are: 'Static' and 'Dynamic'.
        :param pulumi.Input[str] public_ip_address_name: The name of the public IP address.
        :param pulumi.Input[str] resource_group_name: The name of the resource group.
        :param pulumi.Input[str] resource_guid: The resource GUID property of the public IP resource.
        :param pulumi.Input[pulumi.InputType['PublicIPAddressSkuArgs']] sku: The public IP address SKU.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] zones: A list of availability zones denoting the IP allocated for the resource needs to come from.
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

            __props__['dns_settings'] = dns_settings
            __props__['etag'] = etag
            __props__['id'] = id
            __props__['idle_timeout_in_minutes'] = idle_timeout_in_minutes
            __props__['ip_address'] = ip_address
            __props__['ip_tags'] = ip_tags
            __props__['location'] = location
            __props__['provisioning_state'] = provisioning_state
            __props__['public_ip_address_version'] = public_ip_address_version
            __props__['public_ip_allocation_method'] = public_ip_allocation_method
            if public_ip_address_name is None and not opts.urn:
                raise TypeError("Missing required property 'public_ip_address_name'")
            __props__['public_ip_address_name'] = public_ip_address_name
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['resource_guid'] = resource_guid
            __props__['sku'] = sku
            __props__['tags'] = tags
            __props__['zones'] = zones
            __props__['ip_configuration'] = None
            __props__['name'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:network/latest:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20150501preview:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20150615:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20160330:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20160601:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20160901:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20161201:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20170301:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20170601:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20170801:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20170901:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20171001:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20171101:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20180101:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20180201:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20180601:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20180701:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20180801:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20181001:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20181101:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20181201:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20190201:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20190401:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20190601:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20190701:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20190801:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20190901:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20191101:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20191201:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20200301:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20200401:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20200501:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20200601:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20200701:PublicIPAddress"), pulumi.Alias(type_="azure-nextgen:network/v20200801:PublicIPAddress")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(PublicIPAddress, __self__).__init__(
            'azure-nextgen:network/v20180401:PublicIPAddress',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'PublicIPAddress':
        """
        Get an existing PublicIPAddress resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return PublicIPAddress(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="dnsSettings")
    def dns_settings(self) -> pulumi.Output[Optional['outputs.PublicIPAddressDnsSettingsResponse']]:
        """
        The FQDN of the DNS record associated with the public IP address.
        """
        return pulumi.get(self, "dns_settings")

    @property
    @pulumi.getter
    def etag(self) -> pulumi.Output[Optional[str]]:
        """
        A unique read-only string that changes whenever the resource is updated.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter(name="idleTimeoutInMinutes")
    def idle_timeout_in_minutes(self) -> pulumi.Output[Optional[int]]:
        """
        The idle timeout of the public IP address.
        """
        return pulumi.get(self, "idle_timeout_in_minutes")

    @property
    @pulumi.getter(name="ipAddress")
    def ip_address(self) -> pulumi.Output[Optional[str]]:
        """
        The IP address associated with the public IP address resource.
        """
        return pulumi.get(self, "ip_address")

    @property
    @pulumi.getter(name="ipConfiguration")
    def ip_configuration(self) -> pulumi.Output['outputs.IPConfigurationResponse']:
        """
        The IP configuration associated with the public IP address.
        """
        return pulumi.get(self, "ip_configuration")

    @property
    @pulumi.getter(name="ipTags")
    def ip_tags(self) -> pulumi.Output[Optional[Sequence['outputs.IpTagResponse']]]:
        """
        The list of tags associated with the public IP address.
        """
        return pulumi.get(self, "ip_tags")

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
    def provisioning_state(self) -> pulumi.Output[Optional[str]]:
        """
        The provisioning state of the PublicIP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="publicIPAddressVersion")
    def public_ip_address_version(self) -> pulumi.Output[Optional[str]]:
        """
        The public IP address version. Possible values are: 'IPv4' and 'IPv6'.
        """
        return pulumi.get(self, "public_ip_address_version")

    @property
    @pulumi.getter(name="publicIPAllocationMethod")
    def public_ip_allocation_method(self) -> pulumi.Output[Optional[str]]:
        """
        The public IP allocation method. Possible values are: 'Static' and 'Dynamic'.
        """
        return pulumi.get(self, "public_ip_allocation_method")

    @property
    @pulumi.getter(name="resourceGuid")
    def resource_guid(self) -> pulumi.Output[Optional[str]]:
        """
        The resource GUID property of the public IP resource.
        """
        return pulumi.get(self, "resource_guid")

    @property
    @pulumi.getter
    def sku(self) -> pulumi.Output[Optional['outputs.PublicIPAddressSkuResponse']]:
        """
        The public IP address SKU.
        """
        return pulumi.get(self, "sku")

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
    @pulumi.getter
    def zones(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        A list of availability zones denoting the IP allocated for the resource needs to come from.
        """
        return pulumi.get(self, "zones")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

