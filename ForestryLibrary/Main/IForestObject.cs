using System;
using System.Collections.Generic;
using System.Text;

namespace ForestryLibrary.Main
{
    /// <summary>
    /// IForestObject is the highest level of object in ForestryLibrary.Main
    /// All other objects in the ForestryLibrary.Main namespace must implement this interface
    /// </summary>
    public interface IForestObject
    {
        /// <summary>
        /// Id of an object, usually retrieved from the database.
        /// User cannot set this directly
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Name of an object, usually retrieved from the database.
        /// User cannot set this directly
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Description of what an object is, usually retrieved from the database.
        /// User cannot set this directly
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Comments relating to an object, usually retrieved from the database.
        /// User cannot set this directly
        /// </summary>
        string Comments { get; }



    }
}
