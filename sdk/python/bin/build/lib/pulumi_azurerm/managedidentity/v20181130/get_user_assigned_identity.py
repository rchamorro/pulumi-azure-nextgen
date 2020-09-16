# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from ... import _utilities, _tables

__all__ = [
    'GetUserAssignedIdentityResult',
    'AwaitableGetUserAssignedIdentityResult',
    'get_user_assigned_identity',
]

@pulumi.output_type
class GetUserAssignedIdentityResult:
    """
    Describes an identity resource.
    """
    def __init__(__self__, client_id=None, location=None, name=None, principal_id=None, tags=None, tenant_id=None, type=None):
        if client_id and not isinstance(client_id, str):
            raise TypeError("Expected argument 'client_id' to be a str")
        pulumi.set(__self__, "client_id", client_id)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if principal_id and not isinstance(principal_id, str):
            raise TypeError("Expected argument 'principal_id' to be a str")
        pulumi.set(__self__, "principal_id", principal_id)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if tenant_id and not isinstance(tenant_id, str):
            raise TypeError("Expected argument 'tenant_id' to be a str")
        pulumi.set(__self__, "tenant_id", tenant_id)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="clientId")
    def client_id(self) -> str:
        """
        The id of the app associated with the identity. This is a random generated UUID by MSI.
        """
        return pulumi.get(self, "client_id")

    @property
    @pulumi.getter
    def location(self) -> str:
        """
        The geo-location where the resource lives
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="principalId")
    def principal_id(self) -> str:
        """
        The id of the service principal object associated with the created identity.
        """
        return pulumi.get(self, "principal_id")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        Resource tags.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="tenantId")
    def tenant_id(self) -> str:
        """
        The id of the tenant which the identity belongs to.
        """
        return pulumi.get(self, "tenant_id")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
        """
        return pulumi.get(self, "type")


class AwaitableGetUserAssignedIdentityResult(GetUserAssignedIdentityResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetUserAssignedIdentityResult(
            client_id=self.client_id,
            location=self.location,
            name=self.name,
            principal_id=self.principal_id,
            tags=self.tags,
            tenant_id=self.tenant_id,
            type=self.type)


def get_user_assigned_identity(resource_group_name: Optional[str] = None,
                               resource_name: Optional[str] = None,
                               opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetUserAssignedIdentityResult:
    """
    Use this data source to access information about an existing resource.

    :param str resource_group_name: The name of the Resource Group to which the identity belongs.
    :param str resource_name: The name of the identity resource.
    """
    __args__ = dict()
    __args__['resourceGroupName'] = resource_group_name
    __args__['resourceName'] = resource_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azurerm:managedidentity/v20181130:getUserAssignedIdentity', __args__, opts=opts, typ=GetUserAssignedIdentityResult).value

    return AwaitableGetUserAssignedIdentityResult(
        client_id=__ret__.client_id,
        location=__ret__.location,
        name=__ret__.name,
        principal_id=__ret__.principal_id,
        tags=__ret__.tags,
        tenant_id=__ret__.tenant_id,
        type=__ret__.type)