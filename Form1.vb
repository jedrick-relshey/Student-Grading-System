Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim gradeBoxes As TextBox() = {
            txtPrelim1, txtPrelim2, txtPrelim3, txtPrelim4, txtPrelim5, txtPrelim6,
            txtMidterm1, txtMidterm2, txtMidterm3, txtMidterm4, txtMidterm5, txtMidterm6,
            txtFinals1, txtFinals2, txtFinals3, txtFinals4, txtFinals5, txtFinals6,
            txtPrelimTotal1, txtPrelimTotal2, txtPrelimTotal3, txtPrelimTotal4, txtPrelimTotal5, txtPrelimTotal6,
            txtMidtermTotal1, txtMidtermTotal2, txtMidtermTotal3, txtMidtermTotal4, txtMidtermTotal5, txtMidtermTotal6,
            txtFinalsTotal1, txtFinalsTotal2, txtFinalsTotal3, txtFinalsTotal4, txtFinalsTotal5, txtFinalsTotal6
        }

        For Each txt As TextBox In gradeBoxes

            AddHandler txt.KeyPress, AddressOf Grade_KeyPress
            AddHandler txt.TextChanged, AddressOf Grade_TextChanged

        Next

        'Combobox Year Level
        cmbCourse.Items.Add("BSIT")
        cmbCourse.Items.Add("BSHM")
        cmbCourse.Items.Add("BSCRIM")

        'Selection
        cmbCourse.SelectedIndex = -1
        cmbyrSctn.SelectedIndex = -1
    End Sub

    Private Sub Grade_KeyPress(sender As Object, e As KeyPressEventArgs)

        Dim txt As TextBox = CType(sender, TextBox)

        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True
            txt.ForeColor = Color.Red
            txt.Tag = "Numbers only."

            MessageBox.Show("Numbers only.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            txt.ForeColor = Color.Black
        End If

    End Sub

    Private Sub Grade_TextChanged(sender As Object, e As EventArgs)

        Dim txt As TextBox = CType(sender, TextBox)

        If txt.Text <> "" Then
            If Val(txt.Text) > 100 Then
                MessageBox.Show("Max is 100.")
                txt.Clear()
            End If
        End If

    End Sub

    'Students Course for Combo Box
    Private Sub cmbCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCourse.SelectedIndexChanged

        cmbyrSctn.Items.Clear()

        If cmbCourse.Text = "BSIT" Then

            lblCourseTitle.Text = "Bachelor of Science in Information Technology"

            cmbyrSctn.Items.Add("BSIT 1A")
            cmbyrSctn.Items.Add("BSIT 1B")
            cmbyrSctn.Items.Add("")

            cmbyrSctn.Items.Add("BSIT 2A")
            cmbyrSctn.Items.Add("BSIT 2B")
            cmbyrSctn.Items.Add("")

            cmbyrSctn.Items.Add("BSIT 3A")
            cmbyrSctn.Items.Add("BSIT 3B")
            cmbyrSctn.Items.Add("")

            cmbyrSctn.Items.Add("BSIT 4A")
            cmbyrSctn.Items.Add("BSIT 4B")

        ElseIf cmbCourse.Text = "BSHM" Then

            lblCourseTitle.Text = "Bachelor of Science in Hospitality Management"

            cmbyrSctn.Items.Add("BSHM 1A")
            cmbyrSctn.Items.Add("BSHM 1B")
            cmbyrSctn.Items.Add("")

            cmbyrSctn.Items.Add("BSHM 2A")
            cmbyrSctn.Items.Add("BSHM 2B")
            cmbyrSctn.Items.Add("")

            cmbyrSctn.Items.Add("BSHM 3A")
            cmbyrSctn.Items.Add("BSHM 3B")
            cmbyrSctn.Items.Add("")

            cmbyrSctn.Items.Add("BSHM 4A")
            cmbyrSctn.Items.Add("BSHM 4B")

        ElseIf cmbCourse.Text = "BSCRIM" Then

            lblCourseTitle.Text = "Bachelor of Science in Criminology"

            cmbyrSctn.Items.Add("BSCRIM 1A")
            cmbyrSctn.Items.Add("BSCRIM 1B")
            cmbyrSctn.Items.Add("")

            cmbyrSctn.Items.Add("BSCRIM 2A")
            cmbyrSctn.Items.Add("BSCRIM 2B")
            cmbyrSctn.Items.Add("")

            cmbyrSctn.Items.Add("BSCRIM 3A")
            cmbyrSctn.Items.Add("BSCRIM 3B")
            cmbyrSctn.Items.Add("")

            cmbyrSctn.Items.Add("BSCRIM 4A")
            cmbyrSctn.Items.Add("BSCRIM 4B")

        End If

    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click

        Dim prelims As Double
        Dim midterms As Double
        Dim finals As Double
        Dim finalGrade As Double

        For i As Integer = 1 To 6

            Dim txtPrelim As TextBox = CType(Controls.Find("txtPrelim" & i, True)(0), TextBox)
            Dim txtMidterm As TextBox = CType(Controls.Find("txtMidterm" & i, True)(0), TextBox)
            Dim txtFinals As TextBox = CType(Controls.Find("txtFinals" & i, True)(0), TextBox)

            Dim txtFinalGrade As TextBox = CType(Controls.Find("txtFinalGrade" & i, True)(0), TextBox)
            Dim lblStatus As Label = CType(Controls.Find("lblStatus" & i, True)(0), Label)

            prelims = Val(txtPrelim.Text) * 0.3
            midterms = Val(txtMidterm.Text) * 0.3
            finals = Val(txtFinals.Text) * 0.4

            finalGrade = prelims + midterms + finals

            txtFinalGrade.Text = finalGrade.ToString("0.00")

            If finalGrade >= 75 Then
                lblStatus.Text = "Passed"
                lblStatus.Visible = True
                lblStatus.ForeColor = Color.Green
            Else
                lblStatus.Text = "Failed"
                lblStatus.Visible = True
                lblStatus.ForeColor = Color.Red
            End If
        Next

        'ComboBox Function
        If cmbCourse.Text = "" Then
            lblYearLevel.Visible = True
        Else
            lblYearLevel.Visible = False
        End If

        'Radio Botton
        If Not (rbFirstsem.Checked OrElse rbSecondSem.Checked) Then
            lblSemesterError1.Visible = True
            lblSemesterError2.Visible = True
        Else
            lblSemesterError1.Visible = False
            lblSemesterError2.Visible = False
        End If

        'Function for Label of text Boox
        For i As Integer = 1 To 6

            'Student Name
            Dim txtStudentName As TextBox = CType(Controls.Find("txtStudentName" & i, True)(0), TextBox)
            Dim lblNameError As Label = CType(Controls.Find("lblNameError" & i, True)(0), Label)

            If txtStudentName.Text = "" Then
                lblNameError.Visible = True
            Else
                lblNameError.Visible = False
            End If

            'Prelim Grade
            Dim txtPrelim As TextBox = CType(Controls.Find("txtPrelim" & i, True)(0), TextBox)
            Dim lblPrelimGrade As Label = CType(Controls.Find("lblPrelimGrade" & i, True)(0), Label)

            If txtPrelim.Text = "" Then
                lblPrelimGrade.Text = "Enter Value"
                lblPrelimGrade.Visible = True
            Else
                lblPrelimGrade.Visible = False
            End If

            'Midterm Grade
            Dim txtMidterm As TextBox = CType(Controls.Find("txtMidterm" & i, True)(0), TextBox)
            Dim lblMidtermGrade As Label = CType(Controls.Find("lblMidtermGrade" & i, True)(0), Label)

            If txtMidterm.Text = "" Then
                lblMidtermGrade.Text = "Enter Value"
                lblMidtermGrade.Visible = True
            Else
                lblMidtermGrade.Visible = False
            End If

            'Finals Grade
            Dim txtFinals As TextBox = CType(Controls.Find("txtFinals" & i, True)(0), TextBox)
            Dim lblFinalGrade As Label = CType(Controls.Find("lblFinalGrade" & i, True)(0), Label)

            If txtFinals.Text = "" Then
                lblFinalGrade.Text = "Enter Value"
                lblFinalGrade.Visible = True
            Else
                lblFinalGrade.Visible = False
            End If
        Next
    End Sub

    Private Sub rbSecondSem_CheckedChanged(sender As Object, e As EventArgs) Handles rbSecondSem.CheckedChanged
        If rbFirstsem.Checked Then
            lblFrstSmTxt.Text = "First Semester"
        ElseIf rbSecondSem.Checked Then
            lblFrstSmTxt.Text = "Second Semester"
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'Check Course
        If cmbCourse.Text = "" Then
            MessageBox.Show("Please select a course.", "Warning")
            Exit Sub
        End If

        'Check Year & Section
        If cmbyrSctn.Text = "" Then
            MessageBox.Show("Please select a year and section.", "Warning")
            Exit Sub
        End If

        'Check Semester
        If Not (rbFirstsem.Checked OrElse rbSecondSem.Checked) Then
            MessageBox.Show("Please select a semester.", "Warning")
            Exit Sub
        End If

        'Check if grades is computed
        If txtFinalGrade1.Text = "" OrElse
           txtFinalGrade2.Text = "" OrElse
           txtFinalGrade3.Text = "" OrElse
           txtFinalGrade4.Text = "" OrElse
           txtFinalGrade5.Text = "" OrElse
           txtFinalGrade6.Text = "" Then

            MessageBox.Show("Please compute all grades first.", "Warning")
            Exit Sub
        End If

        'Confirmation
        If MessageBox.Show("Are you sure you want to save this grade?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            'Save Records ComboBox
            cmbRecords.Items.Add(cmbyrSctn.Text)
            MessageBox.Show("Grade successfully saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class