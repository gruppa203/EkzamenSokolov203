   M S B A M L   `   `   `  ����L  HEkzamenSokolov203, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:EkzamenSokolov203.PagesEkzamenSokolov203.Pages  5      -    'EkzamenSokolov203.Pages.PolzovateliPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:EkzamenSokolov203.Pages     5        N� Title$  PolzovateliPage��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGridPolzovateli��5         
IsReadOnly .    AutoGenerateColumns .  $��0��6[      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	№ п/п��6!      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6U   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 60   �� *Cod_Polzovatelya+6U     5      $ Имя��6%   $ * 6X   	 62   �� *Imya_Polzovatelya+6X     5      $ Фамилия��6%   $ * 6`   	 66   �� *Familiya_Polzovatelya+6`     5      $ 
Логин��6%   $ * 6N   	 64   �� *Login+6N     5      $ Пароль��6%   $ * 6O   	 65   �� *Parol+6O     5      $ № роли��6%   $ * 6T   	 65   �� *
Nomer_Roli+6T   5      �� 5   
   -   5        
 ��Name$
 Nazad��5      $��
Назад��6    $��1��60   5      5      