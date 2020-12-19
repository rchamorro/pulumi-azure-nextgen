// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./account";
export * from "./getAccount";
export * from "./getPrivateEndpointConnection";
export * from "./listAccountKeys";
export * from "./privateEndpointConnection";

// Export enums:
export * from "../../types/enums/purview/v20201201preview";

// Import resources to register:
import { Account } from "./account";
import { PrivateEndpointConnection } from "./privateEndpointConnection";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-nextgen:purview/v20201201preview:Account":
                return new Account(name, <any>undefined, { urn })
            case "azure-nextgen:purview/v20201201preview:PrivateEndpointConnection":
                return new PrivateEndpointConnection(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-nextgen", "purview/v20201201preview", _module)
