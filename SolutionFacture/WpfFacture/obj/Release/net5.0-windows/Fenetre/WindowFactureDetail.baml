   M S B A M L   `   `   `  ���� E  AWpfFacture, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfFacture.FenetreWpfFacture.Fenetre  T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls ,    &WpfFacture.Fenetre.WindowFactureDetail   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:WpfFacture.Fenetre     Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro       � Title$  WindowFactureDetail��$	��450��$	��800��.���  � ColumnDefinitions �� $	��300 ��� $��* � � RowDefinitions �� $
��Auto ��� $
��Auto ��� $��* ��� $
��Auto ��� $
��Auto �.+��� $��0��$��0��.+��� .��
Client :�� -    ��Name$ comboboxClient�� �� IsTextSearchEnabled$
 True�� �� DisplayMemberPath$ 	PrenomNom������ *ListeClients+ �� SelectedItem �� *FactureCourante.Client+�� $��10q����� *xxx+� $��0��$��1��$��10q� �� $
��Auto ��� $
��Auto � �� $
��Auto ��� $
��Auto �.+��� $��
Numéro : ��$��0��$��0���� $��0��$��1��$
��Auto��$��5q����� *FactureCourante.NumFacture+�� $��Date : ��$��1��$��0��(  "System.Windows.Controls.DatePicker  $��1��$
��Left=�$��23��$��1��$��5q�$��Center=�$	��120��   FirstDayOfWeek$ Monday=�   SelectedDate �� *FactureCourante.DateFacture+�� $��Visible=�$	��192��$��1q�$��1��$��0��$ CustomizeArticle������ *ListeArticles+ �� *ArticleCourant+� $��1��$��1��$��10q� �� $
��Auto ��� $
��Auto � �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $��* ��� $
��Auto �.+��� $��Nom : ��$��0��$��0���� $��0��$��1��$��5q����� *" LigneFactureCourante.Article.Nom+�� $��Prix : ��$��1��$��0���� $��1��$��1��$	��100��$��5q����� *" LigneFactureCourante.PrixUntaire+�� $��Quantité : ��$��2��$��0���� $��2��$��1��$	��100��$��5q����� *LigneFactureCourante.Quantite+�� -   	 ��Name$	 ajouterButton��$��Ajouter��$��3��$��2��$��27��$��80��$��Right=�$��5q����� *
AddCommand+&   System.Windows.Controls.DataGrid  -   
  Name$
 factureGrid��$��2��$��0��$��2��   AutoGenerateColumns$ False��   
IsReadOnly$
 True��$��1q����� *FactureCourante.LigneFactures+ �� Mode$ TwoWay=� �� *xxx+$ TwoWay=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto    Header$ N° Article��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	ArticleId+  $
 Auto $	 Nom�� �� *Article.Nom+  $
 Auto $ 	Quantité�� �� *
Quantite+  $
 Auto $ Prix unitaire�� �� *PrixUntaire+  $ * $ 
Prix total�� �� *
TotalLigne+�� $��10q�$��3��$��2��$��Right=����� *FactureCourante.TotalFacture+�� $��Imprimer��$��4��$��0��$	��100������ *PrintCommand+�� $��Enregistrer��$��4��$��1��$	��100������ *SaveCommand+