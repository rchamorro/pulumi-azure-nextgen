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
    'GetBandwidthScheduleResult',
    'AwaitableGetBandwidthScheduleResult',
    'get_bandwidth_schedule',
]

@pulumi.output_type
class GetBandwidthScheduleResult:
    """
    The bandwidth schedule details.
    """
    def __init__(__self__, days=None, id=None, name=None, rate_in_mbps=None, start=None, stop=None, system_data=None, type=None):
        if days and not isinstance(days, list):
            raise TypeError("Expected argument 'days' to be a list")
        pulumi.set(__self__, "days", days)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if rate_in_mbps and not isinstance(rate_in_mbps, int):
            raise TypeError("Expected argument 'rate_in_mbps' to be a int")
        pulumi.set(__self__, "rate_in_mbps", rate_in_mbps)
        if start and not isinstance(start, str):
            raise TypeError("Expected argument 'start' to be a str")
        pulumi.set(__self__, "start", start)
        if stop and not isinstance(stop, str):
            raise TypeError("Expected argument 'stop' to be a str")
        pulumi.set(__self__, "stop", stop)
        if system_data and not isinstance(system_data, dict):
            raise TypeError("Expected argument 'system_data' to be a dict")
        pulumi.set(__self__, "system_data", system_data)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def days(self) -> Sequence[str]:
        """
        The days of the week when this schedule is applicable.
        """
        return pulumi.get(self, "days")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The path ID that uniquely identifies the object.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The object name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="rateInMbps")
    def rate_in_mbps(self) -> int:
        """
        The bandwidth rate in Mbps.
        """
        return pulumi.get(self, "rate_in_mbps")

    @property
    @pulumi.getter
    def start(self) -> str:
        """
        The start time of the schedule in UTC.
        """
        return pulumi.get(self, "start")

    @property
    @pulumi.getter
    def stop(self) -> str:
        """
        The stop time of the schedule in UTC.
        """
        return pulumi.get(self, "stop")

    @property
    @pulumi.getter(name="systemData")
    def system_data(self) -> 'outputs.SystemDataResponse':
        """
        Bandwidth object related to ASE resource
        """
        return pulumi.get(self, "system_data")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The hierarchical type of the object.
        """
        return pulumi.get(self, "type")


class AwaitableGetBandwidthScheduleResult(GetBandwidthScheduleResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetBandwidthScheduleResult(
            days=self.days,
            id=self.id,
            name=self.name,
            rate_in_mbps=self.rate_in_mbps,
            start=self.start,
            stop=self.stop,
            system_data=self.system_data,
            type=self.type)


def get_bandwidth_schedule(device_name: Optional[str] = None,
                           name: Optional[str] = None,
                           resource_group_name: Optional[str] = None,
                           opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetBandwidthScheduleResult:
    """
    Use this data source to access information about an existing resource.

    :param str device_name: The device name.
    :param str name: The bandwidth schedule name.
    :param str resource_group_name: The resource group name.
    """
    __args__ = dict()
    __args__['deviceName'] = device_name
    __args__['name'] = name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:databoxedge/v20200901preview:getBandwidthSchedule', __args__, opts=opts, typ=GetBandwidthScheduleResult).value

    return AwaitableGetBandwidthScheduleResult(
        days=__ret__.days,
        id=__ret__.id,
        name=__ret__.name,
        rate_in_mbps=__ret__.rate_in_mbps,
        start=__ret__.start,
        stop=__ret__.stop,
        system_data=__ret__.system_data,
        type=__ret__.type)
