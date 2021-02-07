# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'GetRegistrationActivationKeyResult',
    'AwaitableGetRegistrationActivationKeyResult',
    'get_registration_activation_key',
]

@pulumi.output_type
class GetRegistrationActivationKeyResult:
    """
    The resource containing the Azure Stack activation key.
    """
    def __init__(__self__, activation_key=None):
        if activation_key and not isinstance(activation_key, str):
            raise TypeError("Expected argument 'activation_key' to be a str")
        pulumi.set(__self__, "activation_key", activation_key)

    @property
    @pulumi.getter(name="activationKey")
    def activation_key(self) -> Optional[str]:
        """
        Azure Stack activation key.
        """
        return pulumi.get(self, "activation_key")


class AwaitableGetRegistrationActivationKeyResult(GetRegistrationActivationKeyResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetRegistrationActivationKeyResult(
            activation_key=self.activation_key)


def get_registration_activation_key(registration_name: Optional[str] = None,
                                    resource_group: Optional[str] = None,
                                    opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetRegistrationActivationKeyResult:
    """
    Use this data source to access information about an existing resource.

    :param str registration_name: Name of the Azure Stack registration.
    :param str resource_group: Name of the resource group.
    """
    __args__ = dict()
    __args__['registrationName'] = registration_name
    __args__['resourceGroup'] = resource_group
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:azurestack/v20200601preview:getRegistrationActivationKey', __args__, opts=opts, typ=GetRegistrationActivationKeyResult).value

    return AwaitableGetRegistrationActivationKeyResult(
        activation_key=__ret__.activation_key)
