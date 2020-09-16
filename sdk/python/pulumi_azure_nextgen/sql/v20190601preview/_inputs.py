# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'ResourceIdentityArgs',
    'SkuArgs',
    'SyncGroupSchemaArgs',
    'SyncGroupSchemaTableArgs',
    'SyncGroupSchemaTableColumnArgs',
]

@pulumi.input_type
class ResourceIdentityArgs:
    def __init__(__self__, *,
                 type: Optional[pulumi.Input[str]] = None):
        """
        Azure Active Directory identity configuration for a resource.
        :param pulumi.Input[str] type: The identity type. Set this to 'SystemAssigned' in order to automatically create and assign an Azure Active Directory principal for the resource.
        """
        if type is not None:
            pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[str]]:
        """
        The identity type. Set this to 'SystemAssigned' in order to automatically create and assign an Azure Active Directory principal for the resource.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "type", value)


@pulumi.input_type
class SkuArgs:
    def __init__(__self__, *,
                 name: pulumi.Input[str],
                 capacity: Optional[pulumi.Input[int]] = None,
                 family: Optional[pulumi.Input[str]] = None,
                 size: Optional[pulumi.Input[str]] = None,
                 tier: Optional[pulumi.Input[str]] = None):
        """
        An ARM Resource SKU.
        :param pulumi.Input[str] name: The name of the SKU, typically, a letter + Number code, e.g. P3.
        :param pulumi.Input[int] capacity: Capacity of the particular SKU.
        :param pulumi.Input[str] family: If the service has different generations of hardware, for the same SKU, then that can be captured here.
        :param pulumi.Input[str] size: Size of the particular SKU
        :param pulumi.Input[str] tier: The tier or edition of the particular SKU, e.g. Basic, Premium.
        """
        pulumi.set(__self__, "name", name)
        if capacity is not None:
            pulumi.set(__self__, "capacity", capacity)
        if family is not None:
            pulumi.set(__self__, "family", family)
        if size is not None:
            pulumi.set(__self__, "size", size)
        if tier is not None:
            pulumi.set(__self__, "tier", tier)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        """
        The name of the SKU, typically, a letter + Number code, e.g. P3.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def capacity(self) -> Optional[pulumi.Input[int]]:
        """
        Capacity of the particular SKU.
        """
        return pulumi.get(self, "capacity")

    @capacity.setter
    def capacity(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "capacity", value)

    @property
    @pulumi.getter
    def family(self) -> Optional[pulumi.Input[str]]:
        """
        If the service has different generations of hardware, for the same SKU, then that can be captured here.
        """
        return pulumi.get(self, "family")

    @family.setter
    def family(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "family", value)

    @property
    @pulumi.getter
    def size(self) -> Optional[pulumi.Input[str]]:
        """
        Size of the particular SKU
        """
        return pulumi.get(self, "size")

    @size.setter
    def size(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "size", value)

    @property
    @pulumi.getter
    def tier(self) -> Optional[pulumi.Input[str]]:
        """
        The tier or edition of the particular SKU, e.g. Basic, Premium.
        """
        return pulumi.get(self, "tier")

    @tier.setter
    def tier(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "tier", value)


@pulumi.input_type
class SyncGroupSchemaArgs:
    def __init__(__self__, *,
                 master_sync_member_name: Optional[pulumi.Input[str]] = None,
                 tables: Optional[pulumi.Input[Sequence[pulumi.Input['SyncGroupSchemaTableArgs']]]] = None):
        """
        Properties of sync group schema.
        :param pulumi.Input[str] master_sync_member_name: Name of master sync member where the schema is from.
        :param pulumi.Input[Sequence[pulumi.Input['SyncGroupSchemaTableArgs']]] tables: List of tables in sync group schema.
        """
        if master_sync_member_name is not None:
            pulumi.set(__self__, "master_sync_member_name", master_sync_member_name)
        if tables is not None:
            pulumi.set(__self__, "tables", tables)

    @property
    @pulumi.getter(name="masterSyncMemberName")
    def master_sync_member_name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of master sync member where the schema is from.
        """
        return pulumi.get(self, "master_sync_member_name")

    @master_sync_member_name.setter
    def master_sync_member_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "master_sync_member_name", value)

    @property
    @pulumi.getter
    def tables(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['SyncGroupSchemaTableArgs']]]]:
        """
        List of tables in sync group schema.
        """
        return pulumi.get(self, "tables")

    @tables.setter
    def tables(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['SyncGroupSchemaTableArgs']]]]):
        pulumi.set(self, "tables", value)


@pulumi.input_type
class SyncGroupSchemaTableArgs:
    def __init__(__self__, *,
                 columns: Optional[pulumi.Input[Sequence[pulumi.Input['SyncGroupSchemaTableColumnArgs']]]] = None,
                 quoted_name: Optional[pulumi.Input[str]] = None):
        """
        Properties of table in sync group schema.
        :param pulumi.Input[Sequence[pulumi.Input['SyncGroupSchemaTableColumnArgs']]] columns: List of columns in sync group schema.
        :param pulumi.Input[str] quoted_name: Quoted name of sync group schema table.
        """
        if columns is not None:
            pulumi.set(__self__, "columns", columns)
        if quoted_name is not None:
            pulumi.set(__self__, "quoted_name", quoted_name)

    @property
    @pulumi.getter
    def columns(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['SyncGroupSchemaTableColumnArgs']]]]:
        """
        List of columns in sync group schema.
        """
        return pulumi.get(self, "columns")

    @columns.setter
    def columns(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['SyncGroupSchemaTableColumnArgs']]]]):
        pulumi.set(self, "columns", value)

    @property
    @pulumi.getter(name="quotedName")
    def quoted_name(self) -> Optional[pulumi.Input[str]]:
        """
        Quoted name of sync group schema table.
        """
        return pulumi.get(self, "quoted_name")

    @quoted_name.setter
    def quoted_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "quoted_name", value)


@pulumi.input_type
class SyncGroupSchemaTableColumnArgs:
    def __init__(__self__, *,
                 data_size: Optional[pulumi.Input[str]] = None,
                 data_type: Optional[pulumi.Input[str]] = None,
                 quoted_name: Optional[pulumi.Input[str]] = None):
        """
        Properties of column in sync group table.
        :param pulumi.Input[str] data_size: Data size of the column.
        :param pulumi.Input[str] data_type: Data type of the column.
        :param pulumi.Input[str] quoted_name: Quoted name of sync group table column.
        """
        if data_size is not None:
            pulumi.set(__self__, "data_size", data_size)
        if data_type is not None:
            pulumi.set(__self__, "data_type", data_type)
        if quoted_name is not None:
            pulumi.set(__self__, "quoted_name", quoted_name)

    @property
    @pulumi.getter(name="dataSize")
    def data_size(self) -> Optional[pulumi.Input[str]]:
        """
        Data size of the column.
        """
        return pulumi.get(self, "data_size")

    @data_size.setter
    def data_size(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "data_size", value)

    @property
    @pulumi.getter(name="dataType")
    def data_type(self) -> Optional[pulumi.Input[str]]:
        """
        Data type of the column.
        """
        return pulumi.get(self, "data_type")

    @data_type.setter
    def data_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "data_type", value)

    @property
    @pulumi.getter(name="quotedName")
    def quoted_name(self) -> Optional[pulumi.Input[str]]:
        """
        Quoted name of sync group table column.
        """
        return pulumi.get(self, "quoted_name")

    @quoted_name.setter
    def quoted_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "quoted_name", value)

