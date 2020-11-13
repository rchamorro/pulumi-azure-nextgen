// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Contains information about an Azure Batch account.
 */
export class BatchAccount extends pulumi.CustomResource {
    /**
     * Get an existing BatchAccount resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): BatchAccount {
        return new BatchAccount(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:batch/v20170101:BatchAccount';

    /**
     * Returns true if the given object is an instance of BatchAccount.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is BatchAccount {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === BatchAccount.__pulumiType;
    }

    /**
     * The endpoint used by this account to interact with the Batch services.
     */
    public /*out*/ readonly accountEndpoint!: pulumi.Output<string>;
    public /*out*/ readonly activeJobAndJobScheduleQuota!: pulumi.Output<number>;
    /**
     * Contains information about the auto storage account associated with a Batch account.
     */
    public readonly autoStorage!: pulumi.Output<outputs.batch.v20170101.AutoStoragePropertiesResponse>;
    public /*out*/ readonly coreQuota!: pulumi.Output<number>;
    /**
     * Identifies the Azure key vault associated with a Batch account.
     */
    public readonly keyVaultReference!: pulumi.Output<outputs.batch.v20170101.KeyVaultReferenceResponse>;
    /**
     * The location of the resource
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The allocation mode for creating pools in the Batch account.
     */
    public readonly poolAllocationMode!: pulumi.Output<string>;
    public /*out*/ readonly poolQuota!: pulumi.Output<number>;
    /**
     * The provisioned state of the resource
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The tags of the resource
     */
    public readonly tags!: pulumi.Output<{[key: string]: string}>;
    /**
     * The type of the resource
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a BatchAccount resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: BatchAccountArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.accountName === undefined) {
                throw new Error("Missing required property 'accountName'");
            }
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["accountName"] = args ? args.accountName : undefined;
            inputs["autoStorage"] = args ? args.autoStorage : undefined;
            inputs["keyVaultReference"] = args ? args.keyVaultReference : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["poolAllocationMode"] = args ? args.poolAllocationMode : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["accountEndpoint"] = undefined /*out*/;
            inputs["activeJobAndJobScheduleQuota"] = undefined /*out*/;
            inputs["coreQuota"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["poolQuota"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["accountEndpoint"] = undefined /*out*/;
            inputs["activeJobAndJobScheduleQuota"] = undefined /*out*/;
            inputs["autoStorage"] = undefined /*out*/;
            inputs["coreQuota"] = undefined /*out*/;
            inputs["keyVaultReference"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["poolAllocationMode"] = undefined /*out*/;
            inputs["poolQuota"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:batch/latest:BatchAccount" }, { type: "azure-nextgen:batch/v20151201:BatchAccount" }, { type: "azure-nextgen:batch/v20170501:BatchAccount" }, { type: "azure-nextgen:batch/v20170901:BatchAccount" }, { type: "azure-nextgen:batch/v20181201:BatchAccount" }, { type: "azure-nextgen:batch/v20190401:BatchAccount" }, { type: "azure-nextgen:batch/v20190801:BatchAccount" }, { type: "azure-nextgen:batch/v20200301:BatchAccount" }, { type: "azure-nextgen:batch/v20200501:BatchAccount" }, { type: "azure-nextgen:batch/v20200901:BatchAccount" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(BatchAccount.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a BatchAccount resource.
 */
export interface BatchAccountArgs {
    /**
     * A name for the Batch account which must be unique within the region. Batch account names must be between 3 and 24 characters in length and must use only numbers and lowercase letters. This name is used as part of the DNS name that is used to access the Batch service in the region in which the account is created. For example: http://accountname.region.batch.azure.com/.
     */
    readonly accountName: pulumi.Input<string>;
    /**
     * The properties related to auto storage account.
     */
    readonly autoStorage?: pulumi.Input<inputs.batch.v20170101.AutoStorageBaseProperties>;
    /**
     * A reference to the Azure key vault associated with the Batch account.
     */
    readonly keyVaultReference?: pulumi.Input<inputs.batch.v20170101.KeyVaultReference>;
    /**
     * The region in which to create the account.
     */
    readonly location: pulumi.Input<string>;
    /**
     * The pool allocation mode also affects how clients may authenticate to the Batch Service API. If the mode is BatchService, clients may authenticate using access keys or Azure Active Directory. If the mode is UserSubscription, clients must use Azure Active Directory. The default is BatchService.
     */
    readonly poolAllocationMode?: pulumi.Input<string>;
    /**
     * The name of the resource group that contains the new Batch account.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The user specified tags associated with the account.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
