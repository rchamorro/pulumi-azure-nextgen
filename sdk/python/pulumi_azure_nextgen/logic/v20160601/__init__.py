# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

# Export this package's modules as members:
from ._enums import *
from .agreement import *
from .certificate import *
from .get_agreement import *
from .get_certificate import *
from .get_integration_account import *
from .get_integration_account_assembly import *
from .get_integration_account_batch_configuration import *
from .get_map import *
from .get_partner import *
from .get_rosetta_net_process_configuration import *
from .get_schema import *
from .get_session import *
from .get_workflow import *
from .integration_account import *
from .integration_account_assembly import *
from .integration_account_batch_configuration import *
from .list_agreement_content_callback_url import *
from .list_integration_account_assembly_content_callback_url import *
from .list_integration_account_callback_url import *
from .list_integration_account_key_vault_keys import *
from .list_map_content_callback_url import *
from .list_partner_content_callback_url import *
from .list_schema_content_callback_url import *
from .list_workflow_callback_url import *
from .list_workflow_run_action_expression_traces import *
from .list_workflow_run_action_repetition_expression_traces import *
from .list_workflow_trigger_callback_url import *
from .list_workflow_version_callback_url import *
from .map import *
from .partner import *
from .rosetta_net_process_configuration import *
from .schema import *
from .session import *
from .workflow import *
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
            if typ == "azure-nextgen:logic/v20160601:Agreement":
                return Agreement(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:logic/v20160601:Certificate":
                return Certificate(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:logic/v20160601:IntegrationAccount":
                return IntegrationAccount(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:logic/v20160601:IntegrationAccountAssembly":
                return IntegrationAccountAssembly(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:logic/v20160601:IntegrationAccountBatchConfiguration":
                return IntegrationAccountBatchConfiguration(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:logic/v20160601:Map":
                return Map(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:logic/v20160601:Partner":
                return Partner(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:logic/v20160601:RosettaNetProcessConfiguration":
                return RosettaNetProcessConfiguration(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:logic/v20160601:Schema":
                return Schema(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:logic/v20160601:Session":
                return Session(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "azure-nextgen:logic/v20160601:Workflow":
                return Workflow(name, pulumi.ResourceOptions(urn=urn))
            else:
                raise Exception(f"unknown resource type {typ}")


    _module_instance = Module()
    pulumi.runtime.register_resource_module("azure-nextgen", "logic/v20160601", _module_instance)

_register_module()
