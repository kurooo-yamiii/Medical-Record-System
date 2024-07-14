Public Class EMPLOYEESHOW

    Private Sub EMPLOYEESHOW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Class2.Establishment
        TextBox2.Text = Class2.NameOfBusiness
        TextBox3.Text = Class2.AddressWork
        TextBox4.Text = Class2.NumOfEmploymentMale
        TextBox5.Text = Class2.NumofEmploymentFemale
        TextBox6.Text = Class2.TotalEmployees
        TextBox7.Text = Class2.Manager
        TextBox8.Text = Class2.Name
        TextBox9.Text = Class2.Age
        TextBox10.Text = Class2.Sex
        TextBox11.Text = Class2.CivilStatus
        TextBox12.Text = Class2.Address
        TextBox13.Text = Class2.Position
        TextBox14.Text = Class2.PhoneNum
        TextBox15.Text = Class2.Religion
        TextBox16.Text = Class2.Nationality
        TextBox17.Text = Class2.ExperienceOfOccupation
        TextBox18.Text = Class2.NumOfDependents
        TextBox19.Text = Class2.BirthDate
        TextBox20.Text = Class2.MonthlyWage
        TextBox21.Text = Class2.WorkshiftAM
        TextBox22.Text = Class2.WorkshiftPM
        TextBox23.Text = Class2.HoursOfWorkDay
        TextBox24.Text = Class2.Week
        TextBox25.Text = Class2.EmergencyNum
        TextBox26.Text = Class2.Relationship
        TextBox27.Text = Class2.Phone
        TextBox28.Text = Class2.Agency
        TextBox29.Text = Class2.AgencyAddress
        TextBox30.Text = Class2.ChiefComplaints
        TextBox31.Text = Class2.HealthHx
        TextBox32.Text = Class2.MedsTaken
        TextBox33.Text = Class2.Allergies
        TextBox34.Text = Class2.Medicine
        TextBox35.Text = Class2.Food
        TextBox36.Text = Class2.BP
        TextBox37.Text = Class2.RR
        TextBox38.Text = Class2.PR
        TextBox39.Text = Class2.Temperature
        TextBox40.Text = Class2.O2Sat
        TextBox41.Text = Class2.Wt
        TextBox42.Text = Class2.Ht
        TextBox43.Text = Class2.BMI
        TextBox44.Text = Class2.Remarks
        TextBox45.Text = Class2.LMP
        TextBox46.Text = Class2.NameOfIncident
        TextBox47.Text = Class2.PlaceOfIncident
        TextBox48.Text = Class2.DateOfIncident
        TextBox49.Text = Class2.DateOfDisabilityBegan
        TextBox50.Text = Class2.PartOfTheBodyAffected
        TextBox51.Text = Class2.TimeOfIncident
        TextBox52.Text = Class2.TypeOfIncident
        TextBox53.Text = Class2.PropertyDamage
        TextBox54.Text = Class2.PersonalInjury
        TextBox55.Text = Class2.DateOfReturnedToWork
        TextBox56.Text = Class2.DayLost
        TextBox57.Text = Class2.UnsafeAct
        TextBox58.Text = Class2.UnsafeMechanical
        TextBox59.Text = Class2.ContributingFactor
        TextBox60.Text = Class2.ExtentOfDisability
        TextBox61.Text = Class2.DamageOfProperty
        TextBox62.Text = Class2.DescriptionOfIncident
        TextBox63.Text = Class2.Witness

        Label70.Text = Class2.Name
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim Form As New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(Form, New Rectangle(0, 0, Me.Width, Me.Height))
        e.Graphics.DrawImage(Form, 50, 150)
    End Sub

    Private Sub Label70_Click(sender As Object, e As EventArgs) Handles Label70.Click
        PrintPreviewDialog1.ShowDialog()
        Me.Hide()
    End Sub
End Class