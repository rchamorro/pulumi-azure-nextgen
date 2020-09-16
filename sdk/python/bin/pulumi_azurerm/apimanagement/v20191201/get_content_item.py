# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from ... import _utilities, _tables

__all__ = [
    'GetContentItemResult',
    'AwaitableGetContentItemResult',
    'get_content_item',
]

@pulumi.output_type
class GetContentItemResult:
    """
    Content type contract details.
    """
    def __init__(__self__, name=None, type=None):
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Resource type for API Management resource.
        """
        return pulumi.get(self, "type")


class AwaitableGetContentItemResult(GetContentItemResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetContentItemResult(
            name=self.name,
            type=self.type)


def get_content_item(content_item_id: Optional[str] = None,
                     content_type_id: Optional[str] = None,
                     resource_group_name: Optional[str] = None,
                     service_name: Optional[str] = None,
                     opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetContentItemResult:
    """
    Use this data source to access information about an existing resource.

    :param str content_item_id: Content item identifier.
    :param str content_type_id: Content type identifier.
    :param str resource_group_name: The name of the resource group.
    :param str service_name: The name of the API Management service.
    """
    __args__ = dict()
    __args__['contentItemId'] = content_item_id
    __args__['contentTypeId'] = content_type_id
    __args__['resourceGroupName'] = resource_group_name
    __args__['serviceName'] = service_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azurerm:apimanagement/v20191201:getContentItem', __args__, opts=opts, typ=GetContentItemResult).value

    return AwaitableGetContentItemResult(
        name=__ret__.name,
        type=__ret__.type)