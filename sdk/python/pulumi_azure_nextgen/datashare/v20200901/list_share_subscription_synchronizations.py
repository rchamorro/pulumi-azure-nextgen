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
    'ListShareSubscriptionSynchronizationsResult',
    'AwaitableListShareSubscriptionSynchronizationsResult',
    'list_share_subscription_synchronizations',
]

@pulumi.output_type
class ListShareSubscriptionSynchronizationsResult:
    """
    A consumer side list of share subscription synchronizations
    """
    def __init__(__self__, next_link=None, value=None):
        if next_link and not isinstance(next_link, str):
            raise TypeError("Expected argument 'next_link' to be a str")
        pulumi.set(__self__, "next_link", next_link)
        if value and not isinstance(value, list):
            raise TypeError("Expected argument 'value' to be a list")
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter(name="nextLink")
    def next_link(self) -> Optional[str]:
        """
        The Url of next result page.
        """
        return pulumi.get(self, "next_link")

    @property
    @pulumi.getter
    def value(self) -> Sequence['outputs.ShareSubscriptionSynchronizationResponseResult']:
        """
        Collection of items of type DataTransferObjects.
        """
        return pulumi.get(self, "value")


class AwaitableListShareSubscriptionSynchronizationsResult(ListShareSubscriptionSynchronizationsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return ListShareSubscriptionSynchronizationsResult(
            next_link=self.next_link,
            value=self.value)


def list_share_subscription_synchronizations(account_name: Optional[str] = None,
                                             filter: Optional[str] = None,
                                             orderby: Optional[str] = None,
                                             resource_group_name: Optional[str] = None,
                                             share_subscription_name: Optional[str] = None,
                                             skip_token: Optional[str] = None,
                                             opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableListShareSubscriptionSynchronizationsResult:
    """
    Use this data source to access information about an existing resource.

    :param str account_name: The name of the share account.
    :param str filter: Filters the results using OData syntax.
    :param str orderby: Sorts the results using OData syntax.
    :param str resource_group_name: The resource group name.
    :param str share_subscription_name: The name of the share subscription.
    :param str skip_token: Continuation token
    """
    __args__ = dict()
    __args__['accountName'] = account_name
    __args__['filter'] = filter
    __args__['orderby'] = orderby
    __args__['resourceGroupName'] = resource_group_name
    __args__['shareSubscriptionName'] = share_subscription_name
    __args__['skipToken'] = skip_token
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:datashare/v20200901:listShareSubscriptionSynchronizations', __args__, opts=opts, typ=ListShareSubscriptionSynchronizationsResult).value

    return AwaitableListShareSubscriptionSynchronizationsResult(
        next_link=__ret__.next_link,
        value=__ret__.value)
