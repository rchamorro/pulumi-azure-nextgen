// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Represents a Storage Account on the  Data Box Edge/Gateway device.
 * Latest API Version: 2020-09-01.
 */
export class StorageAccount extends pulumi.CustomResource {
    /**
     * Get an existing StorageAccount resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): StorageAccount {
        return new StorageAccount(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:databoxedge/latest:StorageAccount';

    /**
     * Returns true if the given object is an instance of StorageAccount.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is StorageAccount {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === StorageAccount.__pulumiType;
    }

    /**
     * BlobEndpoint of Storage Account
     */
    public /*out*/ readonly blobEndpoint!: pulumi.Output<string>;
    /**
     * The Container Count. Present only for Storage Accounts with DataPolicy set to Cloud.
     */
    public /*out*/ readonly containerCount!: pulumi.Output<number>;
    /**
     * Data policy of the storage Account.
     */
    public readonly dataPolicy!: pulumi.Output<string>;
    /**
     * Description for the storage Account.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * The object name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Storage Account Credential Id
     */
    public readonly storageAccountCredentialId!: pulumi.Output<string | undefined>;
    /**
     * Current status of the storage account
     */
    public readonly storageAccountStatus!: pulumi.Output<string | undefined>;
    /**
     * StorageAccount object on ASE device
     */
    public /*out*/ readonly systemData!: pulumi.Output<outputs.databoxedge.latest.SystemDataResponse>;
    /**
     * The hierarchical type of the object.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a StorageAccount resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: StorageAccountArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.dataPolicy === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'dataPolicy'");
            }
            if ((!args || args.deviceName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'deviceName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.storageAccountName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'storageAccountName'");
            }
            inputs["dataPolicy"] = args ? args.dataPolicy : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["deviceName"] = args ? args.deviceName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["storageAccountCredentialId"] = args ? args.storageAccountCredentialId : undefined;
            inputs["storageAccountName"] = args ? args.storageAccountName : undefined;
            inputs["storageAccountStatus"] = args ? args.storageAccountStatus : undefined;
            inputs["blobEndpoint"] = undefined /*out*/;
            inputs["containerCount"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["systemData"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["blobEndpoint"] = undefined /*out*/;
            inputs["containerCount"] = undefined /*out*/;
            inputs["dataPolicy"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["storageAccountCredentialId"] = undefined /*out*/;
            inputs["storageAccountStatus"] = undefined /*out*/;
            inputs["systemData"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:databoxedge/v20190801:StorageAccount" }, { type: "azure-nextgen:databoxedge/v20200501preview:StorageAccount" }, { type: "azure-nextgen:databoxedge/v20200901:StorageAccount" }, { type: "azure-nextgen:databoxedge/v20200901preview:StorageAccount" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(StorageAccount.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a StorageAccount resource.
 */
export interface StorageAccountArgs {
    /**
     * Data policy of the storage Account.
     */
    readonly dataPolicy: pulumi.Input<string | enums.databoxedge.latest.DataPolicy>;
    /**
     * Description for the storage Account.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * The device name.
     */
    readonly deviceName: pulumi.Input<string>;
    /**
     * The resource group name.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Storage Account Credential Id
     */
    readonly storageAccountCredentialId?: pulumi.Input<string>;
    /**
     * The StorageAccount name.
     */
    readonly storageAccountName: pulumi.Input<string>;
    /**
     * Current status of the storage account
     */
    readonly storageAccountStatus?: pulumi.Input<string | enums.databoxedge.latest.StorageAccountStatus>;
}
