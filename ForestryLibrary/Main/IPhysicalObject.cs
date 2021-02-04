using ForestryLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForestryLibrary.Main
{
    /// <summary>
    /// IPhysical is an interface that represents physical objects (anything that can be touched)
    /// </summary>
    public interface IPhysicalObject : IForestObject
    {
        IGeography Location { get; }
    }
}
