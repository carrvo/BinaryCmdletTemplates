using System;
using System.Management.Automation;

namespace $safeprojectname$
{
    /// <summary>
    /// <para type="synopsis"></para>
    /// <para type="description"></para>
    /// <example>
    ///     <para></para>
    ///     <code></code>
    /// </example>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "Cmdlet", ConfirmImpact = ConfirmImpact.Medium)]
    public sealed class GetCmdletCommand : Cmdlet
    {
        /// <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        [Alias("Argument1")]
        public String Parameter1 { get; set; }

        /// <inheritdoc />
        protected override void ProcessRecord()
        {
            WriteObject($"Hello {Parameter1}");
        }
    }
}
