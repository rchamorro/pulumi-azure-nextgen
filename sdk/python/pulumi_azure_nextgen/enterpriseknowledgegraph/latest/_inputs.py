# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'EnterpriseKnowledgeGraphPropertiesArgs',
    'SkuArgs',
]

@pulumi.input_type
class EnterpriseKnowledgeGraphPropertiesArgs:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None,
                 metadata: Optional[Any] = None,
                 provisioning_state: Optional[pulumi.Input[str]] = None):
        """
        The parameters to provide for the EnterpriseKnowledgeGraph.
        :param pulumi.Input[str] description: The description of the EnterpriseKnowledgeGraph
        :param Any metadata: Specifies the metadata  of the resource.
        :param pulumi.Input[str] provisioning_state: The state of EnterpriseKnowledgeGraph provisioning
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if metadata is not None:
            pulumi.set(__self__, "metadata", metadata)
        if provisioning_state is not None:
            pulumi.set(__self__, "provisioning_state", provisioning_state)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        The description of the EnterpriseKnowledgeGraph
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def metadata(self) -> Optional[Any]:
        """
        Specifies the metadata  of the resource.
        """
        return pulumi.get(self, "metadata")

    @metadata.setter
    def metadata(self, value: Optional[Any]):
        pulumi.set(self, "metadata", value)

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> Optional[pulumi.Input[str]]:
        """
        The state of EnterpriseKnowledgeGraph provisioning
        """
        return pulumi.get(self, "provisioning_state")

    @provisioning_state.setter
    def provisioning_state(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "provisioning_state", value)


@pulumi.input_type
class SkuArgs:
    def __init__(__self__, *,
                 name: pulumi.Input[str]):
        """
        The SKU of the EnterpriseKnowledgeGraph service account.
        :param pulumi.Input[str] name: The sku name
        """
        pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        """
        The sku name
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)


