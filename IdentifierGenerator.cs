/// <summary>
/// Generates a version 4 Universally Unique Identifier (UUID) using .NET’s Guid.NewGuid().
/// </summary>
/// <remarks>
/// Version 4 UUIDs are randomly generated, providing a high probability of uniqueness.
/// Example output: "d3f7c2a8-fa03-4b6e-b5e1-a8f2cadc9b08"
/// </remarks>
/// <returns>A string form of the UUID.</returns>

using System;

namespace PasswordLib
{
    public static class IdentifierGenerator
    {
        /// <summary>
        /// Generates a valid version 4 UUID (random-based).
        /// </summary>
        /// <returns>A string representation of the newly generated UUID v4.</returns>
        public static string GenerateUuidV4()
        {
            Guid uuid = Guid.NewGuid();
            return uuid.ToString();
        }
    }
}
