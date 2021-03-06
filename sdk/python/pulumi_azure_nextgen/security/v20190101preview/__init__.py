# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

# Export this package's modules as members:
from ._enums import *
from .alerts_suppression_rule import *
from .assessment import *
from .assessments_metadata_subscription import *
from .automation import *
from .get_alerts_suppression_rule import *
from .get_assessment import *
from .get_assessments_metadata_subscription import *
from .get_automation import *
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
            if typ == "azure-nextgen:security/v20190101preview:AlertsSuppressionRule":
                return AlertsSuppressionRule(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:security/v20190101preview:Assessment":
                return Assessment(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:security/v20190101preview:AssessmentsMetadataSubscription":
                return AssessmentsMetadataSubscription(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:security/v20190101preview:Automation":
                return Automation(name, pulumi.ResourceOptions(urn=urn))
            else:
                raise Exception(f"unknown resource type {typ}")


    _module_instance = Module()
    pulumi.runtime.register_resource_module("azure-nextgen", "security/v20190101preview", _module_instance)

_register_module()
