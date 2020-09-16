# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'AkamaiAccessControlArgs',
    'AkamaiSignatureHeaderAuthenticationKeyArgs',
    'CrossSiteAccessPoliciesArgs',
    'HlsArgs',
    'IPAccessControlArgs',
    'IPRangeArgs',
    'LiveEventEncodingArgs',
    'LiveEventEndpointArgs',
    'LiveEventInputArgs',
    'LiveEventInputAccessControlArgs',
    'LiveEventInputTrackSelectionArgs',
    'LiveEventOutputTranscriptionTrackArgs',
    'LiveEventPreviewArgs',
    'LiveEventPreviewAccessControlArgs',
    'LiveEventTranscriptionArgs',
    'StreamingEndpointAccessControlArgs',
]

@pulumi.input_type
class AkamaiAccessControlArgs:
    def __init__(__self__, *,
                 akamai_signature_header_authentication_key_list: Optional[pulumi.Input[Sequence[pulumi.Input['AkamaiSignatureHeaderAuthenticationKeyArgs']]]] = None):
        """
        Akamai access control
        :param pulumi.Input[Sequence[pulumi.Input['AkamaiSignatureHeaderAuthenticationKeyArgs']]] akamai_signature_header_authentication_key_list: authentication key list
        """
        if akamai_signature_header_authentication_key_list is not None:
            pulumi.set(__self__, "akamai_signature_header_authentication_key_list", akamai_signature_header_authentication_key_list)

    @property
    @pulumi.getter(name="akamaiSignatureHeaderAuthenticationKeyList")
    def akamai_signature_header_authentication_key_list(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['AkamaiSignatureHeaderAuthenticationKeyArgs']]]]:
        """
        authentication key list
        """
        return pulumi.get(self, "akamai_signature_header_authentication_key_list")

    @akamai_signature_header_authentication_key_list.setter
    def akamai_signature_header_authentication_key_list(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['AkamaiSignatureHeaderAuthenticationKeyArgs']]]]):
        pulumi.set(self, "akamai_signature_header_authentication_key_list", value)


@pulumi.input_type
class AkamaiSignatureHeaderAuthenticationKeyArgs:
    def __init__(__self__, *,
                 base64_key: Optional[pulumi.Input[str]] = None,
                 expiration: Optional[pulumi.Input[str]] = None,
                 identifier: Optional[pulumi.Input[str]] = None):
        """
        Akamai Signature Header authentication key.
        :param pulumi.Input[str] base64_key: authentication key
        :param pulumi.Input[str] expiration: The expiration time of the authentication key.
        :param pulumi.Input[str] identifier: identifier of the key
        """
        if base64_key is not None:
            pulumi.set(__self__, "base64_key", base64_key)
        if expiration is not None:
            pulumi.set(__self__, "expiration", expiration)
        if identifier is not None:
            pulumi.set(__self__, "identifier", identifier)

    @property
    @pulumi.getter(name="base64Key")
    def base64_key(self) -> Optional[pulumi.Input[str]]:
        """
        authentication key
        """
        return pulumi.get(self, "base64_key")

    @base64_key.setter
    def base64_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "base64_key", value)

    @property
    @pulumi.getter
    def expiration(self) -> Optional[pulumi.Input[str]]:
        """
        The expiration time of the authentication key.
        """
        return pulumi.get(self, "expiration")

    @expiration.setter
    def expiration(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "expiration", value)

    @property
    @pulumi.getter
    def identifier(self) -> Optional[pulumi.Input[str]]:
        """
        identifier of the key
        """
        return pulumi.get(self, "identifier")

    @identifier.setter
    def identifier(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "identifier", value)


