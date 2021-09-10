using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentManager
{
    public partial class AppointmentManager : Form
    {
        List<Appointment> Appointments = new List<Appointment>();

        public AppointmentManager()
        {
            InitializeComponent();
            dtpAppointmentDate.MinDate = DateTime.Now;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using AppointmentContext context = new AppointmentContext();

            context.Add(new Appointment
            {
                FirstName = txtFirstName.Text, 
                LastName = txtLastName.Text, 
                HomeAddress = txtHomeAddress.Text, 
                PhoneNumber = txtPhone.Text, 
                AppointmentDate = dtpAppointmentDate.Value
            });
            context.SaveChanges();
        }
    }
}
