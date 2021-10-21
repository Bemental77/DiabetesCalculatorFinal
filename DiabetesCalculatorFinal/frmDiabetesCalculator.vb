

'Author: Casey Bement
'Purpose: Instantiate a Person Class
'Date: 10/19/2021

Option Strict On
Option Explicit On


Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmDiabetesCalculator

    'Module level Object
    Dim lstPersons As New BindingList(Of Person)
    Dim objPerson As New Person()

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim blnIsCarbs As Boolean
        Dim blnIsCurrentBloodSugar As Boolean
        Dim blnIsInsulinToCarbRatio As Boolean
        'Validate all data in textboxes
        If txtName.Text <> String.Empty Then
            If blnIsCarbs = Double.TryParse(txtCarbs.Text, objPerson.Carbohydrates) Then
                If blnIsCurrentBloodSugar = Double.TryParse(txtCurrentBloodSugar.Text, objPerson.CurrentBloodSugar) Then
                    If blnIsInsulinToCarbRatio = Double.TryParse(txtInsulinToCarbRatio.Text, objPerson.InsulinToCarbRatio) Then
                        If txtMeal.Text <> String.Empty Then


                            'blnIsCarbs = Double.TryParse(txtCarbs.Text, objPerson.Carbohydrates)
                            ' blnIsCurrentBloodSugar = Double.TryParse(txtCurrentBloodSugar.Text, objPerson.CurrentBloodSugar)
                            'blnIsInsulinToCarbRatio = Double.TryParse(txtInsulinToCarbRatio.Text, objPerson.InsulinToCarbRatio)

                            'Assign Person Properties
                            'objPerson.PersonID = CType(lblPersonIDOutput.Text, Integer)
                            objPerson.Name = txtName.Text
                            objPerson.Carbohydrates = CType(txtCarbs.Text, Double)
                            objPerson.CurrentBloodSugar = CType(txtCurrentBloodSugar.Text, Double)
                            objPerson.InsulinToCarbRatio = CType(txtInsulinToCarbRatio.Text, Double)
                            objPerson.Meal = txtMeal.Text
                            objPerson.InsulinUnitsToGive = lblInsulinOutput.Text
                            objPerson.DoseDateGiven = CType(txtDate.Text, DateTime)



                            'Process and Display Output
                            lblPersonIDOutput.Text = CType(objPerson.PersonID, String)
                            lblNameOutput.Text = objPerson.Name
                            lblCarbohydratesOutput.Text = CType(objPerson.Carbohydrates, String)
                            lblCurrentBloodSugarOutput.Text = CType(objPerson.CurrentBloodSugar, String)
                            lblInsulinToCarbRatioOutput.Text = CType(objPerson.InsulinToCarbRatio, String)
                            lblMealDisplayOutput.Text = objPerson.Meal
                            lblDateOutput.Text = objPerson.DoseDateGiven.ToString
                            lblInsulinOutput.Text = CalculateInsulin().ToString
                            lblFormulaOutput.Text = FormulaCreate().ToString

                            If btnSave.Text = "Save" Then
                                'Add new Person object to list of Persons
                                lstPersons.Add(objPerson)

                                InsertPerson()
                            ElseIf btnSave.Text = "Update" Then
                                UpdatePerson()
                            ElseIf btnSave.Text = "Delete" Then
                                DeletePerson()
                            End If


                        Else
                            Call Msg("Meal can not be blank.")
                            txtMeal.Focus()
                        End If
                    Else
                        Call Msg("Current Blood Sugar can not be blank, must be numeric and formatted 'XX' or 'XX.XX")
                        txtCurrentBloodSugar.Focus()
                    End If
                Else
                    Call Msg("Carbohydrates can not be blank, must be numeric and formatted 'XX' or 'XX.XX")
                    txtCarbs.Focus()
                End If
            Else
                Call Msg("Insulin To Carb Ratio or Current Blood Sugar can not be blank, must be numeric and formatted 'XX' or 'XX.XX")
                txtInsulinToCarbRatio.Focus()
            End If
        Else
            Call Msg("Name can not be blank.")
            txtName.Focus()
        End If

    End Sub

    Public Function FormulaCreate() As String
        Dim Formula As String
        Formula = lblCarbohydratesOutput.Text + " / " + lblInsulinToCarbRatioOutput.Text
        Return Formula
    End Function

    Public Function CalculateInsulin() As Double
        Dim InsulinUnitsToGive As Double
        InsulinUnitsToGive = CType(txtCarbs.Text, Double) / CType(txtInsulinToCarbRatio.Text, Double)
        Return InsulinUnitsToGive
    End Function

    Public Sub Msg(ByVal strMsg As String)
        MessageBox.Show(strMsg, "Diabetes Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub frmDiabetesCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Bind BindList to Listbox
        lbxPersons.DataSource = lstPersons
        lbxPersons.DisplayMember = "Name"

        txtDate.Text = DateTime.Now.ToString

        Reload_lbxPersons()
    End Sub

    Private Sub Reload_lbxPersons()
        'Clear Listbox
        lstPersons.Clear()

        'Open Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create a command object
        Dim cmdSelect As New SqlCommand("Select * from Person_Tbl;", dbConnection)

        'Execture Command into a DataReader
        Dim rdrPerson As SqlDataReader = cmdSelect.ExecuteReader

        If rdrPerson.HasRows Then
            While rdrPerson.Read
                Dim objStoredPerson As New Person(CType(rdrPerson.Item("Person_ID"), Integer))
                objStoredPerson.Name = rdrPerson.Item("Name").ToString
                objStoredPerson.Carbohydrates = CType(rdrPerson.Item("Carbohydrates"), Double)
                objStoredPerson.CurrentBloodSugar = CType(rdrPerson.Item("CurrentBloodSugar"), Double)
                objStoredPerson.InsulinToCarbRatio = CType(rdrPerson.Item("InsulinToCarbRatio"), Double)
                objStoredPerson.Meal = rdrPerson.Item("Meal").ToString
                objStoredPerson.FormulaOutput = rdrPerson.Item("FormulaOutput").ToString
                objStoredPerson.DoseDateGiven = CType(rdrPerson.Item("Date"), DateTime)


                lstPersons.Add(objStoredPerson)
            End While
        End If

        dbConnection.Close()
        dbConnection.Dispose()
    End Sub

    Private Sub LbxPersons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxPersons.SelectedIndexChanged
        If lbxPersons.SelectedIndex >= 0 Then

            Dim objSelectedPerson As Person = CType(lbxPersons.SelectedItem, Person)
            MessageBox.Show(objSelectedPerson.Name)

            'Populate Display with selected Person
            lblPersonIDOutput.Text = objSelectedPerson.PersonID.ToString
            lblNameOutput.Text = objSelectedPerson.Name
            lblCarbohydratesOutput.Text = objSelectedPerson.Carbohydrates.ToString
            lblCurrentBloodSugarOutput.Text = objSelectedPerson.CurrentBloodSugar.ToString
            lblInsulinToCarbRatioOutput.Text = objSelectedPerson.InsulinToCarbRatio.ToString
            lblMealDisplayOutput.Text = objSelectedPerson.Meal
            lblDateOutput.Text = objSelectedPerson.DoseDateGiven.ToString
            lblInsulinOutput.Text = objSelectedPerson.InsulinUnitsToGive.ToString
            lblFormulaOutput.Text = FormulaCreate().ToString

            'Determine if this is an edit or delete
            Dim intResult As Integer = MessageBox.Show("Are you deleting this record?", "Person List", MessageBoxButtons.YesNo)
            If intResult = DialogResult.No Then
                btnSave.Text = "Update Person"
                lblPersonIDOutput.Enabled = False
            ElseIf intResult = DialogResult.Yes Then
                btnSave.Text = "Delete Person"
                lblPersonIDOutput.Enabled = False
            End If

        End If
    End Sub

    Private Function OpenDBConnection() As SqlConnection
        'Create a connection string
        'This give the full path into the bin/debug folder
        Dim strPath As String = Application.StartupPath
        Dim intPathLength As Integer = strPath.Length
        'This strips off the bin/debug folder to point into your project folder.
        strPath = strPath.Substring(0, intPathLength - 25)



        Dim strconnection As String = "Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=" + strPath + "DiabetesInformation.mdf"

        'Create a Connection object
        Dim dbConnection As New SqlConnection(strconnection)

        Try
            'Open Database
            dbConnection.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
        Return dbConnection
    End Function

    Public Sub InsertPerson()
        'Open Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create Sql String
        Dim strSQL = "Insert into Person_Tbl (Name,Carbohydrates,CurrentBloodSugar,InsulinToCarbRatio,Meal,InsulinUnitToGive,FormulaOutput,Date) values (@Name,@Carbohydrates,@CurrentBloodSugar,@InsulinToCarbRatio,@Meal,@InsulinUnitToGive,@FormulaOutput,@Date)"
        'Create Command 
        Dim cmdInsert As New SqlCommand(strSQL, dbConnection)

        'Populate the Parameters of the Insert
        cmdInsert.Parameters.AddWithValue("Name", lstPersons.Last.Name)
        cmdInsert.Parameters.AddWithValue("Carbohydrates", lstPersons.Last.Carbohydrates)
        cmdInsert.Parameters.AddWithValue("CurrentBloodSugar", lstPersons.Last.CurrentBloodSugar)
        cmdInsert.Parameters.AddWithValue("InsulinToCarbRatio", lstPersons.Last.InsulinToCarbRatio)
        cmdInsert.Parameters.AddWithValue("Meal", lstPersons.Last.Meal)
        cmdInsert.Parameters.AddWithValue("InsulinUnitToGive", lstPersons.Last.InsulinUnitsToGive)
        cmdInsert.Parameters.AddWithValue("FormulaOutput", lstPersons.Last.FormulaOutput)
        cmdInsert.Parameters.AddWithValue("Date", lstPersons.Last.DoseDateGiven)

        Try
            Dim intRowsAffected = cmdInsert.ExecuteNonQuery()
            If intRowsAffected = 1 Then
                MessageBox.Show(lstPersons.Last.Name & " was inserted.")
            Else
                MessageBox.Show("The insert failed.")
            End If

        Catch ex As Exception
            MessageBox.Show("DB Insert Failed" & ex.Message)
        End Try


    End Sub

    Public Sub UpdatePerson()
        'Open Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create Sql String
        Dim strSQL = "Update Person_Tbl set Name ='" & txtName.Text & "',Carbohydrates = '" & txtCarbs.Text & "',CurrentBloodSugar='" & txtCurrentBloodSugar.Text & "',InsulinToCarbRatio='" & txtInsulinToCarbRatio.Text & "',Meal='" & txtMeal.Text & "',InsulinUnitToGive='" & lblInsulinOutput.Text & "',FormulaOutput='" & lblFormulaOutput.Text & "',Date'" & lblDateOutput.Text & "' Where Person_ID = '" & lblPersonIDOutput.Text & "'"
        MessageBox.Show(strSQL)
        'Create Command 
        Dim cmdUpdate As New SqlCommand(strSQL, dbConnection)



        Try
            Dim intRowsAffected = cmdUpdate.ExecuteNonQuery()
            If intRowsAffected = 1 Then
                MessageBox.Show(objPerson.PersonID & " was updated.")
            Else
                MessageBox.Show("The update failed.")
            End If

        Catch ex As Exception
            MessageBox.Show("DB update Failed" & ex.Message)
        End Try

        Reload_lbxPersons()
    End Sub

    Private Sub DeletePerson()
        'Open Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create Sql String
        Dim strSQL = "Delete from Person_Tbl where Person_ID = '" & objPerson.PersonID & "'"
        MessageBox.Show(strSQL)
        'Create Command 
        Dim cmdDelete As New SqlCommand(strSQL, dbConnection)



        Try
            Dim intRowsAffected = cmdDelete.ExecuteNonQuery()
            If intRowsAffected = 1 Then
                MessageBox.Show("Record was deleted.")
            Else
                MessageBox.Show("The delete failed.")
            End If

        Catch ex As Exception
            MessageBox.Show("DB delete Failed" & ex.Message)
        End Try

        Reload_lbxPersons()
        ClearInput()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInput()
    End Sub

    Private Sub ClearInput()
        lblPersonIDOutput.Text = String.Empty
        txtName.Text = String.Empty
        txtCarbs.Text = String.Empty
        txtCurrentBloodSugar.Text = String.Empty
        txtInsulinToCarbRatio.Text = String.Empty
        txtMeal.Text = String.Empty

        btnSave.Text = "Save Person"
        lblPersonIDOutput.Enabled = True
    End Sub


End Class
