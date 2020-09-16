"use strict";
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***
Object.defineProperty(exports, "__esModule", { value: true });
const pulumi = require("@pulumi/pulumi");
const utilities = require("../../utilities");
/**
 * The storage account credential.
 */
class StorageAccountCredential extends pulumi.CustomResource {
    constructor(name, argsOrState, opts) {
        let inputs = {};
        if (!(opts && opts.id)) {
            const args = argsOrState;
            if (!args || args.accountType === undefined) {
                throw new Error("Missing required property 'accountType'");
            }
            if (!args || args.alias === undefined) {
                throw new Error("Missing required property 'alias'");
            }
            if (!args || args.deviceName === undefined) {
                throw new Error("Missing required property 'deviceName'");
            }
            if (!args || args.name === undefined) {
                throw new Error("Missing required property 'name'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.sslStatus === undefined) {
                throw new Error("Missing required property 'sslStatus'");
            }
            inputs["accountKey"] = args ? args.accountKey : undefined;
            inputs["accountType"] = args ? args.accountType : undefined;
            inputs["alias"] = args ? args.alias : undefined;
            inputs["blobDomainName"] = args ? args.blobDomainName : undefined;
            inputs["connectionString"] = args ? args.connectionString : undefined;
            inputs["deviceName"] = args ? args.deviceName : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["sslStatus"] = args ? args.sslStatus : undefined;
            inputs["storageAccountId"] = args ? args.storageAccountId : undefined;
            inputs["userName"] = args ? args.userName : undefined;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {};
        }
        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azurerm:databoxedge/v20190301:StorageAccountCredential" }, { type: "azurerm:databoxedge/v20190801:StorageAccountCredential" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(StorageAccountCredential.__pulumiType, name, inputs, opts);
    }
    /**
     * Get an existing StorageAccountCredential resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name, id, opts) {
        return new StorageAccountCredential(name, undefined, Object.assign(Object.assign({}, opts), { id: id }));
    }
    /**
     * Returns true if the given object is an instance of StorageAccountCredential.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj) {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === StorageAccountCredential.__pulumiType;
    }
}
exports.StorageAccountCredential = StorageAccountCredential;
/** @internal */
StorageAccountCredential.__pulumiType = 'azurerm:databoxedge/v20190701:StorageAccountCredential';
//# sourceMappingURL=storageAccountCredential.js.map