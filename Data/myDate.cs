using System;

namespace blazorHramBabynino.Data
{
    public static class myDate
    {
        public static DateTime ToRusDate(this DateTime date)
        {
            return date.ToLocalTime();
        }
    }
}
