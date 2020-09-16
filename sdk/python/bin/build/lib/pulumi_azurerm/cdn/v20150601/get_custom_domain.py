# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from ... import _utilities, _tables

__all__ = [
    'GetCustomDomainResult',
    'AwaitableGetCustomDomainResult',
    'get_custom_domain',
]

@pulumi.output_type
class GetCustomDomainResult:
    """
    CDN CustomDomain represents a mapping between a user specified domain name and a CDN endpoint. This is to use custom domain names to represent the URLs for branding purposes.
    """
    def __init__(__self__, host_name=None, name=None, provisioning_state=None, resource_state=None, type=None):
        if host_name and not isinstance(host_name, str):
            raise TypeError("Expected argument 'host_name' to be a str")
        pulumi.set(__self__, "host_name", host_name)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if resource_state and not isinstance(resource_state, str):
            raise TypeError("Expected argument 'resource_state' to be a str")
        pulumi.set(__self__, "resource_state", resource_state)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="hostName")
    def host_name(self) -> str:
        """
        The host name of the custom domain. Must be a domain name.
        """
        return pulumi.get(self, "host_name")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Resource name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> Optional[str]:
        """
        Provisioning status of the custom domain.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="resourceState")
    def resource_state(self) -> str:
        """
        Resource status of the custom domain.
        """
        return pulumi.get(self, "resource_state")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Resource type
        """
        return pulumi.get(self, "type")


class AwaitableGetCustomDomainResult(GetCustomDomainResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetCustomDomainResult(
            host_name=self.host_name,
            name=self.name,
            provisioning_state=self.provisioning_state,
            resource_state=self.resource_state,
            type=self.type)


def get_custom_domain(custom_domain_name: Optional[str] = None,
                      endpoint_name: Optional[str] = None,
                      profile_name: Optional[str] = None,
                      resource_group_name: Optional[str] = None,
                      opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetCustomDomainResult:
    """
    Use this data source to access information about an existing resource.

    :param str custom_domain_name: Name of the custom domain within an endpoint.
    :param str endpoint_name: Name of the endpoint within the CDN profile.
    :param str profile_name: Name of the CDN profile within the resource group.
    :param str resource_group_name: Name of the resource group within the Azure subscription.
    """
    __args__ = dict()
    __args__['customDomainName'] = custom_domain_name
    __args__['endpointName'] = endpoint_name
    __args__['profileName'] = profile_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azurerm:cdn/v20150601:getCustomDomain', __args__, opts=opts, typ=GetCustomDomainResult).value

    return AwaitableGetCustomDomainResult(
        host_name=__ret__.host_name,
        name=__ret__.name,
        provisioning_state=__ret__.provisioning_state,
        resource_state=__ret__.resource_state,
        type=__ret__.type)