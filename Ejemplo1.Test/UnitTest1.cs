using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejemplo1;
namespace Ejemplo1.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RaizCuadrada_4()
        {
            //Arrange: Crear el entorno de Trabajo
            RaizCuadrada service = new RaizCuadrada();

            //Act: Operacion
            double result = service.CalcularRaizCuadrada(4);

            //Asset: Verificar la condicion o el criterio de aceptacion de la prueba
            Assert.AreEqual(2, result);
        }
    }
}
