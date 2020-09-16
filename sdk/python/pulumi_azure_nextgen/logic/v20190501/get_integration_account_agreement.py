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
    'GetIntegrationAccountAgreementResult',
    'AwaitableGetIntegrationAccountAgreementResult',
    'get_integration_account_agreement',
]

@pulumi.output_type
class GetIntegrationAccountAgreementResult:
    """
    The integration account agreement.
    """
    def __init__(__self__, agreement_type=None, changed_time=None, content=None, created_time=None, guest_identity=None, guest_partner=None, host_identity=None, host_partner=None, location=None, metadata=None, name=None, tags=None, type=None):
        if agreement_type and not isinstance(agreement_type, str):
            raise TypeError("Expected argument 'agreement_type' to be a str")
        pulumi.set(__self__, "agreement_type", agreement_type)
        if changed_time and not isinstance(changed_time, str):
            raise TypeError("Expected argument 'changed_time' to be a str")
        pulumi.set(__self__, "changed_time", changed_time)
        if content and not isinstance(content, dict):
            raise TypeError("Expected argument 'content' to be a dict")
        pulumi.set(__self__, "content", content)
        if created_time and not isinstance(created_time, str):
            raise TypeError("Expected argument 'created_time' to be a str")
        pulumi.set(__self__, "created_time", created_time)
        if guest_identity and not isinstance(guest_identity, dict):
            raise TypeError("Expected argument 'guest_identity' to be a dict")
        pulumi.set(__self__, "guest_identity", guest_identity)
        if guest_partner and not isinstance(guest_partner, str):
            raise TypeError("Expected argument 'guest_partner' to be a str")
        pulumi.set(__self__, "guest_partner", guest_partner)
        if host_identity and not isinstance(host_identity, dict):
            raise TypeError("Expected argument 'host_identity' to be a dict")
        pulumi.set(__self__, "host_identity", host_identity)
        if host_partner and not isinstance(host_partner, str):
            raise TypeError("Expected argument 'host_partner' to be a str")
        pulumi.set(__self__, "host_partner", host_partner)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if metadata and not isinstance(metadata, dict):
            raise TypeError("Expected argument 'metadata' to be a dict")
        pulumi.set(__self__, "metadata", metadata)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="agreementType")
    def agreement_type(self) -> str:
        """
        The agreement type.
        """
        return pulumi.get(self, "agreement_type")

    @property
    @pulumi.getter(name="changedTime")
    def changed_time(self) -> str:
        """
        The changed time.
        """
        return pulumi.get(self, "changed_time")

    @property
    @pulumi.getter
    def content(self) -> 'outputs.AgreementContentResponse':
        """
        The agreement content.
        """
        return pulumi.get(self, "content")

    @property
    @pulumi.getter(name="createdTime")
    def created_time(self) -> str:
        """
        The created time.
        """
        return pulumi.get(self, "created_time")

    @property
    @pulumi.getter(name="guestIdentity")
    def guest_identity(self) -> 'outputs.BusinessIdentityResponse':
        """
        The business identity of the guest partner.
        """
        return pulumi.get(self, "guest_identity")

    @property
    @pulumi.getter(name="guestPartner")
    def guest_partner(self) -> str:
        """
        The integration account partner that is set as guest partner for this agreement.
        """
        return pulumi.get(self, "guest_partner")

    @property
    @pulumi.getter(name="hostIdentity")
    def host_identity(self) -> 'outputs.BusinessIdentityResponse':
        """
        The business identity of the host partner.
        """
        return pulumi.get(self, "host_identity")

    @property
    @pulumi.getter(name="hostPartner")
    def host_partner(self) -> str:
        """
        The integration account partner that is set as host partner for this agreement.
        """
        return pulumi.get(self, "host_partner")

    @property
    @pulumi.getter
    def location(self) -> Optional[str]:
        """
        The resource location.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def metadata(self) -> Optional[Mapping[str, Any]]:
        """
        The metadata.
        """
        return pulumi.get(self, "metadata")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Gets the resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        The resource tags.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Gets the resource type.
        """
        return pulumi.get(self, "type")


class AwaitableGetIntegrationAccountAgreementResult(GetIntegrationAccountAgreementResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetIntegrationAccountAgreementResult(
            agreement_type=self.agreement_type,
            changed_time=self.changed_time,
            content=self.content,
            created_time=self.created_time,
            guest_identity=self.guest_identity,
            guest_partner=self.guest_partner,
            host_identity=self.host_identity,
            host_partner=self.host_partner,
            location=self.location,
            metadata=self.metadata,
            name=self.name,
            tags=self.tags,
            type=self.type)


def get_integration_account_agreement(agreement_name: Optional[str] = None,
                                      integration_account_name: Optional[str] = None,
                                      resource_group_name: Optional[str] = None,
                                      opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetIntegrationAccountAgreementResult:
    """
    Use this data source to access information about an existing resource.

    :param str agreement_name: The integration account agreement name.
    :param str integration_account_name: The integration account name.
    :param str resource_group_name: The resource group name.
    """
    __args__ = dict()
    __args__['agreementName'] = agreement_name
    __args__['integrationAccountName'] = integration_account_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:logic/v20190501:getIntegrationAccountAgreement', __args__, opts=opts, typ=GetIntegrationAccountAgreementResult).value

    return AwaitableGetIntegrationAccountAgreementResult(
        agreement_type=__ret__.agreement_type,
        changed_time=__ret__.changed_time,
        content=__ret__.content,
        created_time=__ret__.created_time,
        guest_identity=__ret__.guest_identity,
        guest_partner=__ret__.guest_partner,
        host_identity=__ret__.host_identity,
        host_partner=__ret__.host_partner,
        location=__ret__.location,
        metadata=__ret__.metadata,
        name=__ret__.name,
        tags=__ret__.tags,
        type=__ret__.type)