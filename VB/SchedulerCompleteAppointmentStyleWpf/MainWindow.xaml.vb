Imports System
Imports System.Windows
Imports DevExpress.Xpf.Scheduler
Imports DevExpress.XtraScheduler

Namespace SchedulerCompleteAppointmentStyleWpf
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()

            Dim schedulerStorage As SchedulerStorage = schedulerControl1.Storage
            Dim apt As Appointment = schedulerStorage.CreateAppointment(AppointmentType.Normal)
            Dim baseTime As Date = Date.Today

            apt.Start = baseTime.AddHours(1)
            apt.End = baseTime.AddHours(2)
            apt.Subject = "Test"
            apt.Location = "Office"
            apt.Description = "Test procedure"

            schedulerStorage.AppointmentStorage.Add(apt)

            schedulerControl1.Start = baseTime.Date
        End Sub
    End Class
End Namespace