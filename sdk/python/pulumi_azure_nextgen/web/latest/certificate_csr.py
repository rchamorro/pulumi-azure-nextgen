# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = ['CertificateCsr']


class CertificateCsr(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 csr_string: Optional[pulumi.Input[str]] = None,
                 distinguished_name: Optional[pulumi.Input[str]] = None,
                 hosting_environment: Optional[pulumi.Input[str]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 kind: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 password: Optional[pulumi.Input[str]] = None,
                 pfx_blob: Optional[pulumi.Input[str]] = None,
                 public_key_hash: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Certificate signing request object
        Latest API Version: 2015-08-01.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] csr_string: Actual CSR string created
        :param pulumi.Input[str] distinguished_name: Distinguished name of certificate to be created
        :param pulumi.Input[str] hosting_environment: Hosting environment
        :param pulumi.Input[str] id: Resource Id
        :param pulumi.Input[str] kind: Kind of resource
        :param pulumi.Input[str] location: Resource Location
        :param pulumi.Input[str] name: Resource Name
        :param pulumi.Input[str] password: PFX password
        :param pulumi.Input[str] pfx_blob: PFX certificate of created certificate
        :param pulumi.Input[str] public_key_hash: Hash of the certificates public key
        :param pulumi.Input[str] resource_group_name: Name of the resource group
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags
        :param pulumi.Input[str] type: Resource type
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

            __props__['csr_string'] = csr_string
            __props__['distinguished_name'] = distinguished_name
            __props__['hosting_environment'] = hosting_environment
            __props__['id'] = id
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
            __props__['tags'] = tags
            __props__['type'] = type
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:web/v20150801:CertificateCsr")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(CertificateCsr, __self__).__init__(
            'azure-nextgen:web/latest:CertificateCsr',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'CertificateCsr':
        """
        Get an existing CertificateCsr resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return CertificateCsr(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="csrString")
    def csr_string(self) -> pulumi.Output[Optional[str]]:
        """
        Actual CSR string created
        """
        return pulumi.get(self, "csr_string")

    @property
    @pulumi.getter(name="distinguishedName")
    def distinguished_name(self) -> pulumi.Output[Optional[str]]:
        """
        Distinguished name of certificate to be created
        """
        return pulumi.get(self, "distinguished_name")

    @property
    @pulumi.getter(name="hostingEnvironment")
    def hosting_environment(self) -> pulumi.Output[Optional[str]]:
        """
        Hosting environment
        """
        return pulumi.get(self, "hosting_environment")

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
        PFX password
        """
        return pulumi.get(self, "password")

    @property
    @pulumi.getter(name="pfxBlob")
    def pfx_blob(self) -> pulumi.Output[Optional[str]]:
        """
        PFX certificate of created certificate
        """
        return pulumi.get(self, "pfx_blob")

    @property
    @pulumi.getter(name="publicKeyHash")
    def public_key_hash(self) -> pulumi.Output[Optional[str]]:
        """
        Hash of the certificates public key
        """
        return pulumi.get(self, "public_key_hash")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Resource tags
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[Optional[str]]:
        """
        Resource type
        """
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

