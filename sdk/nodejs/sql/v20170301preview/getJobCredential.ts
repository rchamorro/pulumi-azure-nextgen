// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getJobCredential(args: GetJobCredentialArgs, opts?: pulumi.InvokeOptions): Promise<GetJobCredentialResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:sql/v20170301preview:getJobCredential", {
        "credentialName": args.credentialName,
        "jobAgentName": args.jobAgentName,
        "resourceGroupName": args.resourceGroupName,
        "serverName": args.serverName,
    }, opts);
}

export interface GetJobCredentialArgs {
    /**
     * The name of the credential.
     */
    readonly credentialName: string;
    /**
     * The name of the job agent.
     */
    readonly jobAgentName: string;
    /**
     * The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the server.
     */
    readonly serverName: string;
}

/**
 * A stored credential that can be used by a job to connect to target databases.
 */
export interface GetJobCredentialResult {
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * The credential password.
     */
    readonly password: string;
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * The credential user name.
     */
    readonly username: string;
}
