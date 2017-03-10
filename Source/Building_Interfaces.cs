using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace FactoryFramework
{
    /// <summary>
    /// Stores one type of item internally. Useful for item piping *wink*
    /// </summary>
    public interface IInternalStorage
    {
        /// <summary>
        /// Can be overridden in SpawnSetup, Tick etc.
        /// </summary>
        int thingCount { get; set; }
        /// <summary>
        /// The ThingDef that you are storing.
        /// </summary>
        ThingDef internalStoredDef { get; }
        /// <summary>
        /// The maximum amount of items this can store.
        /// </summary>
        int maxCount { get; }
    }
    /// <summary>
    /// Defines an internal storage interface that stores multiple item types. Uses ThingCountClass instead.
    /// </summary>
    public interface IMultipleInternalStorage
    {
        /// <summary>
        /// Getter for the list of items in the storage.
        /// </summary>
        List<ThingCountClass> thingCountClass { get; }
        /// <summary>
        /// Adds a ThingCountClass to internal storage.
        /// </summary>
        void AddToStorage(ThingCountClass newitem);
        /// <summary>
        /// Removes an amount of a thing type from internal storage.
        /// </summary>
        void RemoveFromStorage(ThingCountClass item);
        /// <summary>
        /// The maximum number of item types allowed in internal storage.
        /// </summary>
        int maxNumItemTypesAllowed { get; }
        /// <summary>
        /// The max amount of an item the storage can store.
        /// </summary>
        int maxCount { get; }
    }
}
