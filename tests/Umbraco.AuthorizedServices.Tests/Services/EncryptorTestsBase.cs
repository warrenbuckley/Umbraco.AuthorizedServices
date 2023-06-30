using Umbraco.AuthorizedServices.Services;

namespace Umbraco.AuthorizedServices.Tests.Services;

internal abstract class EncryptorTestsBase
{
    protected const string Message = "When seagulls follow the trawler, it is because they think sardines will be thrown into the sea.";

    [Test]
    public void Encrypt_And_Decrypt()
    {
        // Arrange
        ISecretEncryptor sut = CreateEncrytor();

        // Act
        var encryptedMessage = sut.Encrypt(Message);
        var decryptedMessage = sut.Decrypt(encryptedMessage);

        // Assert
        decryptedMessage.Should().Be(Message);
    }

    protected abstract ISecretEncryptor CreateEncrytor();
}
