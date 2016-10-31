using System;
using System.Diagnostics;
using System.Collections;

namespace WorkTime
{
    class LogHandler
    {
        private ArrayList valideLogs { get; set; }

        public LogHandler(){
            valideLogs = new ArrayList();
            valideLogs = getLogs();
        }

        private ArrayList getLogs()
        {
            string protokolName = "System";
            
            // -- Zugriff auf das Ereignisprotokoll
            EventLog protokol = new EventLog(protokolName);

            // Schleife über alle Einträge
            foreach (EventLogEntry entry in protokol.Entries)
            {
                    if (isTodayAndRightId(entry))
                    {
                        valideLogs.Add(entry);
                    }                
            }
            return valideLogs;
        }

        public EventLogEntry getFirstTodayEntry() {
            if(valideLogs != null && valideLogs.Count > 0){
            EventLogEntry tmpEntry = (EventLogEntry)valideLogs[0];
            foreach(EventLogEntry entry in valideLogs){
                if(entry.TimeWritten.TimeOfDay < tmpEntry.TimeWritten.TimeOfDay){
                    tmpEntry = entry;
                }
            }
            return tmpEntry;
            }
            return null;
        }

        private bool isTodayAndRightId(EventLogEntry logEntry) {
            // search another id
            // TODO Problem with speed start on windows, wenn this on is, then no logging
            if(istToday(logEntry) && logEntry.EventID == 100 ){
                return true;
            }
            return false;
        }

        private Boolean istToday(EventLogEntry logEntry) {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            
            if(dt.DayOfYear == logEntry.TimeWritten.DayOfYear){
                return true;
            }
            return false;
        }
    }
}
