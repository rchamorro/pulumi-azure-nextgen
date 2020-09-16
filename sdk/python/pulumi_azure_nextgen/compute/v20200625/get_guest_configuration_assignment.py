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
    'GetGuestConfigurationAssignmentResult',
    'AwaitableGetGuestConfigurationAssignmentResult',
    'get_guest_configuration_assignment',
]

@pulumi.output_type
class GetGuestConfigurationAssignmentResult:
    """
    Guest configuration assignment is an association between a machine and guest configuration.
    """
    def __init__(__self__, location=None, name=None, properties=None, type=None):
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if properties and not isinstance(properties, dict):
            raise TypeError("Expected argument 'properties' to be a dict")
        pulumi.set(__self__, "properties", properties)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def location(self) -> Optional[str]:
        """
        Region where the VM is located.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        Name of the guest configuration assignment.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def properties(self) -> 'outputs.GuestConfigurationAssignmentPropertiesResponse':
        """
        Properties of the Guest configuration assignment.
        """
        return pulumi.get(self, "properties")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of the resource.
        """
        return pulumi.get(self, "type")


class AwaitableGetGuestConfigurationAssignmentResult(GetGuestConfigurationAssignmentResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetGuestConfigurationAssignmentResult(
            location=self.location,
            name=self.name,
            properties=self.properties,
            type=self.type)


def get_guest_configuration_assignment(guest_configuration_assignment_name: Optional[str] = None,
                                       resource_group_name: Optional[str] = None,
                                       vm_name: Optional[str] = None,
                                       opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetGuestConfigurationAssignmentResult:
    """
    Use this data source to access information about an existing resource.

    :param str guest_configuration_assignment_name: The guest configuration assignment name.
    :param str resource_group_name: The resource group name.
    :param str vm_name: The name of the virtual machine.
    """
    __args__ = dict()
    __args__['guestConfigurationAssignmentName'] = guest_configuration_assignment_name
    __args__['resourceGroupName'] = resource_group_name
    __args__['vmName'] = vm_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:compute/v20200625:getGuestConfigurationAssignment', __args__, opts=opts, typ=GetGuestConfigurationAssignmentResult).value

    return AwaitableGetGuestConfigurationAssignmentResult(
        location=__ret__.location,
        name=__ret__.name,
        properties=__ret__.properties,
        type=__ret__.type)