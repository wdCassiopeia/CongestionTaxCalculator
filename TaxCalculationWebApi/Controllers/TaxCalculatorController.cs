using Microsoft.AspNetCore.Mvc;
using congestion.calculator;
using congestion.calculator.Vehicles;

namespace TaxCalculationWebApi.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class TaxCalculatorController : ControllerBase
    {

        [HttpPost("taxAmountForVehicle")]
        public int TaxAmountForVehicle(VehicleDataDto vehicleData)
        {
            if (vehicleData.vehicleType == "Car") {
                return CongestionTaxCalculator.GetTax(new Car(), vehicleData.dateTimes);

            } else if (vehicleData.vehicleType == "Motorbike" ) {
                return CongestionTaxCalculator.GetTax(new Motorbike(), vehicleData.dateTimes);
                

            } else if (vehicleData.vehicleType == "Bus") {
                return CongestionTaxCalculator.GetTax(new Bus(), vehicleData.dateTimes);

            } else {
                throw new System.Exception("Not a valid vehicle!");
            }
        }
    }
