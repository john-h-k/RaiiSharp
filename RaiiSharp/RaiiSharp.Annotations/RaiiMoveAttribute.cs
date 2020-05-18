using System;
using System.Collections.Generic;
using System.Text;

namespace RaiiSharp.Annotations
{
    /// <summary>
    /// Indicates the method is used for moving unmanaged resources, without incrementing the reference count.
    /// The callee may no longer use the pointer, and the caller takes ownership of it. The caller must appropriately
    /// dispose of the returned value
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class RaiiMoveAttribute : Attribute
    {

    }
}
