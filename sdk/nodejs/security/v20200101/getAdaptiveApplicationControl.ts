// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getAdaptiveApplicationControl(args: GetAdaptiveApplicationControlArgs, opts?: pulumi.InvokeOptions): Promise<GetAdaptiveApplicationControlResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:security/v20200101:getAdaptiveApplicationControl", {
        "ascLocation": args.ascLocation,
        "groupName": args.groupName,
    }, opts);
}

export interface GetAdaptiveApplicationControlArgs {
    /**
     * The location where ASC stores the data of the subscription. can be retrieved from Get locations
     */
    readonly ascLocation: string;
    /**
     * Name of an application control machine group
     */
    readonly groupName: string;
}

export interface GetAdaptiveApplicationControlResult {
    /**
     * The configuration status of the machines group or machine or rule
     */
    readonly configurationStatus: string;
    /**
     * The application control policy enforcement/protection mode of the machine group
     */
    readonly enforcementMode?: string;
    readonly issues: outputs.security.v20200101.AdaptiveApplicationControlIssueSummaryResponse[];
    /**
     * Location where the resource is stored
     */
    readonly location: string;
    /**
     * Resource name
     */
    readonly name: string;
    readonly pathRecommendations?: outputs.security.v20200101.PathRecommendationResponse[];
    /**
     * The protection mode of the collection/file types. Exe/Msi/Script are used for Windows, Executable is used for Linux.
     */
    readonly protectionMode?: outputs.security.v20200101.ProtectionModeResponse;
    /**
     * The initial recommendation status of the machine group or machine
     */
    readonly recommendationStatus: string;
    /**
     * The source type of the machine group
     */
    readonly sourceSystem: string;
    /**
     * Resource type
     */
    readonly type: string;
    readonly vmRecommendations?: outputs.security.v20200101.VmRecommendationResponse[];
}
