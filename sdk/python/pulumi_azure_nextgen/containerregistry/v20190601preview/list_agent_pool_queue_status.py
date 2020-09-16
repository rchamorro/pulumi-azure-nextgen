# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'ListAgentPoolQueueStatusResult',
    'AwaitableListAgentPoolQueueStatusResult',
    'list_agent_pool_queue_status',
]

@pulumi.output_type
class ListAgentPoolQueueStatusResult:
    """
    The QueueStatus of Agent Pool
    """
    def __init__(__self__, count=None):
        if count and not isinstance(count, int):
            raise TypeError("Expected argument 'count' to be a int")
        pulumi.set(__self__, "count", count)

    @property
    @pulumi.getter
    def count(self) -> Optional[int]:
        """
        The number of pending runs in the queue
        """
        return pulumi.get(self, "count")


class AwaitableListAgentPoolQueueStatusResult(ListAgentPoolQueueStatusResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return ListAgentPoolQueueStatusResult(
            count=self.count)


def list_agent_pool_queue_status(agent_pool_name: Optional[str] = None,
                                 registry_name: Optional[str] = None,
                                 resource_group_name: Optional[str] = None,
                                 opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableListAgentPoolQueueStatusResult:
    """
    Use this data source to access information about an existing resource.

    :param str agent_pool_name: The name of the agent pool.
    :param str registry_name: The name of the container registry.
    :param str resource_group_name: The name of the resource group to which the container registry belongs.
    """
    __args__ = dict()
    __args__['agentPoolName'] = agent_pool_name
    __args__['registryName'] = registry_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:containerregistry/v20190601preview:listAgentPoolQueueStatus', __args__, opts=opts, typ=ListAgentPoolQueueStatusResult).value

    return AwaitableListAgentPoolQueueStatusResult(
        count=__ret__.count)