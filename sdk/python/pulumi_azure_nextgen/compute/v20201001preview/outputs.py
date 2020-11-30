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
    'CloudServiceExtensionProfileResponse',
    'CloudServiceExtensionPropertiesResponse',
    'CloudServiceNetworkProfileResponse',
    'CloudServiceOsProfileResponse',
    'CloudServicePropertiesResponse',
    'CloudServiceRoleProfilePropertiesResponse',
    'CloudServiceRoleProfileResponse',
    'CloudServiceRoleSkuResponse',
    'CloudServiceVaultAndSecretReferenceResponse',
    'CloudServiceVaultCertificateResponse',
    'CloudServiceVaultSecretGroupResponse',
    'ExtensionResponse',
    'LoadBalancerConfigurationPropertiesResponse',
    'LoadBalancerConfigurationResponse',
    'LoadBalancerFrontendIPConfigurationPropertiesResponse',
    'LoadBalancerFrontendIPConfigurationResponse',
    'SubResourceResponse',
]

@pulumi.output_type
class CloudServiceExtensionProfileResponse(dict):
    """
    Describes a cloud service extension profile.
    """
    def __init__(__self__, *,
                 extensions: Optional[Sequence['outputs.ExtensionResponse']] = None):
        """
        Describes a cloud service extension profile.
        :param Sequence['ExtensionResponseArgs'] extensions: List of extensions for the cloud service.
        """
        if extensions is not None:
            pulumi.set(__self__, "extensions", extensions)

    @property
    @pulumi.getter
    def extensions(self) -> Optional[Sequence['outputs.ExtensionResponse']]:
        """
        List of extensions for the cloud service.
        """
        return pulumi.get(self, "extensions")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class CloudServiceExtensionPropertiesResponse(dict):
    """
    Extension Properties.
    """
    def __init__(__self__, *,
                 provisioning_state: str,
                 auto_upgrade_minor_version: Optional[bool] = None,
                 force_update_tag: Optional[str] = None,
                 protected_settings: Optional[str] = None,
                 protected_settings_from_key_vault: Optional['outputs.CloudServiceVaultAndSecretReferenceResponse'] = None,
                 publisher: Optional[str] = None,
                 roles_applied_to: Optional[Sequence[str]] = None,
                 settings: Optional[str] = None,
                 type: Optional[str] = None,
                 type_handler_version: Optional[str] = None):
        """
        Extension Properties.
        :param str provisioning_state: The provisioning state, which only appears in the response.
        :param bool auto_upgrade_minor_version: Explicitly specify whether platform can automatically upgrade typeHandlerVersion to higher minor versions when they become available.
        :param str force_update_tag: Tag to force apply the provided public and protected settings.
               Changing the tag value allows for re-running the extension without changing any of the public or protected settings.
               If forceUpdateTag is not changed, updates to public or protected settings would still be applied by the handler.
               If neither forceUpdateTag nor any of public or protected settings change, extension would flow to the role instance with the same sequence-number, and
               it is up to handler implementation whether to re-run it or not
        :param str protected_settings: Protected settings for the extension which are encrypted before sent to the role instance.
        :param str publisher: The name of the extension handler publisher.
        :param Sequence[str] roles_applied_to: Optional list of roles to apply this extension. If property is not specified or '*' is specified, extension is applied to all roles in the cloud service.
        :param str settings: Public settings for the extension. For JSON extensions, this is the JSON settings for the extension. For XML Extension (like RDP), this is the XML setting for the extension.
        :param str type: Specifies the type of the extension.
        :param str type_handler_version: Specifies the version of the extension. Specifies the version of the extension. If this element is not specified or an asterisk (*) is used as the value, the latest version of the extension is used. If the value is specified with a major version number and an asterisk as the minor version number (X.), the latest minor version of the specified major version is selected. If a major version number and a minor version number are specified (X.Y), the specific extension version is selected. If a version is specified, an auto-upgrade is performed on the role instance.
        """
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if auto_upgrade_minor_version is not None:
            pulumi.set(__self__, "auto_upgrade_minor_version", auto_upgrade_minor_version)
        if force_update_tag is not None:
            pulumi.set(__self__, "force_update_tag", force_update_tag)
        if protected_settings is not None:
            pulumi.set(__self__, "protected_settings", protected_settings)
        if protected_settings_from_key_vault is not None:
            pulumi.set(__self__, "protected_settings_from_key_vault", protected_settings_from_key_vault)
        if publisher is not None:
            pulumi.set(__self__, "publisher", publisher)
        if roles_applied_to is not None:
            pulumi.set(__self__, "roles_applied_to", roles_applied_to)
        if settings is not None:
            pulumi.set(__self__, "settings", settings)
        if type is not None:
            pulumi.set(__self__, "type", type)
        if type_handler_version is not None:
            pulumi.set(__self__, "type_handler_version", type_handler_version)

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        The provisioning state, which only appears in the response.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="autoUpgradeMinorVersion")
    def auto_upgrade_minor_version(self) -> Optional[bool]:
        """
        Explicitly specify whether platform can automatically upgrade typeHandlerVersion to higher minor versions when they become available.
        """
        return pulumi.get(self, "auto_upgrade_minor_version")

    @property
    @pulumi.getter(name="forceUpdateTag")
    def force_update_tag(self) -> Optional[str]:
        """
        Tag to force apply the provided public and protected settings.
        Changing the tag value allows for re-running the extension without changing any of the public or protected settings.
        If forceUpdateTag is not changed, updates to public or protected settings would still be applied by the handler.
        If neither forceUpdateTag nor any of public or protected settings change, extension would flow to the role instance with the same sequence-number, and
        it is up to handler implementation whether to re-run it or not
        """
        return pulumi.get(self, "force_update_tag")

    @property
    @pulumi.getter(name="protectedSettings")
    def protected_settings(self) -> Optional[str]:
        """
        Protected settings for the extension which are encrypted before sent to the role instance.
        """
        return pulumi.get(self, "protected_settings")

    @property
    @pulumi.getter(name="protectedSettingsFromKeyVault")
    def protected_settings_from_key_vault(self) -> Optional['outputs.CloudServiceVaultAndSecretReferenceResponse']:
        return pulumi.get(self, "protected_settings_from_key_vault")

    @property
    @pulumi.getter
    def publisher(self) -> Optional[str]:
        """
        The name of the extension handler publisher.
        """
        return pulumi.get(self, "publisher")

    @property
    @pulumi.getter(name="rolesAppliedTo")
    def roles_applied_to(self) -> Optional[Sequence[str]]:
        """
        Optional list of roles to apply this extension. If property is not specified or '*' is specified, extension is applied to all roles in the cloud service.
        """
        return pulumi.get(self, "roles_applied_to")

    @property
    @pulumi.getter
    def settings(self) -> Optional[str]:
        """
        Public settings for the extension. For JSON extensions, this is the JSON settings for the extension. For XML Extension (like RDP), this is the XML setting for the extension.
        """
        return pulumi.get(self, "settings")

    @property
    @pulumi.getter
    def type(self) -> Optional[str]:
        """
        Specifies the type of the extension.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="typeHandlerVersion")
    def type_handler_version(self) -> Optional[str]:
        """
        Specifies the version of the extension. Specifies the version of the extension. If this element is not specified or an asterisk (*) is used as the value, the latest version of the extension is used. If the value is specified with a major version number and an asterisk as the minor version number (X.), the latest minor version of the specified major version is selected. If a major version number and a minor version number are specified (X.Y), the specific extension version is selected. If a version is specified, an auto-upgrade is performed on the role instance.
        """
        return pulumi.get(self, "type_handler_version")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class CloudServiceNetworkProfileResponse(dict):
    """
    Network Profile for the cloud service.
    """
    def __init__(__self__, *,
                 load_balancer_configurations: Optional[Sequence['outputs.LoadBalancerConfigurationResponse']] = None,
                 swappable_cloud_service: Optional['outputs.SubResourceResponse'] = None):
        """
        Network Profile for the cloud service.
        :param Sequence['LoadBalancerConfigurationResponseArgs'] load_balancer_configurations: The list of load balancer configurations for the cloud service.
        """
        if load_balancer_configurations is not None:
            pulumi.set(__self__, "load_balancer_configurations", load_balancer_configurations)
        if swappable_cloud_service is not None:
            pulumi.set(__self__, "swappable_cloud_service", swappable_cloud_service)

    @property
    @pulumi.getter(name="loadBalancerConfigurations")
    def load_balancer_configurations(self) -> Optional[Sequence['outputs.LoadBalancerConfigurationResponse']]:
        """
        The list of load balancer configurations for the cloud service.
        """
        return pulumi.get(self, "load_balancer_configurations")

    @property
    @pulumi.getter(name="swappableCloudService")
    def swappable_cloud_service(self) -> Optional['outputs.SubResourceResponse']:
        return pulumi.get(self, "swappable_cloud_service")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class CloudServiceOsProfileResponse(dict):
    """
    Describes the OS profile for the cloud service.
    """
    def __init__(__self__, *,
                 secrets: Optional[Sequence['outputs.CloudServiceVaultSecretGroupResponse']] = None):
        """
        Describes the OS profile for the cloud service.
        :param Sequence['CloudServiceVaultSecretGroupResponseArgs'] secrets: Specifies set of certificates that should be installed onto the role instances.
        """
        if secrets is not None:
            pulumi.set(__self__, "secrets", secrets)

    @property
    @pulumi.getter
    def secrets(self) -> Optional[Sequence['outputs.CloudServiceVaultSecretGroupResponse']]:
        """
        Specifies set of certificates that should be installed onto the role instances.
        """
        return pulumi.get(self, "secrets")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class CloudServicePropertiesResponse(dict):
    """
    Cloud service properties
    """
    def __init__(__self__, *,
                 provisioning_state: str,
                 unique_id: str,
                 configuration: Optional[str] = None,
                 configuration_url: Optional[str] = None,
                 extension_profile: Optional['outputs.CloudServiceExtensionProfileResponse'] = None,
                 network_profile: Optional['outputs.CloudServiceNetworkProfileResponse'] = None,
                 os_profile: Optional['outputs.CloudServiceOsProfileResponse'] = None,
                 package_url: Optional[str] = None,
                 role_profile: Optional['outputs.CloudServiceRoleProfileResponse'] = None,
                 start_cloud_service: Optional[bool] = None,
                 upgrade_mode: Optional[str] = None):
        """
        Cloud service properties
        :param str provisioning_state: The provisioning state, which only appears in the response.
        :param str unique_id: The unique identifier for the cloud service.
        :param str configuration: Specifies the XML service configuration (.cscfg) for the cloud service.
        :param str configuration_url: Specifies a URL that refers to the location of the service configuration in the Blob service. The service package URL  can be Shared Access Signature (SAS) URI from any storage account.
               This is a write-only property and is not returned in GET calls.
        :param 'CloudServiceExtensionProfileResponseArgs' extension_profile: Describes a cloud service extension profile.
        :param 'CloudServiceNetworkProfileResponseArgs' network_profile: Network Profile for the cloud service.
        :param 'CloudServiceOsProfileResponseArgs' os_profile: Describes the OS profile for the cloud service.
        :param str package_url: Specifies a URL that refers to the location of the service package in the Blob service. The service package URL can be Shared Access Signature (SAS) URI from any storage account.
               This is a write-only property and is not returned in GET calls.
        :param 'CloudServiceRoleProfileResponseArgs' role_profile: Describes the role profile for the cloud service.
        :param bool start_cloud_service: (Optional) Indicates whether to start the cloud service immediately after it is created. The default value is `true`.
               If false, the service model is still deployed, but the code is not run immediately. Instead, the service is PoweredOff until you call Start, at which time the service will be started. A deployed service still incurs charges, even if it is poweredoff.
        :param str upgrade_mode: Update mode for the cloud service. Role instances are allocated to update domains when the service is deployed. Updates can be initiated manually in each update domain or initiated automatically in all update domains.
               Possible Values are <br /><br />**Auto**<br /><br />**Manual** <br /><br />**Simultaneous**<br /><br />
               If not specified, the default value is Auto. If set to Manual, PUT UpdateDomain must be called to apply the update. If set to Auto, the update is automatically applied to each update domain in sequence.
        """
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        pulumi.set(__self__, "unique_id", unique_id)
        if configuration is not None:
            pulumi.set(__self__, "configuration", configuration)
        if configuration_url is not None:
            pulumi.set(__self__, "configuration_url", configuration_url)
        if extension_profile is not None:
            pulumi.set(__self__, "extension_profile", extension_profile)
        if network_profile is not None:
            pulumi.set(__self__, "network_profile", network_profile)
        if os_profile is not None:
            pulumi.set(__self__, "os_profile", os_profile)
        if package_url is not None:
            pulumi.set(__self__, "package_url", package_url)
        if role_profile is not None:
            pulumi.set(__self__, "role_profile", role_profile)
        if start_cloud_service is not None:
            pulumi.set(__self__, "start_cloud_service", start_cloud_service)
        if upgrade_mode is not None:
            pulumi.set(__self__, "upgrade_mode", upgrade_mode)

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        The provisioning state, which only appears in the response.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="uniqueId")
    def unique_id(self) -> str:
        """
        The unique identifier for the cloud service.
        """
        return pulumi.get(self, "unique_id")

    @property
    @pulumi.getter
    def configuration(self) -> Optional[str]:
        """
        Specifies the XML service configuration (.cscfg) for the cloud service.
        """
        return pulumi.get(self, "configuration")

    @property
    @pulumi.getter(name="configurationUrl")
    def configuration_url(self) -> Optional[str]:
        """
        Specifies a URL that refers to the location of the service configuration in the Blob service. The service package URL  can be Shared Access Signature (SAS) URI from any storage account.
        This is a write-only property and is not returned in GET calls.
        """
        return pulumi.get(self, "configuration_url")

    @property
    @pulumi.getter(name="extensionProfile")
    def extension_profile(self) -> Optional['outputs.CloudServiceExtensionProfileResponse']:
        """
        Describes a cloud service extension profile.
        """
        return pulumi.get(self, "extension_profile")

    @property
    @pulumi.getter(name="networkProfile")
    def network_profile(self) -> Optional['outputs.CloudServiceNetworkProfileResponse']:
        """
        Network Profile for the cloud service.
        """
        return pulumi.get(self, "network_profile")

    @property
    @pulumi.getter(name="osProfile")
    def os_profile(self) -> Optional['outputs.CloudServiceOsProfileResponse']:
        """
        Describes the OS profile for the cloud service.
        """
        return pulumi.get(self, "os_profile")

    @property
    @pulumi.getter(name="packageUrl")
    def package_url(self) -> Optional[str]:
        """
        Specifies a URL that refers to the location of the service package in the Blob service. The service package URL can be Shared Access Signature (SAS) URI from any storage account.
        This is a write-only property and is not returned in GET calls.
        """
        return pulumi.get(self, "package_url")

    @property
    @pulumi.getter(name="roleProfile")
    def role_profile(self) -> Optional['outputs.CloudServiceRoleProfileResponse']:
        """
        Describes the role profile for the cloud service.
        """
        return pulumi.get(self, "role_profile")

    @property
    @pulumi.getter(name="startCloudService")
    def start_cloud_service(self) -> Optional[bool]:
        """
        (Optional) Indicates whether to start the cloud service immediately after it is created. The default value is `true`.
        If false, the service model is still deployed, but the code is not run immediately. Instead, the service is PoweredOff until you call Start, at which time the service will be started. A deployed service still incurs charges, even if it is poweredoff.
        """
        return pulumi.get(self, "start_cloud_service")

    @property
    @pulumi.getter(name="upgradeMode")
    def upgrade_mode(self) -> Optional[str]:
        """
        Update mode for the cloud service. Role instances are allocated to update domains when the service is deployed. Updates can be initiated manually in each update domain or initiated automatically in all update domains.
        Possible Values are <br /><br />**Auto**<br /><br />**Manual** <br /><br />**Simultaneous**<br /><br />
        If not specified, the default value is Auto. If set to Manual, PUT UpdateDomain must be called to apply the update. If set to Auto, the update is automatically applied to each update domain in sequence.
        """
        return pulumi.get(self, "upgrade_mode")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class CloudServiceRoleProfilePropertiesResponse(dict):
    """
    Describes the role properties.
    """
    def __init__(__self__, *,
                 name: Optional[str] = None,
                 sku: Optional['outputs.CloudServiceRoleSkuResponse'] = None):
        """
        Describes the role properties.
        :param str name: Resource name.
        :param 'CloudServiceRoleSkuResponseArgs' sku: Describes the cloud service role sku.
        """
        if name is not None:
            pulumi.set(__self__, "name", name)
        if sku is not None:
            pulumi.set(__self__, "sku", sku)

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        Resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def sku(self) -> Optional['outputs.CloudServiceRoleSkuResponse']:
        """
        Describes the cloud service role sku.
        """
        return pulumi.get(self, "sku")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class CloudServiceRoleProfileResponse(dict):
    """
    Describes the role profile for the cloud service.
    """
    def __init__(__self__, *,
                 roles: Optional[Sequence['outputs.CloudServiceRoleProfilePropertiesResponse']] = None):
        """
        Describes the role profile for the cloud service.
        :param Sequence['CloudServiceRoleProfilePropertiesResponseArgs'] roles: List of roles for the cloud service.
        """
        if roles is not None:
            pulumi.set(__self__, "roles", roles)

    @property
    @pulumi.getter
    def roles(self) -> Optional[Sequence['outputs.CloudServiceRoleProfilePropertiesResponse']]:
        """
        List of roles for the cloud service.
        """
        return pulumi.get(self, "roles")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class CloudServiceRoleSkuResponse(dict):
    """
    Describes the cloud service role sku.
    """
    def __init__(__self__, *,
                 capacity: Optional[int] = None,
                 name: Optional[str] = None,
                 tier: Optional[str] = None):
        """
        Describes the cloud service role sku.
        :param int capacity: Specifies the number of role instances in the cloud service.
        :param str name: The sku name. NOTE: If the new SKU is not supported on the hardware the cloud service is currently on, you need to delete and recreate the cloud service or move back to the old sku.
        :param str tier: Specifies the tier of the cloud service. Possible Values are <br /><br /> **Standard** <br /><br /> **Basic**
        """
        if capacity is not None:
            pulumi.set(__self__, "capacity", capacity)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if tier is not None:
            pulumi.set(__self__, "tier", tier)

    @property
    @pulumi.getter
    def capacity(self) -> Optional[int]:
        """
        Specifies the number of role instances in the cloud service.
        """
        return pulumi.get(self, "capacity")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        The sku name. NOTE: If the new SKU is not supported on the hardware the cloud service is currently on, you need to delete and recreate the cloud service or move back to the old sku.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def tier(self) -> Optional[str]:
        """
        Specifies the tier of the cloud service. Possible Values are <br /><br /> **Standard** <br /><br /> **Basic**
        """
        return pulumi.get(self, "tier")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class CloudServiceVaultAndSecretReferenceResponse(dict):
    def __init__(__self__, *,
                 secret_url: Optional[str] = None,
                 source_vault: Optional['outputs.SubResourceResponse'] = None):
        if secret_url is not None:
            pulumi.set(__self__, "secret_url", secret_url)
        if source_vault is not None:
            pulumi.set(__self__, "source_vault", source_vault)

    @property
    @pulumi.getter(name="secretUrl")
    def secret_url(self) -> Optional[str]:
        return pulumi.get(self, "secret_url")

    @property
    @pulumi.getter(name="sourceVault")
    def source_vault(self) -> Optional['outputs.SubResourceResponse']:
        return pulumi.get(self, "source_vault")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class CloudServiceVaultCertificateResponse(dict):
    """
    Describes a single certificate reference in a Key Vault, and where the certificate should reside on the role instance.
    """
    def __init__(__self__, *,
                 certificate_url: Optional[str] = None):
        """
        Describes a single certificate reference in a Key Vault, and where the certificate should reside on the role instance.
        :param str certificate_url: This is the URL of a certificate that has been uploaded to Key Vault as a secret.
        """
        if certificate_url is not None:
            pulumi.set(__self__, "certificate_url", certificate_url)

    @property
    @pulumi.getter(name="certificateUrl")
    def certificate_url(self) -> Optional[str]:
        """
        This is the URL of a certificate that has been uploaded to Key Vault as a secret.
        """
        return pulumi.get(self, "certificate_url")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class CloudServiceVaultSecretGroupResponse(dict):
    """
    Describes a set of certificates which are all in the same Key Vault.
    """
    def __init__(__self__, *,
                 source_vault: Optional['outputs.SubResourceResponse'] = None,
                 vault_certificates: Optional[Sequence['outputs.CloudServiceVaultCertificateResponse']] = None):
        """
        Describes a set of certificates which are all in the same Key Vault.
        :param 'SubResourceResponseArgs' source_vault: The relative URL of the Key Vault containing all of the certificates in VaultCertificates.
        :param Sequence['CloudServiceVaultCertificateResponseArgs'] vault_certificates: The list of key vault references in SourceVault which contain certificates.
        """
        if source_vault is not None:
            pulumi.set(__self__, "source_vault", source_vault)
        if vault_certificates is not None:
            pulumi.set(__self__, "vault_certificates", vault_certificates)

    @property
    @pulumi.getter(name="sourceVault")
    def source_vault(self) -> Optional['outputs.SubResourceResponse']:
        """
        The relative URL of the Key Vault containing all of the certificates in VaultCertificates.
        """
        return pulumi.get(self, "source_vault")

    @property
    @pulumi.getter(name="vaultCertificates")
    def vault_certificates(self) -> Optional[Sequence['outputs.CloudServiceVaultCertificateResponse']]:
        """
        The list of key vault references in SourceVault which contain certificates.
        """
        return pulumi.get(self, "vault_certificates")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ExtensionResponse(dict):
    """
    Describes a cloud service Extension.
    """
    def __init__(__self__, *,
                 name: Optional[str] = None,
                 properties: Optional['outputs.CloudServiceExtensionPropertiesResponse'] = None):
        """
        Describes a cloud service Extension.
        :param str name: The name of the extension.
        :param 'CloudServiceExtensionPropertiesResponseArgs' properties: Extension Properties.
        """
        if name is not None:
            pulumi.set(__self__, "name", name)
        if properties is not None:
            pulumi.set(__self__, "properties", properties)

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        The name of the extension.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def properties(self) -> Optional['outputs.CloudServiceExtensionPropertiesResponse']:
        """
        Extension Properties.
        """
        return pulumi.get(self, "properties")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class LoadBalancerConfigurationPropertiesResponse(dict):
    def __init__(__self__, *,
                 frontend_ip_configurations: Optional[Sequence['outputs.LoadBalancerFrontendIPConfigurationResponse']] = None):
        """
        :param Sequence['LoadBalancerFrontendIPConfigurationResponseArgs'] frontend_ip_configurations: List of IP
        """
        if frontend_ip_configurations is not None:
            pulumi.set(__self__, "frontend_ip_configurations", frontend_ip_configurations)

    @property
    @pulumi.getter(name="frontendIPConfigurations")
    def frontend_ip_configurations(self) -> Optional[Sequence['outputs.LoadBalancerFrontendIPConfigurationResponse']]:
        """
        List of IP
        """
        return pulumi.get(self, "frontend_ip_configurations")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class LoadBalancerConfigurationResponse(dict):
    """
    Describes the load balancer configuration.
    """
    def __init__(__self__, *,
                 name: Optional[str] = None,
                 properties: Optional['outputs.LoadBalancerConfigurationPropertiesResponse'] = None):
        """
        Describes the load balancer configuration.
        :param str name: Resource Name
        """
        if name is not None:
            pulumi.set(__self__, "name", name)
        if properties is not None:
            pulumi.set(__self__, "properties", properties)

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        Resource Name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def properties(self) -> Optional['outputs.LoadBalancerConfigurationPropertiesResponse']:
        return pulumi.get(self, "properties")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class LoadBalancerFrontendIPConfigurationPropertiesResponse(dict):
    """
    Describes a cloud service IP Configuration
    """
    def __init__(__self__, *,
                 private_ip_address: Optional[str] = None,
                 public_ip_address: Optional['outputs.SubResourceResponse'] = None,
                 subnet: Optional['outputs.SubResourceResponse'] = None):
        """
        Describes a cloud service IP Configuration
        :param str private_ip_address: The private IP address referenced by the cloud service.
        """
        if private_ip_address is not None:
            pulumi.set(__self__, "private_ip_address", private_ip_address)
        if public_ip_address is not None:
            pulumi.set(__self__, "public_ip_address", public_ip_address)
        if subnet is not None:
            pulumi.set(__self__, "subnet", subnet)

    @property
    @pulumi.getter(name="privateIPAddress")
    def private_ip_address(self) -> Optional[str]:
        """
        The private IP address referenced by the cloud service.
        """
        return pulumi.get(self, "private_ip_address")

    @property
    @pulumi.getter(name="publicIPAddress")
    def public_ip_address(self) -> Optional['outputs.SubResourceResponse']:
        return pulumi.get(self, "public_ip_address")

    @property
    @pulumi.getter
    def subnet(self) -> Optional['outputs.SubResourceResponse']:
        return pulumi.get(self, "subnet")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class LoadBalancerFrontendIPConfigurationResponse(dict):
    def __init__(__self__, *,
                 name: Optional[str] = None,
                 properties: Optional['outputs.LoadBalancerFrontendIPConfigurationPropertiesResponse'] = None):
        """
        :param 'LoadBalancerFrontendIPConfigurationPropertiesResponseArgs' properties: Describes a cloud service IP Configuration
        """
        if name is not None:
            pulumi.set(__self__, "name", name)
        if properties is not None:
            pulumi.set(__self__, "properties", properties)

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def properties(self) -> Optional['outputs.LoadBalancerFrontendIPConfigurationPropertiesResponse']:
        """
        Describes a cloud service IP Configuration
        """
        return pulumi.get(self, "properties")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class SubResourceResponse(dict):
    def __init__(__self__, *,
                 id: Optional[str] = None):
        """
        :param str id: Resource Id
        """
        if id is not None:
            pulumi.set(__self__, "id", id)

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        """
        Resource Id
        """
        return pulumi.get(self, "id")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

