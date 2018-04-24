using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OpenQA.Selenium.Chrome;
using System.Reflection;

namespace SeleniumParcialTres
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
            {
                driver.Navigate().GoToUrl("http://intranet.aiep.cl/");

                var texto = driver.FindElementById("ContentPlaceUsuario_T6DE087CD028_TXTUsuario");
                var contra = driver.FindElementById("ContentPlaceUsuario_T6DE087CD028_TXTPassword");


                texto.SendKeys("Exequiel.Alvarez");
                contra.SendKeys("258456167349pas");
                driver.FindElementById("ContentPlaceUsuario_T6DE087CD028_BNTIngresar").Click();

            }
        }
            public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
