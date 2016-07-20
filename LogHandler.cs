﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;
using System.Management;

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

        private EventLogEntry getEntry() {
            int today = new DateTime().DayOfYear;
            string query = String.Format("SELECT * FROM Win32_NTLogEvent WHERE Logfile = 'System' AND TimeWritten > '{0}'", today);

            ManagementObjectSearcher mos = new ManagementObjectSearcher(query);

            object o;
            foreach (ManagementObject mo in mos.Get())
            {
                foreach (PropertyData pd in mo.Properties)
                {
                    o = mo[pd.Name];
                    if (o != null)
                    {

                        Console.WriteLine(o.ToString());
                        //listBox1.Items.Add(String.Format("{0}: {1}", pd.Name, mo[pd.Name].ToString()));
                    }
                }
            }
            return null;
        }

        public EventLogEntry getFirstTodayEntry() {
            if(valideLogs != null && valideLogs.Count > 0){
            EventLogEntry tmpEntry = (EventLogEntry)valideLogs[0];
            foreach(EventLogEntry entry in valideLogs){
                if(entry.TimeWritten.TimeOfDay < tmpEntry.TimeWritten.TimeOfDay){
                    tmpEntry = entry;
                }
            }
            getEntry();
            return tmpEntry;
            }
            return null;
        }

        private Boolean isTodayAndRightId(EventLogEntry logEntry) {

            if(istToday(logEntry) && logEntry.EventID == 6005 ){
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
