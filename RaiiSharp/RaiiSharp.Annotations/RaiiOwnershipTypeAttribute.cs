using System;
using System.Collections.Generic;
using System.Text;

namespace RaiiSharp.Annotations
{
    /// <summary>
    /// Indicates a type is an owner of an unmanaged resource
    /// </summary>
    [AttributeUsage(AttributeTargets.Struct)]
    public sealed class RaiiOwnershipTypeAttribute : Attribute
    {
    }
}
