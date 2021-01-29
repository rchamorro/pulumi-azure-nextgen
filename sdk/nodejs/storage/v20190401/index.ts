// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./blobContainer";
export * from "./blobContainerImmutabilityPolicy";
export * from "./blobServiceProperties";
export * from "./fileServiceProperties";
export * from "./fileShare";
export * from "./getBlobContainer";
export * from "./getBlobContainerImmutabilityPolicy";
export * from "./getBlobServiceProperties";
export * from "./getFileServiceProperties";
export * from "./getFileShare";
export * from "./getManagementPolicy";
export * from "./getStorageAccount";
export * from "./listStorageAccountKeys";
export * from "./listStorageAccountSAS";
export * from "./listStorageAccountServiceSAS";
export * from "./managementPolicy";
export * from "./storageAccount";

// Export enums:
export * from "../../types/enums/storage/v20190401";

// Import resources to register:
import { BlobContainer } from "./blobContainer";
import { BlobContainerImmutabilityPolicy } from "./blobContainerImmutabilityPolicy";
import { BlobServiceProperties } from "./blobServiceProperties";
import { FileServiceProperties } from "./fileServiceProperties";
import { FileShare } from "./fileShare";
import { ManagementPolicy } from "./managementPolicy";
import { StorageAccount } from "./storageAccount";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-nextgen:storage/v20190401:BlobContainer":
                return new BlobContainer(name, <any>undefined, { urn })
            case "azure-nextgen:storage/v20190401:BlobContainerImmutabilityPolicy":
                return new BlobContainerImmutabilityPolicy(name, <any>undefined, { urn })
            case "azure-nextgen:storage/v20190401:BlobServiceProperties":
                return new BlobServiceProperties(name, <any>undefined, { urn })
            case "azure-nextgen:storage/v20190401:FileServiceProperties":
                return new FileServiceProperties(name, <any>undefined, { urn })
            case "azure-nextgen:storage/v20190401:FileShare":
                return new FileShare(name, <any>undefined, { urn })
            case "azure-nextgen:storage/v20190401:ManagementPolicy":
                return new ManagementPolicy(name, <any>undefined, { urn })
            case "azure-nextgen:storage/v20190401:StorageAccount":
                return new StorageAccount(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-nextgen", "storage/v20190401", _module)
