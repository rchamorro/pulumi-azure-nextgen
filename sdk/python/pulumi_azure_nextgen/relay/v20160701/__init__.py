# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

# Export this package's modules as members:
from ._enums import *
from .get_hybrid_connection import *
from .get_hybrid_connection_authorization_rule import *
from .get_namespace import *
from .get_namespace_authorization_rule import *
from .get_wcf_relay import *
from .get_wcf_relay_authorization_rule import *
from .hybrid_connection import *
from .hybrid_connection_authorization_rule import *
from .list_hybrid_connection_keys import *
from .list_namespace_keys import *
from .list_wcf_relay_keys import *
from .namespace import *
from .namespace_authorization_rule import *
from .wcf_relay import *
from .wcf_relay_authorization_rule import *
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
            if typ == "azure-nextgen:relay/v20160701:HybridConnection":
                return HybridConnection(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:relay/v20160701:HybridConnectionAuthorizationRule":
                return HybridConnectionAuthorizationRule(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:relay/v20160701:Namespace":
                return Namespace(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:relay/v20160701:NamespaceAuthorizationRule":
                return NamespaceAuthorizationRule(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:relay/v20160701:WCFRelay":
                return WCFRelay(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:relay/v20160701:WCFRelayAuthorizationRule":
                return WCFRelayAuthorizationRule(name, pulumi.ResourceOptions(urn=urn))
            else:
                raise Exception(f"unknown resource type {typ}")


    _module_instance = Module()
    pulumi.runtime.register_resource_module("azure-nextgen", "relay/v20160701", _module_instance)

_register_module()
