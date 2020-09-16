# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'ListRunLogSasUrlResult',
    'AwaitableListRunLogSasUrlResult',
    'list_run_log_sas_url',
]

@pulumi.output_type
class ListRunLogSasUrlResult:
    """
    The result of get log link operation.
    """
    def __init__(__self__, log_link=None):
        if log_link and not isinstance(log_link, str):
            raise TypeError("Expected argument 'log_link' to be a str")
        pulumi.set(__self__, "log_link", log_link)

    @property
    @pulumi.getter(name="logLink")
    def log_link(self) -> Optional[str]:
        """
        The link to logs for a run on a azure container registry.
        """
        return pulumi.get(self, "log_link")


class AwaitableListRunLogSasUrlResult(ListRunLogSasUrlResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return ListRunLogSasUrlResult(
            log_link=self.log_link)


def list_run_log_sas_url(registry_name: Optional[str] = None,
                         resource_group_name: Optional[str] = None,
                         run_id: Optional[str] = None,
                         opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableListRunLogSasUrlResult:
    """
    Use this data source to access information about an existing resource.

    :param str registry_name: The name of the container registry.
    :param str resource_group_name: The name of the resource group to which the container registry belongs.
    :param str run_id: The run ID.
    """
    __args__ = dict()
    __args__['registryName'] = registry_name
    __args__['resourceGroupName'] = resource_group_name
    __args__['runId'] = run_id
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:containerregistry/v20190401:listRunLogSasUrl', __args__, opts=opts, typ=ListRunLogSasUrlResult).value

    return AwaitableListRunLogSasUrlResult(
        log_link=__ret__.log_link)