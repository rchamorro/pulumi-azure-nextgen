import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getApiOperation(args: GetApiOperationArgs, opts?: pulumi.InvokeOptions): Promise<GetApiOperationResult>;
export interface GetApiOperationArgs {
    /**
     * API revision identifier. Must be unique in the current API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number.
     */
    readonly apiId: string;
    /**
     * Operation identifier within an API. Must be unique in the current API Management service instance.
     */
    readonly operationId: string;
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
 * Api Operation details.
 */
export interface GetApiOperationResult {
    /**
     * Description of the operation. May include HTML formatting tags.
     */
    readonly description?: string;
    /**
     * Operation Name.
     */
    readonly displayName: string;
    /**
     * A Valid HTTP Operation Method. Typical Http Methods like GET, PUT, POST but not limited by only them.
     */
    readonly method: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Operation Policies
     */
    readonly policies?: string;
    /**
     * An entity containing request details.
     */
    readonly request?: outputs.apimanagement.v20180101.RequestContractResponse;
    /**
     * Array of Operation responses.
     */
    readonly responses?: outputs.apimanagement.v20180101.ResponseContractResponse[];
    /**
     * Collection of URL template parameters.
     */
    readonly templateParameters?: outputs.apimanagement.v20180101.ParameterContractResponse[];
    /**
     * Resource type for API Management resource.
     */
    readonly type: string;
    /**
     * Relative URL template identifying the target resource for this operation. May include parameters. Example: /customers/{cid}/orders/{oid}/?date={date}
     */
    readonly urlTemplate: string;
}