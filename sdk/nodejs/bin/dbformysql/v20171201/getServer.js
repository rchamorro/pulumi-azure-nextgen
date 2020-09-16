"use strict";
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***
Object.defineProperty(exports, "__esModule", { value: true });
const pulumi = require("@pulumi/pulumi");
const utilities = require("../../utilities");
function getServer(args, opts) {
    if (!opts) {
        opts = {};
    }
    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azurerm:dbformysql/v20171201:getServer", {
        "resourceGroupName": args.resourceGroupName,
        "serverName": args.serverName,
    }, opts);
}
exports.getServer = getServer;
//# sourceMappingURL=getServer.js.map