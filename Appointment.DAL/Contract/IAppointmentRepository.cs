using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment.DAL.Contract
{
    interface IAppointmentRepository
    {
        void Add(Appointment appointment);
        List<Appointment> GetByName(string search);
        int AppointmentCount(int day);
        List<Appointment> GetAll();
        Appointment Get(string name);
    }
}
