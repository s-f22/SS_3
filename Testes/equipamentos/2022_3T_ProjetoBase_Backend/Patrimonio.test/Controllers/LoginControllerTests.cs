using Microsoft.AspNetCore.Mvc;
using Moq;
using Patrimonio.Controllers;
using Patrimonio.Domains;
using Patrimonio.Interfaces;
using Patrimonio.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Patrimonio.test.Controllers
{
    public class LoginControllerTests
    {
        [Fact]
        public void Deve_Retornar_Usuario_Invalido()
        {
            // Pré-Condição / Arrange
            var fakeRepo = new Mock<IUsuarioRepository>();

            fakeRepo.Setup(x => x.Login(It.IsAny<string>(), It.IsAny<string>())).Returns((Usuario)null);

            var fakeViewModel = new LoginViewModel();
            fakeViewModel.Email = "samuel.email.com";
            fakeViewModel.Senha = "xoudaxuxaparabaixinhos";

            var controller = new LoginController(fakeRepo.Object);

            // Procedimento / Act
            var resultado = controller.Login(fakeViewModel);

            // Resultado esperado / Assert
            Assert.IsType<UnauthorizedObjectResult>(resultado);
        }


        [Fact]
        public void Deve_Retornar_Usuario_Valido()
        {
            // Pré-Condição / Arrange
            Usuario fakeUsuario = new Usuario();
            fakeUsuario.Email = "samuel@email.com";
            fakeUsuario.Senha = "94570495";

            var fakeRepo = new Mock<IUsuarioRepository>();

            fakeRepo.Setup(x => x.Login(It.IsAny<string>(), It.IsAny<string>())).Returns((fakeUsuario));

            var fakeViewModel = new LoginViewModel();
            fakeViewModel.Email = "samuel.email.com";
            fakeViewModel.Senha = "xoudaxuxaparabaixinhos";

            var controller = new LoginController(fakeRepo.Object);

            // Procedimento / Act
            var resultado = controller.Login(fakeViewModel);

            // Resultado esperado / Assert
            Assert.IsType<OkObjectResult>(resultado);
        }
    }
}
