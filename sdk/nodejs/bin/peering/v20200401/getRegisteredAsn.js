"use strict";
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***
Object.defineProperty(exports, "__esModule", { value: true });
const pulumi = require("@pulumi/pulumi");
const utilities = require("../../utilities");
function getRegisteredAsn(args, opts) {
    if (!opts) {
        opts = {};
    }
    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azurerm:peering/v20200401:getRegisteredAsn", {
        "peeringName": args.peeringName,
        "registeredAsnName": args.registeredAsnName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}
exports.getRegisteredAsn = getRegisteredAsn;
//# sourceMappingURL=getRegisteredAsn.js.map