// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Information about a Cluster.
 */
export class Cluster extends pulumi.CustomResource {
    /**
     * Get an existing Cluster resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Cluster {
        return new Cluster(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:batchai/v20180501:Cluster';

    /**
     * Returns true if the given object is an instance of Cluster.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Cluster {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Cluster.__pulumiType;
    }

    /**
     * Allocation state of the cluster. Possible values are: steady - Indicates that the cluster is not resizing. There are no changes to the number of compute nodes in the cluster in progress. A cluster enters this state when it is created and when no operations are being performed on the cluster to change the number of compute nodes. resizing - Indicates that the cluster is resizing; that is, compute nodes are being added to or removed from the cluster.
     */
    public /*out*/ readonly allocationState!: pulumi.Output<string>;
    /**
     * The time at which the cluster entered its current allocation state.
     */
    public /*out*/ readonly allocationStateTransitionTime!: pulumi.Output<string>;
    /**
     * The time when the cluster was created.
     */
    public /*out*/ readonly creationTime!: pulumi.Output<string>;
    /**
     * The number of compute nodes currently assigned to the cluster.
     */
    public /*out*/ readonly currentNodeCount!: pulumi.Output<number>;
    /**
     * Collection of errors encountered by various compute nodes during node setup.
     */
    public /*out*/ readonly errors!: pulumi.Output<outputs.batchai.v20180501.BatchAIErrorResponse[]>;
    /**
     * The name of the resource.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Setup (mount file systems, performance counters settings and custom setup task) to be performed on each compute node in the cluster.
     */
    public readonly nodeSetup!: pulumi.Output<outputs.batchai.v20180501.NodeSetupResponse | undefined>;
    /**
     * Counts of various node states on the cluster.
     */
    public /*out*/ readonly nodeStateCounts!: pulumi.Output<outputs.batchai.v20180501.NodeStateCountsResponse>;
    /**
     * Provisioning state of the cluster. Possible value are: creating - Specifies that the cluster is being created. succeeded - Specifies that the cluster has been created successfully. failed - Specifies that the cluster creation has failed. deleting - Specifies that the cluster is being deleted.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Time when the provisioning state was changed.
     */
    public /*out*/ readonly provisioningStateTransitionTime!: pulumi.Output<string>;
    /**
     * Scale settings of the cluster.
     */
    public readonly scaleSettings!: pulumi.Output<outputs.batchai.v20180501.ScaleSettingsResponse | undefined>;
    /**
     * Virtual network subnet resource ID the cluster nodes belong to.
     */
    public readonly subnet!: pulumi.Output<outputs.batchai.v20180501.ResourceIdResponse | undefined>;
    /**
     * The type of the resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * Administrator user account settings which can be used to SSH to compute nodes.
     */
    public readonly userAccountSettings!: pulumi.Output<outputs.batchai.v20180501.UserAccountSettingsResponse | undefined>;
    /**
     * Virtual machine configuration (OS image) of the compute nodes. All nodes in a cluster have the same OS image configuration.
     */
    public readonly virtualMachineConfiguration!: pulumi.Output<outputs.batchai.v20180501.VirtualMachineConfigurationResponse | undefined>;
    /**
     * VM priority of cluster nodes.
     */
    public readonly vmPriority!: pulumi.Output<string | undefined>;
    /**
     * The size of the virtual machines in the cluster. All nodes in a cluster have the same VM size.
     */
    public readonly vmSize!: pulumi.Output<string | undefined>;

