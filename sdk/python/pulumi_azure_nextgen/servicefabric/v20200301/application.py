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

__all__ = ['Application']


class Application(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 application_name: Optional[pulumi.Input[str]] = None,
                 cluster_name: Optional[pulumi.Input[str]] = None,
                 identity: Optional[pulumi.Input[pulumi.InputType['ManagedIdentityArgs']]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 managed_identities: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ApplicationUserAssignedIdentityArgs']]]]] = None,
                 maximum_nodes: Optional[pulumi.Input[float]] = None,
                 metrics: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ApplicationMetricDescriptionArgs']]]]] = None,
                 minimum_nodes: Optional[pulumi.Input[float]] = None,
                 parameters: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 remove_application_capacity: Optional[pulumi.Input[bool]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 type_name: Optional[pulumi.Input[str]] = None,
                 type_version: Optional[pulumi.Input[str]] = None,
                 upgrade_policy: Optional[pulumi.Input[pulumi.InputType['ApplicationUpgradePolicyArgs']]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        The application resource.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] application_name: The name of the application resource.
        :param pulumi.Input[str] cluster_name: The name of the cluster resource.
        :param pulumi.Input[pulumi.InputType['ManagedIdentityArgs']] identity: Describes the managed identities for an Azure resource.
        :param pulumi.Input[str] location: It will be deprecated in New API, resource location depends on the parent resource.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ApplicationUserAssignedIdentityArgs']]]] managed_identities: List of user assigned identities for the application, each mapped to a friendly name.
        :param pulumi.Input[float] maximum_nodes: The maximum number of nodes where Service Fabric will reserve capacity for this application. Note that this does not mean that the services of this application will be placed on all of those nodes. By default, the value of this property is zero and it means that the services can be placed on any node.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ApplicationMetricDescriptionArgs']]]] metrics: List of application capacity metric description.
        :param pulumi.Input[float] minimum_nodes: The minimum number of nodes where Service Fabric will reserve capacity for this application. Note that this does not mean that the services of this application will be placed on all of those nodes. If this property is set to zero, no capacity will be reserved. The value of this property cannot be more than the value of the MaximumNodes property.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] parameters: List of application parameters with overridden values from their default values specified in the application manifest.
        :param pulumi.Input[bool] remove_application_capacity: Remove the current application capacity settings.
        :param pulumi.Input[str] resource_group_name: The name of the resource group.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Azure resource tags.
        :param pulumi.Input[str] type_name: The application type name as defined in the application manifest.
        :param pulumi.Input[str] type_version: The version of the application type as defined in the application manifest.
        :param pulumi.Input[pulumi.InputType['ApplicationUpgradePolicyArgs']] upgrade_policy: Describes the policy for a monitored application upgrade.
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

            if application_name is None and not opts.urn:
                raise TypeError("Missing required property 'application_name'")
            __props__['application_name'] = application_name
            if cluster_name is None and not opts.urn:
                raise TypeError("Missing required property 'cluster_name'")
            __props__['cluster_name'] = cluster_name
            __props__['identity'] = identity
            __props__['location'] = location
            __props__['managed_identities'] = managed_identities
            if maximum_nodes is None:
                maximum_nodes = 0
            __props__['maximum_nodes'] = maximum_nodes
            __props__['metrics'] = metrics
            __props__['minimum_nodes'] = minimum_nodes
            __props__['parameters'] = parameters
            __props__['remove_application_capacity'] = remove_application_capacity
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['tags'] = tags
            __props__['type_name'] = type_name
            __props__['type_version'] = type_version
            __props__['upgrade_policy'] = upgrade_policy
            __props__['etag'] = None
            __props__['name'] = None
            __props__['provisioning_state'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:servicefabric/latest:Application"), pulumi.Alias(type_="azure-nextgen:servicefabric/v20170701preview:Application"), pulumi.Alias(type_="azure-nextgen:servicefabric/v20190301:Application"), pulumi.Alias(type_="azure-nextgen:servicefabric/v20190301preview:Application"), pulumi.Alias(type_="azure-nextgen:servicefabric/v20190601preview:Application"), pulumi.Alias(type_="azure-nextgen:servicefabric/v20191101preview:Application")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(Application, __self__).__init__(
            'azure-nextgen:servicefabric/v20200301:Application',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Application':
        """
        Get an existing Application resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return Application(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def etag(self) -> pulumi.Output[str]:
        """
        Azure resource etag.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter
    def identity(self) -> pulumi.Output[Optional['outputs.ManagedIdentityResponse']]:
        """
        Describes the managed identities for an Azure resource.
        """
        return pulumi.get(self, "identity")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[Optional[str]]:
        """
        It will be deprecated in New API, resource location depends on the parent resource.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="managedIdentities")
    def managed_identities(self) -> pulumi.Output[Optional[Sequence['outputs.ApplicationUserAssignedIdentityResponse']]]:
        """
        List of user assigned identities for the application, each mapped to a friendly name.
        """
        return pulumi.get(self, "managed_identities")

    @property
    @pulumi.getter(name="maximumNodes")
    def maximum_nodes(self) -> pulumi.Output[Optional[float]]:
        """
        The maximum number of nodes where Service Fabric will reserve capacity for this application. Note that this does not mean that the services of this application will be placed on all of those nodes. By default, the value of this property is zero and it means that the services can be placed on any node.
        """
        return pulumi.get(self, "maximum_nodes")

    @property
    @pulumi.getter
    def metrics(self) -> pulumi.Output[Optional[Sequence['outputs.ApplicationMetricDescriptionResponse']]]:
        """
        List of application capacity metric description.
        """
        return pulumi.get(self, "metrics")

    @property
    @pulumi.getter(name="minimumNodes")
    def minimum_nodes(self) -> pulumi.Output[Optional[float]]:
        """
        The minimum number of nodes where Service Fabric will reserve capacity for this application. Note that this does not mean that the services of this application will be placed on all of those nodes. If this property is set to zero, no capacity will be reserved. The value of this property cannot be more than the value of the MaximumNodes property.
        """
        return pulumi.get(self, "minimum_nodes")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Azure resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def parameters(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        List of application parameters with overridden values from their default values specified in the application manifest.
        """
        return pulumi.get(self, "parameters")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        The current deployment or provisioning state, which only appears in the response
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="removeApplicationCapacity")
    def remove_application_capacity(self) -> pulumi.Output[Optional[bool]]:
        """
        Remove the current application capacity settings.
        """
        return pulumi.get(self, "remove_application_capacity")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Azure resource tags.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Azure resource type.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="typeName")
    def type_name(self) -> pulumi.Output[Optional[str]]:
        """
        The application type name as defined in the application manifest.
        """
        return pulumi.get(self, "type_name")

    @property
    @pulumi.getter(name="typeVersion")
    def type_version(self) -> pulumi.Output[Optional[str]]:
        """
        The version of the application type as defined in the application manifest.
        """
        return pulumi.get(self, "type_version")

    @property
    @pulumi.getter(name="upgradePolicy")
    def upgrade_policy(self) -> pulumi.Output[Optional['outputs.ApplicationUpgradePolicyResponse']]:
        """
        Describes the policy for a monitored application upgrade.
        """
        return pulumi.get(self, "upgrade_policy")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

