using System;

namespace razorHramBabynino.Data
{
    public static class myDate
    {
        public static DateTime ToRusDate(this DateTime date)
        {
            return date.ToLocalTime();
        }
    }
}
