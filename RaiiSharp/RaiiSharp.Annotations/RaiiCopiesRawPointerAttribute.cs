using System;
using System.Collections.Generic;
using System.Text;

namespace RaiiSharp.Annotations
{
    /// <summary>
    /// Indicates that the method or constructor copies the pointer and ref increments if applicable, 
    /// allowing the caller to continue using the pointer
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor)]
    public sealed class RaiiCopiesRawPointerAttribute : Attribute
    {
    }
}
