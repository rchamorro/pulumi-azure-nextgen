import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getCluster(args: GetClusterArgs, opts?: pulumi.InvokeOptions): Promise<GetClusterResult>;
export interface GetClusterArgs {
    /**
     * The name of the cluster within the specified resource group. Cluster names can only contain a combination of alphanumeric characters along with dash (-) and underscore (_). The name must be from 1 through 64 characters long.
     */
    readonly clusterName: string;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: string;
}
/**
 * Contains information about a Cluster.
 */
export interface GetClusterResult {
    /**
     * Possible values are: steady and resizing. steady state indicates that the cluster is not resizing. There are no changes to the number of compute nodes in the cluster in progress. A cluster enters this state when it is created and when no operations are being performed on the cluster to change the number of compute nodes. resizing state indicates that the cluster is resizing; that is, compute nodes are being added to or removed from the cluster.
     */
    readonly allocationState: string;
    readonly allocationStateTransitionTime: string;
    readonly creationTime: string;
    readonly currentNodeCount: number;
    /**
     * This element contains all the errors encountered by various compute nodes during node setup.
     */
    readonly errors?: outputs.batchai.v20180301.BatchAIErrorResponse[];
    /**
     * The location of the resource
     */
    readonly location: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * Use this to prepare the VM. NOTE: The volumes specified in mountVolumes are mounted first and then the setupTask is run. Therefore the setup task can use local mountPaths in its execution.
     */
    readonly nodeSetup?: outputs.batchai.v20180301.NodeSetupResponse;
    /**
     * Counts of various compute node states on the cluster.
     */
    readonly nodeStateCounts: outputs.batchai.v20180301.NodeStateCountsResponse;
    /**
     * Possible value are: creating - Specifies that the cluster is being created. succeeded - Specifies that the cluster has been created successfully. failed - Specifies that the cluster creation has failed. deleting - Specifies that the cluster is being deleted.
     */
    readonly provisioningState: string;
    readonly provisioningStateTransitionTime: string;
    /**
     * At least one of manual or autoScale settings must be specified. Only one of manual or autoScale settings can be specified. If autoScale settings are specified, the system automatically scales the cluster up and down (within the supplied limits) based on the pending jobs on the cluster.
     */
    readonly scaleSettings?: outputs.batchai.v20180301.ScaleSettingsResponse;
    /**
     * Represents a resource ID. For example, for a subnet, it is the resource URL for the subnet.
     */
    readonly subnet?: outputs.batchai.v20180301.ResourceIdResponse;
    /**
     * The tags of the resource
     */
    readonly tags: {
        [key: string]: string;
    };
    /**
     * The type of the resource
     */
    readonly type: string;
    /**
     * Settings for user account that gets created on each on the nodes of a cluster.
     */
    readonly userAccountSettings?: outputs.batchai.v20180301.UserAccountSettingsResponse;
    /**
     * Settings for OS image.
     */
    readonly virtualMachineConfiguration?: outputs.batchai.v20180301.VirtualMachineConfigurationResponse;
    /**
     * The default value is dedicated. The node can get preempted while the task is running if lowpriority is chosen. This is best suited if the workload is checkpointing and can be restarted.
     */
    readonly vmPriority?: string;
    /**
     * All virtual machines in a cluster are the same size. For information about available VM sizes for clusters using images from the Virtual Machines Marketplace (see Sizes for Virtual Machines (Linux) or Sizes for Virtual Machines (Windows). Batch AI service supports all Azure VM sizes except STANDARD_A0 and those with premium storage (STANDARD_GS, STANDARD_DS, and STANDARD_DSV2 series).
     */
    readonly vmSize?: string;
}