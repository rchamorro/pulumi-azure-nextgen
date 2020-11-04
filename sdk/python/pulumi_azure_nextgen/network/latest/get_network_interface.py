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
    'GetNetworkInterfaceResult',
    'AwaitableGetNetworkInterfaceResult',
    'get_network_interface',
]

@pulumi.output_type
class GetNetworkInterfaceResult:
    """
    A network interface in a resource group.
    """
    def __init__(__self__, dns_settings=None, dscp_configuration=None, enable_accelerated_networking=None, enable_ip_forwarding=None, etag=None, extended_location=None, hosted_workloads=None, ip_configurations=None, location=None, mac_address=None, name=None, network_security_group=None, primary=None, private_endpoint=None, provisioning_state=None, resource_guid=None, tags=None, tap_configurations=None, type=None, virtual_machine=None):
        if dns_settings and not isinstance(dns_settings, dict):
            raise TypeError("Expected argument 'dns_settings' to be a dict")
        pulumi.set(__self__, "dns_settings", dns_settings)
        if dscp_configuration and not isinstance(dscp_configuration, dict):
            raise TypeError("Expected argument 'dscp_configuration' to be a dict")
        pulumi.set(__self__, "dscp_configuration", dscp_configuration)
        if enable_accelerated_networking and not isinstance(enable_accelerated_networking, bool):
            raise TypeError("Expected argument 'enable_accelerated_networking' to be a bool")
        pulumi.set(__self__, "enable_accelerated_networking", enable_accelerated_networking)
        if enable_ip_forwarding and not isinstance(enable_ip_forwarding, bool):
            raise TypeError("Expected argument 'enable_ip_forwarding' to be a bool")
        pulumi.set(__self__, "enable_ip_forwarding", enable_ip_forwarding)
        if etag and not isinstance(etag, str):
            raise TypeError("Expected argument 'etag' to be a str")
        pulumi.set(__self__, "etag", etag)
        if extended_location and not isinstance(extended_location, dict):
            raise TypeError("Expected argument 'extended_location' to be a dict")
        pulumi.set(__self__, "extended_location", extended_location)
        if hosted_workloads and not isinstance(hosted_workloads, list):
            raise TypeError("Expected argument 'hosted_workloads' to be a list")
        pulumi.set(__self__, "hosted_workloads", hosted_workloads)
        if ip_configurations and not isinstance(ip_configurations, list):
            raise TypeError("Expected argument 'ip_configurations' to be a list")
        pulumi.set(__self__, "ip_configurations", ip_configurations)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if mac_address and not isinstance(mac_address, str):
            raise TypeError("Expected argument 'mac_address' to be a str")
        pulumi.set(__self__, "mac_address", mac_address)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if network_security_group and not isinstance(network_security_group, dict):
            raise TypeError("Expected argument 'network_security_group' to be a dict")
        pulumi.set(__self__, "network_security_group", network_security_group)
        if primary and not isinstance(primary, bool):
            raise TypeError("Expected argument 'primary' to be a bool")
        pulumi.set(__self__, "primary", primary)
        if private_endpoint and not isinstance(private_endpoint, dict):
            raise TypeError("Expected argument 'private_endpoint' to be a dict")
        pulumi.set(__self__, "private_endpoint", private_endpoint)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if resource_guid and not isinstance(resource_guid, str):
            raise TypeError("Expected argument 'resource_guid' to be a str")
        pulumi.set(__self__, "resource_guid", resource_guid)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if tap_configurations and not isinstance(tap_configurations, list):
            raise TypeError("Expected argument 'tap_configurations' to be a list")
        pulumi.set(__self__, "tap_configurations", tap_configurations)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if virtual_machine and not isinstance(virtual_machine, dict):
            raise TypeError("Expected argument 'virtual_machine' to be a dict")
        pulumi.set(__self__, "virtual_machine", virtual_machine)

    @property
    @pulumi.getter(name="dnsSettings")
    def dns_settings(self) -> Optional['outputs.NetworkInterfaceDnsSettingsResponse']:
        """
        The DNS settings in network interface.
        """
        return pulumi.get(self, "dns_settings")

    @property
    @pulumi.getter(name="dscpConfiguration")
    def dscp_configuration(self) -> 'outputs.SubResourceResponse':
        """
        A reference to the dscp configuration to which the network interface is linked.
        """
        return pulumi.get(self, "dscp_configuration")

    @property
    @pulumi.getter(name="enableAcceleratedNetworking")
    def enable_accelerated_networking(self) -> Optional[bool]:
        """
        If the network interface is accelerated networking enabled.
        """
        return pulumi.get(self, "enable_accelerated_networking")

    @property
    @pulumi.getter(name="enableIPForwarding")
    def enable_ip_forwarding(self) -> Optional[bool]:
        """
        Indicates whether IP forwarding is enabled on this network interface.
        """
        return pulumi.get(self, "enable_ip_forwarding")

    @property
    @pulumi.getter
    def etag(self) -> str:
        """
        A unique read-only string that changes whenever the resource is updated.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter(name="extendedLocation")
    def extended_location(self) -> Optional['outputs.ExtendedLocationResponse']:
        """
        The extended location of the network interface.
        """
        return pulumi.get(self, "extended_location")

    @property
    @pulumi.getter(name="hostedWorkloads")
    def hosted_workloads(self) -> Sequence[str]:
        """
        A list of references to linked BareMetal resources.
        """
        return pulumi.get(self, "hosted_workloads")

    @property
    @pulumi.getter(name="ipConfigurations")
    def ip_configurations(self) -> Optional[Sequence['outputs.NetworkInterfaceIPConfigurationResponse']]:
        """
        A list of IPConfigurations of the network interface.
        """
        return pulumi.get(self, "ip_configurations")

    @property
    @pulumi.getter
    def location(self) -> Optional[str]:
        """
        Resource location.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="macAddress")
    def mac_address(self) -> str:
        """
        The MAC address of the network interface.
        """
        return pulumi.get(self, "mac_address")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="networkSecurityGroup")
    def network_security_group(self) -> Optional['outputs.NetworkSecurityGroupResponse']:
        """
        The reference to the NetworkSecurityGroup resource.
        """
        return pulumi.get(self, "network_security_group")

    @property
    @pulumi.getter
    def primary(self) -> bool:
        """
        Whether this is a primary network interface on a virtual machine.
        """
        return pulumi.get(self, "primary")

    @property
    @pulumi.getter(name="privateEndpoint")
    def private_endpoint(self) -> 'outputs.PrivateEndpointResponse':
        """
        A reference to the private endpoint to which the network interface is linked.
        """
        return pulumi.get(self, "private_endpoint")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        The provisioning state of the network interface resource.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="resourceGuid")
    def resource_guid(self) -> str:
        """
        The resource GUID property of the network interface resource.
        """
        return pulumi.get(self, "resource_guid")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        Resource tags.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="tapConfigurations")
    def tap_configurations(self) -> Sequence['outputs.NetworkInterfaceTapConfigurationResponse']:
        """
        A list of TapConfigurations of the network interface.
        """
        return pulumi.get(self, "tap_configurations")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Resource type.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="virtualMachine")
    def virtual_machine(self) -> 'outputs.SubResourceResponse':
        """
        The reference to a virtual machine.
        """
        return pulumi.get(self, "virtual_machine")


