﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    class AlarmClock
    {
                                  //fields
        private int _alarmHour;
        private int _alarmMinute;
        private int _hour;
        private int _minute;
        
      

        // egenskaper/propeties för att skydda mina variabler.

        // beräkning hur min klocka ska fungera
        public int AlarmHour 
        {
            get { return _alarmHour; }

            set
            {
                if (value < 0 || value > 23) // om timmar är mindre än 0 och störe än 23 så får man fel meddelande
                {
                    throw new ArgumentException();
                }

                _alarmHour = value;
            }

        }


        public int AlarmMinute
        {
            get { return _alarmMinute; }

            set
            {
                if (value < 0 || value > 59) // om minnuter är mindre än 0 och större än 59 så får vi fel meddelande
                {
                    throw new ArgumentException( );
                }

                _alarmMinute = value;
            }
        }
        public int Hour
        {
            get { return _hour; }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException();
                }
                _hour = value;
            }
        }
        public int Minute
        {
            get { return _minute; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException();
                }
                _minute = value;
            }
        }




        public AlarmClock()
            : this(0, 0)
        {

        }
        public AlarmClock(int hour, int minute) : this (hour,minute, 0, 0)
        {
           
            // den ska anropa den konstruktor i klassen som har två paramentrar
        }
        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {

            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;


        }

       

      
        public bool TicTock() // regler till klockan 
        {
            if (Minute == 59 && Hour == 23) 
            {
                Minute = 0;
                Hour = 0;
            }

            if (Minute == 59) 
            {
                Minute = 0;
                Hour++;
            }

            Minute++;


            if (Hour == AlarmHour && Minute == AlarmMinute)
            {
                return true;
            }

            else
            {
                return false;
            }


        }
        public override string ToString() // den returnera  och visar en instans iklassen AlarmClok
        {
            StringBuilder displayClock = new StringBuilder();
            displayClock.AppendFormat("{0,3}:", _hour);

            if (_minute < 10)
            {
                displayClock.AppendFormat("0{0}", _minute);
            }
            else
            {
                displayClock.AppendFormat("{0}", _minute);
            }
            displayClock.AppendFormat(" <{0}:", _alarmHour);

            if (_alarmMinute < 10)
            {
                displayClock.AppendFormat("0{0}>", _alarmMinute);
            }
            else
            {
                displayClock.AppendFormat("{0}>", _alarmMinute);  
            }
               return displayClock.ToString();
           }

        public int minute { get; set; }
    }
}
