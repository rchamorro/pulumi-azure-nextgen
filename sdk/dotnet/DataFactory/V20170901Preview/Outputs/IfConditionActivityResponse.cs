// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20170901Preview.Outputs
{

    [OutputType]
    public sealed class IfConditionActivityResponse
    {
        /// <summary>
        /// Activity depends on condition.
        /// </summary>
        public readonly ImmutableArray<Outputs.ActivityDependencyResponse> DependsOn;
        /// <summary>
        /// Activity description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// An expression that would evaluate to Boolean. This is used to determine the block of activities (ifTrueActivities or ifFalseActivities) that will be executed.
        /// </summary>
        public readonly Outputs.ExpressionResponse Expression;
        /// <summary>
        /// List of activities to execute if expression is evaluated to false. This is an optional property and if not provided, the activity will exit without any action.
        /// </summary>
        public readonly ImmutableArray<object> IfFalseActivities;
        /// <summary>
        /// List of activities to execute if expression is evaluated to true. This is an optional property and if not provided, the activity will exit without any action.
        /// </summary>
        public readonly ImmutableArray<object> IfTrueActivities;
        /// <summary>
        /// Activity name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Type of activity.
        /// Expected value is 'Container'.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private IfConditionActivityResponse(
            ImmutableArray<Outputs.ActivityDependencyResponse> dependsOn,

            string? description,

            Outputs.ExpressionResponse expression,

            ImmutableArray<object> ifFalseActivities,

            ImmutableArray<object> ifTrueActivities,

            string name,

            string type)
        {
            DependsOn = dependsOn;
            Description = description;
            Expression = expression;
            IfFalseActivities = ifFalseActivities;
            IfTrueActivities = ifTrueActivities;
            Name = name;
            Type = type;
        }
    }
}