class AwaitableGetNetworkInterfaceResult(GetNetworkInterfaceResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetNetworkInterfaceResult(
            dns_settings=self.dns_settings,
            dscp_configuration=self.dscp_configuration,
            enable_accelerated_networking=self.enable_accelerated_networking,
            enable_ip_forwarding=self.enable_ip_forwarding,
            etag=self.etag,
            extended_location=self.extended_location,
            hosted_workloads=self.hosted_workloads,
            ip_configurations=self.ip_configurations,
            location=self.location,
            mac_address=self.mac_address,
            name=self.name,
            network_security_group=self.network_security_group,
            primary=self.primary,
            private_endpoint=self.private_endpoint,
            provisioning_state=self.provisioning_state,
            resource_guid=self.resource_guid,
            tags=self.tags,
            tap_configurations=self.tap_configurations,
            type=self.type,
            virtual_machine=self.virtual_machine)


def get_network_interface(expand: Optional[str] = None,
                          network_interface_name: Optional[str] = None,
                          resource_group_name: Optional[str] = None,
                          opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetNetworkInterfaceResult:
    """
    Use this data source to access information about an existing resource.

    :param str expand: Expands referenced resources.
    :param str network_interface_name: The name of the network interface.
    :param str resource_group_name: The name of the resource group.
    """
    __args__ = dict()
    __args__['expand'] = expand
    __args__['networkInterfaceName'] = network_interface_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:network/latest:getNetworkInterface', __args__, opts=opts, typ=GetNetworkInterfaceResult).value

    return AwaitableGetNetworkInterfaceResult(
        dns_settings=__ret__.dns_settings,
        dscp_configuration=__ret__.dscp_configuration,
        enable_accelerated_networking=__ret__.enable_accelerated_networking,
        enable_ip_forwarding=__ret__.enable_ip_forwarding,
        etag=__ret__.etag,
        extended_location=__ret__.extended_location,
        hosted_workloads=__ret__.hosted_workloads,
        ip_configurations=__ret__.ip_configurations,
        location=__ret__.location,
        mac_address=__ret__.mac_address,
        name=__ret__.name,
        network_security_group=__ret__.network_security_group,
        primary=__ret__.primary,
        private_endpoint=__ret__.private_endpoint,
        provisioning_state=__ret__.provisioning_state,
        resource_guid=__ret__.resource_guid,
        tags=__ret__.tags,
        tap_configurations=__ret__.tap_configurations,
        type=__ret__.type,
        virtual_machine=__ret__.virtual_machine)
