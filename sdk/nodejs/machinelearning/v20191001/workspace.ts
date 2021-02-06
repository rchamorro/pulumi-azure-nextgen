// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * An object that represents a machine learning workspace.
 */
export class Workspace extends pulumi.CustomResource {
    /**
     * Get an existing Workspace resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Workspace {
        return new Workspace(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:machinelearning/v20191001:Workspace';

    /**
     * Returns true if the given object is an instance of Workspace.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Workspace {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Workspace.__pulumiType;
    }

    /**
     * The creation time for this workspace resource.
     */
    public /*out*/ readonly creationTime!: pulumi.Output<string>;
    /**
     * The key vault identifier used for encrypted workspaces.
     */
    public readonly keyVaultIdentifierId!: pulumi.Output<string | undefined>;
    /**
     * The location of the resource. This cannot be changed after the resource is created.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The name of the resource.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The email id of the owner for this workspace.
     */
    public readonly ownerEmail!: pulumi.Output<string>;
    /**
     * The sku of the workspace.
     */
    public readonly sku!: pulumi.Output<outputs.machinelearning.v20191001.SkuResponse | undefined>;
    /**
     * The regional endpoint for the machine learning studio service which hosts this workspace.
     */
    public /*out*/ readonly studioEndpoint!: pulumi.Output<string>;
    /**
     * The tags of the resource.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The type of the resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * The fully qualified arm id of the storage account associated with this workspace.
     */
    public readonly userStorageAccountId!: pulumi.Output<string>;
    /**
     * The immutable id associated with this workspace.
     */
    public /*out*/ readonly workspaceId!: pulumi.Output<string>;
    /**
     * The current state of workspace resource.
     */
    public /*out*/ readonly workspaceState!: pulumi.Output<string>;
    /**
     * The type of this workspace.
     */
    public /*out*/ readonly workspaceType!: pulumi.Output<string>;

    /**
     * Create a Workspace resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: WorkspaceArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.ownerEmail === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'ownerEmail'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.userStorageAccountId === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'userStorageAccountId'");
            }
            if ((!args || args.workspaceName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'workspaceName'");
            }
            inputs["keyVaultIdentifierId"] = args ? args.keyVaultIdentifierId : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["ownerEmail"] = args ? args.ownerEmail : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["sku"] = args ? args.sku : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["userStorageAccountId"] = args ? args.userStorageAccountId : undefined;
            inputs["workspaceName"] = args ? args.workspaceName : undefined;
            inputs["creationTime"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["studioEndpoint"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["workspaceId"] = undefined /*out*/;
            inputs["workspaceState"] = undefined /*out*/;
            inputs["workspaceType"] = undefined /*out*/;
        } else {
            inputs["creationTime"] = undefined /*out*/;
            inputs["keyVaultIdentifierId"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["ownerEmail"] = undefined /*out*/;
            inputs["sku"] = undefined /*out*/;
            inputs["studioEndpoint"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["userStorageAccountId"] = undefined /*out*/;
            inputs["workspaceId"] = undefined /*out*/;
            inputs["workspaceState"] = undefined /*out*/;
            inputs["workspaceType"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:machinelearning/latest:Workspace" }, { type: "azure-nextgen:machinelearning/v20160401:Workspace" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Workspace.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Workspace resource.
 */
export interface WorkspaceArgs {
    /**
     * The key vault identifier used for encrypted workspaces.
     */
    readonly keyVaultIdentifierId?: pulumi.Input<string>;
    /**
     * The location of the resource. This cannot be changed after the resource is created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The email id of the owner for this workspace.
     */
    readonly ownerEmail: pulumi.Input<string>;
    /**
     * The name of the resource group to which the machine learning workspace belongs.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The sku of the workspace.
     */
    readonly sku?: pulumi.Input<inputs.machinelearning.v20191001.Sku>;
    /**
     * The tags of the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The fully qualified arm id of the storage account associated with this workspace.
     */
    readonly userStorageAccountId: pulumi.Input<string>;
    /**
     * The name of the machine learning workspace.
     */
    readonly workspaceName: pulumi.Input<string>;
}
