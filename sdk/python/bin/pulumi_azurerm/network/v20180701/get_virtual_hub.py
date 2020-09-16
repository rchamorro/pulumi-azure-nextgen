# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from ... import _utilities, _tables
from . import outputs

__all__ = [
    'GetVirtualHubResult',
    'AwaitableGetVirtualHubResult',
    'get_virtual_hub',
]

@pulumi.output_type
class GetVirtualHubResult:
    """
    VirtualHub Resource.
    """
    def __init__(__self__, address_prefix=None, etag=None, hub_virtual_network_connections=None, location=None, name=None, provisioning_state=None, tags=None, type=None, virtual_wan=None):
        if address_prefix and not isinstance(address_prefix, str):
            raise TypeError("Expected argument 'address_prefix' to be a str")
        pulumi.set(__self__, "address_prefix", address_prefix)
        if etag and not isinstance(etag, str):
            raise TypeError("Expected argument 'etag' to be a str")
        pulumi.set(__self__, "etag", etag)
        if hub_virtual_network_connections and not isinstance(hub_virtual_network_connections, list):
            raise TypeError("Expected argument 'hub_virtual_network_connections' to be a list")
        pulumi.set(__self__, "hub_virtual_network_connections", hub_virtual_network_connections)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if virtual_wan and not isinstance(virtual_wan, dict):
            raise TypeError("Expected argument 'virtual_wan' to be a dict")
        pulumi.set(__self__, "virtual_wan", virtual_wan)

    @property
    @pulumi.getter(name="addressPrefix")
    def address_prefix(self) -> Optional[str]:
        """
        Address-prefix for this VirtualHub.
        """
        return pulumi.get(self, "address_prefix")

    @property
    @pulumi.getter
    def etag(self) -> str:
        """
        Gets a unique read-only string that changes whenever the resource is updated.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter(name="hubVirtualNetworkConnections")
    def hub_virtual_network_connections(self) -> Optional[List['outputs.HubVirtualNetworkConnectionResponse']]:
        """
        list of all vnet connections with this VirtualHub.
        """
        return pulumi.get(self, "hub_virtual_network_connections")

    @property
    @pulumi.getter
    def location(self) -> str:
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
    def provisioning_state(self) -> Optional[str]:
        """
        The provisioning state of the resource.
        """
        return pulumi.get(self, "provisioning_state")

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
    @pulumi.getter(name="virtualWan")
    def virtual_wan(self) -> Optional['outputs.SubResourceResponse']:
        """
        The VirtualWAN to which the VirtualHub belongs
        """
        return pulumi.get(self, "virtual_wan")


class AwaitableGetVirtualHubResult(GetVirtualHubResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetVirtualHubResult(
            address_prefix=self.address_prefix,
            etag=self.etag,
            hub_virtual_network_connections=self.hub_virtual_network_connections,
            location=self.location,
            name=self.name,
            provisioning_state=self.provisioning_state,
            tags=self.tags,
            type=self.type,
            virtual_wan=self.virtual_wan)


def get_virtual_hub(resource_group_name: Optional[str] = None,
                    virtual_hub_name: Optional[str] = None,
                    opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetVirtualHubResult:
    """
    Use this data source to access information about an existing resource.

    :param str resource_group_name: The resource group name of the VirtualHub.
    :param str virtual_hub_name: The name of the VirtualHub.
    """
    __args__ = dict()
    __args__['resourceGroupName'] = resource_group_name
    __args__['virtualHubName'] = virtual_hub_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azurerm:network/v20180701:getVirtualHub', __args__, opts=opts, typ=GetVirtualHubResult).value

    return AwaitableGetVirtualHubResult(
        address_prefix=__ret__.address_prefix,
        etag=__ret__.etag,
        hub_virtual_network_connections=__ret__.hub_virtual_network_connections,
        location=__ret__.location,
        name=__ret__.name,
        provisioning_state=__ret__.provisioning_state,
        tags=__ret__.tags,
        type=__ret__.type,
        virtual_wan=__ret__.virtual_wan)