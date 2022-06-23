using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDrone.Operational
{
    public class ConversionUnit
    {
        public DataTable dataAreaRai;
        public DataTable dataDistanceMeter;
        public DataTable dataValumeL;
        public DataTable dataSpeedKm;
        public ConversionUnit()
        {
            dataAreaRai = new DataTable();
            dataAreaRai.Columns.Add("unitDisplay");
            dataAreaRai.Columns.Add("unitArea");
            dataAreaRai.Columns.Add("unitValue");
            dataAreaRai.Rows.Add("Sq.Wa.","SQ.WAH", "400");
            dataAreaRai.Rows.Add("Sq.Ft.", "SQ.FT", "17222");
            dataAreaRai.Rows.Add("Sq.m.", "SQ.M", "1600");
            dataAreaRai.Rows.Add("Ngan.", "NGAN", "4");
            dataAreaRai.Rows.Add("Rai", "RAI", "1");
            dataAreaRai.Rows.Add("Acre.", "ACRE", "0.40");
            dataAreaRai.Rows.Add("Hectare.", "HECTARE", "0.16");
            dataAreaRai.AcceptChanges();

            dataDistanceMeter = new DataTable();
            dataDistanceMeter.Columns.Add("unitDisplay");
            dataDistanceMeter.Columns.Add("unitDistance");
            dataDistanceMeter.Columns.Add("unitValue");
            dataDistanceMeter.Rows.Add("mile","mi", "0.00062137");
            dataDistanceMeter.Rows.Add("kilometre", "km", "0.001");
            dataDistanceMeter.Rows.Add("foot", "ft", "3.2808");
            dataDistanceMeter.Rows.Add("inch", "in", "39.3701");
            dataDistanceMeter.Rows.Add("millimetres", "mm", "1000");
            dataDistanceMeter.Rows.Add("metre", "m", "1");
            dataDistanceMeter.Rows.Add("wa.", "wa", "0.5");
            dataDistanceMeter.AcceptChanges();

            dataValumeL = new DataTable();
            dataValumeL.Columns.Add("unitDisplay");
            dataValumeL.Columns.Add("unitVolume");
            dataValumeL.Columns.Add("unitValue");
            dataValumeL.Rows.Add("Litre","L", "1");
            dataValumeL.Rows.Add("Millilitres", "mL", "1000");
            dataValumeL.Rows.Add("Cubic Inches", "in3", "61.024");
            dataValumeL.Rows.Add("Cubic Metres", "m3", "0.001");
            dataValumeL.Rows.Add("Imperial Fluid Ounces", "fl oz", "1");
            dataValumeL.Rows.Add("Imperial Cups", "cup", "3.52");
            dataValumeL.Rows.Add("Cubic Centimetres", "cm3", "1000");
            dataValumeL.AcceptChanges();

            dataSpeedKm = new DataTable();
            dataSpeedKm.Columns.Add("unitDisplay");
            dataSpeedKm.Columns.Add("unitSpeed");
            dataSpeedKm.Columns.Add("unitValue");
            dataSpeedKm.Rows.Add("kilometre per hour", "km/h", "1");
            dataSpeedKm.Rows.Add("mile per hour", "mph", "0.621371");
            dataSpeedKm.Rows.Add("Knots", "knot", "0.539957");
            dataSpeedKm.Rows.Add("metre per sec.", "m/s", "0.277778");
            dataSpeedKm.AcceptChanges();

        }
        public double ConvertArea(string sourceUnit, double sourceValue, string distinationUnit)
        {
            double _result = 0;
            double _sourceValue = Convert.ToDouble(dataAreaRai.Select("unitArea = '" + sourceUnit + "'")[0]["unitValue"]);
            double _distinationValue = Convert.ToDouble(dataAreaRai.Select("unitArea = '" + distinationUnit + "'")[0]["unitValue"]);

            _result = (sourceValue / _sourceValue) * _distinationValue;

            return _result;
        }
        public double ConvertDistance(string sourceUnit, double sourceValue, string distinationUnit)
        {
            double _result = 0;
            double _sourceValue = Convert.ToDouble(dataDistanceMeter.Select("unitDistance = '" + sourceUnit + "'")[0]["unitValue"]);
            double _distinationValue = Convert.ToDouble(dataDistanceMeter.Select("unitDistance = '" + distinationUnit + "'")[0]["unitValue"]);

            _result = (sourceValue / _sourceValue) * _distinationValue;

            return _result;
        }
        public double ConvertValume(string sourceUnit, double sourceValue, string distinationUnit)
        {
            double _result = 0;
            double _sourceValue = Convert.ToDouble(dataValumeL.Select("unitVolume = '" + sourceUnit + "'")[0]["unitValue"]);
            double _distinationValue = Convert.ToDouble(dataValumeL.Select("unitVolume = '" + distinationUnit + "'")[0]["unitValue"]);

            _result = (sourceValue / _sourceValue) * _distinationValue;

            return _result;
        }
        public double ConvertSpeed(string sourceUnit, double sourceValue, string distinationUnit)
        {
            double _result = 0;
            double _sourceValue = Convert.ToDouble(dataSpeedKm.Select("unitSpeed = '" + sourceUnit + "'")[0]["unitValue"]);
            double _distinationValue = Convert.ToDouble(dataSpeedKm.Select("unitSpeed = '" + distinationUnit + "'")[0]["unitValue"]);

            _result = (sourceValue / _sourceValue) * _distinationValue;

            return _result;
        }
    }
}
