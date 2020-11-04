// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

/**
 * Information about the connection monitor.
 */
export class ConnectionMonitor extends pulumi.CustomResource {
    /**
     * Get an existing ConnectionMonitor resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ConnectionMonitor {
        return new ConnectionMonitor(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/v20200301:ConnectionMonitor';

    /**
     * Returns true if the given object is an instance of ConnectionMonitor.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ConnectionMonitor {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ConnectionMonitor.__pulumiType;
    }

    /**
     * Determines if the connection monitor will start automatically once created.
     */
    public readonly autoStart!: pulumi.Output<boolean | undefined>;
    /**
     * Type of connection monitor.
     */
    public /*out*/ readonly connectionMonitorType!: pulumi.Output<string>;
    /**
     * Describes the destination of connection monitor.
     */
    public readonly destination!: pulumi.Output<outputs.network.v20200301.ConnectionMonitorDestinationResponse | undefined>;
    /**
     * List of connection monitor endpoints.
     */
    public readonly endpoints!: pulumi.Output<outputs.network.v20200301.ConnectionMonitorEndpointResponse[] | undefined>;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * Connection monitor location.
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * Monitoring interval in seconds.
     */
    public readonly monitoringIntervalInSeconds!: pulumi.Output<number | undefined>;
    /**
     * The monitoring status of the connection monitor.
     */
    public /*out*/ readonly monitoringStatus!: pulumi.Output<string>;
    /**
     * Name of the connection monitor.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Optional notes to be associated with the connection monitor.
     */
    public readonly notes!: pulumi.Output<string | undefined>;
    /**
     * List of connection monitor outputs.
     */
    public readonly outputs!: pulumi.Output<outputs.network.v20200301.ConnectionMonitorOutputResponse[] | undefined>;
    /**
     * The provisioning state of the connection monitor.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Describes the source of connection monitor.
     */
    public readonly source!: pulumi.Output<outputs.network.v20200301.ConnectionMonitorSourceResponse | undefined>;
    /**
     * The date and time when the connection monitor was started.
     */
    public /*out*/ readonly startTime!: pulumi.Output<string>;
    /**
     * Connection monitor tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * List of connection monitor test configurations.
     */
    public readonly testConfigurations!: pulumi.Output<outputs.network.v20200301.ConnectionMonitorTestConfigurationResponse[] | undefined>;
    /**
     * List of connection monitor test groups.
     */
    public readonly testGroups!: pulumi.Output<outputs.network.v20200301.ConnectionMonitorTestGroupResponse[] | undefined>;
    /**
     * Connection monitor type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a ConnectionMonitor resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ConnectionMonitorArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.connectionMonitorName === undefined) {
                throw new Error("Missing required property 'connectionMonitorName'");
            }
            if (!args || args.networkWatcherName === undefined) {
                throw new Error("Missing required property 'networkWatcherName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["autoStart"] = args ? args.autoStart : undefined;
            inputs["connectionMonitorName"] = args ? args.connectionMonitorName : undefined;
            inputs["destination"] = args ? args.destination : undefined;
            inputs["endpoints"] = args ? args.endpoints : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["monitoringIntervalInSeconds"] = args ? args.monitoringIntervalInSeconds : undefined;
            inputs["networkWatcherName"] = args ? args.networkWatcherName : undefined;
            inputs["notes"] = args ? args.notes : undefined;
            inputs["outputs"] = args ? args.outputs : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["source"] = args ? args.source : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["testConfigurations"] = args ? args.testConfigurations : undefined;
            inputs["testGroups"] = args ? args.testGroups : undefined;
            inputs["connectionMonitorType"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["monitoringStatus"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["startTime"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["autoStart"] = undefined /*out*/;
            inputs["connectionMonitorType"] = undefined /*out*/;
            inputs["destination"] = undefined /*out*/;
            inputs["endpoints"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["monitoringIntervalInSeconds"] = undefined /*out*/;
            inputs["monitoringStatus"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["notes"] = undefined /*out*/;
            inputs["outputs"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["source"] = undefined /*out*/;
            inputs["startTime"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["testConfigurations"] = undefined /*out*/;
            inputs["testGroups"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/latest:ConnectionMonitor" }, { type: "azure-nextgen:network/v20171001:ConnectionMonitor" }, { type: "azure-nextgen:network/v20171101:ConnectionMonitor" }, { type: "azure-nextgen:network/v20180101:ConnectionMonitor" }, { type: "azure-nextgen:network/v20180201:ConnectionMonitor" }, { type: "azure-nextgen:network/v20180401:ConnectionMonitor" }, { type: "azure-nextgen:network/v20180601:ConnectionMonitor" }, { type: "azure-nextgen:network/v20180701:ConnectionMonitor" }, { type: "azure-nextgen:network/v20180801:ConnectionMonitor" }, { type: "azure-nextgen:network/v20181001:ConnectionMonitor" }, { type: "azure-nextgen:network/v20181101:ConnectionMonitor" }, { type: "azure-nextgen:network/v20181201:ConnectionMonitor" }, { type: "azure-nextgen:network/v20190201:ConnectionMonitor" }, { type: "azure-nextgen:network/v20190401:ConnectionMonitor" }, { type: "azure-nextgen:network/v20190601:ConnectionMonitor" }, { type: "azure-nextgen:network/v20190701:ConnectionMonitor" }, { type: "azure-nextgen:network/v20190801:ConnectionMonitor" }, { type: "azure-nextgen:network/v20190901:ConnectionMonitor" }, { type: "azure-nextgen:network/v20191101:ConnectionMonitor" }, { type: "azure-nextgen:network/v20191201:ConnectionMonitor" }, { type: "azure-nextgen:network/v20200401:ConnectionMonitor" }, { type: "azure-nextgen:network/v20200501:ConnectionMonitor" }, { type: "azure-nextgen:network/v20200601:ConnectionMonitor" }, { type: "azure-nextgen:network/v20200701:ConnectionMonitor" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(ConnectionMonitor.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ConnectionMonitor resource.
 */
export interface ConnectionMonitorArgs {
    /**
     * Determines if the connection monitor will start automatically once created.
     */
    readonly autoStart?: pulumi.Input<boolean>;
    /**
     * The name of the connection monitor.
     */
    readonly connectionMonitorName: pulumi.Input<string>;
    /**
     * Describes the destination of connection monitor.
     */
    readonly destination?: pulumi.Input<inputs.network.v20200301.ConnectionMonitorDestination>;
    /**
     * List of connection monitor endpoints.
     */
    readonly endpoints?: pulumi.Input<pulumi.Input<inputs.network.v20200301.ConnectionMonitorEndpoint>[]>;
    /**
     * Connection monitor location.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Monitoring interval in seconds.
     */
    readonly monitoringIntervalInSeconds?: pulumi.Input<number>;
    /**
     * The name of the Network Watcher resource.
     */
    readonly networkWatcherName: pulumi.Input<string>;
    /**
     * Optional notes to be associated with the connection monitor.
     */
    readonly notes?: pulumi.Input<string>;
    /**
     * List of connection monitor outputs.
     */
    readonly outputs?: pulumi.Input<pulumi.Input<inputs.network.v20200301.ConnectionMonitorOutput>[]>;
    /**
     * The name of the resource group containing Network Watcher.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Describes the source of connection monitor.
     */
    readonly source?: pulumi.Input<inputs.network.v20200301.ConnectionMonitorSource>;
    /**
     * Connection monitor tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * List of connection monitor test configurations.
     */
    readonly testConfigurations?: pulumi.Input<pulumi.Input<inputs.network.v20200301.ConnectionMonitorTestConfiguration>[]>;
    /**
     * List of connection monitor test groups.
     */
    readonly testGroups?: pulumi.Input<pulumi.Input<inputs.network.v20200301.ConnectionMonitorTestGroup>[]>;
}
