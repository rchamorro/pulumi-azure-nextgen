// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.Latest.Inputs
{

    /// <summary>
    /// SQL stored procedure activity type.
    /// </summary>
    public sealed class SqlServerStoredProcedureActivityArgs : Pulumi.ResourceArgs
    {
        [Input("dependsOn")]
        private InputList<Inputs.ActivityDependencyArgs>? _dependsOn;

        /// <summary>
        /// Activity depends on condition.
        /// </summary>
        public InputList<Inputs.ActivityDependencyArgs> DependsOn
        {
            get => _dependsOn ?? (_dependsOn = new InputList<Inputs.ActivityDependencyArgs>());
            set => _dependsOn = value;
        }

        /// <summary>
        /// Activity description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Linked service reference.
        /// </summary>
        [Input("linkedServiceName", required: true)]
        public Input<Inputs.LinkedServiceReferenceArgs> LinkedServiceName { get; set; } = null!;

        /// <summary>
        /// Activity name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Activity policy.
        /// </summary>
        [Input("policy")]
        public Input<Inputs.ActivityPolicyArgs>? Policy { get; set; }

        /// <summary>
        /// Stored procedure name. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("storedProcedureName", required: true)]
        public Input<object> StoredProcedureName { get; set; } = null!;

        [Input("storedProcedureParameters")]
        private InputMap<Inputs.StoredProcedureParameterArgs>? _storedProcedureParameters;

        /// <summary>
        /// Value and type setting for stored procedure parameters. Example: "{Parameter1: {value: "1", type: "int"}}".
        /// </summary>
        public InputMap<Inputs.StoredProcedureParameterArgs> StoredProcedureParameters
        {
            get => _storedProcedureParameters ?? (_storedProcedureParameters = new InputMap<Inputs.StoredProcedureParameterArgs>());
            set => _storedProcedureParameters = value;
        }

        /// <summary>
        /// Type of activity.
        /// Expected value is 'Execution'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        [Input("userProperties")]
        private InputList<Inputs.UserPropertyArgs>? _userProperties;

        /// <summary>
        /// Activity user properties.
        /// </summary>
        public InputList<Inputs.UserPropertyArgs> UserProperties
        {
            get => _userProperties ?? (_userProperties = new InputList<Inputs.UserPropertyArgs>());
            set => _userProperties = value;
        }

        public SqlServerStoredProcedureActivityArgs()
        {
        }
    }
}
