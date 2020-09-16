# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from ... import _utilities, _tables
from . import outputs
from ._inputs import *

__all__ = ['Snapshot']


class Snapshot(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 creation_data: Optional[pulumi.Input[pulumi.InputType['CreationDataArgs']]] = None,
                 disk_access_id: Optional[pulumi.Input[str]] = None,
                 disk_size_gb: Optional[pulumi.Input[float]] = None,
                 disk_state: Optional[pulumi.Input[str]] = None,
                 encryption: Optional[pulumi.Input[pulumi.InputType['EncryptionArgs']]] = None,
                 encryption_settings_collection: Optional[pulumi.Input[pulumi.InputType['EncryptionSettingsCollectionArgs']]] = None,
                 hyper_v_generation: Optional[pulumi.Input[str]] = None,
                 incremental: Optional[pulumi.Input[bool]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 network_access_policy: Optional[pulumi.Input[str]] = None,
                 os_type: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 sku: Optional[pulumi.Input[pulumi.InputType['SnapshotSkuArgs']]] = None,
                 snapshot_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Snapshot resource.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['CreationDataArgs']] creation_data: Disk source information. CreationData information cannot be changed after the disk has been created.
        :param pulumi.Input[str] disk_access_id: ARM id of the DiskAccess resource for using private endpoints on disks.
        :param pulumi.Input[float] disk_size_gb: If creationData.createOption is Empty, this field is mandatory and it indicates the size of the disk to create. If this field is present for updates or creation with other options, it indicates a resize. Resizes are only allowed if the disk is not attached to a running VM, and can only increase the disk's size.
        :param pulumi.Input[str] disk_state: The state of the snapshot.
        :param pulumi.Input[pulumi.InputType['EncryptionArgs']] encryption: Encryption property can be used to encrypt data at rest with customer managed keys or platform managed keys.
        :param pulumi.Input[pulumi.InputType['EncryptionSettingsCollectionArgs']] encryption_settings_collection: Encryption settings collection used be Azure Disk Encryption, can contain multiple encryption settings per disk or snapshot.
        :param pulumi.Input[str] hyper_v_generation: The hypervisor generation of the Virtual Machine. Applicable to OS disks only.
        :param pulumi.Input[bool] incremental: Whether a snapshot is incremental. Incremental snapshots on the same disk occupy less space than full snapshots and can be diffed.
        :param pulumi.Input[str] location: Resource location
        :param pulumi.Input[str] network_access_policy: Policy for accessing the disk via network.
        :param pulumi.Input[str] os_type: The Operating System type.
        :param pulumi.Input[str] resource_group_name: The name of the resource group.
        :param pulumi.Input[pulumi.InputType['SnapshotSkuArgs']] sku: The snapshots sku name. Can be Standard_LRS, Premium_LRS, or Standard_ZRS.
        :param pulumi.Input[str] snapshot_name: The name of the snapshot that is being created. The name can't be changed after the snapshot is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The max name length is 80 characters.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            if creation_data is None:
                raise TypeError("Missing required property 'creation_data'")
            __props__['creation_data'] = creation_data
            __props__['disk_access_id'] = disk_access_id
            __props__['disk_size_gb'] = disk_size_gb
            __props__['disk_state'] = disk_state
            __props__['encryption'] = encryption
            __props__['encryption_settings_collection'] = encryption_settings_collection
            __props__['hyper_v_generation'] = hyper_v_generation
            __props__['incremental'] = incremental
            if location is None:
                raise TypeError("Missing required property 'location'")
            __props__['location'] = location
            __props__['network_access_policy'] = network_access_policy
            __props__['os_type'] = os_type
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['sku'] = sku
            if snapshot_name is None:
                raise TypeError("Missing required property 'snapshot_name'")
            __props__['snapshot_name'] = snapshot_name
            __props__['tags'] = tags
            __props__['disk_size_bytes'] = None
            __props__['managed_by'] = None
            __props__['name'] = None
            __props__['provisioning_state'] = None
            __props__['time_created'] = None
            __props__['type'] = None
            __props__['unique_id'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azurerm:compute/latest:Snapshot"), pulumi.Alias(type_="azurerm:compute/v20170330:Snapshot"), pulumi.Alias(type_="azurerm:compute/v20180401:Snapshot"), pulumi.Alias(type_="azurerm:compute/v20180601:Snapshot"), pulumi.Alias(type_="azurerm:compute/v20180930:Snapshot"), pulumi.Alias(type_="azurerm:compute/v20190301:Snapshot"), pulumi.Alias(type_="azurerm:compute/v20190701:Snapshot"), pulumi.Alias(type_="azurerm:compute/v20191101:Snapshot"), pulumi.Alias(type_="azurerm:compute/v20200501:Snapshot")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(Snapshot, __self__).__init__(
            'azurerm:compute/v20200630:Snapshot',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Snapshot':
        """
        Get an existing Snapshot resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return Snapshot(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="creationData")
    def creation_data(self) -> pulumi.Output['outputs.CreationDataResponse']:
        """
        Disk source information. CreationData information cannot be changed after the disk has been created.
        """
        return pulumi.get(self, "creation_data")

    @property
    @pulumi.getter(name="diskAccessId")
    def disk_access_id(self) -> pulumi.Output[Optional[str]]:
        """
        ARM id of the DiskAccess resource for using private endpoints on disks.
        """
        return pulumi.get(self, "disk_access_id")

    @property
    @pulumi.getter(name="diskSizeBytes")
    def disk_size_bytes(self) -> pulumi.Output[float]:
        """
        The size of the disk in bytes. This field is read only.
        """
        return pulumi.get(self, "disk_size_bytes")

    @property
    @pulumi.getter(name="diskSizeGB")
    def disk_size_gb(self) -> pulumi.Output[Optional[float]]:
        """
        If creationData.createOption is Empty, this field is mandatory and it indicates the size of the disk to create. If this field is present for updates or creation with other options, it indicates a resize. Resizes are only allowed if the disk is not attached to a running VM, and can only increase the disk's size.
        """
        return pulumi.get(self, "disk_size_gb")

    @property
    @pulumi.getter(name="diskState")
    def disk_state(self) -> pulumi.Output[Optional[str]]:
        """
        The state of the snapshot.
        """
        return pulumi.get(self, "disk_state")

    @property
    @pulumi.getter
    def encryption(self) -> pulumi.Output[Optional['outputs.EncryptionResponse']]:
        """
        Encryption property can be used to encrypt data at rest with customer managed keys or platform managed keys.
        """
        return pulumi.get(self, "encryption")

    @property
    @pulumi.getter(name="encryptionSettingsCollection")
    def encryption_settings_collection(self) -> pulumi.Output[Optional['outputs.EncryptionSettingsCollectionResponse']]:
        """
        Encryption settings collection used be Azure Disk Encryption, can contain multiple encryption settings per disk or snapshot.
        """
        return pulumi.get(self, "encryption_settings_collection")

    @property
    @pulumi.getter(name="hyperVGeneration")
    def hyper_v_generation(self) -> pulumi.Output[Optional[str]]:
        """
        The hypervisor generation of the Virtual Machine. Applicable to OS disks only.
        """
        return pulumi.get(self, "hyper_v_generation")

    @property
    @pulumi.getter
    def incremental(self) -> pulumi.Output[Optional[bool]]:
        """
        Whether a snapshot is incremental. Incremental snapshots on the same disk occupy less space than full snapshots and can be diffed.
        """
        return pulumi.get(self, "incremental")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        Resource location
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="managedBy")
    def managed_by(self) -> pulumi.Output[str]:
        """
        Unused. Always Null.
        """
        return pulumi.get(self, "managed_by")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="networkAccessPolicy")
    def network_access_policy(self) -> pulumi.Output[Optional[str]]:
        """
        Policy for accessing the disk via network.
        """
        return pulumi.get(self, "network_access_policy")

    @property
    @pulumi.getter(name="osType")
    def os_type(self) -> pulumi.Output[Optional[str]]:
        """
        The Operating System type.
        """
        return pulumi.get(self, "os_type")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        The disk provisioning state.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter
    def sku(self) -> pulumi.Output[Optional['outputs.SnapshotSkuResponse']]:
        """
        The snapshots sku name. Can be Standard_LRS, Premium_LRS, or Standard_ZRS.
        """
        return pulumi.get(self, "sku")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Resource tags
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="timeCreated")
    def time_created(self) -> pulumi.Output[str]:
        """
        The time when the snapshot was created.
        """
        return pulumi.get(self, "time_created")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Resource type
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="uniqueId")
    def unique_id(self) -> pulumi.Output[str]:
        """
        Unique Guid identifying the resource.
        """
        return pulumi.get(self, "unique_id")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
