using System;
using System.Collections.Generic;
using System.Text;

namespace RaiiSharp.Annotations
{
    /// <summary>
    /// Indicates that the method or constructor takes ownership of the pointer from the caller, without incrementing the reference count.
    /// The caller may no longer use the pointer
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor)]
    public sealed class RaiiTakesOwnershipOfRawPointerAttribute : Attribute
    {
    }
}
