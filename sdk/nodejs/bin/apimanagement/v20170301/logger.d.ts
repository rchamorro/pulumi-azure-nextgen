import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
/**
 * Logger details.
 */
export declare class Logger extends pulumi.CustomResource {
    /**
     * Get an existing Logger resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Logger;
    /**
     * Returns true if the given object is an instance of Logger.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is Logger;
    /**
     * The name and SendRule connection string of the event hub for azureEventHub logger.
     * Instrumentation key for applicationInsights logger.
     */
    readonly credentials: pulumi.Output<{
        [key: string]: string;
    }>;
    /**
     * Logger description.
     */
    readonly description: pulumi.Output<string | undefined>;
    /**
     * Whether records are buffered in the logger before publishing. Default is assumed to be true.
     */
    readonly isBuffered: pulumi.Output<boolean | undefined>;
    /**
     * Logger type.
     */
    readonly loggerType: pulumi.Output<string>;
    /**
     * Resource name.
     */
    readonly name: pulumi.Output<string>;
    /**
     * Sampling settings for an ApplicationInsights logger.
     */
    readonly sampling: pulumi.Output<outputs.apimanagement.v20170301.LoggerSamplingContractResponse | undefined>;
    /**
     * Resource type for API Management resource.
     */
    readonly type: pulumi.Output<string>;
    /**
     * Create a Logger resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: LoggerArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a Logger resource.
 */
export interface LoggerArgs {
    /**
     * The name and SendRule connection string of the event hub for azureEventHub logger.
     * Instrumentation key for applicationInsights logger.
     */
    readonly credentials: pulumi.Input<{
        [key: string]: pulumi.Input<string>;
    }>;
    /**
     * Logger description.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Whether records are buffered in the logger before publishing. Default is assumed to be true.
     */
    readonly isBuffered?: pulumi.Input<boolean>;
    /**
     * Logger type.
     */
    readonly loggerType: pulumi.Input<string>;
    /**
     * Logger identifier. Must be unique in the API Management service instance.
     */
    readonly loggerid: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Sampling settings for an ApplicationInsights logger.
     */
    readonly sampling?: pulumi.Input<inputs.apimanagement.v20170301.LoggerSamplingContract>;
    /**
     * The name of the API Management service.
     */
    readonly serviceName: pulumi.Input<string>;
}