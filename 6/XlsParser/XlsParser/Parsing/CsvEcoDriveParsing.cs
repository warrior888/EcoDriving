using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel;
using XlsParser.Model;

namespace XlsParser.Parsing
{
    public class CsvEcoDriveParsing : DataMaperBase<Dictionary<string, ModelBase>, ExcelQueryFactory, ExcelQueryFactory>
    {
        private readonly string timeOfFrame = "Czas ramki (g:m:s:ms),\"AUX.ACCEL.FORWARD\",\"AUX.ACCEL.FORWARD\",\"AUX.ACCEL.LATERAL\",\"AUX.ACCEL.LATERAL\",\"AUX.ROTATION.ROLL\",\"AUX.ROTATION.ROLL\",\"AUX.ROTATION.PITCH\",\"AUX.ROTATION.PITCH\",\"SAE.MAP\",\"SAE.MAP\",\"SAE.MAP\",\"SAE.RPM\",\"SAE.RPM\",\"SAE.VSS\",\"SAE.VSS\",\"SAE.VSS\",\"SAE.LOAD_ABS\",\"SAE.LOAD_ABS\",\"CONST.MAP_PID\",\"CONST.MAP_PID\",\"CONST.ENGINE_DISPLACEMENT\",\"CONST.ENGINE_DISPLACEMENT\",\"CONST.ENGINE_DISPLACEMENT\",\"CONST.FUEL_DENSITY\",\"CONST.FUEL_DENSITY\",\"CONST.FUEL_DENSITY\",\"CONST.SHIFT_RPM\",\"CONST.SHIFT_RPM\",\"CONST.SHIFT_RPM\",\"CONST.MIN_RPM\",\"CONST.MIN_RPM\",\"CONST.MIN_RPM\",\"CONST.FINAL_DRIVE_RATIOS\",\"CONST.FINAL_DRIVE_RATIOS\",\"CONST.WHEEL_CIRCUMFERENCE\",\"CONST.WHEEL_CIRCUMFERENCE\",\"CONST.WHEEL_CIRCUMFERENCE\",\"CONST.SPEED_CORRECTION\",\"CONST.SPEED_CORRECTION\",\"CONST.SPEED_CORRECTION\",\"CALC.TRIP\",\"CALC.TRIP\",\"CALC.FUEL_CONSUMPTION\",\"CALC.FUEL_CONSUMPTION\",\"CONST.STOICHIOMETRIC_AIR_FUEL_RATIO\",\"CONST.STOICHIOMETRIC_AIR_FUEL_RATIO\",\"CONST.FUEL_TANK_CAPACITY\",\"CONST.FUEL_TANK_CAPACITY\",\"CONST.FUEL_TANK_CAPACITY\",\"CONST.LAMBDA_ACTUAL_PID\",\"CONST.LAMBDA_ACTUAL_PID\",\"CONST.MAF_PID\",\"CONST.MAF_PID\",\"CONST.FUEL_CO2_CONTENT\",\"CONST.FUEL_CO2_CONTENT\",\"CONST.FUEL_CO2_CONTENT\",\"CONST.MAX_RPM\",\"CONST.MAX_RPM\",\"CONST.MAX_RPM\",\"CALC.MAF_A\",\"CALC.MAF_A\",\"CALC.MAF_A\",\"CALC.IS_NEW_DAY\",\"CALC.IS_NEW_DAY\",\"CONST.SPEED_ZONES\",\"CONST.SPEED_ZONES\",\"CONST.SPEED_ZONES\",\"CALC.MAF\",\"CALC.MAF\",\"CALC.MAF\",\"CALC.LAMBDA_ACTUAL\",\"CALC.LAMBDA_ACTUAL\",\"CALC.VSS_C\",\"CALC.VSS_C\",\"CALC.VSS_C\",\"CALC.FUEL_FLOW\",\"CALC.FUEL_FLOW\",\"CALC.FUEL_FLOW\",\"CALC.MAP\",\"CALC.MAP\",\"CALC.MAP\",\"CALC.FC.AFC\",\"CALC.FC.AFC\",\"CALC.FC.AFC\",\"CALC.TRIP.DISTANCE\",\"CALC.TRIP.DISTANCE\",\"CALC.TRIP.DISTANCE\",\"CALC.GEAR\",\"CALC.GEAR\",\"CALC.GEAR\",\"CALC.TRIP.TIME\",\"CALC.TRIP.TIME\",\"CALC.TRIP.TIME\",\"CALC.TRIP.STOPS\",\"CALC.TRIP.STOPS\",\"CALC.TRIP.FUEL_USED\",\"CALC.TRIP.FUEL_USED\",\"CALC.TRIP.FUEL_USED\",\"CALC.TRIP.FILLUPS\",\"CALC.TRIP.FILLUPS\",\"CALC.TRIP.FUEL_FLOW\",\"CALC.TRIP.FUEL_FLOW\",\"CALC.TRIP.FUEL_FLOW\",\"CALC.TRIP.SPEED\",\"CALC.TRIP.SPEED\",\"CALC.TRIP.SPEED\",\"CALC.TRIP.BOOST\",\"CALC.TRIP.BOOST\",\"CALC.TRIP.BOOST\",\"CALC.TRIP.RPM\",\"CALC.TRIP.RPM\",\"CALC.TRIP.RPM\",\"CALC.DISTANCE\",\"CALC.DISTANCE\",\"CALC.DISTANCE\",\"CALC.FC.FUEL_VOLUME\",\"CALC.FC.FUEL_VOLUME\",\"CALC.FC.FUEL_VOLUME\",\"CALC.FC.IFC\",\"CALC.FC.IFC\",\"CALC.FC.IFC\",\"CALC.FUEL_FLOW_AVG\",\"CALC.FUEL_FLOW_AVG\",\"CALC.FUEL_FLOW_AVG\",\"CALC.BOOST_PRESSURE\",\"CALC.BOOST_PRESSURE\",\"CALC.BOOST_PRESSURE\",\"CALC.ACCELERATION\",\"CALC.ACCELERATION\",\"CALC.ACCELERATION\",\"CALC.FC.IFC_AVG\",\"CALC.FC.IFC_AVG\",\"CALC.FC.IFC_AVG\",\"CALC.TRIP.GEAR\",\"CALC.TRIP.GEAR\",\"CONST.SPEED_ZONES.2.MIN_SPEED\",\"CONST.SPEED_ZONES.2.MIN_SPEED\",\"CONST.SPEED_ZONES.2.MIN_SPEED\",\"CONST.SPEED_ZONES.1.MAX_SPEED\",\"CONST.SPEED_ZONES.1.MAX_SPEED\",\"CONST.SPEED_ZONES.1.MAX_SPEED\",\"CALC.GEAR.NUM_GEARS\",\"CALC.GEAR.NUM_GEARS\",\"CALC.TRIP.DISTANCE.A\",\"CALC.TRIP.DISTANCE.A\",\"CALC.TRIP.DISTANCE.A\",\"CALC.TRIP.CO2\",\"CALC.TRIP.CO2\",\"CALC.ACCELERATION_G\",\"CALC.ACCELERATION_G\",\"CALC.TRIP.TIME.START.A\",\"CALC.TRIP.TIME.START.A\",\"CALC.TRIP.TIME.START.A\",\"CALC.TRIP.TIME.RUN.A\",\"CALC.TRIP.TIME.RUN.A\",\"CALC.TRIP.TIME.RUN.A\",\"CALC.TRIP.TIME.DRIVE.A\",\"CALC.TRIP.TIME.DRIVE.A\",\"CALC.TRIP.TIME.DRIVE.A\",\"CALC.GEAR.CURRENT\",\"CALC.GEAR.CURRENT\",\"CALC.FC.AVERAGE\",\"CALC.FC.AVERAGE\",\"CALC.FC.AVERAGE\",\"CALC.TRIP.AFC\",\"CALC.TRIP.AFC\",\"CALC.TRIP.AFC\",\"CALC.ENGINE_POWER\",\"CALC.ENGINE_POWER\",\"CALC.ENGINE_POWER\",\"CONST.SPEED_ZONES.5.SHIFT_SPEED\",\"CONST.SPEED_ZONES.5.SHIFT_SPEED\",\"CONST.SPEED_ZONES.5.SHIFT_SPEED\",\"CALC.FILLUP\",\"CALC.FILLUP\",\"CONST.SPEED_ZONES.4.SHIFT_SPEED\",\"CONST.SPEED_ZONES.4.SHIFT_SPEED\",\"CONST.SPEED_ZONES.4.SHIFT_SPEED\",\"CONST.SPEED_ZONES.3.SHIFT_SPEED\",\"CONST.SPEED_ZONES.3.SHIFT_SPEED\",\"CONST.SPEED_ZONES.3.SHIFT_SPEED\",\"CALC.TRIP.POWER\",\"CALC.TRIP.POWER\",\"CALC.TRIP.POWER\",\"CALC.ENGINE_TORQUE\",\"CALC.ENGINE_TORQUE\",\"CALC.ENGINE_TORQUE\",\"CALC.TRIP.GEAR.N.DISTANCE_PCT.A\",\"CALC.TRIP.GEAR.N.DISTANCE_PCT.A\",\"CALC.TRIP.GEAR.WG.DISTANCE_PCT.A\",\"CALC.TRIP.GEAR.WG.DISTANCE_PCT.A\",\"CALC.FILLUP.CORRECTION\",\"CALC.FILLUP.CORRECTION\",\"CALC.FILLUP.CORRECTION\",\"CALC.FILLUP.FUEL_PRICE\",\"CALC.FILLUP.FUEL_PRICE\",\"CALC.FILLUP.FUEL_PRICE\",\"CALC.TRIP.STOPS.A\",\"CALC.TRIP.STOPS.A\",\"CALC.TRIP.ACCEL\",\"CALC.TRIP.ACCEL\",\"CALC.TRIP.FUEL_COST\",\"CALC.TRIP.FUEL_COST\",\"CALC.TRIP.TORQUE\",\"CALC.TRIP.TORQUE\",\"CALC.TRIP.TORQUE\",\"AUX.GPS.LATITUDE\",\"AUX.GPS.LATITUDE\",\"AUX.GPS.LONGITUDE\",\"AUX.GPS.LONGITUDE\",\"AUX.GPS.ALTITUDE\",\"AUX.GPS.ALTITUDE\",\"AUX.GPS.ALTITUDE\",\"AUX.GPS.HORZ_ACCURACY\",\"AUX.GPS.HORZ_ACCURACY\",\"AUX.GPS.HORZ_ACCURACY\",\"AUX.GPS.VERT_ACCURACY\",\"AUX.GPS.VERT_ACCURACY\",\"AUX.GPS.VERT_ACCURACY\",\"AUX.GPS.COURSE\",\"AUX.GPS.COURSE\",\"AUX.GPS.SPEED\",\"AUX.GPS.SPEED\",\"AUX.GPS.SPEED\",";
        private readonly string auxAccelForward = "\"AUX.ACCEL.FORWARD\"";
        private readonly string auxAccelLateral = "\"AUX.ACCEL.LATERAL\"";
        private readonly string auxRotationRoll = "\"AUX.ROTATION.ROLL\"";

