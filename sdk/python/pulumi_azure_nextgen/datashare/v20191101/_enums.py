# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from enum import Enum

__all__ = [
    'Kind',
    'ShareKind',
    'Type',
]


class Kind(str, Enum):
    """
    Kind of synchronization
    """
    SCHEDULE_BASED = "ScheduleBased"


class ShareKind(str, Enum):
    """
    Share kind.
    """
    COPY_BASED = "CopyBased"
    IN_PLACE = "InPlace"


class Type(str, Enum):
    """
    Identity Type
    """
    SYSTEM_ASSIGNED = "SystemAssigned"