@pulumi.input_type
class CrossSiteAccessPoliciesArgs:
    def __init__(__self__, *,
                 client_access_policy: Optional[pulumi.Input[str]] = None,
                 cross_domain_policy: Optional[pulumi.Input[str]] = None):
        """
        The client access policy.
        :param pulumi.Input[str] client_access_policy: The content of clientaccesspolicy.xml used by Silverlight.
        :param pulumi.Input[str] cross_domain_policy: The content of crossdomain.xml used by Silverlight.
        """
        if client_access_policy is not None:
            pulumi.set(__self__, "client_access_policy", client_access_policy)
        if cross_domain_policy is not None:
            pulumi.set(__self__, "cross_domain_policy", cross_domain_policy)

    @property
    @pulumi.getter(name="clientAccessPolicy")
    def client_access_policy(self) -> Optional[pulumi.Input[str]]:
        """
        The content of clientaccesspolicy.xml used by Silverlight.
        """
        return pulumi.get(self, "client_access_policy")

    @client_access_policy.setter
    def client_access_policy(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "client_access_policy", value)

    @property
    @pulumi.getter(name="crossDomainPolicy")
    def cross_domain_policy(self) -> Optional[pulumi.Input[str]]:
        """
        The content of crossdomain.xml used by Silverlight.
        """
        return pulumi.get(self, "cross_domain_policy")

    @cross_domain_policy.setter
    def cross_domain_policy(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cross_domain_policy", value)


@pulumi.input_type
class HlsArgs:
    def __init__(__self__, *,
                 fragments_per_ts_segment: Optional[pulumi.Input[int]] = None):
        """
        The HLS configuration.
        :param pulumi.Input[int] fragments_per_ts_segment: The amount of fragments per HTTP Live Streaming (HLS) segment.
        """
        if fragments_per_ts_segment is not None:
            pulumi.set(__self__, "fragments_per_ts_segment", fragments_per_ts_segment)

    @property
    @pulumi.getter(name="fragmentsPerTsSegment")
    def fragments_per_ts_segment(self) -> Optional[pulumi.Input[int]]:
        """
        The amount of fragments per HTTP Live Streaming (HLS) segment.
        """
        return pulumi.get(self, "fragments_per_ts_segment")

    @fragments_per_ts_segment.setter
    def fragments_per_ts_segment(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "fragments_per_ts_segment", value)


@pulumi.input_type
class IPAccessControlArgs:
    def __init__(__self__, *,
                 allow: Optional[pulumi.Input[Sequence[pulumi.Input['IPRangeArgs']]]] = None):
        """
        The IP access control.
        :param pulumi.Input[Sequence[pulumi.Input['IPRangeArgs']]] allow: The IP allow list.
        """
        if allow is not None:
            pulumi.set(__self__, "allow", allow)

    @property
    @pulumi.getter
    def allow(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['IPRangeArgs']]]]:
        """
        The IP allow list.
        """
        return pulumi.get(self, "allow")

    @allow.setter
    def allow(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['IPRangeArgs']]]]):
        pulumi.set(self, "allow", value)


@pulumi.input_type
class IPRangeArgs:
    def __init__(__self__, *,
                 address: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 subnet_prefix_length: Optional[pulumi.Input[int]] = None):
        """
        The IP address range in the CIDR scheme.
        :param pulumi.Input[str] address: The IP address.
        :param pulumi.Input[str] name: The friendly name for the IP address range.
        :param pulumi.Input[int] subnet_prefix_length: The subnet mask prefix length (see CIDR notation).
        """
        if address is not None:
            pulumi.set(__self__, "address", address)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if subnet_prefix_length is not None:
            pulumi.set(__self__, "subnet_prefix_length", subnet_prefix_length)

    @property
    @pulumi.getter
    def address(self) -> Optional[pulumi.Input[str]]:
        """
        The IP address.
        """
        return pulumi.get(self, "address")

    @address.setter
    def address(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "address", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The friendly name for the IP address range.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="subnetPrefixLength")
    def subnet_prefix_length(self) -> Optional[pulumi.Input[int]]:
        """
        The subnet mask prefix length (see CIDR notation).
        """
        return pulumi.get(self, "subnet_prefix_length")

    @subnet_prefix_length.setter
    def subnet_prefix_length(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "subnet_prefix_length", value)


@pulumi.input_type
class LiveEventEncodingArgs:
    def __init__(__self__, *,
                 encoding_type: Optional[pulumi.Input[str]] = None,
                 preset_name: Optional[pulumi.Input[str]] = None):
        """
        The Live Event encoding.
        :param pulumi.Input[str] encoding_type: The encoding type for Live Event.  This value is specified at creation time and cannot be updated.
        :param pulumi.Input[str] preset_name: The encoding preset name.  This value is specified at creation time and cannot be updated.
        """
        if encoding_type is not None:
            pulumi.set(__self__, "encoding_type", encoding_type)
        if preset_name is not None:
            pulumi.set(__self__, "preset_name", preset_name)

    @property
    @pulumi.getter(name="encodingType")
    def encoding_type(self) -> Optional[pulumi.Input[str]]:
        """
        The encoding type for Live Event.  This value is specified at creation time and cannot be updated.
        """
        return pulumi.get(self, "encoding_type")

    @encoding_type.setter
    def encoding_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "encoding_type", value)

    @property
    @pulumi.getter(name="presetName")
    def preset_name(self) -> Optional[pulumi.Input[str]]:
        """
        The encoding preset name.  This value is specified at creation time and cannot be updated.
        """
        return pulumi.get(self, "preset_name")

    @preset_name.setter
    def preset_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "preset_name", value)


