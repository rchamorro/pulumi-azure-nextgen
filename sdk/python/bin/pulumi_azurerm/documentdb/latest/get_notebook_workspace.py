# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from ... import _utilities, _tables

__all__ = [
    'GetNotebookWorkspaceResult',
    'AwaitableGetNotebookWorkspaceResult',
    'get_notebook_workspace',
]

@pulumi.output_type
class GetNotebookWorkspaceResult:
    """
    A notebook workspace resource
    """
    def __init__(__self__, name=None, notebook_server_endpoint=None, status=None, type=None):
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if notebook_server_endpoint and not isinstance(notebook_server_endpoint, str):
            raise TypeError("Expected argument 'notebook_server_endpoint' to be a str")
        pulumi.set(__self__, "notebook_server_endpoint", notebook_server_endpoint)
        if status and not isinstance(status, str):
            raise TypeError("Expected argument 'status' to be a str")
        pulumi.set(__self__, "status", status)
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
    @pulumi.getter(name="notebookServerEndpoint")
    def notebook_server_endpoint(self) -> str:
        """
        Specifies the endpoint of Notebook server.
        """
        return pulumi.get(self, "notebook_server_endpoint")

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        Status of the notebook workspace. Possible values are: Creating, Online, Deleting, Failed, Updating.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of Azure resource.
        """
        return pulumi.get(self, "type")


class AwaitableGetNotebookWorkspaceResult(GetNotebookWorkspaceResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetNotebookWorkspaceResult(
            name=self.name,
            notebook_server_endpoint=self.notebook_server_endpoint,
            status=self.status,
            type=self.type)


def get_notebook_workspace(account_name: Optional[str] = None,
                           notebook_workspace_name: Optional[str] = None,
                           resource_group_name: Optional[str] = None,
                           opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetNotebookWorkspaceResult:
    """
    Use this data source to access information about an existing resource.

    :param str account_name: Cosmos DB database account name.
    :param str notebook_workspace_name: The name of the notebook workspace resource.
    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    """
    __args__ = dict()
    __args__['accountName'] = account_name
    __args__['notebookWorkspaceName'] = notebook_workspace_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azurerm:documentdb/latest:getNotebookWorkspace', __args__, opts=opts, typ=GetNotebookWorkspaceResult).value

    return AwaitableGetNotebookWorkspaceResult(
        name=__ret__.name,
        notebook_server_endpoint=__ret__.notebook_server_endpoint,
        status=__ret__.status,
        type=__ret__.type)