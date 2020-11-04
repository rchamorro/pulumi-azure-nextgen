# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from . import outputs

__all__ = [
    'GetCustomIPPrefixResult',
    'AwaitableGetCustomIPPrefixResult',
    'get_custom_ip_prefix',
]

@pulumi.output_type
class GetCustomIPPrefixResult:
    """
    Custom IP prefix resource.
    """
    def __init__(__self__, cidr=None, commissioned_state=None, etag=None, location=None, name=None, provisioning_state=None, public_ip_prefixes=None, resource_guid=None, tags=None, type=None, zones=None):
        if cidr and not isinstance(cidr, str):
            raise TypeError("Expected argument 'cidr' to be a str")
        pulumi.set(__self__, "cidr", cidr)
        if commissioned_state and not isinstance(commissioned_state, str):
            raise TypeError("Expected argument 'commissioned_state' to be a str")
        pulumi.set(__self__, "commissioned_state", commissioned_state)
        if etag and not isinstance(etag, str):
            raise TypeError("Expected argument 'etag' to be a str")
        pulumi.set(__self__, "etag", etag)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if public_ip_prefixes and not isinstance(public_ip_prefixes, list):
            raise TypeError("Expected argument 'public_ip_prefixes' to be a list")
        pulumi.set(__self__, "public_ip_prefixes", public_ip_prefixes)
        if resource_guid and not isinstance(resource_guid, str):
            raise TypeError("Expected argument 'resource_guid' to be a str")
        pulumi.set(__self__, "resource_guid", resource_guid)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if zones and not isinstance(zones, list):
            raise TypeError("Expected argument 'zones' to be a list")
        pulumi.set(__self__, "zones", zones)

    @property
    @pulumi.getter
    def cidr(self) -> Optional[str]:
        """
        The prefix range in CIDR notation. Should include the start address and the prefix length.
        """
        return pulumi.get(self, "cidr")

    @property
    @pulumi.getter(name="commissionedState")
    def commissioned_state(self) -> Optional[str]:
        """
        The commissioned state of the Custom IP Prefix.
        """
        return pulumi.get(self, "commissioned_state")

    @property
    @pulumi.getter
    def etag(self) -> str:
        """
        A unique read-only string that changes whenever the resource is updated.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter
    def location(self) -> Optional[str]:
        """
        Resource location.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        The provisioning state of the custom IP prefix resource.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="publicIpPrefixes")
    def public_ip_prefixes(self) -> Sequence['outputs.SubResourceResponse']:
        """
        The list of all referenced PublicIpPrefixes.
        """
        return pulumi.get(self, "public_ip_prefixes")

    @property
    @pulumi.getter(name="resourceGuid")
    def resource_guid(self) -> str:
        """
        The resource GUID property of the custom IP prefix resource.
        """
        return pulumi.get(self, "resource_guid")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        Resource tags.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Resource type.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def zones(self) -> Optional[Sequence[str]]:
        """
        A list of availability zones denoting the IP allocated for the resource needs to come from.
        """
        return pulumi.get(self, "zones")


class AwaitableGetCustomIPPrefixResult(GetCustomIPPrefixResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetCustomIPPrefixResult(
            cidr=self.cidr,
            commissioned_state=self.commissioned_state,
            etag=self.etag,
            location=self.location,
            name=self.name,
            provisioning_state=self.provisioning_state,
            public_ip_prefixes=self.public_ip_prefixes,
            resource_guid=self.resource_guid,
            tags=self.tags,
            type=self.type,
            zones=self.zones)


def get_custom_ip_prefix(custom_ip_prefix_name: Optional[str] = None,
                         expand: Optional[str] = None,
                         resource_group_name: Optional[str] = None,
                         opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetCustomIPPrefixResult:
    """
    Use this data source to access information about an existing resource.

    :param str custom_ip_prefix_name: The name of the custom IP prefix.
    :param str expand: Expands referenced resources.
    :param str resource_group_name: The name of the resource group.
    """
    __args__ = dict()
    __args__['customIpPrefixName'] = custom_ip_prefix_name
    __args__['expand'] = expand
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:network/v20200701:getCustomIPPrefix', __args__, opts=opts, typ=GetCustomIPPrefixResult).value

    return AwaitableGetCustomIPPrefixResult(
        cidr=__ret__.cidr,
        commissioned_state=__ret__.commissioned_state,
        etag=__ret__.etag,
        location=__ret__.location,
        name=__ret__.name,
        provisioning_state=__ret__.provisioning_state,
        public_ip_prefixes=__ret__.public_ip_prefixes,
        resource_guid=__ret__.resource_guid,
        tags=__ret__.tags,
        type=__ret__.type,
        zones=__ret__.zones)
