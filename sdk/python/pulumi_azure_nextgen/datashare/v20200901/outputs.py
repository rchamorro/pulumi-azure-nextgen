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
    'DefaultDtoResponseSystemData',
    'IdentityResponse',
    'ProxyDtoResponseSystemData',
    'ScheduledSourceSynchronizationSettingResponseResult',
    'ShareSubscriptionSynchronizationResponseResult',
    'ShareSynchronizationResponseResult',
    'SynchronizationDetailsResponseResult',
]

@pulumi.output_type
class DefaultDtoResponseSystemData(dict):
    """
    System Data of the Azure resource.
    """
    def __init__(__self__, *,
                 created_at: Optional[str] = None,
                 created_by: Optional[str] = None,
                 created_by_type: Optional[str] = None,
                 last_modified_at: Optional[str] = None,
                 last_modified_by: Optional[str] = None,
                 last_modified_by_type: Optional[str] = None):
        """
        System Data of the Azure resource.
        :param str created_at: The timestamp of resource creation (UTC).
        :param str created_by: The identity that created the resource.
        :param str created_by_type: The type of identity that created the resource.
        :param str last_modified_at: The type of identity that last modified the resource.
        :param str last_modified_by: The identity that last modified the resource.
        :param str last_modified_by_type: The type of identity that last modified the resource.
        """
        if created_at is not None:
            pulumi.set(__self__, "created_at", created_at)
        if created_by is not None:
            pulumi.set(__self__, "created_by", created_by)
        if created_by_type is not None:
            pulumi.set(__self__, "created_by_type", created_by_type)
        if last_modified_at is not None:
            pulumi.set(__self__, "last_modified_at", last_modified_at)
        if last_modified_by is not None:
            pulumi.set(__self__, "last_modified_by", last_modified_by)
        if last_modified_by_type is not None:
            pulumi.set(__self__, "last_modified_by_type", last_modified_by_type)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> Optional[str]:
        """
        The timestamp of resource creation (UTC).
        """
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter(name="createdBy")
    def created_by(self) -> Optional[str]:
        """
        The identity that created the resource.
        """
        return pulumi.get(self, "created_by")

    @property
    @pulumi.getter(name="createdByType")
    def created_by_type(self) -> Optional[str]:
        """
        The type of identity that created the resource.
        """
        return pulumi.get(self, "created_by_type")

    @property
    @pulumi.getter(name="lastModifiedAt")
    def last_modified_at(self) -> Optional[str]:
        """
        The type of identity that last modified the resource.
        """
        return pulumi.get(self, "last_modified_at")

    @property
    @pulumi.getter(name="lastModifiedBy")
    def last_modified_by(self) -> Optional[str]:
        """
        The identity that last modified the resource.
        """
        return pulumi.get(self, "last_modified_by")

    @property
    @pulumi.getter(name="lastModifiedByType")
    def last_modified_by_type(self) -> Optional[str]:
        """
        The type of identity that last modified the resource.
        """
        return pulumi.get(self, "last_modified_by_type")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class IdentityResponse(dict):
    """
    Identity of resource
    """
    def __init__(__self__, *,
                 principal_id: str,
                 tenant_id: str,
                 type: Optional[str] = None):
        """
        Identity of resource
        :param str principal_id: service principal Id
        :param str tenant_id: Tenant Id
        :param str type: Identity Type
        """
        pulumi.set(__self__, "principal_id", principal_id)
        pulumi.set(__self__, "tenant_id", tenant_id)
        if type is not None:
            pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="principalId")
    def principal_id(self) -> str:
        """
        service principal Id
        """
        return pulumi.get(self, "principal_id")

    @property
    @pulumi.getter(name="tenantId")
    def tenant_id(self) -> str:
        """
        Tenant Id
        """
        return pulumi.get(self, "tenant_id")

    @property
    @pulumi.getter
    def type(self) -> Optional[str]:
        """
        Identity Type
        """
        return pulumi.get(self, "type")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ProxyDtoResponseSystemData(dict):
    """
    System Data of the Azure resource.
    """
    def __init__(__self__, *,
                 created_at: Optional[str] = None,
                 created_by: Optional[str] = None,
                 created_by_type: Optional[str] = None,
                 last_modified_at: Optional[str] = None,
                 last_modified_by: Optional[str] = None,
                 last_modified_by_type: Optional[str] = None):
        """
        System Data of the Azure resource.
        :param str created_at: The timestamp of resource creation (UTC).
        :param str created_by: The identity that created the resource.
        :param str created_by_type: The type of identity that created the resource.
        :param str last_modified_at: The type of identity that last modified the resource.
        :param str last_modified_by: The identity that last modified the resource.
        :param str last_modified_by_type: The type of identity that last modified the resource.
        """
        if created_at is not None:
            pulumi.set(__self__, "created_at", created_at)
        if created_by is not None:
            pulumi.set(__self__, "created_by", created_by)
        if created_by_type is not None:
            pulumi.set(__self__, "created_by_type", created_by_type)
        if last_modified_at is not None:
            pulumi.set(__self__, "last_modified_at", last_modified_at)
        if last_modified_by is not None:
            pulumi.set(__self__, "last_modified_by", last_modified_by)
        if last_modified_by_type is not None:
            pulumi.set(__self__, "last_modified_by_type", last_modified_by_type)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> Optional[str]:
        """
        The timestamp of resource creation (UTC).
        """
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter(name="createdBy")
    def created_by(self) -> Optional[str]:
        """
        The identity that created the resource.
        """
        return pulumi.get(self, "created_by")

    @property
    @pulumi.getter(name="createdByType")
    def created_by_type(self) -> Optional[str]:
        """
        The type of identity that created the resource.
        """
        return pulumi.get(self, "created_by_type")

    @property
    @pulumi.getter(name="lastModifiedAt")
    def last_modified_at(self) -> Optional[str]:
        """
        The type of identity that last modified the resource.
        """
        return pulumi.get(self, "last_modified_at")

    @property
    @pulumi.getter(name="lastModifiedBy")
    def last_modified_by(self) -> Optional[str]:
        """
        The identity that last modified the resource.
        """
        return pulumi.get(self, "last_modified_by")

    @property
    @pulumi.getter(name="lastModifiedByType")
    def last_modified_by_type(self) -> Optional[str]:
        """
        The type of identity that last modified the resource.
        """
        return pulumi.get(self, "last_modified_by_type")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ScheduledSourceSynchronizationSettingResponseResult(dict):
    """
    A type of synchronization setting based on schedule
    """
    def __init__(__self__, *,
                 kind: str,
                 recurrence_interval: Optional[str] = None,
                 synchronization_time: Optional[str] = None):
        """
        A type of synchronization setting based on schedule
        :param str kind: Kind of synchronization
               Expected value is 'ScheduleBased'.
        :param str recurrence_interval: Recurrence Interval
        :param str synchronization_time: Synchronization time
        """
        pulumi.set(__self__, "kind", 'ScheduleBased')
        if recurrence_interval is not None:
            pulumi.set(__self__, "recurrence_interval", recurrence_interval)
        if synchronization_time is not None:
            pulumi.set(__self__, "synchronization_time", synchronization_time)

    @property
    @pulumi.getter
    def kind(self) -> str:
        """
        Kind of synchronization
        Expected value is 'ScheduleBased'.
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter(name="recurrenceInterval")
    def recurrence_interval(self) -> Optional[str]:
        """
        Recurrence Interval
        """
        return pulumi.get(self, "recurrence_interval")

    @property
    @pulumi.getter(name="synchronizationTime")
    def synchronization_time(self) -> Optional[str]:
        """
        Synchronization time
        """
        return pulumi.get(self, "synchronization_time")


@pulumi.output_type
class ShareSubscriptionSynchronizationResponseResult(dict):
    """
    A ShareSubscriptionSynchronization data transfer object.
    """
    def __init__(__self__, *,
                 duration_ms: int,
                 end_time: str,
                 message: str,
                 start_time: str,
                 status: str,
                 synchronization_id: str,
                 synchronization_mode: str):
        """
        A ShareSubscriptionSynchronization data transfer object.
        :param int duration_ms: Synchronization duration
        :param str end_time: End time of synchronization
        :param str message: message of Synchronization
        :param str start_time: start time of synchronization
        :param str status: Raw Status
        :param str synchronization_id: Synchronization id
        :param str synchronization_mode: Synchronization Mode
        """
        pulumi.set(__self__, "duration_ms", duration_ms)
        pulumi.set(__self__, "end_time", end_time)
        pulumi.set(__self__, "message", message)
        pulumi.set(__self__, "start_time", start_time)
        pulumi.set(__self__, "status", status)
        pulumi.set(__self__, "synchronization_id", synchronization_id)
        pulumi.set(__self__, "synchronization_mode", synchronization_mode)

    @property
    @pulumi.getter(name="durationMs")
    def duration_ms(self) -> int:
        """
        Synchronization duration
        """
        return pulumi.get(self, "duration_ms")

    @property
    @pulumi.getter(name="endTime")
    def end_time(self) -> str:
        """
        End time of synchronization
        """
        return pulumi.get(self, "end_time")

    @property
    @pulumi.getter
    def message(self) -> str:
        """
        message of Synchronization
        """
        return pulumi.get(self, "message")

    @property
    @pulumi.getter(name="startTime")
    def start_time(self) -> str:
        """
        start time of synchronization
        """
        return pulumi.get(self, "start_time")

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        Raw Status
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter(name="synchronizationId")
    def synchronization_id(self) -> str:
        """
        Synchronization id
        """
        return pulumi.get(self, "synchronization_id")

    @property
    @pulumi.getter(name="synchronizationMode")
    def synchronization_mode(self) -> str:
        """
        Synchronization Mode
        """
        return pulumi.get(self, "synchronization_mode")


@pulumi.output_type
class ShareSynchronizationResponseResult(dict):
    """
    A ShareSynchronization data transfer object.
    """
    def __init__(__self__, *,
                 synchronization_mode: str,
                 consumer_email: Optional[str] = None,
                 consumer_name: Optional[str] = None,
                 consumer_tenant_name: Optional[str] = None,
                 duration_ms: Optional[int] = None,
                 end_time: Optional[str] = None,
                 message: Optional[str] = None,
                 start_time: Optional[str] = None,
                 status: Optional[str] = None,
                 synchronization_id: Optional[str] = None):
        """
        A ShareSynchronization data transfer object.
        :param str synchronization_mode: Synchronization mode
        :param str consumer_email: Email of the user who created the synchronization
        :param str consumer_name: Name of the user who created the synchronization
        :param str consumer_tenant_name: Tenant name of the consumer who created the synchronization
        :param int duration_ms: synchronization duration
        :param str end_time: End time of synchronization
        :param str message: message of synchronization
        :param str start_time: start time of synchronization
        :param str status: Raw Status
        :param str synchronization_id: Synchronization id
        """
        pulumi.set(__self__, "synchronization_mode", synchronization_mode)
        if consumer_email is not None:
            pulumi.set(__self__, "consumer_email", consumer_email)
        if consumer_name is not None:
            pulumi.set(__self__, "consumer_name", consumer_name)
        if consumer_tenant_name is not None:
            pulumi.set(__self__, "consumer_tenant_name", consumer_tenant_name)
        if duration_ms is not None:
            pulumi.set(__self__, "duration_ms", duration_ms)
        if end_time is not None:
            pulumi.set(__self__, "end_time", end_time)
        if message is not None:
            pulumi.set(__self__, "message", message)
        if start_time is not None:
            pulumi.set(__self__, "start_time", start_time)
        if status is not None:
            pulumi.set(__self__, "status", status)
        if synchronization_id is not None:
            pulumi.set(__self__, "synchronization_id", synchronization_id)

    @property
    @pulumi.getter(name="synchronizationMode")
    def synchronization_mode(self) -> str:
        """
        Synchronization mode
        """
        return pulumi.get(self, "synchronization_mode")

    @property
    @pulumi.getter(name="consumerEmail")
    def consumer_email(self) -> Optional[str]:
        """
        Email of the user who created the synchronization
        """
        return pulumi.get(self, "consumer_email")

    @property
    @pulumi.getter(name="consumerName")
    def consumer_name(self) -> Optional[str]:
        """
        Name of the user who created the synchronization
        """
        return pulumi.get(self, "consumer_name")

    @property
    @pulumi.getter(name="consumerTenantName")
    def consumer_tenant_name(self) -> Optional[str]:
        """
        Tenant name of the consumer who created the synchronization
        """
        return pulumi.get(self, "consumer_tenant_name")

    @property
    @pulumi.getter(name="durationMs")
    def duration_ms(self) -> Optional[int]:
        """
        synchronization duration
        """
        return pulumi.get(self, "duration_ms")

    @property
    @pulumi.getter(name="endTime")
    def end_time(self) -> Optional[str]:
        """
        End time of synchronization
        """
        return pulumi.get(self, "end_time")

    @property
    @pulumi.getter
    def message(self) -> Optional[str]:
        """
        message of synchronization
        """
        return pulumi.get(self, "message")

    @property
    @pulumi.getter(name="startTime")
    def start_time(self) -> Optional[str]:
        """
        start time of synchronization
        """
        return pulumi.get(self, "start_time")

    @property
    @pulumi.getter
    def status(self) -> Optional[str]:
        """
        Raw Status
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter(name="synchronizationId")
    def synchronization_id(self) -> Optional[str]:
        """
        Synchronization id
        """
        return pulumi.get(self, "synchronization_id")


