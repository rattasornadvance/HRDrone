using HRDrone.Entity;
using HRDrone.Entity.Response;
using HRDrone.Operational;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRDroneAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitConvertController : ControllerBase
    {
        [HttpGet]
        [Route("GetVersion")]
        public string GetVersion()
        {
            return "1.0.0.1";
        }
        [HttpGet]
        [Route("GetUnitArea")]
        public List<UnitConvertArea> GetUnitArea()
        {
            List<UnitConvertArea> list = new List<UnitConvertArea>();

            ConversionUnit _u = new ConversionUnit();
            foreach (DataRow item in _u.dataAreaRai.Rows)
            {
                UnitConvertArea _data = new UnitConvertArea
                {
                    unitDisplay = item["unitDisplay"].ToString(),
                    unitArea = item["unitArea"].ToString(),
                    unitValue = Convert.ToDouble(item["unitValue"]),
                };

                list.Add(_data);
            }
            return list;
        }
        [HttpGet]
        [Route("GetUnitDistance")]
        public List<UnitConvertDistance> GetUnitDistance()
        {
            List<UnitConvertDistance> list = new List<UnitConvertDistance>();

            ConversionUnit _u = new ConversionUnit();
            foreach (DataRow item in _u.dataDistanceMeter.Rows)
            {
                UnitConvertDistance _data = new UnitConvertDistance
                {
                    unitDisplay = item["unitDisplay"].ToString(),
                    unitDistance = item["unitDistance"].ToString(),
                    unitValue = Convert.ToDouble(item["unitValue"]),
                };

                list.Add(_data);
            }
            return list;
        }
        [HttpGet]
        [Route("GetUnitValume")]
        public List<UnitConvertVolume> GetUnitValume()
        {
            List<UnitConvertVolume> list = new List<UnitConvertVolume>();

            ConversionUnit _u = new ConversionUnit();
            foreach (DataRow item in _u.dataValumeL.Rows)
            {
                UnitConvertVolume _data = new UnitConvertVolume
                {
                    unitDisplay = item["unitDisplay"].ToString(),
                    unitVolume = item["unitVolume"].ToString(),
                    unitValue = Convert.ToDouble(item["unitValue"]),
                };

                list.Add(_data);
            }
            return list;
        }
        [HttpGet]
        [Route("GetUnitSpeed")]
        public List<UnitConvertSpeed> GetUnitSpeed()
        {
            List<UnitConvertSpeed> list = new List<UnitConvertSpeed>();

            ConversionUnit _u = new ConversionUnit();
            foreach (DataRow item in _u.dataSpeedKm.Rows)
            {
                UnitConvertSpeed _data = new UnitConvertSpeed
                {
                    unitDisplay = item["unitDisplay"].ToString(),
                    unitSpeed = item["unitSpeed"].ToString(),
                    unitValue = Convert.ToDouble(item["unitValue"]),
                };

                list.Add(_data);
            }
            return list;
        }
        [HttpPost]
        [Route("ConvertArea")]
        public ResponseUnitConversion ConvertArea([FromBody] dynamic para)
        {
            var requestValue = JsonConvert.DeserializeObject<object>(para.ToString());
            if (string.IsNullOrEmpty(requestValue.unitArea.Value.ToString()))
            {
                return new ResponseUnitConversion()
                {
                    code = 500,
                    message = "Area is Empty",
                    resultJson = 0,
                };
            }

            ConversionUnit _conversion = new ConversionUnit();
            double _result = _conversion.ConvertArea(
                requestValue.unitArea.Value.ToString()
                , Convert.ToDouble(requestValue.unitValue)
                , requestValue.unitAreaConvert.Value.ToString()
                );
            return new ResponseUnitConversion()
            {
                code = 200,
                message = "Success",
                resultJson = _result,
            };
        }
        [HttpPost]
        [Route("ConvertAreaResult")]
        public ResponseUnitConversion ConvertAreaResult([FromBody] UnitConvertArea para)
        {
            //UnitConvertArea requestValue = JsonConvert.DeserializeObject<UnitConvertArea>(para.ToString());
            UnitConvertArea requestValue = para;
            if (string.IsNullOrEmpty(requestValue.unitArea))
            {
                return new ResponseUnitConversion()
                {
                    code = 500,
                    message = "Area is Empty",
                    resultJson = null,
                };
            }

            ConversionUnit _conversion = new ConversionUnit();

            UnitConvertAreaValue _data = new UnitConvertAreaValue();

            _data.unitAcre = _conversion.ConvertArea(requestValue.unitArea, requestValue.unitValue, "ACRE");
            _data.unitM2 = _conversion.ConvertArea(requestValue.unitArea, requestValue.unitValue, "SQ.M");
            _data.unitRai = _conversion.ConvertArea(requestValue.unitArea, requestValue.unitValue, "RAI");

            if (_data == null)
            {
                return new ResponseUnitConversion()
                {
                    code = 204,
                    message = "No Data",
                    resultJson = _data,
                };
            }
            else
            {
                return new ResponseUnitConversion()
                {
                    code = 200,
                    message = "Success",
                    resultJson = _data,
                };
            }
        }

        [HttpPost]
        [Route("ConvertDistance")]
        public ResponseUnitConversion ConvertDistance([FromBody] dynamic para)
        {
            var requestValue = JsonConvert.DeserializeObject<object>(para.ToString());
            if (string.IsNullOrEmpty(requestValue.unitDistance.Value.ToString()))
            {
                return new ResponseUnitConversion()
                {
                    code = 500,
                    message = "Distance is Empty",
                    resultJson = 0,
                };
            }

            ConversionUnit _conversion = new ConversionUnit();
            double _result = _conversion.ConvertDistance(
                requestValue.unitDistance.Value.ToString()
                , Convert.ToDouble(requestValue.unitValue)
                , requestValue.unitDistanceConvert.Value.ToString()
                );

            return new ResponseUnitConversion()
            {
                code = 200,
                message = "Success",
                resultJson = _result,
            };
        }
        [HttpPost]
        [Route("ConvertDistanceResult")]
        public ResponseUnitConversion ConvertDistanceResult([FromBody] UnitConvertDistance para)
        {
            //UnitConvertDistance requestValue = JsonConvert.DeserializeObject<UnitConvertDistance>(para.ToString());
            UnitConvertDistance requestValue = para;
            if (string.IsNullOrEmpty(requestValue.unitDistance))
            {
                return new ResponseUnitConversion()
                {
                    code = 500,
                    message = "Distance Unit is Empty",
                    resultJson = null,
                };
            }
            ConversionUnit _conversion = new ConversionUnit();
            UnitConvertDistanceValue _data = new UnitConvertDistanceValue();

            _data.unitMile = _conversion.ConvertDistance(requestValue.unitDistance, requestValue.unitValue, "mi");
            _data.unitMetre = _conversion.ConvertDistance(requestValue.unitDistance, requestValue.unitValue, "m");
            _data.unitWa = _conversion.ConvertDistance(requestValue.unitDistance, requestValue.unitValue, "wa");

            if (_data == null)
            {
                return new ResponseUnitConversion()
                {
                    code = 204,
                    message = "No Data",
                    resultJson = _data,
                };
            }
            else
            {
                return new ResponseUnitConversion()
                {
                    code = 200,
                    message = "Success",
                    resultJson = _data,
                };
            }
        }

        [HttpPost]
        [Route("ConvertVolume")]
        public ResponseUnitConversion ConvertVolume([FromBody] dynamic para)
        {
            var requestValue = JsonConvert.DeserializeObject<object>(para.ToString());
            if (string.IsNullOrEmpty(requestValue.unitVolume.Value.ToString()))
            {
                return new ResponseUnitConversion()
                {
                    code = 500,
                    message = "Volume is Empty",
                    resultJson = 0,
                };
            }

            ConversionUnit _conversion = new ConversionUnit();
            double _result = _conversion.ConvertValume(
                requestValue.unitVolume.Value.ToString()
                , Convert.ToDouble(requestValue.unitValue)
                , requestValue.unitVolumeConvert.Value.ToString()
                );

            return new ResponseUnitConversion()
            {
                code = 200,
                message = "Success",
                resultJson = _result,
            };
        }
        [HttpPost]
        [Route("ConvertVolumeResult")]
        public ResponseUnitConversion ConvertVolumeResult([FromBody] UnitConvertVolume para)
        {
            //UnitConvertDistance requestValue = JsonConvert.DeserializeObject<UnitConvertDistance>(para.ToString());
            UnitConvertVolume requestValue = para;
            if (string.IsNullOrEmpty(requestValue.unitVolume))
            {
                return new ResponseUnitConversion()
                {
                    code = 500,
                    message = "Volume Unit is Empty",
                    resultJson = null,
                };
            }
            ConversionUnit _conversion = new ConversionUnit();
            UnitConvertVolumeValue _data = new UnitConvertVolumeValue();

            _data.unitML = _conversion.ConvertValume(requestValue.unitVolume, requestValue.unitValue, "mL");
            _data.unitCm3 = _conversion.ConvertValume(requestValue.unitVolume, requestValue.unitValue, "cm3");
            _data.unitFlOz = _conversion.ConvertValume(requestValue.unitVolume, requestValue.unitValue, "fl oz");

            if (_data == null)
            {
                return new ResponseUnitConversion()
                {
                    code = 204,
                    message = "No Data",
                    resultJson = _data,
                };
            }
            else
            {
                return new ResponseUnitConversion()
                {
                    code = 200,
                    message = "Success",
                    resultJson = _data,
                };
            }
        }

        [HttpPost]
        [Route("ConvertSpeed")]
        public ResponseUnitConversion ConvertSpeed([FromBody] dynamic para)
        {
            var requestValue = JsonConvert.DeserializeObject<object>(para.ToString());
            if (string.IsNullOrEmpty(requestValue.unitSpeed.Value.ToString()))
            {
                return new ResponseUnitConversion()
                {
                    code = 500,
                    message = "Speed is Empty",
                    resultJson = 0,
                };
            }

            ConversionUnit _conversion = new ConversionUnit();
            double _result = _conversion.ConvertSpeed(
                requestValue.unitSpeed.Value.ToString()
                , Convert.ToDouble(requestValue.unitValue)
                , requestValue.unitSpeedConvert.Value.ToString()
                );

            return new ResponseUnitConversion()
            {
                code = 200,
                message = "Success",
                resultJson = _result,
            };
        }
        [HttpPost]
        [Route("ConvertSpeedResult")]
        public ResponseUnitConversion ConvertSpeedResult([FromBody] UnitConvertSpeed para)
        {
            //UnitConvertDistance requestValue = JsonConvert.DeserializeObject<UnitConvertDistance>(para.ToString());
            UnitConvertSpeed requestValue = para;
            if (string.IsNullOrEmpty(requestValue.unitSpeed))
            {
                return new ResponseUnitConversion()
                {
                    code = 500,
                    message = "Speed Unit is Empty",
                    resultJson = null,
                };
            }
            ConversionUnit _conversion = new ConversionUnit();
            UnitConvertSpeedValue _data = new UnitConvertSpeedValue();

            _data.unitMph = _conversion.ConvertSpeed(requestValue.unitSpeed, requestValue.unitValue, "mph");
            _data.unitMs = _conversion.ConvertSpeed(requestValue.unitSpeed, requestValue.unitValue, "m/s");
            _data.unitKmh = _conversion.ConvertSpeed(requestValue.unitSpeed, requestValue.unitValue, "km/h");

            if (_data == null)
            {
                return new ResponseUnitConversion()
                {
                    code = 204,
                    message = "No Data",
                    resultJson = _data,
                };
            }
            else
            {
                return new ResponseUnitConversion()
                {
                    code = 200,
                    message = "Success",
                    resultJson = _data,
                };
            }
        }
    }
}
