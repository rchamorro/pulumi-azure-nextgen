// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getAvailabilityGroupListener(args: GetAvailabilityGroupListenerArgs, opts?: pulumi.InvokeOptions): Promise<GetAvailabilityGroupListenerResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:sqlvirtualmachine/v20170301preview:getAvailabilityGroupListener", {
        "availabilityGroupListenerName": args.availabilityGroupListenerName,
        "resourceGroupName": args.resourceGroupName,
        "sqlVirtualMachineGroupName": args.sqlVirtualMachineGroupName,
    }, opts);
}

export interface GetAvailabilityGroupListenerArgs {
    /**
     * Name of the availability group listener.
     */
    readonly availabilityGroupListenerName: string;
    /**
     * Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
     */
    readonly resourceGroupName: string;
    /**
     * Name of the SQL virtual machine group.
     */
    readonly sqlVirtualMachineGroupName: string;
}

/**
 * A SQL Server availability group listener.
 */
export interface GetAvailabilityGroupListenerResult {
    /**
     * Name of the availability group.
     */
    readonly availabilityGroupName?: string;
    /**
     * Create a default availability group if it does not exist.
     */
    readonly createDefaultAvailabilityGroupIfNotExist?: boolean;
    /**
     * List of load balancer configurations for an availability group listener.
     */
    readonly loadBalancerConfigurations?: outputs.sqlvirtualmachine.v20170301preview.LoadBalancerConfigurationResponse[];
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Listener port.
     */
    readonly port?: number;
    /**
     * Provisioning state to track the async operation status.
     */
    readonly provisioningState: string;
    /**
     * Resource type.
     */
    readonly type: string;
}
