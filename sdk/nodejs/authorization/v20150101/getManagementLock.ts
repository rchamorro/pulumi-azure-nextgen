// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getManagementLock(args: GetManagementLockArgs, opts?: pulumi.InvokeOptions): Promise<GetManagementLockResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:authorization/v20150101:getManagementLock", {
        "lockName": args.lockName,
    }, opts);
}

export interface GetManagementLockArgs {
    /**
     * Name of the management lock.
     */
    readonly lockName: string;
}

/**
 * Management lock information.
 */
export interface GetManagementLockResult {
    /**
     * The lock level of the management lock.
     */
    readonly level?: string;
    /**
     * The name of the lock.
     */
    readonly name?: string;
    /**
     * The notes of the management lock.
     */
    readonly notes?: string;
    /**
     * The type of the lock.
     */
    readonly type: string;
}