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
        Me.TB_LastDeliveryClient = New System.Windows.Forms.TextBox()
        Me.LB_LastDeliveryClient = New System.Windows.Forms.Label()
        Me.LB_InOutPut = New System.Windows.Forms.Label()
        Me.LV_InOutPut = New System.Windows.Forms.ListView()
        Me.TB_LastDeliveryProvider = New System.Windows.Forms.TextBox()
        Me.TB_EstimationValueStock = New System.Windows.Forms.TextBox()
        Me.LB_LastDeliveryProviderLabel = New System.Windows.Forms.Label()
        Me.LB_TextEstimation = New System.Windows.Forms.Label()
        Me.LB_StockLive = New System.Windows.Forms.Label()
        Me.LV_StockLive = New System.Windows.Forms.ListView()
        Me.TP_Provider = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LB_DateEstimationDeliveryProvider = New System.Windows.Forms.Label()
        Me.LB_DeliveryLastTime = New System.Windows.Forms.Label()
        Me.TP_Client = New System.Windows.Forms.TabPage()
        Me.TP_Estimation = New System.Windows.Forms.TabPage()
        Me.TB_LastDeliveryEffective = New System.Windows.Forms.TextBox()
        Me.TB_EstimationDateDeliveryProvider = New System.Windows.Forms.TextBox()
        Me.LB_RéfConfirm = New System.Windows.Forms.Label()
        Me.LB_DateConfirm = New System.Windows.Forms.Label()
        Me.LB_ProviderConfirm = New System.Windows.Forms.Label()
        Me.TB_ConfirmRefDelivery = New System.Windows.Forms.TextBox()
        Me.TB_ConfirmDateDelivery = New System.Windows.Forms.TextBox()
        Me.TB_ConfirmProviderDelivery = New System.Windows.Forms.TextBox()
        Me.BT_ConfirmFinishDelivery = New System.Windows.Forms.Button()
        Me.LB_NewRefDeliveryProvider = New System.Windows.Forms.Label()
        Me.LB_NewDateDeliveryProvider = New System.Windows.Forms.Label()
        Me.LB_NewProviderDeliveryProvider = New System.Windows.Forms.Label()
        Me.TB_NewRefProvider = New System.Windows.Forms.TextBox()
        Me.TB_NewDateProvider = New System.Windows.Forms.TextBox()
        Me.TB_NewNewProvider = New System.Windows.Forms.TextBox()
        Me.LB_NewProductDeliveryProvider = New System.Windows.Forms.Label()
        Me.LB_NewQuantityDeliveryProvider = New System.Windows.Forms.Label()
        Me.LB_NewPriceDeliveryProvider = New System.Windows.Forms.Label()
        Me.TB_NewProductDeliveryProvider = New System.Windows.Forms.TextBox()
        Me.TB_NewQuantityDeliveryProvider = New System.Windows.Forms.TextBox()
        Me.TB_NewPriceDeliveryProvider = New System.Windows.Forms.TextBox()
        Me.LV_ProductsAddDeliveryProvider = New System.Windows.Forms.ListView()
        Me.BT_AcceptDeliveryProvider = New System.Windows.Forms.Button()
        Me.BT_DeleteDeliveryProvider = New System.Windows.Forms.Button()
        Me.LV_CurrentDeliveries = New System.Windows.Forms.ListView()
        Me.LB_CurrentDeliveryProvider = New System.Windows.Forms.Label()
        Me.TabC_Stock.SuspendLayout()
        Me.TP_StockShow.SuspendLayout()
        Me.TP_Provider.SuspendLayout()
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
        Me.TP_StockShow.Controls.Add(Me.TB_LastDeliveryClient)
        Me.TP_StockShow.Controls.Add(Me.LB_LastDeliveryClient)
        Me.TP_StockShow.Controls.Add(Me.LB_InOutPut)
        Me.TP_StockShow.Controls.Add(Me.LV_InOutPut)
        Me.TP_StockShow.Controls.Add(Me.TB_LastDeliveryProvider)
        Me.TP_StockShow.Controls.Add(Me.TB_EstimationValueStock)
        Me.TP_StockShow.Controls.Add(Me.LB_LastDeliveryProviderLabel)
        Me.TP_StockShow.Controls.Add(Me.LB_TextEstimation)
        Me.TP_StockShow.Controls.Add(Me.LB_StockLive)
        Me.TP_StockShow.Controls.Add(Me.LV_StockLive)
        Me.TP_StockShow.Location = New System.Drawing.Point(4, 22)
        Me.TP_StockShow.Name = "TP_StockShow"
        Me.TP_StockShow.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_StockShow.Size = New System.Drawing.Size(1441, 656)
        Me.TP_StockShow.TabIndex = 1
        Me.TP_StockShow.Text = "Stock Actuel"
        Me.TP_StockShow.UseVisualStyleBackColor = True
        '
        'TB_LastDeliveryClient
        '
        Me.TB_LastDeliveryClient.Enabled = False
        Me.TB_LastDeliveryClient.Location = New System.Drawing.Point(184, 82)
        Me.TB_LastDeliveryClient.Name = "TB_LastDeliveryClient"
        Me.TB_LastDeliveryClient.Size = New System.Drawing.Size(100, 20)
        Me.TB_LastDeliveryClient.TabIndex = 8
        '
        'LB_LastDeliveryClient
        '
        Me.LB_LastDeliveryClient.AutoSize = True
        Me.LB_LastDeliveryClient.Location = New System.Drawing.Point(6, 85)
        Me.LB_LastDeliveryClient.Name = "LB_LastDeliveryClient"
        Me.LB_LastDeliveryClient.Size = New System.Drawing.Size(172, 13)
        Me.LB_LastDeliveryClient.TabIndex = 7
        Me.LB_LastDeliveryClient.Text = "Date de la dernière livraison client :"
        '
        'LB_InOutPut
        '
        Me.LB_InOutPut.AutoSize = True
        Me.LB_InOutPut.Location = New System.Drawing.Point(891, 168)
        Me.LB_InOutPut.Name = "LB_InOutPut"
        Me.LB_InOutPut.Size = New System.Drawing.Size(76, 13)
        Me.LB_InOutPut.TabIndex = 6
        Me.LB_InOutPut.Text = "InPut/OutPut :"
        '
        'LV_InOutPut
        '
        Me.LV_InOutPut.Location = New System.Drawing.Point(644, 198)
        Me.LV_InOutPut.Name = "LV_InOutPut"
        Me.LV_InOutPut.Size = New System.Drawing.Size(621, 393)
        Me.LV_InOutPut.TabIndex = 5
        Me.LV_InOutPut.UseCompatibleStateImageBehavior = False
        '
        'TB_LastDeliveryProvider
        '
        Me.TB_LastDeliveryProvider.Enabled = False
        Me.TB_LastDeliveryProvider.Location = New System.Drawing.Point(212, 50)
        Me.TB_LastDeliveryProvider.Name = "TB_LastDeliveryProvider"
        Me.TB_LastDeliveryProvider.Size = New System.Drawing.Size(100, 20)
        Me.TB_LastDeliveryProvider.TabIndex = 2
        '
        'TB_EstimationValueStock
        '
        Me.TB_EstimationValueStock.Enabled = False
        Me.TB_EstimationValueStock.Location = New System.Drawing.Point(143, 18)
        Me.TB_EstimationValueStock.Name = "TB_EstimationValueStock"
        Me.TB_EstimationValueStock.Size = New System.Drawing.Size(100, 20)
        Me.TB_EstimationValueStock.TabIndex = 0
        '
        'LB_LastDeliveryProviderLabel
        '
        Me.LB_LastDeliveryProviderLabel.AutoSize = True
        Me.LB_LastDeliveryProviderLabel.Location = New System.Drawing.Point(8, 53)
        Me.LB_LastDeliveryProviderLabel.Name = "LB_LastDeliveryProviderLabel"
        Me.LB_LastDeliveryProviderLabel.Size = New System.Drawing.Size(198, 13)
        Me.LB_LastDeliveryProviderLabel.TabIndex = 4
        Me.LB_LastDeliveryProviderLabel.Text = "Date de la dernière livraison fournisseur :"
        '
        'LB_TextEstimation
        '
        Me.LB_TextEstimation.AutoSize = True
        Me.LB_TextEstimation.Location = New System.Drawing.Point(8, 21)
        Me.LB_TextEstimation.Name = "LB_TextEstimation"
        Me.LB_TextEstimation.Size = New System.Drawing.Size(129, 13)
        Me.LB_TextEstimation.TabIndex = 2
        Me.LB_TextEstimation.Text = "Valeur Estimée du Stock :"
        '
        'LB_StockLive
        '
        Me.LB_StockLive.AutoSize = True
        Me.LB_StockLive.Location = New System.Drawing.Point(268, 168)
        Me.LB_StockLive.Name = "LB_StockLive"
        Me.LB_StockLive.Size = New System.Drawing.Size(73, 13)
        Me.LB_StockLive.TabIndex = 1
        Me.LB_StockLive.Text = "Stock actuel :"
        '
        'LV_StockLive
        '
        Me.LV_StockLive.Location = New System.Drawing.Point(11, 198)
        Me.LV_StockLive.Name = "LV_StockLive"
        Me.LV_StockLive.Size = New System.Drawing.Size(627, 393)
        Me.LV_StockLive.TabIndex = 0
        Me.LV_StockLive.UseCompatibleStateImageBehavior = False
        '
        'TP_Provider
        '
        Me.TP_Provider.Controls.Add(Me.LB_CurrentDeliveryProvider)
        Me.TP_Provider.Controls.Add(Me.LV_CurrentDeliveries)
        Me.TP_Provider.Controls.Add(Me.BT_DeleteDeliveryProvider)
        Me.TP_Provider.Controls.Add(Me.BT_AcceptDeliveryProvider)
        Me.TP_Provider.Controls.Add(Me.LV_ProductsAddDeliveryProvider)
        Me.TP_Provider.Controls.Add(Me.TB_NewPriceDeliveryProvider)
        Me.TP_Provider.Controls.Add(Me.TB_NewQuantityDeliveryProvider)
        Me.TP_Provider.Controls.Add(Me.TB_NewProductDeliveryProvider)
        Me.TP_Provider.Controls.Add(Me.LB_NewPriceDeliveryProvider)
        Me.TP_Provider.Controls.Add(Me.LB_NewQuantityDeliveryProvider)
        Me.TP_Provider.Controls.Add(Me.LB_NewProductDeliveryProvider)
        Me.TP_Provider.Controls.Add(Me.TB_NewNewProvider)
        Me.TP_Provider.Controls.Add(Me.TB_NewDateProvider)
        Me.TP_Provider.Controls.Add(Me.TB_NewRefProvider)
        Me.TP_Provider.Controls.Add(Me.LB_NewProviderDeliveryProvider)
        Me.TP_Provider.Controls.Add(Me.LB_NewDateDeliveryProvider)
        Me.TP_Provider.Controls.Add(Me.LB_NewRefDeliveryProvider)
        Me.TP_Provider.Controls.Add(Me.BT_ConfirmFinishDelivery)
        Me.TP_Provider.Controls.Add(Me.TB_ConfirmProviderDelivery)
        Me.TP_Provider.Controls.Add(Me.TB_ConfirmDateDelivery)
        Me.TP_Provider.Controls.Add(Me.TB_ConfirmRefDelivery)
        Me.TP_Provider.Controls.Add(Me.LB_ProviderConfirm)
        Me.TP_Provider.Controls.Add(Me.LB_DateConfirm)
        Me.TP_Provider.Controls.Add(Me.LB_RéfConfirm)
        Me.TP_Provider.Controls.Add(Me.TB_EstimationDateDeliveryProvider)
        Me.TP_Provider.Controls.Add(Me.TB_LastDeliveryEffective)
        Me.TP_Provider.Controls.Add(Me.Label2)
        Me.TP_Provider.Controls.Add(Me.LB_DateEstimationDeliveryProvider)
        Me.TP_Provider.Controls.Add(Me.LB_DeliveryLastTime)
        Me.TP_Provider.Location = New System.Drawing.Point(4, 22)
        Me.TP_Provider.Name = "TP_Provider"
        Me.TP_Provider.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_Provider.Size = New System.Drawing.Size(1441, 656)
        Me.TP_Provider.TabIndex = 2
        Me.TP_Provider.Text = "Commandes Fournisseurs"
        Me.TP_Provider.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 2
        '
        'LB_DateEstimationDeliveryProvider
        '
        Me.LB_DateEstimationDeliveryProvider.AutoSize = True
        Me.LB_DateEstimationDeliveryProvider.Location = New System.Drawing.Point(8, 39)
        Me.LB_DateEstimationDeliveryProvider.Name = "LB_DateEstimationDeliveryProvider"
        Me.LB_DateEstimationDeliveryProvider.Size = New System.Drawing.Size(198, 13)
        Me.LB_DateEstimationDeliveryProvider.TabIndex = 1
        Me.LB_DateEstimationDeliveryProvider.Text = "Date Estimée de la Prochaine Livraison :"
        '
        'LB_DeliveryLastTime
        '
        Me.LB_DeliveryLastTime.AutoSize = True
        Me.LB_DeliveryLastTime.Location = New System.Drawing.Point(8, 8)
        Me.LB_DeliveryLastTime.Name = "LB_DeliveryLastTime"
        Me.LB_DeliveryLastTime.Size = New System.Drawing.Size(146, 13)
        Me.LB_DeliveryLastTime.TabIndex = 0
        Me.LB_DeliveryLastTime.Text = "Dernière Livraison effectuée :"
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
        'TB_LastDeliveryEffective
        '
        Me.TB_LastDeliveryEffective.Enabled = False
        Me.TB_LastDeliveryEffective.Location = New System.Drawing.Point(160, 6)
        Me.TB_LastDeliveryEffective.Name = "TB_LastDeliveryEffective"
        Me.TB_LastDeliveryEffective.Size = New System.Drawing.Size(100, 20)
        Me.TB_LastDeliveryEffective.TabIndex = 3
        '
        'TB_EstimationDateDeliveryProvider
        '
        Me.TB_EstimationDateDeliveryProvider.Enabled = False
        Me.TB_EstimationDateDeliveryProvider.Location = New System.Drawing.Point(212, 36)
        Me.TB_EstimationDateDeliveryProvider.Name = "TB_EstimationDateDeliveryProvider"
        Me.TB_EstimationDateDeliveryProvider.Size = New System.Drawing.Size(100, 20)
        Me.TB_EstimationDateDeliveryProvider.TabIndex = 4
        '
        'LB_RéfConfirm
        '
        Me.LB_RéfConfirm.AutoSize = True
        Me.LB_RéfConfirm.Location = New System.Drawing.Point(10, 71)
        Me.LB_RéfConfirm.Name = "LB_RéfConfirm"
        Me.LB_RéfConfirm.Size = New System.Drawing.Size(154, 13)
        Me.LB_RéfConfirm.TabIndex = 5
        Me.LB_RéfConfirm.Text = "Réf. Commande Sélectionnée :"
        '
        'LB_DateConfirm
        '
        Me.LB_DateConfirm.AutoSize = True
        Me.LB_DateConfirm.Location = New System.Drawing.Point(327, 71)
        Me.LB_DateConfirm.Name = "LB_DateConfirm"
        Me.LB_DateConfirm.Size = New System.Drawing.Size(96, 13)
        Me.LB_DateConfirm.TabIndex = 6
        Me.LB_DateConfirm.Text = "Date de Livraison :"
        '
        'LB_ProviderConfirm
        '
        Me.LB_ProviderConfirm.AutoSize = True
        Me.LB_ProviderConfirm.Location = New System.Drawing.Point(572, 71)
        Me.LB_ProviderConfirm.Name = "LB_ProviderConfirm"
        Me.LB_ProviderConfirm.Size = New System.Drawing.Size(67, 13)
        Me.LB_ProviderConfirm.TabIndex = 7
        Me.LB_ProviderConfirm.Text = "Fournisseur :"
        '
        'TB_ConfirmRefDelivery
        '
        Me.TB_ConfirmRefDelivery.Location = New System.Drawing.Point(170, 68)
        Me.TB_ConfirmRefDelivery.Name = "TB_ConfirmRefDelivery"
        Me.TB_ConfirmRefDelivery.Size = New System.Drawing.Size(151, 20)
        Me.TB_ConfirmRefDelivery.TabIndex = 8
        '
        'TB_ConfirmDateDelivery
        '
        Me.TB_ConfirmDateDelivery.Location = New System.Drawing.Point(429, 68)
        Me.TB_ConfirmDateDelivery.Name = "TB_ConfirmDateDelivery"
        Me.TB_ConfirmDateDelivery.Size = New System.Drawing.Size(133, 20)
        Me.TB_ConfirmDateDelivery.TabIndex = 9
        '
        'TB_ConfirmProviderDelivery
        '
        Me.TB_ConfirmProviderDelivery.Location = New System.Drawing.Point(645, 68)
        Me.TB_ConfirmProviderDelivery.Name = "TB_ConfirmProviderDelivery"
        Me.TB_ConfirmProviderDelivery.Size = New System.Drawing.Size(126, 20)
        Me.TB_ConfirmProviderDelivery.TabIndex = 10
        '
        'BT_ConfirmFinishDelivery
        '
        Me.BT_ConfirmFinishDelivery.Location = New System.Drawing.Point(792, 57)
        Me.BT_ConfirmFinishDelivery.Name = "BT_ConfirmFinishDelivery"
        Me.BT_ConfirmFinishDelivery.Size = New System.Drawing.Size(75, 41)
        Me.BT_ConfirmFinishDelivery.TabIndex = 11
        Me.BT_ConfirmFinishDelivery.Text = "Confirmer Arrivée"
        Me.BT_ConfirmFinishDelivery.UseVisualStyleBackColor = True
        '
        'LB_NewRefDeliveryProvider
        '
        Me.LB_NewRefDeliveryProvider.AutoSize = True
        Me.LB_NewRefDeliveryProvider.Location = New System.Drawing.Point(20, 159)
        Me.LB_NewRefDeliveryProvider.Name = "LB_NewRefDeliveryProvider"
        Me.LB_NewRefDeliveryProvider.Size = New System.Drawing.Size(134, 13)
        Me.LB_NewRefDeliveryProvider.TabIndex = 12
        Me.LB_NewRefDeliveryProvider.Text = "Réf. Nouvelle Commande :"
        '
        'LB_NewDateDeliveryProvider
        '
        Me.LB_NewDateDeliveryProvider.AutoSize = True
        Me.LB_NewDateDeliveryProvider.Location = New System.Drawing.Point(185, 159)
        Me.LB_NewDateDeliveryProvider.Name = "LB_NewDateDeliveryProvider"
        Me.LB_NewDateDeliveryProvider.Size = New System.Drawing.Size(136, 13)
        Me.LB_NewDateDeliveryProvider.TabIndex = 13
        Me.LB_NewDateDeliveryProvider.Text = "Date de Livraison Estimée :"
        '
        'LB_NewProviderDeliveryProvider
        '
        Me.LB_NewProviderDeliveryProvider.AutoSize = True
        Me.LB_NewProviderDeliveryProvider.Location = New System.Drawing.Point(374, 159)
        Me.LB_NewProviderDeliveryProvider.Name = "LB_NewProviderDeliveryProvider"
        Me.LB_NewProviderDeliveryProvider.Size = New System.Drawing.Size(67, 13)
        Me.LB_NewProviderDeliveryProvider.TabIndex = 14
        Me.LB_NewProviderDeliveryProvider.Text = "Fournisseur :"
        '
        'TB_NewRefProvider
        '
        Me.TB_NewRefProvider.Location = New System.Drawing.Point(13, 183)
        Me.TB_NewRefProvider.Name = "TB_NewRefProvider"
        Me.TB_NewRefProvider.Size = New System.Drawing.Size(151, 20)
        Me.TB_NewRefProvider.TabIndex = 15
        '
        'TB_NewDateProvider
        '
        Me.TB_NewDateProvider.Location = New System.Drawing.Point(188, 183)
        Me.TB_NewDateProvider.Name = "TB_NewDateProvider"
        Me.TB_NewDateProvider.Size = New System.Drawing.Size(133, 20)
        Me.TB_NewDateProvider.TabIndex = 16
        '
        'TB_NewNewProvider
        '
        Me.TB_NewNewProvider.Location = New System.Drawing.Point(345, 183)
        Me.TB_NewNewProvider.Name = "TB_NewNewProvider"
        Me.TB_NewNewProvider.Size = New System.Drawing.Size(126, 20)
        Me.TB_NewNewProvider.TabIndex = 17
        '
        'LB_NewProductDeliveryProvider
        '
        Me.LB_NewProductDeliveryProvider.AutoSize = True
        Me.LB_NewProductDeliveryProvider.Location = New System.Drawing.Point(31, 229)
        Me.LB_NewProductDeliveryProvider.Name = "LB_NewProductDeliveryProvider"
        Me.LB_NewProductDeliveryProvider.Size = New System.Drawing.Size(46, 13)
        Me.LB_NewProductDeliveryProvider.TabIndex = 18
        Me.LB_NewProductDeliveryProvider.Text = "Produit :"
        '
        'LB_NewQuantityDeliveryProvider
        '
        Me.LB_NewQuantityDeliveryProvider.AutoSize = True
        Me.LB_NewQuantityDeliveryProvider.Location = New System.Drawing.Point(157, 229)
        Me.LB_NewQuantityDeliveryProvider.Name = "LB_NewQuantityDeliveryProvider"
        Me.LB_NewQuantityDeliveryProvider.Size = New System.Drawing.Size(56, 13)
        Me.LB_NewQuantityDeliveryProvider.TabIndex = 19
        Me.LB_NewQuantityDeliveryProvider.Text = "Quantité : "
        '
        'LB_NewPriceDeliveryProvider
        '
        Me.LB_NewPriceDeliveryProvider.AutoSize = True
        Me.LB_NewPriceDeliveryProvider.Location = New System.Drawing.Point(282, 229)
        Me.LB_NewPriceDeliveryProvider.Name = "LB_NewPriceDeliveryProvider"
        Me.LB_NewPriceDeliveryProvider.Size = New System.Drawing.Size(30, 13)
        Me.LB_NewPriceDeliveryProvider.TabIndex = 20
        Me.LB_NewPriceDeliveryProvider.Text = "Prix :"
        '
        'TB_NewProductDeliveryProvider
        '
        Me.TB_NewProductDeliveryProvider.Location = New System.Drawing.Point(3, 255)
        Me.TB_NewProductDeliveryProvider.Name = "TB_NewProductDeliveryProvider"
        Me.TB_NewProductDeliveryProvider.Size = New System.Drawing.Size(100, 20)
        Me.TB_NewProductDeliveryProvider.TabIndex = 21
        '
        'TB_NewQuantityDeliveryProvider
        '
        Me.TB_NewQuantityDeliveryProvider.Location = New System.Drawing.Point(123, 255)
        Me.TB_NewQuantityDeliveryProvider.Name = "TB_NewQuantityDeliveryProvider"
        Me.TB_NewQuantityDeliveryProvider.Size = New System.Drawing.Size(100, 20)
        Me.TB_NewQuantityDeliveryProvider.TabIndex = 22
        '
        'TB_NewPriceDeliveryProvider
        '
        Me.TB_NewPriceDeliveryProvider.Location = New System.Drawing.Point(246, 255)
        Me.TB_NewPriceDeliveryProvider.Name = "TB_NewPriceDeliveryProvider"
        Me.TB_NewPriceDeliveryProvider.Size = New System.Drawing.Size(100, 20)
        Me.TB_NewPriceDeliveryProvider.TabIndex = 23
        '
        'LV_ProductsAddDeliveryProvider
        '
        Me.LV_ProductsAddDeliveryProvider.Location = New System.Drawing.Point(6, 322)
        Me.LV_ProductsAddDeliveryProvider.Name = "LV_ProductsAddDeliveryProvider"
        Me.LV_ProductsAddDeliveryProvider.Size = New System.Drawing.Size(340, 269)
        Me.LV_ProductsAddDeliveryProvider.TabIndex = 24
        Me.LV_ProductsAddDeliveryProvider.UseCompatibleStateImageBehavior = False
        '
        'BT_AcceptDeliveryProvider
        '
        Me.BT_AcceptDeliveryProvider.Location = New System.Drawing.Point(70, 293)
        Me.BT_AcceptDeliveryProvider.Name = "BT_AcceptDeliveryProvider"
        Me.BT_AcceptDeliveryProvider.Size = New System.Drawing.Size(75, 23)
        Me.BT_AcceptDeliveryProvider.TabIndex = 25
        Me.BT_AcceptDeliveryProvider.Text = "Ajouter"
        Me.BT_AcceptDeliveryProvider.UseVisualStyleBackColor = True
        '
        'BT_DeleteDeliveryProvider
        '
        Me.BT_DeleteDeliveryProvider.Location = New System.Drawing.Point(199, 293)
        Me.BT_DeleteDeliveryProvider.Name = "BT_DeleteDeliveryProvider"
        Me.BT_DeleteDeliveryProvider.Size = New System.Drawing.Size(75, 23)
        Me.BT_DeleteDeliveryProvider.TabIndex = 26
        Me.BT_DeleteDeliveryProvider.Text = "Supprimer"
        Me.BT_DeleteDeliveryProvider.UseVisualStyleBackColor = True
        '
        'LV_CurrentDeliveries
        '
        Me.LV_CurrentDeliveries.Location = New System.Drawing.Point(590, 255)
        Me.LV_CurrentDeliveries.Name = "LV_CurrentDeliveries"
        Me.LV_CurrentDeliveries.Size = New System.Drawing.Size(675, 336)
        Me.LV_CurrentDeliveries.TabIndex = 27
        Me.LV_CurrentDeliveries.UseCompatibleStateImageBehavior = False
        '
        'LB_CurrentDeliveryProvider
        '
        Me.LB_CurrentDeliveryProvider.AutoSize = True
        Me.LB_CurrentDeliveryProvider.Location = New System.Drawing.Point(877, 229)
        Me.LB_CurrentDeliveryProvider.Name = "LB_CurrentDeliveryProvider"
        Me.LB_CurrentDeliveryProvider.Size = New System.Drawing.Size(106, 13)
        Me.LB_CurrentDeliveryProvider.TabIndex = 28
        Me.LB_CurrentDeliveryProvider.Text = "Livraisons En Cours :"
        '
        'Form_Stocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1281, 625)
        Me.Controls.Add(Me.TabC_Stock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form_Stocks"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Gestionnaire du Stock"
        Me.TabC_Stock.ResumeLayout(False)
        Me.TP_StockShow.ResumeLayout(False)
        Me.TP_StockShow.PerformLayout()
        Me.TP_Provider.ResumeLayout(False)
        Me.TP_Provider.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabC_Stock As System.Windows.Forms.TabControl
    Friend WithEvents TP_Home As System.Windows.Forms.TabPage
    Friend WithEvents TP_StockShow As System.Windows.Forms.TabPage
    Friend WithEvents TP_Provider As System.Windows.Forms.TabPage
    Friend WithEvents TP_Client As System.Windows.Forms.TabPage
    Friend WithEvents TP_Estimation As System.Windows.Forms.TabPage
    Friend WithEvents LB_StockLive As System.Windows.Forms.Label
    Friend WithEvents LV_StockLive As System.Windows.Forms.ListView
    Friend WithEvents TB_LastDeliveryProvider As System.Windows.Forms.TextBox
    Friend WithEvents TB_EstimationValueStock As System.Windows.Forms.TextBox
    Friend WithEvents LB_LastDeliveryProviderLabel As System.Windows.Forms.Label
    Friend WithEvents LB_TextEstimation As System.Windows.Forms.Label
    Friend WithEvents LB_InOutPut As System.Windows.Forms.Label
    Friend WithEvents LV_InOutPut As System.Windows.Forms.ListView
    Friend WithEvents TB_LastDeliveryClient As System.Windows.Forms.TextBox
    Friend WithEvents LB_LastDeliveryClient As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LB_DateEstimationDeliveryProvider As System.Windows.Forms.Label
    Friend WithEvents LB_DeliveryLastTime As System.Windows.Forms.Label
    Friend WithEvents TB_EstimationDateDeliveryProvider As System.Windows.Forms.TextBox
    Friend WithEvents TB_LastDeliveryEffective As System.Windows.Forms.TextBox
    Friend WithEvents TB_NewPriceDeliveryProvider As System.Windows.Forms.TextBox
    Friend WithEvents TB_NewQuantityDeliveryProvider As System.Windows.Forms.TextBox
    Friend WithEvents TB_NewProductDeliveryProvider As System.Windows.Forms.TextBox
    Friend WithEvents LB_NewPriceDeliveryProvider As System.Windows.Forms.Label
    Friend WithEvents LB_NewQuantityDeliveryProvider As System.Windows.Forms.Label
    Friend WithEvents LB_NewProductDeliveryProvider As System.Windows.Forms.Label
    Friend WithEvents TB_NewNewProvider As System.Windows.Forms.TextBox
    Friend WithEvents TB_NewDateProvider As System.Windows.Forms.TextBox
    Friend WithEvents TB_NewRefProvider As System.Windows.Forms.TextBox
    Friend WithEvents LB_NewProviderDeliveryProvider As System.Windows.Forms.Label
    Friend WithEvents LB_NewDateDeliveryProvider As System.Windows.Forms.Label
    Friend WithEvents LB_NewRefDeliveryProvider As System.Windows.Forms.Label
    Friend WithEvents BT_ConfirmFinishDelivery As System.Windows.Forms.Button
    Friend WithEvents TB_ConfirmProviderDelivery As System.Windows.Forms.TextBox
    Friend WithEvents TB_ConfirmDateDelivery As System.Windows.Forms.TextBox
    Friend WithEvents TB_ConfirmRefDelivery As System.Windows.Forms.TextBox
    Friend WithEvents LB_ProviderConfirm As System.Windows.Forms.Label
    Friend WithEvents LB_DateConfirm As System.Windows.Forms.Label
    Friend WithEvents LB_RéfConfirm As System.Windows.Forms.Label
    Friend WithEvents LB_CurrentDeliveryProvider As System.Windows.Forms.Label
    Friend WithEvents LV_CurrentDeliveries As System.Windows.Forms.ListView
    Friend WithEvents BT_DeleteDeliveryProvider As System.Windows.Forms.Button
    Friend WithEvents BT_AcceptDeliveryProvider As System.Windows.Forms.Button
    Friend WithEvents LV_ProductsAddDeliveryProvider As System.Windows.Forms.ListView
End Class
