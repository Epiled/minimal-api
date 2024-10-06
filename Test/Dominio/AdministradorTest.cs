using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestatGetSetPropriedades()
    {
      // Arrange
      var adm = new Administrador();

      // Act
      adm.Id = 1;
      adm.Email = "teste@test.com";
      adm.Senha = "teste";
      adm.Perfil = "Adm";

      // Assert
      Assert.AreEqual(1, adm.Id);
      Assert.AreEqual("teste@test.com", adm.Email);
      Assert.AreEqual("teste", adm.Senha);
      Assert.AreEqual("Adm", adm.Perfil);

    }
}