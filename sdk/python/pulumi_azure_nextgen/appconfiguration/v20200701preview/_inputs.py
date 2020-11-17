# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'EncryptionPropertiesArgs',
    'KeyVaultPropertiesArgs',
    'PrivateEndpointArgs',
    'PrivateLinkServiceConnectionStateArgs',
    'ResourceIdentityArgs',
    'SkuArgs',
]

@pulumi.input_type
class EncryptionPropertiesArgs:
    def __init__(__self__, *,
                 key_vault_properties: Optional[pulumi.Input['KeyVaultPropertiesArgs']] = None):
        """
        The encryption settings for a configuration store.
        :param pulumi.Input['KeyVaultPropertiesArgs'] key_vault_properties: Key vault properties.
        """
        if key_vault_properties is not None:
            pulumi.set(__self__, "key_vault_properties", key_vault_properties)

    @property
    @pulumi.getter(name="keyVaultProperties")
    def key_vault_properties(self) -> Optional[pulumi.Input['KeyVaultPropertiesArgs']]:
        """
        Key vault properties.
        """
        return pulumi.get(self, "key_vault_properties")

    @key_vault_properties.setter
    def key_vault_properties(self, value: Optional[pulumi.Input['KeyVaultPropertiesArgs']]):
        pulumi.set(self, "key_vault_properties", value)


@pulumi.input_type
class KeyVaultPropertiesArgs:
    def __init__(__self__, *,
                 identity_client_id: Optional[pulumi.Input[str]] = None,
                 key_identifier: Optional[pulumi.Input[str]] = None):
        """
        Settings concerning key vault encryption for a configuration store.
        :param pulumi.Input[str] identity_client_id: The client id of the identity which will be used to access key vault.
        :param pulumi.Input[str] key_identifier: The URI of the key vault key used to encrypt data.
        """
        if identity_client_id is not None:
            pulumi.set(__self__, "identity_client_id", identity_client_id)
        if key_identifier is not None:
            pulumi.set(__self__, "key_identifier", key_identifier)

    @property
    @pulumi.getter(name="identityClientId")
    def identity_client_id(self) -> Optional[pulumi.Input[str]]:
        """
        The client id of the identity which will be used to access key vault.
        """
        return pulumi.get(self, "identity_client_id")

    @identity_client_id.setter
    def identity_client_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "identity_client_id", value)

    @property
    @pulumi.getter(name="keyIdentifier")
    def key_identifier(self) -> Optional[pulumi.Input[str]]:
        """
        The URI of the key vault key used to encrypt data.
        """
        return pulumi.get(self, "key_identifier")

    @key_identifier.setter
    def key_identifier(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key_identifier", value)


@pulumi.input_type
class PrivateEndpointArgs:
    def __init__(__self__, *,
                 id: Optional[pulumi.Input[str]] = None):
        """
        Private endpoint which a connection belongs to.
        :param pulumi.Input[str] id: The resource Id for private endpoint
        """
        if id is not None:
            pulumi.set(__self__, "id", id)

    @property
    @pulumi.getter
    def id(self) -> Optional[pulumi.Input[str]]:
        """
        The resource Id for private endpoint
        """
        return pulumi.get(self, "id")

    @id.setter
    def id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "id", value)


@pulumi.input_type
class PrivateLinkServiceConnectionStateArgs:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None):
        """
        The state of a private link service connection.
        :param pulumi.Input[str] description: The private link service connection description.
        :param pulumi.Input[str] status: The private link service connection status.
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if status is not None:
            pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        The private link service connection description.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        """
        The private link service connection status.
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)


@pulumi.input_type
class ResourceIdentityArgs:
    def __init__(__self__, *,
                 type: Optional[pulumi.Input[str]] = None,
                 user_assigned_identities: Optional[pulumi.Input[Mapping[str, Any]]] = None):
        """
        An identity that can be associated with a resource.
        :param pulumi.Input[str] type: The type of managed identity used. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity and a set of user-assigned identities. The type 'None' will remove any identities.
        :param pulumi.Input[Mapping[str, Any]] user_assigned_identities: The list of user-assigned identities associated with the resource. The user-assigned identity dictionary keys will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        """
        if type is not None:
            pulumi.set(__self__, "type", type)
        if user_assigned_identities is not None:
            pulumi.set(__self__, "user_assigned_identities", user_assigned_identities)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[str]]:
        """
        The type of managed identity used. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity and a set of user-assigned identities. The type 'None' will remove any identities.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter(name="userAssignedIdentities")
    def user_assigned_identities(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        The list of user-assigned identities associated with the resource. The user-assigned identity dictionary keys will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        """
        return pulumi.get(self, "user_assigned_identities")

    @user_assigned_identities.setter
    def user_assigned_identities(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "user_assigned_identities", value)


@pulumi.input_type
class SkuArgs:
    def __init__(__self__, *,
                 name: pulumi.Input[str]):
        """
        Describes a configuration store SKU.
        :param pulumi.Input[str] name: The SKU name of the configuration store.
        """
        pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        """
        The SKU name of the configuration store.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)


