// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.NetApp.V20200801.Inputs
{

    /// <summary>
    /// Volume Export Policy Rule
    /// </summary>
    public sealed class ExportPolicyRuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Client ingress specification as comma separated string with IPv4 CIDRs, IPv4 host addresses and host names
        /// </summary>
        [Input("allowedClients")]
        public Input<string>? AllowedClients { get; set; }

        /// <summary>
        /// Allows CIFS protocol
        /// </summary>
        [Input("cifs")]
        public Input<bool>? Cifs { get; set; }

        /// <summary>
        /// Has root access to volume
        /// </summary>
        [Input("hasRootAccess")]
        public Input<bool>? HasRootAccess { get; set; }

        /// <summary>
        /// Kerberos5 Read only access. To be use with swagger version 2020-05-01 or later
        /// </summary>
        [Input("kerberos5ReadOnly")]
        public Input<bool>? Kerberos5ReadOnly { get; set; }

        /// <summary>
        /// Kerberos5 Read and write access. To be use with swagger version 2020-05-01 or later
        /// </summary>
        [Input("kerberos5ReadWrite")]
        public Input<bool>? Kerberos5ReadWrite { get; set; }

        /// <summary>
        /// Kerberos5i Read only access. To be use with swagger version 2020-05-01 or later
        /// </summary>
        [Input("kerberos5iReadOnly")]
        public Input<bool>? Kerberos5iReadOnly { get; set; }

        /// <summary>
        /// Kerberos5i Read and write access. To be use with swagger version 2020-05-01 or later
        /// </summary>
        [Input("kerberos5iReadWrite")]
        public Input<bool>? Kerberos5iReadWrite { get; set; }

        /// <summary>
        /// Kerberos5p Read only access. To be use with swagger version 2020-05-01 or later
        /// </summary>
        [Input("kerberos5pReadOnly")]
        public Input<bool>? Kerberos5pReadOnly { get; set; }

        /// <summary>
        /// Kerberos5p Read and write access. To be use with swagger version 2020-05-01 or later
        /// </summary>
        [Input("kerberos5pReadWrite")]
        public Input<bool>? Kerberos5pReadWrite { get; set; }

        /// <summary>
        /// Allows NFSv3 protocol. Enable only for NFSv3 type volumes
        /// </summary>
        [Input("nfsv3")]
        public Input<bool>? Nfsv3 { get; set; }

        /// <summary>
        /// Allows NFSv4.1 protocol. Enable only for NFSv4.1 type volumes
        /// </summary>
        [Input("nfsv41")]
        public Input<bool>? Nfsv41 { get; set; }

        /// <summary>
        /// Order index
        /// </summary>
        [Input("ruleIndex")]
        public Input<int>? RuleIndex { get; set; }

        /// <summary>
        /// Read only access
        /// </summary>
        [Input("unixReadOnly")]
        public Input<bool>? UnixReadOnly { get; set; }

        /// <summary>
        /// Read and write access
        /// </summary>
        [Input("unixReadWrite")]
        public Input<bool>? UnixReadWrite { get; set; }

        public ExportPolicyRuleArgs()
        {
            HasRootAccess = true;
            Kerberos5ReadOnly = false;
            Kerberos5ReadWrite = false;
            Kerberos5iReadOnly = false;
            Kerberos5iReadWrite = false;
            Kerberos5pReadOnly = false;
            Kerberos5pReadWrite = false;
        }
    }
}
