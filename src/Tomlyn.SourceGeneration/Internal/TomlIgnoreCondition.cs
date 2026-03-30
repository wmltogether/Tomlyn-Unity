// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace Tomlyn.Serialization
{

    public enum TomlIgnoreCondition
    {
        /// <summary>
        /// Property is never ignored during serialization or deserialization.
        /// </summary>
        Never = 0,
        /// <summary>
        /// Property is always ignored during serialization and deserialization.
        /// </summary>
        Always = 1,
        /// <summary>
        /// If the value is the default, the property is ignored during serialization.
        /// This is applied to both reference and value-type properties and fields.
        /// </summary>
        WhenWritingDefault = 2,
        /// <summary>
        /// If the value is <see langword="null"/>, the property is ignored during serialization.
        /// This is applied only to reference-type properties and fields.
        /// </summary>
        WhenWritingNull = 3,
        /// <summary>
        /// Property is ignored during serialization
        /// </summary>
        WhenWriting = 4,
        /// <summary>
        /// Property is ignored during deserialization
        /// </summary>
        WhenReading = 5,
    }
}