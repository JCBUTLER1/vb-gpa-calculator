<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GPA_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbGrades = New System.Windows.Forms.ComboBox()
        Me.txtCreditHours = New System.Windows.Forms.TextBox()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblGPA = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grade"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Credit Hours"
        '
        'cmbGrades
        '
        Me.cmbGrades.FormattingEnabled = True
        Me.cmbGrades.Items.AddRange(New Object() {"A", "B", "C", "D", "F"})
        Me.cmbGrades.Location = New System.Drawing.Point(116, 23)
        Me.cmbGrades.Name = "cmbGrades"
        Me.cmbGrades.Size = New System.Drawing.Size(94, 21)
        Me.cmbGrades.TabIndex = 2
        Me.cmbGrades.Text = "Select Grade"
        '
        'txtCreditHours
        '
        Me.txtCreditHours.Location = New System.Drawing.Point(116, 65)
        Me.txtCreditHours.Name = "txtCreditHours"
        Me.txtCreditHours.Size = New System.Drawing.Size(94, 20)
        Me.txtCreditHours.TabIndex = 3
        '
        'btnRecord
        '
        Me.btnRecord.AutoSize = True
        Me.btnRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecord.Location = New System.Drawing.Point(40, 114)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(170, 28)
        Me.btnRecord.TabIndex = 4
        Me.btnRecord.Text = "Record This Course"
        Me.btnRecord.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.AutoSize = True
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(40, 165)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(170, 28)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate GPA"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblGPA
        '
        Me.lblGPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGPA.Location = New System.Drawing.Point(110, 222)
        Me.lblGPA.Name = "lblGPA"
        Me.lblGPA.Size = New System.Drawing.Size(100, 23)
        Me.lblGPA.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "GPA"
        '
        'GPA_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 290)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblGPA)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnRecord)
        Me.Controls.Add(Me.txtCreditHours)
        Me.Controls.Add(Me.cmbGrades)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GPA_form"
        Me.Text = "GPA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbGrades As ComboBox
    Friend WithEvents txtCreditHours As TextBox
    Friend WithEvents btnRecord As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblGPA As Label
    Friend WithEvents Label3 As Label
End Class
