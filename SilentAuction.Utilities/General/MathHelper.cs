using System;

namespace SilentAuction.Utilities.General
{
    public class MathHelper
    {
        public static int ParseIntZeroIfNull(string val)
        {
            int retVal;
            try
            {
                retVal = Int32.Parse(val);
            }
            catch (Exception)
            {
                retVal = 0;
            }

            return retVal;
        }

        public static Double ParseDoubleZeroIfNull(string val)
        {
            Double retVal;
            try
            {
                retVal = Double.Parse(val);
            }
            catch (Exception)
            {
                retVal = 0.0;
            }

            return retVal;
        }

        public static Decimal ParseDecimalZeroIfNull(string val)
        {
            Decimal retVal;
            try
            {
                retVal = Decimal.Parse(val);
            }
            catch (Exception)
            {
                retVal = 0.0m;
            }

            return retVal;
        }
    }
}
