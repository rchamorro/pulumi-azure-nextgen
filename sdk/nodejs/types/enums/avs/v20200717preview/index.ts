// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***


export const AddonType = {
    SRM: "SRM",
    VR: "VR",
} as const;

/**
 * The type of private cloud addon
 */
export type AddonType = (typeof AddonType)[keyof typeof AddonType];

export const DhcpTypeEnum = {
    SERVER_RELAY: "SERVER, RELAY",
} as const;

/**
 * Type of DHCP: SERVER or RELAY.
 */
export type DhcpTypeEnum = (typeof DhcpTypeEnum)[keyof typeof DhcpTypeEnum];

export const DnsServiceLogLevelEnum = {
    DEBUG: "DEBUG",
    INFO: "INFO",
    WARNING: "WARNING",
    ERROR: "ERROR",
    FATAL: "FATAL",
} as const;

/**
 * DNS Service log level.
 */
export type DnsServiceLogLevelEnum = (typeof DnsServiceLogLevelEnum)[keyof typeof DnsServiceLogLevelEnum];

export const InternetEnum = {
    Enabled: "Enabled",
    Disabled: "Disabled",
} as const;

/**
 * Connectivity to internet is enabled or disabled
 */
export type InternetEnum = (typeof InternetEnum)[keyof typeof InternetEnum];

export const PortMirroringDirectionEnum = {
    INGRESS_EGRESS_BIDIRECTIONAL: "INGRESS, EGRESS, BIDIRECTIONAL",
} as const;

/**
 * Direction of port mirroring profile.
 */
export type PortMirroringDirectionEnum = (typeof PortMirroringDirectionEnum)[keyof typeof PortMirroringDirectionEnum];

export const SslEnum = {
    Enabled: "Enabled",
    Disabled: "Disabled",
} as const;

/**
 * Protect LDAP communication using SSL certificate (LDAPS)
 */
export type SslEnum = (typeof SslEnum)[keyof typeof SslEnum];
