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
    'GetExpressRoutePortResult',
    'AwaitableGetExpressRoutePortResult',
    'get_express_route_port',
]

@pulumi.output_type
class GetExpressRoutePortResult:
    """
    ExpressRoutePort resource definition.
    """
    def __init__(__self__, allocation_date=None, bandwidth_in_gbps=None, circuits=None, encapsulation=None, etag=None, ether_type=None, id=None, identity=None, links=None, location=None, mtu=None, name=None, peering_location=None, provisioned_bandwidth_in_gbps=None, provisioning_state=None, resource_guid=None, tags=None, type=None):
        if allocation_date and not isinstance(allocation_date, str):
            raise TypeError("Expected argument 'allocation_date' to be a str")
        pulumi.set(__self__, "allocation_date", allocation_date)
        if bandwidth_in_gbps and not isinstance(bandwidth_in_gbps, int):
            raise TypeError("Expected argument 'bandwidth_in_gbps' to be a int")
        pulumi.set(__self__, "bandwidth_in_gbps", bandwidth_in_gbps)
        if circuits and not isinstance(circuits, list):
            raise TypeError("Expected argument 'circuits' to be a list")
        pulumi.set(__self__, "circuits", circuits)
        if encapsulation and not isinstance(encapsulation, str):
            raise TypeError("Expected argument 'encapsulation' to be a str")
        pulumi.set(__self__, "encapsulation", encapsulation)
        if etag and not isinstance(etag, str):
            raise TypeError("Expected argument 'etag' to be a str")
        pulumi.set(__self__, "etag", etag)
        if ether_type and not isinstance(ether_type, str):
            raise TypeError("Expected argument 'ether_type' to be a str")
        pulumi.set(__self__, "ether_type", ether_type)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if identity and not isinstance(identity, dict):
            raise TypeError("Expected argument 'identity' to be a dict")
        pulumi.set(__self__, "identity", identity)
        if links and not isinstance(links, list):
            raise TypeError("Expected argument 'links' to be a list")
        pulumi.set(__self__, "links", links)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if mtu and not isinstance(mtu, str):
            raise TypeError("Expected argument 'mtu' to be a str")
        pulumi.set(__self__, "mtu", mtu)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if peering_location and not isinstance(peering_location, str):
            raise TypeError("Expected argument 'peering_location' to be a str")
        pulumi.set(__self__, "peering_location", peering_location)
        if provisioned_bandwidth_in_gbps and not isinstance(provisioned_bandwidth_in_gbps, float):
            raise TypeError("Expected argument 'provisioned_bandwidth_in_gbps' to be a float")
        pulumi.set(__self__, "provisioned_bandwidth_in_gbps", provisioned_bandwidth_in_gbps)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if resource_guid and not isinstance(resource_guid, str):
            raise TypeError("Expected argument 'resource_guid' to be a str")
        pulumi.set(__self__, "resource_guid", resource_guid)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="allocationDate")
    def allocation_date(self) -> str:
        """
        Date of the physical port allocation to be used in Letter of Authorization.
        """
        return pulumi.get(self, "allocation_date")

    @property
    @pulumi.getter(name="bandwidthInGbps")
    def bandwidth_in_gbps(self) -> Optional[int]:
        """
        Bandwidth of procured ports in Gbps.
        """
        return pulumi.get(self, "bandwidth_in_gbps")

    @property
    @pulumi.getter
    def circuits(self) -> Sequence['outputs.SubResourceResponse']:
        """
        Reference the ExpressRoute circuit(s) that are provisioned on this ExpressRoutePort resource.
        """
        return pulumi.get(self, "circuits")

    @property
    @pulumi.getter
    def encapsulation(self) -> Optional[str]:
        """
        Encapsulation method on physical ports.
        """
        return pulumi.get(self, "encapsulation")

    @property
    @pulumi.getter
    def etag(self) -> str:
        """
        A unique read-only string that changes whenever the resource is updated.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter(name="etherType")
    def ether_type(self) -> str:
        """
        Ether type of the physical port.
        """
        return pulumi.get(self, "ether_type")

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        """
        Resource ID.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def identity(self) -> Optional['outputs.ManagedServiceIdentityResponse']:
        """
        The identity of ExpressRoutePort, if configured.
        """
        return pulumi.get(self, "identity")

    @property
    @pulumi.getter
    def links(self) -> Optional[Sequence['outputs.ExpressRouteLinkResponse']]:
        """
        The set of physical links of the ExpressRoutePort resource.
        """
        return pulumi.get(self, "links")

    @property
    @pulumi.getter
    def location(self) -> Optional[str]:
        """
        Resource location.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def mtu(self) -> str:
        """
        Maximum transmission unit of the physical port pair(s).
        """
        return pulumi.get(self, "mtu")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="peeringLocation")
    def peering_location(self) -> Optional[str]:
        """
        The name of the peering location that the ExpressRoutePort is mapped to physically.
        """
        return pulumi.get(self, "peering_location")

    @property
    @pulumi.getter(name="provisionedBandwidthInGbps")
    def provisioned_bandwidth_in_gbps(self) -> float:
        """
        Aggregate Gbps of associated circuit bandwidths.
        """
        return pulumi.get(self, "provisioned_bandwidth_in_gbps")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        The provisioning state of the express route port resource.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="resourceGuid")
    def resource_guid(self) -> str:
        """
        The resource GUID property of the express route port resource.
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
    @pulumi.getter
    def type(self) -> str:
        """
        Resource type.
        """
        return pulumi.get(self, "type")


class AwaitableGetExpressRoutePortResult(GetExpressRoutePortResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetExpressRoutePortResult(
            allocation_date=self.allocation_date,
            bandwidth_in_gbps=self.bandwidth_in_gbps,
            circuits=self.circuits,
            encapsulation=self.encapsulation,
            etag=self.etag,
            ether_type=self.ether_type,
            id=self.id,
            identity=self.identity,
            links=self.links,
            location=self.location,
            mtu=self.mtu,
            name=self.name,
            peering_location=self.peering_location,
            provisioned_bandwidth_in_gbps=self.provisioned_bandwidth_in_gbps,
            provisioning_state=self.provisioning_state,
            resource_guid=self.resource_guid,
            tags=self.tags,
            type=self.type)


def get_express_route_port(express_route_port_name: Optional[str] = None,
                           resource_group_name: Optional[str] = None,
                           opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetExpressRoutePortResult:
    """
    Use this data source to access information about an existing resource.

    :param str express_route_port_name: The name of ExpressRoutePort.
    :param str resource_group_name: The name of the resource group.
    """
    __args__ = dict()
    __args__['expressRoutePortName'] = express_route_port_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:network/v20200801:getExpressRoutePort', __args__, opts=opts, typ=GetExpressRoutePortResult).value

    return AwaitableGetExpressRoutePortResult(
        allocation_date=__ret__.allocation_date,
        bandwidth_in_gbps=__ret__.bandwidth_in_gbps,
        circuits=__ret__.circuits,
        encapsulation=__ret__.encapsulation,
        etag=__ret__.etag,
        ether_type=__ret__.ether_type,
        id=__ret__.id,
        identity=__ret__.identity,
        links=__ret__.links,
        location=__ret__.location,
        mtu=__ret__.mtu,
        name=__ret__.name,
        peering_location=__ret__.peering_location,
        provisioned_bandwidth_in_gbps=__ret__.provisioned_bandwidth_in_gbps,
        provisioning_state=__ret__.provisioning_state,
        resource_guid=__ret__.resource_guid,
        tags=__ret__.tags,
        type=__ret__.type)
