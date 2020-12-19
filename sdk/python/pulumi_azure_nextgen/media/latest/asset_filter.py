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

__all__ = ['AssetFilter']


class AssetFilter(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 account_name: Optional[pulumi.Input[str]] = None,
                 asset_name: Optional[pulumi.Input[str]] = None,
                 filter_name: Optional[pulumi.Input[str]] = None,
                 first_quality: Optional[pulumi.Input[pulumi.InputType['FirstQualityArgs']]] = None,
                 presentation_time_range: Optional[pulumi.Input[pulumi.InputType['PresentationTimeRangeArgs']]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 tracks: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['FilterTrackSelectionArgs']]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        An Asset Filter.
        Latest API Version: 2020-05-01.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] account_name: The Media Services account name.
        :param pulumi.Input[str] asset_name: The Asset name.
        :param pulumi.Input[str] filter_name: The Asset Filter name
        :param pulumi.Input[pulumi.InputType['FirstQualityArgs']] first_quality: The first quality.
        :param pulumi.Input[pulumi.InputType['PresentationTimeRangeArgs']] presentation_time_range: The presentation time range.
        :param pulumi.Input[str] resource_group_name: The name of the resource group within the Azure subscription.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['FilterTrackSelectionArgs']]]] tracks: The tracks selection conditions.
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

            if account_name is None and not opts.urn:
                raise TypeError("Missing required property 'account_name'")
            __props__['account_name'] = account_name
            if asset_name is None and not opts.urn:
                raise TypeError("Missing required property 'asset_name'")
            __props__['asset_name'] = asset_name
            if filter_name is None and not opts.urn:
                raise TypeError("Missing required property 'filter_name'")
            __props__['filter_name'] = filter_name
            __props__['first_quality'] = first_quality
            __props__['presentation_time_range'] = presentation_time_range
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['tracks'] = tracks
            __props__['name'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:media/v20180701:AssetFilter"), pulumi.Alias(type_="azure-nextgen:media/v20200501:AssetFilter")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(AssetFilter, __self__).__init__(
            'azure-nextgen:media/latest:AssetFilter',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'AssetFilter':
        """
        Get an existing AssetFilter resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return AssetFilter(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="firstQuality")
    def first_quality(self) -> pulumi.Output[Optional['outputs.FirstQualityResponse']]:
        """
        The first quality.
        """
        return pulumi.get(self, "first_quality")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="presentationTimeRange")
    def presentation_time_range(self) -> pulumi.Output[Optional['outputs.PresentationTimeRangeResponse']]:
        """
        The presentation time range.
        """
        return pulumi.get(self, "presentation_time_range")

    @property
    @pulumi.getter
    def tracks(self) -> pulumi.Output[Optional[Sequence['outputs.FilterTrackSelectionResponse']]]:
        """
        The tracks selection conditions.
        """
        return pulumi.get(self, "tracks")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        """
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