    /**
     * Create a Cluster resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ClusterArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.clusterName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'clusterName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.userAccountSettings === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'userAccountSettings'");
            }
            if ((!args || args.vmSize === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'vmSize'");
            }
            if ((!args || args.workspaceName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'workspaceName'");
            }
            inputs["clusterName"] = args ? args.clusterName : undefined;
            inputs["nodeSetup"] = args ? args.nodeSetup : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["scaleSettings"] = args ? args.scaleSettings : undefined;
            inputs["subnet"] = args ? args.subnet : undefined;
            inputs["userAccountSettings"] = args ? args.userAccountSettings : undefined;
            inputs["virtualMachineConfiguration"] = args ? args.virtualMachineConfiguration : undefined;
            inputs["vmPriority"] = (args ? args.vmPriority : undefined) || "dedicated";
            inputs["vmSize"] = args ? args.vmSize : undefined;
            inputs["workspaceName"] = args ? args.workspaceName : undefined;
            inputs["allocationState"] = undefined /*out*/;
            inputs["allocationStateTransitionTime"] = undefined /*out*/;
            inputs["creationTime"] = undefined /*out*/;
            inputs["currentNodeCount"] = undefined /*out*/;
            inputs["errors"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["nodeStateCounts"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["provisioningStateTransitionTime"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["allocationState"] = undefined /*out*/;
            inputs["allocationStateTransitionTime"] = undefined /*out*/;
            inputs["creationTime"] = undefined /*out*/;
            inputs["currentNodeCount"] = undefined /*out*/;
            inputs["errors"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["nodeSetup"] = undefined /*out*/;
            inputs["nodeStateCounts"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["provisioningStateTransitionTime"] = undefined /*out*/;
            inputs["scaleSettings"] = undefined /*out*/;
            inputs["subnet"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["userAccountSettings"] = undefined /*out*/;
            inputs["virtualMachineConfiguration"] = undefined /*out*/;
            inputs["vmPriority"] = undefined /*out*/;
            inputs["vmSize"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:batchai/latest:Cluster" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Cluster.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Cluster resource.
 */
export interface ClusterArgs {
    /**
     * The name of the cluster within the specified resource group. Cluster names can only contain a combination of alphanumeric characters along with dash (-) and underscore (_). The name must be from 1 through 64 characters long.
     */
    readonly clusterName: pulumi.Input<string>;
    /**
     * Setup to be performed on each compute node in the cluster.
     */
    readonly nodeSetup?: pulumi.Input<inputs.batchai.v20180501.NodeSetup>;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Scale settings for the cluster. Batch AI service supports manual and auto scale clusters.
     */
    readonly scaleSettings?: pulumi.Input<inputs.batchai.v20180501.ScaleSettings>;
    /**
     * Existing virtual network subnet to put the cluster nodes in. Note, if a File Server mount configured in node setup, the File Server's subnet will be used automatically.
     */
    readonly subnet?: pulumi.Input<inputs.batchai.v20180501.ResourceId>;
    /**
     * Settings for an administrator user account that will be created on each compute node in the cluster.
     */
    readonly userAccountSettings: pulumi.Input<inputs.batchai.v20180501.UserAccountSettings>;
    /**
     * OS image configuration for cluster nodes. All nodes in a cluster have the same OS image.
     */
    readonly virtualMachineConfiguration?: pulumi.Input<inputs.batchai.v20180501.VirtualMachineConfiguration>;
    /**
     * VM priority. Allowed values are: dedicated (default) and lowpriority.
     */
    readonly vmPriority?: pulumi.Input<enums.batchai.v20180501.VmPriority>;
    /**
     * The size of the virtual machines in the cluster. All nodes in a cluster have the same VM size. For information about available VM sizes for clusters using images from the Virtual Machines Marketplace see Sizes for Virtual Machines (Linux). Batch AI service supports all Azure VM sizes except STANDARD_A0 and those with premium storage (STANDARD_GS, STANDARD_DS, and STANDARD_DSV2 series).
     */
    readonly vmSize: pulumi.Input<string>;
    /**
     * The name of the workspace. Workspace names can only contain a combination of alphanumeric characters along with dash (-) and underscore (_). The name must be from 1 through 64 characters long.
     */
    readonly workspaceName: pulumi.Input<string>;
}
