<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BtnCalcular = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        LblPrimo = New Label()
        SuspendLayout()
        ' 
        ' BtnCalcular
        ' 
        BtnCalcular.Location = New Point(152, 120)
        BtnCalcular.Name = "BtnCalcular"
        BtnCalcular.Size = New Size(112, 34)
        BtnCalcular.TabIndex = 1
        BtnCalcular.Text = "Calcular"
        BtnCalcular.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(197, 29)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 0
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(28, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(163, 25)
        Label1.TabIndex = 2
        Label1.Text = "Escribe un numero:"
        ' 
        ' LblPrimo
        ' 
        LblPrimo.Location = New Point(28, 68)
        LblPrimo.Name = "LblPrimo"
        LblPrimo.Size = New Size(319, 33)
        LblPrimo.TabIndex = 3
        LblPrimo.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(424, 194)
        Controls.Add(LblPrimo)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(BtnCalcular)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Numeros Primos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnCalcular As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblPrimo As Label
End Class
