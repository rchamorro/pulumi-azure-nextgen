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

__all__ = ['OpenShiftCluster']


class OpenShiftCluster(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 apiserver_profile: Optional[pulumi.Input[pulumi.InputType['APIServerProfileArgs']]] = None,
                 cluster_profile: Optional[pulumi.Input[pulumi.InputType['ClusterProfileArgs']]] = None,
                 console_profile: Optional[pulumi.Input[pulumi.InputType['ConsoleProfileArgs']]] = None,
                 ingress_profiles: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['IngressProfileArgs']]]]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 master_profile: Optional[pulumi.Input[pulumi.InputType['MasterProfileArgs']]] = None,
                 network_profile: Optional[pulumi.Input[pulumi.InputType['NetworkProfileArgs']]] = None,
                 provisioning_state: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 resource_name_: Optional[pulumi.Input[str]] = None,
                 service_principal_profile: Optional[pulumi.Input[pulumi.InputType['ServicePrincipalProfileArgs']]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 worker_profiles: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['WorkerProfileArgs']]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        OpenShiftCluster represents an Azure Red Hat OpenShift cluster.
        Latest API Version: 2020-04-30.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['APIServerProfileArgs']] apiserver_profile: The cluster API server profile.
        :param pulumi.Input[pulumi.InputType['ClusterProfileArgs']] cluster_profile: The cluster profile.
        :param pulumi.Input[pulumi.InputType['ConsoleProfileArgs']] console_profile: The console profile.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['IngressProfileArgs']]]] ingress_profiles: The cluster ingress profiles.
        :param pulumi.Input[str] location: The geo-location where the resource lives
        :param pulumi.Input[pulumi.InputType['MasterProfileArgs']] master_profile: The cluster master profile.
        :param pulumi.Input[pulumi.InputType['NetworkProfileArgs']] network_profile: The cluster network profile.
        :param pulumi.Input[str] provisioning_state: The cluster provisioning state (immutable).
        :param pulumi.Input[str] resource_group_name: The name of the resource group. The name is case insensitive.
        :param pulumi.Input[str] resource_name_: The name of the OpenShift cluster resource.
        :param pulumi.Input[pulumi.InputType['ServicePrincipalProfileArgs']] service_principal_profile: The cluster service principal profile.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['WorkerProfileArgs']]]] worker_profiles: The cluster worker profiles.
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

            __props__['apiserver_profile'] = apiserver_profile
            __props__['cluster_profile'] = cluster_profile
            __props__['console_profile'] = console_profile
            __props__['ingress_profiles'] = ingress_profiles
            if location is None and not opts.urn:
                raise TypeError("Missing required property 'location'")
            __props__['location'] = location
            __props__['master_profile'] = master_profile
            __props__['network_profile'] = network_profile
            __props__['provisioning_state'] = provisioning_state
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if resource_name_ is None and not opts.urn:
                raise TypeError("Missing required property 'resource_name_'")
            __props__['resource_name'] = resource_name_
            __props__['service_principal_profile'] = service_principal_profile
            __props__['tags'] = tags
            __props__['worker_profiles'] = worker_profiles
            __props__['name'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:redhatopenshift/v20200430:OpenShiftCluster"), pulumi.Alias(type_="azure-nextgen:redhatopenshift/v20210131preview:OpenShiftCluster")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(OpenShiftCluster, __self__).__init__(
            'azure-nextgen:redhatopenshift/latest:OpenShiftCluster',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'OpenShiftCluster':
        """
        Get an existing OpenShiftCluster resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return OpenShiftCluster(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="apiserverProfile")
    def apiserver_profile(self) -> pulumi.Output[Optional['outputs.APIServerProfileResponse']]:
        """
        The cluster API server profile.
        """
        return pulumi.get(self, "apiserver_profile")

    @property
    @pulumi.getter(name="clusterProfile")
    def cluster_profile(self) -> pulumi.Output[Optional['outputs.ClusterProfileResponse']]:
        """
        The cluster profile.
        """
        return pulumi.get(self, "cluster_profile")

    @property
    @pulumi.getter(name="consoleProfile")
    def console_profile(self) -> pulumi.Output[Optional['outputs.ConsoleProfileResponse']]:
        """
        The console profile.
        """
        return pulumi.get(self, "console_profile")

    @property
    @pulumi.getter(name="ingressProfiles")
    def ingress_profiles(self) -> pulumi.Output[Optional[Sequence['outputs.IngressProfileResponse']]]:
        """
        The cluster ingress profiles.
        """
        return pulumi.get(self, "ingress_profiles")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        The geo-location where the resource lives
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="masterProfile")
    def master_profile(self) -> pulumi.Output[Optional['outputs.MasterProfileResponse']]:
        """
        The cluster master profile.
        """
        return pulumi.get(self, "master_profile")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="networkProfile")
    def network_profile(self) -> pulumi.Output[Optional['outputs.NetworkProfileResponse']]:
        """
        The cluster network profile.
        """
        return pulumi.get(self, "network_profile")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[Optional[str]]:
        """
        The cluster provisioning state (immutable).
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="servicePrincipalProfile")
    def service_principal_profile(self) -> pulumi.Output[Optional['outputs.ServicePrincipalProfileResponse']]:
        """
        The cluster service principal profile.
        """
        return pulumi.get(self, "service_principal_profile")

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
    @pulumi.getter(name="workerProfiles")
    def worker_profiles(self) -> pulumi.Output[Optional[Sequence['outputs.WorkerProfileResponse']]]:
        """
        The cluster worker profiles.
        """
        return pulumi.get(self, "worker_profiles")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

