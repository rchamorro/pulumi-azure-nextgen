# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from enum import Enum

__all__ = [
    'AacAudioProfile',
    'AssetContainerPermission',
    'ContentKeyPolicyFairPlayRentalAndLeaseKeyType',
    'ContentKeyPolicyPlayReadyContentType',
    'ContentKeyPolicyPlayReadyLicenseType',
    'ContentKeyPolicyPlayReadyUnknownOutputPassingOption',
    'ContentKeyPolicyRestrictionTokenType',
    'DeinterlaceMode',
    'DeinterlaceParity',
    'EncoderNamedPreset',
    'EntropyMode',
    'H264Complexity',
    'H264VideoProfile',
    'LiveEventEncodingType',
    'LiveEventInputProtocol',
    'OnErrorType',
    'Priority',
    'Rotation',
    'StorageAccountType',
    'StreamOptionsFlag',
    'StretchMode',
    'TrackPropertyCompareOperation',
    'TrackPropertyType',
]


class AacAudioProfile(str, Enum):
    """
    The encoding profile to be used when encoding audio with AAC.
    """
    AAC_LC = "AacLc"
    HE_AAC_V1 = "HeAacV1"
    HE_AAC_V2 = "HeAacV2"


class AssetContainerPermission(str, Enum):
    """
    The permissions to set on the SAS URL.
    """
    READ = "Read"
    READ_WRITE = "ReadWrite"
    READ_WRITE_DELETE = "ReadWriteDelete"


class ContentKeyPolicyFairPlayRentalAndLeaseKeyType(str, Enum):
    """
    The rental and lease key type.
    """
    UNKNOWN = "Unknown"
    UNDEFINED = "Undefined"
    PERSISTENT_UNLIMITED = "PersistentUnlimited"
    PERSISTENT_LIMITED = "PersistentLimited"


class ContentKeyPolicyPlayReadyContentType(str, Enum):
    """
    The PlayReady content type.
    """
    UNKNOWN = "Unknown"
    UNSPECIFIED = "Unspecified"
    ULTRA_VIOLET_DOWNLOAD = "UltraVioletDownload"
    ULTRA_VIOLET_STREAMING = "UltraVioletStreaming"


class ContentKeyPolicyPlayReadyLicenseType(str, Enum):
    """
    The license type.
    """
    UNKNOWN = "Unknown"
    NON_PERSISTENT = "NonPersistent"
    PERSISTENT = "Persistent"


class ContentKeyPolicyPlayReadyUnknownOutputPassingOption(str, Enum):
    """
    Configures Unknown output handling settings of the license.
    """
    UNKNOWN = "Unknown"
    NOT_ALLOWED = "NotAllowed"
    ALLOWED = "Allowed"
    ALLOWED_WITH_VIDEO_CONSTRICTION = "AllowedWithVideoConstriction"


class ContentKeyPolicyRestrictionTokenType(str, Enum):
    """
    The type of token.
    """
    UNKNOWN = "Unknown"
    SWT = "Swt"
    JWT = "Jwt"


class DeinterlaceMode(str, Enum):
    """
    The deinterlacing mode. Defaults to AutoPixelAdaptive.
    """
    OFF = "Off"
    AUTO_PIXEL_ADAPTIVE = "AutoPixelAdaptive"


class DeinterlaceParity(str, Enum):
    """
    The field parity for de-interlacing, defaults to Auto.
    """
    AUTO = "Auto"
    TOP_FIELD_FIRST = "TopFieldFirst"
    BOTTOM_FIELD_FIRST = "BottomFieldFirst"


class EncoderNamedPreset(str, Enum):
    """
    The built-in preset to be used for encoding videos.
    """
    ADAPTIVE_STREAMING = "AdaptiveStreaming"
    AAC_GOOD_QUALITY_AUDIO = "AACGoodQualityAudio"
    H264_MULTIPLE_BITRATE1080P = "H264MultipleBitrate1080p"
    H264_MULTIPLE_BITRATE720P = "H264MultipleBitrate720p"
    H264_MULTIPLE_BITRATE_SD = "H264MultipleBitrateSD"


class EntropyMode(str, Enum):
    """
    The entropy mode to be used for this layer. If not specified, the encoder chooses the mode that is appropriate for the profile and level.
    """
    CABAC = "Cabac"
    CAVLC = "Cavlc"


class H264Complexity(str, Enum):
    """
    Tells the encoder how to choose its encoding settings. The default value is Balanced.
    """
    SPEED = "Speed"
    BALANCED = "Balanced"
    QUALITY = "Quality"


class H264VideoProfile(str, Enum):
    """
    Which profile of the H.264 standard should be used when encoding this layer. Default is Auto.
    """
    AUTO = "Auto"
    BASELINE = "Baseline"
    MAIN = "Main"
    HIGH = "High"
    HIGH422 = "High422"
    HIGH444 = "High444"


class LiveEventEncodingType(str, Enum):
    """
    The encoding type for Live Event.
    """
    NONE = "None"
    BASIC = "Basic"


class LiveEventInputProtocol(str, Enum):
    """
    The streaming protocol for the Live Event.
    """
    FRAGMENTED_MP4 = "FragmentedMP4"
    RTMP = "RTMP"


class OnErrorType(str, Enum):
    """
    A Transform can define more than one outputs. This property defines what the service should do when one output fails - either continue to produce other outputs, or, stop the other outputs. The default is stop.
    """
    STOP_PROCESSING_JOB = "StopProcessingJob"
    CONTINUE_JOB = "ContinueJob"


class Priority(str, Enum):
    """
    Sets the relative priority of the TransformOutputs within a Transform. This sets the priority that the service uses for processing TransformOutputs. The default priority is Normal.
    """
    LOW = "Low"
    NORMAL = "Normal"
    HIGH = "High"


class Rotation(str, Enum):
    """
    The rotation, if any, to be applied to the input video, before it is encoded. Default is Auto
    """
    AUTO = "Auto"
    NONE = "None"
    ROTATE0 = "Rotate0"
    ROTATE90 = "Rotate90"
    ROTATE180 = "Rotate180"
    ROTATE270 = "Rotate270"


class StorageAccountType(str, Enum):
    """
    The type of the storage account.
    """
    PRIMARY = "Primary"
    SECONDARY = "Secondary"


class StreamOptionsFlag(str, Enum):
    DEFAULT = "Default"
    LOW_LATENCY = "LowLatency"


class StretchMode(str, Enum):
    """
    The resizing mode - how the input video will be resized to fit the desired output resolution(s). Default is AutoSize
    """
    NONE = "None"
    AUTO_SIZE = "AutoSize"
    AUTO_FIT = "AutoFit"


class TrackPropertyCompareOperation(str, Enum):
    """
    Track property condition operation
    """
    UNKNOWN = "Unknown"
    EQUAL = "Equal"


class TrackPropertyType(str, Enum):
    """
    Track property type
    """
    UNKNOWN = "Unknown"
    FOUR_CC = "FourCC"
