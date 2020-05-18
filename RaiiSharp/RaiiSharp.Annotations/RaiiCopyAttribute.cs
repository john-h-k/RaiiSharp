using System;
using System.Collections.Generic;
using System.Text;

namespace RaiiSharp.Annotations
{
    /// <summary>
    /// Indicates that the method copies the pointer and ref increments if applicable, 
    /// allowing the callee and caller to continue using the value. The caller must appropriately
    /// dispose of the returned value
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class RaiiCopyAttribute : Attribute
    {
    }
}
