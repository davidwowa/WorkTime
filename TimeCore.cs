using System;
using System.Diagnostics;

namespace WorkTime
{
    class TimeCore
    {
        private LogHandler LogHandler;
        public int pause { get; set; }

        public TimeCore() {
            LogHandler = new LogHandler();
        }

        public String getPCStartTime() {
            EventLogEntry entry = LogHandler.getFirstTodayEntry();
            if(entry != null){
                String date = convertLongDateFormat(entry.TimeWritten);
                return date;
            }
            return "Fehler!";
        }

        public DateTime getPCStartTimeAsDateTime()
        {
            EventLogEntry entry = LogHandler.getFirstTodayEntry();
            if (entry != null)
            {
                return entry.TimeWritten;
            }
            return DateTime.MaxValue;
        }

        public String getPCWorkTime() {
            TimeSpan calculatedTime = calcualteWorkTime();
            String shortDateFormat = convertShortTimeFormat(calculatedTime);
            return shortDateFormat;
        }      

        public TimeSpan getPCWorkTimeAsTimeSpam()
        {
            TimeSpan calculatedTime = calcualteWorkTime();
            return calculatedTime;
        }

        private TimeSpan calcualteWorkTime()
        {
            EventLogEntry entry = LogHandler.getFirstTodayEntry();
            if(entry != null){
                DateTime start = entry.TimeWritten;
                DateTime now = DateTime.Now;
                TimeSpan span = now.TimeOfDay - start.TimeOfDay;               
                setPauseTime(span);
                return span;
            }
            return TimeSpan.Zero;
        }

        private void setPauseTime(TimeSpan dateTime) {
            int hours = dateTime.Hours;
            if(hours >= 8 && hours < 9){
                pause = 30;
            }else if(hours >= 9 && hours < 10){
                pause = 45;
            }else if(hours == 10){
                pause = 60;
            }else if(hours < 8){
                pause = 25;
            }
            else if (hours > 10)
            {
                pause = 0;
            }
            else {
                pause = -1;
            }
        }

        private String convertLongDateFormat(DateTime dateTime) {
            return dateTime.ToString("dddd, dd MMMM yyyy");
        }

        private String convertShortTimeFormat(TimeSpan dateTime) {
            String hours = Convert.ToString(dateTime.Hours);
            String minutes = Convert.ToString(dateTime.Minutes);
            return hours + ":" + minutes;
        }

        // Werden zz nicht gebraucht
        private DateTime windowsStartTime()
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now - new TimeSpan(0, 0, 0, 0, System.Environment.TickCount);
            return dt;
        }

        private TimeSpan workTimeFromLetsStart()
        {
            return new TimeSpan(0, 0, 0, 0, System.Environment.TickCount);
        }
    }
}
