"use strict";
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***
Object.defineProperty(exports, "__esModule", { value: true });
const pulumi = require("@pulumi/pulumi");
const utilities = require("../../utilities");
/**
 * Class representing a Traffic Manager endpoint.
 */
class Endpoint extends pulumi.CustomResource {
    constructor(name, argsOrState, opts) {
        let inputs = {};
        if (!(opts && opts.id)) {
            const args = argsOrState;
            if (!args || args.endpointName === undefined) {
                throw new Error("Missing required property 'endpointName'");
            }
            if (!args || args.endpointType === undefined) {
                throw new Error("Missing required property 'endpointType'");
            }
            if (!args || args.profileName === undefined) {
                throw new Error("Missing required property 'profileName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["customHeaders"] = args ? args.customHeaders : undefined;
            inputs["endpointLocation"] = args ? args.endpointLocation : undefined;
            inputs["endpointMonitorStatus"] = args ? args.endpointMonitorStatus : undefined;
            inputs["endpointName"] = args ? args.endpointName : undefined;
            inputs["endpointStatus"] = args ? args.endpointStatus : undefined;
            inputs["endpointType"] = args ? args.endpointType : undefined;
            inputs["geoMapping"] = args ? args.geoMapping : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["minChildEndpoints"] = args ? args.minChildEndpoints : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["priority"] = args ? args.priority : undefined;
            inputs["profileName"] = args ? args.profileName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["target"] = args ? args.target : undefined;
            inputs["targetResourceId"] = args ? args.targetResourceId : undefined;
            inputs["type"] = args ? args.type : undefined;
            inputs["weight"] = args ? args.weight : undefined;
        }
        if (!opts) {
            opts = {};
        }
        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azurerm:network/v20151101:Endpoint" }, { type: "azurerm:network/v20170301:Endpoint" }, { type: "azurerm:network/v20170501:Endpoint" }, { type: "azurerm:network/v20180201:Endpoint" }, { type: "azurerm:network/v20180401:Endpoint" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Endpoint.__pulumiType, name, inputs, opts);
    }
    /**
     * Get an existing Endpoint resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name, id, opts) {
        return new Endpoint(name, undefined, Object.assign(Object.assign({}, opts), { id: id }));
    }
    /**
     * Returns true if the given object is an instance of Endpoint.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj) {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Endpoint.__pulumiType;
    }
}
exports.Endpoint = Endpoint;
/** @internal */
Endpoint.__pulumiType = 'azurerm:network/v20180301:Endpoint';
//# sourceMappingURL=endpoint.js.map