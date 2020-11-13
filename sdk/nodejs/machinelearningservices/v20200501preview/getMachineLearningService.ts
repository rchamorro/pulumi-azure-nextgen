// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getMachineLearningService(args: GetMachineLearningServiceArgs, opts?: pulumi.InvokeOptions): Promise<GetMachineLearningServiceResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:machinelearningservices/v20200501preview:getMachineLearningService", {
        "expand": args.expand,
        "resourceGroupName": args.resourceGroupName,
        "serviceName": args.serviceName,
        "workspaceName": args.workspaceName,
    }, opts);
}

export interface GetMachineLearningServiceArgs {
    /**
     * Set to True to include Model details.
     */
    readonly expand?: boolean;
    /**
     * Name of the resource group in which workspace is located.
     */
    readonly resourceGroupName: string;
    /**
     * Name of the Azure Machine Learning service.
     */
    readonly serviceName: string;
    /**
     * Name of Azure Machine Learning workspace.
     */
    readonly workspaceName: string;
}

/**
 * Machine Learning service object wrapped into ARM resource envelope.
 */
export interface GetMachineLearningServiceResult {
    /**
     * The identity of the resource.
     */
    readonly identity?: outputs.machinelearningservices.v20200501preview.IdentityResponse;
    /**
     * Specifies the location of the resource.
     */
    readonly location?: string;
    /**
     * Specifies the name of the resource.
     */
    readonly name: string;
    /**
     * Service properties
     */
    readonly properties: outputs.machinelearningservices.v20200501preview.ACIServiceResponseResponse | outputs.machinelearningservices.v20200501preview.AKSVariantResponseResponse;
    /**
     * The sku of the workspace.
     */
    readonly sku?: outputs.machinelearningservices.v20200501preview.SkuResponse;
    /**
     * Contains resource tags defined as key/value pairs.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Specifies the type of the resource.
     */
    readonly type: string;
}
