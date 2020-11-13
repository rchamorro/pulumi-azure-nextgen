// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getVirtualMachineRdpFileContents(args: GetVirtualMachineRdpFileContentsArgs, opts?: pulumi.InvokeOptions): Promise<GetVirtualMachineRdpFileContentsResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:devtestlab/v20180915:getVirtualMachineRdpFileContents", {
        "labName": args.labName,
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetVirtualMachineRdpFileContentsArgs {
    /**
     * The name of the lab.
     */
    readonly labName: string;
    /**
     * The name of the virtual machine.
     */
    readonly name: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * Represents a .rdp file
 */
export interface GetVirtualMachineRdpFileContentsResult {
    /**
     * The contents of the .rdp file
     */
    readonly contents?: string;
}