@pulumi.output_type
class SynchronizationDetailsResponseResult(dict):
    """
    Synchronization details at data set level
    """
    def __init__(__self__, *,
                 data_set_id: str,
                 data_set_type: str,
                 duration_ms: int,
                 end_time: str,
                 files_read: float,
                 files_written: float,
                 message: str,
                 name: str,
                 rows_copied: float,
                 rows_read: float,
                 size_read: float,
                 size_written: float,
                 start_time: str,
                 status: str,
                 v_core: float):
        """
        Synchronization details at data set level
        :param str data_set_id: Id of data set
        :param str data_set_type: Type of the data set
        :param int duration_ms: Duration of data set level copy
        :param str end_time: End time of data set level copy
        :param float files_read: The number of files read from the source data set
        :param float files_written: The number of files written into the sink data set
        :param str message: Error message if any
        :param str name: Name of the data set
        :param float rows_copied: The number of files copied into the sink data set
        :param float rows_read: The number of rows read from the source data set.
        :param float size_read: The size of the data read from the source data set in bytes
        :param float size_written: The size of the data written into the sink data set in bytes
        :param str start_time: Start time of data set level copy
        :param str status: Raw Status
        :param float v_core: The vCore units consumed for the data set synchronization
        """
        pulumi.set(__self__, "data_set_id", data_set_id)
        pulumi.set(__self__, "data_set_type", data_set_type)
        pulumi.set(__self__, "duration_ms", duration_ms)
        pulumi.set(__self__, "end_time", end_time)
        pulumi.set(__self__, "files_read", files_read)
        pulumi.set(__self__, "files_written", files_written)
        pulumi.set(__self__, "message", message)
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "rows_copied", rows_copied)
        pulumi.set(__self__, "rows_read", rows_read)
        pulumi.set(__self__, "size_read", size_read)
        pulumi.set(__self__, "size_written", size_written)
        pulumi.set(__self__, "start_time", start_time)
        pulumi.set(__self__, "status", status)
        pulumi.set(__self__, "v_core", v_core)

    @property
    @pulumi.getter(name="dataSetId")
    def data_set_id(self) -> str:
        """
        Id of data set
        """
        return pulumi.get(self, "data_set_id")

    @property
    @pulumi.getter(name="dataSetType")
    def data_set_type(self) -> str:
        """
        Type of the data set
        """
        return pulumi.get(self, "data_set_type")

    @property
    @pulumi.getter(name="durationMs")
    def duration_ms(self) -> int:
        """
        Duration of data set level copy
        """
        return pulumi.get(self, "duration_ms")

    @property
    @pulumi.getter(name="endTime")
    def end_time(self) -> str:
        """
        End time of data set level copy
        """
        return pulumi.get(self, "end_time")

    @property
    @pulumi.getter(name="filesRead")
    def files_read(self) -> float:
        """
        The number of files read from the source data set
        """
        return pulumi.get(self, "files_read")

    @property
    @pulumi.getter(name="filesWritten")
    def files_written(self) -> float:
        """
        The number of files written into the sink data set
        """
        return pulumi.get(self, "files_written")

    @property
    @pulumi.getter
    def message(self) -> str:
        """
        Error message if any
        """
        return pulumi.get(self, "message")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Name of the data set
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="rowsCopied")
    def rows_copied(self) -> float:
        """
        The number of files copied into the sink data set
        """
        return pulumi.get(self, "rows_copied")

    @property
    @pulumi.getter(name="rowsRead")
    def rows_read(self) -> float:
        """
        The number of rows read from the source data set.
        """
        return pulumi.get(self, "rows_read")

    @property
    @pulumi.getter(name="sizeRead")
    def size_read(self) -> float:
        """
        The size of the data read from the source data set in bytes
        """
        return pulumi.get(self, "size_read")

    @property
    @pulumi.getter(name="sizeWritten")
    def size_written(self) -> float:
        """
        The size of the data written into the sink data set in bytes
        """
        return pulumi.get(self, "size_written")

    @property
    @pulumi.getter(name="startTime")
    def start_time(self) -> str:
        """
        Start time of data set level copy
        """
        return pulumi.get(self, "start_time")

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        Raw Status
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter(name="vCore")
    def v_core(self) -> float:
        """
        The vCore units consumed for the data set synchronization
        """
        return pulumi.get(self, "v_core")


