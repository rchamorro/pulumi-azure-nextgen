# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from . import outputs
from ._enums import *

__all__ = [
    'CmkKekIdentityResponse',
    'CmkKeyVaultPropertiesResponse',
    'IdentityDataResponse',
    'PrivateEndpointConnectionResponse',
    'PrivateEndpointConnectionVaultPropertiesResponse',
    'PrivateEndpointResponse',
    'PrivateLinkServiceConnectionStateResponse',
    'SkuResponse',
    'UpgradeDetailsResponse',
    'UserIdentityResponse',
    'VaultPropertiesResponse',
    'VaultPropertiesResponseEncryption',
]

@pulumi.output_type
class CmkKekIdentityResponse(dict):
    """
    The details of the identity used for CMK
    """
    def __init__(__self__, *,
                 use_system_assigned_identity: Optional[bool] = None,
                 user_assigned_identity: Optional[str] = None):
        """
        The details of the identity used for CMK
        :param bool use_system_assigned_identity: Indicate that system assigned identity should be used. Mutually exclusive with 'userAssignedIdentity' field
        :param str user_assigned_identity: The user assigned identity to be used to grant permissions in case the type of identity used is UserAssigned
        """
        if use_system_assigned_identity is not None:
            pulumi.set(__self__, "use_system_assigned_identity", use_system_assigned_identity)
        if user_assigned_identity is not None:
            pulumi.set(__self__, "user_assigned_identity", user_assigned_identity)

    @property
    @pulumi.getter(name="useSystemAssignedIdentity")
    def use_system_assigned_identity(self) -> Optional[bool]:
        """
        Indicate that system assigned identity should be used. Mutually exclusive with 'userAssignedIdentity' field
        """
        return pulumi.get(self, "use_system_assigned_identity")

    @property
    @pulumi.getter(name="userAssignedIdentity")
    def user_assigned_identity(self) -> Optional[str]:
        """
        The user assigned identity to be used to grant permissions in case the type of identity used is UserAssigned
        """
        return pulumi.get(self, "user_assigned_identity")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class CmkKeyVaultPropertiesResponse(dict):
    """
    The properties of the Key Vault which hosts CMK
    """
    def __init__(__self__, *,
                 key_uri: Optional[str] = None):
        """
        The properties of the Key Vault which hosts CMK
        :param str key_uri: The key uri of the Customer Managed Key
        """
        if key_uri is not None:
            pulumi.set(__self__, "key_uri", key_uri)

    @property
    @pulumi.getter(name="keyUri")
    def key_uri(self) -> Optional[str]:
        """
        The key uri of the Customer Managed Key
        """
        return pulumi.get(self, "key_uri")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class IdentityDataResponse(dict):
    """
    Identity for the resource.
    """
    def __init__(__self__, *,
                 principal_id: str,
                 tenant_id: str,
                 type: str,
                 user_assigned_identities: Optional[Mapping[str, 'outputs.UserIdentityResponse']] = None):
        """
        Identity for the resource.
        :param str principal_id: The principal ID of resource identity.
        :param str tenant_id: The tenant ID of resource.
        :param str type: The type of managed identity used. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity and a set of user-assigned identities. The type 'None' will remove any identities.
        :param Mapping[str, 'UserIdentityResponseArgs'] user_assigned_identities: The list of user-assigned identities associated with the resource. The user-assigned identity dictionary keys will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        """
        pulumi.set(__self__, "principal_id", principal_id)
        pulumi.set(__self__, "tenant_id", tenant_id)
        pulumi.set(__self__, "type", type)
        if user_assigned_identities is not None:
            pulumi.set(__self__, "user_assigned_identities", user_assigned_identities)

    @property
    @pulumi.getter(name="principalId")
    def principal_id(self) -> str:
        """
        The principal ID of resource identity.
        """
        return pulumi.get(self, "principal_id")

    @property
    @pulumi.getter(name="tenantId")
    def tenant_id(self) -> str:
        """
        The tenant ID of resource.
        """
        return pulumi.get(self, "tenant_id")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of managed identity used. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity and a set of user-assigned identities. The type 'None' will remove any identities.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="userAssignedIdentities")
    def user_assigned_identities(self) -> Optional[Mapping[str, 'outputs.UserIdentityResponse']]:
        """
        The list of user-assigned identities associated with the resource. The user-assigned identity dictionary keys will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        """
        return pulumi.get(self, "user_assigned_identities")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class PrivateEndpointConnectionResponse(dict):
    """
    Private Endpoint Connection Response Properties.
    """
    def __init__(__self__, *,
                 private_endpoint: 'outputs.PrivateEndpointResponse',
                 private_link_service_connection_state: 'outputs.PrivateLinkServiceConnectionStateResponse',
                 provisioning_state: str):
        """
        Private Endpoint Connection Response Properties.
        :param 'PrivateEndpointResponseArgs' private_endpoint: The Private Endpoint network resource that is linked to the Private Endpoint connection.
        :param 'PrivateLinkServiceConnectionStateResponseArgs' private_link_service_connection_state: Gets or sets private link service connection state.
        :param str provisioning_state: Gets or sets provisioning state of the private endpoint connection.
        """
        pulumi.set(__self__, "private_endpoint", private_endpoint)
        pulumi.set(__self__, "private_link_service_connection_state", private_link_service_connection_state)
        pulumi.set(__self__, "provisioning_state", provisioning_state)

    @property
    @pulumi.getter(name="privateEndpoint")
    def private_endpoint(self) -> 'outputs.PrivateEndpointResponse':
        """
        The Private Endpoint network resource that is linked to the Private Endpoint connection.
        """
        return pulumi.get(self, "private_endpoint")

    @property
    @pulumi.getter(name="privateLinkServiceConnectionState")
    def private_link_service_connection_state(self) -> 'outputs.PrivateLinkServiceConnectionStateResponse':
        """
        Gets or sets private link service connection state.
        """
        return pulumi.get(self, "private_link_service_connection_state")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        Gets or sets provisioning state of the private endpoint connection.
        """
        return pulumi.get(self, "provisioning_state")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class PrivateEndpointConnectionVaultPropertiesResponse(dict):
    """
    Information to be stored in Vault properties as an element of privateEndpointConnections List.
    """
    def __init__(__self__, *,
                 id: str,
                 properties: 'outputs.PrivateEndpointConnectionResponse'):
        """
        Information to be stored in Vault properties as an element of privateEndpointConnections List.
        :param str id: Format of id subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.[Service]/{resource}/{resourceName}/privateEndpointConnections/{connectionName}.
        :param 'PrivateEndpointConnectionResponseArgs' properties: Private Endpoint Connection Response Properties.
        """
        pulumi.set(__self__, "id", id)
        pulumi.set(__self__, "properties", properties)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Format of id subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.[Service]/{resource}/{resourceName}/privateEndpointConnections/{connectionName}.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def properties(self) -> 'outputs.PrivateEndpointConnectionResponse':
        """
        Private Endpoint Connection Response Properties.
        """
        return pulumi.get(self, "properties")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class PrivateEndpointResponse(dict):
    """
    The Private Endpoint network resource that is linked to the Private Endpoint connection.
    """
    def __init__(__self__, *,
                 id: str):
        """
        The Private Endpoint network resource that is linked to the Private Endpoint connection.
        :param str id: Gets or sets id.
        """
        pulumi.set(__self__, "id", id)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Gets or sets id.
        """
        return pulumi.get(self, "id")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class PrivateLinkServiceConnectionStateResponse(dict):
    """
    Gets or sets private link service connection state.
    """
    def __init__(__self__, *,
                 actions_required: str,
                 description: str,
                 status: str):
        """
        Gets or sets private link service connection state.
        :param str actions_required: Gets or sets actions required.
        :param str description: Gets or sets description.
        :param str status: Gets or sets the status.
        """
        pulumi.set(__self__, "actions_required", actions_required)
        pulumi.set(__self__, "description", description)
        pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter(name="actionsRequired")
    def actions_required(self) -> str:
        """
        Gets or sets actions required.
        """
        return pulumi.get(self, "actions_required")

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        Gets or sets description.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        Gets or sets the status.
        """
        return pulumi.get(self, "status")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class SkuResponse(dict):
    """
    Identifies the unique system identifier for each Azure resource.
    """
    def __init__(__self__, *,
                 name: str):
        """
        Identifies the unique system identifier for each Azure resource.
        :param str name: The Sku name.
        """
        pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The Sku name.
        """
        return pulumi.get(self, "name")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class UpgradeDetailsResponse(dict):
    """
    Details for upgrading vault.
    """
    def __init__(__self__, *,
                 end_time_utc: str,
                 last_updated_time_utc: str,
                 message: str,
                 operation_id: str,
                 previous_resource_id: str,
                 start_time_utc: str,
                 status: str,
                 trigger_type: str,
                 upgraded_resource_id: str):
        """
        Details for upgrading vault.
        :param str end_time_utc: UTC time at which the upgrade operation has ended.
        :param str last_updated_time_utc: UTC time at which the upgrade operation status was last updated.
        :param str message: Message to the user containing information about the upgrade operation.
        :param str operation_id: ID of the vault upgrade operation.
        :param str previous_resource_id: Resource ID of the vault before the upgrade.
        :param str start_time_utc: UTC time at which the upgrade operation has started.
        :param str status: Status of the vault upgrade operation.
        :param str trigger_type: The way the vault upgrade was triggered.
        :param str upgraded_resource_id: Resource ID of the upgraded vault.
        """
        pulumi.set(__self__, "end_time_utc", end_time_utc)
        pulumi.set(__self__, "last_updated_time_utc", last_updated_time_utc)
        pulumi.set(__self__, "message", message)
        pulumi.set(__self__, "operation_id", operation_id)
        pulumi.set(__self__, "previous_resource_id", previous_resource_id)
        pulumi.set(__self__, "start_time_utc", start_time_utc)
        pulumi.set(__self__, "status", status)
        pulumi.set(__self__, "trigger_type", trigger_type)
        pulumi.set(__self__, "upgraded_resource_id", upgraded_resource_id)

    @property
    @pulumi.getter(name="endTimeUtc")
    def end_time_utc(self) -> str:
        """
        UTC time at which the upgrade operation has ended.
        """
        return pulumi.get(self, "end_time_utc")

    @property
    @pulumi.getter(name="lastUpdatedTimeUtc")
    def last_updated_time_utc(self) -> str:
        """
        UTC time at which the upgrade operation status was last updated.
        """
        return pulumi.get(self, "last_updated_time_utc")

    @property
    @pulumi.getter
    def message(self) -> str:
        """
        Message to the user containing information about the upgrade operation.
        """
        return pulumi.get(self, "message")

    @property
    @pulumi.getter(name="operationId")
    def operation_id(self) -> str:
        """
        ID of the vault upgrade operation.
        """
        return pulumi.get(self, "operation_id")

    @property
    @pulumi.getter(name="previousResourceId")
    def previous_resource_id(self) -> str:
        """
        Resource ID of the vault before the upgrade.
        """
        return pulumi.get(self, "previous_resource_id")

    @property
    @pulumi.getter(name="startTimeUtc")
    def start_time_utc(self) -> str:
        """
        UTC time at which the upgrade operation has started.
        """
        return pulumi.get(self, "start_time_utc")

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        Status of the vault upgrade operation.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter(name="triggerType")
    def trigger_type(self) -> str:
        """
        The way the vault upgrade was triggered.
        """
        return pulumi.get(self, "trigger_type")

    @property
    @pulumi.getter(name="upgradedResourceId")
    def upgraded_resource_id(self) -> str:
        """
        Resource ID of the upgraded vault.
        """
        return pulumi.get(self, "upgraded_resource_id")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class UserIdentityResponse(dict):
    """
    A resource identity that is managed by the user of the service.
    """
    def __init__(__self__, *,
                 client_id: str,
                 principal_id: str):
        """
        A resource identity that is managed by the user of the service.
        :param str client_id: The client ID of the user-assigned identity.
        :param str principal_id: The principal ID of the user-assigned identity.
        """
        pulumi.set(__self__, "client_id", client_id)
        pulumi.set(__self__, "principal_id", principal_id)

    @property
    @pulumi.getter(name="clientId")
    def client_id(self) -> str:
        """
        The client ID of the user-assigned identity.
        """
        return pulumi.get(self, "client_id")

    @property
    @pulumi.getter(name="principalId")
    def principal_id(self) -> str:
        """
        The principal ID of the user-assigned identity.
        """
        return pulumi.get(self, "principal_id")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class VaultPropertiesResponse(dict):
    """
    Properties of the vault.
    """
    def __init__(__self__, *,
                 private_endpoint_connections: Sequence['outputs.PrivateEndpointConnectionVaultPropertiesResponse'],
                 private_endpoint_state_for_backup: str,
                 private_endpoint_state_for_site_recovery: str,
                 provisioning_state: str,
                 encryption: Optional['outputs.VaultPropertiesResponseEncryption'] = None,
                 upgrade_details: Optional['outputs.UpgradeDetailsResponse'] = None):
        """
        Properties of the vault.
        :param Sequence['PrivateEndpointConnectionVaultPropertiesResponseArgs'] private_endpoint_connections: List of private endpoint connection.
        :param str private_endpoint_state_for_backup: Private endpoint state for backup.
        :param str private_endpoint_state_for_site_recovery: Private endpoint state for site recovery.
        :param str provisioning_state: Provisioning State.
        :param 'VaultPropertiesResponseEncryptionArgs' encryption: Customer Managed Key details of the resource.
        :param 'UpgradeDetailsResponseArgs' upgrade_details: Details for upgrading vault.
        """
        pulumi.set(__self__, "private_endpoint_connections", private_endpoint_connections)
        pulumi.set(__self__, "private_endpoint_state_for_backup", private_endpoint_state_for_backup)
        pulumi.set(__self__, "private_endpoint_state_for_site_recovery", private_endpoint_state_for_site_recovery)
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if encryption is not None:
            pulumi.set(__self__, "encryption", encryption)
        if upgrade_details is not None:
            pulumi.set(__self__, "upgrade_details", upgrade_details)

    @property
    @pulumi.getter(name="privateEndpointConnections")
    def private_endpoint_connections(self) -> Sequence['outputs.PrivateEndpointConnectionVaultPropertiesResponse']:
        """
        List of private endpoint connection.
        """
        return pulumi.get(self, "private_endpoint_connections")

    @property
    @pulumi.getter(name="privateEndpointStateForBackup")
    def private_endpoint_state_for_backup(self) -> str:
        """
        Private endpoint state for backup.
        """
        return pulumi.get(self, "private_endpoint_state_for_backup")

    @property
    @pulumi.getter(name="privateEndpointStateForSiteRecovery")
    def private_endpoint_state_for_site_recovery(self) -> str:
        """
        Private endpoint state for site recovery.
        """
        return pulumi.get(self, "private_endpoint_state_for_site_recovery")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        Provisioning State.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter
    def encryption(self) -> Optional['outputs.VaultPropertiesResponseEncryption']:
        """
        Customer Managed Key details of the resource.
        """
        return pulumi.get(self, "encryption")

    @property
    @pulumi.getter(name="upgradeDetails")
    def upgrade_details(self) -> Optional['outputs.UpgradeDetailsResponse']:
        """
        Details for upgrading vault.
        """
        return pulumi.get(self, "upgrade_details")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class VaultPropertiesResponseEncryption(dict):
    """
    Customer Managed Key details of the resource.
    """
    def __init__(__self__, *,
                 infrastructure_encryption: Optional[str] = None,
                 kek_identity: Optional['outputs.CmkKekIdentityResponse'] = None,
                 key_vault_properties: Optional['outputs.CmkKeyVaultPropertiesResponse'] = None):
        """
        Customer Managed Key details of the resource.
        :param str infrastructure_encryption: Enabling/Disabling the Double Encryption state
        :param 'CmkKekIdentityResponseArgs' kek_identity: The details of the identity used for CMK
        :param 'CmkKeyVaultPropertiesResponseArgs' key_vault_properties: The properties of the Key Vault which hosts CMK
        """
        if infrastructure_encryption is not None:
            pulumi.set(__self__, "infrastructure_encryption", infrastructure_encryption)
        if kek_identity is not None:
            pulumi.set(__self__, "kek_identity", kek_identity)
        if key_vault_properties is not None:
            pulumi.set(__self__, "key_vault_properties", key_vault_properties)

    @property
    @pulumi.getter(name="infrastructureEncryption")
    def infrastructure_encryption(self) -> Optional[str]:
        """
        Enabling/Disabling the Double Encryption state
        """
        return pulumi.get(self, "infrastructure_encryption")

    @property
    @pulumi.getter(name="kekIdentity")
    def kek_identity(self) -> Optional['outputs.CmkKekIdentityResponse']:
        """
        The details of the identity used for CMK
        """
        return pulumi.get(self, "kek_identity")

    @property
    @pulumi.getter(name="keyVaultProperties")
    def key_vault_properties(self) -> Optional['outputs.CmkKeyVaultPropertiesResponse']:
        """
        The properties of the Key Vault which hosts CMK
        """
        return pulumi.get(self, "key_vault_properties")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


