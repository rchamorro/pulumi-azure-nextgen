# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from ... import _utilities, _tables

__all__ = [
    'AssessmentPropertiesArgs',
    'CollectorAgentPropertiesArgs',
    'CollectorBodyAgentSpnPropertiesArgs',
    'CollectorPropertiesArgs',
    'ProjectPropertiesArgs',
    'VmUptimeArgs',
]

@pulumi.input_type
class AssessmentPropertiesArgs:
    def __init__(__self__, *,
                 azure_disk_type: pulumi.Input[str],
                 azure_hybrid_use_benefit: pulumi.Input[str],
                 azure_location: pulumi.Input[str],
                 azure_offer_code: pulumi.Input[str],
                 azure_pricing_tier: pulumi.Input[str],
                 azure_storage_redundancy: pulumi.Input[str],
                 azure_vm_families: pulumi.Input[List[pulumi.Input[str]]],
                 currency: pulumi.Input[str],
                 discount_percentage: pulumi.Input[float],
                 percentile: pulumi.Input[str],
                 reserved_instance: pulumi.Input[str],
                 scaling_factor: pulumi.Input[float],
                 sizing_criterion: pulumi.Input[str],
                 stage: pulumi.Input[str],
                 time_range: pulumi.Input[str],
                 vm_uptime: pulumi.Input['VmUptimeArgs']):
        """
        Properties of an assessment.
        :param pulumi.Input[str] azure_disk_type: Storage type selected for this disk.
        :param pulumi.Input[str] azure_hybrid_use_benefit: AHUB discount on windows virtual machines.
        :param pulumi.Input[str] azure_location: Target Azure location for which the machines should be assessed. These enums are the same as used by Compute API.
        :param pulumi.Input[str] azure_offer_code: Offer code according to which cost estimation is done.
        :param pulumi.Input[str] azure_pricing_tier: Pricing tier for Size evaluation.
        :param pulumi.Input[str] azure_storage_redundancy: Storage Redundancy type offered by Azure.
        :param pulumi.Input[List[pulumi.Input[str]]] azure_vm_families: List of azure VM families.
        :param pulumi.Input[str] currency: Currency to report prices in.
        :param pulumi.Input[float] discount_percentage: Custom discount percentage to be applied on final costs. Can be in the range [0, 100].
        :param pulumi.Input[str] percentile: Percentile of performance data used to recommend Azure size.
        :param pulumi.Input[str] reserved_instance: Azure reserved instance.
        :param pulumi.Input[float] scaling_factor: Scaling factor used over utilization data to add a performance buffer for new machines to be created in Azure. Min Value = 1.0, Max value = 1.9, Default = 1.3.
        :param pulumi.Input[str] sizing_criterion: Assessment sizing criterion.
        :param pulumi.Input[str] stage: User configurable setting that describes the status of the assessment.
        :param pulumi.Input[str] time_range: Time range of performance data used to recommend a size.
        :param pulumi.Input['VmUptimeArgs'] vm_uptime: Specify the duration for which the VMs are up in the on-premises environment.
        """
        pulumi.set(__self__, "azure_disk_type", azure_disk_type)
        pulumi.set(__self__, "azure_hybrid_use_benefit", azure_hybrid_use_benefit)
        pulumi.set(__self__, "azure_location", azure_location)
        pulumi.set(__self__, "azure_offer_code", azure_offer_code)
        pulumi.set(__self__, "azure_pricing_tier", azure_pricing_tier)
        pulumi.set(__self__, "azure_storage_redundancy", azure_storage_redundancy)
        pulumi.set(__self__, "azure_vm_families", azure_vm_families)
        pulumi.set(__self__, "currency", currency)
        pulumi.set(__self__, "discount_percentage", discount_percentage)
        pulumi.set(__self__, "percentile", percentile)
        pulumi.set(__self__, "reserved_instance", reserved_instance)
        pulumi.set(__self__, "scaling_factor", scaling_factor)
        pulumi.set(__self__, "sizing_criterion", sizing_criterion)
        pulumi.set(__self__, "stage", stage)
        pulumi.set(__self__, "time_range", time_range)
        pulumi.set(__self__, "vm_uptime", vm_uptime)

    @property
    @pulumi.getter(name="azureDiskType")
    def azure_disk_type(self) -> pulumi.Input[str]:
        """
        Storage type selected for this disk.
        """
        return pulumi.get(self, "azure_disk_type")

    @azure_disk_type.setter
    def azure_disk_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "azure_disk_type", value)

    @property
    @pulumi.getter(name="azureHybridUseBenefit")
    def azure_hybrid_use_benefit(self) -> pulumi.Input[str]:
        """
        AHUB discount on windows virtual machines.
        """
        return pulumi.get(self, "azure_hybrid_use_benefit")

    @azure_hybrid_use_benefit.setter
    def azure_hybrid_use_benefit(self, value: pulumi.Input[str]):
        pulumi.set(self, "azure_hybrid_use_benefit", value)

    @property
    @pulumi.getter(name="azureLocation")
    def azure_location(self) -> pulumi.Input[str]:
        """
        Target Azure location for which the machines should be assessed. These enums are the same as used by Compute API.
        """
        return pulumi.get(self, "azure_location")

    @azure_location.setter
    def azure_location(self, value: pulumi.Input[str]):
        pulumi.set(self, "azure_location", value)

    @property
    @pulumi.getter(name="azureOfferCode")
    def azure_offer_code(self) -> pulumi.Input[str]:
        """
        Offer code according to which cost estimation is done.
        """
        return pulumi.get(self, "azure_offer_code")

    @azure_offer_code.setter
    def azure_offer_code(self, value: pulumi.Input[str]):
        pulumi.set(self, "azure_offer_code", value)

    @property
    @pulumi.getter(name="azurePricingTier")
    def azure_pricing_tier(self) -> pulumi.Input[str]:
        """
        Pricing tier for Size evaluation.
        """
        return pulumi.get(self, "azure_pricing_tier")

    @azure_pricing_tier.setter
    def azure_pricing_tier(self, value: pulumi.Input[str]):
        pulumi.set(self, "azure_pricing_tier", value)

    @property
    @pulumi.getter(name="azureStorageRedundancy")
    def azure_storage_redundancy(self) -> pulumi.Input[str]:
        """
        Storage Redundancy type offered by Azure.
        """
        return pulumi.get(self, "azure_storage_redundancy")

    @azure_storage_redundancy.setter
    def azure_storage_redundancy(self, value: pulumi.Input[str]):
        pulumi.set(self, "azure_storage_redundancy", value)

    @property
    @pulumi.getter(name="azureVmFamilies")
    def azure_vm_families(self) -> pulumi.Input[List[pulumi.Input[str]]]:
        """
        List of azure VM families.
        """
        return pulumi.get(self, "azure_vm_families")

    @azure_vm_families.setter
    def azure_vm_families(self, value: pulumi.Input[List[pulumi.Input[str]]]):
        pulumi.set(self, "azure_vm_families", value)

    @property
    @pulumi.getter
    def currency(self) -> pulumi.Input[str]:
        """
        Currency to report prices in.
        """
        return pulumi.get(self, "currency")

    @currency.setter
    def currency(self, value: pulumi.Input[str]):
        pulumi.set(self, "currency", value)

    @property
    @pulumi.getter(name="discountPercentage")
    def discount_percentage(self) -> pulumi.Input[float]:
        """
        Custom discount percentage to be applied on final costs. Can be in the range [0, 100].
        """
        return pulumi.get(self, "discount_percentage")

    @discount_percentage.setter
    def discount_percentage(self, value: pulumi.Input[float]):
        pulumi.set(self, "discount_percentage", value)

    @property
    @pulumi.getter
    def percentile(self) -> pulumi.Input[str]:
        """
        Percentile of performance data used to recommend Azure size.
        """
        return pulumi.get(self, "percentile")

    @percentile.setter
    def percentile(self, value: pulumi.Input[str]):
        pulumi.set(self, "percentile", value)

    @property
    @pulumi.getter(name="reservedInstance")
    def reserved_instance(self) -> pulumi.Input[str]:
        """
        Azure reserved instance.
        """
        return pulumi.get(self, "reserved_instance")

    @reserved_instance.setter
    def reserved_instance(self, value: pulumi.Input[str]):
        pulumi.set(self, "reserved_instance", value)

    @property
    @pulumi.getter(name="scalingFactor")
    def scaling_factor(self) -> pulumi.Input[float]:
        """
        Scaling factor used over utilization data to add a performance buffer for new machines to be created in Azure. Min Value = 1.0, Max value = 1.9, Default = 1.3.
        """
        return pulumi.get(self, "scaling_factor")

    @scaling_factor.setter
    def scaling_factor(self, value: pulumi.Input[float]):
        pulumi.set(self, "scaling_factor", value)

    @property
    @pulumi.getter(name="sizingCriterion")
    def sizing_criterion(self) -> pulumi.Input[str]:
        """
        Assessment sizing criterion.
        """
        return pulumi.get(self, "sizing_criterion")

    @sizing_criterion.setter
    def sizing_criterion(self, value: pulumi.Input[str]):
        pulumi.set(self, "sizing_criterion", value)

    @property
    @pulumi.getter
    def stage(self) -> pulumi.Input[str]:
        """
        User configurable setting that describes the status of the assessment.
        """
        return pulumi.get(self, "stage")

    @stage.setter
    def stage(self, value: pulumi.Input[str]):
        pulumi.set(self, "stage", value)

    @property
    @pulumi.getter(name="timeRange")
    def time_range(self) -> pulumi.Input[str]:
        """
        Time range of performance data used to recommend a size.
        """
        return pulumi.get(self, "time_range")

    @time_range.setter
    def time_range(self, value: pulumi.Input[str]):
        pulumi.set(self, "time_range", value)

    @property
    @pulumi.getter(name="vmUptime")
    def vm_uptime(self) -> pulumi.Input['VmUptimeArgs']:
        """
        Specify the duration for which the VMs are up in the on-premises environment.
        """
        return pulumi.get(self, "vm_uptime")

    @vm_uptime.setter
    def vm_uptime(self, value: pulumi.Input['VmUptimeArgs']):
        pulumi.set(self, "vm_uptime", value)


