import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getDiagnostic(args: GetDiagnosticArgs, opts?: pulumi.InvokeOptions): Promise<GetDiagnosticResult>;
export interface GetDiagnosticArgs {
    /**
     * Diagnostic identifier. Must be unique in the current API Management service instance.
     */
    readonly diagnosticId: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the API Management service.
     */
    readonly serviceName: string;
}
/**
 * Diagnostic details.
 */
export interface GetDiagnosticResult {
    /**
     * Specifies for what type of messages sampling settings should not apply.
     */
    readonly alwaysLog?: string;
    /**
     * Diagnostic settings for incoming/outgoing HTTP messages to the Backend
     */
    readonly backend?: outputs.apimanagement.v20190101.PipelineDiagnosticSettingsResponse;
    /**
     * Whether to process Correlation Headers coming to Api Management Service. Only applicable to Application Insights diagnostics. Default is true.
     */
    readonly enableHttpCorrelationHeaders?: boolean;
    /**
     * Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.
     */
    readonly frontend?: outputs.apimanagement.v20190101.PipelineDiagnosticSettingsResponse;
    /**
     * Sets correlation protocol to use for Application Insights diagnostics.
     */
    readonly httpCorrelationProtocol?: string;
    /**
     * Resource Id of a target logger.
     */
    readonly loggerId: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Sampling settings for Diagnostic.
     */
    readonly sampling?: outputs.apimanagement.v20190101.SamplingSettingsResponse;
    /**
     * Resource type for API Management resource.
     */
    readonly type: string;
    /**
     * The verbosity level applied to traces emitted by trace policies.
     */
    readonly verbosity?: string;
}