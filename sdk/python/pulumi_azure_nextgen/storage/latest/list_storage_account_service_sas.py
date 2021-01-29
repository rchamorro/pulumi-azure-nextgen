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
    'ListStorageAccountServiceSASResult',
    'AwaitableListStorageAccountServiceSASResult',
    'list_storage_account_service_sas',
]

@pulumi.output_type
class ListStorageAccountServiceSASResult:
    """
    The List service SAS credentials operation response.
    """
    def __init__(__self__, service_sas_token=None):
        if service_sas_token and not isinstance(service_sas_token, str):
            raise TypeError("Expected argument 'service_sas_token' to be a str")
        pulumi.set(__self__, "service_sas_token", service_sas_token)

    @property
    @pulumi.getter(name="serviceSasToken")
    def service_sas_token(self) -> str:
        """
        List service SAS credentials of specific resource.
        """
        return pulumi.get(self, "service_sas_token")


class AwaitableListStorageAccountServiceSASResult(ListStorageAccountServiceSASResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return ListStorageAccountServiceSASResult(
            service_sas_token=self.service_sas_token)


def list_storage_account_service_sas(account_name: Optional[str] = None,
                                     cache_control: Optional[str] = None,
                                     canonicalized_resource: Optional[str] = None,
                                     content_disposition: Optional[str] = None,
                                     content_encoding: Optional[str] = None,
                                     content_language: Optional[str] = None,
                                     content_type: Optional[str] = None,
                                     i_p_address_or_range: Optional[str] = None,
                                     identifier: Optional[str] = None,
                                     key_to_sign: Optional[str] = None,
                                     partition_key_end: Optional[str] = None,
                                     partition_key_start: Optional[str] = None,
                                     permissions: Optional[Union[str, 'Permissions']] = None,
                                     protocols: Optional['HttpProtocol'] = None,
                                     resource: Optional[Union[str, 'SignedResource']] = None,
                                     resource_group_name: Optional[str] = None,
                                     row_key_end: Optional[str] = None,
                                     row_key_start: Optional[str] = None,
                                     shared_access_expiry_time: Optional[str] = None,
                                     shared_access_start_time: Optional[str] = None,
                                     opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableListStorageAccountServiceSASResult:
    """
    Use this data source to access information about an existing resource.

    :param str account_name: The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
    :param str cache_control: The response header override for cache control.
    :param str canonicalized_resource: The canonical path to the signed resource.
    :param str content_disposition: The response header override for content disposition.
    :param str content_encoding: The response header override for content encoding.
    :param str content_language: The response header override for content language.
    :param str content_type: The response header override for content type.
    :param str i_p_address_or_range: An IP address or a range of IP addresses from which to accept requests.
    :param str identifier: A unique value up to 64 characters in length that correlates to an access policy specified for the container, queue, or table.
    :param str key_to_sign: The key to sign the account SAS token with.
    :param str partition_key_end: The end of partition key.
    :param str partition_key_start: The start of partition key.
    :param Union[str, 'Permissions'] permissions: The signed permissions for the service SAS. Possible values include: Read (r), Write (w), Delete (d), List (l), Add (a), Create (c), Update (u) and Process (p).
    :param 'HttpProtocol' protocols: The protocol permitted for a request made with the account SAS.
    :param Union[str, 'SignedResource'] resource: The signed services accessible with the service SAS. Possible values include: Blob (b), Container (c), File (f), Share (s).
    :param str resource_group_name: The name of the resource group within the user's subscription. The name is case insensitive.
    :param str row_key_end: The end of row key.
    :param str row_key_start: The start of row key.
    :param str shared_access_expiry_time: The time at which the shared access signature becomes invalid.
    :param str shared_access_start_time: The time at which the SAS becomes valid.
    """
    __args__ = dict()
    __args__['accountName'] = account_name
    __args__['cacheControl'] = cache_control
    __args__['canonicalizedResource'] = canonicalized_resource
    __args__['contentDisposition'] = content_disposition
    __args__['contentEncoding'] = content_encoding
    __args__['contentLanguage'] = content_language
    __args__['contentType'] = content_type
    __args__['iPAddressOrRange'] = i_p_address_or_range
    __args__['identifier'] = identifier
    __args__['keyToSign'] = key_to_sign
    __args__['partitionKeyEnd'] = partition_key_end
    __args__['partitionKeyStart'] = partition_key_start
    __args__['permissions'] = permissions
    __args__['protocols'] = protocols
    __args__['resource'] = resource
    __args__['resourceGroupName'] = resource_group_name
    __args__['rowKeyEnd'] = row_key_end
    __args__['rowKeyStart'] = row_key_start
    __args__['sharedAccessExpiryTime'] = shared_access_expiry_time
    __args__['sharedAccessStartTime'] = shared_access_start_time
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:storage/latest:listStorageAccountServiceSAS', __args__, opts=opts, typ=ListStorageAccountServiceSASResult).value

    return AwaitableListStorageAccountServiceSASResult(
        service_sas_token=__ret__.service_sas_token)
