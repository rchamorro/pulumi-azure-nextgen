"use strict";
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***
Object.defineProperty(exports, "__esModule", { value: true });
const pulumi = require("@pulumi/pulumi");
const utilities = require("../../utilities");
/**
 * A data set mapping data transfer object.
 */
class DataSetMapping extends pulumi.CustomResource {
    constructor(name, argsOrState, opts) {
        let inputs = {};
        if (!(opts && opts.id)) {
            const args = argsOrState;
            if (!args || args.accountName === undefined) {
                throw new Error("Missing required property 'accountName'");
            }
            if (!args || args.dataSetMappingName === undefined) {
                throw new Error("Missing required property 'dataSetMappingName'");
            }
            if (!args || args.kind === undefined) {
                throw new Error("Missing required property 'kind'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.shareSubscriptionName === undefined) {
                throw new Error("Missing required property 'shareSubscriptionName'");
            }
            inputs["accountName"] = args ? args.accountName : undefined;
            inputs["dataSetMappingName"] = args ? args.dataSetMappingName : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["shareSubscriptionName"] = args ? args.shareSubscriptionName : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {};
        }
        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(DataSetMapping.__pulumiType, name, inputs, opts);
    }
    /**
     * Get an existing DataSetMapping resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name, id, opts) {
        return new DataSetMapping(name, undefined, Object.assign(Object.assign({}, opts), { id: id }));
    }
    /**
     * Returns true if the given object is an instance of DataSetMapping.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj) {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DataSetMapping.__pulumiType;
    }
}
exports.DataSetMapping = DataSetMapping;
/** @internal */
DataSetMapping.__pulumiType = 'azurerm:datashare/v20191101:DataSetMapping';
//# sourceMappingURL=dataSetMapping.js.map