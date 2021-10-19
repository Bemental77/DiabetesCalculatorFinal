<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCarbs = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCarbs = New System.Windows.Forms.TextBox()
        Me.lblCurrentBloodSugar = New System.Windows.Forms.Label()
        Me.txtCurrentBloodSugar = New System.Windows.Forms.TextBox()
        Me.lblInsulinToCarbRatio = New System.Windows.Forms.Label()
        Me.txtInsulinToCarbRatio = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblChooseMeal = New System.Windows.Forms.Label()
        Me.cbxChooseMeal = New System.Windows.Forms.ComboBox()
        Me.gbxDisplay = New System.Windows.Forms.GroupBox()
        Me.lblFormulaOutput = New System.Windows.Forms.Label()
        Me.lblFormulaDisplay = New System.Windows.Forms.Label()
        Me.lblInsulinOutput = New System.Windows.Forms.Label()
        Me.lblMealOutput = New System.Windows.Forms.Label()
        Me.lblNameOutput = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMealDisplay = New System.Windows.Forms.Label()
        Me.lblNameDisplay = New System.Windows.Forms.Label()
        Me.gbxDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(12, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(62, 25)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'lblCarbs
        '
        Me.lblCarbs.AutoSize = True
        Me.lblCarbs.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCarbs.Location = New System.Drawing.Point(12, 58)
        Me.lblCarbs.Name = "lblCarbs"
        Me.lblCarbs.Size = New System.Drawing.Size(139, 25)
        Me.lblCarbs.TabIndex = 1
        Me.lblCarbs.Text = "Carbohydrates:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(80, 9)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(283, 25)
        Me.txtName.TabIndex = 2
        '
        'txtCarbs
        '
        Me.txtCarbs.Location = New System.Drawing.Point(157, 58)
        Me.txtCarbs.Name = "txtCarbs"
        Me.txtCarbs.Size = New System.Drawing.Size(206, 25)
        Me.txtCarbs.TabIndex = 3
        '
        'lblCurrentBloodSugar
        '
        Me.lblCurrentBloodSugar.AutoSize = True
        Me.lblCurrentBloodSugar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCurrentBloodSugar.Location = New System.Drawing.Point(12, 110)
        Me.lblCurrentBloodSugar.Name = "lblCurrentBloodSugar"
        Me.lblCurrentBloodSugar.Size = New System.Drawing.Size(188, 25)
        Me.lblCurrentBloodSugar.TabIndex = 4
        Me.lblCurrentBloodSugar.Text = "Current Blood Sugar:"
        '
        'txtCurrentBloodSugar
        '
        Me.txtCurrentBloodSugar.Location = New System.Drawing.Point(206, 110)
        Me.txtCurrentBloodSugar.Name = "txtCurrentBloodSugar"
        Me.txtCurrentBloodSugar.Size = New System.Drawing.Size(157, 25)
        Me.txtCurrentBloodSugar.TabIndex = 5
        '
        'lblInsulinToCarbRatio
        '
        Me.lblInsulinToCarbRatio.AutoSize = True
        Me.lblInsulinToCarbRatio.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInsulinToCarbRatio.Location = New System.Drawing.Point(12, 162)
        Me.lblInsulinToCarbRatio.Name = "lblInsulinToCarbRatio"
        Me.lblInsulinToCarbRatio.Size = New System.Drawing.Size(187, 25)
        Me.lblInsulinToCarbRatio.TabIndex = 6
        Me.lblInsulinToCarbRatio.Text = "Insulin to Carb Ratio:"
        '
        'txtInsulinToCarbRatio
        '
        Me.txtInsulinToCarbRatio.Location = New System.Drawing.Point(206, 162)
        Me.txtInsulinToCarbRatio.Name = "txtInsulinToCarbRatio"
        Me.txtInsulinToCarbRatio.Size = New System.Drawing.Size(157, 25)
        Me.txtInsulinToCarbRatio.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCalculate.Location = New System.Drawing.Point(12, 377)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(214, 61)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.Location = New System.Drawing.Point(292, 377)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(214, 61)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(574, 377)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(214, 61)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblChooseMeal
        '
        Me.lblChooseMeal.AutoSize = True
        Me.lblChooseMeal.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblChooseMeal.Location = New System.Drawing.Point(73, 219)
        Me.lblChooseMeal.Name = "lblChooseMeal"
        Me.lblChooseMeal.Size = New System.Drawing.Size(126, 25)
        Me.lblChooseMeal.TabIndex = 11
        Me.lblChooseMeal.Text = "Choose Meal:"
        '
        'cbxChooseMeal
        '
        Me.cbxChooseMeal.FormattingEnabled = True
        Me.cbxChooseMeal.Location = New System.Drawing.Point(206, 219)
        Me.cbxChooseMeal.Name = "cbxChooseMeal"
        Me.cbxChooseMeal.Size = New System.Drawing.Size(157, 25)
        Me.cbxChooseMeal.TabIndex = 12
        '
        'gbxDisplay
        '
        Me.gbxDisplay.Controls.Add(Me.lblFormulaOutput)
        Me.gbxDisplay.Controls.Add(Me.lblFormulaDisplay)
        Me.gbxDisplay.Controls.Add(Me.lblInsulinOutput)
        Me.gbxDisplay.Controls.Add(Me.lblMealOutput)
        Me.gbxDisplay.Controls.Add(Me.lblNameOutput)
        Me.gbxDisplay.Controls.Add(Me.Label1)
        Me.gbxDisplay.Controls.Add(Me.lblMealDisplay)
        Me.gbxDisplay.Controls.Add(Me.lblNameDisplay)
        Me.gbxDisplay.Location = New System.Drawing.Point(382, 27)
        Me.gbxDisplay.Name = "gbxDisplay"
        Me.gbxDisplay.Size = New System.Drawing.Size(379, 323)
        Me.gbxDisplay.TabIndex = 13
        Me.gbxDisplay.TabStop = False
        Me.gbxDisplay.Text = "Display"
        '
        'lblFormulaOutput
        '
        Me.lblFormulaOutput.AutoSize = True
        Me.lblFormulaOutput.Location = New System.Drawing.Point(53, 240)
        Me.lblFormulaOutput.Name = "lblFormulaOutput"
        Me.lblFormulaOutput.Size = New System.Drawing.Size(95, 17)
        Me.lblFormulaOutput.TabIndex = 7
        Me.lblFormulaOutput.Text = "FormulaOutput"
        '
        'lblFormulaDisplay
        '
        Me.lblFormulaDisplay.AutoSize = True
        Me.lblFormulaDisplay.Location = New System.Drawing.Point(17, 223)
        Me.lblFormulaDisplay.Name = "lblFormulaDisplay"
        Me.lblFormulaDisplay.Size = New System.Drawing.Size(125, 17)
        Me.lblFormulaDisplay.TabIndex = 6
        Me.lblFormulaDisplay.Text = "Calculation Formula:"
        '
        'lblInsulinOutput
        '
        Me.lblInsulinOutput.AutoSize = True
        Me.lblInsulinOutput.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblInsulinOutput.Location = New System.Drawing.Point(160, 138)
        Me.lblInsulinOutput.Name = "lblInsulinOutput"
        Me.lblInsulinOutput.Size = New System.Drawing.Size(94, 17)
        Me.lblInsulinOutput.TabIndex = 5
        Me.lblInsulinOutput.Text = "InsulinOutput"
        '
        'lblMealOutput
        '
        Me.lblMealOutput.AutoSize = True
        Me.lblMealOutput.Location = New System.Drawing.Point(79, 70)
        Me.lblMealOutput.Name = "lblMealOutput"
        Me.lblMealOutput.Size = New System.Drawing.Size(77, 17)
        Me.lblMealOutput.TabIndex = 4
        Me.lblMealOutput.Text = "MealOutput"
        '
        'lblNameOutput
        '
        Me.lblNameOutput.AutoSize = True
        Me.lblNameOutput.Location = New System.Drawing.Point(79, 42)
        Me.lblNameOutput.Name = "lblNameOutput"
        Me.lblNameOutput.Size = New System.Drawing.Size(79, 17)
        Me.lblNameOutput.TabIndex = 3
        Me.lblNameOutput.Text = "NameOuput"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(17, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Insulin Units to give:"
        '
        'lblMealDisplay
        '
        Me.lblMealDisplay.AutoSize = True
        Me.lblMealDisplay.Location = New System.Drawing.Point(23, 70)
        Me.lblMealDisplay.Name = "lblMealDisplay"
        Me.lblMealDisplay.Size = New System.Drawing.Size(40, 17)
        Me.lblMealDisplay.TabIndex = 1
        Me.lblMealDisplay.Text = "Meal:"
        '
        'lblNameDisplay
        '
        Me.lblNameDisplay.AutoSize = True
        Me.lblNameDisplay.Location = New System.Drawing.Point(17, 42)
        Me.lblNameDisplay.Name = "lblNameDisplay"
        Me.lblNameDisplay.Size = New System.Drawing.Size(46, 17)
        Me.lblNameDisplay.TabIndex = 0
        Me.lblNameDisplay.Text = "Name:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gbxDisplay)
        Me.Controls.Add(Me.cbxChooseMeal)
        Me.Controls.Add(Me.lblChooseMeal)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtInsulinToCarbRatio)
        Me.Controls.Add(Me.lblInsulinToCarbRatio)
        Me.Controls.Add(Me.txtCurrentBloodSugar)
        Me.Controls.Add(Me.lblCurrentBloodSugar)
        Me.Controls.Add(Me.txtCarbs)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblCarbs)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Form1"
        Me.Text = "Diabetes Calculator"
        Me.gbxDisplay.ResumeLayout(False)
        Me.gbxDisplay.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblCarbs As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtCarbs As TextBox
    Friend WithEvents lblCurrentBloodSugar As Label
    Friend WithEvents txtCurrentBloodSugar As TextBox
    Friend WithEvents lblInsulinToCarbRatio As Label
    Friend WithEvents txtInsulinToCarbRatio As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblChooseMeal As Label
    Friend WithEvents cbxChooseMeal As ComboBox
    Friend WithEvents gbxDisplay As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMealDisplay As Label
    Friend WithEvents lblNameDisplay As Label
    Friend WithEvents lblFormulaOutput As Label
    Friend WithEvents lblFormulaDisplay As Label
    Friend WithEvents lblInsulinOutput As Label
    Friend WithEvents lblMealOutput As Label
    Friend WithEvents lblNameOutput As Label
End Class
