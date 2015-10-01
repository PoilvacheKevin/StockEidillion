<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Acceuil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LB_Name = New System.Windows.Forms.Label()
        Me.LB_Password = New System.Windows.Forms.Label()
        Me.BT_Valider = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(97, 81)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(97, 156)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        '
        'LB_Name
        '
        Me.LB_Name.AutoSize = True
        Me.LB_Name.Location = New System.Drawing.Point(105, 56)
        Me.LB_Name.Name = "LB_Name"
        Me.LB_Name.Size = New System.Drawing.Size(92, 13)
        Me.LB_Name.TabIndex = 2
        Me.LB_Name.Text = "Nom d'Utilisateur :"
        '
        'LB_Password
        '
        Me.LB_Password.AutoSize = True
        Me.LB_Password.Location = New System.Drawing.Point(108, 131)
        Me.LB_Password.Name = "LB_Password"
        Me.LB_Password.Size = New System.Drawing.Size(78, 13)
        Me.LB_Password.TabIndex = 3
        Me.LB_Password.Text = "Mot de Passe :"
        '
        'BT_Valider
        '
        Me.BT_Valider.Location = New System.Drawing.Point(108, 194)
        Me.BT_Valider.Name = "BT_Valider"
        Me.BT_Valider.Size = New System.Drawing.Size(75, 23)
        Me.BT_Valider.TabIndex = 4
        Me.BT_Valider.Text = "Valider"
        Me.BT_Valider.UseVisualStyleBackColor = True
        '
        'Form_Acceuil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.BT_Valider)
        Me.Controls.Add(Me.LB_Password)
        Me.Controls.Add(Me.LB_Name)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form_Acceuil"
        Me.Text = "Acceuil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents LB_Name As System.Windows.Forms.Label
    Friend WithEvents LB_Password As System.Windows.Forms.Label
    Friend WithEvents BT_Valider As System.Windows.Forms.Button

End Class
