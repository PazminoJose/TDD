using NUnit.Framework;
using Ejemplo1;
namespace Ejemplo.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
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