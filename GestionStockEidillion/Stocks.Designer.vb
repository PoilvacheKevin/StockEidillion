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
        Me.TB_LastDeliveryClientLive = New System.Windows.Forms.TextBox()
        Me.LB_LastDeliveryClientLive = New System.Windows.Forms.Label()
        Me.LB_InOutPut = New System.Windows.Forms.Label()
        Me.LV_InOutPut = New System.Windows.Forms.ListView()
        Me.TB_LastDeliveryProvider = New System.Windows.Forms.TextBox()
        Me.TB_EstimationValueStock = New System.Windows.Forms.TextBox()
        Me.LB_LastDeliveryProviderLabel = New System.Windows.Forms.Label()
        Me.LB_TextEstimation = New System.Windows.Forms.Label()
        Me.LB_StockLive = New System.Windows.Forms.Label()
        Me.LV_StockLive = New System.Windows.Forms.ListView()
        Me.TP_Provider = New System.Windows.Forms.TabPage()
        Me.CB_NewNewProvider = New System.Windows.Forms.ComboBox()
        Me.BT_NewProductConfirm = New System.Windows.Forms.Button()
        Me.CB_NewProductProvider = New System.Windows.Forms.ComboBox()
        Me.LB_NewProductProvider = New System.Windows.Forms.Label()
        Me.TB_NewProductReference = New System.Windows.Forms.TextBox()
        Me.LB_NewProductReference = New System.Windows.Forms.Label()
        Me.TB_NewProductName = New System.Windows.Forms.TextBox()
        Me.LB_NewProductName = New System.Windows.Forms.Label()
        Me.CB_NewProductDeliveryProvider = New System.Windows.Forms.ComboBox()
        Me.BT_ConfirmNewDelivery = New System.Windows.Forms.Button()
        Me.LB_CurrentDeliveryProvider = New System.Windows.Forms.Label()
        Me.LV_CurrentDeliversiesProvider = New System.Windows.Forms.ListView()
        Me.BT_DeleteDeliveryProvider = New System.Windows.Forms.Button()
        Me.BT_AcceptDeliveryProvider = New System.Windows.Forms.Button()
        Me.LV_CurrentDeliveriesProvider = New System.Windows.Forms.ListView()
        Me.TB_NewPriceDeliveryProvider = New System.Windows.Forms.TextBox()
        Me.TB_NewQuantityDeliveryProvider = New System.Windows.Forms.TextBox()
        Me.LB_NewPriceDeliveryProvider = New System.Windows.Forms.Label()
        Me.LB_NewQuantityDeliveryProvider = New System.Windows.Forms.Label()
        Me.LB_NewProductDeliveryProvider = New System.Windows.Forms.Label()
        Me.TB_NewDateProvider = New System.Windows.Forms.TextBox()
        Me.TB_NewRefProvider = New System.Windows.Forms.TextBox()
        Me.LB_NewProviderDeliveryProvider = New System.Windows.Forms.Label()
        Me.LB_NewDateDeliveryProvider = New System.Windows.Forms.Label()
        Me.LB_NewRefDeliveryProvider = New System.Windows.Forms.Label()
        Me.BT_ConfirmFinishDelivery = New System.Windows.Forms.Button()
        Me.TB_ConfirmProviderDelivery = New System.Windows.Forms.TextBox()
        Me.TB_ConfirmDateDelivery = New System.Windows.Forms.TextBox()
        Me.TB_ConfirmRefDelivery = New System.Windows.Forms.TextBox()
        Me.LB_ProviderConfirm = New System.Windows.Forms.Label()
        Me.LB_DateConfirm = New System.Windows.Forms.Label()
        Me.LB_RéfConfirm = New System.Windows.Forms.Label()
        Me.TB_EstimationDateDeliveryProvider = New System.Windows.Forms.TextBox()
        Me.TB_LastDeliveryEffective = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LB_DateEstimationDeliveryProvider = New System.Windows.Forms.Label()
        Me.LB_DeliveryLastTime = New System.Windows.Forms.Label()
        Me.TP_Client = New System.Windows.Forms.TabPage()
        Me.CB_NewNewClient = New System.Windows.Forms.ComboBox()
        Me.CB_NewProductDeliveryClient = New System.Windows.Forms.ComboBox()
        Me.TB_NewClientPhone = New System.Windows.Forms.TextBox()
        Me.LB_NewClientPhone = New System.Windows.Forms.Label()
        Me.TB_NewClientMail = New System.Windows.Forms.TextBox()
        Me.LB_NewClientMail = New System.Windows.Forms.Label()
        Me.BT_NewClient = New System.Windows.Forms.Button()
        Me.TB_NewAdresseClient = New System.Windows.Forms.TextBox()
        Me.LB_NewAdresseClient = New System.Windows.Forms.Label()
        Me.TB_NewClientTVA = New System.Windows.Forms.TextBox()
        Me.LB_NewClientTVA = New System.Windows.Forms.Label()
        Me.TB_NewClient = New System.Windows.Forms.TextBox()
        Me.LB_NewClient = New System.Windows.Forms.Label()
        Me.LB_CurrentDeliveryClient = New System.Windows.Forms.Label()
        Me.LV_CurrentDeliversiesClients = New System.Windows.Forms.ListView()
        Me.BT_ConfirmNewDeliveryClient = New System.Windows.Forms.Button()
        Me.LV_CurrentDeliveriesClient = New System.Windows.Forms.ListView()
        Me.BT_DeleteDeliveryClient = New System.Windows.Forms.Button()
        Me.BT_AcceptDeliveryClient = New System.Windows.Forms.Button()
        Me.TB_NewPriceDeliveryClient = New System.Windows.Forms.TextBox()
        Me.LB_NewPriceDeliveryClient = New System.Windows.Forms.Label()
        Me.TB_NewQuantityDeliveryClient = New System.Windows.Forms.TextBox()
        Me.LB_NewQuantityDeliveryClient = New System.Windows.Forms.Label()
        Me.LB_NewProductDeliveryClient = New System.Windows.Forms.Label()
        Me.LB_NewClientDeliveryClient = New System.Windows.Forms.Label()
        Me.TB_NewDateClient = New System.Windows.Forms.TextBox()
        Me.LB_NewDateClient = New System.Windows.Forms.Label()
        Me.BT_ConfirmDeliveryClient = New System.Windows.Forms.Button()
        Me.TB_DeliveryNameClient = New System.Windows.Forms.TextBox()
        Me.LB_DeliveryNameClient = New System.Windows.Forms.Label()
        Me.TB_DeliveryDateClient = New System.Windows.Forms.TextBox()
        Me.LB_DeliveryDateClient = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LB_DeliveryReferenceClient = New System.Windows.Forms.Label()
        Me.TB_LastDateClient = New System.Windows.Forms.TextBox()
        Me.LB_LastDateClient = New System.Windows.Forms.Label()
        Me.TB_LastDeliveryClient = New System.Windows.Forms.TextBox()
        Me.LB_LastDeliveryClient = New System.Windows.Forms.Label()
        Me.TP_Estimation = New System.Windows.Forms.TabPage()
        Me.LB_NewRefDeliveryClient = New System.Windows.Forms.Label()
        Me.TB_NewRefDeliveryClient = New System.Windows.Forms.TextBox()
        Me.TabC_Stock.SuspendLayout()
        Me.TP_StockShow.SuspendLayout()
        Me.TP_Provider.SuspendLayout()
        Me.TP_Client.SuspendLayout()
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
        Me.TP_StockShow.Controls.Add(Me.TB_LastDeliveryClientLive)
        Me.TP_StockShow.Controls.Add(Me.LB_LastDeliveryClientLive)
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
        'TB_LastDeliveryClientLive
        '
        Me.TB_LastDeliveryClientLive.Enabled = False
        Me.TB_LastDeliveryClientLive.Location = New System.Drawing.Point(184, 82)
        Me.TB_LastDeliveryClientLive.Name = "TB_LastDeliveryClientLive"
        Me.TB_LastDeliveryClientLive.Size = New System.Drawing.Size(100, 20)
        Me.TB_LastDeliveryClientLive.TabIndex = 8
        '
        'LB_LastDeliveryClientLive
        '
        Me.LB_LastDeliveryClientLive.AutoSize = True
        Me.LB_LastDeliveryClientLive.Location = New System.Drawing.Point(6, 85)
        Me.LB_LastDeliveryClientLive.Name = "LB_LastDeliveryClientLive"
        Me.LB_LastDeliveryClientLive.Size = New System.Drawing.Size(172, 13)
        Me.LB_LastDeliveryClientLive.TabIndex = 7
        Me.LB_LastDeliveryClientLive.Text = "Date de la dernière livraison client :"
        '
        'LB_InOutPut
        '
        Me.LB_InOutPut.AutoSize = True
        Me.LB_InOutPut.Location = New System.Drawing.Point(915, 168)
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
        Me.LB_StockLive.Location = New System.Drawing.Point(287, 168)
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
        Me.TP_Provider.Controls.Add(Me.CB_NewNewProvider)
        Me.TP_Provider.Controls.Add(Me.BT_NewProductConfirm)
        Me.TP_Provider.Controls.Add(Me.CB_NewProductProvider)
        Me.TP_Provider.Controls.Add(Me.LB_NewProductProvider)
        Me.TP_Provider.Controls.Add(Me.TB_NewProductReference)
        Me.TP_Provider.Controls.Add(Me.LB_NewProductReference)
        Me.TP_Provider.Controls.Add(Me.TB_NewProductName)
        Me.TP_Provider.Controls.Add(Me.LB_NewProductName)
        Me.TP_Provider.Controls.Add(Me.CB_NewProductDeliveryProvider)
        Me.TP_Provider.Controls.Add(Me.BT_ConfirmNewDelivery)
        Me.TP_Provider.Controls.Add(Me.LB_CurrentDeliveryProvider)
        Me.TP_Provider.Controls.Add(Me.LV_CurrentDeliversiesProvider)
        Me.TP_Provider.Controls.Add(Me.BT_DeleteDeliveryProvider)
        Me.TP_Provider.Controls.Add(Me.BT_AcceptDeliveryProvider)
        Me.TP_Provider.Controls.Add(Me.LV_CurrentDeliveriesProvider)
        Me.TP_Provider.Controls.Add(Me.TB_NewPriceDeliveryProvider)
        Me.TP_Provider.Controls.Add(Me.TB_NewQuantityDeliveryProvider)
        Me.TP_Provider.Controls.Add(Me.LB_NewPriceDeliveryProvider)
        Me.TP_Provider.Controls.Add(Me.LB_NewQuantityDeliveryProvider)
        Me.TP_Provider.Controls.Add(Me.LB_NewProductDeliveryProvider)
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
        'CB_NewNewProvider
        '
        Me.CB_NewNewProvider.FormattingEnabled = True
        Me.CB_NewNewProvider.Location = New System.Drawing.Point(350, 182)
        Me.CB_NewNewProvider.Name = "CB_NewNewProvider"
        Me.CB_NewNewProvider.Size = New System.Drawing.Size(121, 21)
        Me.CB_NewNewProvider.TabIndex = 36
        '
        'BT_NewProductConfirm
        '
        Me.BT_NewProductConfirm.Location = New System.Drawing.Point(677, 95)
        Me.BT_NewProductConfirm.Name = "BT_NewProductConfirm"
        Me.BT_NewProductConfirm.Size = New System.Drawing.Size(159, 23)
        Me.BT_NewProductConfirm.TabIndex = 10
        Me.BT_NewProductConfirm.Text = "Confirmer le nouveau produit"
        Me.BT_NewProductConfirm.UseVisualStyleBackColor = True
        '
        'CB_NewProductProvider
        '
        Me.CB_NewProductProvider.FormattingEnabled = True
        Me.CB_NewProductProvider.Location = New System.Drawing.Point(550, 96)
        Me.CB_NewProductProvider.Name = "CB_NewProductProvider"
        Me.CB_NewProductProvider.Size = New System.Drawing.Size(121, 21)
        Me.CB_NewProductProvider.TabIndex = 9
        '
        'LB_NewProductProvider
        '
        Me.LB_NewProductProvider.AutoSize = True
        Me.LB_NewProductProvider.Location = New System.Drawing.Point(477, 100)
        Me.LB_NewProductProvider.Name = "LB_NewProductProvider"
        Me.LB_NewProductProvider.Size = New System.Drawing.Size(67, 13)
        Me.LB_NewProductProvider.TabIndex = 35
        Me.LB_NewProductProvider.Text = "Fournisseur :"
        '
        'TB_NewProductReference
        '
        Me.TB_NewProductReference.Location = New System.Drawing.Point(371, 97)
        Me.TB_NewProductReference.Name = "TB_NewProductReference"
        Me.TB_NewProductReference.Size = New System.Drawing.Size(100, 20)
        Me.TB_NewProductReference.TabIndex = 8
        '
        'LB_NewProductReference
        '
        Me.LB_NewProductReference.AutoSize = True
        Me.LB_NewProductReference.Location = New System.Drawing.Point(266, 100)
        Me.LB_NewProductReference.Name = "LB_NewProductReference"
        Me.LB_NewProductReference.Size = New System.Drawing.Size(102, 13)
        Me.LB_NewProductReference.TabIndex = 33
        Me.LB_NewProductReference.Text = "Référence Produit : "
        '
        'TB_NewProductName
        '
        Me.TB_NewProductName.Location = New System.Drawing.Point(140, 97)
        Me.TB_NewProductName.Name = "TB_NewProductName"
        Me.TB_NewProductName.Size = New System.Drawing.Size(120, 20)
        Me.TB_NewProductName.TabIndex = 7
        '
        'LB_NewProductName
        '
        Me.LB_NewProductName.AutoSize = True
        Me.LB_NewProductName.Location = New System.Drawing.Point(10, 100)
        Me.LB_NewProductName.Name = "LB_NewProductName"
        Me.LB_NewProductName.Size = New System.Drawing.Size(124, 13)
        Me.LB_NewProductName.TabIndex = 31
        Me.LB_NewProductName.Text = "Nouveau Produit : Nom :"
        '
        'CB_NewProductDeliveryProvider
        '
        Me.CB_NewProductDeliveryProvider.FormattingEnabled = True
        Me.CB_NewProductDeliveryProvider.Location = New System.Drawing.Point(8, 255)
        Me.CB_NewProductDeliveryProvider.Name = "CB_NewProductDeliveryProvider"
        Me.CB_NewProductDeliveryProvider.Size = New System.Drawing.Size(93, 21)
        Me.CB_NewProductDeliveryProvider.TabIndex = 14
        '
        'BT_ConfirmNewDelivery
        '
        Me.BT_ConfirmNewDelivery.Location = New System.Drawing.Point(377, 236)
        Me.BT_ConfirmNewDelivery.Name = "BT_ConfirmNewDelivery"
        Me.BT_ConfirmNewDelivery.Size = New System.Drawing.Size(75, 56)
        Me.BT_ConfirmNewDelivery.TabIndex = 17
        Me.BT_ConfirmNewDelivery.Text = "Confirmer Nouvelle Livraison"
        Me.BT_ConfirmNewDelivery.UseVisualStyleBackColor = True
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
        'LV_CurrentDeliversiesProvider
        '
        Me.LV_CurrentDeliversiesProvider.Location = New System.Drawing.Point(590, 255)
        Me.LV_CurrentDeliversiesProvider.Name = "LV_CurrentDeliversiesProvider"
        Me.LV_CurrentDeliversiesProvider.Size = New System.Drawing.Size(675, 336)
        Me.LV_CurrentDeliversiesProvider.TabIndex = 27
        Me.LV_CurrentDeliversiesProvider.UseCompatibleStateImageBehavior = False
        '
        'BT_DeleteDeliveryProvider
        '
        Me.BT_DeleteDeliveryProvider.Location = New System.Drawing.Point(199, 293)
        Me.BT_DeleteDeliveryProvider.Name = "BT_DeleteDeliveryProvider"
        Me.BT_DeleteDeliveryProvider.Size = New System.Drawing.Size(75, 23)
        Me.BT_DeleteDeliveryProvider.TabIndex = 19
        Me.BT_DeleteDeliveryProvider.Text = "Supprimer"
        Me.BT_DeleteDeliveryProvider.UseVisualStyleBackColor = True
        '
        'BT_AcceptDeliveryProvider
        '
        Me.BT_AcceptDeliveryProvider.Location = New System.Drawing.Point(70, 293)
        Me.BT_AcceptDeliveryProvider.Name = "BT_AcceptDeliveryProvider"
        Me.BT_AcceptDeliveryProvider.Size = New System.Drawing.Size(75, 23)
        Me.BT_AcceptDeliveryProvider.TabIndex = 18
        Me.BT_AcceptDeliveryProvider.Text = "Ajouter"
        Me.BT_AcceptDeliveryProvider.UseVisualStyleBackColor = True
        '
        'LV_CurrentDeliveriesProvider
        '
        Me.LV_CurrentDeliveriesProvider.Location = New System.Drawing.Point(6, 322)
        Me.LV_CurrentDeliveriesProvider.Name = "LV_CurrentDeliveriesProvider"
        Me.LV_CurrentDeliveriesProvider.Size = New System.Drawing.Size(325, 269)
        Me.LV_CurrentDeliveriesProvider.TabIndex = 24
        Me.LV_CurrentDeliveriesProvider.UseCompatibleStateImageBehavior = False
        '
        'TB_NewPriceDeliveryProvider
        '
        Me.TB_NewPriceDeliveryProvider.Location = New System.Drawing.Point(246, 255)
        Me.TB_NewPriceDeliveryProvider.Name = "TB_NewPriceDeliveryProvider"
        Me.TB_NewPriceDeliveryProvider.Size = New System.Drawing.Size(100, 20)
        Me.TB_NewPriceDeliveryProvider.TabIndex = 16
        '
        'TB_NewQuantityDeliveryProvider
        '
        Me.TB_NewQuantityDeliveryProvider.Location = New System.Drawing.Point(123, 255)
        Me.TB_NewQuantityDeliveryProvider.Name = "TB_NewQuantityDeliveryProvider"
        Me.TB_NewQuantityDeliveryProvider.Size = New System.Drawing.Size(100, 20)
        Me.TB_NewQuantityDeliveryProvider.TabIndex = 15
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
        'LB_NewQuantityDeliveryProvider
        '
        Me.LB_NewQuantityDeliveryProvider.AutoSize = True
        Me.LB_NewQuantityDeliveryProvider.Location = New System.Drawing.Point(150, 229)
        Me.LB_NewQuantityDeliveryProvider.Name = "LB_NewQuantityDeliveryProvider"
        Me.LB_NewQuantityDeliveryProvider.Size = New System.Drawing.Size(56, 13)
        Me.LB_NewQuantityDeliveryProvider.TabIndex = 19
        Me.LB_NewQuantityDeliveryProvider.Text = "Quantité : "
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
        'TB_NewDateProvider
        '
        Me.TB_NewDateProvider.Location = New System.Drawing.Point(188, 183)
        Me.TB_NewDateProvider.Name = "TB_NewDateProvider"
        Me.TB_NewDateProvider.Size = New System.Drawing.Size(133, 20)
        Me.TB_NewDateProvider.TabIndex = 12
        '
        'TB_NewRefProvider
        '
        Me.TB_NewRefProvider.Location = New System.Drawing.Point(13, 183)
        Me.TB_NewRefProvider.Name = "TB_NewRefProvider"
        Me.TB_NewRefProvider.Size = New System.Drawing.Size(151, 20)
        Me.TB_NewRefProvider.TabIndex = 11
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
        'LB_NewDateDeliveryProvider
        '
        Me.LB_NewDateDeliveryProvider.AutoSize = True
        Me.LB_NewDateDeliveryProvider.Location = New System.Drawing.Point(185, 159)
        Me.LB_NewDateDeliveryProvider.Name = "LB_NewDateDeliveryProvider"
        Me.LB_NewDateDeliveryProvider.Size = New System.Drawing.Size(136, 13)
        Me.LB_NewDateDeliveryProvider.TabIndex = 13
        Me.LB_NewDateDeliveryProvider.Text = "Date de Livraison Estimée :"
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
        'BT_ConfirmFinishDelivery
        '
        Me.BT_ConfirmFinishDelivery.Location = New System.Drawing.Point(790, 66)
        Me.BT_ConfirmFinishDelivery.Name = "BT_ConfirmFinishDelivery"
        Me.BT_ConfirmFinishDelivery.Size = New System.Drawing.Size(151, 23)
        Me.BT_ConfirmFinishDelivery.TabIndex = 6
        Me.BT_ConfirmFinishDelivery.Text = "Confirmer Arrivée"
        Me.BT_ConfirmFinishDelivery.UseVisualStyleBackColor = True
        '
        'TB_ConfirmProviderDelivery
        '
        Me.TB_ConfirmProviderDelivery.Location = New System.Drawing.Point(645, 68)
        Me.TB_ConfirmProviderDelivery.Name = "TB_ConfirmProviderDelivery"
        Me.TB_ConfirmProviderDelivery.Size = New System.Drawing.Size(126, 20)
        Me.TB_ConfirmProviderDelivery.TabIndex = 5
        '
        'TB_ConfirmDateDelivery
        '
        Me.TB_ConfirmDateDelivery.Location = New System.Drawing.Point(429, 68)
        Me.TB_ConfirmDateDelivery.Name = "TB_ConfirmDateDelivery"
        Me.TB_ConfirmDateDelivery.Size = New System.Drawing.Size(133, 20)
        Me.TB_ConfirmDateDelivery.TabIndex = 4
        '
        'TB_ConfirmRefDelivery
        '
        Me.TB_ConfirmRefDelivery.Location = New System.Drawing.Point(170, 68)
        Me.TB_ConfirmRefDelivery.Name = "TB_ConfirmRefDelivery"
        Me.TB_ConfirmRefDelivery.Size = New System.Drawing.Size(151, 20)
        Me.TB_ConfirmRefDelivery.TabIndex = 3
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
        'LB_DateConfirm
        '
        Me.LB_DateConfirm.AutoSize = True
        Me.LB_DateConfirm.Location = New System.Drawing.Point(327, 71)
        Me.LB_DateConfirm.Name = "LB_DateConfirm"
        Me.LB_DateConfirm.Size = New System.Drawing.Size(96, 13)
        Me.LB_DateConfirm.TabIndex = 6
        Me.LB_DateConfirm.Text = "Date de Livraison :"
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
        'TB_EstimationDateDeliveryProvider
        '
        Me.TB_EstimationDateDeliveryProvider.Enabled = False
        Me.TB_EstimationDateDeliveryProvider.Location = New System.Drawing.Point(212, 36)
        Me.TB_EstimationDateDeliveryProvider.Name = "TB_EstimationDateDeliveryProvider"
        Me.TB_EstimationDateDeliveryProvider.Size = New System.Drawing.Size(100, 20)
        Me.TB_EstimationDateDeliveryProvider.TabIndex = 2
        '
        'TB_LastDeliveryEffective
        '
        Me.TB_LastDeliveryEffective.Enabled = False
        Me.TB_LastDeliveryEffective.Location = New System.Drawing.Point(160, 6)
        Me.TB_LastDeliveryEffective.Name = "TB_LastDeliveryEffective"
        Me.TB_LastDeliveryEffective.Size = New System.Drawing.Size(100, 20)
        Me.TB_LastDeliveryEffective.TabIndex = 1
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
        Me.TP_Client.Controls.Add(Me.CB_NewNewClient)
        Me.TP_Client.Controls.Add(Me.CB_NewProductDeliveryClient)
        Me.TP_Client.Controls.Add(Me.TB_NewClientPhone)
        Me.TP_Client.Controls.Add(Me.LB_NewClientPhone)
        Me.TP_Client.Controls.Add(Me.TB_NewClientMail)
        Me.TP_Client.Controls.Add(Me.LB_NewClientMail)
        Me.TP_Client.Controls.Add(Me.BT_NewClient)
        Me.TP_Client.Controls.Add(Me.TB_NewAdresseClient)
        Me.TP_Client.Controls.Add(Me.LB_NewAdresseClient)
        Me.TP_Client.Controls.Add(Me.TB_NewClientTVA)
        Me.TP_Client.Controls.Add(Me.LB_NewClientTVA)
        Me.TP_Client.Controls.Add(Me.TB_NewClient)
        Me.TP_Client.Controls.Add(Me.LB_NewClient)
        Me.TP_Client.Controls.Add(Me.LB_CurrentDeliveryClient)
        Me.TP_Client.Controls.Add(Me.LV_CurrentDeliversiesClients)
        Me.TP_Client.Controls.Add(Me.BT_ConfirmNewDeliveryClient)
        Me.TP_Client.Controls.Add(Me.LV_CurrentDeliveriesClient)
        Me.TP_Client.Controls.Add(Me.BT_DeleteDeliveryClient)
        Me.TP_Client.Controls.Add(Me.BT_AcceptDeliveryClient)
        Me.TP_Client.Controls.Add(Me.TB_NewPriceDeliveryClient)
        Me.TP_Client.Controls.Add(Me.LB_NewPriceDeliveryClient)
        Me.TP_Client.Controls.Add(Me.TB_NewQuantityDeliveryClient)
        Me.TP_Client.Controls.Add(Me.LB_NewQuantityDeliveryClient)
        Me.TP_Client.Controls.Add(Me.LB_NewProductDeliveryClient)
        Me.TP_Client.Controls.Add(Me.LB_NewClientDeliveryClient)
        Me.TP_Client.Controls.Add(Me.TB_NewDateClient)
        Me.TP_Client.Controls.Add(Me.LB_NewDateClient)
        Me.TP_Client.Controls.Add(Me.TB_NewRefDeliveryClient)
        Me.TP_Client.Controls.Add(Me.LB_NewRefDeliveryClient)
        Me.TP_Client.Controls.Add(Me.BT_ConfirmDeliveryClient)
        Me.TP_Client.Controls.Add(Me.TB_DeliveryNameClient)
        Me.TP_Client.Controls.Add(Me.LB_DeliveryNameClient)
        Me.TP_Client.Controls.Add(Me.TB_DeliveryDateClient)
        Me.TP_Client.Controls.Add(Me.LB_DeliveryDateClient)
        Me.TP_Client.Controls.Add(Me.TextBox1)
        Me.TP_Client.Controls.Add(Me.LB_DeliveryReferenceClient)
        Me.TP_Client.Controls.Add(Me.TB_LastDateClient)
        Me.TP_Client.Controls.Add(Me.LB_LastDateClient)
        Me.TP_Client.Controls.Add(Me.TB_LastDeliveryClient)
        Me.TP_Client.Controls.Add(Me.LB_LastDeliveryClient)
        Me.TP_Client.Location = New System.Drawing.Point(4, 22)
        Me.TP_Client.Name = "TP_Client"
        Me.TP_Client.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_Client.Size = New System.Drawing.Size(1441, 656)
        Me.TP_Client.TabIndex = 3
        Me.TP_Client.Text = "Commandes Clients"
        Me.TP_Client.UseVisualStyleBackColor = True
        '
        'CB_NewNewClient
        '
        Me.CB_NewNewClient.FormattingEnabled = True
        Me.CB_NewNewClient.Location = New System.Drawing.Point(323, 209)
        Me.CB_NewNewClient.Name = "CB_NewNewClient"
        Me.CB_NewNewClient.Size = New System.Drawing.Size(121, 21)
        Me.CB_NewNewClient.TabIndex = 43
        '
        'CB_NewProductDeliveryClient
        '
        Me.CB_NewProductDeliveryClient.FormattingEnabled = True
        Me.CB_NewProductDeliveryClient.Location = New System.Drawing.Point(11, 273)
        Me.CB_NewProductDeliveryClient.Name = "CB_NewProductDeliveryClient"
        Me.CB_NewProductDeliveryClient.Size = New System.Drawing.Size(99, 21)
        Me.CB_NewProductDeliveryClient.TabIndex = 42
        '
        'TB_NewClientPhone
        '
        Me.TB_NewClientPhone.Location = New System.Drawing.Point(991, 103)
        Me.TB_NewClientPhone.Name = "TB_NewClientPhone"
        Me.TB_NewClientPhone.Size = New System.Drawing.Size(100, 20)
        Me.TB_NewClientPhone.TabIndex = 41
        '
        'LB_NewClientPhone
        '
        Me.LB_NewClientPhone.AutoSize = True
        Me.LB_NewClientPhone.Location = New System.Drawing.Point(957, 105)
        Me.LB_NewClientPhone.Name = "LB_NewClientPhone"
        Me.LB_NewClientPhone.Size = New System.Drawing.Size(28, 13)
        Me.LB_NewClientPhone.TabIndex = 40
        Me.LB_NewClientPhone.Text = "Tel :"
        '
        'TB_NewClientMail
        '
        Me.TB_NewClientMail.Location = New System.Drawing.Point(795, 102)
        Me.TB_NewClientMail.Name = "TB_NewClientMail"
        Me.TB_NewClientMail.Size = New System.Drawing.Size(156, 20)
        Me.TB_NewClientMail.TabIndex = 39
        '
        'LB_NewClientMail
        '
        Me.LB_NewClientMail.AutoSize = True
        Me.LB_NewClientMail.Location = New System.Drawing.Point(757, 106)
        Me.LB_NewClientMail.Name = "LB_NewClientMail"
        Me.LB_NewClientMail.Size = New System.Drawing.Size(32, 13)
        Me.LB_NewClientMail.TabIndex = 38
        Me.LB_NewClientMail.Text = "Mail :"
        '
        'BT_NewClient
        '
        Me.BT_NewClient.Location = New System.Drawing.Point(1106, 100)
        Me.BT_NewClient.Name = "BT_NewClient"
        Me.BT_NewClient.Size = New System.Drawing.Size(148, 23)
        Me.BT_NewClient.TabIndex = 36
        Me.BT_NewClient.Text = "Ajouter Nouveau Client"
        Me.BT_NewClient.UseVisualStyleBackColor = True
        '
        'TB_NewAdresseClient
        '
        Me.TB_NewAdresseClient.Location = New System.Drawing.Point(519, 102)
        Me.TB_NewAdresseClient.Name = "TB_NewAdresseClient"
        Me.TB_NewAdresseClient.Size = New System.Drawing.Size(232, 20)
        Me.TB_NewAdresseClient.TabIndex = 35
        '
        'LB_NewAdresseClient
        '
        Me.LB_NewAdresseClient.AutoSize = True
        Me.LB_NewAdresseClient.Location = New System.Drawing.Point(462, 106)
        Me.LB_NewAdresseClient.Name = "LB_NewAdresseClient"
        Me.LB_NewAdresseClient.Size = New System.Drawing.Size(51, 13)
        Me.LB_NewAdresseClient.TabIndex = 34
        Me.LB_NewAdresseClient.Text = "Adresse :"
        '
        'TB_NewClientTVA
        '
        Me.TB_NewClientTVA.Location = New System.Drawing.Point(349, 102)
        Me.TB_NewClientTVA.Name = "TB_NewClientTVA"
        Me.TB_NewClientTVA.Size = New System.Drawing.Size(107, 20)
        Me.TB_NewClientTVA.TabIndex = 33
        '
        'LB_NewClientTVA
        '
        Me.LB_NewClientTVA.AutoSize = True
        Me.LB_NewClientTVA.Location = New System.Drawing.Point(294, 106)
        Me.LB_NewClientTVA.Name = "LB_NewClientTVA"
        Me.LB_NewClientTVA.Size = New System.Drawing.Size(49, 13)
        Me.LB_NewClientTVA.TabIndex = 32
        Me.LB_NewClientTVA.Text = "N° TVA :"
        '
        'TB_NewClient
        '
        Me.TB_NewClient.Location = New System.Drawing.Point(127, 103)
        Me.TB_NewClient.Name = "TB_NewClient"
        Me.TB_NewClient.Size = New System.Drawing.Size(161, 20)
        Me.TB_NewClient.TabIndex = 31
        '
        'LB_NewClient
        '
        Me.LB_NewClient.AutoSize = True
        Me.LB_NewClient.Location = New System.Drawing.Point(8, 106)
        Me.LB_NewClient.Name = "LB_NewClient"
        Me.LB_NewClient.Size = New System.Drawing.Size(120, 13)
        Me.LB_NewClient.TabIndex = 30
        Me.LB_NewClient.Text = "Nouveau Client : Nom : "
        '
        'LB_CurrentDeliveryClient
        '
        Me.LB_CurrentDeliveryClient.AutoSize = True
        Me.LB_CurrentDeliveryClient.Location = New System.Drawing.Point(911, 225)
        Me.LB_CurrentDeliveryClient.Name = "LB_CurrentDeliveryClient"
        Me.LB_CurrentDeliveryClient.Size = New System.Drawing.Size(105, 13)
        Me.LB_CurrentDeliveryClient.TabIndex = 29
        Me.LB_CurrentDeliveryClient.Text = "Livraisons en Cours :"
        '
        'LV_CurrentDeliversiesClients
        '
        Me.LV_CurrentDeliversiesClients.Location = New System.Drawing.Point(659, 255)
        Me.LV_CurrentDeliversiesClients.Name = "LV_CurrentDeliversiesClients"
        Me.LV_CurrentDeliversiesClients.Size = New System.Drawing.Size(606, 336)
        Me.LV_CurrentDeliversiesClients.TabIndex = 28
        Me.LV_CurrentDeliversiesClients.UseCompatibleStateImageBehavior = False
        '
        'BT_ConfirmNewDeliveryClient
        '
        Me.BT_ConfirmNewDeliveryClient.Location = New System.Drawing.Point(477, 255)
        Me.BT_ConfirmNewDeliveryClient.Name = "BT_ConfirmNewDeliveryClient"
        Me.BT_ConfirmNewDeliveryClient.Size = New System.Drawing.Size(75, 55)
        Me.BT_ConfirmNewDeliveryClient.TabIndex = 27
        Me.BT_ConfirmNewDeliveryClient.Text = "Confirmer la Nouvelle Livraison"
        Me.BT_ConfirmNewDeliveryClient.UseVisualStyleBackColor = True
        '
        'LV_CurrentDeliveriesClient
        '
        Me.LV_CurrentDeliveriesClient.Location = New System.Drawing.Point(6, 340)
        Me.LV_CurrentDeliveriesClient.Name = "LV_CurrentDeliveriesClient"
        Me.LV_CurrentDeliveriesClient.Size = New System.Drawing.Size(438, 251)
        Me.LV_CurrentDeliveriesClient.TabIndex = 26
        Me.LV_CurrentDeliveriesClient.UseCompatibleStateImageBehavior = False
        '
        'BT_DeleteDeliveryClient
        '
        Me.BT_DeleteDeliveryClient.Location = New System.Drawing.Point(272, 311)
        Me.BT_DeleteDeliveryClient.Name = "BT_DeleteDeliveryClient"
        Me.BT_DeleteDeliveryClient.Size = New System.Drawing.Size(75, 23)
        Me.BT_DeleteDeliveryClient.TabIndex = 25
        Me.BT_DeleteDeliveryClient.Text = "Supprimer"
        Me.BT_DeleteDeliveryClient.UseVisualStyleBackColor = True
        '
        'BT_AcceptDeliveryClient
        '
        Me.BT_AcceptDeliveryClient.Location = New System.Drawing.Point(107, 311)
        Me.BT_AcceptDeliveryClient.Name = "BT_AcceptDeliveryClient"
        Me.BT_AcceptDeliveryClient.Size = New System.Drawing.Size(75, 23)
        Me.BT_AcceptDeliveryClient.TabIndex = 24
        Me.BT_AcceptDeliveryClient.Text = "Ajouter"
        Me.BT_AcceptDeliveryClient.UseVisualStyleBackColor = True
        '
        'TB_NewPriceDeliveryClient
        '
        Me.TB_NewPriceDeliveryClient.Location = New System.Drawing.Point(252, 273)
        Me.TB_NewPriceDeliveryClient.Name = "TB_NewPriceDeliveryClient"
        Me.TB_NewPriceDeliveryClient.Size = New System.Drawing.Size(106, 20)
        Me.TB_NewPriceDeliveryClient.TabIndex = 23
        '
        'LB_NewPriceDeliveryClient
        '
        Me.LB_NewPriceDeliveryClient.AutoSize = True
        Me.LB_NewPriceDeliveryClient.Location = New System.Drawing.Point(290, 248)
        Me.LB_NewPriceDeliveryClient.Name = "LB_NewPriceDeliveryClient"
        Me.LB_NewPriceDeliveryClient.Size = New System.Drawing.Size(30, 13)
        Me.LB_NewPriceDeliveryClient.TabIndex = 22
        Me.LB_NewPriceDeliveryClient.Text = "Prix :"
        '
        'TB_NewQuantityDeliveryClient
        '
        Me.TB_NewQuantityDeliveryClient.Location = New System.Drawing.Point(132, 273)
        Me.TB_NewQuantityDeliveryClient.Name = "TB_NewQuantityDeliveryClient"
        Me.TB_NewQuantityDeliveryClient.Size = New System.Drawing.Size(98, 20)
        Me.TB_NewQuantityDeliveryClient.TabIndex = 21
        '
        'LB_NewQuantityDeliveryClient
        '
        Me.LB_NewQuantityDeliveryClient.AutoSize = True
        Me.LB_NewQuantityDeliveryClient.Location = New System.Drawing.Point(157, 248)
        Me.LB_NewQuantityDeliveryClient.Name = "LB_NewQuantityDeliveryClient"
        Me.LB_NewQuantityDeliveryClient.Size = New System.Drawing.Size(53, 13)
        Me.LB_NewQuantityDeliveryClient.TabIndex = 20
        Me.LB_NewQuantityDeliveryClient.Text = "Quantité :"
        '
        'LB_NewProductDeliveryClient
        '
        Me.LB_NewProductDeliveryClient.AutoSize = True
        Me.LB_NewProductDeliveryClient.Location = New System.Drawing.Point(38, 248)
        Me.LB_NewProductDeliveryClient.Name = "LB_NewProductDeliveryClient"
        Me.LB_NewProductDeliveryClient.Size = New System.Drawing.Size(46, 13)
        Me.LB_NewProductDeliveryClient.TabIndex = 18
        Me.LB_NewProductDeliveryClient.Text = "Produit :"
        '
        'LB_NewClientDeliveryClient
        '
        Me.LB_NewClientDeliveryClient.AutoSize = True
        Me.LB_NewClientDeliveryClient.Location = New System.Drawing.Point(358, 184)
        Me.LB_NewClientDeliveryClient.Name = "LB_NewClientDeliveryClient"
        Me.LB_NewClientDeliveryClient.Size = New System.Drawing.Size(39, 13)
        Me.LB_NewClientDeliveryClient.TabIndex = 16
        Me.LB_NewClientDeliveryClient.Text = "Client :"
        '
        'TB_NewDateClient
        '
        Me.TB_NewDateClient.Location = New System.Drawing.Point(172, 209)
        Me.TB_NewDateClient.Name = "TB_NewDateClient"
        Me.TB_NewDateClient.Size = New System.Drawing.Size(123, 20)
        Me.TB_NewDateClient.TabIndex = 15
        '
        'LB_NewDateClient
        '
        Me.LB_NewDateClient.AutoSize = True
        Me.LB_NewDateClient.Location = New System.Drawing.Point(169, 184)
        Me.LB_NewDateClient.Name = "LB_NewDateClient"
        Me.LB_NewDateClient.Size = New System.Drawing.Size(136, 13)
        Me.LB_NewDateClient.TabIndex = 14
        Me.LB_NewDateClient.Text = "Date de Livraison Estimée :"
        '
        'BT_ConfirmDeliveryClient
        '
        Me.BT_ConfirmDeliveryClient.Location = New System.Drawing.Point(714, 71)
        Me.BT_ConfirmDeliveryClient.Name = "BT_ConfirmDeliveryClient"
        Me.BT_ConfirmDeliveryClient.Size = New System.Drawing.Size(159, 22)
        Me.BT_ConfirmDeliveryClient.TabIndex = 11
        Me.BT_ConfirmDeliveryClient.Text = "Confirmer Livraison"
        Me.BT_ConfirmDeliveryClient.UseVisualStyleBackColor = True
        '
        'TB_DeliveryNameClient
        '
        Me.TB_DeliveryNameClient.Location = New System.Drawing.Point(599, 73)
        Me.TB_DeliveryNameClient.Name = "TB_DeliveryNameClient"
        Me.TB_DeliveryNameClient.Size = New System.Drawing.Size(100, 20)
        Me.TB_DeliveryNameClient.TabIndex = 10
        '
        'LB_DeliveryNameClient
        '
        Me.LB_DeliveryNameClient.AutoSize = True
        Me.LB_DeliveryNameClient.Location = New System.Drawing.Point(509, 76)
        Me.LB_DeliveryNameClient.Name = "LB_DeliveryNameClient"
        Me.LB_DeliveryNameClient.Size = New System.Drawing.Size(84, 13)
        Me.LB_DeliveryNameClient.TabIndex = 9
        Me.LB_DeliveryNameClient.Text = "Nom Du Client : "
        '
        'TB_DeliveryDateClient
        '
        Me.TB_DeliveryDateClient.Location = New System.Drawing.Point(403, 73)
        Me.TB_DeliveryDateClient.Name = "TB_DeliveryDateClient"
        Me.TB_DeliveryDateClient.Size = New System.Drawing.Size(100, 20)
        Me.TB_DeliveryDateClient.TabIndex = 8
        '
        'LB_DeliveryDateClient
        '
        Me.LB_DeliveryDateClient.AutoSize = True
        Me.LB_DeliveryDateClient.Location = New System.Drawing.Point(301, 76)
        Me.LB_DeliveryDateClient.Name = "LB_DeliveryDateClient"
        Me.LB_DeliveryDateClient.Size = New System.Drawing.Size(96, 13)
        Me.LB_DeliveryDateClient.TabIndex = 7
        Me.LB_DeliveryDateClient.Text = "Date de Livraison :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(160, 73)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(135, 20)
        Me.TextBox1.TabIndex = 5
        '
        'LB_DeliveryReferenceClient
        '
        Me.LB_DeliveryReferenceClient.AutoSize = True
        Me.LB_DeliveryReferenceClient.Location = New System.Drawing.Point(8, 76)
        Me.LB_DeliveryReferenceClient.Name = "LB_DeliveryReferenceClient"
        Me.LB_DeliveryReferenceClient.Size = New System.Drawing.Size(148, 13)
        Me.LB_DeliveryReferenceClient.TabIndex = 4
        Me.LB_DeliveryReferenceClient.Text = "Réf. Commande Sélctionnée :"
        '
        'TB_LastDateClient
        '
        Me.TB_LastDateClient.Location = New System.Drawing.Point(160, 43)
        Me.TB_LastDateClient.Name = "TB_LastDateClient"
        Me.TB_LastDateClient.Size = New System.Drawing.Size(100, 20)
        Me.TB_LastDateClient.TabIndex = 3
        '
        'LB_LastDateClient
        '
        Me.LB_LastDateClient.AutoSize = True
        Me.LB_LastDateClient.Location = New System.Drawing.Point(8, 46)
        Me.LB_LastDateClient.Name = "LB_LastDateClient"
        Me.LB_LastDateClient.Size = New System.Drawing.Size(146, 13)
        Me.LB_LastDateClient.TabIndex = 2
        Me.LB_LastDateClient.Text = "Date estimée de la Livraison :"
        '
        'TB_LastDeliveryClient
        '
        Me.TB_LastDeliveryClient.Enabled = False
        Me.TB_LastDeliveryClient.Location = New System.Drawing.Point(188, 13)
        Me.TB_LastDeliveryClient.Name = "TB_LastDeliveryClient"
        Me.TB_LastDeliveryClient.Size = New System.Drawing.Size(100, 20)
        Me.TB_LastDeliveryClient.TabIndex = 1
        '
        'LB_LastDeliveryClient
        '
        Me.LB_LastDeliveryClient.AutoSize = True
        Me.LB_LastDeliveryClient.Location = New System.Drawing.Point(6, 16)
        Me.LB_LastDeliveryClient.Name = "LB_LastDeliveryClient"
        Me.LB_LastDeliveryClient.Size = New System.Drawing.Size(176, 13)
        Me.LB_LastDeliveryClient.TabIndex = 0
        Me.LB_LastDeliveryClient.Text = "Dernière Livraison Client Effectuée :"
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
        'LB_NewRefDeliveryClient
        '
        Me.LB_NewRefDeliveryClient.AutoSize = True
        Me.LB_NewRefDeliveryClient.Location = New System.Drawing.Point(6, 184)
        Me.LB_NewRefDeliveryClient.Name = "LB_NewRefDeliveryClient"
        Me.LB_NewRefDeliveryClient.Size = New System.Drawing.Size(134, 13)
        Me.LB_NewRefDeliveryClient.TabIndex = 12
        Me.LB_NewRefDeliveryClient.Text = "Réf. Nouvelle Commande :"
        '
        'TB_NewRefDeliveryClient
        '
        Me.TB_NewRefDeliveryClient.Location = New System.Drawing.Point(6, 209)
        Me.TB_NewRefDeliveryClient.Name = "TB_NewRefDeliveryClient"
        Me.TB_NewRefDeliveryClient.Size = New System.Drawing.Size(131, 20)
        Me.TB_NewRefDeliveryClient.TabIndex = 13
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
        Me.TP_Client.ResumeLayout(False)
        Me.TP_Client.PerformLayout()
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
    Friend WithEvents TB_LastDeliveryClientLive As System.Windows.Forms.TextBox
    Friend WithEvents LB_LastDeliveryClientLive As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LB_DateEstimationDeliveryProvider As System.Windows.Forms.Label
    Friend WithEvents LB_DeliveryLastTime As System.Windows.Forms.Label
    Friend WithEvents TB_EstimationDateDeliveryProvider As System.Windows.Forms.TextBox
    Friend WithEvents TB_LastDeliveryEffective As System.Windows.Forms.TextBox
    Friend WithEvents TB_NewPriceDeliveryProvider As System.Windows.Forms.TextBox
    Friend WithEvents TB_NewQuantityDeliveryProvider As System.Windows.Forms.TextBox
    Friend WithEvents LB_NewPriceDeliveryProvider As System.Windows.Forms.Label
    Friend WithEvents LB_NewQuantityDeliveryProvider As System.Windows.Forms.Label
    Friend WithEvents LB_NewProductDeliveryProvider As System.Windows.Forms.Label
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
    Friend WithEvents LV_CurrentDeliversiesProvider As System.Windows.Forms.ListView
    Friend WithEvents BT_DeleteDeliveryProvider As System.Windows.Forms.Button
    Friend WithEvents BT_AcceptDeliveryProvider As System.Windows.Forms.Button
    Friend WithEvents LV_CurrentDeliveriesProvider As System.Windows.Forms.ListView
    Friend WithEvents BT_ConfirmNewDelivery As System.Windows.Forms.Button
    Friend WithEvents LB_LastDeliveryClient As System.Windows.Forms.Label
    Friend WithEvents TB_LastDeliveryClient As System.Windows.Forms.TextBox
    Friend WithEvents BT_ConfirmDeliveryClient As System.Windows.Forms.Button
    Friend WithEvents TB_DeliveryNameClient As System.Windows.Forms.TextBox
    Friend WithEvents LB_DeliveryNameClient As System.Windows.Forms.Label
    Friend WithEvents TB_DeliveryDateClient As System.Windows.Forms.TextBox
    Friend WithEvents LB_DeliveryDateClient As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LB_DeliveryReferenceClient As System.Windows.Forms.Label
    Friend WithEvents TB_LastDateClient As System.Windows.Forms.TextBox
    Friend WithEvents LB_LastDateClient As System.Windows.Forms.Label
    Friend WithEvents LB_NewDateClient As System.Windows.Forms.Label
    Friend WithEvents TB_NewDateClient As System.Windows.Forms.TextBox
    Friend WithEvents LB_NewClientDeliveryClient As System.Windows.Forms.Label
    Friend WithEvents LB_NewProductDeliveryClient As System.Windows.Forms.Label
    Friend WithEvents LB_NewQuantityDeliveryClient As System.Windows.Forms.Label
    Friend WithEvents TB_NewPriceDeliveryClient As System.Windows.Forms.TextBox
    Friend WithEvents LB_NewPriceDeliveryClient As System.Windows.Forms.Label
    Friend WithEvents TB_NewQuantityDeliveryClient As System.Windows.Forms.TextBox
    Friend WithEvents BT_DeleteDeliveryClient As System.Windows.Forms.Button
    Friend WithEvents BT_AcceptDeliveryClient As System.Windows.Forms.Button
    Friend WithEvents LV_CurrentDeliveriesClient As System.Windows.Forms.ListView
    Friend WithEvents BT_ConfirmNewDeliveryClient As System.Windows.Forms.Button
    Friend WithEvents LB_CurrentDeliveryClient As System.Windows.Forms.Label
    Friend WithEvents LV_CurrentDeliversiesClients As System.Windows.Forms.ListView
    Friend WithEvents LB_NewClientTVA As System.Windows.Forms.Label
    Friend WithEvents TB_NewClient As System.Windows.Forms.TextBox
    Friend WithEvents LB_NewClient As System.Windows.Forms.Label
    Friend WithEvents TB_NewClientTVA As System.Windows.Forms.TextBox
    Friend WithEvents LB_NewAdresseClient As System.Windows.Forms.Label
    Friend WithEvents BT_NewClient As System.Windows.Forms.Button
    Friend WithEvents TB_NewAdresseClient As System.Windows.Forms.TextBox
    Friend WithEvents TB_NewClientPhone As System.Windows.Forms.TextBox
    Friend WithEvents LB_NewClientPhone As System.Windows.Forms.Label
    Friend WithEvents TB_NewClientMail As System.Windows.Forms.TextBox
    Friend WithEvents LB_NewClientMail As System.Windows.Forms.Label
    Friend WithEvents CB_NewProductDeliveryClient As System.Windows.Forms.ComboBox
    Friend WithEvents CB_NewProductDeliveryProvider As System.Windows.Forms.ComboBox
    Friend WithEvents CB_NewNewClient As System.Windows.Forms.ComboBox
    Friend WithEvents CB_NewProductProvider As System.Windows.Forms.ComboBox
    Friend WithEvents LB_NewProductProvider As System.Windows.Forms.Label
    Friend WithEvents TB_NewProductReference As System.Windows.Forms.TextBox
    Friend WithEvents LB_NewProductReference As System.Windows.Forms.Label
    Friend WithEvents TB_NewProductName As System.Windows.Forms.TextBox
    Friend WithEvents LB_NewProductName As System.Windows.Forms.Label
    Friend WithEvents BT_NewProductConfirm As System.Windows.Forms.Button
    Friend WithEvents CB_NewNewProvider As System.Windows.Forms.ComboBox
    Friend WithEvents TB_NewRefDeliveryClient As System.Windows.Forms.TextBox
    Friend WithEvents LB_NewRefDeliveryClient As System.Windows.Forms.Label
End Class
