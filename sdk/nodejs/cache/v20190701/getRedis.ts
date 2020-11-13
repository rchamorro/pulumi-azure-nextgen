// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getRedis(args: GetRedisArgs, opts?: pulumi.InvokeOptions): Promise<GetRedisResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:cache/v20190701:getRedis", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetRedisArgs {
    /**
     * The name of the Redis cache.
     */
    readonly name: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * A single Redis item in List or Get Operation.
 */
export interface GetRedisResult {
    /**
     * The keys of the Redis cache - not set if this object is not the response to Create or Update redis cache
     */
    readonly accessKeys: outputs.cache.v20190701.RedisAccessKeysResponse;
    /**
     * Specifies whether the non-ssl Redis server port (6379) is enabled.
     */
    readonly enableNonSslPort?: boolean;
    /**
     * Redis host name.
     */
    readonly hostName: string;
    /**
     * List of the Redis instances associated with the cache
     */
    readonly instances: outputs.cache.v20190701.RedisInstanceDetailsResponse[];
    /**
     * List of the linked servers associated with the cache
     */
    readonly linkedServers: outputs.cache.v20190701.RedisLinkedServerResponse[];
    /**
     * The geo-location where the resource lives
     */
    readonly location: string;
    /**
     * Optional: requires clients to use a specified TLS version (or higher) to connect (e,g, '1.0', '1.1', '1.2')
     */
    readonly minimumTlsVersion?: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Redis non-SSL port.
     */
    readonly port: number;
    /**
     * Redis instance provisioning status.
     */
    readonly provisioningState: string;
    /**
     * All Redis Settings. Few possible keys: rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value etc.
     */
    readonly redisConfiguration?: {[key: string]: string};
    /**
     * Redis version.
     */
    readonly redisVersion: string;
    /**
     * The number of replicas to be created per master.
     */
    readonly replicasPerMaster?: number;
    /**
     * The number of shards to be created on a Premium Cluster Cache.
     */
    readonly shardCount?: number;
    /**
     * The SKU of the Redis cache to deploy.
     */
    readonly sku: outputs.cache.v20190701.SkuResponse;
    /**
     * Redis SSL port.
     */
    readonly sslPort: number;
    /**
     * Static IP address. Required when deploying a Redis cache inside an existing Azure Virtual Network.
     */
    readonly staticIP?: string;
    /**
     * The full resource ID of a subnet in a virtual network to deploy the Redis cache in. Example format: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/Microsoft.{Network|ClassicNetwork}/VirtualNetworks/vnet1/subnets/subnet1
     */
    readonly subnetId?: string;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * A dictionary of tenant settings
     */
    readonly tenantSettings?: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * A list of availability zones denoting where the resource needs to come from.
     */
    readonly zones?: string[];
}
