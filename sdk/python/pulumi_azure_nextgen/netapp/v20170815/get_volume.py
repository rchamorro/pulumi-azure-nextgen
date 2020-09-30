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
    'GetVolumeResult',
    'AwaitableGetVolumeResult',
    'get_volume',
]

@pulumi.output_type
class GetVolumeResult:
    """
    Volume resource
    """
    def __init__(__self__, creation_token=None, export_policy=None, file_system_id=None, location=None, name=None, provisioning_state=None, service_level=None, subnet_id=None, tags=None, type=None, usage_threshold=None):
        if creation_token and not isinstance(creation_token, str):
            raise TypeError("Expected argument 'creation_token' to be a str")
        pulumi.set(__self__, "creation_token", creation_token)
        if export_policy and not isinstance(export_policy, dict):
            raise TypeError("Expected argument 'export_policy' to be a dict")
        pulumi.set(__self__, "export_policy", export_policy)
        if file_system_id and not isinstance(file_system_id, str):
            raise TypeError("Expected argument 'file_system_id' to be a str")
        pulumi.set(__self__, "file_system_id", file_system_id)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if service_level and not isinstance(service_level, str):
            raise TypeError("Expected argument 'service_level' to be a str")
        pulumi.set(__self__, "service_level", service_level)
        if subnet_id and not isinstance(subnet_id, str):
            raise TypeError("Expected argument 'subnet_id' to be a str")
        pulumi.set(__self__, "subnet_id", subnet_id)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if usage_threshold and not isinstance(usage_threshold, int):
            raise TypeError("Expected argument 'usage_threshold' to be a int")
        pulumi.set(__self__, "usage_threshold", usage_threshold)

    @property
    @pulumi.getter(name="creationToken")
    def creation_token(self) -> str:
        """
        A unique file path for the volume. Used when creating mount targets
        """
        return pulumi.get(self, "creation_token")

    @property
    @pulumi.getter(name="exportPolicy")
    def export_policy(self) -> Optional['outputs.VolumePropertiesResponseExportPolicy']:
        """
        Export policy rule
        """
        return pulumi.get(self, "export_policy")

    @property
    @pulumi.getter(name="fileSystemId")
    def file_system_id(self) -> str:
        """
        Unique FileSystem Identifier.
        """
        return pulumi.get(self, "file_system_id")

    @property
    @pulumi.getter
    def location(self) -> str:
        """
        Resource location
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Resource name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        Azure lifecycle management
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="serviceLevel")
    def service_level(self) -> str:
        """
        The service level of the file system
        """
        return pulumi.get(self, "service_level")

    @property
    @pulumi.getter(name="subnetId")
    def subnet_id(self) -> Optional[str]:
        """
        The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes
        """
        return pulumi.get(self, "subnet_id")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Any]:
        """
        Resource tags
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Resource type
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="usageThreshold")
    def usage_threshold(self) -> Optional[int]:
        """
        Maximum storage quota allowed for a file system in bytes. This is a soft quota used for alerting only. Minimum size is 100 GiB. Upper limit is 100TiB.
        """
        return pulumi.get(self, "usage_threshold")


class AwaitableGetVolumeResult(GetVolumeResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetVolumeResult(
            creation_token=self.creation_token,
            export_policy=self.export_policy,
            file_system_id=self.file_system_id,
            location=self.location,
            name=self.name,
            provisioning_state=self.provisioning_state,
            service_level=self.service_level,
            subnet_id=self.subnet_id,
            tags=self.tags,
            type=self.type,
            usage_threshold=self.usage_threshold)


def get_volume(account_name: Optional[str] = None,
               pool_name: Optional[str] = None,
               resource_group_name: Optional[str] = None,
               volume_name: Optional[str] = None,
               opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetVolumeResult:
    """
    Use this data source to access information about an existing resource.

    :param str account_name: The name of the NetApp account
    :param str pool_name: The name of the capacity pool
    :param str resource_group_name: The name of the resource group.
    :param str volume_name: The name of the volume
    """
    __args__ = dict()
    __args__['accountName'] = account_name
    __args__['poolName'] = pool_name
    __args__['resourceGroupName'] = resource_group_name
    __args__['volumeName'] = volume_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:netapp/v20170815:getVolume', __args__, opts=opts, typ=GetVolumeResult).value

    return AwaitableGetVolumeResult(
        creation_token=__ret__.creation_token,
        export_policy=__ret__.export_policy,
        file_system_id=__ret__.file_system_id,
        location=__ret__.location,
        name=__ret__.name,
        provisioning_state=__ret__.provisioning_state,
        service_level=__ret__.service_level,
        subnet_id=__ret__.subnet_id,
        tags=__ret__.tags,
        type=__ret__.type,
        usage_threshold=__ret__.usage_threshold)
