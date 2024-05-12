using Calýsan_Bodro_Web.DataAccess;

namespace TestEmployee
{
    [TestClass]
    public class EmployeeListTest
    {
        [TestMethod]
        public async Task GetAllEmployeeList()
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            try
            {

                var result = await employeeRepository.EmployeeGetAll();

                Assert.AreEqual(3, result.Count);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }


        }
    }
}