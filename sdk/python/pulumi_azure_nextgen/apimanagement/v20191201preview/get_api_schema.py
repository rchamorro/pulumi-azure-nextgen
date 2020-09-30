# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'GetApiSchemaResult',
    'AwaitableGetApiSchemaResult',
    'get_api_schema',
]

@pulumi.output_type
class GetApiSchemaResult:
    """
    Schema Contract details.
    """
    def __init__(__self__, content_type=None, definitions=None, name=None, type=None, value=None):
        if content_type and not isinstance(content_type, str):
            raise TypeError("Expected argument 'content_type' to be a str")
        pulumi.set(__self__, "content_type", content_type)
        if definitions and not isinstance(definitions, dict):
            raise TypeError("Expected argument 'definitions' to be a dict")
        pulumi.set(__self__, "definitions", definitions)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if value and not isinstance(value, str):
            raise TypeError("Expected argument 'value' to be a str")
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter(name="contentType")
    def content_type(self) -> str:
        """
        Must be a valid a media type used in a Content-Type header as defined in the RFC 2616. Media type of the schema document (e.g. application/json, application/xml). </br> - `Swagger` Schema use `application/vnd.ms-azure-apim.swagger.definitions+json` </br> - `WSDL` Schema use `application/vnd.ms-azure-apim.xsd+xml` </br> - `OpenApi` Schema use `application/vnd.oai.openapi.components+json` </br> - `WADL Schema` use `application/vnd.ms-azure-apim.wadl.grammars+xml`.
        """
        return pulumi.get(self, "content_type")

    @property
    @pulumi.getter
    def definitions(self) -> Optional[Any]:
        """
        Types definitions. Used for Swagger/OpenAPI schemas only, null otherwise.
        """
        return pulumi.get(self, "definitions")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Resource type for API Management resource.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def value(self) -> Optional[str]:
        """
        Json escaped string defining the document representing the Schema. Used for schemas other than Swagger/OpenAPI.
        """
        return pulumi.get(self, "value")


class AwaitableGetApiSchemaResult(GetApiSchemaResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetApiSchemaResult(
            content_type=self.content_type,
            definitions=self.definitions,
            name=self.name,
            type=self.type,
            value=self.value)


def get_api_schema(api_id: Optional[str] = None,
                   resource_group_name: Optional[str] = None,
                   schema_id: Optional[str] = None,
                   service_name: Optional[str] = None,
                   opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetApiSchemaResult:
    """
    Use this data source to access information about an existing resource.

    :param str api_id: API revision identifier. Must be unique in the current API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number.
    :param str resource_group_name: The name of the resource group.
    :param str schema_id: Schema identifier within an API. Must be unique in the current API Management service instance.
    :param str service_name: The name of the API Management service.
    """
    __args__ = dict()
    __args__['apiId'] = api_id
    __args__['resourceGroupName'] = resource_group_name
    __args__['schemaId'] = schema_id
    __args__['serviceName'] = service_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:apimanagement/v20191201preview:getApiSchema', __args__, opts=opts, typ=GetApiSchemaResult).value

    return AwaitableGetApiSchemaResult(
        content_type=__ret__.content_type,
        definitions=__ret__.definitions,
        name=__ret__.name,
        type=__ret__.type,
        value=__ret__.value)
