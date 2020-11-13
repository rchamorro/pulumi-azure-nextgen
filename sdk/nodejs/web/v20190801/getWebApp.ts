// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getWebApp(args: GetWebAppArgs, opts?: pulumi.InvokeOptions): Promise<GetWebAppResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:web/v20190801:getWebApp", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetWebAppArgs {
    /**
     * Name of the app.
     */
    readonly name: string;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: string;
}

/**
 * A web app, a mobile app backend, or an API app.
 */
export interface GetWebAppResult {
    /**
     * Management information availability state for the app.
     */
    readonly availabilityState: string;
    /**
     * <code>true</code> to enable client affinity; <code>false</code> to stop sending session affinity cookies, which route client requests in the same session to the same instance. Default is <code>true</code>.
     */
    readonly clientAffinityEnabled?: boolean;
    /**
     * <code>true</code> to enable client certificate authentication (TLS mutual authentication); otherwise, <code>false</code>. Default is <code>false</code>.
     */
    readonly clientCertEnabled?: boolean;
    /**
     * client certificate authentication comma-separated exclusion paths
     */
    readonly clientCertExclusionPaths?: string;
    /**
     * If specified during app creation, the app is cloned from a source app.
     */
    readonly cloningInfo?: outputs.web.v20190801.CloningInfoResponse;
    /**
     * Size of the function container.
     */
    readonly containerSize?: number;
    /**
     * Maximum allowed daily memory-time quota (applicable on dynamic apps only).
     */
    readonly dailyMemoryTimeQuota?: number;
    /**
     * Default hostname of the app. Read-only.
     */
    readonly defaultHostName: string;
    /**
     * <code>true</code> if the app is enabled; otherwise, <code>false</code>. Setting this value to false disables the app (takes the app offline).
     */
    readonly enabled?: boolean;
    /**
     * Enabled hostnames for the app.Hostnames need to be assigned (see HostNames) AND enabled. Otherwise,
     * the app is not served on those hostnames.
     */
    readonly enabledHostNames: string[];
    /**
     * Hostname SSL states are used to manage the SSL bindings for app's hostnames.
     */
    readonly hostNameSslStates?: outputs.web.v20190801.HostNameSslStateResponse[];
    /**
     * Hostnames associated with the app.
     */
    readonly hostNames: string[];
    /**
     * <code>true</code> to disable the public hostnames of the app; otherwise, <code>false</code>.
     *  If <code>true</code>, the app is only accessible via API management process.
     */
    readonly hostNamesDisabled?: boolean;
    /**
     * App Service Environment to use for the app.
     */
    readonly hostingEnvironmentProfile?: outputs.web.v20190801.HostingEnvironmentProfileResponse;
    /**
     * HttpsOnly: configures a web site to accept only https requests. Issues redirect for
     * http requests
     */
    readonly httpsOnly?: boolean;
    /**
     * Hyper-V sandbox.
     */
    readonly hyperV?: boolean;
    /**
     * Managed service identity.
     */
    readonly identity?: outputs.web.v20190801.ManagedServiceIdentityResponse;
    /**
     * Specifies an operation id if this site has a pending operation.
     */
    readonly inProgressOperationId: string;
    /**
     * <code>true</code> if the app is a default container; otherwise, <code>false</code>.
     */
    readonly isDefaultContainer: boolean;
    /**
     * Obsolete: Hyper-V sandbox.
     */
    readonly isXenon?: boolean;
    /**
     * Kind of resource.
     */
    readonly kind?: string;
    /**
     * Last time the app was modified, in UTC. Read-only.
     */
    readonly lastModifiedTimeUtc: string;
    /**
     * Resource Location.
     */
    readonly location: string;
    /**
     * Maximum number of workers.
     * This only applies to Functions container.
     */
    readonly maxNumberOfWorkers: number;
    /**
     * Resource Name.
     */
    readonly name: string;
    /**
     * List of IP addresses that the app uses for outbound connections (e.g. database access). Includes VIPs from tenants that site can be hosted with current settings. Read-only.
     */
    readonly outboundIpAddresses: string;
    /**
     * List of IP addresses that the app uses for outbound connections (e.g. database access). Includes VIPs from all tenants except dataComponent. Read-only.
     */
    readonly possibleOutboundIpAddresses: string;
    /**
     * Site redundancy mode
     */
    readonly redundancyMode?: string;
    /**
     * Name of the repository site.
     */
    readonly repositorySiteName: string;
    /**
     * <code>true</code> if reserved; otherwise, <code>false</code>.
     */
    readonly reserved?: boolean;
    /**
     * Name of the resource group the app belongs to. Read-only.
     */
    readonly resourceGroup: string;
    /**
     * <code>true</code> to stop SCM (KUDU) site when the app is stopped; otherwise, <code>false</code>. The default is <code>false</code>.
     */
    readonly scmSiteAlsoStopped?: boolean;
    /**
     * Resource ID of the associated App Service plan, formatted as: "/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}".
     */
    readonly serverFarmId?: string;
    /**
     * Configuration of the app.
     */
    readonly siteConfig?: outputs.web.v20190801.SiteConfigResponse;
    /**
     * Status of the last deployment slot swap operation.
     */
    readonly slotSwapStatus: outputs.web.v20190801.SlotSwapStatusResponse;
    /**
     * Current state of the app.
     */
    readonly state: string;
    /**
     * App suspended till in case memory-time quota is exceeded.
     */
    readonly suspendedTill: string;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Specifies which deployment slot this app will swap into. Read-only.
     */
    readonly targetSwapSlot: string;
    /**
     * Azure Traffic Manager hostnames associated with the app. Read-only.
     */
    readonly trafficManagerHostNames: string[];
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * State indicating whether the app has exceeded its quota usage. Read-only.
     */
    readonly usageState: string;
}
