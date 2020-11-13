// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Aad.V20200101.Outputs
{

    [OutputType]
    public sealed class DomainSecuritySettingsResponse
    {
        /// <summary>
        /// A flag to determine whether or not NtlmV1 is enabled or disabled.
        /// </summary>
        public readonly string? NtlmV1;
        /// <summary>
        /// A flag to determine whether or not SyncKerberosPasswords is enabled or disabled.
        /// </summary>
        public readonly string? SyncKerberosPasswords;
        /// <summary>
        /// A flag to determine whether or not SyncNtlmPasswords is enabled or disabled.
        /// </summary>
        public readonly string? SyncNtlmPasswords;
        /// <summary>
        /// A flag to determine whether or not SyncOnPremPasswords is enabled or disabled.
        /// </summary>
        public readonly string? SyncOnPremPasswords;
        /// <summary>
        /// A flag to determine whether or not TlsV1 is enabled or disabled.
        /// </summary>
        public readonly string? TlsV1;

        [OutputConstructor]
        private DomainSecuritySettingsResponse(
            string? ntlmV1,

            string? syncKerberosPasswords,

            string? syncNtlmPasswords,

            string? syncOnPremPasswords,

            string? tlsV1)
        {
            NtlmV1 = ntlmV1;
            SyncKerberosPasswords = syncKerberosPasswords;
            SyncNtlmPasswords = syncNtlmPasswords;
            SyncOnPremPasswords = syncOnPremPasswords;
            TlsV1 = tlsV1;
        }
    }
}
