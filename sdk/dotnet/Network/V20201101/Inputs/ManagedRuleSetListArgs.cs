// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20201101.Inputs
{

    /// <summary>
    /// Defines the list of managed rule sets for the policy.
    /// </summary>
    public sealed class ManagedRuleSetListArgs : Pulumi.ResourceArgs
    {
        [Input("managedRuleSets")]
        private InputList<Inputs.ManagedRuleSetArgs>? _managedRuleSets;

        /// <summary>
        /// List of rule sets.
        /// </summary>
        public InputList<Inputs.ManagedRuleSetArgs> ManagedRuleSets
        {
            get => _managedRuleSets ?? (_managedRuleSets = new InputList<Inputs.ManagedRuleSetArgs>());
            set => _managedRuleSets = value;
        }

        public ManagedRuleSetListArgs()
        {
        }
    }
}
