using System;
using System.Windows;
using DevExpress.Xpf.Scheduler;
using DevExpress.XtraScheduler;

namespace SchedulerCompleteAppointmentStyleWpf {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            SchedulerStorage schedulerStorage = schedulerControl1.Storage;
            Appointment apt = schedulerStorage.CreateAppointment(AppointmentType.Normal);
            DateTime baseTime = DateTime.Today;

            apt.Start = baseTime.AddHours(1);
            apt.End = baseTime.AddHours(2);
            apt.Subject = "Test";
            apt.Location = "Office";
            apt.Description = "Test procedure";

            schedulerStorage.AppointmentStorage.Add(apt);

            schedulerControl1.Start = baseTime.Date;
        }
    }
}