@pulumi.input_type
class LiveEventEndpointArgs:
    def __init__(__self__, *,
                 protocol: Optional[pulumi.Input[str]] = None,
                 url: Optional[pulumi.Input[str]] = None):
        """
        The Live Event endpoint.
        :param pulumi.Input[str] protocol: The endpoint protocol.
        :param pulumi.Input[str] url: The endpoint URL.
        """
        if protocol is not None:
            pulumi.set(__self__, "protocol", protocol)
        if url is not None:
            pulumi.set(__self__, "url", url)

    @property
    @pulumi.getter
    def protocol(self) -> Optional[pulumi.Input[str]]:
        """
        The endpoint protocol.
        """
        return pulumi.get(self, "protocol")

    @protocol.setter
    def protocol(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "protocol", value)

    @property
    @pulumi.getter
    def url(self) -> Optional[pulumi.Input[str]]:
        """
        The endpoint URL.
        """
        return pulumi.get(self, "url")

    @url.setter
    def url(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "url", value)


@pulumi.input_type
class LiveEventInputArgs:
    def __init__(__self__, *,
                 streaming_protocol: pulumi.Input[str],
                 access_control: Optional[pulumi.Input['LiveEventInputAccessControlArgs']] = None,
                 access_token: Optional[pulumi.Input[str]] = None,
                 endpoints: Optional[pulumi.Input[Sequence[pulumi.Input['LiveEventEndpointArgs']]]] = None,
                 key_frame_interval_duration: Optional[pulumi.Input[str]] = None):
        """
        The Live Event input.
        :param pulumi.Input[str] streaming_protocol: The streaming protocol for the Live Event.  This is specified at creation time and cannot be updated.
        :param pulumi.Input['LiveEventInputAccessControlArgs'] access_control: The access control for LiveEvent Input.
        :param pulumi.Input[str] access_token: A unique identifier for a stream.  This can be specified at creation time but cannot be updated.  If omitted, the service will generate a unique value.
        :param pulumi.Input[Sequence[pulumi.Input['LiveEventEndpointArgs']]] endpoints: The input endpoints for the Live Event.
        :param pulumi.Input[str] key_frame_interval_duration: ISO 8601 timespan duration of the key frame interval duration.
        """
        pulumi.set(__self__, "streaming_protocol", streaming_protocol)
        if access_control is not None:
            pulumi.set(__self__, "access_control", access_control)
        if access_token is not None:
            pulumi.set(__self__, "access_token", access_token)
        if endpoints is not None:
            pulumi.set(__self__, "endpoints", endpoints)
        if key_frame_interval_duration is not None:
            pulumi.set(__self__, "key_frame_interval_duration", key_frame_interval_duration)

    @property
    @pulumi.getter(name="streamingProtocol")
    def streaming_protocol(self) -> pulumi.Input[str]:
        """
        The streaming protocol for the Live Event.  This is specified at creation time and cannot be updated.
        """
        return pulumi.get(self, "streaming_protocol")

    @streaming_protocol.setter
    def streaming_protocol(self, value: pulumi.Input[str]):
        pulumi.set(self, "streaming_protocol", value)

    @property
    @pulumi.getter(name="accessControl")
    def access_control(self) -> Optional[pulumi.Input['LiveEventInputAccessControlArgs']]:
        """
        The access control for LiveEvent Input.
        """
        return pulumi.get(self, "access_control")

    @access_control.setter
    def access_control(self, value: Optional[pulumi.Input['LiveEventInputAccessControlArgs']]):
        pulumi.set(self, "access_control", value)

    @property
    @pulumi.getter(name="accessToken")
    def access_token(self) -> Optional[pulumi.Input[str]]:
        """
        A unique identifier for a stream.  This can be specified at creation time but cannot be updated.  If omitted, the service will generate a unique value.
        """
        return pulumi.get(self, "access_token")

    @access_token.setter
    def access_token(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "access_token", value)

    @property
    @pulumi.getter
    def endpoints(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['LiveEventEndpointArgs']]]]:
        """
        The input endpoints for the Live Event.
        """
        return pulumi.get(self, "endpoints")

    @endpoints.setter
    def endpoints(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['LiveEventEndpointArgs']]]]):
        pulumi.set(self, "endpoints", value)

    @property
    @pulumi.getter(name="keyFrameIntervalDuration")
    def key_frame_interval_duration(self) -> Optional[pulumi.Input[str]]:
        """
        ISO 8601 timespan duration of the key frame interval duration.
        """
        return pulumi.get(self, "key_frame_interval_duration")

    @key_frame_interval_duration.setter
    def key_frame_interval_duration(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key_frame_interval_duration", value)


@pulumi.input_type
class LiveEventInputAccessControlArgs:
    def __init__(__self__, *,
                 ip: Optional[pulumi.Input['IPAccessControlArgs']] = None):
        """
        The IP access control for Live Event Input.
        :param pulumi.Input['IPAccessControlArgs'] ip: The IP access control properties.
        """
        if ip is not None:
            pulumi.set(__self__, "ip", ip)

    @property
    @pulumi.getter
    def ip(self) -> Optional[pulumi.Input['IPAccessControlArgs']]:
        """
        The IP access control properties.
        """
        return pulumi.get(self, "ip")

    @ip.setter
    def ip(self, value: Optional[pulumi.Input['IPAccessControlArgs']]):
        pulumi.set(self, "ip", value)


@pulumi.input_type
class LiveEventInputTrackSelectionArgs:
    def __init__(__self__, *,
                 operation: Optional[pulumi.Input[str]] = None,
                 property: Optional[pulumi.Input[str]] = None,
                 value: Optional[pulumi.Input[str]] = None):
        """
        A track selection condition.
        :param pulumi.Input[str] operation: Comparing operation.
        :param pulumi.Input[str] property: Property name to select.
        :param pulumi.Input[str] value: Property value to select.
        """
        if operation is not None:
            pulumi.set(__self__, "operation", operation)
        if property is not None:
            pulumi.set(__self__, "property", property)
        if value is not None:
            pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def operation(self) -> Optional[pulumi.Input[str]]:
        """
        Comparing operation.
        """
        return pulumi.get(self, "operation")

    @operation.setter
    def operation(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "operation", value)

    @property
    @pulumi.getter
    def value(self) -> Optional[pulumi.Input[str]]:
        """
        Property value to select.
        """
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "value", value)

    @property
    @pulumi.getter
    def property(self) -> Optional[pulumi.Input[str]]:
        """
        Property name to select.
        """
        return pulumi.get(self, "property")

    @property.setter
    def property(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "property", value)


