# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

# Export this package's modules as members:
from ._enums import *
from .blob_container import *
from .blob_container_immutability_policy import *
from .blob_service_properties import *
from .file_service_properties import *
from .file_share import *
from .get_blob_container import *
from .get_blob_container_immutability_policy import *
from .get_blob_service_properties import *
from .get_file_service_properties import *
from .get_file_share import *
from .get_management_policy import *
from .get_object_replication_policy import *
from .get_private_endpoint_connection import *
from .get_queue import *
from .get_queue_service_properties import *
from .get_storage_account import *
from .get_table import *
from .get_table_service_properties import *
from .list_storage_account_keys import *
from .list_storage_account_sas import *
from .list_storage_account_service_sas import *
from .management_policy import *
from .object_replication_policy import *
from .private_endpoint_connection import *
from .queue import *
from .queue_service_properties import *
from .storage_account import *
from .table import *
from .table_service_properties import *
from ._inputs import *
from . import outputs

def _register_module():
    import pulumi
    from ... import _utilities


    class Module(pulumi.runtime.ResourceModule):
        _version = _utilities.get_semver_version()

        def version(self):
            return Module._version

        def construct(self, name: str, typ: str, urn: str) -> pulumi.Resource:
            if typ == "azure-nextgen:storage/latest:BlobContainer":
                return BlobContainer(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:storage/latest:BlobContainerImmutabilityPolicy":
                return BlobContainerImmutabilityPolicy(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:storage/latest:BlobServiceProperties":
                return BlobServiceProperties(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:storage/latest:FileServiceProperties":
                return FileServiceProperties(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:storage/latest:FileShare":
                return FileShare(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:storage/latest:ManagementPolicy":
                return ManagementPolicy(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:storage/latest:ObjectReplicationPolicy":
                return ObjectReplicationPolicy(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:storage/latest:PrivateEndpointConnection":
                return PrivateEndpointConnection(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:storage/latest:Queue":
                return Queue(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:storage/latest:QueueServiceProperties":
                return QueueServiceProperties(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:storage/latest:StorageAccount":
                return StorageAccount(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:storage/latest:Table":
                return Table(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:storage/latest:TableServiceProperties":
                return TableServiceProperties(name, pulumi.ResourceOptions(urn=urn))
            else:
                raise Exception(f"unknown resource type {typ}")


    _module_instance = Module()
    pulumi.runtime.register_resource_module("azure-nextgen", "storage/latest", _module_instance)

_register_module()
