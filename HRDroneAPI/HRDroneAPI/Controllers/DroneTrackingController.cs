using HRDrone.BusinessLogic;
using HRDrone.Entity;
using HRDrone.Entity.Response;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRDroneAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DroneTrackingController : ControllerBase
    {
        [HttpGet]
        [Route("GetDroneAll")]
        public List<HrdRegistration> GetDroneAll()
        {
            HrdRegistrationComponent _reg = new HrdRegistrationComponent();
            return _reg.GetDataAll();
        }

        [HttpPost]
        [Route("InsertDroneTracking")]
        public ResponseDroneTracking InsertDroneTracking([FromBody] dynamic para)
        {
            var requestValue = JsonConvert.DeserializeObject<object>(para.ToString());
            if (string.IsNullOrEmpty(requestValue.unitArea))
            {
                return new ResponseDroneTracking()
                {
                    code = 500,
                    message = "Area is Empty",
                    resultJson = null,
                };
            }
            object _data = new object();
            if (_data == null)
            {
                return new ResponseDroneTracking()
                {
                    code = 204,
                    message = "No Data",
                    resultJson = _data,
                };
            }
            else
            {
                return new ResponseDroneTracking()
                {
                    code = 200,
                    message = "Success",
                    resultJson = _data,
                };
            }
        }
        [HttpPost]
        [Route("GetDroneTracking")]
        public ResponseDroneTracking GetDroneTracking([FromBody] dynamic para)
        {
            var requestValue = JsonConvert.DeserializeObject<object>(para.ToString());
            if (string.IsNullOrEmpty(requestValue.regId.Value.ToString()))
            {
                return new ResponseDroneTracking()
                {
                    code = 500,
                    message = "Reg is Empty",
                    resultJson = null,
                };
            }
            HrdTrackingComponent _tracking = new HrdTrackingComponent();
            HrdTracking _data = _tracking.GetDataLastestByRegId(Convert.ToInt32(requestValue.regId.Value));

            if (_data == null)
            {
                return new ResponseDroneTracking()
                {
                    code = 204,
                    message = "No Data",
                    resultJson = _data,
                };
            }
            else
            {
                return new ResponseDroneTracking()
                {
                    code = 200,
                    message = "Success",
                    resultJson = _data,
                };
            }
        }
    }
}

