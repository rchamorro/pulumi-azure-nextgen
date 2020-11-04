# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'ClusterSkuArgs',
    'IdentityArgs',
    'KeyVaultPropertiesArgs',
]

@pulumi.input_type
class ClusterSkuArgs:
    def __init__(__self__, *,
                 capacity: Optional[pulumi.Input[int]] = None,
                 name: Optional[pulumi.Input[str]] = None):
        """
        The cluster sku definition.
        :param pulumi.Input[int] capacity: The capacity value
        :param pulumi.Input[str] name: The name of the SKU.
        """
        if capacity is not None:
            pulumi.set(__self__, "capacity", capacity)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def capacity(self) -> Optional[pulumi.Input[int]]:
        """
        The capacity value
        """
        return pulumi.get(self, "capacity")

    @capacity.setter
    def capacity(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "capacity", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the SKU.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


@pulumi.input_type
class IdentityArgs:
    def __init__(__self__, *,
                 type: pulumi.Input[str]):
        """
        Identity for the resource.
        :param pulumi.Input[str] type: The type of identity used for the resource. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity and a set of user assigned identities.
        """
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input[str]:
        """
        The type of identity used for the resource. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity and a set of user assigned identities.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input[str]):
        pulumi.set(self, "type", value)


@pulumi.input_type
class KeyVaultPropertiesArgs:
    def __init__(__self__, *,
                 key_name: Optional[pulumi.Input[str]] = None,
                 key_vault_uri: Optional[pulumi.Input[str]] = None,
                 key_version: Optional[pulumi.Input[str]] = None,
                 rsa_key_size: Optional[pulumi.Input[int]] = None):
        """
        The key vault properties.
        :param pulumi.Input[str] key_name: The name of the key associated with the Log Analytics cluster.
        :param pulumi.Input[str] key_vault_uri: The Key Vault uri which holds they key associated with the Log Analytics cluster.
        :param pulumi.Input[str] key_version: The version of the key associated with the Log Analytics cluster.
        :param pulumi.Input[int] rsa_key_size: Selected key minimum required key size.
        """
        if key_name is not None:
            pulumi.set(__self__, "key_name", key_name)
        if key_vault_uri is not None:
            pulumi.set(__self__, "key_vault_uri", key_vault_uri)
        if key_version is not None:
            pulumi.set(__self__, "key_version", key_version)
        if rsa_key_size is not None:
            pulumi.set(__self__, "rsa_key_size", rsa_key_size)

    @property
    @pulumi.getter(name="keyName")
    def key_name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the key associated with the Log Analytics cluster.
        """
        return pulumi.get(self, "key_name")

    @key_name.setter
    def key_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key_name", value)

    @property
    @pulumi.getter(name="keyVaultUri")
    def key_vault_uri(self) -> Optional[pulumi.Input[str]]:
        """
        The Key Vault uri which holds they key associated with the Log Analytics cluster.
        """
        return pulumi.get(self, "key_vault_uri")

    @key_vault_uri.setter
    def key_vault_uri(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key_vault_uri", value)

    @property
    @pulumi.getter(name="keyVersion")
    def key_version(self) -> Optional[pulumi.Input[str]]:
        """
        The version of the key associated with the Log Analytics cluster.
        """
        return pulumi.get(self, "key_version")

    @key_version.setter
    def key_version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key_version", value)

    @property
    @pulumi.getter(name="rsaKeySize")
    def rsa_key_size(self) -> Optional[pulumi.Input[int]]:
        """
        Selected key minimum required key size.
        """
        return pulumi.get(self, "rsa_key_size")

    @rsa_key_size.setter
    def rsa_key_size(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "rsa_key_size", value)

