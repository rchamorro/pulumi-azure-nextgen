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
    'ApiConnectionDefinitionResponseProperties',
    'ApiConnectionTestLinkResponse',
    'ApiOAuthSettingsParameterResponse',
    'ApiOAuthSettingsResponse',
    'ApiReferenceResponse',
    'ApiResourceBackendServiceResponse',
    'ApiResourceDefinitionsResponse',
    'ConnectionErrorResponse',
    'ConnectionGatewayDefinitionResponseProperties',
    'ConnectionGatewayReferenceResponse',
    'ConnectionParameterResponse',
    'ConnectionStatusDefinitionResponse',
    'ConsentLinkDefinitionResponseResult',
    'CustomApiPropertiesDefinitionResponse',
    'WsdlDefinitionResponse',
    'WsdlServiceResponse',
]

@pulumi.output_type
class ApiConnectionDefinitionResponseProperties(dict):
    def __init__(__self__, *,
                 api: Optional['outputs.ApiReferenceResponse'] = None,
                 changed_time: Optional[str] = None,
                 created_time: Optional[str] = None,
                 custom_parameter_values: Optional[Mapping[str, str]] = None,
                 display_name: Optional[str] = None,
                 non_secret_parameter_values: Optional[Mapping[str, str]] = None,
                 parameter_values: Optional[Mapping[str, str]] = None,
                 statuses: Optional[Sequence['outputs.ConnectionStatusDefinitionResponse']] = None,
                 test_links: Optional[Sequence['outputs.ApiConnectionTestLinkResponse']] = None):
        """
        :param str changed_time: Timestamp of last connection change
        :param str created_time: Timestamp of the connection creation
        :param Mapping[str, str] custom_parameter_values: Dictionary of custom parameter values
        :param str display_name: Display name
        :param Mapping[str, str] non_secret_parameter_values: Dictionary of nonsecret parameter values
        :param Mapping[str, str] parameter_values: Dictionary of parameter values
        :param Sequence['ConnectionStatusDefinitionResponseArgs'] statuses: Status of the connection
        :param Sequence['ApiConnectionTestLinkResponseArgs'] test_links: Links to test the API connection
        """
        if api is not None:
            pulumi.set(__self__, "api", api)
        if changed_time is not None:
            pulumi.set(__self__, "changed_time", changed_time)
        if created_time is not None:
            pulumi.set(__self__, "created_time", created_time)
        if custom_parameter_values is not None:
            pulumi.set(__self__, "custom_parameter_values", custom_parameter_values)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if non_secret_parameter_values is not None:
            pulumi.set(__self__, "non_secret_parameter_values", non_secret_parameter_values)
        if parameter_values is not None:
            pulumi.set(__self__, "parameter_values", parameter_values)
        if statuses is not None:
            pulumi.set(__self__, "statuses", statuses)
        if test_links is not None:
            pulumi.set(__self__, "test_links", test_links)

    @property
    @pulumi.getter
    def api(self) -> Optional['outputs.ApiReferenceResponse']:
        return pulumi.get(self, "api")

    @property
    @pulumi.getter(name="changedTime")
    def changed_time(self) -> Optional[str]:
        """
        Timestamp of last connection change
        """
        return pulumi.get(self, "changed_time")

    @property
    @pulumi.getter(name="createdTime")
    def created_time(self) -> Optional[str]:
        """
        Timestamp of the connection creation
        """
        return pulumi.get(self, "created_time")

    @property
    @pulumi.getter(name="customParameterValues")
    def custom_parameter_values(self) -> Optional[Mapping[str, str]]:
        """
        Dictionary of custom parameter values
        """
        return pulumi.get(self, "custom_parameter_values")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> Optional[str]:
        """
        Display name
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter(name="nonSecretParameterValues")
    def non_secret_parameter_values(self) -> Optional[Mapping[str, str]]:
        """
        Dictionary of nonsecret parameter values
        """
        return pulumi.get(self, "non_secret_parameter_values")

    @property
    @pulumi.getter(name="parameterValues")
    def parameter_values(self) -> Optional[Mapping[str, str]]:
        """
        Dictionary of parameter values
        """
        return pulumi.get(self, "parameter_values")

    @property
    @pulumi.getter
    def statuses(self) -> Optional[Sequence['outputs.ConnectionStatusDefinitionResponse']]:
        """
        Status of the connection
        """
        return pulumi.get(self, "statuses")

    @property
    @pulumi.getter(name="testLinks")
    def test_links(self) -> Optional[Sequence['outputs.ApiConnectionTestLinkResponse']]:
        """
        Links to test the API connection
        """
        return pulumi.get(self, "test_links")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ApiConnectionTestLinkResponse(dict):
    """
    API connection properties
    """
    def __init__(__self__, *,
                 method: Optional[str] = None,
                 request_uri: Optional[str] = None):
        """
        API connection properties
        :param str method: HTTP Method
        :param str request_uri: Test link request URI
        """
        if method is not None:
            pulumi.set(__self__, "method", method)
        if request_uri is not None:
            pulumi.set(__self__, "request_uri", request_uri)

    @property
    @pulumi.getter
    def method(self) -> Optional[str]:
        """
        HTTP Method
        """
        return pulumi.get(self, "method")

    @property
    @pulumi.getter(name="requestUri")
    def request_uri(self) -> Optional[str]:
        """
        Test link request URI
        """
        return pulumi.get(self, "request_uri")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ApiOAuthSettingsParameterResponse(dict):
    """
    OAuth settings for the API
    """
    def __init__(__self__, *,
                 options: Optional[Any] = None,
                 ui_definition: Optional[Any] = None,
                 value: Optional[str] = None):
        """
        OAuth settings for the API
        :param Any options: Options available to this parameter
        :param Any ui_definition: UI definitions per culture as caller can specify the culture
        :param str value: Value of the setting
        """
        if options is not None:
            pulumi.set(__self__, "options", options)
        if ui_definition is not None:
            pulumi.set(__self__, "ui_definition", ui_definition)
        if value is not None:
            pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def options(self) -> Optional[Any]:
        """
        Options available to this parameter
        """
        return pulumi.get(self, "options")

    @property
    @pulumi.getter(name="uiDefinition")
    def ui_definition(self) -> Optional[Any]:
        """
        UI definitions per culture as caller can specify the culture
        """
        return pulumi.get(self, "ui_definition")

    @property
    @pulumi.getter
    def value(self) -> Optional[str]:
        """
        Value of the setting
        """
        return pulumi.get(self, "value")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ApiOAuthSettingsResponse(dict):
    """
    OAuth settings for the connection provider
    """
    def __init__(__self__, *,
                 client_id: Optional[str] = None,
                 client_secret: Optional[str] = None,
                 custom_parameters: Optional[Mapping[str, 'outputs.ApiOAuthSettingsParameterResponse']] = None,
                 identity_provider: Optional[str] = None,
                 properties: Optional[Any] = None,
                 redirect_url: Optional[str] = None,
                 scopes: Optional[Sequence[str]] = None):
        """
        OAuth settings for the connection provider
        :param str client_id: Resource provider client id
        :param str client_secret: Client Secret needed for OAuth
        :param Mapping[str, 'ApiOAuthSettingsParameterResponseArgs'] custom_parameters: OAuth parameters key is the name of parameter
        :param str identity_provider: Identity provider
        :param Any properties: Read only properties for this oauth setting.
        :param str redirect_url: Url
        :param Sequence[str] scopes: OAuth scopes
        """
        if client_id is not None:
            pulumi.set(__self__, "client_id", client_id)
        if client_secret is not None:
            pulumi.set(__self__, "client_secret", client_secret)
        if custom_parameters is not None:
            pulumi.set(__self__, "custom_parameters", custom_parameters)
        if identity_provider is not None:
            pulumi.set(__self__, "identity_provider", identity_provider)
        if properties is not None:
            pulumi.set(__self__, "properties", properties)
        if redirect_url is not None:
            pulumi.set(__self__, "redirect_url", redirect_url)
        if scopes is not None:
            pulumi.set(__self__, "scopes", scopes)

    @property
    @pulumi.getter(name="clientId")
    def client_id(self) -> Optional[str]:
        """
        Resource provider client id
        """
        return pulumi.get(self, "client_id")

    @property
    @pulumi.getter(name="clientSecret")
    def client_secret(self) -> Optional[str]:
        """
        Client Secret needed for OAuth
        """
        return pulumi.get(self, "client_secret")

    @property
    @pulumi.getter(name="customParameters")
    def custom_parameters(self) -> Optional[Mapping[str, 'outputs.ApiOAuthSettingsParameterResponse']]:
        """
        OAuth parameters key is the name of parameter
        """
        return pulumi.get(self, "custom_parameters")

    @property
    @pulumi.getter(name="identityProvider")
    def identity_provider(self) -> Optional[str]:
        """
        Identity provider
        """
        return pulumi.get(self, "identity_provider")

    @property
    @pulumi.getter
    def properties(self) -> Optional[Any]:
        """
        Read only properties for this oauth setting.
        """
        return pulumi.get(self, "properties")

    @property
    @pulumi.getter(name="redirectUrl")
    def redirect_url(self) -> Optional[str]:
        """
        Url
        """
        return pulumi.get(self, "redirect_url")

    @property
    @pulumi.getter
    def scopes(self) -> Optional[Sequence[str]]:
        """
        OAuth scopes
        """
        return pulumi.get(self, "scopes")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ApiReferenceResponse(dict):
    def __init__(__self__, *,
                 brand_color: Optional[str] = None,
                 description: Optional[str] = None,
                 display_name: Optional[str] = None,
                 icon_uri: Optional[str] = None,
                 id: Optional[str] = None,
                 name: Optional[str] = None,
                 swagger: Optional[Any] = None,
                 type: Optional[str] = None):
        """
        :param str brand_color: Brand color
        :param str description: The custom API description
        :param str display_name: The display name
        :param str icon_uri: The icon URI
        :param str id: Resource reference id
        :param str name: The name of the API
        :param Any swagger: The JSON representation of the swagger
        :param str type: Resource reference type
        """
        if brand_color is not None:
            pulumi.set(__self__, "brand_color", brand_color)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if icon_uri is not None:
            pulumi.set(__self__, "icon_uri", icon_uri)
        if id is not None:
            pulumi.set(__self__, "id", id)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if swagger is not None:
            pulumi.set(__self__, "swagger", swagger)
        if type is not None:
            pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="brandColor")
    def brand_color(self) -> Optional[str]:
        """
        Brand color
        """
        return pulumi.get(self, "brand_color")

    @property
    @pulumi.getter
    def description(self) -> Optional[str]:
        """
        The custom API description
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> Optional[str]:
        """
        The display name
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter(name="iconUri")
    def icon_uri(self) -> Optional[str]:
        """
        The icon URI
        """
        return pulumi.get(self, "icon_uri")

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        """
        Resource reference id
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        The name of the API
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def swagger(self) -> Optional[Any]:
        """
        The JSON representation of the swagger
        """
        return pulumi.get(self, "swagger")

    @property
    @pulumi.getter
    def type(self) -> Optional[str]:
        """
        Resource reference type
        """
        return pulumi.get(self, "type")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ApiResourceBackendServiceResponse(dict):
    """
    The API backend service
    """
    def __init__(__self__, *,
                 service_url: Optional[str] = None):
        """
        The API backend service
        :param str service_url: The service URL
        """
        if service_url is not None:
            pulumi.set(__self__, "service_url", service_url)

    @property
    @pulumi.getter(name="serviceUrl")
    def service_url(self) -> Optional[str]:
        """
        The service URL
        """
        return pulumi.get(self, "service_url")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ApiResourceDefinitionsResponse(dict):
    """
    API Definitions
    """
    def __init__(__self__, *,
                 modified_swagger_url: Optional[str] = None,
                 original_swagger_url: Optional[str] = None):
        """
        API Definitions
        :param str modified_swagger_url: The modified swagger URL
        :param str original_swagger_url: The original swagger URL
        """
        if modified_swagger_url is not None:
            pulumi.set(__self__, "modified_swagger_url", modified_swagger_url)
        if original_swagger_url is not None:
            pulumi.set(__self__, "original_swagger_url", original_swagger_url)

    @property
    @pulumi.getter(name="modifiedSwaggerUrl")
    def modified_swagger_url(self) -> Optional[str]:
        """
        The modified swagger URL
        """
        return pulumi.get(self, "modified_swagger_url")

    @property
    @pulumi.getter(name="originalSwaggerUrl")
    def original_swagger_url(self) -> Optional[str]:
        """
        The original swagger URL
        """
        return pulumi.get(self, "original_swagger_url")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ConnectionErrorResponse(dict):
    """
    Connection error
    """
    def __init__(__self__, *,
                 id: str,
                 name: str,
                 type: str,
                 code: Optional[str] = None,
                 etag: Optional[str] = None,
                 location: Optional[str] = None,
                 message: Optional[str] = None,
                 tags: Optional[Mapping[str, str]] = None):
        """
        Connection error
        :param str id: Resource id
        :param str name: Resource name
        :param str type: Resource type
        :param str code: Code of the status
        :param str etag: Resource ETag
        :param str location: Resource location
        :param str message: Description of the status
        :param Mapping[str, str] tags: Resource tags
        """
        pulumi.set(__self__, "id", id)
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "type", type)
        if code is not None:
            pulumi.set(__self__, "code", code)
        if etag is not None:
            pulumi.set(__self__, "etag", etag)
        if location is not None:
            pulumi.set(__self__, "location", location)
        if message is not None:
            pulumi.set(__self__, "message", message)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Resource id
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Resource name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Resource type
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def code(self) -> Optional[str]:
        """
        Code of the status
        """
        return pulumi.get(self, "code")

    @property
    @pulumi.getter
    def etag(self) -> Optional[str]:
        """
        Resource ETag
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter
    def location(self) -> Optional[str]:
        """
        Resource location
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def message(self) -> Optional[str]:
        """
        Description of the status
        """
        return pulumi.get(self, "message")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        Resource tags
        """
        return pulumi.get(self, "tags")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ConnectionGatewayDefinitionResponseProperties(dict):
    def __init__(__self__, *,
                 backend_uri: Optional[str] = None,
                 connection_gateway_installation: Optional['outputs.ConnectionGatewayReferenceResponse'] = None,
                 contact_information: Optional[Sequence[str]] = None,
                 description: Optional[str] = None,
                 display_name: Optional[str] = None,
                 machine_name: Optional[str] = None,
                 status: Optional[Any] = None):
        """
        :param str backend_uri: The URI of the backend
        :param 'ConnectionGatewayReferenceResponseArgs' connection_gateway_installation: The gateway installation reference
        :param Sequence[str] contact_information: The gateway admin
        :param str description: The gateway description
        :param str display_name: The gateway display name
        :param str machine_name: The machine name of the gateway
        :param Any status: The gateway status
        """
        if backend_uri is not None:
            pulumi.set(__self__, "backend_uri", backend_uri)
        if connection_gateway_installation is not None:
            pulumi.set(__self__, "connection_gateway_installation", connection_gateway_installation)
        if contact_information is not None:
            pulumi.set(__self__, "contact_information", contact_information)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if machine_name is not None:
            pulumi.set(__self__, "machine_name", machine_name)
        if status is not None:
            pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter(name="backendUri")
    def backend_uri(self) -> Optional[str]:
        """
        The URI of the backend
        """
        return pulumi.get(self, "backend_uri")

    @property
    @pulumi.getter(name="connectionGatewayInstallation")
    def connection_gateway_installation(self) -> Optional['outputs.ConnectionGatewayReferenceResponse']:
        """
        The gateway installation reference
        """
        return pulumi.get(self, "connection_gateway_installation")

    @property
    @pulumi.getter(name="contactInformation")
    def contact_information(self) -> Optional[Sequence[str]]:
        """
        The gateway admin
        """
        return pulumi.get(self, "contact_information")

    @property
    @pulumi.getter
    def description(self) -> Optional[str]:
        """
        The gateway description
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> Optional[str]:
        """
        The gateway display name
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter(name="machineName")
    def machine_name(self) -> Optional[str]:
        """
        The machine name of the gateway
        """
        return pulumi.get(self, "machine_name")

    @property
    @pulumi.getter
    def status(self) -> Optional[Any]:
        """
        The gateway status
        """
        return pulumi.get(self, "status")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ConnectionGatewayReferenceResponse(dict):
    """
    The gateway installation reference
    """
    def __init__(__self__, *,
                 id: Optional[str] = None,
                 location: Optional[str] = None,
                 name: Optional[str] = None,
                 type: Optional[str] = None):
        """
        The gateway installation reference
        :param str id: Resource reference id
        :param str location: Resource reference location
        :param str name: Resource reference name
        :param str type: Resource reference type
        """
        if id is not None:
            pulumi.set(__self__, "id", id)
        if location is not None:
            pulumi.set(__self__, "location", location)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if type is not None:
            pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        """
        Resource reference id
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def location(self) -> Optional[str]:
        """
        Resource reference location
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        Resource reference name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def type(self) -> Optional[str]:
        """
        Resource reference type
        """
        return pulumi.get(self, "type")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ConnectionParameterResponse(dict):
    """
    Connection provider parameters
    """
    def __init__(__self__, *,
                 o_auth_settings: Optional['outputs.ApiOAuthSettingsResponse'] = None,
                 type: Optional[str] = None):
        """
        Connection provider parameters
        :param 'ApiOAuthSettingsResponseArgs' o_auth_settings: OAuth settings for the connection provider
        :param str type: Type of the parameter
        """
        if o_auth_settings is not None:
            pulumi.set(__self__, "o_auth_settings", o_auth_settings)
        if type is not None:
            pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="oAuthSettings")
    def o_auth_settings(self) -> Optional['outputs.ApiOAuthSettingsResponse']:
        """
        OAuth settings for the connection provider
        """
        return pulumi.get(self, "o_auth_settings")

    @property
    @pulumi.getter
    def type(self) -> Optional[str]:
        """
        Type of the parameter
        """
        return pulumi.get(self, "type")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ConnectionStatusDefinitionResponse(dict):
    """
    Connection status
    """
    def __init__(__self__, *,
                 error: Optional['outputs.ConnectionErrorResponse'] = None,
                 status: Optional[str] = None,
                 target: Optional[str] = None):
        """
        Connection status
        :param 'ConnectionErrorResponseArgs' error: Connection error
        :param str status: The gateway status
        :param str target: Target of the error
        """
        if error is not None:
            pulumi.set(__self__, "error", error)
        if status is not None:
            pulumi.set(__self__, "status", status)
        if target is not None:
            pulumi.set(__self__, "target", target)

    @property
    @pulumi.getter
    def error(self) -> Optional['outputs.ConnectionErrorResponse']:
        """
        Connection error
        """
        return pulumi.get(self, "error")

    @property
    @pulumi.getter
    def status(self) -> Optional[str]:
        """
        The gateway status
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def target(self) -> Optional[str]:
        """
        Target of the error
        """
        return pulumi.get(self, "target")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ConsentLinkDefinitionResponseResult(dict):
    """
    A consent link
    """
    def __init__(__self__, *,
                 display_name: Optional[str] = None,
                 first_party_login_uri: Optional[str] = None,
                 link: Optional[str] = None,
                 status: Optional[str] = None):
        """
        A consent link
        :param str display_name: Display name of the parameter in the connection provider's OAuth settings
        :param str first_party_login_uri: URI for first party login
        :param str link: URI for the consent link
        :param str status: Status of the link
        """
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if first_party_login_uri is not None:
            pulumi.set(__self__, "first_party_login_uri", first_party_login_uri)
        if link is not None:
            pulumi.set(__self__, "link", link)
        if status is not None:
            pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> Optional[str]:
        """
        Display name of the parameter in the connection provider's OAuth settings
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter(name="firstPartyLoginUri")
    def first_party_login_uri(self) -> Optional[str]:
        """
        URI for first party login
        """
        return pulumi.get(self, "first_party_login_uri")

    @property
    @pulumi.getter
    def link(self) -> Optional[str]:
        """
        URI for the consent link
        """
        return pulumi.get(self, "link")

    @property
    @pulumi.getter
    def status(self) -> Optional[str]:
        """
        Status of the link
        """
        return pulumi.get(self, "status")


@pulumi.output_type
class CustomApiPropertiesDefinitionResponse(dict):
    """
    Custom API properties
    """
    def __init__(__self__, *,
                 api_definitions: Optional['outputs.ApiResourceDefinitionsResponse'] = None,
                 api_type: Optional[str] = None,
                 backend_service: Optional['outputs.ApiResourceBackendServiceResponse'] = None,
                 brand_color: Optional[str] = None,
                 capabilities: Optional[Sequence[str]] = None,
                 connection_parameters: Optional[Mapping[str, 'outputs.ConnectionParameterResponse']] = None,
                 description: Optional[str] = None,
                 display_name: Optional[str] = None,
                 icon_uri: Optional[str] = None,
                 runtime_urls: Optional[Sequence[str]] = None,
                 swagger: Optional[Any] = None,
                 wsdl_definition: Optional['outputs.WsdlDefinitionResponse'] = None):
        """
        Custom API properties
        :param 'ApiResourceDefinitionsResponseArgs' api_definitions: API Definitions
        :param str api_type: The API type
        :param 'ApiResourceBackendServiceResponseArgs' backend_service: The API backend service
        :param str brand_color: Brand color
        :param Sequence[str] capabilities: The custom API capabilities
        :param Mapping[str, 'ConnectionParameterResponseArgs'] connection_parameters: Connection parameters
        :param str description: The custom API description
        :param str display_name: The display name
        :param str icon_uri: The icon URI
        :param Sequence[str] runtime_urls: Runtime URLs
        :param Any swagger: The JSON representation of the swagger
        :param 'WsdlDefinitionResponseArgs' wsdl_definition: The WSDL definition
        """
        if api_definitions is not None:
            pulumi.set(__self__, "api_definitions", api_definitions)
        if api_type is not None:
            pulumi.set(__self__, "api_type", api_type)
        if backend_service is not None:
            pulumi.set(__self__, "backend_service", backend_service)
        if brand_color is not None:
            pulumi.set(__self__, "brand_color", brand_color)
        if capabilities is not None:
            pulumi.set(__self__, "capabilities", capabilities)
        if connection_parameters is not None:
            pulumi.set(__self__, "connection_parameters", connection_parameters)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if icon_uri is not None:
            pulumi.set(__self__, "icon_uri", icon_uri)
        if runtime_urls is not None:
            pulumi.set(__self__, "runtime_urls", runtime_urls)
        if swagger is not None:
            pulumi.set(__self__, "swagger", swagger)
        if wsdl_definition is not None:
            pulumi.set(__self__, "wsdl_definition", wsdl_definition)

    @property
    @pulumi.getter(name="apiDefinitions")
    def api_definitions(self) -> Optional['outputs.ApiResourceDefinitionsResponse']:
        """
        API Definitions
        """
        return pulumi.get(self, "api_definitions")

    @property
    @pulumi.getter(name="apiType")
    def api_type(self) -> Optional[str]:
        """
        The API type
        """
        return pulumi.get(self, "api_type")

    @property
    @pulumi.getter(name="backendService")
    def backend_service(self) -> Optional['outputs.ApiResourceBackendServiceResponse']:
        """
        The API backend service
        """
        return pulumi.get(self, "backend_service")

    @property
    @pulumi.getter(name="brandColor")
    def brand_color(self) -> Optional[str]:
        """
        Brand color
        """
        return pulumi.get(self, "brand_color")

    @property
    @pulumi.getter
    def capabilities(self) -> Optional[Sequence[str]]:
        """
        The custom API capabilities
        """
        return pulumi.get(self, "capabilities")

    @property
    @pulumi.getter(name="connectionParameters")
    def connection_parameters(self) -> Optional[Mapping[str, 'outputs.ConnectionParameterResponse']]:
        """
        Connection parameters
        """
        return pulumi.get(self, "connection_parameters")

    @property
    @pulumi.getter
    def description(self) -> Optional[str]:
        """
        The custom API description
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> Optional[str]:
        """
        The display name
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter(name="iconUri")
    def icon_uri(self) -> Optional[str]:
        """
        The icon URI
        """
        return pulumi.get(self, "icon_uri")

    @property
    @pulumi.getter(name="runtimeUrls")
    def runtime_urls(self) -> Optional[Sequence[str]]:
        """
        Runtime URLs
        """
        return pulumi.get(self, "runtime_urls")

    @property
    @pulumi.getter
    def swagger(self) -> Optional[Any]:
        """
        The JSON representation of the swagger
        """
        return pulumi.get(self, "swagger")

    @property
    @pulumi.getter(name="wsdlDefinition")
    def wsdl_definition(self) -> Optional['outputs.WsdlDefinitionResponse']:
        """
        The WSDL definition
        """
        return pulumi.get(self, "wsdl_definition")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class WsdlDefinitionResponse(dict):
    """
    The WSDL definition
    """
    def __init__(__self__, *,
                 content: Optional[str] = None,
                 import_method: Optional[str] = None,
                 service: Optional['outputs.WsdlServiceResponse'] = None,
                 url: Optional[str] = None):
        """
        The WSDL definition
        :param str content: The WSDL content
        :param str import_method: The WSDL import method
        :param 'WsdlServiceResponseArgs' service: The service with name and endpoint names
        :param str url: The WSDL URL
        """
        if content is not None:
            pulumi.set(__self__, "content", content)
        if import_method is not None:
            pulumi.set(__self__, "import_method", import_method)
        if service is not None:
            pulumi.set(__self__, "service", service)
        if url is not None:
            pulumi.set(__self__, "url", url)

    @property
    @pulumi.getter
    def content(self) -> Optional[str]:
        """
        The WSDL content
        """
        return pulumi.get(self, "content")

    @property
    @pulumi.getter(name="importMethod")
    def import_method(self) -> Optional[str]:
        """
        The WSDL import method
        """
        return pulumi.get(self, "import_method")

    @property
    @pulumi.getter
    def service(self) -> Optional['outputs.WsdlServiceResponse']:
        """
        The service with name and endpoint names
        """
        return pulumi.get(self, "service")

    @property
    @pulumi.getter
    def url(self) -> Optional[str]:
        """
        The WSDL URL
        """
        return pulumi.get(self, "url")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class WsdlServiceResponse(dict):
    """
    The service with name and endpoint names
    """
    def __init__(__self__, *,
                 qualified_name: str,
                 endpoint_qualified_names: Optional[Sequence[str]] = None):
        """
        The service with name and endpoint names
        :param str qualified_name: The service's qualified name
        :param Sequence[str] endpoint_qualified_names: List of the endpoints' qualified names
        """
        pulumi.set(__self__, "qualified_name", qualified_name)
        if endpoint_qualified_names is not None:
            pulumi.set(__self__, "endpoint_qualified_names", endpoint_qualified_names)

    @property
    @pulumi.getter(name="qualifiedName")
    def qualified_name(self) -> str:
        """
        The service's qualified name
        """
        return pulumi.get(self, "qualified_name")

    @property
    @pulumi.getter(name="endpointQualifiedNames")
    def endpoint_qualified_names(self) -> Optional[Sequence[str]]:
        """
        List of the endpoints' qualified names
        """
        return pulumi.get(self, "endpoint_qualified_names")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


