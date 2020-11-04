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

__all__ = ['PrivateLinkService']


class PrivateLinkService(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 auto_approval: Optional[pulumi.Input[pulumi.InputType['PrivateLinkServicePropertiesAutoApprovalArgs']]] = None,
                 enable_proxy_protocol: Optional[pulumi.Input[bool]] = None,
                 fqdns: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 ip_configurations: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['PrivateLinkServiceIpConfigurationArgs']]]]] = None,
                 load_balancer_frontend_ip_configurations: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['FrontendIPConfigurationArgs']]]]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 service_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 visibility: Optional[pulumi.Input[pulumi.InputType['PrivateLinkServicePropertiesVisibilityArgs']]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Private link service resource.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['PrivateLinkServicePropertiesAutoApprovalArgs']] auto_approval: The auto-approval list of the private link service.
        :param pulumi.Input[bool] enable_proxy_protocol: Whether the private link service is enabled for proxy protocol or not.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] fqdns: The list of Fqdn.
        :param pulumi.Input[str] id: Resource ID.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['PrivateLinkServiceIpConfigurationArgs']]]] ip_configurations: An array of private link service IP configurations.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['FrontendIPConfigurationArgs']]]] load_balancer_frontend_ip_configurations: An array of references to the load balancer IP configurations.
        :param pulumi.Input[str] location: Resource location.
        :param pulumi.Input[str] resource_group_name: The name of the resource group.
        :param pulumi.Input[str] service_name: The name of the private link service.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
        :param pulumi.Input[pulumi.InputType['PrivateLinkServicePropertiesVisibilityArgs']] visibility: The visibility list of the private link service.
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

            __props__['auto_approval'] = auto_approval
            __props__['enable_proxy_protocol'] = enable_proxy_protocol
            __props__['fqdns'] = fqdns
            __props__['id'] = id
            __props__['ip_configurations'] = ip_configurations
            __props__['load_balancer_frontend_ip_configurations'] = load_balancer_frontend_ip_configurations
            __props__['location'] = location
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if service_name is None:
                raise TypeError("Missing required property 'service_name'")
            __props__['service_name'] = service_name
            __props__['tags'] = tags
            __props__['visibility'] = visibility
            __props__['alias'] = None
            __props__['etag'] = None
            __props__['name'] = None
            __props__['network_interfaces'] = None
            __props__['private_endpoint_connections'] = None
            __props__['provisioning_state'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:network/v20190401:PrivateLinkService"), pulumi.Alias(type_="azure-nextgen:network/v20190601:PrivateLinkService"), pulumi.Alias(type_="azure-nextgen:network/v20190701:PrivateLinkService"), pulumi.Alias(type_="azure-nextgen:network/v20190801:PrivateLinkService"), pulumi.Alias(type_="azure-nextgen:network/v20190901:PrivateLinkService"), pulumi.Alias(type_="azure-nextgen:network/v20191101:PrivateLinkService"), pulumi.Alias(type_="azure-nextgen:network/v20191201:PrivateLinkService"), pulumi.Alias(type_="azure-nextgen:network/v20200301:PrivateLinkService"), pulumi.Alias(type_="azure-nextgen:network/v20200401:PrivateLinkService"), pulumi.Alias(type_="azure-nextgen:network/v20200501:PrivateLinkService"), pulumi.Alias(type_="azure-nextgen:network/v20200601:PrivateLinkService"), pulumi.Alias(type_="azure-nextgen:network/v20200701:PrivateLinkService")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(PrivateLinkService, __self__).__init__(
            'azure-nextgen:network/latest:PrivateLinkService',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'PrivateLinkService':
        """
        Get an existing PrivateLinkService resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return PrivateLinkService(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def alias(self) -> pulumi.Output[str]:
        """
        The alias of the private link service.
        """
        return pulumi.get(self, "alias")

    @property
    @pulumi.getter(name="autoApproval")
    def auto_approval(self) -> pulumi.Output[Optional['outputs.PrivateLinkServicePropertiesResponseAutoApproval']]:
        """
        The auto-approval list of the private link service.
        """
        return pulumi.get(self, "auto_approval")

    @property
    @pulumi.getter(name="enableProxyProtocol")
    def enable_proxy_protocol(self) -> pulumi.Output[Optional[bool]]:
        """
        Whether the private link service is enabled for proxy protocol or not.
        """
        return pulumi.get(self, "enable_proxy_protocol")

    @property
    @pulumi.getter
    def etag(self) -> pulumi.Output[str]:
        """
        A unique read-only string that changes whenever the resource is updated.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter
    def fqdns(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        The list of Fqdn.
        """
        return pulumi.get(self, "fqdns")

    @property
    @pulumi.getter(name="ipConfigurations")
    def ip_configurations(self) -> pulumi.Output[Optional[Sequence['outputs.PrivateLinkServiceIpConfigurationResponse']]]:
        """
        An array of private link service IP configurations.
        """
        return pulumi.get(self, "ip_configurations")

    @property
    @pulumi.getter(name="loadBalancerFrontendIpConfigurations")
    def load_balancer_frontend_ip_configurations(self) -> pulumi.Output[Optional[Sequence['outputs.FrontendIPConfigurationResponse']]]:
        """
        An array of references to the load balancer IP configurations.
        """
        return pulumi.get(self, "load_balancer_frontend_ip_configurations")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[Optional[str]]:
        """
        Resource location.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="networkInterfaces")
    def network_interfaces(self) -> pulumi.Output[Sequence['outputs.NetworkInterfaceResponse']]:
        """
        An array of references to the network interfaces created for this private link service.
        """
        return pulumi.get(self, "network_interfaces")

    @property
    @pulumi.getter(name="privateEndpointConnections")
    def private_endpoint_connections(self) -> pulumi.Output[Sequence['outputs.PrivateEndpointConnectionResponse']]:
        """
        An array of list about connections to the private endpoint.
        """
        return pulumi.get(self, "private_endpoint_connections")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        The provisioning state of the private link service resource.
        """
        return pulumi.get(self, "provisioning_state")

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
        Resource type.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def visibility(self) -> pulumi.Output[Optional['outputs.PrivateLinkServicePropertiesResponseVisibility']]:
        """
        The visibility list of the private link service.
        """
        return pulumi.get(self, "visibility")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

