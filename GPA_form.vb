Public Class GPA_form

    Dim floatingSum As Double
    Dim numberOfCourses As Integer

    'When the Record This Course button is clicked, run the following procedure
    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        'Declare the follwing variables because 
        Dim grades As String
        Dim gradeValue As Integer
        Dim hours As Integer
        Dim courseGrade As Double

        'Run validation to make sure a Grade value was selected and the credie hours value was entered.
        '(Grade Indexes: Nothing Selected = -1, A = 0, B = 1, C = 2, D = 3, E = 4)
        'If the user selects one of the Grades in the combo box, then check to see If the user entered a value for the Credit Hours. 
        If (cmbGrades.SelectedIndex > -1) Then
            If (txtCreditHours.Text = "1" Or txtCreditHours.Text = "2" Or txtCreditHours.Text = "3" Or txtCreditHours.Text = "4") Then
                grades = cmbGrades.Text 'Assign the value entered in the Grades combo box to the grades variable
                gradeValue = CalculateGrade(grades)

                hours = CInt(txtCreditHours.Text)
                courseGrade = CalculateCourseGrade(gradeValue, hours)
                numberOfCourses += 1
                floatingSum += courseGrade

                Call ResetForm()
            Else
                MessageBox.Show("Please enter the correct number of Credit Hours.", "Invaid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please select a Grade from the options provided.", "Invaid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub ResetForm()
        cmbGrades.SelectedIndex = -1
        cmbGrades.Text = "Select Grade"
        txtCreditHours.Clear()
    End Sub

    Function CalculateCourseGrade(gradeValue As Integer, hours As Integer) As Double
        Dim courseGrade As Double
        Dim finalGrade As Double
        Dim maxPossibleGrade As Integer

        maxPossibleGrade = 4 * hours '4 represents A
        courseGrade = gradeValue * hours 'Covers B, C, D, and F
        finalGrade = (courseGrade / maxPossibleGrade) * 4

        Return finalGrade
    End Function

    'Function used to calculate the grade, using the grades variable value that was selected in the Grades combo box.
    Function CalculateGrade(grades As String) As Integer
        Dim gradeValue As Integer

        Select Case (grades)
            Case "A"
                gradeValue = 4
            Case "B"
                gradeValue = 3
            Case "C"
                gradeValue = 2
            Case "D"
                gradeValue = 1
            Case Else
                gradeValue = 0
        End Select

        Return gradeValue
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim GPA As Double

        If numberOfCourses > 0 Then
            GPA = floatingSum / numberOfCourses
            lblGPA.Text = GPA.ToString("N2")
            floatingSum = 0
            numberOfCourses = 0

            Call ResetForm()
        Else
            MessageBox.Show("Please enter grade first", "Nothing to calculate", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
