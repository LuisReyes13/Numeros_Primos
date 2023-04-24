Imports System.Reflection
Imports System.Reflection.Emit

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Try
            validarPrimo()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub validarPrimo()
        Try
            Dim numero As Integer = Val(TextBox1.Text)
            Dim esPrimo As Boolean = True
            If numero <= 1 Then
                esPrimo = False
            Else
                For i As Integer = 2 To Math.Sqrt(numero)
                    If numero Mod i = 0 Then
                        esPrimo = False
                        Exit For
                    End If
                Next
            End If

            If esPrimo Then
                LblPrimo.Text = $"{numero} Si, es primo"
            Else
                LblPrimo.Text = $"{numero} No, es primo"
            End If
            TextBox1.Clear()
            TextBox1.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                validarPrimo()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
