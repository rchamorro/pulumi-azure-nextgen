# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from . import outputs
from ._enums import *

__all__ = [
    'CaptureDescriptionResponse',
    'DestinationResponse',
    'NWRuleSetIpRulesResponse',
    'NWRuleSetVirtualNetworkRulesResponse',
    'SkuResponse',
    'SubnetResponse',
]

@pulumi.output_type
class CaptureDescriptionResponse(dict):
    """
    Properties to configure capture description for eventhub
    """
    def __init__(__self__, *,
                 destination: Optional['outputs.DestinationResponse'] = None,
                 enabled: Optional[bool] = None,
                 encoding: Optional[str] = None,
                 interval_in_seconds: Optional[int] = None,
                 size_limit_in_bytes: Optional[int] = None,
                 skip_empty_archives: Optional[bool] = None):
        """
        Properties to configure capture description for eventhub
        :param 'DestinationResponseArgs' destination: Properties of Destination where capture will be stored. (Storage Account, Blob Names)
        :param bool enabled: A value that indicates whether capture description is enabled. 
        :param str encoding: Enumerates the possible values for the encoding format of capture description. Note: 'AvroDeflate' will be deprecated in New API Version
        :param int interval_in_seconds: The time window allows you to set the frequency with which the capture to Azure Blobs will happen, value should between 60 to 900 seconds
        :param int size_limit_in_bytes: The size window defines the amount of data built up in your Event Hub before an capture operation, value should be between 10485760 to 524288000 bytes
        :param bool skip_empty_archives: A value that indicates whether to Skip Empty Archives
        """
        if destination is not None:
            pulumi.set(__self__, "destination", destination)
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if encoding is not None:
            pulumi.set(__self__, "encoding", encoding)
        if interval_in_seconds is not None:
            pulumi.set(__self__, "interval_in_seconds", interval_in_seconds)
        if size_limit_in_bytes is not None:
            pulumi.set(__self__, "size_limit_in_bytes", size_limit_in_bytes)
        if skip_empty_archives is not None:
            pulumi.set(__self__, "skip_empty_archives", skip_empty_archives)

    @property
    @pulumi.getter
    def destination(self) -> Optional['outputs.DestinationResponse']:
        """
        Properties of Destination where capture will be stored. (Storage Account, Blob Names)
        """
        return pulumi.get(self, "destination")

    @property
    @pulumi.getter
    def enabled(self) -> Optional[bool]:
        """
        A value that indicates whether capture description is enabled. 
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter
    def encoding(self) -> Optional[str]:
        """
        Enumerates the possible values for the encoding format of capture description. Note: 'AvroDeflate' will be deprecated in New API Version
        """
        return pulumi.get(self, "encoding")

    @property
    @pulumi.getter(name="intervalInSeconds")
    def interval_in_seconds(self) -> Optional[int]:
        """
        The time window allows you to set the frequency with which the capture to Azure Blobs will happen, value should between 60 to 900 seconds
        """
        return pulumi.get(self, "interval_in_seconds")

    @property
    @pulumi.getter(name="sizeLimitInBytes")
    def size_limit_in_bytes(self) -> Optional[int]:
        """
        The size window defines the amount of data built up in your Event Hub before an capture operation, value should be between 10485760 to 524288000 bytes
        """
        return pulumi.get(self, "size_limit_in_bytes")

    @property
    @pulumi.getter(name="skipEmptyArchives")
    def skip_empty_archives(self) -> Optional[bool]:
        """
        A value that indicates whether to Skip Empty Archives
        """
        return pulumi.get(self, "skip_empty_archives")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class DestinationResponse(dict):
    """
    Capture storage details for capture description
    """
    def __init__(__self__, *,
                 archive_name_format: Optional[str] = None,
                 blob_container: Optional[str] = None,
                 name: Optional[str] = None,
                 storage_account_resource_id: Optional[str] = None):
        """
        Capture storage details for capture description
        :param str archive_name_format: Blob naming convention for archive, e.g. {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}. Here all the parameters (Namespace,EventHub .. etc) are mandatory irrespective of order
        :param str blob_container: Blob container Name
        :param str name: Name for capture destination
        :param str storage_account_resource_id: Resource id of the storage account to be used to create the blobs
        """
        if archive_name_format is not None:
            pulumi.set(__self__, "archive_name_format", archive_name_format)
        if blob_container is not None:
            pulumi.set(__self__, "blob_container", blob_container)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if storage_account_resource_id is not None:
            pulumi.set(__self__, "storage_account_resource_id", storage_account_resource_id)

    @property
    @pulumi.getter(name="archiveNameFormat")
    def archive_name_format(self) -> Optional[str]:
        """
        Blob naming convention for archive, e.g. {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}. Here all the parameters (Namespace,EventHub .. etc) are mandatory irrespective of order
        """
        return pulumi.get(self, "archive_name_format")

    @property
    @pulumi.getter(name="blobContainer")
    def blob_container(self) -> Optional[str]:
        """
        Blob container Name
        """
        return pulumi.get(self, "blob_container")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        Name for capture destination
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="storageAccountResourceId")
    def storage_account_resource_id(self) -> Optional[str]:
        """
        Resource id of the storage account to be used to create the blobs
        """
        return pulumi.get(self, "storage_account_resource_id")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class NWRuleSetIpRulesResponse(dict):
    """
    Description of NetWorkRuleSet - IpRules resource.
    """
    def __init__(__self__, *,
                 action: Optional[str] = None,
                 ip_mask: Optional[str] = None):
        """
        Description of NetWorkRuleSet - IpRules resource.
        :param str action: The IP Filter Action
        :param str ip_mask: IP Mask
        """
        if action is None:
            action = 'Allow'
        if action is not None:
            pulumi.set(__self__, "action", action)
        if ip_mask is not None:
            pulumi.set(__self__, "ip_mask", ip_mask)

    @property
    @pulumi.getter
    def action(self) -> Optional[str]:
        """
        The IP Filter Action
        """
        return pulumi.get(self, "action")

    @property
    @pulumi.getter(name="ipMask")
    def ip_mask(self) -> Optional[str]:
        """
        IP Mask
        """
        return pulumi.get(self, "ip_mask")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class NWRuleSetVirtualNetworkRulesResponse(dict):
    """
    Description of VirtualNetworkRules - NetworkRules resource.
    """
    def __init__(__self__, *,
                 ignore_missing_vnet_service_endpoint: Optional[bool] = None,
                 subnet: Optional['outputs.SubnetResponse'] = None):
        """
        Description of VirtualNetworkRules - NetworkRules resource.
        :param bool ignore_missing_vnet_service_endpoint: Value that indicates whether to ignore missing VNet Service Endpoint
        :param 'SubnetResponseArgs' subnet: Subnet properties
        """
        if ignore_missing_vnet_service_endpoint is not None:
            pulumi.set(__self__, "ignore_missing_vnet_service_endpoint", ignore_missing_vnet_service_endpoint)
        if subnet is not None:
            pulumi.set(__self__, "subnet", subnet)

    @property
    @pulumi.getter(name="ignoreMissingVnetServiceEndpoint")
    def ignore_missing_vnet_service_endpoint(self) -> Optional[bool]:
        """
        Value that indicates whether to ignore missing VNet Service Endpoint
        """
        return pulumi.get(self, "ignore_missing_vnet_service_endpoint")

    @property
    @pulumi.getter
    def subnet(self) -> Optional['outputs.SubnetResponse']:
        """
        Subnet properties
        """
        return pulumi.get(self, "subnet")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class SkuResponse(dict):
    """
    SKU parameters supplied to the create namespace operation
    """
    def __init__(__self__, *,
                 name: str,
                 capacity: Optional[int] = None,
                 tier: Optional[str] = None):
        """
        SKU parameters supplied to the create namespace operation
        :param str name: Name of this SKU.
        :param int capacity: The Event Hubs throughput units, value should be 0 to 20 throughput units.
        :param str tier: The billing tier of this particular SKU.
        """
        pulumi.set(__self__, "name", name)
        if capacity is not None:
            pulumi.set(__self__, "capacity", capacity)
        if tier is not None:
            pulumi.set(__self__, "tier", tier)

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Name of this SKU.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def capacity(self) -> Optional[int]:
        """
        The Event Hubs throughput units, value should be 0 to 20 throughput units.
        """
        return pulumi.get(self, "capacity")

    @property
    @pulumi.getter
    def tier(self) -> Optional[str]:
        """
        The billing tier of this particular SKU.
        """
        return pulumi.get(self, "tier")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class SubnetResponse(dict):
    """
    Properties supplied for Subnet
    """
    def __init__(__self__, *,
                 id: str):
        """
        Properties supplied for Subnet
        :param str id: Resource ID of Virtual Network Subnet
        """
        pulumi.set(__self__, "id", id)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Resource ID of Virtual Network Subnet
        """
        return pulumi.get(self, "id")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


