# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from ._enums import *

__all__ = [
    'DnsConfigArgs',
    'EndpointArgs',
    'MonitorConfigArgs',
]

@pulumi.input_type
class DnsConfigArgs:
    def __init__(__self__, *,
                 relative_name: Optional[pulumi.Input[str]] = None,
                 ttl: Optional[pulumi.Input[float]] = None):
        """
        Class containing DNS settings in a Traffic Manager profile.
        :param pulumi.Input[str] relative_name: The relative DNS name provided by this Traffic Manager profile. This value is combined with the DNS domain name used by Azure Traffic Manager to form the fully-qualified domain name (FQDN) of the profile.
        :param pulumi.Input[float] ttl: The DNS Time-To-Live (TTL), in seconds. This informs the local DNS resolvers and DNS clients how long to cache DNS responses provided by this Traffic Manager profile.
        """
        if relative_name is not None:
            pulumi.set(__self__, "relative_name", relative_name)
        if ttl is not None:
            pulumi.set(__self__, "ttl", ttl)

    @property
    @pulumi.getter(name="relativeName")
    def relative_name(self) -> Optional[pulumi.Input[str]]:
        """
        The relative DNS name provided by this Traffic Manager profile. This value is combined with the DNS domain name used by Azure Traffic Manager to form the fully-qualified domain name (FQDN) of the profile.
        """
        return pulumi.get(self, "relative_name")

    @relative_name.setter
    def relative_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "relative_name", value)

    @property
    @pulumi.getter
    def ttl(self) -> Optional[pulumi.Input[float]]:
        """
        The DNS Time-To-Live (TTL), in seconds. This informs the local DNS resolvers and DNS clients how long to cache DNS responses provided by this Traffic Manager profile.
        """
        return pulumi.get(self, "ttl")

    @ttl.setter
    def ttl(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "ttl", value)