@pulumi.input_type
class CollectorAgentPropertiesArgs:
    def __init__(__self__, *,
                 spn_details: Optional[pulumi.Input['CollectorBodyAgentSpnPropertiesArgs']] = None):
        if spn_details is not None:
            pulumi.set(__self__, "spn_details", spn_details)

    @property
    @pulumi.getter(name="spnDetails")
    def spn_details(self) -> Optional[pulumi.Input['CollectorBodyAgentSpnPropertiesArgs']]:
        return pulumi.get(self, "spn_details")

    @spn_details.setter
    def spn_details(self, value: Optional[pulumi.Input['CollectorBodyAgentSpnPropertiesArgs']]):
        pulumi.set(self, "spn_details", value)


@pulumi.input_type
class CollectorBodyAgentSpnPropertiesArgs:
    def __init__(__self__, *,
                 application_id: Optional[pulumi.Input[str]] = None,
                 audience: Optional[pulumi.Input[str]] = None,
                 authority: Optional[pulumi.Input[str]] = None,
                 object_id: Optional[pulumi.Input[str]] = None,
                 tenant_id: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] application_id: Application/client Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services.
        :param pulumi.Input[str] audience: Intended audience for the service principal.
        :param pulumi.Input[str] authority: AAD Authority URL which was used to request the token for the service principal.
        :param pulumi.Input[str] object_id: Object Id of the service principal with which the on-premise management/data plane components would communicate with our Azure services.
        :param pulumi.Input[str] tenant_id: Tenant Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services.
        """
        if application_id is not None:
            pulumi.set(__self__, "application_id", application_id)
        if audience is not None:
            pulumi.set(__self__, "audience", audience)
        if authority is not None:
            pulumi.set(__self__, "authority", authority)
        if object_id is not None:
            pulumi.set(__self__, "object_id", object_id)
        if tenant_id is not None:
            pulumi.set(__self__, "tenant_id", tenant_id)

    @property
    @pulumi.getter(name="applicationId")
    def application_id(self) -> Optional[pulumi.Input[str]]:
        """
        Application/client Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services.
        """
        return pulumi.get(self, "application_id")

    @application_id.setter
    def application_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "application_id", value)

    @property
    @pulumi.getter
    def audience(self) -> Optional[pulumi.Input[str]]:
        """
        Intended audience for the service principal.
        """
        return pulumi.get(self, "audience")

    @audience.setter
    def audience(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "audience", value)

    @property
    @pulumi.getter
    def authority(self) -> Optional[pulumi.Input[str]]:
        """
        AAD Authority URL which was used to request the token for the service principal.
        """
        return pulumi.get(self, "authority")

    @authority.setter
    def authority(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "authority", value)

    @property
    @pulumi.getter(name="objectId")
    def object_id(self) -> Optional[pulumi.Input[str]]:
        """
        Object Id of the service principal with which the on-premise management/data plane components would communicate with our Azure services.
        """
        return pulumi.get(self, "object_id")

    @object_id.setter
    def object_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "object_id", value)

    @property
    @pulumi.getter(name="tenantId")
    def tenant_id(self) -> Optional[pulumi.Input[str]]:
        """
        Tenant Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services.
        """
        return pulumi.get(self, "tenant_id")

    @tenant_id.setter
    def tenant_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "tenant_id", value)


@pulumi.input_type
class CollectorPropertiesArgs:
    def __init__(__self__, *,
                 agent_properties: Optional[pulumi.Input['CollectorAgentPropertiesArgs']] = None,
                 discovery_site_id: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] discovery_site_id: The ARM id of the discovery service site.
        """
        if agent_properties is not None:
            pulumi.set(__self__, "agent_properties", agent_properties)
        if discovery_site_id is not None:
            pulumi.set(__self__, "discovery_site_id", discovery_site_id)

    @property
    @pulumi.getter(name="agentProperties")
    def agent_properties(self) -> Optional[pulumi.Input['CollectorAgentPropertiesArgs']]:
        return pulumi.get(self, "agent_properties")

    @agent_properties.setter
    def agent_properties(self, value: Optional[pulumi.Input['CollectorAgentPropertiesArgs']]):
        pulumi.set(self, "agent_properties", value)

    @property
    @pulumi.getter(name="discoverySiteId")
    def discovery_site_id(self) -> Optional[pulumi.Input[str]]:
        """
        The ARM id of the discovery service site.
        """
        return pulumi.get(self, "discovery_site_id")

    @discovery_site_id.setter
    def discovery_site_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "discovery_site_id", value)


