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
    'DatabaseProjectSummaryResponse',
    'DatabasesSolutionSummaryResponse',
    'MigrateProjectPropertiesResponse',
    'MigrateProjectResponseTags',
    'ServersProjectSummaryResponse',
    'ServersSolutionSummaryResponse',
    'SolutionDetailsResponse',
    'SolutionPropertiesResponse',
]

@pulumi.output_type
class DatabaseProjectSummaryResponse(dict):
    """
    The database project summary class.
    """
    def __init__(__self__, *,
                 instance_type: str,
                 extended_summary: Optional[Mapping[str, str]] = None,
                 last_summary_refreshed_time: Optional[str] = None,
                 refresh_summary_state: Optional[str] = None):
        """
        The database project summary class.
        :param str instance_type: Gets the Instance type.
        :param Mapping[str, str] extended_summary: Gets or sets the extended summary.
        :param str last_summary_refreshed_time: Gets or sets the time when summary was last refreshed.
        :param str refresh_summary_state: Gets or sets the state of refresh summary.
        """
        pulumi.set(__self__, "instance_type", 'Databases')
        if extended_summary is not None:
            pulumi.set(__self__, "extended_summary", extended_summary)
        if last_summary_refreshed_time is not None:
            pulumi.set(__self__, "last_summary_refreshed_time", last_summary_refreshed_time)
        if refresh_summary_state is not None:
            pulumi.set(__self__, "refresh_summary_state", refresh_summary_state)

    @property
    @pulumi.getter(name="instanceType")
    def instance_type(self) -> str:
        """
        Gets the Instance type.
        """
        return pulumi.get(self, "instance_type")

    @property
    @pulumi.getter(name="extendedSummary")
    def extended_summary(self) -> Optional[Mapping[str, str]]:
        """
        Gets or sets the extended summary.
        """
        return pulumi.get(self, "extended_summary")

    @property
    @pulumi.getter(name="lastSummaryRefreshedTime")
    def last_summary_refreshed_time(self) -> Optional[str]:
        """
        Gets or sets the time when summary was last refreshed.
        """
        return pulumi.get(self, "last_summary_refreshed_time")

    @property
    @pulumi.getter(name="refreshSummaryState")
    def refresh_summary_state(self) -> Optional[str]:
        """
        Gets or sets the state of refresh summary.
        """
        return pulumi.get(self, "refresh_summary_state")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class DatabasesSolutionSummaryResponse(dict):
    """
    Class representing the databases solution summary.
    """
    def __init__(__self__, *,
                 instance_type: str,
                 database_instances_assessed_count: Optional[int] = None,
                 databases_assessed_count: Optional[int] = None,
                 migration_ready_count: Optional[int] = None):
        """
        Class representing the databases solution summary.
        :param str instance_type: Gets the Instance type.
        :param int database_instances_assessed_count: Gets or sets the count of database instances assessed.
        :param int databases_assessed_count: Gets or sets the count of databases assessed.
        :param int migration_ready_count: Gets or sets the count of databases ready for migration.
        """
        pulumi.set(__self__, "instance_type", 'Databases')
        if database_instances_assessed_count is not None:
            pulumi.set(__self__, "database_instances_assessed_count", database_instances_assessed_count)
        if databases_assessed_count is not None:
            pulumi.set(__self__, "databases_assessed_count", databases_assessed_count)
        if migration_ready_count is not None:
            pulumi.set(__self__, "migration_ready_count", migration_ready_count)

    @property
    @pulumi.getter(name="instanceType")
    def instance_type(self) -> str:
        """
        Gets the Instance type.
        """
        return pulumi.get(self, "instance_type")

    @property
    @pulumi.getter(name="databaseInstancesAssessedCount")
    def database_instances_assessed_count(self) -> Optional[int]:
        """
        Gets or sets the count of database instances assessed.
        """
        return pulumi.get(self, "database_instances_assessed_count")

    @property
    @pulumi.getter(name="databasesAssessedCount")
    def databases_assessed_count(self) -> Optional[int]:
        """
        Gets or sets the count of databases assessed.
        """
        return pulumi.get(self, "databases_assessed_count")

    @property
    @pulumi.getter(name="migrationReadyCount")
    def migration_ready_count(self) -> Optional[int]:
        """
        Gets or sets the count of databases ready for migration.
        """
        return pulumi.get(self, "migration_ready_count")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class MigrateProjectPropertiesResponse(dict):
    """
    Class for migrate project properties.
    """
    def __init__(__self__, *,
                 last_summary_refreshed_time: str,
                 refresh_summary_state: str,
                 summary: Mapping[str, Any],
                 provisioning_state: Optional[str] = None,
                 registered_tools: Optional[Sequence[str]] = None):
        """
        Class for migrate project properties.
        :param str last_summary_refreshed_time: Gets the last time the project summary was refreshed.
        :param str refresh_summary_state: Gets the refresh summary state.
        :param Mapping[str, Union['DatabaseProjectSummaryResponseArgs', 'ServersProjectSummaryResponseArgs']] summary: Gets the summary of the migrate project.
        :param str provisioning_state: Provisioning state of the migrate project.
        :param Sequence[str] registered_tools: Gets or sets the list of tools registered with the migrate project.
        """
        pulumi.set(__self__, "last_summary_refreshed_time", last_summary_refreshed_time)
        pulumi.set(__self__, "refresh_summary_state", refresh_summary_state)
        pulumi.set(__self__, "summary", summary)
        if provisioning_state is not None:
            pulumi.set(__self__, "provisioning_state", provisioning_state)
        if registered_tools is not None:
            pulumi.set(__self__, "registered_tools", registered_tools)

    @property
    @pulumi.getter(name="lastSummaryRefreshedTime")
    def last_summary_refreshed_time(self) -> str:
        """
        Gets the last time the project summary was refreshed.
        """
        return pulumi.get(self, "last_summary_refreshed_time")

    @property
    @pulumi.getter(name="refreshSummaryState")
    def refresh_summary_state(self) -> str:
        """
        Gets the refresh summary state.
        """
        return pulumi.get(self, "refresh_summary_state")

    @property
    @pulumi.getter
    def summary(self) -> Mapping[str, Any]:
        """
        Gets the summary of the migrate project.
        """
        return pulumi.get(self, "summary")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> Optional[str]:
        """
        Provisioning state of the migrate project.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="registeredTools")
    def registered_tools(self) -> Optional[Sequence[str]]:
        """
        Gets or sets the list of tools registered with the migrate project.
        """
        return pulumi.get(self, "registered_tools")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class MigrateProjectResponseTags(dict):
    """
    Gets or sets the tags.
    """
    def __init__(__self__, *,
                 additional_properties: Optional[str] = None):
        """
        Gets or sets the tags.
        """
        if additional_properties is not None:
            pulumi.set(__self__, "additional_properties", additional_properties)

    @property
    @pulumi.getter(name="additionalProperties")
    def additional_properties(self) -> Optional[str]:
        return pulumi.get(self, "additional_properties")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ServersProjectSummaryResponse(dict):
    """
    Class representing the servers project summary.
    """
    def __init__(__self__, *,
                 instance_type: str,
                 assessed_count: Optional[int] = None,
                 discovered_count: Optional[int] = None,
                 extended_summary: Optional[Mapping[str, str]] = None,
                 last_summary_refreshed_time: Optional[str] = None,
                 migrated_count: Optional[int] = None,
                 refresh_summary_state: Optional[str] = None,
                 replicating_count: Optional[int] = None,
                 test_migrated_count: Optional[int] = None):
        """
        Class representing the servers project summary.
        :param str instance_type: Gets the Instance type.
        :param int assessed_count: Gets or sets the count of entities assessed.
        :param int discovered_count: Gets or sets the count of entities discovered.
        :param Mapping[str, str] extended_summary: Gets or sets the extended summary.
        :param str last_summary_refreshed_time: Gets or sets the time when summary was last refreshed.
        :param int migrated_count: Gets or sets the count of entities migrated.
        :param str refresh_summary_state: Gets or sets the state of refresh summary.
        :param int replicating_count: Gets or sets the count of entities being replicated.
        :param int test_migrated_count: Gets or sets the count of entities test migrated.
        """
        pulumi.set(__self__, "instance_type", 'Servers')
        if assessed_count is not None:
            pulumi.set(__self__, "assessed_count", assessed_count)
        if discovered_count is not None:
            pulumi.set(__self__, "discovered_count", discovered_count)
        if extended_summary is not None:
            pulumi.set(__self__, "extended_summary", extended_summary)
        if last_summary_refreshed_time is not None:
            pulumi.set(__self__, "last_summary_refreshed_time", last_summary_refreshed_time)
        if migrated_count is not None:
            pulumi.set(__self__, "migrated_count", migrated_count)
        if refresh_summary_state is not None:
            pulumi.set(__self__, "refresh_summary_state", refresh_summary_state)
        if replicating_count is not None:
            pulumi.set(__self__, "replicating_count", replicating_count)
        if test_migrated_count is not None:
            pulumi.set(__self__, "test_migrated_count", test_migrated_count)

    @property
    @pulumi.getter(name="instanceType")
    def instance_type(self) -> str:
        """
        Gets the Instance type.
        """
        return pulumi.get(self, "instance_type")

    @property
    @pulumi.getter(name="assessedCount")
    def assessed_count(self) -> Optional[int]:
        """
        Gets or sets the count of entities assessed.
        """
        return pulumi.get(self, "assessed_count")

    @property
    @pulumi.getter(name="discoveredCount")
    def discovered_count(self) -> Optional[int]:
        """
        Gets or sets the count of entities discovered.
        """
        return pulumi.get(self, "discovered_count")

    @property
    @pulumi.getter(name="extendedSummary")
    def extended_summary(self) -> Optional[Mapping[str, str]]:
        """
        Gets or sets the extended summary.
        """
        return pulumi.get(self, "extended_summary")

    @property
    @pulumi.getter(name="lastSummaryRefreshedTime")
    def last_summary_refreshed_time(self) -> Optional[str]:
        """
        Gets or sets the time when summary was last refreshed.
        """
        return pulumi.get(self, "last_summary_refreshed_time")

    @property
    @pulumi.getter(name="migratedCount")
    def migrated_count(self) -> Optional[int]:
        """
        Gets or sets the count of entities migrated.
        """
        return pulumi.get(self, "migrated_count")

    @property
    @pulumi.getter(name="refreshSummaryState")
    def refresh_summary_state(self) -> Optional[str]:
        """
        Gets or sets the state of refresh summary.
        """
        return pulumi.get(self, "refresh_summary_state")

    @property
    @pulumi.getter(name="replicatingCount")
    def replicating_count(self) -> Optional[int]:
        """
        Gets or sets the count of entities being replicated.
        """
        return pulumi.get(self, "replicating_count")

    @property
    @pulumi.getter(name="testMigratedCount")
    def test_migrated_count(self) -> Optional[int]:
        """
        Gets or sets the count of entities test migrated.
        """
        return pulumi.get(self, "test_migrated_count")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ServersSolutionSummaryResponse(dict):
    """
    Class representing the servers solution summary.
    """
    def __init__(__self__, *,
                 instance_type: str,
                 assessed_count: Optional[int] = None,
                 discovered_count: Optional[int] = None,
                 migrated_count: Optional[int] = None,
                 replicating_count: Optional[int] = None,
                 test_migrated_count: Optional[int] = None):
        """
        Class representing the servers solution summary.
        :param str instance_type: Gets the Instance type.
        :param int assessed_count: Gets or sets the count of servers assessed.
        :param int discovered_count: Gets or sets the count of servers discovered.
        :param int migrated_count: Gets or sets the count of servers migrated.
        :param int replicating_count: Gets or sets the count of servers being replicated.
        :param int test_migrated_count: Gets or sets the count of servers test migrated.
        """
        pulumi.set(__self__, "instance_type", 'Servers')
        if assessed_count is not None:
            pulumi.set(__self__, "assessed_count", assessed_count)
        if discovered_count is not None:
            pulumi.set(__self__, "discovered_count", discovered_count)
        if migrated_count is not None:
            pulumi.set(__self__, "migrated_count", migrated_count)
        if replicating_count is not None:
            pulumi.set(__self__, "replicating_count", replicating_count)
        if test_migrated_count is not None:
            pulumi.set(__self__, "test_migrated_count", test_migrated_count)

    @property
    @pulumi.getter(name="instanceType")
    def instance_type(self) -> str:
        """
        Gets the Instance type.
        """
        return pulumi.get(self, "instance_type")

    @property
    @pulumi.getter(name="assessedCount")
    def assessed_count(self) -> Optional[int]:
        """
        Gets or sets the count of servers assessed.
        """
        return pulumi.get(self, "assessed_count")

    @property
    @pulumi.getter(name="discoveredCount")
    def discovered_count(self) -> Optional[int]:
        """
        Gets or sets the count of servers discovered.
        """
        return pulumi.get(self, "discovered_count")

    @property
    @pulumi.getter(name="migratedCount")
    def migrated_count(self) -> Optional[int]:
        """
        Gets or sets the count of servers migrated.
        """
        return pulumi.get(self, "migrated_count")

    @property
    @pulumi.getter(name="replicatingCount")
    def replicating_count(self) -> Optional[int]:
        """
        Gets or sets the count of servers being replicated.
        """
        return pulumi.get(self, "replicating_count")

    @property
    @pulumi.getter(name="testMigratedCount")
    def test_migrated_count(self) -> Optional[int]:
        """
        Gets or sets the count of servers test migrated.
        """
        return pulumi.get(self, "test_migrated_count")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class SolutionDetailsResponse(dict):
    """
    Class representing the details of the solution.
    """
    def __init__(__self__, *,
                 assessment_count: Optional[int] = None,
                 extended_details: Optional[Mapping[str, str]] = None,
                 group_count: Optional[int] = None):
        """
        Class representing the details of the solution.
        :param int assessment_count: Gets or sets the count of assessments reported by the solution.
        :param Mapping[str, str] extended_details: Gets or sets the extended details reported by the solution.
        :param int group_count: Gets or sets the count of groups reported by the solution.
        """
        if assessment_count is not None:
            pulumi.set(__self__, "assessment_count", assessment_count)
        if extended_details is not None:
            pulumi.set(__self__, "extended_details", extended_details)
        if group_count is not None:
            pulumi.set(__self__, "group_count", group_count)

    @property
    @pulumi.getter(name="assessmentCount")
    def assessment_count(self) -> Optional[int]:
        """
        Gets or sets the count of assessments reported by the solution.
        """
        return pulumi.get(self, "assessment_count")

    @property
    @pulumi.getter(name="extendedDetails")
    def extended_details(self) -> Optional[Mapping[str, str]]:
        """
        Gets or sets the extended details reported by the solution.
        """
        return pulumi.get(self, "extended_details")

    @property
    @pulumi.getter(name="groupCount")
    def group_count(self) -> Optional[int]:
        """
        Gets or sets the count of groups reported by the solution.
        """
        return pulumi.get(self, "group_count")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class SolutionPropertiesResponse(dict):
    """
    Class for solution properties.
    """
    def __init__(__self__, *,
                 cleanup_state: Optional[str] = None,
                 details: Optional['outputs.SolutionDetailsResponse'] = None,
                 goal: Optional[str] = None,
                 purpose: Optional[str] = None,
                 status: Optional[str] = None,
                 summary: Optional[Any] = None,
                 tool: Optional[str] = None):
        """
        Class for solution properties.
        :param str cleanup_state: Gets or sets the cleanup state of the solution.
        :param 'SolutionDetailsResponseArgs' details: Gets or sets the details of the solution.
        :param str goal: Gets or sets the goal of the solution.
        :param str purpose: Gets or sets the purpose of the solution.
        :param str status: Gets or sets the current status of the solution.
        :param Union['DatabasesSolutionSummaryResponseArgs', 'ServersSolutionSummaryResponseArgs'] summary: Gets or sets the summary of the solution.
        :param str tool: Gets or sets the tool being used in the solution.
        """
        if cleanup_state is not None:
            pulumi.set(__self__, "cleanup_state", cleanup_state)
        if details is not None:
            pulumi.set(__self__, "details", details)
        if goal is not None:
            pulumi.set(__self__, "goal", goal)
        if purpose is not None:
            pulumi.set(__self__, "purpose", purpose)
        if status is not None:
            pulumi.set(__self__, "status", status)
        if summary is not None:
            pulumi.set(__self__, "summary", summary)
        if tool is not None:
            pulumi.set(__self__, "tool", tool)

    @property
    @pulumi.getter(name="cleanupState")
    def cleanup_state(self) -> Optional[str]:
        """
        Gets or sets the cleanup state of the solution.
        """
        return pulumi.get(self, "cleanup_state")

    @property
    @pulumi.getter
    def details(self) -> Optional['outputs.SolutionDetailsResponse']:
        """
        Gets or sets the details of the solution.
        """
        return pulumi.get(self, "details")

    @property
    @pulumi.getter
    def goal(self) -> Optional[str]:
        """
        Gets or sets the goal of the solution.
        """
        return pulumi.get(self, "goal")

    @property
    @pulumi.getter
    def purpose(self) -> Optional[str]:
        """
        Gets or sets the purpose of the solution.
        """
        return pulumi.get(self, "purpose")

    @property
    @pulumi.getter
    def status(self) -> Optional[str]:
        """
        Gets or sets the current status of the solution.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def summary(self) -> Optional[Any]:
        """
        Gets or sets the summary of the solution.
        """
        return pulumi.get(self, "summary")

    @property
    @pulumi.getter
    def tool(self) -> Optional[str]:
        """
        Gets or sets the tool being used in the solution.
        """
        return pulumi.get(self, "tool")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

