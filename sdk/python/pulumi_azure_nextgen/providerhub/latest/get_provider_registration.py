# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from . import outputs

__all__ = [
    'GetProviderRegistrationResult',
    'AwaitableGetProviderRegistrationResult',
    'get_provider_registration',
]

@pulumi.output_type
class GetProviderRegistrationResult:
    def __init__(__self__, name=None, properties=None, type=None):
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if properties and not isinstance(properties, dict):
            raise TypeError("Expected argument 'properties' to be a dict")
        pulumi.set(__self__, "properties", properties)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def properties(self) -> 'outputs.ProviderRegistrationResponseProperties':
        return pulumi.get(self, "properties")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        """
        return pulumi.get(self, "type")


class AwaitableGetProviderRegistrationResult(GetProviderRegistrationResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetProviderRegistrationResult(
            name=self.name,
            properties=self.properties,
            type=self.type)


def get_provider_registration(provider_namespace: Optional[str] = None,
                              opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetProviderRegistrationResult:
    """
    Use this data source to access information about an existing resource.

    :param str provider_namespace: The name of the resource provider hosted within ProviderHub.
    """
    __args__ = dict()
    __args__['providerNamespace'] = provider_namespace
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:providerhub/latest:getProviderRegistration', __args__, opts=opts, typ=GetProviderRegistrationResult).value

    return AwaitableGetProviderRegistrationResult(
        name=__ret__.name,
        properties=__ret__.properties,
        type=__ret__.type)