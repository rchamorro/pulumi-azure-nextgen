# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'GetSiteSourceControlResult',
    'AwaitableGetSiteSourceControlResult',
    'get_site_source_control',
]

@pulumi.output_type
class GetSiteSourceControlResult:
    """
    Describes the source control configuration for web app
    """
    def __init__(__self__, branch=None, deployment_rollback_enabled=None, is_manual_integration=None, is_mercurial=None, kind=None, location=None, name=None, repo_url=None, tags=None, type=None):
        if branch and not isinstance(branch, str):
            raise TypeError("Expected argument 'branch' to be a str")
        pulumi.set(__self__, "branch", branch)
        if deployment_rollback_enabled and not isinstance(deployment_rollback_enabled, bool):
            raise TypeError("Expected argument 'deployment_rollback_enabled' to be a bool")
        pulumi.set(__self__, "deployment_rollback_enabled", deployment_rollback_enabled)
        if is_manual_integration and not isinstance(is_manual_integration, bool):
            raise TypeError("Expected argument 'is_manual_integration' to be a bool")
        pulumi.set(__self__, "is_manual_integration", is_manual_integration)
        if is_mercurial and not isinstance(is_mercurial, bool):
            raise TypeError("Expected argument 'is_mercurial' to be a bool")
        pulumi.set(__self__, "is_mercurial", is_mercurial)
        if kind and not isinstance(kind, str):
            raise TypeError("Expected argument 'kind' to be a str")
        pulumi.set(__self__, "kind", kind)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if repo_url and not isinstance(repo_url, str):
            raise TypeError("Expected argument 'repo_url' to be a str")
        pulumi.set(__self__, "repo_url", repo_url)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def branch(self) -> Optional[str]:
        """
        Name of branch to use for deployment
        """
        return pulumi.get(self, "branch")

    @property
    @pulumi.getter(name="deploymentRollbackEnabled")
    def deployment_rollback_enabled(self) -> Optional[bool]:
        """
        Whether to manual or continuous integration
        """
        return pulumi.get(self, "deployment_rollback_enabled")

    @property
    @pulumi.getter(name="isManualIntegration")
    def is_manual_integration(self) -> Optional[bool]:
        """
        Whether to manual or continuous integration
        """
        return pulumi.get(self, "is_manual_integration")

    @property
    @pulumi.getter(name="isMercurial")
    def is_mercurial(self) -> Optional[bool]:
        """
        Mercurial or Git repository type
        """
        return pulumi.get(self, "is_mercurial")

    @property
    @pulumi.getter
    def kind(self) -> Optional[str]:
        """
        Kind of resource
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter
    def location(self) -> str:
        """
        Resource Location
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        Resource Name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="repoUrl")
    def repo_url(self) -> Optional[str]:
        """
        Repository or source control url
        """
        return pulumi.get(self, "repo_url")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        Resource tags
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> Optional[str]:
        """
        Resource type
        """
        return pulumi.get(self, "type")


class AwaitableGetSiteSourceControlResult(GetSiteSourceControlResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetSiteSourceControlResult(
            branch=self.branch,
            deployment_rollback_enabled=self.deployment_rollback_enabled,
            is_manual_integration=self.is_manual_integration,
            is_mercurial=self.is_mercurial,
            kind=self.kind,
            location=self.location,
            name=self.name,
            repo_url=self.repo_url,
            tags=self.tags,
            type=self.type)


def get_site_source_control(name: Optional[str] = None,
                            resource_group_name: Optional[str] = None,
                            opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetSiteSourceControlResult:
    """
    Use this data source to access information about an existing resource.

    :param str name: Name of web app
    :param str resource_group_name: Name of resource group
    """
    __args__ = dict()
    __args__['name'] = name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-nextgen:web/v20150801:getSiteSourceControl', __args__, opts=opts, typ=GetSiteSourceControlResult).value

    return AwaitableGetSiteSourceControlResult(
        branch=__ret__.branch,
        deployment_rollback_enabled=__ret__.deployment_rollback_enabled,
        is_manual_integration=__ret__.is_manual_integration,
        is_mercurial=__ret__.is_mercurial,
        kind=__ret__.kind,
        location=__ret__.location,
        name=__ret__.name,
        repo_url=__ret__.repo_url,
        tags=__ret__.tags,
        type=__ret__.type)