"use strict";
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***
Object.defineProperty(exports, "__esModule", { value: true });
const pulumi = require("@pulumi/pulumi");
const utilities = require("../../utilities");
function getZone(args, opts) {
    if (!opts) {
        opts = {};
    }
    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azurerm:network/v20170901:getZone", {
        "resourceGroupName": args.resourceGroupName,
        "zoneName": args.zoneName,
    }, opts);
}
exports.getZone = getZone;
//# sourceMappingURL=getZone.js.map