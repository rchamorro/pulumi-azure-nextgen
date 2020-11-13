// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function listWorkflowRunActionRepetitionExpressionTraces(args: ListWorkflowRunActionRepetitionExpressionTracesArgs, opts?: pulumi.InvokeOptions): Promise<ListWorkflowRunActionRepetitionExpressionTracesResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:logic/v20180701preview:listWorkflowRunActionRepetitionExpressionTraces", {
        "actionName": args.actionName,
        "repetitionName": args.repetitionName,
        "resourceGroupName": args.resourceGroupName,
        "runName": args.runName,
        "workflowName": args.workflowName,
    }, opts);
}

export interface ListWorkflowRunActionRepetitionExpressionTracesArgs {
    /**
     * The workflow action name.
     */
    readonly actionName: string;
    /**
     * The workflow repetition.
     */
    readonly repetitionName: string;
    /**
     * The resource group name.
     */
    readonly resourceGroupName: string;
    /**
     * The workflow run name.
     */
    readonly runName: string;
    /**
     * The workflow name.
     */
    readonly workflowName: string;
}

export interface ListWorkflowRunActionRepetitionExpressionTracesResult {
    readonly inputs?: outputs.logic.v20180701preview.ExpressionRootResponse[];
}
