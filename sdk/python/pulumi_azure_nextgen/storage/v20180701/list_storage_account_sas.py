# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from ._enums import *

__all__ = [
    'ListStorageAccountSASResult',
    'AwaitableListStorageAccountSASResult',
    'list_storage_account_sas',
]

@pulumi.output_type
class ListStorageAccountSASResult:
    """
    The List SAS credentials operation response.
    """
    def __init__(__self__, account_sas_token=None):
        if account_sas_token and not isinstance(account_sas_token, str):
            raise TypeError("Expected argument 'account_sas_token' to be a str")
        pulumi.set(__self__, "account_sas_token", account_sas_token)

    @property
    @pulumi.getter(name="accountSasToken")
    def account_sas_token(self) -> str:
        """
        List SAS credentials of storage account.
        """
        return pulumi.get(self, "account_sas_token")


class AwaitableListStorageAccountSASResult(ListStorageAccountSASResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return ListStorageAccountSASResult(
            account_sas_token=self.account_sas_token)


def list_storage_account_sas(account_name: Optional[str] = None,
                             i_p_address_or_range: Optional[str] = None,
                             key_to_sign: Optional[str] = None,
                             permissions: Optional[Union[str, 'Permissions']] = None,
                             protocols: Optional['HttpProtocol'] = None,
                             resource_group_name: Optional[str] = None,
                             resource_types: Optional[Union[str, 'SignedResourceTypes']] = None,
                             services: Optional[Union[str, 'Services']] = None,
                             shared_access_expiry_time: Optional[str] = None,
                             shared_access_start_time: Optional[str] = None,
                             opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableListStorageAccountSASResult:
    """
    Use this data source to access information about an existing resource.

    :param str account_name: The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
    :param str i_p_address_or_range: An IP address or a range of IP addresses from which to accept requests.
    :param str key_to_sign: The key to sign the account SAS token with.
    :param Union[str, 'Permissions'] permissions: The signed permissions for the account SAS. Possible values include: Read (r), Write (w), Delete (d), List (l), Add (a), Create (c), Update (u) and Process (p).
    :param 'HttpProtocol' protocols: The protocol permitted for a request made with the account SAS.
    :param str resource_group_name: The name of the resource group within the user's subscription. The name is case insensitive.
    :param Union[str, 'SignedResourceTypes'] resource_types: The signed resource types that are accessible with the account SAS. Service (s): Access to service-level APIs; Container (c): Access to container-level APIs; Object (o): Access to object-level APIs for blobs, queue messages, table entities, and files.
    :param Union[str, 'Services'] services: The signed services accessible with the account SAS. Possible values include: Blob (b), Queue (q), Table (t), File (f).
    :param str shared_access_expiry_time: The time at which the shared access signature becomes invalid.
    :param str shared_access_start_time: The time at which the SAS becomes valid.
    """
    __args__ = dict()
    __args__['accountName'] = account_name
    __args__['iPAddressOrRange'] = i_p_address_or_range
    __args__['keyToSign'] = key_to_sign
    __args__['permissions'] = permissions
    __args__['protocols'] = protocols
    __args__['resourceGroupName'] = resource_group_name
    __args__['resourceTypes'] = resource_types
    __args__['services'] = services
    __args__['sharedAccessExpiryTime'] = shared_access_expiry_time
    __args__['sharedAccessStartTime'] = shared_access_start_time
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:storage/v20180701:listStorageAccountSAS', __args__, opts=opts, typ=ListStorageAccountSASResult).value

    return AwaitableListStorageAccountSASResult(
        account_sas_token=__ret__.account_sas_token)