@pulumi.input_type
class LiveEventOutputTranscriptionTrackArgs:
    def __init__(__self__, *,
                 track_name: pulumi.Input[str]):
        """
        Describes a transcription track in the output of a Live Event, generated using speech-to-text transcription.
        :param pulumi.Input[str] track_name: The output track name.
        """
        pulumi.set(__self__, "track_name", track_name)

    @property
    @pulumi.getter(name="trackName")
    def track_name(self) -> pulumi.Input[str]:
        """
        The output track name.
        """
        return pulumi.get(self, "track_name")

    @track_name.setter
    def track_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "track_name", value)


@pulumi.input_type
class LiveEventPreviewArgs:
    def __init__(__self__, *,
                 access_control: Optional[pulumi.Input['LiveEventPreviewAccessControlArgs']] = None,
                 alternative_media_id: Optional[pulumi.Input[str]] = None,
                 endpoints: Optional[pulumi.Input[Sequence[pulumi.Input['LiveEventEndpointArgs']]]] = None,
                 preview_locator: Optional[pulumi.Input[str]] = None,
                 streaming_policy_name: Optional[pulumi.Input[str]] = None):
        """
        The Live Event preview.
        :param pulumi.Input['LiveEventPreviewAccessControlArgs'] access_control: The access control for LiveEvent preview.
        :param pulumi.Input[str] alternative_media_id: An Alternative Media Identifier associated with the StreamingLocator created for the preview.  This value is specified at creation time and cannot be updated.  The identifier can be used in the CustomLicenseAcquisitionUrlTemplate or the CustomKeyAcquisitionUrlTemplate of the StreamingPolicy specified in the StreamingPolicyName field.
        :param pulumi.Input[Sequence[pulumi.Input['LiveEventEndpointArgs']]] endpoints: The endpoints for preview.
        :param pulumi.Input[str] preview_locator: The identifier of the preview locator in Guid format.  Specifying this at creation time allows the caller to know the preview locator url before the event is created.  If omitted, the service will generate a random identifier.  This value cannot be updated once the live event is created.
        :param pulumi.Input[str] streaming_policy_name: The name of streaming policy used for the LiveEvent preview.  This value is specified at creation time and cannot be updated.
        """
        if access_control is not None:
            pulumi.set(__self__, "access_control", access_control)
        if alternative_media_id is not None:
            pulumi.set(__self__, "alternative_media_id", alternative_media_id)
        if endpoints is not None:
            pulumi.set(__self__, "endpoints", endpoints)
        if preview_locator is not None:
            pulumi.set(__self__, "preview_locator", preview_locator)
        if streaming_policy_name is not None:
            pulumi.set(__self__, "streaming_policy_name", streaming_policy_name)

    @property
    @pulumi.getter(name="accessControl")
    def access_control(self) -> Optional[pulumi.Input['LiveEventPreviewAccessControlArgs']]:
        """
        The access control for LiveEvent preview.
        """
        return pulumi.get(self, "access_control")

    @access_control.setter
    def access_control(self, value: Optional[pulumi.Input['LiveEventPreviewAccessControlArgs']]):
        pulumi.set(self, "access_control", value)

    @property
    @pulumi.getter(name="alternativeMediaId")
    def alternative_media_id(self) -> Optional[pulumi.Input[str]]:
        """
        An Alternative Media Identifier associated with the StreamingLocator created for the preview.  This value is specified at creation time and cannot be updated.  The identifier can be used in the CustomLicenseAcquisitionUrlTemplate or the CustomKeyAcquisitionUrlTemplate of the StreamingPolicy specified in the StreamingPolicyName field.
        """
        return pulumi.get(self, "alternative_media_id")

    @alternative_media_id.setter
    def alternative_media_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "alternative_media_id", value)

    @property
    @pulumi.getter
    def endpoints(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['LiveEventEndpointArgs']]]]:
        """
        The endpoints for preview.
        """
        return pulumi.get(self, "endpoints")

    @endpoints.setter
    def endpoints(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['LiveEventEndpointArgs']]]]):
        pulumi.set(self, "endpoints", value)

    @property
    @pulumi.getter(name="previewLocator")
    def preview_locator(self) -> Optional[pulumi.Input[str]]:
        """
        The identifier of the preview locator in Guid format.  Specifying this at creation time allows the caller to know the preview locator url before the event is created.  If omitted, the service will generate a random identifier.  This value cannot be updated once the live event is created.
        """
        return pulumi.get(self, "preview_locator")

    @preview_locator.setter
    def preview_locator(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "preview_locator", value)

    @property
    @pulumi.getter(name="streamingPolicyName")
    def streaming_policy_name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of streaming policy used for the LiveEvent preview.  This value is specified at creation time and cannot be updated.
        """
        return pulumi.get(self, "streaming_policy_name")

    @streaming_policy_name.setter
    def streaming_policy_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "streaming_policy_name", value)


@pulumi.input_type
class LiveEventPreviewAccessControlArgs:
    def __init__(__self__, *,
                 ip: Optional[pulumi.Input['IPAccessControlArgs']] = None):
        """
        The IP access control for Live Event preview.
        :param pulumi.Input['IPAccessControlArgs'] ip: The IP access control properties.
        """
        if ip is not None:
            pulumi.set(__self__, "ip", ip)

    @property
    @pulumi.getter
    def ip(self) -> Optional[pulumi.Input['IPAccessControlArgs']]:
        """
        The IP access control properties.
        """
        return pulumi.get(self, "ip")

    @ip.setter
    def ip(self, value: Optional[pulumi.Input['IPAccessControlArgs']]):
        pulumi.set(self, "ip", value)


@pulumi.input_type
class LiveEventTranscriptionArgs:
    def __init__(__self__, *,
                 input_track_selection: Optional[pulumi.Input[Sequence[pulumi.Input['LiveEventInputTrackSelectionArgs']]]] = None,
                 language: Optional[pulumi.Input[str]] = None,
                 output_transcription_track: Optional[pulumi.Input['LiveEventOutputTranscriptionTrackArgs']] = None):
        """
        Describes the transcription tracks in the output of a Live Event, generated using speech-to-text transcription.
        :param pulumi.Input[Sequence[pulumi.Input['LiveEventInputTrackSelectionArgs']]] input_track_selection: Provides a mechanism to select the audio track in the input live feed, to which speech-to-text transcription is applied.
        :param pulumi.Input[str] language: Specifies the language (locale) used for speech-to-text transcription � it should match the spoken language in the audio track. The value should be in BCP-47 format of 'language tag-region' (e.g: 'en-US'). The list of supported languages are 'en-US' and 'en-GB'.
        :param pulumi.Input['LiveEventOutputTranscriptionTrackArgs'] output_transcription_track: Describes a transcription track in the output of a Live Event, generated using speech-to-text transcription.
        """
        if input_track_selection is not None:
            pulumi.set(__self__, "input_track_selection", input_track_selection)
        if language is not None:
            pulumi.set(__self__, "language", language)
        if output_transcription_track is not None:
            pulumi.set(__self__, "output_transcription_track", output_transcription_track)

    @property
    @pulumi.getter(name="inputTrackSelection")
    def input_track_selection(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['LiveEventInputTrackSelectionArgs']]]]:
        """
        Provides a mechanism to select the audio track in the input live feed, to which speech-to-text transcription is applied.
        """
        return pulumi.get(self, "input_track_selection")

    @input_track_selection.setter
    def input_track_selection(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['LiveEventInputTrackSelectionArgs']]]]):
        pulumi.set(self, "input_track_selection", value)

    @property
    @pulumi.getter
    def language(self) -> Optional[pulumi.Input[str]]:
        """
        Specifies the language (locale) used for speech-to-text transcription � it should match the spoken language in the audio track. The value should be in BCP-47 format of 'language tag-region' (e.g: 'en-US'). The list of supported languages are 'en-US' and 'en-GB'.
        """
        return pulumi.get(self, "language")

    @language.setter
    def language(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "language", value)

    @property
    @pulumi.getter(name="outputTranscriptionTrack")
    def output_transcription_track(self) -> Optional[pulumi.Input['LiveEventOutputTranscriptionTrackArgs']]:
        """
        Describes a transcription track in the output of a Live Event, generated using speech-to-text transcription.
        """
        return pulumi.get(self, "output_transcription_track")

    @output_transcription_track.setter
    def output_transcription_track(self, value: Optional[pulumi.Input['LiveEventOutputTranscriptionTrackArgs']]):
        pulumi.set(self, "output_transcription_track", value)


@pulumi.input_type
class StreamingEndpointAccessControlArgs:
    def __init__(__self__, *,
                 akamai: Optional[pulumi.Input['AkamaiAccessControlArgs']] = None,
                 ip: Optional[pulumi.Input['IPAccessControlArgs']] = None):
        """
        StreamingEndpoint access control definition.
        :param pulumi.Input['AkamaiAccessControlArgs'] akamai: The access control of Akamai
        :param pulumi.Input['IPAccessControlArgs'] ip: The IP access control of the StreamingEndpoint.
        """
        if akamai is not None:
            pulumi.set(__self__, "akamai", akamai)
        if ip is not None:
            pulumi.set(__self__, "ip", ip)

    @property
    @pulumi.getter
    def akamai(self) -> Optional[pulumi.Input['AkamaiAccessControlArgs']]:
        """
        The access control of Akamai
        """
        return pulumi.get(self, "akamai")

    @akamai.setter
    def akamai(self, value: Optional[pulumi.Input['AkamaiAccessControlArgs']]):
        pulumi.set(self, "akamai", value)

    @property
    @pulumi.getter
    def ip(self) -> Optional[pulumi.Input['IPAccessControlArgs']]:
        """
        The IP access control of the StreamingEndpoint.
        """
        return pulumi.get(self, "ip")

    @ip.setter
    def ip(self, value: Optional[pulumi.Input['IPAccessControlArgs']]):
        pulumi.set(self, "ip", value)