@pulumi.input_type
class EndpointArgs:
    def __init__(__self__, *,
                 endpoint_location: Optional[pulumi.Input[str]] = None,
                 endpoint_monitor_status: Optional[pulumi.Input[Union[str, 'EndpointMonitorStatus']]] = None,
                 endpoint_status: Optional[pulumi.Input[Union[str, 'EndpointStatus']]] = None,
                 geo_mapping: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 min_child_endpoints: Optional[pulumi.Input[float]] = None,
                 priority: Optional[pulumi.Input[float]] = None,
                 target: Optional[pulumi.Input[str]] = None,
                 target_resource_id: Optional[pulumi.Input[str]] = None,
                 weight: Optional[pulumi.Input[float]] = None):
        """
        Class representing a Traffic Manager endpoint.
        :param pulumi.Input[str] endpoint_location: Specifies the location of the external or nested endpoints when using the ‘Performance’ traffic routing method.
        :param pulumi.Input[Union[str, 'EndpointMonitorStatus']] endpoint_monitor_status: The monitoring status of the endpoint.
        :param pulumi.Input[Union[str, 'EndpointStatus']] endpoint_status: The status of the endpoint. If the endpoint is Enabled, it is probed for endpoint health and is included in the traffic routing method.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] geo_mapping: The list of countries/regions mapped to this endpoint when using the ‘Geographic’ traffic routing method. Please consult Traffic Manager Geographic documentation for a full list of accepted values.
        :param pulumi.Input[float] min_child_endpoints: The minimum number of endpoints that must be available in the child profile in order for the parent profile to be considered available. Only applicable to endpoint of type 'NestedEndpoints'.
        :param pulumi.Input[float] priority: The priority of this endpoint when using the ‘Priority’ traffic routing method. Possible values are from 1 to 1000, lower values represent higher priority. This is an optional parameter.  If specified, it must be specified on all endpoints, and no two endpoints can share the same priority value.
        :param pulumi.Input[str] target: The fully-qualified DNS name of the endpoint. Traffic Manager returns this value in DNS responses to direct traffic to this endpoint.
        :param pulumi.Input[str] target_resource_id: The Azure Resource URI of the of the endpoint. Not applicable to endpoints of type 'ExternalEndpoints'.
        :param pulumi.Input[float] weight: The weight of this endpoint when using the 'Weighted' traffic routing method. Possible values are from 1 to 1000.
        """
        if endpoint_location is not None:
            pulumi.set(__self__, "endpoint_location", endpoint_location)
        if endpoint_monitor_status is not None:
            pulumi.set(__self__, "endpoint_monitor_status", endpoint_monitor_status)
        if endpoint_status is not None:
            pulumi.set(__self__, "endpoint_status", endpoint_status)
        if geo_mapping is not None:
            pulumi.set(__self__, "geo_mapping", geo_mapping)
        if min_child_endpoints is not None:
            pulumi.set(__self__, "min_child_endpoints", min_child_endpoints)
        if priority is not None:
            pulumi.set(__self__, "priority", priority)
        if target is not None:
            pulumi.set(__self__, "target", target)
        if target_resource_id is not None:
            pulumi.set(__self__, "target_resource_id", target_resource_id)
        if weight is not None:
            pulumi.set(__self__, "weight", weight)

    @property
    @pulumi.getter(name="endpointLocation")
    def endpoint_location(self) -> Optional[pulumi.Input[str]]:
        """
        Specifies the location of the external or nested endpoints when using the ‘Performance’ traffic routing method.
        """
        return pulumi.get(self, "endpoint_location")

    @endpoint_location.setter
    def endpoint_location(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "endpoint_location", value)

    @property
    @pulumi.getter(name="endpointMonitorStatus")
    def endpoint_monitor_status(self) -> Optional[pulumi.Input[Union[str, 'EndpointMonitorStatus']]]:
        """
        The monitoring status of the endpoint.
        """
        return pulumi.get(self, "endpoint_monitor_status")

    @endpoint_monitor_status.setter
    def endpoint_monitor_status(self, value: Optional[pulumi.Input[Union[str, 'EndpointMonitorStatus']]]):
        pulumi.set(self, "endpoint_monitor_status", value)

    @property
    @pulumi.getter(name="endpointStatus")
    def endpoint_status(self) -> Optional[pulumi.Input[Union[str, 'EndpointStatus']]]:
        """
        The status of the endpoint. If the endpoint is Enabled, it is probed for endpoint health and is included in the traffic routing method.
        """
        return pulumi.get(self, "endpoint_status")

    @endpoint_status.setter
    def endpoint_status(self, value: Optional[pulumi.Input[Union[str, 'EndpointStatus']]]):
        pulumi.set(self, "endpoint_status", value)

    @property
    @pulumi.getter(name="geoMapping")
    def geo_mapping(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        The list of countries/regions mapped to this endpoint when using the ‘Geographic’ traffic routing method. Please consult Traffic Manager Geographic documentation for a full list of accepted values.
        """
        return pulumi.get(self, "geo_mapping")

    @geo_mapping.setter
    def geo_mapping(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "geo_mapping", value)

    @property
    @pulumi.getter(name="minChildEndpoints")
    def min_child_endpoints(self) -> Optional[pulumi.Input[float]]:
        """
        The minimum number of endpoints that must be available in the child profile in order for the parent profile to be considered available. Only applicable to endpoint of type 'NestedEndpoints'.
        """
        return pulumi.get(self, "min_child_endpoints")

    @min_child_endpoints.setter
    def min_child_endpoints(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "min_child_endpoints", value)

    @property
    @pulumi.getter
    def priority(self) -> Optional[pulumi.Input[float]]:
        """
        The priority of this endpoint when using the ‘Priority’ traffic routing method. Possible values are from 1 to 1000, lower values represent higher priority. This is an optional parameter.  If specified, it must be specified on all endpoints, and no two endpoints can share the same priority value.
        """
        return pulumi.get(self, "priority")

    @priority.setter
    def priority(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "priority", value)

    @property
    @pulumi.getter
    def target(self) -> Optional[pulumi.Input[str]]:
        """
        The fully-qualified DNS name of the endpoint. Traffic Manager returns this value in DNS responses to direct traffic to this endpoint.
        """
        return pulumi.get(self, "target")

    @target.setter
    def target(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "target", value)

    @property
    @pulumi.getter(name="targetResourceId")
    def target_resource_id(self) -> Optional[pulumi.Input[str]]:
        """
        The Azure Resource URI of the of the endpoint. Not applicable to endpoints of type 'ExternalEndpoints'.
        """
        return pulumi.get(self, "target_resource_id")

    @target_resource_id.setter
    def target_resource_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "target_resource_id", value)

    @property
    @pulumi.getter
    def weight(self) -> Optional[pulumi.Input[float]]:
        """
        The weight of this endpoint when using the 'Weighted' traffic routing method. Possible values are from 1 to 1000.
        """
        return pulumi.get(self, "weight")

    @weight.setter
    def weight(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "weight", value)


@pulumi.input_type
class MonitorConfigArgs:
    def __init__(__self__, *,
                 interval_in_seconds: Optional[pulumi.Input[float]] = None,
                 path: Optional[pulumi.Input[str]] = None,
                 port: Optional[pulumi.Input[float]] = None,
                 profile_monitor_status: Optional[pulumi.Input[Union[str, 'ProfileMonitorStatus']]] = None,
                 protocol: Optional[pulumi.Input[Union[str, 'MonitorProtocol']]] = None,
                 timeout_in_seconds: Optional[pulumi.Input[float]] = None,
                 tolerated_number_of_failures: Optional[pulumi.Input[float]] = None):
        """
        Class containing endpoint monitoring settings in a Traffic Manager profile.
        :param pulumi.Input[float] interval_in_seconds: The monitor interval for endpoints in this profile. This is the interval at which Traffic Manager will check the health of each endpoint in this profile.
        :param pulumi.Input[str] path: The path relative to the endpoint domain name used to probe for endpoint health.
        :param pulumi.Input[float] port: The TCP port used to probe for endpoint health.
        :param pulumi.Input[Union[str, 'ProfileMonitorStatus']] profile_monitor_status: The profile-level monitoring status of the Traffic Manager profile.
        :param pulumi.Input[Union[str, 'MonitorProtocol']] protocol: The protocol (HTTP, HTTPS or TCP) used to probe for endpoint health.
        :param pulumi.Input[float] timeout_in_seconds: The monitor timeout for endpoints in this profile. This is the time that Traffic Manager allows endpoints in this profile to response to the health check.
        :param pulumi.Input[float] tolerated_number_of_failures: The number of consecutive failed health check that Traffic Manager tolerates before declaring an endpoint in this profile Degraded after the next failed health check.
        """
        if interval_in_seconds is not None:
            pulumi.set(__self__, "interval_in_seconds", interval_in_seconds)
        if path is not None:
            pulumi.set(__self__, "path", path)
        if port is not None:
            pulumi.set(__self__, "port", port)
        if profile_monitor_status is not None:
            pulumi.set(__self__, "profile_monitor_status", profile_monitor_status)
        if protocol is not None:
            pulumi.set(__self__, "protocol", protocol)
        if timeout_in_seconds is not None:
            pulumi.set(__self__, "timeout_in_seconds", timeout_in_seconds)
        if tolerated_number_of_failures is not None:
            pulumi.set(__self__, "tolerated_number_of_failures", tolerated_number_of_failures)

    @property
    @pulumi.getter(name="intervalInSeconds")
    def interval_in_seconds(self) -> Optional[pulumi.Input[float]]:
        """
        The monitor interval for endpoints in this profile. This is the interval at which Traffic Manager will check the health of each endpoint in this profile.
        """
        return pulumi.get(self, "interval_in_seconds")

    @interval_in_seconds.setter
    def interval_in_seconds(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "interval_in_seconds", value)

    @property
    @pulumi.getter
    def path(self) -> Optional[pulumi.Input[str]]:
        """
        The path relative to the endpoint domain name used to probe for endpoint health.
        """
        return pulumi.get(self, "path")

    @path.setter
    def path(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "path", value)

    @property
    @pulumi.getter
    def port(self) -> Optional[pulumi.Input[float]]:
        """
        The TCP port used to probe for endpoint health.
        """
        return pulumi.get(self, "port")

    @port.setter
    def port(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "port", value)

    @property
    @pulumi.getter(name="profileMonitorStatus")
    def profile_monitor_status(self) -> Optional[pulumi.Input[Union[str, 'ProfileMonitorStatus']]]:
        """
        The profile-level monitoring status of the Traffic Manager profile.
        """
        return pulumi.get(self, "profile_monitor_status")

    @profile_monitor_status.setter
    def profile_monitor_status(self, value: Optional[pulumi.Input[Union[str, 'ProfileMonitorStatus']]]):
        pulumi.set(self, "profile_monitor_status", value)

    @property
    @pulumi.getter
    def protocol(self) -> Optional[pulumi.Input[Union[str, 'MonitorProtocol']]]:
        """
        The protocol (HTTP, HTTPS or TCP) used to probe for endpoint health.
        """
        return pulumi.get(self, "protocol")

    @protocol.setter
    def protocol(self, value: Optional[pulumi.Input[Union[str, 'MonitorProtocol']]]):
        pulumi.set(self, "protocol", value)

    @property
    @pulumi.getter(name="timeoutInSeconds")
    def timeout_in_seconds(self) -> Optional[pulumi.Input[float]]:
        """
        The monitor timeout for endpoints in this profile. This is the time that Traffic Manager allows endpoints in this profile to response to the health check.
        """
        return pulumi.get(self, "timeout_in_seconds")

    @timeout_in_seconds.setter
    def timeout_in_seconds(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "timeout_in_seconds", value)

    @property
    @pulumi.getter(name="toleratedNumberOfFailures")
    def tolerated_number_of_failures(self) -> Optional[pulumi.Input[float]]:
        """
        The number of consecutive failed health check that Traffic Manager tolerates before declaring an endpoint in this profile Degraded after the next failed health check.
        """
        return pulumi.get(self, "tolerated_number_of_failures")

    @tolerated_number_of_failures.setter
    def tolerated_number_of_failures(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "tolerated_number_of_failures", value)


