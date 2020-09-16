import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getDscConfiguration(args: GetDscConfigurationArgs, opts?: pulumi.InvokeOptions): Promise<GetDscConfigurationResult>;
export interface GetDscConfigurationArgs {
    /**
     * The name of the automation account.
     */
    readonly automationAccountName: string;
    /**
     * The configuration name.
     */
    readonly configurationName: string;
    /**
     * Name of an Azure Resource group.
     */
    readonly resourceGroupName: string;
}
/**
 * Definition of the configuration type.
 */
export interface GetDscConfigurationResult {
    /**
     * Gets or sets the creation time.
     */
    readonly creationTime?: string;
    /**
     * Gets or sets the description.
     */
    readonly description?: string;
    /**
     * Gets or sets the etag of the resource.
     */
    readonly etag?: string;
    /**
     * Gets or sets the job count of the configuration.
     */
    readonly jobCount?: number;
    /**
     * Gets or sets the last modified time.
     */
    readonly lastModifiedTime?: string;
    /**
     * The Azure Region where the resource lives
     */
    readonly location?: string;
    /**
     * Gets or sets verbose log option.
     */
    readonly logVerbose?: boolean;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * Gets the number of compiled node configurations.
     */
    readonly nodeConfigurationCount?: number;
    /**
     * Gets or sets the configuration parameters.
     */
    readonly parameters?: {
        [key: string]: outputs.automation.v20151031.DscConfigurationParameterResponse;
    };
    /**
     * Gets or sets the provisioning state of the configuration.
     */
    readonly provisioningState?: string;
    /**
     * Gets or sets the source.
     */
    readonly source?: outputs.automation.v20151031.ContentSourceResponse;
    /**
     * Gets or sets the state of the configuration.
     */
    readonly state?: string;
    /**
     * Resource tags.
     */
    readonly tags?: {
        [key: string]: string;
    };
    /**
     * The type of the resource.
     */
    readonly type: string;
}