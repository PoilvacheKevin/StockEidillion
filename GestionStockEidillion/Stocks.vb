Public Class Form_Stocks

    Dim MySQLCom As New SQLCom()

    Private Sub Form_Stocks_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Fermeture d'Accueil
        Form_Acceuil.Dispose()
    End Sub

    Private Sub Form_Stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Chargement de la CB_NewProductProvider
        AddItemsCB_NewProductProvider()

        'Création de la ListView Stock
        LV_StockLive.FullRowSelect = True
        LV_StockLive.View = View.Details
        LV_StockLive.Columns.Add("Noms des Produits", 220, HorizontalAlignment.Left)
        LV_StockLive.Columns.Add("Référence Produit", 100, HorizontalAlignment.Left)
        LV_StockLive.Columns.Add("Quantité en Stock", 100, HorizontalAlignment.Left)
        LV_StockLive.Columns.Add("Prix d'Achat", 80, HorizontalAlignment.Left)
        LV_StockLive.Columns.Add("Prix de Vente Estimé", 140, HorizontalAlignment.Left)
        LV_StockLive.AllowColumnReorder = False
        LV_StockLive.LabelEdit = False

        'Création de la ListView In/OutPut
        LV_InOutPut.FullRowSelect = True
        LV_InOutPut.View = View.Details
        LV_InOutPut.Columns.Add("Nom Client/Fournisseur", 150, HorizontalAlignment.Left)
        LV_InOutPut.Columns.Add("Arrivée/Sortie", 100, HorizontalAlignment.Left)
        LV_InOutPut.Columns.Add("Date de mouvement de Stock", 120, HorizontalAlignment.Left)
        LV_InOutPut.Columns.Add("Valeur Estimée de la Livraison", 150, HorizontalAlignment.Left)
        LV_InOutPut.Columns.Add("Référence", 100, HorizontalAlignment.Left)
        LV_InOutPut.AllowColumnReorder = False
        LV_InOutPut.LabelEdit = False

        'Création de la ListView de commandes de produits aux producteurs
        LV_CurrentDeliveriesProvider.FullRowSelect = True
        LV_CurrentDeliveriesProvider.View = View.Details
        LV_CurrentDeliveriesProvider.Columns.Add("Nom du Produit", 150, HorizontalAlignment.Left)
        LV_CurrentDeliveriesProvider.Columns.Add("Quantité", 100, HorizontalAlignment.Left)
        LV_CurrentDeliveriesProvider.Columns.Add("Prix", 120, HorizontalAlignment.Left)
        LV_CurrentDeliveriesProvider.AllowColumnReorder = False
        LV_CurrentDeliveriesProvider.LabelEdit = False

        'Création de la ListView de commandes de produits par les clients
        LV_CurrentDeliveriesClient.FullRowSelect = True
        LV_CurrentDeliveriesClient.View = View.Details
        LV_CurrentDeliveriesClient.Columns.Add("Nom du Produit", 150, HorizontalAlignment.Left)
        LV_CurrentDeliveriesClient.Columns.Add("Quantité", 100, HorizontalAlignment.Left)
        LV_CurrentDeliveriesClient.Columns.Add("Prix", 120, HorizontalAlignment.Left)
        LV_CurrentDeliveriesClient.AllowColumnReorder = False
        LV_CurrentDeliveriesClient.LabelEdit = False

        'Livraisons en cours par les producteurs/en cours d'acheminement
        LV_CurrentDeliversiesProvider.FullRowSelect = True
        LV_CurrentDeliversiesProvider.View = View.Details
        LV_CurrentDeliversiesProvider.Columns.Add("Nom du Fournisseur", 150, HorizontalAlignment.Left)
        LV_CurrentDeliversiesProvider.Columns.Add("Terminée", 80, HorizontalAlignment.Left)
        LV_CurrentDeliversiesProvider.Columns.Add("Date De Livraison", 120, HorizontalAlignment.Left)
        LV_CurrentDeliversiesProvider.Columns.Add("Valeur de la Livraison", 150, HorizontalAlignment.Left)
        LV_CurrentDeliversiesProvider.Columns.Add("Référence", 100, HorizontalAlignment.Left)
        LV_CurrentDeliversiesProvider.AllowColumnReorder = False
        LV_CurrentDeliversiesProvider.LabelEdit = False

        'Livraisons en cours par les clients/Commandes passées mais pas encore terminées
        LV_CurrentDeliversiesClients.FullRowSelect = True
        LV_CurrentDeliversiesClients.View = View.Details
        LV_CurrentDeliversiesClients.Columns.Add("Nom du Client", 150, HorizontalAlignment.Left)
        LV_CurrentDeliversiesClients.Columns.Add("Terminée", 80, HorizontalAlignment.Left)
        LV_CurrentDeliversiesClients.Columns.Add("Date De Livraison", 120, HorizontalAlignment.Left)
        LV_CurrentDeliversiesClients.Columns.Add("Valeur de la Livraison", 150, HorizontalAlignment.Left)
        LV_CurrentDeliversiesClients.Columns.Add("Référence", 100, HorizontalAlignment.Left)
        LV_CurrentDeliversiesClients.AllowColumnReorder = False
        LV_CurrentDeliversiesClients.LabelEdit = False
    End Sub

    'Procédure pour ajouter un client à la base de donnée
    Private Sub BT_NewClient_Click(sender As Object, e As EventArgs) Handles BT_NewClient.Click
        If TB_NewAdresseClient.Text <> "" And TB_NewClient.Text <> "" And TB_NewClientTVA.Text <> "" Then
            Dim Verification As Boolean
            Verification = MySQLCom.AddClient(TB_NewClient.Text, TB_NewAdresseClient.Text, TB_NewClientPhone.Text, TB_NewClientTVA.Text, TB_NewClientMail.Text)
            If Verification = True Then
                MessageBox.Show("Elément Enregistré")
                TB_NewClient.Text = ""
                TB_NewAdresseClient.Text = ""
                TB_NewClientPhone.Text = ""
                TB_NewClientTVA.Text = ""
                TB_NewClientMail.Text = ""
            End If
        Else
            MessageBox.Show("Donnée(s) Manquante(s) Pour Ajouter Client à la DataBase !")
        End If
    End Sub

    'Procédure pour ajouter un nouveau produit
    Private Sub BT_NewProductConfirm_Click(sender As Object, e As EventArgs) Handles BT_NewProductConfirm.Click
        If TB_NewProductName.Text <> "" And TB_NewProductReference.Text <> "" Then
            Dim Verification As Boolean
            Dim IDProvider As Integer
            Dim Reference As Integer = CType(TB_NewProductReference.Text, Integer)
            IDProvider = MySQLCom.GiveIDProviders(CB_NewProductProvider.SelectedItem)
            Verification = MySQLCom.AddProduct(TB_NewProductName.Text, Reference, IDProvider)
            If Verification = True Then
                MessageBox.Show("Elément Enregistré")
                TB_NewProductReference.Text = ""
                TB_NewProductName.Text = ""
            End If
        Else
            MessageBox.Show("Donnée(s) Manquante(s) Pour Ajouter Produit à la DataBase !")
        End If
    End Sub

    'Procédure pour ajouter les fournisseurs à la CB_NewProductProviders
    Private Sub AddItemsCB_NewProductProvider()
        Dim Providers() As String
        Providers = MySQLCom.GiveNamesOfProviders()

        For Each Value In Providers
            CB_NewProductProvider.Items.Add(Value)
        Next
    End Sub
End Class