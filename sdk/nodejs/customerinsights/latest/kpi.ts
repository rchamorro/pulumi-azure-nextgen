// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * The KPI resource format.
 */
export class Kpi extends pulumi.CustomResource {
    /**
     * Get an existing Kpi resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Kpi {
        return new Kpi(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:customerinsights/latest:Kpi';

    /**
     * Returns true if the given object is an instance of Kpi.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Kpi {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Kpi.__pulumiType;
    }

    /**
     * The aliases.
     */
    public readonly aliases!: pulumi.Output<outputs.customerinsights.latest.KpiAliasResponse[] | undefined>;
    /**
     * The calculation window.
     */
    public readonly calculationWindow!: pulumi.Output<string>;
    /**
     * Name of calculation window field.
     */
    public readonly calculationWindowFieldName!: pulumi.Output<string | undefined>;
    /**
     * Localized description for the KPI.
     */
    public readonly description!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Localized display name for the KPI.
     */
    public readonly displayName!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The mapping entity type.
     */
    public readonly entityType!: pulumi.Output<string>;
    /**
     * The mapping entity name.
     */
    public readonly entityTypeName!: pulumi.Output<string>;
    /**
     * The computation expression for the KPI.
     */
    public readonly expression!: pulumi.Output<string>;
    /**
     * The KPI extracts.
     */
    public readonly extracts!: pulumi.Output<outputs.customerinsights.latest.KpiExtractResponse[] | undefined>;
    /**
     * The filter expression for the KPI.
     */
    public readonly filter!: pulumi.Output<string | undefined>;
    /**
     * The computation function for the KPI.
     */
    public readonly function!: pulumi.Output<string>;
    /**
     * the group by properties for the KPI.
     */
    public readonly groupBy!: pulumi.Output<string[] | undefined>;
    /**
     * The KPI GroupByMetadata.
     */
    public /*out*/ readonly groupByMetadata!: pulumi.Output<outputs.customerinsights.latest.KpiGroupByMetadataResponse[]>;
    /**
     * The KPI name.
     */
    public readonly kpiName!: pulumi.Output<string>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The participant profiles.
     */
    public /*out*/ readonly participantProfilesMetadata!: pulumi.Output<outputs.customerinsights.latest.KpiParticipantProfilesMetadataResponse[]>;
    /**
     * Provisioning state.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The hub name.
     */
    public /*out*/ readonly tenantId!: pulumi.Output<string>;
    /**
     * The KPI thresholds.
     */
    public readonly thresHolds!: pulumi.Output<outputs.customerinsights.latest.KpiThresholdsResponse | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * The unit of measurement for the KPI.
     */
    public readonly unit!: pulumi.Output<string | undefined>;

    /**
     * Create a Kpi resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: KpiArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.calculationWindow === undefined) {
                throw new Error("Missing required property 'calculationWindow'");
            }
            if (!args || args.entityType === undefined) {
                throw new Error("Missing required property 'entityType'");
            }
            if (!args || args.entityTypeName === undefined) {
                throw new Error("Missing required property 'entityTypeName'");
            }
            if (!args || args.expression === undefined) {
                throw new Error("Missing required property 'expression'");
            }
            if (!args || args.function === undefined) {
                throw new Error("Missing required property 'function'");
            }
            if (!args || args.hubName === undefined) {
                throw new Error("Missing required property 'hubName'");
            }
            if (!args || args.kpiName === undefined) {
                throw new Error("Missing required property 'kpiName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["aliases"] = args ? args.aliases : undefined;
            inputs["calculationWindow"] = args ? args.calculationWindow : undefined;
            inputs["calculationWindowFieldName"] = args ? args.calculationWindowFieldName : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["entityType"] = args ? args.entityType : undefined;
            inputs["entityTypeName"] = args ? args.entityTypeName : undefined;
            inputs["expression"] = args ? args.expression : undefined;
            inputs["extracts"] = args ? args.extracts : undefined;
            inputs["filter"] = args ? args.filter : undefined;
            inputs["function"] = args ? args.function : undefined;
            inputs["groupBy"] = args ? args.groupBy : undefined;
            inputs["hubName"] = args ? args.hubName : undefined;
            inputs["kpiName"] = args ? args.kpiName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["thresHolds"] = args ? args.thresHolds : undefined;
            inputs["unit"] = args ? args.unit : undefined;
            inputs["groupByMetadata"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["participantProfilesMetadata"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["tenantId"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["aliases"] = undefined /*out*/;
            inputs["calculationWindow"] = undefined /*out*/;
            inputs["calculationWindowFieldName"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["displayName"] = undefined /*out*/;
            inputs["entityType"] = undefined /*out*/;
            inputs["entityTypeName"] = undefined /*out*/;
            inputs["expression"] = undefined /*out*/;
            inputs["extracts"] = undefined /*out*/;
            inputs["filter"] = undefined /*out*/;
            inputs["function"] = undefined /*out*/;
            inputs["groupBy"] = undefined /*out*/;
            inputs["groupByMetadata"] = undefined /*out*/;
            inputs["kpiName"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["participantProfilesMetadata"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["tenantId"] = undefined /*out*/;
            inputs["thresHolds"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["unit"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:customerinsights/v20170101:Kpi" }, { type: "azure-nextgen:customerinsights/v20170426:Kpi" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Kpi.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Kpi resource.
 */
export interface KpiArgs {
    /**
     * The aliases.
     */
    readonly aliases?: pulumi.Input<pulumi.Input<inputs.customerinsights.latest.KpiAlias>[]>;
    /**
     * The calculation window.
     */
    readonly calculationWindow: pulumi.Input<string>;
    /**
     * Name of calculation window field.
     */
    readonly calculationWindowFieldName?: pulumi.Input<string>;
    /**
     * Localized description for the KPI.
     */
    readonly description?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Localized display name for the KPI.
     */
    readonly displayName?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The mapping entity type.
     */
    readonly entityType: pulumi.Input<string>;
    /**
     * The mapping entity name.
     */
    readonly entityTypeName: pulumi.Input<string>;
    /**
     * The computation expression for the KPI.
     */
    readonly expression: pulumi.Input<string>;
    /**
     * The KPI extracts.
     */
    readonly extracts?: pulumi.Input<pulumi.Input<inputs.customerinsights.latest.KpiExtract>[]>;
    /**
     * The filter expression for the KPI.
     */
    readonly filter?: pulumi.Input<string>;
    /**
     * The computation function for the KPI.
     */
    readonly function: pulumi.Input<string>;
    /**
     * the group by properties for the KPI.
     */
    readonly groupBy?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The name of the hub.
     */
    readonly hubName: pulumi.Input<string>;
    /**
     * The name of the KPI.
     */
    readonly kpiName: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The KPI thresholds.
     */
    readonly thresHolds?: pulumi.Input<inputs.customerinsights.latest.KpiThresholds>;
    /**
     * The unit of measurement for the KPI.
     */
    readonly unit?: pulumi.Input<string>;
}
