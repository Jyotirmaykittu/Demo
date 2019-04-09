using APITddDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using APITddDemo.Controllers;

namespace UnitTestProjectEmp
{
    [TestClass]
    public class UnitTest1
    {
        private readonly DbContextOptions<EmployeeContext> _options;
        private readonly IConfigurationRoot _configuration;
        public UnitTest1()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            _configuration = builder.Build();
            _options = new DbContextOptionsBuilder<EmployeeContext>()
                .UseSqlServer(_configuration.GetConnectionString("myconn")).Options;
        }

        [TestMethod]
        public void TestMethod_GetAll()
        {
            var manager = new ValuesController(_options);           
            var result = manager.Get();
            //Assert.AreEqual(1, result);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestMethod_GetById()
        {
            var manager = new ValuesController(_options);
            int emp = 1;
            var result = manager.Get(emp);
            Assert.AreEqual(1, result);
        }
    }
}
