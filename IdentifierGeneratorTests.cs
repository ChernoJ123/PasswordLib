using NUnit.Framework;

namespace PasswordLib.Tests
{
    public class IdentifierGeneratorTests
    {
        [Test]
        public void GenerateUuidV4_ReturnsValidGuid()
        {
            string uuid = PasswordLib.IdentifierGenerator.GenerateUuidV4();
            Assert.DoesNotThrow(() => System.Guid.Parse(uuid));
        }

        [Test]
        public void GenerateUuidV4_MultipleCallsAreUnique()
        {
            string uuid1 = PasswordLib.IdentifierGenerator.GenerateUuidV4();
            string uuid2 = PasswordLib.IdentifierGenerator.GenerateUuidV4();
            Assert.AreNotEqual(uuid1, uuid2);
        }
    }
}
