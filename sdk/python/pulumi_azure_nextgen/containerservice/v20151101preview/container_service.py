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
from ._inputs import *

__all__ = ['ContainerService']


class ContainerService(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 agent_pool_profiles: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ContainerServiceAgentPoolProfileArgs']]]]] = None,
                 container_service_name: Optional[pulumi.Input[str]] = None,
                 diagnostics_profile: Optional[pulumi.Input[pulumi.InputType['ContainerServiceDiagnosticsProfileArgs']]] = None,
                 linux_profile: Optional[pulumi.Input[pulumi.InputType['ContainerServiceLinuxProfileArgs']]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 master_profile: Optional[pulumi.Input[pulumi.InputType['ContainerServiceMasterProfileArgs']]] = None,
                 orchestrator_profile: Optional[pulumi.Input[pulumi.InputType['ContainerServiceOrchestratorProfileArgs']]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 windows_profile: Optional[pulumi.Input[pulumi.InputType['ContainerServiceWindowsProfileArgs']]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Container service

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ContainerServiceAgentPoolProfileArgs']]]] agent_pool_profiles: Properties of agent pools
        :param pulumi.Input[str] container_service_name: The name of the container service within the given subscription and resource group.
        :param pulumi.Input[pulumi.InputType['ContainerServiceDiagnosticsProfileArgs']] diagnostics_profile: Properties for Diagnostic Agent
        :param pulumi.Input[pulumi.InputType['ContainerServiceLinuxProfileArgs']] linux_profile: Properties for Linux VMs
        :param pulumi.Input[str] location: Resource location
        :param pulumi.Input[pulumi.InputType['ContainerServiceMasterProfileArgs']] master_profile: Properties of master agents
        :param pulumi.Input[pulumi.InputType['ContainerServiceOrchestratorProfileArgs']] orchestrator_profile: Properties of orchestrator
        :param pulumi.Input[str] resource_group_name: The name of the resource group.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags
        :param pulumi.Input[pulumi.InputType['ContainerServiceWindowsProfileArgs']] windows_profile: Properties of Windows VMs
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

            if agent_pool_profiles is None and not opts.urn:
                raise TypeError("Missing required property 'agent_pool_profiles'")
            __props__['agent_pool_profiles'] = agent_pool_profiles
            if container_service_name is None and not opts.urn:
                raise TypeError("Missing required property 'container_service_name'")
            __props__['container_service_name'] = container_service_name
            __props__['diagnostics_profile'] = diagnostics_profile
            if linux_profile is None and not opts.urn:
                raise TypeError("Missing required property 'linux_profile'")
            __props__['linux_profile'] = linux_profile
            __props__['location'] = location
            if master_profile is None and not opts.urn:
                raise TypeError("Missing required property 'master_profile'")
            __props__['master_profile'] = master_profile
            __props__['orchestrator_profile'] = orchestrator_profile
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['tags'] = tags
            __props__['windows_profile'] = windows_profile
            __props__['name'] = None
            __props__['provisioning_state'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:containerservice/latest:ContainerService"), pulumi.Alias(type_="azure-nextgen:containerservice/v20160330:ContainerService"), pulumi.Alias(type_="azure-nextgen:containerservice/v20160930:ContainerService"), pulumi.Alias(type_="azure-nextgen:containerservice/v20170131:ContainerService")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(ContainerService, __self__).__init__(
            'azure-nextgen:containerservice/v20151101preview:ContainerService',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'ContainerService':
        """
        Get an existing ContainerService resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return ContainerService(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="agentPoolProfiles")
    def agent_pool_profiles(self) -> pulumi.Output[Sequence['outputs.ContainerServiceAgentPoolProfileResponse']]:
        """
        Properties of agent pools
        """
        return pulumi.get(self, "agent_pool_profiles")

    @property
    @pulumi.getter(name="diagnosticsProfile")
    def diagnostics_profile(self) -> pulumi.Output[Optional['outputs.ContainerServiceDiagnosticsProfileResponse']]:
        """
        Properties for Diagnostic Agent
        """
        return pulumi.get(self, "diagnostics_profile")

    @property
    @pulumi.getter(name="linuxProfile")
    def linux_profile(self) -> pulumi.Output['outputs.ContainerServiceLinuxProfileResponse']:
        """
        Properties for Linux VMs
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
    @pulumi.getter(name="masterProfile")
    def master_profile(self) -> pulumi.Output['outputs.ContainerServiceMasterProfileResponse']:
        """
        Properties of master agents
        """
        return pulumi.get(self, "master_profile")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="orchestratorProfile")
    def orchestrator_profile(self) -> pulumi.Output[Optional['outputs.ContainerServiceOrchestratorProfileResponse']]:
        """
        Properties of orchestrator
        """
        return pulumi.get(self, "orchestrator_profile")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        Gets the provisioning state, which only appears in the response.
        """
        return pulumi.get(self, "provisioning_state")

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
    def windows_profile(self) -> pulumi.Output[Optional['outputs.ContainerServiceWindowsProfileResponse']]:
        """
        Properties of Windows VMs
        """
        return pulumi.get(self, "windows_profile")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

