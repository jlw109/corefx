﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Text.Json.Serialization
{
    /// <summary>
    /// Determines the naming policy used to convert a JSON name to another format, such as a camel-casing format.
    /// </summary>
    public abstract class JsonNamingPolicy
    {
        protected JsonNamingPolicy() { }

        /// <summary>
        /// Returns the naming policy for camel-casing.
        /// </summary>
        public static JsonNamingPolicy CamelCase { get; } = new JsonCamelCaseNamePolicy();

        /// <summary>
        /// Converts the provided name.
        /// </summary>
        /// <param name="name">The name to convert.</param>
        /// <returns>The converted name.</returns>
        public abstract string ConvertName(string name);
    }
}
