# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'GetSqlResourceSqlRoleAssignmentResult',
    'AwaitableGetSqlResourceSqlRoleAssignmentResult',
    'get_sql_resource_sql_role_assignment',
]

@pulumi.output_type
class GetSqlResourceSqlRoleAssignmentResult:
    """
    An Azure Cosmos DB Role Assignment
    """
    def __init__(__self__, name=None, principal_id=None, role_definition_id=None, scope=None, type=None):
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if principal_id and not isinstance(principal_id, str):
            raise TypeError("Expected argument 'principal_id' to be a str")
        pulumi.set(__self__, "principal_id", principal_id)
        if role_definition_id and not isinstance(role_definition_id, str):
            raise TypeError("Expected argument 'role_definition_id' to be a str")
        pulumi.set(__self__, "role_definition_id", role_definition_id)
        if scope and not isinstance(scope, str):
            raise TypeError("Expected argument 'scope' to be a str")
        pulumi.set(__self__, "scope", scope)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the database account.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="principalId")
    def principal_id(self) -> Optional[str]:
        """
        The unique identifier for the associated AAD principal in the AAD graph to which access is being granted through this Role Assignment. Tenant ID for the principal is inferred using the tenant associated with the subscription.
        """
        return pulumi.get(self, "principal_id")

    @property
    @pulumi.getter(name="roleDefinitionId")
    def role_definition_id(self) -> Optional[str]:
        """
        The unique identifier for the associated Role Definition.
        """
        return pulumi.get(self, "role_definition_id")

    @property
    @pulumi.getter
    def scope(self) -> Optional[str]:
        """
        The data plane resource path for which access is being granted through this Role Assignment.
        """
        return pulumi.get(self, "scope")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of Azure resource.
        """
        return pulumi.get(self, "type")


class AwaitableGetSqlResourceSqlRoleAssignmentResult(GetSqlResourceSqlRoleAssignmentResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetSqlResourceSqlRoleAssignmentResult(
            name=self.name,
            principal_id=self.principal_id,
            role_definition_id=self.role_definition_id,
            scope=self.scope,
            type=self.type)


def get_sql_resource_sql_role_assignment(account_name: Optional[str] = None,
                                         resource_group_name: Optional[str] = None,
                                         role_assignment_id: Optional[str] = None,
                                         opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetSqlResourceSqlRoleAssignmentResult:
    """
    Use this data source to access information about an existing resource.

    :param str account_name: Cosmos DB database account name.
    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    :param str role_assignment_id: The GUID for the Role Assignment.
    """
    __args__ = dict()
    __args__['accountName'] = account_name
    __args__['resourceGroupName'] = resource_group_name
    __args__['roleAssignmentId'] = role_assignment_id
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:documentdb/v20200601preview:getSqlResourceSqlRoleAssignment', __args__, opts=opts, typ=GetSqlResourceSqlRoleAssignmentResult).value

    return AwaitableGetSqlResourceSqlRoleAssignmentResult(
        name=__ret__.name,
        principal_id=__ret__.principal_id,
        role_definition_id=__ret__.role_definition_id,
        scope=__ret__.scope,
        type=__ret__.type)