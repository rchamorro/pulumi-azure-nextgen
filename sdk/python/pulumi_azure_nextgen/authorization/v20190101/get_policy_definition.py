# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'GetPolicyDefinitionResult',
    'AwaitableGetPolicyDefinitionResult',
    'get_policy_definition',
]

@pulumi.output_type
class GetPolicyDefinitionResult:
    """
    The policy definition.
    """
    def __init__(__self__, description=None, display_name=None, metadata=None, mode=None, name=None, parameters=None, policy_rule=None, policy_type=None, type=None):
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if display_name and not isinstance(display_name, str):
            raise TypeError("Expected argument 'display_name' to be a str")
        pulumi.set(__self__, "display_name", display_name)
        if metadata and not isinstance(metadata, dict):
            raise TypeError("Expected argument 'metadata' to be a dict")
        pulumi.set(__self__, "metadata", metadata)
        if mode and not isinstance(mode, str):
            raise TypeError("Expected argument 'mode' to be a str")
        pulumi.set(__self__, "mode", mode)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if parameters and not isinstance(parameters, dict):
            raise TypeError("Expected argument 'parameters' to be a dict")
        pulumi.set(__self__, "parameters", parameters)
        if policy_rule and not isinstance(policy_rule, dict):
            raise TypeError("Expected argument 'policy_rule' to be a dict")
        pulumi.set(__self__, "policy_rule", policy_rule)
        if policy_type and not isinstance(policy_type, str):
            raise TypeError("Expected argument 'policy_type' to be a str")
        pulumi.set(__self__, "policy_type", policy_type)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def description(self) -> Optional[str]:
        """
        The policy definition description.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> Optional[str]:
        """
        The display name of the policy definition.
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter
    def metadata(self) -> Optional[Any]:
        """
        The policy definition metadata.
        """
        return pulumi.get(self, "metadata")

    @property
    @pulumi.getter
    def mode(self) -> Optional[str]:
        """
        The policy definition mode. Some examples are All, Indexed, Microsoft.KeyVault.Data.
        """
        return pulumi.get(self, "mode")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the policy definition.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def parameters(self) -> Optional[Any]:
        """
        Required if a parameter is used in policy rule.
        """
        return pulumi.get(self, "parameters")

    @property
    @pulumi.getter(name="policyRule")
    def policy_rule(self) -> Optional[Any]:
        """
        The policy rule.
        """
        return pulumi.get(self, "policy_rule")

    @property
    @pulumi.getter(name="policyType")
    def policy_type(self) -> Optional[str]:
        """
        The type of policy definition. Possible values are NotSpecified, BuiltIn, and Custom.
        """
        return pulumi.get(self, "policy_type")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of the resource (Microsoft.Authorization/policyDefinitions).
        """
        return pulumi.get(self, "type")


class AwaitableGetPolicyDefinitionResult(GetPolicyDefinitionResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetPolicyDefinitionResult(
            description=self.description,
            display_name=self.display_name,
            metadata=self.metadata,
            mode=self.mode,
            name=self.name,
            parameters=self.parameters,
            policy_rule=self.policy_rule,
            policy_type=self.policy_type,
            type=self.type)


def get_policy_definition(policy_definition_name: Optional[str] = None,
                          opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetPolicyDefinitionResult:
    """
    Use this data source to access information about an existing resource.

    :param str policy_definition_name: The name of the policy definition to get.
    """
    __args__ = dict()
    __args__['policyDefinitionName'] = policy_definition_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:authorization/v20190101:getPolicyDefinition', __args__, opts=opts, typ=GetPolicyDefinitionResult).value

    return AwaitableGetPolicyDefinitionResult(
        description=__ret__.description,
        display_name=__ret__.display_name,
        metadata=__ret__.metadata,
        mode=__ret__.mode,
        name=__ret__.name,
        parameters=__ret__.parameters,
        policy_rule=__ret__.policy_rule,
        policy_type=__ret__.policy_type,
        type=__ret__.type)
