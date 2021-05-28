using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment
{
    class AppointmentRepository
    {
        List<Appointment> db;
        public AppointmentRepository()
        {
            db = new List<Appointment>();
        }
        public void Add(Appointment appointment)
        {
            db.Add(appointment);
        }
        public int AppointmentCount(int day)
        {
            int counter = 0;
            for (int i = 0; i < db.Count; i++)
            {
                if (db[i].DayNumber == day)
                {
                    counter++;
                }
            }
            return counter;
        }
        public List<Appointment> GetAll()
        {
            return db;
        }
        public Appointment Get(string name)
        {
            for (int i = 0; i < db.Count; i++)
            {
                if (db[i].Name == name)
                {
                    return db[i];
                }
            }
            return null;
        }
    }
}