        private readonly string workSheet = "przejazd_29#04";
        public override Dictionary<string, ModelBase> getModelData(ExcelQueryFactory queryFactory)
        {
            queryFactory.AddMapping<EcoDrive>(ecoDrive => ecoDrive.timeOfFrame, timeOfFrame);
            //queryFactory.AddMapping<EcoDrive>(ecoDrive => ecoDrive.auxAccelForward, auxAccelForward);
            //queryFactory.AddMapping<EcoDrive>(ecoDrive => ecoDrive.auxAccelLateral, auxAccelLateral);
            //queryFactory.AddMapping<EcoDrive>(ecoDrive => ecoDrive.auxRotationRoll, auxRotationRoll);

            var drive = queryFactory.Worksheet<EcoDrive>(workSheet).Select(x => (ModelBase) x);
            var resoult = new Dictionary<string, ModelBase>();

            int i = 1;
            foreach (EcoDrive item in drive)
            {
                if (item.timeOfFrame == null)
                {
                    resoult.Add(string.Format("{0}{1}", item.timeOfFrame, i++), item);
                    continue;
                }

                resoult.Add(item.timeOfFrame, item);


            }

            return resoult;
            //return drive.ToDictionary(item => ((EcoDrive)item).timeOfFrame == null ? "" : ((EcoDrive)item).timeOfFrame.ToString());

            //var people = queryFactory.Worksheet<Person>(workSheet).Select(x => (ModelBase) x);

            //return people.ToDictionary(item => ((Person)item).userId.ToString());
        }

        public override Dictionary<string, ModelBase> getAdequateParser(ExcelQueryFactory queryFactory)
        {
            throw new NotImplementedException();
        }
    }
}
