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

__all__ = ['Workspace']


class Workspace(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 babylon_configuration: Optional[pulumi.Input[pulumi.InputType['BabylonConfigurationArgs']]] = None,
                 connectivity_endpoints: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 default_data_lake_storage: Optional[pulumi.Input[pulumi.InputType['DataLakeStorageAccountDetailsArgs']]] = None,
                 encryption: Optional[pulumi.Input[pulumi.InputType['EncryptionDetailsArgs']]] = None,
                 identity: Optional[pulumi.Input[pulumi.InputType['ManagedIdentityArgs']]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 managed_resource_group_name: Optional[pulumi.Input[str]] = None,
                 managed_virtual_network: Optional[pulumi.Input[str]] = None,
                 managed_virtual_network_settings: Optional[pulumi.Input[pulumi.InputType['ManagedVirtualNetworkSettingsArgs']]] = None,
                 private_endpoint_connections: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['PrivateEndpointConnectionArgs']]]]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 sql_administrator_login: Optional[pulumi.Input[str]] = None,
                 sql_administrator_login_password: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 virtual_network_profile: Optional[pulumi.Input[pulumi.InputType['VirtualNetworkProfileArgs']]] = None,
                 workspace_name: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        A workspace

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['BabylonConfigurationArgs']] babylon_configuration: Babylon Configuration
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] connectivity_endpoints: Connectivity endpoints
        :param pulumi.Input[pulumi.InputType['DataLakeStorageAccountDetailsArgs']] default_data_lake_storage: Workspace default data lake storage account details
        :param pulumi.Input[pulumi.InputType['EncryptionDetailsArgs']] encryption: The encryption details of the workspace
        :param pulumi.Input[pulumi.InputType['ManagedIdentityArgs']] identity: Identity of the workspace
        :param pulumi.Input[str] location: The geo-location where the resource lives
        :param pulumi.Input[str] managed_resource_group_name: Workspace managed resource group. The resource group name uniquely identifies the resource group within the user subscriptionId. The resource group name must be no longer than 90 characters long, and must be alphanumeric characters (Char.IsLetterOrDigit()) and '-', '_', '(', ')' and'.'. Note that the name cannot end with '.'
        :param pulumi.Input[str] managed_virtual_network: Setting this to 'default' will ensure that all compute for this workspace is in a virtual network managed on behalf of the user.
        :param pulumi.Input[pulumi.InputType['ManagedVirtualNetworkSettingsArgs']] managed_virtual_network_settings: Managed Virtual Network Settings
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['PrivateEndpointConnectionArgs']]]] private_endpoint_connections: Private endpoint connections to the workspace
        :param pulumi.Input[str] resource_group_name: The name of the resource group. The name is case insensitive.
        :param pulumi.Input[str] sql_administrator_login: Login for workspace SQL active directory administrator
        :param pulumi.Input[str] sql_administrator_login_password: SQL administrator login password
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
        :param pulumi.Input[pulumi.InputType['VirtualNetworkProfileArgs']] virtual_network_profile: Virtual Network profile
        :param pulumi.Input[str] workspace_name: The name of the workspace
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

            __props__['babylon_configuration'] = babylon_configuration
            __props__['connectivity_endpoints'] = connectivity_endpoints
            __props__['default_data_lake_storage'] = default_data_lake_storage
            __props__['encryption'] = encryption
            __props__['identity'] = identity
            if location is None:
                raise TypeError("Missing required property 'location'")
            __props__['location'] = location
            __props__['managed_resource_group_name'] = managed_resource_group_name
            __props__['managed_virtual_network'] = managed_virtual_network
            __props__['managed_virtual_network_settings'] = managed_virtual_network_settings
            __props__['private_endpoint_connections'] = private_endpoint_connections
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['sql_administrator_login'] = sql_administrator_login
            __props__['sql_administrator_login_password'] = sql_administrator_login_password
            __props__['tags'] = tags
            __props__['virtual_network_profile'] = virtual_network_profile
            if workspace_name is None:
                raise TypeError("Missing required property 'workspace_name'")
            __props__['workspace_name'] = workspace_name
            __props__['extra_properties'] = None
            __props__['name'] = None
            __props__['provisioning_state'] = None
            __props__['type'] = None
            __props__['workspace_uid'] = None
        super(Workspace, __self__).__init__(
            'azure-nextgen:synapse/v20190601preview:Workspace',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Workspace':
        """
        Get an existing Workspace resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return Workspace(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="babylonConfiguration")
    def babylon_configuration(self) -> pulumi.Output[Optional['outputs.BabylonConfigurationResponse']]:
        """
        Babylon Configuration
        """
        return pulumi.get(self, "babylon_configuration")

    @property
    @pulumi.getter(name="connectivityEndpoints")
    def connectivity_endpoints(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Connectivity endpoints
        """
        return pulumi.get(self, "connectivity_endpoints")

    @property
    @pulumi.getter(name="defaultDataLakeStorage")
    def default_data_lake_storage(self) -> pulumi.Output[Optional['outputs.DataLakeStorageAccountDetailsResponse']]:
        """
        Workspace default data lake storage account details
        """
        return pulumi.get(self, "default_data_lake_storage")

    @property
    @pulumi.getter
    def encryption(self) -> pulumi.Output[Optional['outputs.EncryptionDetailsResponse']]:
        """
        The encryption details of the workspace
        """
        return pulumi.get(self, "encryption")

    @property
    @pulumi.getter(name="extraProperties")
    def extra_properties(self) -> pulumi.Output[Mapping[str, Any]]:
        """
        Workspace level configs and feature flags
        """
        return pulumi.get(self, "extra_properties")

    @property
    @pulumi.getter
    def identity(self) -> pulumi.Output[Optional['outputs.ManagedIdentityResponse']]:
        """
        Identity of the workspace
        """
        return pulumi.get(self, "identity")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        The geo-location where the resource lives
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="managedResourceGroupName")
    def managed_resource_group_name(self) -> pulumi.Output[Optional[str]]:
        """
        Workspace managed resource group. The resource group name uniquely identifies the resource group within the user subscriptionId. The resource group name must be no longer than 90 characters long, and must be alphanumeric characters (Char.IsLetterOrDigit()) and '-', '_', '(', ')' and'.'. Note that the name cannot end with '.'
        """
        return pulumi.get(self, "managed_resource_group_name")

    @property
    @pulumi.getter(name="managedVirtualNetwork")
    def managed_virtual_network(self) -> pulumi.Output[Optional[str]]:
        """
        Setting this to 'default' will ensure that all compute for this workspace is in a virtual network managed on behalf of the user.
        """
        return pulumi.get(self, "managed_virtual_network")

    @property
    @pulumi.getter(name="managedVirtualNetworkSettings")
    def managed_virtual_network_settings(self) -> pulumi.Output[Optional['outputs.ManagedVirtualNetworkSettingsResponse']]:
        """
        Managed Virtual Network Settings
        """
        return pulumi.get(self, "managed_virtual_network_settings")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="privateEndpointConnections")
    def private_endpoint_connections(self) -> pulumi.Output[Optional[Sequence['outputs.PrivateEndpointConnectionResponse']]]:
        """
        Private endpoint connections to the workspace
        """
        return pulumi.get(self, "private_endpoint_connections")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        Resource provisioning state
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="sqlAdministratorLogin")
    def sql_administrator_login(self) -> pulumi.Output[Optional[str]]:
        """
        Login for workspace SQL active directory administrator
        """
        return pulumi.get(self, "sql_administrator_login")

    @property
    @pulumi.getter(name="sqlAdministratorLoginPassword")
    def sql_administrator_login_password(self) -> pulumi.Output[Optional[str]]:
        """
        SQL administrator login password
        """
        return pulumi.get(self, "sql_administrator_login_password")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Resource tags.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="virtualNetworkProfile")
    def virtual_network_profile(self) -> pulumi.Output[Optional['outputs.VirtualNetworkProfileResponse']]:
        """
        Virtual Network profile
        """
        return pulumi.get(self, "virtual_network_profile")

    @property
    @pulumi.getter(name="workspaceUID")
    def workspace_uid(self) -> pulumi.Output[str]:
        """
        The workspace unique identifier
        """
        return pulumi.get(self, "workspace_uid")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

