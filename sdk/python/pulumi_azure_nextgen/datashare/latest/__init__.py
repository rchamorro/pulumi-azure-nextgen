# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

# Export this package's modules as members:
from ._enums import *
from .account import *
from .data_set import *
from .data_set_mapping import *
from .get_account import *
from .get_data_set import *
from .get_data_set_mapping import *
from .get_invitation import *
from .get_share import *
from .get_share_subscription import *
from .get_synchronization_setting import *
from .get_trigger import *
from .invitation import *
from .list_share_subscription_source_share_synchronization_settings import *
from .list_share_subscription_synchronization_details import *
from .list_share_subscription_synchronizations import *
from .list_share_synchronization_details import *
from .list_share_synchronizations import *
from .share import *
from .share_subscription import *
from .synchronization_setting import *
from .trigger import *
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
            if typ == "azure-nextgen:datashare/latest:Account":
                return Account(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:datashare/latest:DataSet":
                return DataSet(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:datashare/latest:DataSetMapping":
                return DataSetMapping(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:datashare/latest:Invitation":
                return Invitation(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:datashare/latest:Share":
                return Share(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:datashare/latest:ShareSubscription":
                return ShareSubscription(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:datashare/latest:SynchronizationSetting":
                return SynchronizationSetting(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:datashare/latest:Trigger":
                return Trigger(name, pulumi.ResourceOptions(urn=urn))
            else:
                raise Exception(f"unknown resource type {typ}")


    _module_instance = Module()
    pulumi.runtime.register_resource_module("azure-nextgen", "datashare/latest", _module_instance)

_register_module()
