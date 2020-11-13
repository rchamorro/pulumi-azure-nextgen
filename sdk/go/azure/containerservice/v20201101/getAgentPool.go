// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20201101

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupAgentPool(ctx *pulumi.Context, args *LookupAgentPoolArgs, opts ...pulumi.InvokeOption) (*LookupAgentPoolResult, error) {
	var rv LookupAgentPoolResult
	err := ctx.Invoke("azure-nextgen:containerservice/v20201101:getAgentPool", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupAgentPoolArgs struct {
	// The name of the agent pool.
	AgentPoolName string `pulumi:"agentPoolName"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the managed cluster resource.
	ResourceName string `pulumi:"resourceName"`
}

// Agent Pool.
type LookupAgentPoolResult struct {
	// Availability zones for nodes. Must use VirtualMachineScaleSets AgentPoolType.
	AvailabilityZones []string `pulumi:"availabilityZones"`
	// Number of agents (VMs) to host docker containers. Allowed values must be in the range of 0 to 100 (inclusive) for user pools and in the range of 1 to 100 (inclusive) for system pools. The default value is 1.
	Count *int `pulumi:"count"`
	// Whether to enable auto-scaler
	EnableAutoScaling *bool `pulumi:"enableAutoScaling"`
	// Enable public IP for nodes
	EnableNodePublicIP *bool `pulumi:"enableNodePublicIP"`
	// KubeletConfig specifies the configuration of kubelet on agent nodes.
	KubeletConfig *KubeletConfigResponse `pulumi:"kubeletConfig"`
	// LinuxOSConfig specifies the OS configuration of linux agent nodes.
	LinuxOSConfig *LinuxOSConfigResponse `pulumi:"linuxOSConfig"`
	// Maximum number of nodes for auto-scaling
	MaxCount *int `pulumi:"maxCount"`
	// Maximum number of pods that can run on a node.
	MaxPods *int `pulumi:"maxPods"`
	// Minimum number of nodes for auto-scaling
	MinCount *int `pulumi:"minCount"`
	// AgentPoolMode represents mode of an agent pool
	Mode *string `pulumi:"mode"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name string `pulumi:"name"`
	// Version of node image
	NodeImageVersion string `pulumi:"nodeImageVersion"`
	// Agent pool node labels to be persisted across all nodes in agent pool.
	NodeLabels map[string]string `pulumi:"nodeLabels"`
	// Taints added to new nodes during node pool create and scale. For example, key=value:NoSchedule.
	NodeTaints []string `pulumi:"nodeTaints"`
	// Version of orchestrator specified when creating the managed cluster.
	OrchestratorVersion *string `pulumi:"orchestratorVersion"`
	// OS Disk Size in GB to be used to specify the disk size for every machine in this master/agent pool. If you specify 0, it will apply the default osDisk size according to the vmSize specified.
	OsDiskSizeGB *int `pulumi:"osDiskSizeGB"`
	// OS disk type to be used for machines in a given agent pool. Allowed values are 'Ephemeral' and 'Managed'. Defaults to 'Managed'. May not be changed after creation.
	OsDiskType *string `pulumi:"osDiskType"`
	// OsType to be used to specify os type. Choose from Linux and Windows. Default to Linux.
	OsType *string `pulumi:"osType"`
	// Pod SubnetID specifies the VNet's subnet identifier for pods.
	PodSubnetID *string `pulumi:"podSubnetID"`
	// Describes whether the Agent Pool is Running or Stopped
	PowerState PowerStateResponse `pulumi:"powerState"`
	// The current deployment or provisioning state, which only appears in the response.
	ProvisioningState string `pulumi:"provisioningState"`
	// The ID for Proximity Placement Group.
	ProximityPlacementGroupID *string `pulumi:"proximityPlacementGroupID"`
	// ScaleSetEvictionPolicy to be used to specify eviction policy for Spot virtual machine scale set. Default to Delete.
	ScaleSetEvictionPolicy *string `pulumi:"scaleSetEvictionPolicy"`
	// ScaleSetPriority to be used to specify virtual machine scale set priority. Default to regular.
	ScaleSetPriority *string `pulumi:"scaleSetPriority"`
	// SpotMaxPrice to be used to specify the maximum price you are willing to pay in US Dollars. Possible values are any decimal value greater than zero or -1 which indicates default price to be up-to on-demand.
	SpotMaxPrice *float64 `pulumi:"spotMaxPrice"`
	// Agent pool tags to be persisted on the agent pool virtual machine scale set.
	Tags map[string]string `pulumi:"tags"`
	// AgentPoolType represents types of an agent pool
	Type string `pulumi:"type"`
	// Settings for upgrading the agentpool
	UpgradeSettings *AgentPoolUpgradeSettingsResponse `pulumi:"upgradeSettings"`
	// Size of agent VMs.
	VmSize *string `pulumi:"vmSize"`
	// VNet SubnetID specifies the VNet's subnet identifier for nodes and maybe pods
	VnetSubnetID *string `pulumi:"vnetSubnetID"`
}
