# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'GetBackupResult',
    'AwaitableGetBackupResult',
    'get_backup',
]

@pulumi.output_type
class GetBackupResult:
    """
    Backup of a Volume
    """
    def __init__(__self__, backup_id=None, backup_type=None, creation_date=None, id=None, label=None, location=None, name=None, provisioning_state=None, size=None, type=None):
        if backup_id and not isinstance(backup_id, str):
            raise TypeError("Expected argument 'backup_id' to be a str")
        pulumi.set(__self__, "backup_id", backup_id)
        if backup_type and not isinstance(backup_type, str):
            raise TypeError("Expected argument 'backup_type' to be a str")
        pulumi.set(__self__, "backup_type", backup_type)
        if creation_date and not isinstance(creation_date, str):
            raise TypeError("Expected argument 'creation_date' to be a str")
        pulumi.set(__self__, "creation_date", creation_date)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if label and not isinstance(label, str):
            raise TypeError("Expected argument 'label' to be a str")
        pulumi.set(__self__, "label", label)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if size and not isinstance(size, float):
            raise TypeError("Expected argument 'size' to be a float")
        pulumi.set(__self__, "size", size)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="backupId")
    def backup_id(self) -> str:
        """
        UUID v4 used to identify the Backup
        """
        return pulumi.get(self, "backup_id")

    @property
    @pulumi.getter(name="backupType")
    def backup_type(self) -> str:
        """
        Type of backup adhoc or scheduled
        """
        return pulumi.get(self, "backup_type")

    @property
    @pulumi.getter(name="creationDate")
    def creation_date(self) -> str:
        """
        The creation date of the backup
        """
        return pulumi.get(self, "creation_date")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Resource Id
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def label(self) -> Optional[str]:
        """
        Label for backup
        """
        return pulumi.get(self, "label")

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
    @pulumi.getter
    def size(self) -> float:
        """
        Size of backup
        """
        return pulumi.get(self, "size")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Resource type
        """
        return pulumi.get(self, "type")


class AwaitableGetBackupResult(GetBackupResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetBackupResult(
            backup_id=self.backup_id,
            backup_type=self.backup_type,
            creation_date=self.creation_date,
            id=self.id,
            label=self.label,
            location=self.location,
            name=self.name,
            provisioning_state=self.provisioning_state,
            size=self.size,
            type=self.type)


def get_backup(account_name: Optional[str] = None,
               backup_name: Optional[str] = None,
               pool_name: Optional[str] = None,
               resource_group_name: Optional[str] = None,
               volume_name: Optional[str] = None,
               opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetBackupResult:
    """
    Use this data source to access information about an existing resource.

    :param str account_name: The name of the NetApp account
    :param str backup_name: The name of the backup
    :param str pool_name: The name of the capacity pool
    :param str resource_group_name: The name of the resource group.
    :param str volume_name: The name of the volume
    """
    __args__ = dict()
    __args__['accountName'] = account_name
    __args__['backupName'] = backup_name
    __args__['poolName'] = pool_name
    __args__['resourceGroupName'] = resource_group_name
    __args__['volumeName'] = volume_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:netapp/v20200701:getBackup', __args__, opts=opts, typ=GetBackupResult).value

    return AwaitableGetBackupResult(
        backup_id=__ret__.backup_id,
        backup_type=__ret__.backup_type,
        creation_date=__ret__.creation_date,
        id=__ret__.id,
        label=__ret__.label,
        location=__ret__.location,
        name=__ret__.name,
        provisioning_state=__ret__.provisioning_state,
        size=__ret__.size,
        type=__ret__.type)
