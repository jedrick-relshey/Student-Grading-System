Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Combobox Year Level
        cmbCourse.Items.Add("BSIT")
        cmbCourse.Items.Add("BSHM")
        cmbCourse.Items.Add("BSCRIM")

        'Selection
        cmbCourse.SelectedIndex = -1
        cmbyrSctn.SelectedIndex = -1
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
            Dim txtPrelimTotal As TextBox = CType(Controls.Find("txtPrelimTotal" & i, True)(0), TextBox)

            Dim txtMidterm As TextBox = CType(Controls.Find("txtMidterm" & i, True)(0), TextBox)
            Dim txtMidtermTotal As TextBox = CType(Controls.Find("txtMidtermTotal" & i, True)(0), TextBox)

            Dim txtFinals As TextBox = CType(Controls.Find("txtFinals" & i, True)(0), TextBox)
            Dim txtFinalsTotal As TextBox = CType(Controls.Find("txtFinalsTotal" & i, True)(0), TextBox)

            Dim txtFinalGrade As TextBox = CType(Controls.Find("txtFinalGrade" & i, True)(0), TextBox)

            Dim lblStatus As Label = CType(Controls.Find("lblStatus" & i, True)(0), Label)

            If txtPrelimTotal.Text <> "0" AndAlso
       txtMidtermTotal.Text <> "0" AndAlso
       txtFinalsTotal.Text <> "0" Then

                prelims = (Val(txtPrelim.Text) / Val(txtPrelimTotal.Text)) * 30
                midterms = (Val(txtMidterm.Text) / Val(txtMidtermTotal.Text)) * 30
                finals = (Val(txtFinals.Text) / Val(txtFinalsTotal.Text)) * 40

                finalGrade = prelims + midterms + finals

                txtFinalGrade.Text = finalGrade.ToString("0.00")

                If finalGrade >= 75 And finalGrade <= 100 Then
                    lblStatus.Text = "Passed"
                    lblStatus.Visible = True
                    lblStatus.ForeColor = Color.Green
                Else
                    lblStatus.Text = "Failed"
                    lblStatus.Visible = True
                    lblStatus.ForeColor = Color.Red
                End If

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

        'Student Name Text Box
        If txtStudentName1.Text = "" Then
            lblNameError1.Visible = True
        Else
            lblNameError1.Visible = False
        End If

        If txtStudentName2.Text = "" Then
            lblNameError2.Visible = True
        Else
            lblNameError2.Visible = False
        End If

        If txtStudentName3.Text = "" Then
            lblNameError3.Visible = True
        Else
            lblNameError3.Visible = False
        End If

        If txtStudentName4.Text = "" Then
            lblNameError4.Visible = True
        Else
            lblNameError4.Visible = False
        End If

        If txtStudentName5.Text = "" Then
            lblNameError5.Visible = True
        Else
            lblNameError5.Visible = False
        End If

        If txtStudentName6.Text = "" Then
            lblNameError6.Visible = True
        Else
            lblNameError6.Visible = False
        End If

        ' PRELIMS STUDENT GRADE
        If txtPrelim1.Text = "" Then
            lblPrelimGrade1.Text = "Enter Value"
            lblPrelimGrade1.Visible = True
        Else
            lblPrelimGrade1.Visible = False
        End If

        If txtPrelim2.Text = "" Then
            lblPrelimGrade2.Text = "Enter Value"
            lblPrelimGrade2.Visible = True
        Else
            lblPrelimGrade2.Visible = False
        End If

        If txtPrelim3.Text = "" Then
            lblPrelimGrade3.Text = "Enter Value"
            lblPrelimGrade3.Visible = True
        Else
            lblPrelimGrade3.Visible = False
        End If

        If txtPrelim4.Text = "" Then
            lblPrelimGrade4.Text = "Enter Value"
            lblPrelimGrade4.Visible = True
        Else
            lblPrelimGrade4.Visible = False
        End If

        If txtPrelim5.Text = "" Then
            lblPrelimGrade5.Text = "Enter Value"
            lblPrelimGrade5.Visible = True
        Else
            lblPrelimGrade5.Visible = False
        End If

        If txtPrelim6.Text = "" Then
            lblPrelimGrade6.Text = "Enter Value"
            lblPrelimGrade6.Visible = True
        Else
            lblPrelimGrade6.Visible = False
        End If

        ' PRELIMS TOTAL VALUE
        If txtPrelimTotal1.Text = "" Then
            lblPrelimValue1.Text = "Enter Value"
            lblPrelimValue1.Visible = True
        Else
            lblPrelimValue1.Visible = False
        End If

        If txtPrelimTotal2.Text = "" Then
            lblPrelimValue2.Text = "Enter Value"
            lblPrelimValue2.Visible = True
        Else
            lblPrelimValue2.Visible = False
        End If

        If txtPrelimTotal3.Text = "" Then
            lblPrelimValue3.Text = "Enter Value"
            lblPrelimValue3.Visible = True
        Else
            lblPrelimValue3.Visible = False
        End If

        If txtPrelimTotal4.Text = "" Then
            lblPrelimValue4.Text = "Enter Value"
            lblPrelimValue4.Visible = True
        Else
            lblPrelimValue4.Visible = False
        End If

        If txtPrelimTotal5.Text = "" Then
            lblPrelimValue5.Text = "Enter Value"
            lblPrelimValue5.Visible = True
        Else
            lblPrelimValue5.Visible = False
        End If

        If txtPrelimTotal6.Text = "" Then
            lblPrelimValue6.Text = "Enter Value"
            lblPrelimValue6.Visible = True
        Else
            lblPrelimValue6.Visible = False
        End If

        ' MIDTERM STUDENT GRADE
        If txtMidterm1.Text = "" Then
            lblMidtermGrade1.Text = "Enter Value"
            lblMidtermGrade1.Visible = True
        Else
            lblMidtermGrade1.Visible = False
        End If

        If txtMidterm2.Text = "" Then
            lblMidtermGrade2.Text = "Enter Value"
            lblMidtermGrade2.Visible = True
        Else
            lblMidtermGrade2.Visible = False
        End If

        If txtMidterm3.Text = "" Then
            lblMidtermGrade3.Text = "Enter Value"
            lblMidtermGrade3.Visible = True
        Else
            lblMidtermGrade3.Visible = False
        End If

        If txtMidterm4.Text = "" Then
            lblMidtermGrade4.Text = "Enter Value"
            lblMidtermGrade4.Visible = True
        Else
            lblMidtermGrade4.Visible = False
        End If

        If txtMidterm5.Text = "" Then
            lblMidtermGrade5.Text = "Enter Value"
            lblMidtermGrade5.Visible = True
        Else
            lblMidtermGrade5.Visible = False
        End If

        If txtMidterm6.Text = "" Then
            lblMidtermGrade6.Text = "Enter Value"
            lblMidtermGrade6.Visible = True
        Else
            lblMidtermGrade6.Visible = False
        End If

        ' MIDTERM TOTAL VALUE
        If txtMidtermTotal1.Text = "" Then
            lblMidtermValue1.Text = "Enter Value"
            lblMidtermValue1.Visible = True
        Else
            lblMidtermValue1.Visible = False
        End If

        If txtMidtermTotal2.Text = "" Then
            lblMidtermValue2.Text = "Enter Value"
            lblMidtermValue2.Visible = True
        Else
            lblMidtermValue2.Visible = False
        End If

        If txtMidtermTotal3.Text = "" Then
            lblMidtermValue3.Text = "Enter Value"
            lblMidtermValue3.Visible = True
        Else
            lblMidtermValue3.Visible = False
        End If

        If txtMidtermTotal4.Text = "" Then
            lblMidtermValue4.Text = "Enter Value"
            lblMidtermValue4.Visible = True
        Else
            lblMidtermValue4.Visible = False
        End If

        If txtMidtermTotal5.Text = "" Then
            lblMidtermValue5.Text = "Enter Value"
            lblMidtermValue5.Visible = True
        Else
            lblMidtermValue5.Visible = False
        End If

        If txtMidtermTotal6.Text = "" Then
            lblMidtermValue6.Text = "Enter Value"
            lblMidtermValue6.Visible = True
        Else
            lblMidtermValue6.Visible = False
        End If

        ' FINALS STUDENT GRADE
        If txtFinals1.Text = "" Then
            lblFinalGrade1.Text = "Enter Value"
            lblFinalGrade1.Visible = True
        Else
            lblFinalGrade1.Visible = False
        End If

        If txtFinals2.Text = "" Then
            lblFinalGrade2.Text = "Enter Value"
            lblFinalGrade2.Visible = True
        Else
            lblFinalGrade2.Visible = False
        End If

        If txtFinals3.Text = "" Then
            lblFinalGrade3.Text = "Enter Value"
            lblFinalGrade3.Visible = True
        Else
            lblFinalGrade3.Visible = False
        End If

        If txtFinals4.Text = "" Then
            lblFinalGrade4.Text = "Enter Value"
            lblFinalGrade4.Visible = True
        Else
            lblFinalGrade4.Visible = False
        End If

        If txtFinals5.Text = "" Then
            lblFinalGrade5.Text = "Enter Value"
            lblFinalGrade5.Visible = True
        Else
            lblFinalGrade5.Visible = False
        End If

        If txtFinals6.Text = "" Then
            lblFinalGrade6.Text = "Enter Value"
            lblFinalGrade6.Visible = True
        Else
            lblFinalGrade6.Visible = False
        End If

        'Student Final Grade
        If txtFinalsTotal1.Text = "" Then
            lblFinalValue1.Text = "Enter Value"
            lblFinalValue1.Visible = True
        Else
            lblFinalValue1.Visible = False
        End If

        If txtFinalsTotal2.Text = "" Then
            lblFinalValue2.Text = "Enter Value"
            lblFinalValue2.Visible = True
        Else
            lblFinalValue2.Visible = False
        End If

        If txtFinalsTotal3.Text = "" Then
            lblFinalValue3.Text = "Enter Value"
            lblFinalValue3.Visible = True
        Else
            lblFinalValue3.Visible = False
        End If

        If txtFinalsTotal4.Text = "" Then
            lblFinalValue4.Text = "Enter Value"
            lblFinalValue4.Visible = True
        Else
            lblFinalValue4.Visible = False
        End If

        If txtFinalsTotal5.Text = "" Then
            lblFinalValue5.Text = "Enter Value"
            lblFinalValue5.Visible = True
        Else
            lblFinalValue5.Visible = False
        End If

        If txtFinalsTotal6.Text = "" Then
            lblFinalValue6.Text = "Enter Value"
            lblFinalValue6.Visible = True
        Else
            lblFinalValue6.Visible = False
        End If
    End Sub



    Private Sub rbSecondSem_CheckedChanged(sender As Object, e As EventArgs) Handles rbSecondSem.CheckedChanged
        If rbFirstsem.Checked Then
            lblFrstSmTxt.Text = "First Semester"
        ElseIf rbSecondSem.Checked Then
            lblFrstSmTxt.Text = "Second Semester"
        End If
    End Sub

    'PRELIM 1 VALIDATION
    Private Sub txtPrelim1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrelim1.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True
            lblPrelimGrade1.Text = "Numbers only."
            lblPrelimGrade1.Visible = True

        Else
            lblPrelimGrade1.Visible = False
        End If
    End Sub

    Private Sub txtPrelim1_TextChanged(sender As Object, e As EventArgs) Handles txtPrelim1.TextChanged

        If txtPrelim1.Text <> "" Then

            If Val(txtPrelim1.Text) > 100 Then
                lblPrelimGrade1.Text = "Max is 100"
                lblPrelimGrade1.Visible = True
                txtPrelim1.Clear()
            Else
                lblPrelimGrade1.Visible = False
            End If

        End If

    End Sub

    Private Sub txtPrelimTotal1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrelimTotal1.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True
            lblPrelimValue1.Text = "Numbers only."
            lblPrelimValue1.Visible = True

        Else
            lblPrelimValue1.Visible = False
        End If
    End Sub

    Private Sub txtPrelimTotal1_TextChanged(sender As Object, e As EventArgs) Handles txtPrelimTotal1.TextChanged

        If txtPrelimTotal1.Text <> "" Then

            If Val(txtPrelimTotal1.Text) > 100 Then
                lblPrelimValue1.Text = "Max is 100."
                lblPrelimValue1.Visible = True
                txtPrelimTotal1.Clear()
            Else
                lblPrelimValue1.Visible = False
            End If
        End If
    End Sub

    'PRELIM 2 VALIDATION
    Private Sub txtPrelim2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrelim2.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True
            lblPrelimGrade2.Text = "Numbers only."
            lblPrelimGrade2.Visible = True

        Else
            lblPrelimGrade2.Visible = False
        End If
    End Sub

    Private Sub txtPrelim2_TextChanged(sender As Object, e As EventArgs) Handles txtPrelim2.TextChanged

        If txtPrelim2.Text <> "" Then

            If Val(txtPrelim2.Text) > 100 Then
                lblPrelimGrade2.Text = "Max is 100"
                lblPrelimGrade2.Visible = True
                txtPrelim2.Clear()
            Else
                lblPrelimGrade2.Visible = False
            End If
        End If

    End Sub

    Private Sub txtPrelimTotal2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrelimTotal2.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True
            lblPrelimValue2.Text = "Numbers only."
            lblPrelimValue2.Visible = True

        Else
            lblPrelimValue2.Visible = False
        End If
    End Sub

    Private Sub txtPrelimTotal2_TextChanged(sender As Object, e As EventArgs) Handles txtPrelimTotal2.TextChanged

        If txtPrelimTotal2.Text <> "" Then

            If Val(txtPrelimTotal2.Text) > 100 Then
                lblPrelimValue2.Text = "Max is 100."
                lblPrelimValue2.Visible = True
                txtPrelimTotal2.Clear()
            Else
                lblPrelimValue2.Visible = False
            End If
        End If
    End Sub

    'PRELIM 3 VALIDATION
    Private Sub txtPrelim3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrelim3.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True
            lblPrelimGrade3.Text = "Numbers only."
            lblPrelimGrade3.Visible = True

        Else
            lblPrelimGrade3.Visible = False
        End If
    End Sub

    Private Sub txtPrelim3_TextChanged(sender As Object, e As EventArgs) Handles txtPrelim3.TextChanged

        If txtPrelim3.Text <> "" Then

            If Val(txtPrelim3.Text) > 100 Then
                lblPrelimGrade3.Text = "Max is 100"
                lblPrelimGrade3.Visible = True
                txtPrelim3.Clear()
            Else
                lblPrelimGrade3.Visible = False
            End If
        End If

    End Sub

    Private Sub txtPrelimTotal3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrelimTotal3.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True
            lblPrelimValue3.Text = "Numbers only."
            lblPrelimValue3.Visible = True

        Else
            lblPrelimValue3.Visible = False
        End If
    End Sub

    Private Sub txtPrelimTotal3_TextChanged(sender As Object, e As EventArgs) Handles txtPrelimTotal3.TextChanged

        If txtPrelimTotal3.Text <> "" Then

            If Val(txtPrelimTotal3.Text) > 100 Then
                lblPrelimValue3.Text = "Max is 100."
                lblPrelimValue3.Visible = True
                txtPrelimTotal3.Clear()
            Else
                lblPrelimValue3.Visible = False
            End If
        End If
    End Sub

    'PRELIM 4 VALIDATION
    Private Sub txtPrelim4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrelim4.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True
            lblPrelimGrade4.Text = "Numbers only."
            lblPrelimGrade4.Visible = True

        Else
            lblPrelimGrade4.Visible = False
        End If
    End Sub

    Private Sub txtPrelim4_TextChanged(sender As Object, e As EventArgs) Handles txtPrelim4.TextChanged

        If txtPrelim4.Text <> "" Then

            If Val(txtPrelim4.Text) > 100 Then
                lblPrelimGrade4.Text = "Max is 100"
                lblPrelimGrade4.Visible = True
                txtPrelim4.Clear()
            Else
                lblPrelimGrade4.Visible = False
            End If
        End If

    End Sub

    Private Sub txtPrelimTotal4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrelimTotal4.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True
            lblPrelimValue4.Text = "Numbers only."
            lblPrelimValue4.Visible = True

        Else
            lblPrelimValue4.Visible = False
        End If
    End Sub

    Private Sub txtPrelimTotal4_TextChanged(sender As Object, e As EventArgs) Handles txtPrelimTotal4.TextChanged

        If txtPrelimTotal4.Text <> "" Then

            If Val(txtPrelimTotal4.Text) > 100 Then
                lblPrelimValue4.Text = "Max is 100."
                lblPrelimValue4.Visible = True
                txtPrelimTotal4.Clear()
            Else
                lblPrelimValue4.Visible = False
            End If
        End If
    End Sub

    'PRELIM 5 VALIDATION
    Private Sub txtPrelim5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrelim5.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True
            lblPrelimGrade5.Text = "Numbers only."
            lblPrelimGrade5.Visible = True

        Else
            lblPrelimGrade5.Visible = False
        End If
    End Sub

    Private Sub txtPrelim5_TextChanged(sender As Object, e As EventArgs) Handles txtPrelim5.TextChanged

        If txtPrelim5.Text <> "" Then

            If Val(txtPrelim5.Text) > 100 Then
                lblPrelimGrade5.Text = "Max is 100"
                lblPrelimGrade5.Visible = True
                txtPrelim5.Clear()
            Else
                lblPrelimGrade5.Visible = False
            End If
        End If

    End Sub

    Private Sub txtPrelimTotal5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrelimTotal5.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True
            lblPrelimValue5.Text = "Numbers only."
            lblPrelimValue5.Visible = True

        Else
            lblPrelimValue5.Visible = False
        End If
    End Sub

    Private Sub txtPrelimTotal5_TextChanged(sender As Object, e As EventArgs) Handles txtPrelimTotal5.TextChanged

        If txtPrelimTotal5.Text <> "" Then

            If Val(txtPrelimTotal5.Text) > 100 Then
                lblPrelimValue5.Text = "Max is 100."
                lblPrelimValue5.Visible = True
                txtPrelimTotal5.Clear()
            Else
                lblPrelimValue5.Visible = False
            End If
        End If
    End Sub

    'PRELIM 6 VALIDATION
    Private Sub txtPrelim6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrelim6.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True
            lblPrelimGrade6.Text = "Numbers only."
            lblPrelimGrade6.Visible = True

        Else
            lblPrelimGrade6.Visible = False
        End If
    End Sub

    Private Sub txtPrelim6_TextChanged(sender As Object, e As EventArgs) Handles txtPrelim6.TextChanged

        If txtPrelim6.Text <> "" Then

            If Val(txtPrelim6.Text) > 100 Then
                lblPrelimGrade6.Text = "Max is 100"
                lblPrelimGrade6.Visible = True
                txtPrelim6.Clear()
            Else
                lblPrelimGrade6.Visible = False
            End If
        End If

    End Sub

    Private Sub txtPrelimTotal6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrelimTotal6.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True
            lblPrelimValue6.Text = "Numbers only."
            lblPrelimValue6.Visible = True

        Else
            lblPrelimValue6.Visible = False
        End If
    End Sub

    Private Sub txtPrelimTotal6_TextChanged(sender As Object, e As EventArgs) Handles txtPrelimTotal6.TextChanged

        If txtPrelimTotal6.Text <> "" Then

            If Val(txtPrelimTotal6.Text) > 100 Then
                lblPrelimValue6.Text = "Max is 100."
                lblPrelimValue6.Visible = True
                txtPrelimTotal6.Clear()
            Else
                lblPrelimValue6.Visible = False
            End If
        End If
    End Sub

    'MIDTERM 1 VALIDATION
    Private Sub txtMidterm1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMidterm1.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True
            lblMidtermGrade1.Text = "Numbers only."
            lblMidtermGrade1.Visible = True

        Else
            lblMidtermGrade1.Visible = False
        End If
    End Sub

    Private Sub txtMidterm1_TextChanged(sender As Object, e As EventArgs) Handles txtMidterm1.TextChanged

        If txtMidterm1.Text <> "" Then

            If Val(txtMidterm1.Text) > 100 Then
                lblMidtermGrade1.Text = "Max is 100."
                lblMidtermGrade1.Visible = True
                txtMidterm1.Clear()
            Else
                lblMidtermGrade1.Visible = False
            End If
        End If

    End Sub

    Private Sub txtMidtermTotal1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMidtermTotal1.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True
            lblMidtermValue1.Text = "Numbers only."
            lblMidtermValue1.Visible = True

        Else
            lblMidtermValue1.Visible = False
        End If
    End Sub

    Private Sub txtMidtermTotal1_TextChanged(sender As Object, e As EventArgs) Handles txtMidtermTotal1.TextChanged

        If txtMidtermTotal1.Text <> "" Then

            If Val(txtMidtermTotal1.Text) > 100 Then
                lblMidtermValue1.Text = "Max is 100."
                lblMidtermValue1.Visible = True
                txtMidtermTotal1.Clear()
            Else
                lblMidtermValue1.Visible = False
            End If
        End If

    End Sub

    'MIDTERM 2 VALIDATION
    Private Sub txtMidterm2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMidterm2.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True
            lblMidtermGrade2.Text = "Numbers only."
            lblMidtermGrade2.Visible = True

        Else
            lblMidtermGrade2.Visible = False
        End If
    End Sub

    Private Sub txtMidterm2_TextChanged(sender As Object, e As EventArgs) Handles txtMidterm2.TextChanged

        If txtMidterm2.Text <> "" Then

            If Val(txtMidterm2.Text) > 100 Then
                lblMidtermGrade2.Text = "Max is 100."
                lblMidtermGrade2.Visible = True
                txtMidterm2.Clear()
            Else
                lblMidtermGrade2.Visible = False
            End If
        End If

    End Sub

    Private Sub txtMidtermTotal2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMidtermTotal2.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True
            lblMidtermValue2.Text = "Numbers only."
            lblMidtermValue2.Visible = True

        Else
            lblMidtermValue2.Visible = False
        End If
    End Sub

    Private Sub txtMidtermTotal2_TextChanged(sender As Object, e As EventArgs) Handles txtMidtermTotal2.TextChanged

        If txtMidtermTotal2.Text <> "" Then

            If Val(txtMidtermTotal2.Text) > 100 Then
                lblMidtermValue2.Text = "Max is 100."
                lblMidtermValue2.Visible = True
                txtMidtermTotal2.Clear()
            Else
                lblMidtermValue2.Visible = False
            End If
        End If

    End Sub

    'MIDTERM 3 VALIDATION
    Private Sub txtMidterm3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMidterm3.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True
            lblMidtermGrade3.Text = "Numbers only."
            lblMidtermGrade3.Visible = True

        Else
            lblMidtermGrade3.Visible = False
        End If
    End Sub

    Private Sub txtMidterm3_TextChanged(sender As Object, e As EventArgs) Handles txtMidterm3.TextChanged

        If txtMidterm3.Text <> "" Then

            If Val(txtMidterm3.Text) > 100 Then
                lblMidtermGrade3.Text = "Max is 100."
                lblMidtermGrade3.Visible = True
                txtMidterm3.Clear()
            Else
                lblMidtermGrade3.Visible = False
            End If
        End If

    End Sub

    Private Sub txtMidtermTotal3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMidtermTotal3.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True
            lblMidtermValue3.Text = "Numbers only."
            lblMidtermValue3.Visible = True

        Else
            lblMidtermValue3.Visible = False
        End If
    End Sub

    Private Sub txtMidtermTotal3_TextChanged(sender As Object, e As EventArgs) Handles txtMidtermTotal3.TextChanged

        If txtMidtermTotal3.Text <> "" Then

            If Val(txtMidtermTotal3.Text) > 100 Then
                lblMidtermValue3.Text = "Max is 100."
                lblMidtermValue3.Visible = True
                txtMidtermTotal3.Clear()
            Else
                lblMidtermValue3.Visible = False
            End If
        End If

    End Sub

    'MIDTERM 4 VALIDATION
    Private Sub txtMidterm4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMidterm4.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True
            lblMidtermGrade4.Text = "Numbers only."
            lblMidtermGrade4.Visible = True

        Else
            lblMidtermGrade4.Visible = False
        End If
    End Sub

    Private Sub txtMidterm4_TextChanged(sender As Object, e As EventArgs) Handles txtMidterm4.TextChanged

        If txtMidterm4.Text <> "" Then

            If Val(txtMidterm4.Text) > 100 Then
                lblMidtermGrade4.Text = "Max is 100."
                lblMidtermGrade4.Visible = True
                txtMidterm4.Clear()
            Else
                lblMidtermGrade4.Visible = False
            End If
        End If

    End Sub

    Private Sub txtMidtermTotal4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMidtermTotal4.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True
            lblMidtermValue4.Text = "Numbers only."
            lblMidtermValue4.Visible = True

        Else
            lblMidtermValue4.Visible = False
        End If
    End Sub

    Private Sub txtMidtermTotal4_TextChanged(sender As Object, e As EventArgs) Handles txtMidtermTotal4.TextChanged

        If txtMidtermTotal4.Text <> "" Then

            If Val(txtMidtermTotal4.Text) > 100 Then
                lblMidtermValue4.Text = "Max is 100."
                lblMidtermValue4.Visible = True
                txtMidtermTotal4.Clear()
            Else
                lblMidtermValue4.Visible = False
            End If
        End If

    End Sub

    'MIDTERM 5 VALIDATION
    Private Sub txtMidterm5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMidterm5.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True
            lblMidtermGrade5.Text = "Numbers only."
            lblMidtermGrade5.Visible = True

        Else
            lblMidtermGrade5.Visible = False
        End If
    End Sub

    Private Sub txtMidterm5_TextChanged(sender As Object, e As EventArgs) Handles txtMidterm5.TextChanged

        If txtMidterm5.Text <> "" Then

            If Val(txtMidterm5.Text) > 100 Then
                lblMidtermGrade5.Text = "Max is 100."
                lblMidtermGrade5.Visible = True
                txtMidterm5.Clear()
            Else
                lblMidtermGrade5.Visible = False
            End If
        End If

    End Sub

    Private Sub txtMidtermTotal5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMidtermTotal5.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True
            lblMidtermValue5.Text = "Numbers only."
            lblMidtermValue5.Visible = True

        Else
            lblMidtermValue5.Visible = False
        End If
    End Sub

    Private Sub txtMidtermTotal5_TextChanged(sender As Object, e As EventArgs) Handles txtMidtermTotal5.TextChanged

        If txtMidtermTotal5.Text <> "" Then

            If Val(txtMidtermTotal5.Text) > 100 Then
                lblMidtermValue5.Text = "Max is 100."
                lblMidtermValue5.Visible = True
                txtMidtermTotal5.Clear()
            Else
                lblMidtermValue5.Visible = False
            End If
        End If

    End Sub

    'MIDTERM 6 VALIDATION
    Private Sub txtMidterm6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMidterm6.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True
            lblMidtermGrade6.Text = "Numbers only."
            lblMidtermGrade6.Visible = True

        Else
            lblMidtermGrade6.Visible = False
        End If
    End Sub

    Private Sub txtMidterm6_TextChanged(sender As Object, e As EventArgs) Handles txtMidterm6.TextChanged

        If txtMidterm6.Text <> "" Then

            If Val(txtMidterm6.Text) > 100 Then
                lblMidtermGrade6.Text = "Max is 100."
                lblMidtermGrade6.Visible = True
                txtMidterm6.Clear()
            Else
                lblMidtermGrade6.Visible = False
            End If
        End If

    End Sub

    Private Sub txtMidtermTotal6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMidtermTotal6.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True
            lblMidtermValue6.Text = "Numbers only."
            lblMidtermValue6.Visible = True

        Else
            lblMidtermValue6.Visible = False
        End If
    End Sub

    Private Sub txtMidtermTotal6_TextChanged(sender As Object, e As EventArgs) Handles txtMidtermTotal6.TextChanged

        If txtMidtermTotal6.Text <> "" Then

            If Val(txtMidtermTotal6.Text) > 100 Then
                lblMidtermValue6.Text = "Max is 100."
                lblMidtermValue6.Visible = True
                txtMidtermTotal6.Clear()
            Else
                lblMidtermValue6.Visible = False
            End If
        End If

    End Sub

    'FINALS 1 VALIDATION
    Private Sub txtFinals1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFinals1.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True
            lblFinalGrade1.Text = "Numbers only."
            lblFinalGrade1.Visible = True

        Else
            lblFinalGrade1.Visible = False
        End If
    End Sub

    Private Sub txtFinals1_TextChanged(sender As Object, e As EventArgs) Handles txtFinals1.TextChanged

        If txtFinals1.Text <> "" Then

            If Val(txtFinals1.Text) > 100 Then
                lblFinalGrade1.Text = "Max is 100."
                lblFinalGrade1.Visible = True
                txtFinals1.Clear()
            Else
                lblFinalGrade1.Visible = False
            End If
        End If

    End Sub

    Private Sub txtFinalsTotal1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFinalsTotal1.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True
            lblFinalValue1.Text = "Numbers only."
            lblFinalValue1.Visible = True

        Else
            lblFinalValue1.Visible = False
        End If
    End Sub

    Private Sub txtFinalsTotal1_TextChanged(sender As Object, e As EventArgs) Handles txtFinalsTotal1.TextChanged

        If txtFinalsTotal1.Text <> "" Then

            If Val(txtFinalsTotal1.Text) > 100 Then
                lblFinalValue1.Text = "Max is 100."
                lblFinalValue1.Visible = True
                txtFinalsTotal1.Clear()
            Else
                lblFinalValue1.Visible = False
            End If
        End If
    End Sub

    ' FINALS 2 VALIDATION
    Private Sub txtFinals2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFinals2.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            lblFinalGrade2.Text = "Numbers only."
            lblFinalGrade2.Visible = True
        Else
            lblFinalGrade2.Visible = False
        End If
    End Sub

    Private Sub txtFinals2_TextChanged(sender As Object, e As EventArgs) Handles txtFinals2.TextChanged
        If txtFinals2.Text <> "" Then
            If Val(txtFinals2.Text) > 100 Then
                lblFinalGrade2.Text = "Max is 100."
                lblFinalGrade2.Visible = True
                txtFinals2.Clear()
            Else
                lblFinalGrade2.Visible = False
            End If
        End If
    End Sub

    Private Sub txtFinalsTotal2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFinalsTotal2.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            lblFinalValue2.Text = "Numbers only."
            lblFinalValue2.Visible = True
        Else
            lblFinalValue2.Visible = False
        End If
    End Sub

    Private Sub txtFinalsTotal2_TextChanged(sender As Object, e As EventArgs) Handles txtFinalsTotal2.TextChanged
        If txtFinalsTotal2.Text <> "" Then
            If Val(txtFinalsTotal2.Text) > 100 Then
                lblFinalValue2.Text = "Max is 100."
                lblFinalValue2.Visible = True
                txtFinalsTotal2.Clear()
            Else
                lblFinalValue2.Visible = False
            End If
        End If
    End Sub

    ' FINALS 3 VALIDATION

    Private Sub txtFinals3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFinals3.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            lblFinalGrade3.Text = "Numbers only."
            lblFinalGrade3.Visible = True
        Else
            lblFinalGrade3.Visible = False
        End If
    End Sub

    Private Sub txtFinals3_TextChanged(sender As Object, e As EventArgs) Handles txtFinals3.TextChanged
        If txtFinals3.Text <> "" Then
            If Val(txtFinals3.Text) > 100 Then
                lblFinalGrade3.Text = "Max is 100."
                lblFinalGrade3.Visible = True
                txtFinals3.Clear()
            Else
                lblFinalGrade3.Visible = False
            End If
        End If
    End Sub

    Private Sub txtFinalsTotal3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFinalsTotal3.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            lblFinalValue3.Text = "Numbers only."
            lblFinalValue3.Visible = True
        Else
            lblFinalValue3.Visible = False
        End If
    End Sub

    Private Sub txtFinalsTotal3_TextChanged(sender As Object, e As EventArgs) Handles txtFinalsTotal3.TextChanged
        If txtFinalsTotal3.Text <> "" Then
            If Val(txtFinalsTotal3.Text) > 100 Then
                lblFinalValue3.Text = "Max is 100."
                lblFinalValue3.Visible = True
                txtFinalsTotal3.Clear()
            Else
                lblFinalValue3.Visible = False
            End If
        End If
    End Sub

    ' FINALS 4 VALIDATION
    Private Sub txtFinals4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFinals4.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            lblFinalGrade4.Text = "Numbers only."
            lblFinalGrade4.Visible = True
        Else
            lblFinalGrade4.Visible = False
        End If
    End Sub

    Private Sub txtFinals4_TextChanged(sender As Object, e As EventArgs) Handles txtFinals4.TextChanged
        If txtFinals4.Text <> "" Then
            If Val(txtFinals4.Text) > 100 Then
                lblFinalGrade4.Text = "Max is 100."
                lblFinalGrade4.Visible = True
                txtFinals4.Clear()
            Else
                lblFinalGrade4.Visible = False
            End If
        End If
    End Sub

    Private Sub txtFinalsTotal4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFinalsTotal4.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            lblFinalValue4.Text = "Numbers only."
            lblFinalValue4.Visible = True
        Else
            lblFinalValue4.Visible = False
        End If
    End Sub

    Private Sub txtFinalsTotal4_TextChanged(sender As Object, e As EventArgs) Handles txtFinalsTotal4.TextChanged
        If txtFinalsTotal4.Text <> "" Then
            If Val(txtFinalsTotal4.Text) > 100 Then
                lblFinalValue4.Text = "Max is 100."
                lblFinalValue4.Visible = True
                txtFinalsTotal4.Clear()
            Else
                lblFinalValue4.Visible = False
            End If
        End If
    End Sub

    ' FINALS 5 VALIDATION
    Private Sub txtFinals5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFinals5.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            lblFinalGrade5.Text = "Numbers only."
            lblFinalGrade5.Visible = True
        Else
            lblFinalGrade5.Visible = False
        End If
    End Sub

    Private Sub txtFinals5_TextChanged(sender As Object, e As EventArgs) Handles txtFinals5.TextChanged
        If txtFinals5.Text <> "" Then
            If Val(txtFinals5.Text) > 100 Then
                lblFinalGrade5.Text = "Max is 100."
                lblFinalGrade5.Visible = True
                txtFinals5.Clear()
            Else
                lblFinalGrade5.Visible = False
            End If
        End If
    End Sub

    Private Sub txtFinalsTotal5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFinalsTotal5.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            lblFinalValue5.Text = "Numbers only."
            lblFinalValue5.Visible = True
        Else
            lblFinalValue5.Visible = False
        End If
    End Sub

    Private Sub txtFinalsTotal5_TextChanged(sender As Object, e As EventArgs) Handles txtFinalsTotal5.TextChanged
        If txtFinalsTotal5.Text <> "" Then
            If Val(txtFinalsTotal5.Text) > 100 Then
                lblFinalValue5.Text = "Max is 100."
                lblFinalValue5.Visible = True
                txtFinalsTotal5.Clear()
            Else
                lblFinalValue5.Visible = False
            End If
        End If
    End Sub

    ' FINALS 6 VALIDATION
    Private Sub txtFinals6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFinals6.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            lblFinalGrade6.Text = "Numbers only."
            lblFinalGrade6.Visible = True
        Else
            lblFinalGrade6.Visible = False
        End If
    End Sub

    Private Sub txtFinals6_TextChanged(sender As Object, e As EventArgs) Handles txtFinals6.TextChanged
        If txtFinals6.Text <> "" Then
            If Val(txtFinals6.Text) > 100 Then
                lblFinalGrade6.Text = "Max is 100."
                lblFinalGrade6.Visible = True
                txtFinals6.Clear()
            Else
                lblFinalGrade6.Visible = False
            End If
        End If
    End Sub

    Private Sub txtFinalsTotal6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFinalsTotal6.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            lblFinalValue6.Text = "Numbers only."
            lblFinalValue6.Visible = True
        Else
            lblFinalValue6.Visible = False
        End If
    End Sub

    Private Sub txtFinalsTotal6_TextChanged(sender As Object, e As EventArgs) Handles txtFinalsTotal6.TextChanged
        If txtFinalsTotal6.Text <> "" Then
            If Val(txtFinalsTotal6.Text) > 100 Then
                lblFinalValue6.Text = "Max is 100."
                lblFinalValue6.Visible = True
                txtFinalsTotal6.Clear()
            Else
                lblFinalValue6.Visible = False
            End If
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