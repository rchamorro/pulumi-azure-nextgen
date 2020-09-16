import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getWebTest(args: GetWebTestArgs, opts?: pulumi.InvokeOptions): Promise<GetWebTestResult>;
export interface GetWebTestArgs {
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the Application Insights webtest resource.
     */
    readonly webTestName: string;
}
/**
 * An Application Insights web test definition.
 */
export interface GetWebTestResult {
    /**
     * An XML configuration specification for a WebTest.
     */
    readonly configuration?: outputs.insights.v20150501.WebTestPropertiesResponseConfiguration;
    /**
     * Purpose/user defined descriptive test for this WebTest.
     */
    readonly description?: string;
    /**
     * Is the test actively being monitored.
     */
    readonly enabled?: boolean;
    /**
     * Interval in seconds between test runs for this WebTest. Default value is 300.
     */
    readonly frequency?: number;
    /**
     * The kind of web test that this web test watches. Choices are ping and multistep.
     */
    readonly kind?: string;
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * A list of where to physically run the tests from to give global coverage for accessibility of your application.
     */
    readonly locations: outputs.insights.v20150501.WebTestGeolocationResponse[];
    /**
     * Azure resource name
     */
    readonly name: string;
    /**
     * Current state of this component, whether or not is has been provisioned within the resource group it is defined. Users cannot change this value but are able to read from it. Values will include Succeeded, Deploying, Canceled, and Failed.
     */
    readonly provisioningState: string;
    /**
     * Allow for retries should this WebTest fail.
     */
    readonly retryEnabled?: boolean;
    /**
     * Unique ID of this WebTest. This is typically the same value as the Name field.
     */
    readonly syntheticMonitorId: string;
    /**
     * Resource tags
     */
    readonly tags?: {
        [key: string]: string;
    };
    /**
     * Seconds until this WebTest will timeout and fail. Default value is 30.
     */
    readonly timeout?: number;
    /**
     * Azure resource type
     */
    readonly type: string;
    /**
     * The kind of web test this is, valid choices are ping and multistep.
     */
    readonly webTestKind: string;
    /**
     * User defined name if this WebTest.
     */
    readonly webTestName: string;
}