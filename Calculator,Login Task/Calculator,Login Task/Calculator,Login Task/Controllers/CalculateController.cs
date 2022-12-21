using ServiceLayer.Services.Interfaces;
using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Login_Task.Controllers
{
    public class CalculateController
    {


        public void Calculate() 
        {
            ICalculationService service = new CalculationService();

            var result = service.Calculate(5, 7, "*");

            Console.WriteLine(result);


        }

    }
}
