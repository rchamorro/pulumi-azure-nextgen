# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'GetPolicyAssignmentResult',
    'AwaitableGetPolicyAssignmentResult',
    'get_policy_assignment',
]

@pulumi.output_type
class GetPolicyAssignmentResult:
    """
    The policy assignment.
    """
    def __init__(__self__, description=None, display_name=None, name=None, parameters=None, policy_definition_id=None, scope=None, type=None):
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if display_name and not isinstance(display_name, str):
            raise TypeError("Expected argument 'display_name' to be a str")
        pulumi.set(__self__, "display_name", display_name)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if parameters and not isinstance(parameters, dict):
            raise TypeError("Expected argument 'parameters' to be a dict")
        pulumi.set(__self__, "parameters", parameters)
        if policy_definition_id and not isinstance(policy_definition_id, str):
            raise TypeError("Expected argument 'policy_definition_id' to be a str")
        pulumi.set(__self__, "policy_definition_id", policy_definition_id)
        if scope and not isinstance(scope, str):
            raise TypeError("Expected argument 'scope' to be a str")
        pulumi.set(__self__, "scope", scope)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def description(self) -> Optional[str]:
        """
        This message will be part of response in case of policy violation.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> Optional[str]:
        """
        The display name of the policy assignment.
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        The name of the policy assignment.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def parameters(self) -> Optional[Mapping[str, Any]]:
        """
        Required if a parameter is used in policy rule.
        """
        return pulumi.get(self, "parameters")

    @property
    @pulumi.getter(name="policyDefinitionId")
    def policy_definition_id(self) -> Optional[str]:
        """
        The ID of the policy definition.
        """
        return pulumi.get(self, "policy_definition_id")

    @property
    @pulumi.getter
    def scope(self) -> Optional[str]:
        """
        The scope for the policy assignment.
        """
        return pulumi.get(self, "scope")

    @property
    @pulumi.getter
    def type(self) -> Optional[str]:
        """
        The type of the policy assignment.
        """
        return pulumi.get(self, "type")


class AwaitableGetPolicyAssignmentResult(GetPolicyAssignmentResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetPolicyAssignmentResult(
            description=self.description,
            display_name=self.display_name,
            name=self.name,
            parameters=self.parameters,
            policy_definition_id=self.policy_definition_id,
            scope=self.scope,
            type=self.type)


def get_policy_assignment(policy_assignment_name: Optional[str] = None,
                          scope: Optional[str] = None,
                          opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetPolicyAssignmentResult:
    """
    Use this data source to access information about an existing resource.

    :param str policy_assignment_name: The name of the policy assignment to get.
    :param str scope: The scope of the policy assignment.
    """
    __args__ = dict()
    __args__['policyAssignmentName'] = policy_assignment_name
    __args__['scope'] = scope
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:authorization/v20161201:getPolicyAssignment', __args__, opts=opts, typ=GetPolicyAssignmentResult).value

    return AwaitableGetPolicyAssignmentResult(
        description=__ret__.description,
        display_name=__ret__.display_name,
        name=__ret__.name,
        parameters=__ret__.parameters,
        policy_definition_id=__ret__.policy_definition_id,
        scope=__ret__.scope,
        type=__ret__.type)