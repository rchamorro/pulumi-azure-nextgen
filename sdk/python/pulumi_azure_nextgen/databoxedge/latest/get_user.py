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
    'GetUserResult',
    'AwaitableGetUserResult',
    'get_user',
]

@pulumi.output_type
class GetUserResult:
    """
    Represents a user who has access to one or more shares on the Data Box Edge/Gateway device.
    """
    def __init__(__self__, encrypted_password=None, id=None, name=None, share_access_rights=None, system_data=None, type=None, user_type=None):
        if encrypted_password and not isinstance(encrypted_password, dict):
            raise TypeError("Expected argument 'encrypted_password' to be a dict")
        pulumi.set(__self__, "encrypted_password", encrypted_password)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if share_access_rights and not isinstance(share_access_rights, list):
            raise TypeError("Expected argument 'share_access_rights' to be a list")
        pulumi.set(__self__, "share_access_rights", share_access_rights)
        if system_data and not isinstance(system_data, dict):
            raise TypeError("Expected argument 'system_data' to be a dict")
        pulumi.set(__self__, "system_data", system_data)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if user_type and not isinstance(user_type, str):
            raise TypeError("Expected argument 'user_type' to be a str")
        pulumi.set(__self__, "user_type", user_type)

    @property
    @pulumi.getter(name="encryptedPassword")
    def encrypted_password(self) -> Optional['outputs.AsymmetricEncryptedSecretResponse']:
        """
        The password details.
        """
        return pulumi.get(self, "encrypted_password")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The path ID that uniquely identifies the object.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The object name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="shareAccessRights")
    def share_access_rights(self) -> Sequence['outputs.ShareAccessRightResponse']:
        """
        List of shares that the user has rights on. This field should not be specified during user creation.
        """
        return pulumi.get(self, "share_access_rights")

    @property
    @pulumi.getter(name="systemData")
    def system_data(self) -> 'outputs.SystemDataResponse':
        """
        User in DataBoxEdge Resource
        """
        return pulumi.get(self, "system_data")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The hierarchical type of the object.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="userType")
    def user_type(self) -> Optional[str]:
        """
        Type of the user.
        """
        return pulumi.get(self, "user_type")


class AwaitableGetUserResult(GetUserResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetUserResult(
            encrypted_password=self.encrypted_password,
            id=self.id,
            name=self.name,
            share_access_rights=self.share_access_rights,
            system_data=self.system_data,
            type=self.type,
            user_type=self.user_type)


def get_user(device_name: Optional[str] = None,
             name: Optional[str] = None,
             resource_group_name: Optional[str] = None,
             opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetUserResult:
    """
    Use this data source to access information about an existing resource.

    :param str device_name: The device name.
    :param str name: The user name.
    :param str resource_group_name: The resource group name.
    """
    __args__ = dict()
    __args__['deviceName'] = device_name
    __args__['name'] = name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:databoxedge/latest:getUser', __args__, opts=opts, typ=GetUserResult).value

    return AwaitableGetUserResult(
        encrypted_password=__ret__.encrypted_password,
        id=__ret__.id,
        name=__ret__.name,
        share_access_rights=__ret__.share_access_rights,
        system_data=__ret__.system_data,
        type=__ret__.type,
        user_type=__ret__.user_type)
