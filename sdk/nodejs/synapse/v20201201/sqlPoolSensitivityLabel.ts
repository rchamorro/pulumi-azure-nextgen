// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * A sensitivity label.
 */
export class SqlPoolSensitivityLabel extends pulumi.CustomResource {
    /**
     * Get an existing SqlPoolSensitivityLabel resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): SqlPoolSensitivityLabel {
        return new SqlPoolSensitivityLabel(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:synapse/v20201201:SqlPoolSensitivityLabel';

    /**
     * Returns true if the given object is an instance of SqlPoolSensitivityLabel.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SqlPoolSensitivityLabel {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SqlPoolSensitivityLabel.__pulumiType;
    }

    /**
     * The column name.
     */
    public readonly columnName!: pulumi.Output<string>;
    /**
     * The information type.
     */
    public readonly informationType!: pulumi.Output<string | undefined>;
    /**
     * The information type ID.
     */
    public readonly informationTypeId!: pulumi.Output<string | undefined>;
    /**
     * Is sensitivity recommendation disabled. Applicable for recommended sensitivity label only. Specifies whether the sensitivity recommendation on this column is disabled (dismissed) or not.
     */
    public /*out*/ readonly isDisabled!: pulumi.Output<boolean>;
    /**
     * The label ID.
     */
    public readonly labelId!: pulumi.Output<string | undefined>;
    /**
     * The label name.
     */
    public readonly labelName!: pulumi.Output<string | undefined>;
    /**
     * managed by
     */
    public /*out*/ readonly managedBy!: pulumi.Output<string>;
    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    public readonly rank!: pulumi.Output<string | undefined>;
    /**
     * The schema name.
     */
    public readonly schemaName!: pulumi.Output<string>;
    /**
     * The table name.
     */
    public readonly tableName!: pulumi.Output<string>;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a SqlPoolSensitivityLabel resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SqlPoolSensitivityLabelArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.columnName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'columnName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.schemaName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'schemaName'");
            }
            if ((!args || args.sensitivityLabelSource === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'sensitivityLabelSource'");
            }
            if ((!args || args.sqlPoolName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'sqlPoolName'");
            }
            if ((!args || args.tableName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'tableName'");
            }
            if ((!args || args.workspaceName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'workspaceName'");
            }
            inputs["columnName"] = args ? args.columnName : undefined;
            inputs["informationType"] = args ? args.informationType : undefined;
            inputs["informationTypeId"] = args ? args.informationTypeId : undefined;
            inputs["labelId"] = args ? args.labelId : undefined;
            inputs["labelName"] = args ? args.labelName : undefined;
            inputs["rank"] = args ? args.rank : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["schemaName"] = args ? args.schemaName : undefined;
            inputs["sensitivityLabelSource"] = args ? args.sensitivityLabelSource : undefined;
            inputs["sqlPoolName"] = args ? args.sqlPoolName : undefined;
            inputs["tableName"] = args ? args.tableName : undefined;
            inputs["workspaceName"] = args ? args.workspaceName : undefined;
            inputs["isDisabled"] = undefined /*out*/;
            inputs["managedBy"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["columnName"] = undefined /*out*/;
            inputs["informationType"] = undefined /*out*/;
            inputs["informationTypeId"] = undefined /*out*/;
            inputs["isDisabled"] = undefined /*out*/;
            inputs["labelId"] = undefined /*out*/;
            inputs["labelName"] = undefined /*out*/;
            inputs["managedBy"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["rank"] = undefined /*out*/;
            inputs["schemaName"] = undefined /*out*/;
            inputs["tableName"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:synapse/v20190601preview:SqlPoolSensitivityLabel" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(SqlPoolSensitivityLabel.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a SqlPoolSensitivityLabel resource.
 */
export interface SqlPoolSensitivityLabelArgs {
    /**
     * The name of the column.
     */
    readonly columnName: pulumi.Input<string>;
    /**
     * The information type.
     */
    readonly informationType?: pulumi.Input<string>;
    /**
     * The information type ID.
     */
    readonly informationTypeId?: pulumi.Input<string>;
    /**
     * The label ID.
     */
    readonly labelId?: pulumi.Input<string>;
    /**
     * The label name.
     */
    readonly labelName?: pulumi.Input<string>;
    readonly rank?: pulumi.Input<enums.synapse.v20201201.SensitivityLabelRank>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the schema.
     */
    readonly schemaName: pulumi.Input<string>;
    /**
     * The source of the sensitivity label.
     */
    readonly sensitivityLabelSource: pulumi.Input<string>;
    /**
     * SQL pool name
     */
    readonly sqlPoolName: pulumi.Input<string>;
    /**
     * The name of the table.
     */
    readonly tableName: pulumi.Input<string>;
    /**
     * The name of the workspace
     */
    readonly workspaceName: pulumi.Input<string>;
}
