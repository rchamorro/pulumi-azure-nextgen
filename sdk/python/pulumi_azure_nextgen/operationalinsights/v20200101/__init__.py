# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

# Export this package's modules as members:
from ._enums import *
from .action import *
from .alert_rule import *
from .bookmark import *
from .data_connector import *
from .get_action import *
from .get_alert_rule import *
from .get_bookmark import *
from .get_data_connector import *
from .get_incident import *
from .incident import *
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
            if typ == "azure-nextgen:operationalinsights/v20200101:Action":
                return Action(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:operationalinsights/v20200101:AlertRule":
                return AlertRule(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:operationalinsights/v20200101:Bookmark":
                return Bookmark(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:operationalinsights/v20200101:DataConnector":
                return DataConnector(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:operationalinsights/v20200101:Incident":
                return Incident(name, pulumi.ResourceOptions(urn=urn))
            else:
                raise Exception(f"unknown resource type {typ}")


    _module_instance = Module()
    pulumi.runtime.register_resource_module("azure-nextgen", "operationalinsights/v20200101", _module_instance)

_register_module()
