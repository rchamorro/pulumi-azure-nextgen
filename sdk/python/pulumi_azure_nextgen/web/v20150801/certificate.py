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

__all__ = ['Certificate']


class Certificate(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cer_blob: Optional[pulumi.Input[str]] = None,
                 expiration_date: Optional[pulumi.Input[str]] = None,
                 friendly_name: Optional[pulumi.Input[str]] = None,
                 host_names: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 hosting_environment_profile: Optional[pulumi.Input[pulumi.InputType['HostingEnvironmentProfileArgs']]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 issue_date: Optional[pulumi.Input[str]] = None,
                 issuer: Optional[pulumi.Input[str]] = None,
                 kind: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 password: Optional[pulumi.Input[str]] = None,
                 pfx_blob: Optional[pulumi.Input[str]] = None,
                 public_key_hash: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 self_link: Optional[pulumi.Input[str]] = None,
                 site_name: Optional[pulumi.Input[str]] = None,
                 subject_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 thumbprint: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 valid: Optional[pulumi.Input[bool]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        App certificate

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cer_blob: Raw bytes of .cer file
        :param pulumi.Input[str] expiration_date: Certificate expiration date
        :param pulumi.Input[str] friendly_name: Friendly name of the certificate
        :param pulumi.Input[Sequence[pulumi.Input[str]]] host_names: Host names the certificate applies to
        :param pulumi.Input[pulumi.InputType['HostingEnvironmentProfileArgs']] hosting_environment_profile: Specification for the hosting environment (App Service Environment) to use for the certificate
        :param pulumi.Input[str] id: Resource Id
        :param pulumi.Input[str] issue_date: Certificate issue Date
        :param pulumi.Input[str] issuer: Certificate issuer
        :param pulumi.Input[str] kind: Kind of resource
        :param pulumi.Input[str] location: Resource Location
        :param pulumi.Input[str] name: Resource Name
        :param pulumi.Input[str] password: Certificate password
        :param pulumi.Input[str] pfx_blob: Pfx blob
        :param pulumi.Input[str] public_key_hash: Public key hash
        :param pulumi.Input[str] resource_group_name: Name of the resource group
        :param pulumi.Input[str] self_link: Self link
        :param pulumi.Input[str] site_name: App name
        :param pulumi.Input[str] subject_name: Subject name of the certificate
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags
        :param pulumi.Input[str] thumbprint: Certificate thumbprint
        :param pulumi.Input[str] type: Resource type
        :param pulumi.Input[bool] valid: Is the certificate valid?
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

            __props__['cer_blob'] = cer_blob
            __props__['expiration_date'] = expiration_date
            __props__['friendly_name'] = friendly_name
            __props__['host_names'] = host_names
            __props__['hosting_environment_profile'] = hosting_environment_profile
            __props__['id'] = id
            __props__['issue_date'] = issue_date
            __props__['issuer'] = issuer
            __props__['kind'] = kind
            __props__['location'] = location
            if name is None and not opts.urn:
                raise TypeError("Missing required property 'name'")
            __props__['name'] = name
            __props__['password'] = password
            __props__['pfx_blob'] = pfx_blob
            __props__['public_key_hash'] = public_key_hash
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['self_link'] = self_link
            __props__['site_name'] = site_name
            __props__['subject_name'] = subject_name
            __props__['tags'] = tags
            __props__['thumbprint'] = thumbprint
            __props__['type'] = type
            __props__['valid'] = valid
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:web/latest:Certificate"), pulumi.Alias(type_="azure-nextgen:web/v20160301:Certificate"), pulumi.Alias(type_="azure-nextgen:web/v20180201:Certificate"), pulumi.Alias(type_="azure-nextgen:web/v20181101:Certificate"), pulumi.Alias(type_="azure-nextgen:web/v20190801:Certificate"), pulumi.Alias(type_="azure-nextgen:web/v20200601:Certificate"), pulumi.Alias(type_="azure-nextgen:web/v20200901:Certificate")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(Certificate, __self__).__init__(
            'azure-nextgen:web/v20150801:Certificate',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Certificate':
        """
        Get an existing Certificate resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return Certificate(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="cerBlob")
    def cer_blob(self) -> pulumi.Output[Optional[str]]:
        """
        Raw bytes of .cer file
        """
        return pulumi.get(self, "cer_blob")

    @property
    @pulumi.getter(name="expirationDate")
    def expiration_date(self) -> pulumi.Output[Optional[str]]:
        """
        Certificate expiration date
        """
        return pulumi.get(self, "expiration_date")

    @property
    @pulumi.getter(name="friendlyName")
    def friendly_name(self) -> pulumi.Output[Optional[str]]:
        """
        Friendly name of the certificate
        """
        return pulumi.get(self, "friendly_name")

    @property
    @pulumi.getter(name="hostNames")
    def host_names(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        Host names the certificate applies to
        """
        return pulumi.get(self, "host_names")

    @property
    @pulumi.getter(name="hostingEnvironmentProfile")
    def hosting_environment_profile(self) -> pulumi.Output[Optional['outputs.HostingEnvironmentProfileResponse']]:
        """
        Specification for the hosting environment (App Service Environment) to use for the certificate
        """
        return pulumi.get(self, "hosting_environment_profile")

    @property
    @pulumi.getter(name="issueDate")
    def issue_date(self) -> pulumi.Output[Optional[str]]:
        """
        Certificate issue Date
        """
        return pulumi.get(self, "issue_date")

    @property
    @pulumi.getter
    def issuer(self) -> pulumi.Output[Optional[str]]:
        """
        Certificate issuer
        """
        return pulumi.get(self, "issuer")

    @property
    @pulumi.getter
    def kind(self) -> pulumi.Output[Optional[str]]:
        """
        Kind of resource
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        Resource Location
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[Optional[str]]:
        """
        Resource Name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def password(self) -> pulumi.Output[Optional[str]]:
        """
        Certificate password
        """
        return pulumi.get(self, "password")

    @property
    @pulumi.getter(name="pfxBlob")
    def pfx_blob(self) -> pulumi.Output[Optional[str]]:
        """
        Pfx blob
        """
        return pulumi.get(self, "pfx_blob")

    @property
    @pulumi.getter(name="publicKeyHash")
    def public_key_hash(self) -> pulumi.Output[Optional[str]]:
        """
        Public key hash
        """
        return pulumi.get(self, "public_key_hash")

    @property
    @pulumi.getter(name="selfLink")
    def self_link(self) -> pulumi.Output[Optional[str]]:
        """
        Self link
        """
        return pulumi.get(self, "self_link")

    @property
    @pulumi.getter(name="siteName")
    def site_name(self) -> pulumi.Output[Optional[str]]:
        """
        App name
        """
        return pulumi.get(self, "site_name")

    @property
    @pulumi.getter(name="subjectName")
    def subject_name(self) -> pulumi.Output[Optional[str]]:
        """
        Subject name of the certificate
        """
        return pulumi.get(self, "subject_name")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Resource tags
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def thumbprint(self) -> pulumi.Output[Optional[str]]:
        """
        Certificate thumbprint
        """
        return pulumi.get(self, "thumbprint")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[Optional[str]]:
        """
        Resource type
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def valid(self) -> pulumi.Output[Optional[bool]]:
        """
        Is the certificate valid?
        """
        return pulumi.get(self, "valid")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

