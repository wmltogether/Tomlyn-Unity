// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace Tomlyn.Serialization
{
    /// <summary>
    /// Determines how deserialization will handle object creation for fields or properties.
    /// </summary>
    public enum TomlObjectCreationHandling
    {
        /// <summary>
        /// A new instance will always be created when deserializing a field or property.
        /// </summary>
        Replace = 0,

        /// <summary>
        /// Attempt to populate any instances already found on a deserialized field or property.
        /// </summary>
        Populate = 1,
    }
}