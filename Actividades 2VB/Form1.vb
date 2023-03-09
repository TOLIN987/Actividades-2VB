Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ltvData.View = View.Details

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtDescription.Text = "" OrElse txtName.Text = "" OrElse txtPrice.Text = "" OrElse dudCategory.Text = Nothing OrElse nudQuantity.Value = 0 Then
            MessageBox.Show("Fill in all the fields")
            txtName.Clear()
            txtPrice.Clear()
            txtDescription.Clear()
            dudCategory.Refresh()
            nudQuantity.Update()
            Return
        End If
        Dim products As New Product(txtName.Text, txtPrice.Text, nudQuantity.Value, dudCategory.Text, txtDescription.Text)
        Dim row As String() = products.ToString().Split(","c)
        ltvData.Items.Add(New ListViewItem(row))
        txtDescription.Clear()
        txtName.Clear()
        txtPrice.Clear()
        dudCategory.Refresh()
        nudQuantity.Update()
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        Dim character As Char = e.KeyChar
        If Char.IsLetter(character) OrElse Not Char.IsDigit(character) OrElse Not (character <> "."c) Then
            e.Handled = True
        End If
        If character = "."c AndAlso (CType(sender, TextBox).Text.IndexOf("."c) > -1) Then
            e.Handled = True
        End If
    End Sub


End Class
