<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiabetesCalculator
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblChooseMeal = New System.Windows.Forms.Label()
        Me.gbxDisplay = New System.Windows.Forms.GroupBox()
        Me.lblMealDisplayOutput = New System.Windows.Forms.Label()
        Me.lblMeal = New System.Windows.Forms.Label()
        Me.lblInsulinToCarbRatioOutput = New System.Windows.Forms.Label()
        Me.lblInsulinToCarbRatioDisplay = New System.Windows.Forms.Label()
        Me.lblCurrentBloodSugarOutput = New System.Windows.Forms.Label()
        Me.lblCurrentBloodSugarDisplay = New System.Windows.Forms.Label()
        Me.lblCarbohydratesOutput = New System.Windows.Forms.Label()
        Me.lblCarbohydratesDisplay = New System.Windows.Forms.Label()
        Me.lblPersonIDOutput = New System.Windows.Forms.Label()
        Me.lblPersonIDDisplay = New System.Windows.Forms.Label()
        Me.lblDateOutput = New System.Windows.Forms.Label()
        Me.lblDateDisplay = New System.Windows.Forms.Label()
        Me.lblFormulaOutput = New System.Windows.Forms.Label()
        Me.lblFormulaDisplay = New System.Windows.Forms.Label()
        Me.lblInsulinOutput = New System.Windows.Forms.Label()
        Me.lblMealOutput = New System.Windows.Forms.Label()
        Me.lblNameOutput = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMealDisplay = New System.Windows.Forms.Label()
        Me.lblNameDisplay = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtMeal = New System.Windows.Forms.TextBox()
        Me.lbxPersons = New System.Windows.Forms.ListBox()
        Me.gbxDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(15, 27)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(62, 25)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'lblCarbs
        '
        Me.lblCarbs.AutoSize = True
        Me.lblCarbs.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCarbs.Location = New System.Drawing.Point(15, 76)
        Me.lblCarbs.Name = "lblCarbs"
        Me.lblCarbs.Size = New System.Drawing.Size(139, 25)
        Me.lblCarbs.TabIndex = 1
        Me.lblCarbs.Text = "Carbohydrates:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(83, 27)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(283, 25)
        Me.txtName.TabIndex = 2
        '
        'txtCarbs
        '
        Me.txtCarbs.Location = New System.Drawing.Point(160, 76)
        Me.txtCarbs.Name = "txtCarbs"
        Me.txtCarbs.Size = New System.Drawing.Size(206, 25)
        Me.txtCarbs.TabIndex = 3
        '
        'lblCurrentBloodSugar
        '
        Me.lblCurrentBloodSugar.AutoSize = True
        Me.lblCurrentBloodSugar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCurrentBloodSugar.Location = New System.Drawing.Point(15, 128)
        Me.lblCurrentBloodSugar.Name = "lblCurrentBloodSugar"
        Me.lblCurrentBloodSugar.Size = New System.Drawing.Size(188, 25)
        Me.lblCurrentBloodSugar.TabIndex = 4
        Me.lblCurrentBloodSugar.Text = "Current Blood Sugar:"
        '
        'txtCurrentBloodSugar
        '
        Me.txtCurrentBloodSugar.Location = New System.Drawing.Point(209, 128)
        Me.txtCurrentBloodSugar.Name = "txtCurrentBloodSugar"
        Me.txtCurrentBloodSugar.Size = New System.Drawing.Size(157, 25)
        Me.txtCurrentBloodSugar.TabIndex = 5
        '
        'lblInsulinToCarbRatio
        '
        Me.lblInsulinToCarbRatio.AutoSize = True
        Me.lblInsulinToCarbRatio.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInsulinToCarbRatio.Location = New System.Drawing.Point(15, 180)
        Me.lblInsulinToCarbRatio.Name = "lblInsulinToCarbRatio"
        Me.lblInsulinToCarbRatio.Size = New System.Drawing.Size(187, 25)
        Me.lblInsulinToCarbRatio.TabIndex = 6
        Me.lblInsulinToCarbRatio.Text = "Insulin to Carb Ratio:"
        '
        'txtInsulinToCarbRatio
        '
        Me.txtInsulinToCarbRatio.Location = New System.Drawing.Point(209, 180)
        Me.txtInsulinToCarbRatio.Name = "txtInsulinToCarbRatio"
        Me.txtInsulinToCarbRatio.Size = New System.Drawing.Size(157, 25)
        Me.txtInsulinToCarbRatio.TabIndex = 7
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.Location = New System.Drawing.Point(64, 520)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(214, 61)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(507, 520)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(214, 61)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblChooseMeal
        '
        Me.lblChooseMeal.AutoSize = True
        Me.lblChooseMeal.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblChooseMeal.Location = New System.Drawing.Point(76, 237)
        Me.lblChooseMeal.Name = "lblChooseMeal"
        Me.lblChooseMeal.Size = New System.Drawing.Size(126, 25)
        Me.lblChooseMeal.TabIndex = 11
        Me.lblChooseMeal.Text = "Choose Meal:"
        '
        'gbxDisplay
        '
        Me.gbxDisplay.Controls.Add(Me.lblMealDisplayOutput)
        Me.gbxDisplay.Controls.Add(Me.lblMeal)
        Me.gbxDisplay.Controls.Add(Me.lblInsulinToCarbRatioOutput)
        Me.gbxDisplay.Controls.Add(Me.lblInsulinToCarbRatioDisplay)
        Me.gbxDisplay.Controls.Add(Me.lblCurrentBloodSugarOutput)
        Me.gbxDisplay.Controls.Add(Me.lblCurrentBloodSugarDisplay)
        Me.gbxDisplay.Controls.Add(Me.lblCarbohydratesOutput)
        Me.gbxDisplay.Controls.Add(Me.lblCarbohydratesDisplay)
        Me.gbxDisplay.Controls.Add(Me.lblPersonIDOutput)
        Me.gbxDisplay.Controls.Add(Me.lblPersonIDDisplay)
        Me.gbxDisplay.Controls.Add(Me.lblDateOutput)
        Me.gbxDisplay.Controls.Add(Me.lblDateDisplay)
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
        'lblMealDisplayOutput
        '
        Me.lblMealDisplayOutput.AutoSize = True
        Me.lblMealDisplayOutput.Location = New System.Drawing.Point(155, 161)
        Me.lblMealDisplayOutput.Name = "lblMealDisplayOutput"
        Me.lblMealDisplayOutput.Size = New System.Drawing.Size(77, 17)
        Me.lblMealDisplayOutput.TabIndex = 21
        Me.lblMealDisplayOutput.Text = "MealOutput"
        '
        'lblMeal
        '
        Me.lblMeal.AutoSize = True
        Me.lblMeal.Location = New System.Drawing.Point(111, 161)
        Me.lblMeal.Name = "lblMeal"
        Me.lblMeal.Size = New System.Drawing.Size(40, 17)
        Me.lblMeal.TabIndex = 20
        Me.lblMeal.Text = "Meal:"
        '
        'lblInsulinToCarbRatioOutput
        '
        Me.lblInsulinToCarbRatioOutput.AutoSize = True
        Me.lblInsulinToCarbRatioOutput.Location = New System.Drawing.Point(157, 143)
        Me.lblInsulinToCarbRatioOutput.Name = "lblInsulinToCarbRatioOutput"
        Me.lblInsulinToCarbRatioOutput.Size = New System.Drawing.Size(73, 17)
        Me.lblInsulinToCarbRatioOutput.TabIndex = 19
        Me.lblInsulinToCarbRatioOutput.Text = "ITCROutput"
        '
        'lblInsulinToCarbRatioDisplay
        '
        Me.lblInsulinToCarbRatioDisplay.AutoSize = True
        Me.lblInsulinToCarbRatioDisplay.Location = New System.Drawing.Point(22, 143)
        Me.lblInsulinToCarbRatioDisplay.Name = "lblInsulinToCarbRatioDisplay"
        Me.lblInsulinToCarbRatioDisplay.Size = New System.Drawing.Size(129, 17)
        Me.lblInsulinToCarbRatioDisplay.TabIndex = 18
        Me.lblInsulinToCarbRatioDisplay.Text = "Insulin to Carb Ratio:"
        '
        'lblCurrentBloodSugarOutput
        '
        Me.lblCurrentBloodSugarOutput.AutoSize = True
        Me.lblCurrentBloodSugarOutput.Location = New System.Drawing.Point(158, 126)
        Me.lblCurrentBloodSugarOutput.Name = "lblCurrentBloodSugarOutput"
        Me.lblCurrentBloodSugarOutput.Size = New System.Drawing.Size(70, 17)
        Me.lblCurrentBloodSugarOutput.TabIndex = 17
        Me.lblCurrentBloodSugarOutput.Text = "CBSOutput"
        '
        'lblCurrentBloodSugarDisplay
        '
        Me.lblCurrentBloodSugarDisplay.AutoSize = True
        Me.lblCurrentBloodSugarDisplay.Location = New System.Drawing.Point(22, 126)
        Me.lblCurrentBloodSugarDisplay.Name = "lblCurrentBloodSugarDisplay"
        Me.lblCurrentBloodSugarDisplay.Size = New System.Drawing.Size(130, 17)
        Me.lblCurrentBloodSugarDisplay.TabIndex = 16
        Me.lblCurrentBloodSugarDisplay.Text = "Current Blood Sugar:"
        '
        'lblCarbohydratesOutput
        '
        Me.lblCarbohydratesOutput.AutoSize = True
        Me.lblCarbohydratesOutput.Location = New System.Drawing.Point(125, 109)
        Me.lblCarbohydratesOutput.Name = "lblCarbohydratesOutput"
        Me.lblCarbohydratesOutput.Size = New System.Drawing.Size(134, 17)
        Me.lblCarbohydratesOutput.TabIndex = 15
        Me.lblCarbohydratesOutput.Text = "CarbohydratesOutput"
        '
        'lblCarbohydratesDisplay
        '
        Me.lblCarbohydratesDisplay.AutoSize = True
        Me.lblCarbohydratesDisplay.Location = New System.Drawing.Point(22, 109)
        Me.lblCarbohydratesDisplay.Name = "lblCarbohydratesDisplay"
        Me.lblCarbohydratesDisplay.Size = New System.Drawing.Size(97, 17)
        Me.lblCarbohydratesDisplay.TabIndex = 14
        Me.lblCarbohydratesDisplay.Text = "Carbohydrates:"
        '
        'lblPersonIDOutput
        '
        Me.lblPersonIDOutput.AutoSize = True
        Me.lblPersonIDOutput.Location = New System.Drawing.Point(101, 31)
        Me.lblPersonIDOutput.Name = "lblPersonIDOutput"
        Me.lblPersonIDOutput.Size = New System.Drawing.Size(100, 17)
        Me.lblPersonIDOutput.TabIndex = 13
        Me.lblPersonIDOutput.Text = "PersonIDOutput"
        '
        'lblPersonIDDisplay
        '
        Me.lblPersonIDDisplay.AutoSize = True
        Me.lblPersonIDDisplay.Location = New System.Drawing.Point(16, 31)
        Me.lblPersonIDDisplay.Name = "lblPersonIDDisplay"
        Me.lblPersonIDDisplay.Size = New System.Drawing.Size(79, 17)
        Me.lblPersonIDDisplay.TabIndex = 12
        Me.lblPersonIDDisplay.Text = "Person ID #:"
        '
        'lblDateOutput
        '
        Me.lblDateOutput.AutoSize = True
        Me.lblDateOutput.Location = New System.Drawing.Point(160, 283)
        Me.lblDateOutput.Name = "lblDateOutput"
        Me.lblDateOutput.Size = New System.Drawing.Size(75, 17)
        Me.lblDateOutput.TabIndex = 11
        Me.lblDateOutput.Text = "DateOutput"
        '
        'lblDateDisplay
        '
        Me.lblDateDisplay.AutoSize = True
        Me.lblDateDisplay.Location = New System.Drawing.Point(116, 283)
        Me.lblDateDisplay.Name = "lblDateDisplay"
        Me.lblDateDisplay.Size = New System.Drawing.Size(38, 17)
        Me.lblDateDisplay.TabIndex = 10
        Me.lblDateDisplay.Text = "Date:"
        '
        'lblFormulaOutput
        '
        Me.lblFormulaOutput.AutoSize = True
        Me.lblFormulaOutput.Location = New System.Drawing.Point(160, 223)
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
        Me.lblInsulinOutput.Location = New System.Drawing.Point(161, 195)
        Me.lblInsulinOutput.Name = "lblInsulinOutput"
        Me.lblInsulinOutput.Size = New System.Drawing.Size(94, 17)
        Me.lblInsulinOutput.TabIndex = 5
        Me.lblInsulinOutput.Text = "InsulinOutput"
        '
        'lblMealOutput
        '
        Me.lblMealOutput.AutoSize = True
        Me.lblMealOutput.Location = New System.Drawing.Point(78, 88)
        Me.lblMealOutput.Name = "lblMealOutput"
        Me.lblMealOutput.Size = New System.Drawing.Size(77, 17)
        Me.lblMealOutput.TabIndex = 4
        Me.lblMealOutput.Text = "MealOutput"
        '
        'lblNameOutput
        '
        Me.lblNameOutput.AutoSize = True
        Me.lblNameOutput.Location = New System.Drawing.Point(78, 60)
        Me.lblNameOutput.Name = "lblNameOutput"
        Me.lblNameOutput.Size = New System.Drawing.Size(79, 17)
        Me.lblNameOutput.TabIndex = 3
        Me.lblNameOutput.Text = "NameOuput"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(18, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Insulin Units to give:"
        '
        'lblMealDisplay
        '
        Me.lblMealDisplay.AutoSize = True
        Me.lblMealDisplay.Location = New System.Drawing.Point(22, 88)
        Me.lblMealDisplay.Name = "lblMealDisplay"
        Me.lblMealDisplay.Size = New System.Drawing.Size(40, 17)
        Me.lblMealDisplay.TabIndex = 1
        Me.lblMealDisplay.Text = "Meal:"
        '
        'lblNameDisplay
        '
        Me.lblNameDisplay.AutoSize = True
        Me.lblNameDisplay.Location = New System.Drawing.Point(16, 60)
        Me.lblNameDisplay.Name = "lblNameDisplay"
        Me.lblNameDisplay.Size = New System.Drawing.Size(46, 17)
        Me.lblNameDisplay.TabIndex = 0
        Me.lblNameDisplay.Text = "Name:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDate.Location = New System.Drawing.Point(64, 283)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(138, 25)
        Me.lblDate.TabIndex = 14
        Me.lblDate.Text = "Date and Time:"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(208, 283)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(157, 25)
        Me.txtDate.TabIndex = 9
        '
        'txtMeal
        '
        Me.txtMeal.Location = New System.Drawing.Point(208, 237)
        Me.txtMeal.Name = "txtMeal"
        Me.txtMeal.Size = New System.Drawing.Size(157, 25)
        Me.txtMeal.TabIndex = 8
        '
        'lbxPersons
        '
        Me.lbxPersons.FormattingEnabled = True
        Me.lbxPersons.ItemHeight = 17
        Me.lbxPersons.Location = New System.Drawing.Point(382, 384)
        Me.lbxPersons.Name = "lbxPersons"
        Me.lbxPersons.Size = New System.Drawing.Size(379, 89)
        Me.lbxPersons.TabIndex = 12
        '
        'frmDiabetesCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(800, 593)
        Me.Controls.Add(Me.lbxPersons)
        Me.Controls.Add(Me.txtMeal)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.gbxDisplay)
        Me.Controls.Add(Me.lblChooseMeal)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtInsulinToCarbRatio)
        Me.Controls.Add(Me.lblInsulinToCarbRatio)
        Me.Controls.Add(Me.txtCurrentBloodSugar)
        Me.Controls.Add(Me.lblCurrentBloodSugar)
        Me.Controls.Add(Me.txtCarbs)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblCarbs)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmDiabetesCalculator"
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
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblChooseMeal As Label
    Friend WithEvents gbxDisplay As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMealDisplay As Label
    Friend WithEvents lblNameDisplay As Label
    Friend WithEvents lblFormulaOutput As Label
    Friend WithEvents lblFormulaDisplay As Label
    Friend WithEvents lblInsulinOutput As Label
    Friend WithEvents lblMealOutput As Label
    Friend WithEvents lblNameOutput As Label
    Friend WithEvents lblDateOutput As Label
    Friend WithEvents lblDateDisplay As Label
    Friend WithEvents lblPersonIDOutput As Label
    Friend WithEvents lblPersonIDDisplay As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtMeal As TextBox
    Friend WithEvents lbxPersons As ListBox
    Friend WithEvents lblCarbohydratesOutput As Label
    Friend WithEvents lblCarbohydratesDisplay As Label
    Friend WithEvents lblCurrentBloodSugarOutput As Label
    Friend WithEvents lblCurrentBloodSugarDisplay As Label
    Friend WithEvents lblInsulinToCarbRatioOutput As Label
    Friend WithEvents lblInsulinToCarbRatioDisplay As Label
    Friend WithEvents lblMeal As Label
    Friend WithEvents lblMealDisplayOutput As Label
End Class
