# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from . import outputs
from ._enums import *
from ._inputs import *

__all__ = ['Endpoint']


class Endpoint(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 content_types_to_compress: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 endpoint_name: Optional[pulumi.Input[str]] = None,
                 is_compression_enabled: Optional[pulumi.Input[bool]] = None,
                 is_http_allowed: Optional[pulumi.Input[bool]] = None,
                 is_https_allowed: Optional[pulumi.Input[bool]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 origin_host_header: Optional[pulumi.Input[str]] = None,
                 origin_path: Optional[pulumi.Input[str]] = None,
                 origins: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DeepCreatedOriginArgs']]]]] = None,
                 profile_name: Optional[pulumi.Input[str]] = None,
                 query_string_caching_behavior: Optional[pulumi.Input['QueryStringCachingBehavior']] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        CDN endpoint is the entity within a CDN profile containing configuration information regarding caching behaviors and origins. The CDN endpoint is exposed using the URL format <endpointname>.azureedge.net by default, but custom domains can also be created.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] content_types_to_compress: List of content types on which compression will be applied. The value for the elements should be a valid MIME type.
        :param pulumi.Input[str] endpoint_name: Name of the endpoint within the CDN profile.
        :param pulumi.Input[bool] is_compression_enabled: Indicates whether content compression is enabled. Default value is false. If compression is enabled, the content transferred from the CDN endpoint to the end user will be compressed. The requested content must be larger than 1 byte and smaller than 1 MB.
        :param pulumi.Input[bool] is_http_allowed: Indicates whether HTTP traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
        :param pulumi.Input[bool] is_https_allowed: Indicates whether https traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
        :param pulumi.Input[str] location: Endpoint location
        :param pulumi.Input[str] origin_host_header: The host header CDN provider will send along with content requests to origins. The default value is the host name of the origin.
        :param pulumi.Input[str] origin_path: The path used for origin requests.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DeepCreatedOriginArgs']]]] origins: The set of origins for the CDN endpoint. When multiple origins exist, the first origin will be used as primary and rest will be used as failover options.
        :param pulumi.Input[str] profile_name: Name of the CDN profile within the resource group.
        :param pulumi.Input['QueryStringCachingBehavior'] query_string_caching_behavior: Defines the query string caching behavior.
        :param pulumi.Input[str] resource_group_name: Name of the resource group within the Azure subscription.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Endpoint tags
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

            __props__['content_types_to_compress'] = content_types_to_compress
            if endpoint_name is None and not opts.urn:
                raise TypeError("Missing required property 'endpoint_name'")
            __props__['endpoint_name'] = endpoint_name
            __props__['is_compression_enabled'] = is_compression_enabled
            __props__['is_http_allowed'] = is_http_allowed
            __props__['is_https_allowed'] = is_https_allowed
            __props__['location'] = location
            __props__['origin_host_header'] = origin_host_header
            __props__['origin_path'] = origin_path
            if origins is None and not opts.urn:
                raise TypeError("Missing required property 'origins'")
            __props__['origins'] = origins
            if profile_name is None and not opts.urn:
                raise TypeError("Missing required property 'profile_name'")
            __props__['profile_name'] = profile_name
            __props__['query_string_caching_behavior'] = query_string_caching_behavior
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['tags'] = tags
            __props__['host_name'] = None
            __props__['name'] = None
            __props__['provisioning_state'] = None
            __props__['resource_state'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:cdn/latest:Endpoint"), pulumi.Alias(type_="azure-nextgen:cdn/v20150601:Endpoint"), pulumi.Alias(type_="azure-nextgen:cdn/v20161002:Endpoint"), pulumi.Alias(type_="azure-nextgen:cdn/v20170402:Endpoint"), pulumi.Alias(type_="azure-nextgen:cdn/v20171012:Endpoint"), pulumi.Alias(type_="azure-nextgen:cdn/v20190415:Endpoint"), pulumi.Alias(type_="azure-nextgen:cdn/v20190615:Endpoint"), pulumi.Alias(type_="azure-nextgen:cdn/v20190615preview:Endpoint"), pulumi.Alias(type_="azure-nextgen:cdn/v20191231:Endpoint"), pulumi.Alias(type_="azure-nextgen:cdn/v20200331:Endpoint"), pulumi.Alias(type_="azure-nextgen:cdn/v20200415:Endpoint"), pulumi.Alias(type_="azure-nextgen:cdn/v20200901:Endpoint")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(Endpoint, __self__).__init__(
            'azure-nextgen:cdn/v20160402:Endpoint',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Endpoint':
        """
        Get an existing Endpoint resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return Endpoint(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="contentTypesToCompress")
    def content_types_to_compress(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        List of content types on which compression will be applied. The value for the elements should be a valid MIME type.
        """
        return pulumi.get(self, "content_types_to_compress")

    @property
    @pulumi.getter(name="hostName")
    def host_name(self) -> pulumi.Output[str]:
        """
        The host name of the endpoint {endpointName}.{DNSZone}
        """
        return pulumi.get(self, "host_name")

    @property
    @pulumi.getter(name="isCompressionEnabled")
    def is_compression_enabled(self) -> pulumi.Output[Optional[bool]]:
        """
        Indicates whether the compression is enabled. Default value is false. If compression is enabled, the content transferred from cdn endpoint to end user will be compressed. The requested content must be larger than 1 byte and smaller than 1 MB.
        """
        return pulumi.get(self, "is_compression_enabled")

    @property
    @pulumi.getter(name="isHttpAllowed")
    def is_http_allowed(self) -> pulumi.Output[Optional[bool]]:
        """
        Indicates whether HTTP traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
        """
        return pulumi.get(self, "is_http_allowed")

    @property
    @pulumi.getter(name="isHttpsAllowed")
    def is_https_allowed(self) -> pulumi.Output[Optional[bool]]:
        """
        Indicates whether https traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
        """
        return pulumi.get(self, "is_https_allowed")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        Resource location
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="originHostHeader")
    def origin_host_header(self) -> pulumi.Output[Optional[str]]:
        """
        The host header the CDN provider will send along with content requests to origins. The default value is the host name of the origin.
        """
        return pulumi.get(self, "origin_host_header")

    @property
    @pulumi.getter(name="originPath")
    def origin_path(self) -> pulumi.Output[Optional[str]]:
        """
        The path used for origin requests.
        """
        return pulumi.get(self, "origin_path")

    @property
    @pulumi.getter
    def origins(self) -> pulumi.Output[Optional[Sequence['outputs.DeepCreatedOriginResponse']]]:
        """
        The set of origins for the CDN endpoint. When multiple origins exist, the first origin will be used as primary and rest will be used as failover options.
        """
        return pulumi.get(self, "origins")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        Provisioning status of the endpoint.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="queryStringCachingBehavior")
    def query_string_caching_behavior(self) -> pulumi.Output[Optional[str]]:
        """
        Defines the query string caching behavior.
        """
        return pulumi.get(self, "query_string_caching_behavior")

    @property
    @pulumi.getter(name="resourceState")
    def resource_state(self) -> pulumi.Output[str]:
        """
        Resource status of the endpoint.
        """
        return pulumi.get(self, "resource_state")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Mapping[str, str]]:
        """
        Resource tags
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Resource type
        """
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

