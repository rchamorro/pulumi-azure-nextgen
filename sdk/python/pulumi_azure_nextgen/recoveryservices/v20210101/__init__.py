# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

# Export this package's modules as members:
from ._enums import *
from .get_private_endpoint_connection import *
from .get_protected_item import *
from .get_protection_container import *
from .get_protection_policy import *
from .private_endpoint_connection import *
from .protected_item import *
from .protection_container import *
from .protection_policy import *
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
            if typ == "azure-nextgen:recoveryservices/v20210101:PrivateEndpointConnection":
                return PrivateEndpointConnection(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:recoveryservices/v20210101:ProtectedItem":
                return ProtectedItem(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:recoveryservices/v20210101:ProtectionContainer":
                return ProtectionContainer(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:recoveryservices/v20210101:ProtectionPolicy":
                return ProtectionPolicy(name, pulumi.ResourceOptions(urn=urn))
            else:
                raise Exception(f"unknown resource type {typ}")


    _module_instance = Module()
    pulumi.runtime.register_resource_module("azure-nextgen", "recoveryservices/v20210101", _module_instance)

_register_module()
