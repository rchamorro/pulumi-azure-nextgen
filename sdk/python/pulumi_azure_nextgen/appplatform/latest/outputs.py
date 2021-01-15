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
    'AppResourcePropertiesResponse',
    'BindingResourcePropertiesResponse',
    'CertificatePropertiesResponse',
    'ClusterResourcePropertiesResponse',
    'CustomDomainPropertiesResponse',
    'DeploymentInstanceResponse',
    'DeploymentResourcePropertiesResponse',
    'DeploymentSettingsResponse',
    'ManagedIdentityPropertiesResponse',
    'NetworkProfileResponse',
    'NetworkProfileResponseOutboundIPs',
    'PersistentDiskResponse',
    'SkuResponse',
    'TemporaryDiskResponse',
    'UserSourceInfoResponse',
]

@pulumi.output_type
class AppResourcePropertiesResponse(dict):
    """
    App resource properties payload
    """
    def __init__(__self__, *,
                 created_time: str,
                 provisioning_state: str,
                 url: str,
                 active_deployment_name: Optional[str] = None,
                 fqdn: Optional[str] = None,
                 https_only: Optional[bool] = None,
                 persistent_disk: Optional['outputs.PersistentDiskResponse'] = None,
                 public: Optional[bool] = None,
                 temporary_disk: Optional['outputs.TemporaryDiskResponse'] = None):
        """
        App resource properties payload
        :param str created_time: Date time when the resource is created
        :param str provisioning_state: Provisioning state of the App
        :param str url: URL of the App
        :param str active_deployment_name: Name of the active deployment of the App
        :param str fqdn: Fully qualified dns Name.
        :param bool https_only: Indicate if only https is allowed.
        :param 'PersistentDiskResponseArgs' persistent_disk: Persistent disk settings
        :param bool public: Indicates whether the App exposes public endpoint
        :param 'TemporaryDiskResponseArgs' temporary_disk: Temporary disk settings
        """
        pulumi.set(__self__, "created_time", created_time)
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        pulumi.set(__self__, "url", url)
        if active_deployment_name is not None:
            pulumi.set(__self__, "active_deployment_name", active_deployment_name)
        if fqdn is not None:
            pulumi.set(__self__, "fqdn", fqdn)
        if https_only is not None:
            pulumi.set(__self__, "https_only", https_only)
        if persistent_disk is not None:
            pulumi.set(__self__, "persistent_disk", persistent_disk)
        if public is not None:
            pulumi.set(__self__, "public", public)
        if temporary_disk is not None:
            pulumi.set(__self__, "temporary_disk", temporary_disk)

    @property
    @pulumi.getter(name="createdTime")
    def created_time(self) -> str:
        """
        Date time when the resource is created
        """
        return pulumi.get(self, "created_time")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        Provisioning state of the App
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter
    def url(self) -> str:
        """
        URL of the App
        """
        return pulumi.get(self, "url")

    @property
    @pulumi.getter(name="activeDeploymentName")
    def active_deployment_name(self) -> Optional[str]:
        """
        Name of the active deployment of the App
        """
        return pulumi.get(self, "active_deployment_name")

    @property
    @pulumi.getter
    def fqdn(self) -> Optional[str]:
        """
        Fully qualified dns Name.
        """
        return pulumi.get(self, "fqdn")

    @property
    @pulumi.getter(name="httpsOnly")
    def https_only(self) -> Optional[bool]:
        """
        Indicate if only https is allowed.
        """
        return pulumi.get(self, "https_only")

    @property
    @pulumi.getter(name="persistentDisk")
    def persistent_disk(self) -> Optional['outputs.PersistentDiskResponse']:
        """
        Persistent disk settings
        """
        return pulumi.get(self, "persistent_disk")

    @property
    @pulumi.getter
    def public(self) -> Optional[bool]:
        """
        Indicates whether the App exposes public endpoint
        """
        return pulumi.get(self, "public")

    @property
    @pulumi.getter(name="temporaryDisk")
    def temporary_disk(self) -> Optional['outputs.TemporaryDiskResponse']:
        """
        Temporary disk settings
        """
        return pulumi.get(self, "temporary_disk")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class BindingResourcePropertiesResponse(dict):
    """
    Binding resource properties payload
    """
    def __init__(__self__, *,
                 created_at: str,
                 generated_properties: str,
                 resource_name: str,
                 resource_type: str,
                 updated_at: str,
                 binding_parameters: Optional[Mapping[str, Any]] = None,
                 key: Optional[str] = None,
                 resource_id: Optional[str] = None):
        """
        Binding resource properties payload
        :param str created_at: Creation time of the Binding resource
        :param str generated_properties: The generated Spring Boot property file for this binding. The secret will be deducted.
        :param str resource_name: The name of the bound resource
        :param str resource_type: The standard Azure resource type of the bound resource
        :param str updated_at: Update time of the Binding resource
        :param Mapping[str, Any] binding_parameters: Binding parameters of the Binding resource
        :param str key: The key of the bound resource
        :param str resource_id: The Azure resource id of the bound resource
        """
        pulumi.set(__self__, "created_at", created_at)
        pulumi.set(__self__, "generated_properties", generated_properties)
        pulumi.set(__self__, "resource_name", resource_name)
        pulumi.set(__self__, "resource_type", resource_type)
        pulumi.set(__self__, "updated_at", updated_at)
        if binding_parameters is not None:
            pulumi.set(__self__, "binding_parameters", binding_parameters)
        if key is not None:
            pulumi.set(__self__, "key", key)
        if resource_id is not None:
            pulumi.set(__self__, "resource_id", resource_id)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> str:
        """
        Creation time of the Binding resource
        """
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter(name="generatedProperties")
    def generated_properties(self) -> str:
        """
        The generated Spring Boot property file for this binding. The secret will be deducted.
        """
        return pulumi.get(self, "generated_properties")

    @property
    @pulumi.getter(name="resourceName")
    def resource_name(self) -> str:
        """
        The name of the bound resource
        """
        return pulumi.get(self, "resource_name")

    @property
    @pulumi.getter(name="resourceType")
    def resource_type(self) -> str:
        """
        The standard Azure resource type of the bound resource
        """
        return pulumi.get(self, "resource_type")

    @property
    @pulumi.getter(name="updatedAt")
    def updated_at(self) -> str:
        """
        Update time of the Binding resource
        """
        return pulumi.get(self, "updated_at")

    @property
    @pulumi.getter(name="bindingParameters")
    def binding_parameters(self) -> Optional[Mapping[str, Any]]:
        """
        Binding parameters of the Binding resource
        """
        return pulumi.get(self, "binding_parameters")

    @property
    @pulumi.getter
    def key(self) -> Optional[str]:
        """
        The key of the bound resource
        """
        return pulumi.get(self, "key")

    @property
    @pulumi.getter(name="resourceId")
    def resource_id(self) -> Optional[str]:
        """
        The Azure resource id of the bound resource
        """
        return pulumi.get(self, "resource_id")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class CertificatePropertiesResponse(dict):
    """
    Certificate resource payload.
    """
    def __init__(__self__, *,
                 activate_date: str,
                 dns_names: Sequence[str],
                 expiration_date: str,
                 issued_date: str,
                 issuer: str,
                 key_vault_cert_name: str,
                 subject_name: str,
                 thumbprint: str,
                 vault_uri: str,
                 cert_version: Optional[str] = None):
        """
        Certificate resource payload.
        :param str activate_date: The activate date of certificate.
        :param Sequence[str] dns_names: The domain list of certificate.
        :param str expiration_date: The expiration date of certificate.
        :param str issued_date: The issue date of certificate.
        :param str issuer: The issuer of certificate.
        :param str key_vault_cert_name: The certificate name of key vault.
        :param str subject_name: The subject name of certificate.
        :param str thumbprint: The thumbprint of certificate.
        :param str vault_uri: The vault uri of user key vault.
        :param str cert_version: The certificate version of key vault.
        """
        pulumi.set(__self__, "activate_date", activate_date)
        pulumi.set(__self__, "dns_names", dns_names)
        pulumi.set(__self__, "expiration_date", expiration_date)
        pulumi.set(__self__, "issued_date", issued_date)
        pulumi.set(__self__, "issuer", issuer)
        pulumi.set(__self__, "key_vault_cert_name", key_vault_cert_name)
        pulumi.set(__self__, "subject_name", subject_name)
        pulumi.set(__self__, "thumbprint", thumbprint)
        pulumi.set(__self__, "vault_uri", vault_uri)
        if cert_version is not None:
            pulumi.set(__self__, "cert_version", cert_version)

    @property
    @pulumi.getter(name="activateDate")
    def activate_date(self) -> str:
        """
        The activate date of certificate.
        """
        return pulumi.get(self, "activate_date")

    @property
    @pulumi.getter(name="dnsNames")
    def dns_names(self) -> Sequence[str]:
        """
        The domain list of certificate.
        """
        return pulumi.get(self, "dns_names")

    @property
    @pulumi.getter(name="expirationDate")
    def expiration_date(self) -> str:
        """
        The expiration date of certificate.
        """
        return pulumi.get(self, "expiration_date")

    @property
    @pulumi.getter(name="issuedDate")
    def issued_date(self) -> str:
        """
        The issue date of certificate.
        """
        return pulumi.get(self, "issued_date")

    @property
    @pulumi.getter
    def issuer(self) -> str:
        """
        The issuer of certificate.
        """
        return pulumi.get(self, "issuer")

    @property
    @pulumi.getter(name="keyVaultCertName")
    def key_vault_cert_name(self) -> str:
        """
        The certificate name of key vault.
        """
        return pulumi.get(self, "key_vault_cert_name")

    @property
    @pulumi.getter(name="subjectName")
    def subject_name(self) -> str:
        """
        The subject name of certificate.
        """
        return pulumi.get(self, "subject_name")

    @property
    @pulumi.getter
    def thumbprint(self) -> str:
        """
        The thumbprint of certificate.
        """
        return pulumi.get(self, "thumbprint")

    @property
    @pulumi.getter(name="vaultUri")
    def vault_uri(self) -> str:
        """
        The vault uri of user key vault.
        """
        return pulumi.get(self, "vault_uri")

    @property
    @pulumi.getter(name="certVersion")
    def cert_version(self) -> Optional[str]:
        """
        The certificate version of key vault.
        """
        return pulumi.get(self, "cert_version")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ClusterResourcePropertiesResponse(dict):
    """
    Service properties payload
    """
    def __init__(__self__, *,
                 provisioning_state: str,
                 service_id: str,
                 version: int,
                 network_profile: Optional['outputs.NetworkProfileResponse'] = None):
        """
        Service properties payload
        :param str provisioning_state: Provisioning state of the Service
        :param str service_id: ServiceInstanceEntity GUID which uniquely identifies a created resource
        :param int version: Version of the Service
        :param 'NetworkProfileResponseArgs' network_profile: Network profile of the Service
        """
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        pulumi.set(__self__, "service_id", service_id)
        pulumi.set(__self__, "version", version)
        if network_profile is not None:
            pulumi.set(__self__, "network_profile", network_profile)

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        Provisioning state of the Service
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="serviceId")
    def service_id(self) -> str:
        """
        ServiceInstanceEntity GUID which uniquely identifies a created resource
        """
        return pulumi.get(self, "service_id")

    @property
    @pulumi.getter
    def version(self) -> int:
        """
        Version of the Service
        """
        return pulumi.get(self, "version")

    @property
    @pulumi.getter(name="networkProfile")
    def network_profile(self) -> Optional['outputs.NetworkProfileResponse']:
        """
        Network profile of the Service
        """
        return pulumi.get(self, "network_profile")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class CustomDomainPropertiesResponse(dict):
    """
    Custom domain of app resource payload.
    """
    def __init__(__self__, *,
                 app_name: str,
                 cert_name: Optional[str] = None,
                 thumbprint: Optional[str] = None):
        """
        Custom domain of app resource payload.
        :param str app_name: The app name of domain.
        :param str cert_name: The bound certificate name of domain.
        :param str thumbprint: The thumbprint of bound certificate.
        """
        pulumi.set(__self__, "app_name", app_name)
        if cert_name is not None:
            pulumi.set(__self__, "cert_name", cert_name)
        if thumbprint is not None:
            pulumi.set(__self__, "thumbprint", thumbprint)

    @property
    @pulumi.getter(name="appName")
    def app_name(self) -> str:
        """
        The app name of domain.
        """
        return pulumi.get(self, "app_name")

    @property
    @pulumi.getter(name="certName")
    def cert_name(self) -> Optional[str]:
        """
        The bound certificate name of domain.
        """
        return pulumi.get(self, "cert_name")

    @property
    @pulumi.getter
    def thumbprint(self) -> Optional[str]:
        """
        The thumbprint of bound certificate.
        """
        return pulumi.get(self, "thumbprint")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class DeploymentInstanceResponse(dict):
    """
    Deployment instance payload
    """
    def __init__(__self__, *,
                 discovery_status: str,
                 name: str,
                 reason: str,
                 start_time: str,
                 status: str):
        """
        Deployment instance payload
        :param str discovery_status: Discovery status of the deployment instance
        :param str name: Name of the deployment instance
        :param str reason: Failed reason of the deployment instance
        :param str start_time: Start time of the deployment instance
        :param str status: Status of the deployment instance
        """
        pulumi.set(__self__, "discovery_status", discovery_status)
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "reason", reason)
        pulumi.set(__self__, "start_time", start_time)
        pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter(name="discoveryStatus")
    def discovery_status(self) -> str:
        """
        Discovery status of the deployment instance
        """
        return pulumi.get(self, "discovery_status")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Name of the deployment instance
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def reason(self) -> str:
        """
        Failed reason of the deployment instance
        """
        return pulumi.get(self, "reason")

    @property
    @pulumi.getter(name="startTime")
    def start_time(self) -> str:
        """
        Start time of the deployment instance
        """
        return pulumi.get(self, "start_time")

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        Status of the deployment instance
        """
        return pulumi.get(self, "status")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class DeploymentResourcePropertiesResponse(dict):
    """
    Deployment resource properties payload
    """
    def __init__(__self__, *,
                 active: bool,
                 app_name: str,
                 created_time: str,
                 instances: Sequence['outputs.DeploymentInstanceResponse'],
                 provisioning_state: str,
                 status: str,
                 deployment_settings: Optional['outputs.DeploymentSettingsResponse'] = None,
                 source: Optional['outputs.UserSourceInfoResponse'] = None):
        """
        Deployment resource properties payload
        :param bool active: Indicates whether the Deployment is active
        :param str app_name: App name of the deployment
        :param str created_time: Date time when the resource is created
        :param Sequence['DeploymentInstanceResponseArgs'] instances: Collection of instances belong to the Deployment
        :param str provisioning_state: Provisioning state of the Deployment
        :param str status: Status of the Deployment
        :param 'DeploymentSettingsResponseArgs' deployment_settings: Deployment settings of the Deployment
        :param 'UserSourceInfoResponseArgs' source: Uploaded source information of the deployment.
        """
        pulumi.set(__self__, "active", active)
        pulumi.set(__self__, "app_name", app_name)
        pulumi.set(__self__, "created_time", created_time)
        pulumi.set(__self__, "instances", instances)
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        pulumi.set(__self__, "status", status)
        if deployment_settings is not None:
            pulumi.set(__self__, "deployment_settings", deployment_settings)
        if source is not None:
            pulumi.set(__self__, "source", source)

    @property
    @pulumi.getter
    def active(self) -> bool:
        """
        Indicates whether the Deployment is active
        """
        return pulumi.get(self, "active")

    @property
    @pulumi.getter(name="appName")
    def app_name(self) -> str:
        """
        App name of the deployment
        """
        return pulumi.get(self, "app_name")

    @property
    @pulumi.getter(name="createdTime")
    def created_time(self) -> str:
        """
        Date time when the resource is created
        """
        return pulumi.get(self, "created_time")

    @property
    @pulumi.getter
    def instances(self) -> Sequence['outputs.DeploymentInstanceResponse']:
        """
        Collection of instances belong to the Deployment
        """
        return pulumi.get(self, "instances")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        Provisioning state of the Deployment
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        Status of the Deployment
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter(name="deploymentSettings")
    def deployment_settings(self) -> Optional['outputs.DeploymentSettingsResponse']:
        """
        Deployment settings of the Deployment
        """
        return pulumi.get(self, "deployment_settings")

    @property
    @pulumi.getter
    def source(self) -> Optional['outputs.UserSourceInfoResponse']:
        """
        Uploaded source information of the deployment.
        """
        return pulumi.get(self, "source")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class DeploymentSettingsResponse(dict):
    """
    Deployment settings payload
    """
    def __init__(__self__, *,
                 cpu: Optional[int] = None,
                 environment_variables: Optional[Mapping[str, str]] = None,
                 jvm_options: Optional[str] = None,
                 memory_in_gb: Optional[int] = None,
                 net_core_main_entry_path: Optional[str] = None,
                 runtime_version: Optional[str] = None):
        """
        Deployment settings payload
        :param int cpu: Required CPU, basic tier should be 1, standard tier should be in range (1, 4)
        :param Mapping[str, str] environment_variables: Collection of environment variables
        :param str jvm_options: JVM parameter
        :param int memory_in_gb: Required Memory size in GB, basic tier should be in range (1, 2), standard tier should be in range (1, 8)
        :param str net_core_main_entry_path: The path to the .NET executable relative to zip root
        :param str runtime_version: Runtime version
        """
        if cpu is None:
            cpu = 1
        if cpu is not None:
            pulumi.set(__self__, "cpu", cpu)
        if environment_variables is not None:
            pulumi.set(__self__, "environment_variables", environment_variables)
        if jvm_options is not None:
            pulumi.set(__self__, "jvm_options", jvm_options)
        if memory_in_gb is None:
            memory_in_gb = 1
        if memory_in_gb is not None:
            pulumi.set(__self__, "memory_in_gb", memory_in_gb)
        if net_core_main_entry_path is not None:
            pulumi.set(__self__, "net_core_main_entry_path", net_core_main_entry_path)
        if runtime_version is not None:
            pulumi.set(__self__, "runtime_version", runtime_version)

    @property
    @pulumi.getter
    def cpu(self) -> Optional[int]:
        """
        Required CPU, basic tier should be 1, standard tier should be in range (1, 4)
        """
        return pulumi.get(self, "cpu")

    @property
    @pulumi.getter(name="environmentVariables")
    def environment_variables(self) -> Optional[Mapping[str, str]]:
        """
        Collection of environment variables
        """
        return pulumi.get(self, "environment_variables")

    @property
    @pulumi.getter(name="jvmOptions")
    def jvm_options(self) -> Optional[str]:
        """
        JVM parameter
        """
        return pulumi.get(self, "jvm_options")

    @property
    @pulumi.getter(name="memoryInGB")
    def memory_in_gb(self) -> Optional[int]:
        """
        Required Memory size in GB, basic tier should be in range (1, 2), standard tier should be in range (1, 8)
        """
        return pulumi.get(self, "memory_in_gb")

    @property
    @pulumi.getter(name="netCoreMainEntryPath")
    def net_core_main_entry_path(self) -> Optional[str]:
        """
        The path to the .NET executable relative to zip root
        """
        return pulumi.get(self, "net_core_main_entry_path")

    @property
    @pulumi.getter(name="runtimeVersion")
    def runtime_version(self) -> Optional[str]:
        """
        Runtime version
        """
        return pulumi.get(self, "runtime_version")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ManagedIdentityPropertiesResponse(dict):
    """
    Managed identity properties retrieved from ARM request headers.
    """
    def __init__(__self__, *,
                 principal_id: Optional[str] = None,
                 tenant_id: Optional[str] = None,
                 type: Optional[str] = None):
        """
        Managed identity properties retrieved from ARM request headers.
        :param str principal_id: Principal Id
        :param str tenant_id: Tenant Id
        :param str type: Type of the managed identity
        """
        if principal_id is not None:
            pulumi.set(__self__, "principal_id", principal_id)
        if tenant_id is not None:
            pulumi.set(__self__, "tenant_id", tenant_id)
        if type is not None:
            pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="principalId")
    def principal_id(self) -> Optional[str]:
        """
        Principal Id
        """
        return pulumi.get(self, "principal_id")

    @property
    @pulumi.getter(name="tenantId")
    def tenant_id(self) -> Optional[str]:
        """
        Tenant Id
        """
        return pulumi.get(self, "tenant_id")

    @property
    @pulumi.getter
    def type(self) -> Optional[str]:
        """
        Type of the managed identity
        """
        return pulumi.get(self, "type")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class NetworkProfileResponse(dict):
    """
    Service network profile payload
    """
    def __init__(__self__, *,
                 outbound_ips: 'outputs.NetworkProfileResponseOutboundIPs',
                 app_network_resource_group: Optional[str] = None,
                 app_subnet_id: Optional[str] = None,
                 service_cidr: Optional[str] = None,
                 service_runtime_network_resource_group: Optional[str] = None,
                 service_runtime_subnet_id: Optional[str] = None):
        """
        Service network profile payload
        :param 'NetworkProfileResponseOutboundIPsArgs' outbound_ips: Desired outbound IP resources for Azure Spring Cloud instance.
        :param str app_network_resource_group: Name of the resource group containing network resources of Azure Spring Cloud Apps
        :param str app_subnet_id: Fully qualified resource Id of the subnet to host Azure Spring Cloud Apps
        :param str service_cidr: Azure Spring Cloud service reserved CIDR
        :param str service_runtime_network_resource_group: Name of the resource group containing network resources of Azure Spring Cloud Service Runtime
        :param str service_runtime_subnet_id: Fully qualified resource Id of the subnet to host Azure Spring Cloud Service Runtime
        """
        pulumi.set(__self__, "outbound_ips", outbound_ips)
        if app_network_resource_group is not None:
            pulumi.set(__self__, "app_network_resource_group", app_network_resource_group)
        if app_subnet_id is not None:
            pulumi.set(__self__, "app_subnet_id", app_subnet_id)
        if service_cidr is not None:
            pulumi.set(__self__, "service_cidr", service_cidr)
        if service_runtime_network_resource_group is not None:
            pulumi.set(__self__, "service_runtime_network_resource_group", service_runtime_network_resource_group)
        if service_runtime_subnet_id is not None:
            pulumi.set(__self__, "service_runtime_subnet_id", service_runtime_subnet_id)

    @property
    @pulumi.getter(name="outboundIPs")
    def outbound_ips(self) -> 'outputs.NetworkProfileResponseOutboundIPs':
        """
        Desired outbound IP resources for Azure Spring Cloud instance.
        """
        return pulumi.get(self, "outbound_ips")

    @property
    @pulumi.getter(name="appNetworkResourceGroup")
    def app_network_resource_group(self) -> Optional[str]:
        """
        Name of the resource group containing network resources of Azure Spring Cloud Apps
        """
        return pulumi.get(self, "app_network_resource_group")

    @property
    @pulumi.getter(name="appSubnetId")
    def app_subnet_id(self) -> Optional[str]:
        """
        Fully qualified resource Id of the subnet to host Azure Spring Cloud Apps
        """
        return pulumi.get(self, "app_subnet_id")

    @property
    @pulumi.getter(name="serviceCidr")
    def service_cidr(self) -> Optional[str]:
        """
        Azure Spring Cloud service reserved CIDR
        """
        return pulumi.get(self, "service_cidr")

    @property
    @pulumi.getter(name="serviceRuntimeNetworkResourceGroup")
    def service_runtime_network_resource_group(self) -> Optional[str]:
        """
        Name of the resource group containing network resources of Azure Spring Cloud Service Runtime
        """
        return pulumi.get(self, "service_runtime_network_resource_group")

    @property
    @pulumi.getter(name="serviceRuntimeSubnetId")
    def service_runtime_subnet_id(self) -> Optional[str]:
        """
        Fully qualified resource Id of the subnet to host Azure Spring Cloud Service Runtime
        """
        return pulumi.get(self, "service_runtime_subnet_id")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class NetworkProfileResponseOutboundIPs(dict):
    """
    Desired outbound IP resources for Azure Spring Cloud instance.
    """
    def __init__(__self__, *,
                 public_ips: Sequence[str]):
        """
        Desired outbound IP resources for Azure Spring Cloud instance.
        :param Sequence[str] public_ips: A list of public IP addresses.
        """
        pulumi.set(__self__, "public_ips", public_ips)

    @property
    @pulumi.getter(name="publicIPs")
    def public_ips(self) -> Sequence[str]:
        """
        A list of public IP addresses.
        """
        return pulumi.get(self, "public_ips")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class PersistentDiskResponse(dict):
    """
    Persistent disk payload
    """
    def __init__(__self__, *,
                 used_in_gb: int,
                 mount_path: Optional[str] = None,
                 size_in_gb: Optional[int] = None):
        """
        Persistent disk payload
        :param int used_in_gb: Size of the used persistent disk in GB
        :param str mount_path: Mount path of the persistent disk
        :param int size_in_gb: Size of the persistent disk in GB
        """
        pulumi.set(__self__, "used_in_gb", used_in_gb)
        if mount_path is not None:
            pulumi.set(__self__, "mount_path", mount_path)
        if size_in_gb is not None:
            pulumi.set(__self__, "size_in_gb", size_in_gb)

    @property
    @pulumi.getter(name="usedInGB")
    def used_in_gb(self) -> int:
        """
        Size of the used persistent disk in GB
        """
        return pulumi.get(self, "used_in_gb")

    @property
    @pulumi.getter(name="mountPath")
    def mount_path(self) -> Optional[str]:
        """
        Mount path of the persistent disk
        """
        return pulumi.get(self, "mount_path")

    @property
    @pulumi.getter(name="sizeInGB")
    def size_in_gb(self) -> Optional[int]:
        """
        Size of the persistent disk in GB
        """
        return pulumi.get(self, "size_in_gb")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class SkuResponse(dict):
    """
    Sku of Azure Spring Cloud
    """
    def __init__(__self__, *,
                 capacity: Optional[int] = None,
                 name: Optional[str] = None,
                 tier: Optional[str] = None):
        """
        Sku of Azure Spring Cloud
        :param int capacity: Current capacity of the target resource
        :param str name: Name of the Sku
        :param str tier: Tier of the Sku
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
        Current capacity of the target resource
        """
        return pulumi.get(self, "capacity")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        Name of the Sku
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def tier(self) -> Optional[str]:
        """
        Tier of the Sku
        """
        return pulumi.get(self, "tier")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class TemporaryDiskResponse(dict):
    """
    Temporary disk payload
    """
    def __init__(__self__, *,
                 mount_path: Optional[str] = None,
                 size_in_gb: Optional[int] = None):
        """
        Temporary disk payload
        :param str mount_path: Mount path of the temporary disk
        :param int size_in_gb: Size of the temporary disk in GB
        """
        if mount_path is not None:
            pulumi.set(__self__, "mount_path", mount_path)
        if size_in_gb is not None:
            pulumi.set(__self__, "size_in_gb", size_in_gb)

    @property
    @pulumi.getter(name="mountPath")
    def mount_path(self) -> Optional[str]:
        """
        Mount path of the temporary disk
        """
        return pulumi.get(self, "mount_path")

    @property
    @pulumi.getter(name="sizeInGB")
    def size_in_gb(self) -> Optional[int]:
        """
        Size of the temporary disk in GB
        """
        return pulumi.get(self, "size_in_gb")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class UserSourceInfoResponse(dict):
    """
    Source information for a deployment
    """
    def __init__(__self__, *,
                 artifact_selector: Optional[str] = None,
                 relative_path: Optional[str] = None,
                 type: Optional[str] = None,
                 version: Optional[str] = None):
        """
        Source information for a deployment
        :param str artifact_selector: Selector for the artifact to be used for the deployment for multi-module projects. This should be
               the relative path to the target module/project.
        :param str relative_path: Relative path of the storage which stores the source
        :param str type: Type of the source uploaded
        :param str version: Version of the source
        """
        if artifact_selector is not None:
            pulumi.set(__self__, "artifact_selector", artifact_selector)
        if relative_path is not None:
            pulumi.set(__self__, "relative_path", relative_path)
        if type is not None:
            pulumi.set(__self__, "type", type)
        if version is not None:
            pulumi.set(__self__, "version", version)

    @property
    @pulumi.getter(name="artifactSelector")
    def artifact_selector(self) -> Optional[str]:
        """
        Selector for the artifact to be used for the deployment for multi-module projects. This should be
        the relative path to the target module/project.
        """
        return pulumi.get(self, "artifact_selector")

    @property
    @pulumi.getter(name="relativePath")
    def relative_path(self) -> Optional[str]:
        """
        Relative path of the storage which stores the source
        """
        return pulumi.get(self, "relative_path")

    @property
    @pulumi.getter
    def type(self) -> Optional[str]:
        """
        Type of the source uploaded
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def version(self) -> Optional[str]:
        """
        Version of the source
        """
        return pulumi.get(self, "version")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


