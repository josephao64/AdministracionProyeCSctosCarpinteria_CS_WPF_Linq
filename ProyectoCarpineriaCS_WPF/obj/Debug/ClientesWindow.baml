   M S B A M L   `   `   `  ����  ProyectoCarpineriaCS_WPF-    'ProyectoCarpineriaCS_WPF.ClientesWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        N� Title$  Clientes��5      $	��700��6   $
��1300��6%    N� 
Background �#E3D7BF.��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $	��250 �6   .+�5   
   �� 
����������#CCCCCC$��1q�6:   $��20q�6N    �� Padding$ 10q�6Z   ._�5      &   System.Windows.Controls.DataGrid  -   5          Name$ ClientesGrid��5         AutoGenerateColumns .     CanUserAddRows .     CanUserDeleteRows .     AlternatingRowBackground �#F6F6F6	   GridLinesVisibility$
	 None=�5   :   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *Nombre+6T     5      $ 	Teléfono��6)   $ * 6X    6;   �� *
Telefono+6X   5      5      �� 5   
   
����������#CCCCCC$��1q�6:   $��20q�6N   $ 10q�6Z   $��1��6g   ._�5      �� .+�5      �� $��Clientes Frecuentes��6   $
��Bold"�67   $��16(�6I   $��0,0,0,10q�6W   �� 5      -   5         ��Name$ ClientesFrecuentesListBox��5      
�������$��0q�6P   $
��Auto=�5      5      5      5      5      