@pulumi.input_type
class ProjectPropertiesArgs:
    def __init__(__self__, *,
                 assessment_solution_id: Optional[pulumi.Input[str]] = None,
                 customer_workspace_id: Optional[pulumi.Input[str]] = None,
                 customer_workspace_location: Optional[pulumi.Input[str]] = None,
                 project_status: Optional[pulumi.Input[str]] = None):
        """
        Properties of a project.
        :param pulumi.Input[str] assessment_solution_id: Assessment solution ARM id tracked by Microsoft.Migrate/migrateProjects.
        :param pulumi.Input[str] customer_workspace_id: The ARM id of service map workspace created by customer.
        :param pulumi.Input[str] customer_workspace_location: Location of service map workspace created by customer.
        :param pulumi.Input[str] project_status: Assessment project status.
        """
        if assessment_solution_id is not None:
            pulumi.set(__self__, "assessment_solution_id", assessment_solution_id)
        if customer_workspace_id is not None:
            pulumi.set(__self__, "customer_workspace_id", customer_workspace_id)
        if customer_workspace_location is not None:
            pulumi.set(__self__, "customer_workspace_location", customer_workspace_location)
        if project_status is not None:
            pulumi.set(__self__, "project_status", project_status)

    @property
    @pulumi.getter(name="assessmentSolutionId")
    def assessment_solution_id(self) -> Optional[pulumi.Input[str]]:
        """
        Assessment solution ARM id tracked by Microsoft.Migrate/migrateProjects.
        """
        return pulumi.get(self, "assessment_solution_id")

    @assessment_solution_id.setter
    def assessment_solution_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "assessment_solution_id", value)

    @property
    @pulumi.getter(name="customerWorkspaceId")
    def customer_workspace_id(self) -> Optional[pulumi.Input[str]]:
        """
        The ARM id of service map workspace created by customer.
        """
        return pulumi.get(self, "customer_workspace_id")

    @customer_workspace_id.setter
    def customer_workspace_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "customer_workspace_id", value)

    @property
    @pulumi.getter(name="customerWorkspaceLocation")
    def customer_workspace_location(self) -> Optional[pulumi.Input[str]]:
        """
        Location of service map workspace created by customer.
        """
        return pulumi.get(self, "customer_workspace_location")

    @customer_workspace_location.setter
    def customer_workspace_location(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "customer_workspace_location", value)

    @property
    @pulumi.getter(name="projectStatus")
    def project_status(self) -> Optional[pulumi.Input[str]]:
        """
        Assessment project status.
        """
        return pulumi.get(self, "project_status")

    @project_status.setter
    def project_status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "project_status", value)


@pulumi.input_type
class VmUptimeArgs:
    def __init__(__self__, *,
                 days_per_month: Optional[pulumi.Input[float]] = None,
                 hours_per_day: Optional[pulumi.Input[float]] = None):
        """
        :param pulumi.Input[float] days_per_month: Number of days in a month for VM uptime.
        :param pulumi.Input[float] hours_per_day: Number of hours per day for VM uptime.
        """
        if days_per_month is not None:
            pulumi.set(__self__, "days_per_month", days_per_month)
        if hours_per_day is not None:
            pulumi.set(__self__, "hours_per_day", hours_per_day)

    @property
    @pulumi.getter(name="daysPerMonth")
    def days_per_month(self) -> Optional[pulumi.Input[float]]:
        """
        Number of days in a month for VM uptime.
        """
        return pulumi.get(self, "days_per_month")

    @days_per_month.setter
    def days_per_month(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "days_per_month", value)

    @property
    @pulumi.getter(name="hoursPerDay")
    def hours_per_day(self) -> Optional[pulumi.Input[float]]:
        """
        Number of hours per day for VM uptime.
        """
        return pulumi.get(self, "hours_per_day")

    @hours_per_day.setter
    def hours_per_day(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "hours_per_day", value)

