# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

# Export this package's modules as members:
from ._enums import *
from .get_remote_rendering_account import *
from .get_spatial_anchors_account import *
from .list_remote_rendering_account_keys import *
from .list_spatial_anchors_account_keys import *
from .remote_rendering_account import *
from .spatial_anchors_account import *
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
            if typ == "azure-nextgen:mixedreality/v20210101:RemoteRenderingAccount":
                return RemoteRenderingAccount(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:mixedreality/v20210101:SpatialAnchorsAccount":
                return SpatialAnchorsAccount(name, pulumi.ResourceOptions(urn=urn))
            else:
                raise Exception(f"unknown resource type {typ}")


    _module_instance = Module()
    pulumi.runtime.register_resource_module("azure-nextgen", "mixedreality/v20210101", _module_instance)

_register_module()
