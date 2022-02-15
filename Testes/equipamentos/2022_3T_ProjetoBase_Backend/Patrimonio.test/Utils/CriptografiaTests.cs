
using Patrimonio.Utils;
using System.Text.RegularExpressions;
using Xunit;

namespace Patrimonio.test.Utils
{
    public class CriptografiaTests
    {
        [Fact] // Descrição
        public void Deve_Retornar_Hash_Em_BCcrypt()
        {
            // Pré-Condição / Arrange
            var senha = Criptografia.GerarHash("senha987654321");
            var regex = new Regex(@"^\$2[ayb]\$.{56}$");

            // Procedimento / Act
            var retorno = regex.IsMatch(senha);

            // Resultado Esperado / Assert
            Assert.True(retorno);
        }

        [Fact]
        public void Deve_Retornar_Comparacao_Valida()
        {
            // Pré-Condição / Arrange
            var senha = "123456789";
            var hashBanco = "$2a$11$9E.lDvUG4ExcdOlj68FnA.kcI8SA9szCJhZ5mTHstgRoBIrpXn5qG";
            // Procedimento / Act
            var comparacao = Criptografia.Comparar(senha, hashBanco);

            // Resultado Esperado / Assert
            Assert.True(comparacao);
        }
    }
}
