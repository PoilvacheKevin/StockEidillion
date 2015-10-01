<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Stocks
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
        Me.TabC_Stock = New System.Windows.Forms.TabControl()
        Me.TP_Home = New System.Windows.Forms.TabPage()
        Me.TP_StockShow = New System.Windows.Forms.TabPage()
        Me.TP_Provider = New System.Windows.Forms.TabPage()
        Me.TP_Client = New System.Windows.Forms.TabPage()
        Me.TP_Estimation = New System.Windows.Forms.TabPage()
        Me.TabC_Stock.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabC_Stock
        '
        Me.TabC_Stock.Controls.Add(Me.TP_Home)
        Me.TabC_Stock.Controls.Add(Me.TP_StockShow)
        Me.TabC_Stock.Controls.Add(Me.TP_Provider)
        Me.TabC_Stock.Controls.Add(Me.TP_Client)
        Me.TabC_Stock.Controls.Add(Me.TP_Estimation)
        Me.TabC_Stock.HotTrack = True
        Me.TabC_Stock.ItemSize = New System.Drawing.Size(140, 18)
        Me.TabC_Stock.Location = New System.Drawing.Point(0, 0)
        Me.TabC_Stock.Name = "TabC_Stock"
        Me.TabC_Stock.SelectedIndex = 0
        Me.TabC_Stock.Size = New System.Drawing.Size(1449, 682)
        Me.TabC_Stock.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabC_Stock.TabIndex = 0
        '
        'TP_Home
        '
        Me.TP_Home.Location = New System.Drawing.Point(4, 22)
        Me.TP_Home.Name = "TP_Home"
        Me.TP_Home.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_Home.Size = New System.Drawing.Size(1441, 656)
        Me.TP_Home.TabIndex = 0
        Me.TP_Home.Text = "Acceuil"
        Me.TP_Home.UseVisualStyleBackColor = True
        '
        'TP_StockShow
        '
        Me.TP_StockShow.Location = New System.Drawing.Point(4, 22)
        Me.TP_StockShow.Name = "TP_StockShow"
        Me.TP_StockShow.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_StockShow.Size = New System.Drawing.Size(1441, 656)
        Me.TP_StockShow.TabIndex = 1
        Me.TP_StockShow.Text = "Stock Actuel"
        Me.TP_StockShow.UseVisualStyleBackColor = True
        '
        'TP_Provider
        '
        Me.TP_Provider.Location = New System.Drawing.Point(4, 22)
        Me.TP_Provider.Name = "TP_Provider"
        Me.TP_Provider.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_Provider.Size = New System.Drawing.Size(1441, 656)
        Me.TP_Provider.TabIndex = 2
        Me.TP_Provider.Text = "Commandes Fournisseurs"
        Me.TP_Provider.UseVisualStyleBackColor = True
        '
        'TP_Client
        '
        Me.TP_Client.Location = New System.Drawing.Point(4, 22)
        Me.TP_Client.Name = "TP_Client"
        Me.TP_Client.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_Client.Size = New System.Drawing.Size(1441, 656)
        Me.TP_Client.TabIndex = 3
        Me.TP_Client.Text = "Commandes Clients"
        Me.TP_Client.UseVisualStyleBackColor = True
        '
        'TP_Estimation
        '
        Me.TP_Estimation.Location = New System.Drawing.Point(4, 22)
        Me.TP_Estimation.Name = "TP_Estimation"
        Me.TP_Estimation.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_Estimation.Size = New System.Drawing.Size(1441, 656)
        Me.TP_Estimation.TabIndex = 4
        Me.TP_Estimation.Text = "Stock Estimation"
        Me.TP_Estimation.UseVisualStyleBackColor = True
        '
        'Form_Stocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1294, 625)
        Me.Controls.Add(Me.TabC_Stock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form_Stocks"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Gestionnaire du Stock"
        Me.TabC_Stock.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabC_Stock As System.Windows.Forms.TabControl
    Friend WithEvents TP_Home As System.Windows.Forms.TabPage
    Friend WithEvents TP_StockShow As System.Windows.Forms.TabPage
    Friend WithEvents TP_Provider As System.Windows.Forms.TabPage
    Friend WithEvents TP_Client As System.Windows.Forms.TabPage
    Friend WithEvents TP_Estimation As System.Windows.Forms.TabPage
End Class
