Public Class Form_Stocks

    Private Sub LV_StockLive_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LV_StockLive.SelectedIndexChanged

    End Sub

    Private Sub Form_Stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LV_StockLive.FullRowSelect = True
        LV_StockLive.View = View.Details
        LV_StockLive.Columns.Add("Noms des Produits", 220, HorizontalAlignment.Left)
        LV_StockLive.Columns.Add("Référence Produit", 100, HorizontalAlignment.Left)
        LV_StockLive.Columns.Add("Quantité en Stock", 100, HorizontalAlignment.Left)
        LV_StockLive.Columns.Add("Prix d'Achat", 80, HorizontalAlignment.Left)
        LV_StockLive.Columns.Add("Prix de Vente Estimé", 140, HorizontalAlignment.Left)
        LV_StockLive.AllowColumnReorder = False
        LV_StockLive.LabelEdit = False

        LV_InOutPut.FullRowSelect = True
        LV_InOutPut.View = View.Details
        LV_InOutPut.Columns.Add("Nom Client/Fournisseur", 150, HorizontalAlignment.Left)
        LV_InOutPut.Columns.Add("Arrivée/Sortie", 100, HorizontalAlignment.Left)
        LV_InOutPut.Columns.Add("Date de mouvement de Stock", 120, HorizontalAlignment.Left)
        LV_InOutPut.Columns.Add("Valeur Estimée de la Livraison", 150, HorizontalAlignment.Left)
        LV_InOutPut.Columns.Add("Référence", 100, HorizontalAlignment.Left)
        LV_InOutPut.AllowColumnReorder = False
        LV_InOutPut.LabelEdit = False

        LV_CurrentDeliveriesProvider.FullRowSelect = True
        LV_CurrentDeliveriesProvider.View = View.Details
        LV_CurrentDeliveriesProvider.Columns.Add("Nom du Produit", 150, HorizontalAlignment.Left)
        LV_CurrentDeliveriesProvider.Columns.Add("Quantité", 100, HorizontalAlignment.Left)
        LV_CurrentDeliveriesProvider.Columns.Add("Prix", 120, HorizontalAlignment.Left)
        LV_CurrentDeliveriesProvider.AllowColumnReorder = False
        LV_CurrentDeliveriesProvider.LabelEdit = False

        LV_CurrentDeliveriesClient.FullRowSelect = True
        LV_CurrentDeliveriesClient.View = View.Details
        LV_CurrentDeliveriesClient.Columns.Add("Nom du Produit", 150, HorizontalAlignment.Left)
        LV_CurrentDeliveriesClient.Columns.Add("Quantité", 100, HorizontalAlignment.Left)
        LV_CurrentDeliveriesClient.Columns.Add("Prix", 120, HorizontalAlignment.Left)
        LV_CurrentDeliveriesClient.AllowColumnReorder = False
        LV_CurrentDeliveriesClient.LabelEdit = False

        LV_CurrentDeliversiesProvider.FullRowSelect = True
        LV_CurrentDeliversiesProvider.View = View.Details
        LV_CurrentDeliversiesProvider.Columns.Add("Nom du Fournisseur", 150, HorizontalAlignment.Left)
        LV_CurrentDeliversiesProvider.Columns.Add("Terminée", 80, HorizontalAlignment.Left)
        LV_CurrentDeliversiesProvider.Columns.Add("Date De Livraison", 120, HorizontalAlignment.Left)
        LV_CurrentDeliversiesProvider.Columns.Add("Valeur de la Livraison", 150, HorizontalAlignment.Left)
        LV_CurrentDeliversiesProvider.Columns.Add("Référence", 100, HorizontalAlignment.Left)
        LV_CurrentDeliversiesProvider.AllowColumnReorder = False
        LV_CurrentDeliversiesProvider.LabelEdit = False

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

End Class