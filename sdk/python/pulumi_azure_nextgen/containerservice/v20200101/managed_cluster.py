# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from . import outputs
from ._inputs import *

__all__ = ['ManagedCluster']


class ManagedCluster(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 aad_profile: Optional[pulumi.Input[pulumi.InputType['ManagedClusterAADProfileArgs']]] = None,
                 addon_profiles: Optional[pulumi.Input[Mapping[str, pulumi.Input[pulumi.InputType['ManagedClusterAddonProfileArgs']]]]] = None,
                 agent_pool_profiles: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ManagedClusterAgentPoolProfileArgs']]]]] = None,
                 api_server_access_profile: Optional[pulumi.Input[pulumi.InputType['ManagedClusterAPIServerAccessProfileArgs']]] = None,
                 disk_encryption_set_id: Optional[pulumi.Input[str]] = None,
                 dns_prefix: Optional[pulumi.Input[str]] = None,
                 enable_pod_security_policy: Optional[pulumi.Input[bool]] = None,
                 enable_rbac: Optional[pulumi.Input[bool]] = None,
                 identity: Optional[pulumi.Input[pulumi.InputType['ManagedClusterIdentityArgs']]] = None,
                 identity_profile: Optional[pulumi.Input[Mapping[str, pulumi.Input[pulumi.InputType['ManagedClusterPropertiesIdentityProfileArgs']]]]] = None,
                 kubernetes_version: Optional[pulumi.Input[str]] = None,
                 linux_profile: Optional[pulumi.Input[pulumi.InputType['ContainerServiceLinuxProfileArgs']]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 network_profile: Optional[pulumi.Input[pulumi.InputType['ContainerServiceNetworkProfileArgs']]] = None,
                 node_resource_group: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 resource_name_: Optional[pulumi.Input[str]] = None,
                 service_principal_profile: Optional[pulumi.Input[pulumi.InputType['ManagedClusterServicePrincipalProfileArgs']]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 windows_profile: Optional[pulumi.Input[pulumi.InputType['ManagedClusterWindowsProfileArgs']]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Managed cluster.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['ManagedClusterAADProfileArgs']] aad_profile: Profile of Azure Active Directory configuration.
        :param pulumi.Input[Mapping[str, pulumi.Input[pulumi.InputType['ManagedClusterAddonProfileArgs']]]] addon_profiles: Profile of managed cluster add-on.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ManagedClusterAgentPoolProfileArgs']]]] agent_pool_profiles: Properties of the agent pool.
        :param pulumi.Input[pulumi.InputType['ManagedClusterAPIServerAccessProfileArgs']] api_server_access_profile: Access profile for managed cluster API server.
        :param pulumi.Input[str] disk_encryption_set_id: ResourceId of the disk encryption set to use for enabling encryption at rest.
        :param pulumi.Input[str] dns_prefix: DNS prefix specified when creating the managed cluster.
        :param pulumi.Input[bool] enable_pod_security_policy: (DEPRECATING) Whether to enable Kubernetes pod security policy (preview). This feature is set for removal on October 15th, 2020. Learn more at aka.ms/aks/azpodpolicy.
        :param pulumi.Input[bool] enable_rbac: Whether to enable Kubernetes Role-Based Access Control.
        :param pulumi.Input[pulumi.InputType['ManagedClusterIdentityArgs']] identity: The identity of the managed cluster, if configured.
        :param pulumi.Input[Mapping[str, pulumi.Input[pulumi.InputType['ManagedClusterPropertiesIdentityProfileArgs']]]] identity_profile: Identities associated with the cluster.
        :param pulumi.Input[str] kubernetes_version: Version of Kubernetes specified when creating the managed cluster.
        :param pulumi.Input[pulumi.InputType['ContainerServiceLinuxProfileArgs']] linux_profile: Profile for Linux VMs in the container service cluster.
        :param pulumi.Input[str] location: Resource location
        :param pulumi.Input[pulumi.InputType['ContainerServiceNetworkProfileArgs']] network_profile: Profile of network configuration.
        :param pulumi.Input[str] node_resource_group: Name of the resource group containing agent pool nodes.
        :param pulumi.Input[str] resource_group_name: The name of the resource group.
        :param pulumi.Input[str] resource_name_: The name of the managed cluster resource.
        :param pulumi.Input[pulumi.InputType['ManagedClusterServicePrincipalProfileArgs']] service_principal_profile: Information about a service principal identity for the cluster to use for manipulating Azure APIs.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags
        :param pulumi.Input[pulumi.InputType['ManagedClusterWindowsProfileArgs']] windows_profile: Profile for Windows VMs in the container service cluster.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            __props__['aad_profile'] = aad_profile
            __props__['addon_profiles'] = addon_profiles
            __props__['agent_pool_profiles'] = agent_pool_profiles
            __props__['api_server_access_profile'] = api_server_access_profile
            __props__['disk_encryption_set_id'] = disk_encryption_set_id
            __props__['dns_prefix'] = dns_prefix
            __props__['enable_pod_security_policy'] = enable_pod_security_policy
            __props__['enable_rbac'] = enable_rbac
            __props__['identity'] = identity
            __props__['identity_profile'] = identity_profile
            __props__['kubernetes_version'] = kubernetes_version
            __props__['linux_profile'] = linux_profile
            if location is None:
                raise TypeError("Missing required property 'location'")
            __props__['location'] = location
            __props__['network_profile'] = network_profile
            __props__['node_resource_group'] = node_resource_group
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if resource_name_ is None:
                raise TypeError("Missing required property 'resource_name_'")
            __props__['resource_name'] = resource_name_
            __props__['service_principal_profile'] = service_principal_profile
            __props__['tags'] = tags
            __props__['windows_profile'] = windows_profile
            __props__['fqdn'] = None
            __props__['max_agent_pools'] = None
            __props__['name'] = None
            __props__['private_fqdn'] = None
            __props__['provisioning_state'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:containerservice/latest:ManagedCluster"), pulumi.Alias(type_="azure-nextgen:containerservice/v20170831:ManagedCluster"), pulumi.Alias(type_="azure-nextgen:containerservice/v20180331:ManagedCluster"), pulumi.Alias(type_="azure-nextgen:containerservice/v20180801preview:ManagedCluster"), pulumi.Alias(type_="azure-nextgen:containerservice/v20190201:ManagedCluster"), pulumi.Alias(type_="azure-nextgen:containerservice/v20190401:ManagedCluster"), pulumi.Alias(type_="azure-nextgen:containerservice/v20190601:ManagedCluster"), pulumi.Alias(type_="azure-nextgen:containerservice/v20190801:ManagedCluster"), pulumi.Alias(type_="azure-nextgen:containerservice/v20191001:ManagedCluster"), pulumi.Alias(type_="azure-nextgen:containerservice/v20191101:ManagedCluster"), pulumi.Alias(type_="azure-nextgen:containerservice/v20200201:ManagedCluster"), pulumi.Alias(type_="azure-nextgen:containerservice/v20200301:ManagedCluster"), pulumi.Alias(type_="azure-nextgen:containerservice/v20200401:ManagedCluster"), pulumi.Alias(type_="azure-nextgen:containerservice/v20200601:ManagedCluster"), pulumi.Alias(type_="azure-nextgen:containerservice/v20200701:ManagedCluster"), pulumi.Alias(type_="azure-nextgen:containerservice/v20200901:ManagedCluster"), pulumi.Alias(type_="azure-nextgen:containerservice/v20201101:ManagedCluster")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(ManagedCluster, __self__).__init__(
            'azure-nextgen:containerservice/v20200101:ManagedCluster',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'ManagedCluster':
        """
        Get an existing ManagedCluster resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return ManagedCluster(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="aadProfile")
    def aad_profile(self) -> pulumi.Output[Optional['outputs.ManagedClusterAADProfileResponse']]:
        """
        Profile of Azure Active Directory configuration.
        """
        return pulumi.get(self, "aad_profile")

    @property
    @pulumi.getter(name="addonProfiles")
    def addon_profiles(self) -> pulumi.Output[Optional[Mapping[str, 'outputs.ManagedClusterAddonProfileResponse']]]:
        """
        Profile of managed cluster add-on.
        """
        return pulumi.get(self, "addon_profiles")

    @property
    @pulumi.getter(name="agentPoolProfiles")
    def agent_pool_profiles(self) -> pulumi.Output[Optional[Sequence['outputs.ManagedClusterAgentPoolProfileResponse']]]:
        """
        Properties of the agent pool.
        """
        return pulumi.get(self, "agent_pool_profiles")

    @property
    @pulumi.getter(name="apiServerAccessProfile")
    def api_server_access_profile(self) -> pulumi.Output[Optional['outputs.ManagedClusterAPIServerAccessProfileResponse']]:
        """
        Access profile for managed cluster API server.
        """
        return pulumi.get(self, "api_server_access_profile")

    @property
    @pulumi.getter(name="diskEncryptionSetID")
    def disk_encryption_set_id(self) -> pulumi.Output[Optional[str]]:
        """
        ResourceId of the disk encryption set to use for enabling encryption at rest.
        """
        return pulumi.get(self, "disk_encryption_set_id")

    @property
    @pulumi.getter(name="dnsPrefix")
    def dns_prefix(self) -> pulumi.Output[Optional[str]]:
        """
        DNS prefix specified when creating the managed cluster.
        """
        return pulumi.get(self, "dns_prefix")

    @property
    @pulumi.getter(name="enablePodSecurityPolicy")
    def enable_pod_security_policy(self) -> pulumi.Output[Optional[bool]]:
        """
        (DEPRECATING) Whether to enable Kubernetes pod security policy (preview). This feature is set for removal on October 15th, 2020. Learn more at aka.ms/aks/azpodpolicy.
        """
        return pulumi.get(self, "enable_pod_security_policy")

    @property
    @pulumi.getter(name="enableRBAC")
    def enable_rbac(self) -> pulumi.Output[Optional[bool]]:
        """
        Whether to enable Kubernetes Role-Based Access Control.
        """
        return pulumi.get(self, "enable_rbac")

    @property
    @pulumi.getter
    def fqdn(self) -> pulumi.Output[str]:
        """
        FQDN for the master pool.
        """
        return pulumi.get(self, "fqdn")

    @property
    @pulumi.getter
    def identity(self) -> pulumi.Output[Optional['outputs.ManagedClusterIdentityResponse']]:
        """
        The identity of the managed cluster, if configured.
        """
        return pulumi.get(self, "identity")

    @property
    @pulumi.getter(name="identityProfile")
    def identity_profile(self) -> pulumi.Output[Optional[Mapping[str, 'outputs.ManagedClusterPropertiesResponseIdentityProfile']]]:
        """
        Identities associated with the cluster.
        """
        return pulumi.get(self, "identity_profile")

    @property
    @pulumi.getter(name="kubernetesVersion")
    def kubernetes_version(self) -> pulumi.Output[Optional[str]]:
        """
        Version of Kubernetes specified when creating the managed cluster.
        """
        return pulumi.get(self, "kubernetes_version")

    @property
    @pulumi.getter(name="linuxProfile")
    def linux_profile(self) -> pulumi.Output[Optional['outputs.ContainerServiceLinuxProfileResponse']]:
        """
        Profile for Linux VMs in the container service cluster.
        """
        return pulumi.get(self, "linux_profile")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        Resource location
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="maxAgentPools")
    def max_agent_pools(self) -> pulumi.Output[int]:
        """
        The max number of agent pools for the managed cluster.
        """
        return pulumi.get(self, "max_agent_pools")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="networkProfile")
    def network_profile(self) -> pulumi.Output[Optional['outputs.ContainerServiceNetworkProfileResponse']]:
        """
        Profile of network configuration.
        """
        return pulumi.get(self, "network_profile")

    @property
    @pulumi.getter(name="nodeResourceGroup")
    def node_resource_group(self) -> pulumi.Output[Optional[str]]:
        """
        Name of the resource group containing agent pool nodes.
        """
        return pulumi.get(self, "node_resource_group")

    @property
    @pulumi.getter(name="privateFQDN")
    def private_fqdn(self) -> pulumi.Output[str]:
        """
        FQDN of private cluster.
        """
        return pulumi.get(self, "private_fqdn")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        The current deployment or provisioning state, which only appears in the response.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="servicePrincipalProfile")
    def service_principal_profile(self) -> pulumi.Output[Optional['outputs.ManagedClusterServicePrincipalProfileResponse']]:
        """
        Information about a service principal identity for the cluster to use for manipulating Azure APIs.
        """
        return pulumi.get(self, "service_principal_profile")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Resource tags
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Resource type
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="windowsProfile")
    def windows_profile(self) -> pulumi.Output[Optional['outputs.ManagedClusterWindowsProfileResponse']]:
        """
        Profile for Windows VMs in the container service cluster.
        """
        return pulumi.get(self, "windows_profile")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

