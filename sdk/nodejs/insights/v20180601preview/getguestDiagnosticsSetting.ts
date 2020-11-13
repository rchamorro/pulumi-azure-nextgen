// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getguestDiagnosticsSetting(args: GetguestDiagnosticsSettingArgs, opts?: pulumi.InvokeOptions): Promise<GetguestDiagnosticsSettingResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:insights/v20180601preview:getguestDiagnosticsSetting", {
        "diagnosticSettingsName": args.diagnosticSettingsName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetguestDiagnosticsSettingArgs {
    /**
     * The name of the diagnostic setting.
     */
    readonly diagnosticSettingsName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * Virtual machine guest diagnostics settings resource.
 */
export interface GetguestDiagnosticsSettingResult {
    /**
     * the array of data source object which are configured to collect and send data
     */
    readonly dataSources?: outputs.insights.v20180601preview.DataSourceResponse[];
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * Azure resource name
     */
    readonly name: string;
    /**
     * Operating system type for the configuration
     */
    readonly osType?: string;
    readonly proxySetting?: string;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Azure resource type
     */
    readonly type: string;
}
