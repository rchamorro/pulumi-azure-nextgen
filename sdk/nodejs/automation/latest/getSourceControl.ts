// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

export function getSourceControl(args: GetSourceControlArgs, opts?: pulumi.InvokeOptions): Promise<GetSourceControlResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:automation/latest:getSourceControl", {
        "automationAccountName": args.automationAccountName,
        "resourceGroupName": args.resourceGroupName,
        "sourceControlName": args.sourceControlName,
    }, opts);
}

export interface GetSourceControlArgs {
    /**
     * The name of the automation account.
     */
    readonly automationAccountName: string;
    /**
     * Name of an Azure Resource group.
     */
    readonly resourceGroupName: string;
    /**
     * The name of source control.
     */
    readonly sourceControlName: string;
}

/**
 * Definition of the source control.
 */
export interface GetSourceControlResult {
    /**
     * The auto sync of the source control. Default is false.
     */
    readonly autoSync?: boolean;
    /**
     * The repo branch of the source control. Include branch as empty string for VsoTfvc.
     */
    readonly branch?: string;
    /**
     * The creation time.
     */
    readonly creationTime?: string;
    /**
     * The description.
     */
    readonly description?: string;
    /**
     * The folder path of the source control.
     */
    readonly folderPath?: string;
    /**
     * Fully qualified resource Id for the resource
     */
    readonly id: string;
    /**
     * The last modified time.
     */
    readonly lastModifiedTime?: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * The auto publish of the source control. Default is true.
     */
    readonly publishRunbook?: boolean;
    /**
     * The repo url of the source control.
     */
    readonly repoUrl?: string;
    /**
     * The source type. Must be one of VsoGit, VsoTfvc, GitHub.
     */
    readonly sourceType?: string;
    /**
     * The type of the resource.
     */
    readonly type: string;
}
