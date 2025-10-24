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
