using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleRESTAPIApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
        private double _valueOne;
        private double _valueTwo;

        public CalculateController(double valueOne, double valueTwo)
        {
            this._valueOne = valueOne;
            this._valueTwo = valueTwo;
        }
        // GET: api/<CalculateController>
        [HttpGet]
        public ActionResult<double> GetSum()
        {
            var opration = new Opration(_valueOne, _valueTwo).Sum();
            return opration;
        }
        [HttpGet]
        public ActionResult<double> GetSubtract()
        {
            var opration = new Opration(_valueOne, _valueTwo).Subtract();
            return opration;
        }
        [HttpGet]
        public ActionResult<double> GetMultiply()
        {
            var opration = new Opration(_valueOne, _valueTwo).Multiply();
            return opration;
        }
        [HttpGet]
        public ActionResult<double> GetDivide()
        {
            var opration = new Opration(_valueOne, _valueTwo).Divide();
            return opration;
        }
    }
}
