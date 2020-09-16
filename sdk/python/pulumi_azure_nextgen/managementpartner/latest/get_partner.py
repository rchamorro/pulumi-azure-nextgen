# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'GetPartnerResult',
    'AwaitableGetPartnerResult',
    'get_partner',
]

@pulumi.output_type
class GetPartnerResult:
    """
    this is the management partner operations response
    """
    def __init__(__self__, created_time=None, etag=None, name=None, object_id=None, partner_id=None, partner_name=None, tenant_id=None, type=None, updated_time=None, version=None):
        if created_time and not isinstance(created_time, str):
            raise TypeError("Expected argument 'created_time' to be a str")
        pulumi.set(__self__, "created_time", created_time)
        if etag and not isinstance(etag, int):
            raise TypeError("Expected argument 'etag' to be a int")
        pulumi.set(__self__, "etag", etag)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if object_id and not isinstance(object_id, str):
            raise TypeError("Expected argument 'object_id' to be a str")
        pulumi.set(__self__, "object_id", object_id)
        if partner_id and not isinstance(partner_id, str):
            raise TypeError("Expected argument 'partner_id' to be a str")
        pulumi.set(__self__, "partner_id", partner_id)
        if partner_name and not isinstance(partner_name, str):
            raise TypeError("Expected argument 'partner_name' to be a str")
        pulumi.set(__self__, "partner_name", partner_name)
        if tenant_id and not isinstance(tenant_id, str):
            raise TypeError("Expected argument 'tenant_id' to be a str")
        pulumi.set(__self__, "tenant_id", tenant_id)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if updated_time and not isinstance(updated_time, str):
            raise TypeError("Expected argument 'updated_time' to be a str")
        pulumi.set(__self__, "updated_time", updated_time)
        if version and not isinstance(version, int):
            raise TypeError("Expected argument 'version' to be a int")
        pulumi.set(__self__, "version", version)

    @property
    @pulumi.getter(name="createdTime")
    def created_time(self) -> Optional[str]:
        """
        This is the DateTime when the partner was created.
        """
        return pulumi.get(self, "created_time")

    @property
    @pulumi.getter
    def etag(self) -> Optional[int]:
        """
        Type of the partner
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Name of the partner
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="objectId")
    def object_id(self) -> Optional[str]:
        """
        This is the object id.
        """
        return pulumi.get(self, "object_id")

    @property
    @pulumi.getter(name="partnerId")
    def partner_id(self) -> Optional[str]:
        """
        This is the partner id
        """
        return pulumi.get(self, "partner_id")

    @property
    @pulumi.getter(name="partnerName")
    def partner_name(self) -> Optional[str]:
        """
        This is the partner name
        """
        return pulumi.get(self, "partner_name")

    @property
    @pulumi.getter(name="tenantId")
    def tenant_id(self) -> Optional[str]:
        """
        This is the tenant id.
        """
        return pulumi.get(self, "tenant_id")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Type of resource. "Microsoft.ManagementPartner/partners"
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="updatedTime")
    def updated_time(self) -> Optional[str]:
        """
        This is the DateTime when the partner was updated.
        """
        return pulumi.get(self, "updated_time")

    @property
    @pulumi.getter
    def version(self) -> Optional[int]:
        """
        This is the version.
        """
        return pulumi.get(self, "version")


class AwaitableGetPartnerResult(GetPartnerResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetPartnerResult(
            created_time=self.created_time,
            etag=self.etag,
            name=self.name,
            object_id=self.object_id,
            partner_id=self.partner_id,
            partner_name=self.partner_name,
            tenant_id=self.tenant_id,
            type=self.type,
            updated_time=self.updated_time,
            version=self.version)


def get_partner(partner_id: Optional[str] = None,
                opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetPartnerResult:
    """
    Use this data source to access information about an existing resource.

    :param str partner_id: Id of the Partner
    """
    __args__ = dict()
    __args__['partnerId'] = partner_id
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:managementpartner/latest:getPartner', __args__, opts=opts, typ=GetPartnerResult).value

    return AwaitableGetPartnerResult(
        created_time=__ret__.created_time,
        etag=__ret__.etag,
        name=__ret__.name,
        object_id=__ret__.object_id,
        partner_id=__ret__.partner_id,
        partner_name=__ret__.partner_name,
        tenant_id=__ret__.tenant_id,
        type=__ret__.type,
        updated_time=__ret__.updated_time,
        version=__ret__.version)