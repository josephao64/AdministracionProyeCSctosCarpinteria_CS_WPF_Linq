   M S B A M L   `   `   `  ����  ProyectoCarpineriaCS_WPF.    (ProyectoCarpineriaCS_WPF.ProyectosWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        N� Title$  	Proyectos��5      $	��700��6   $
��1300��6%    N� 
Background �#e3d7bf.��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ ProyectosGrid��5      $��0��6*      AutoGenerateColumns .  $��	8,85,8,24q�6S      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *ID+  5      $ Nombre��6%    65   �� *Nombre+  5      $ 	Teléfono��6%    67   �� *
Telefono+  5      $ Descripción��6%    6:   �� *Descripcion+  5      $ Fecha Inicio��6%    6;   �� *FechaInicio+  5      $ 	Fecha Fin��6%    68   �� *
FechaFin+  5      $ Precio��6%    65   �� *Precio+5      � 5   
    � Orientation$ 
Horizontal=�6   $
��Left=�6-   $��
10,0,0,555q�6H   $
��1011��6\   .+�5      �� $	��Id:��6   $��Center=�6"   �� 5      -   5        	 ��Name$	 TxtId��5      $	��100��6%   $��Center=�61   $��5q�6L   �� 5      $��Nombre:��6   $��Center=�6&   �� 5      -   5        $	 	TxtNombre��5      $	��200��6)   $��Center=�65   $��5q�6P   �� 5      $��
Teléfono:��6   $��Center=�6(   �� 5      -   5        $	 TxtTelefono��5      $	��150��6+   $��Center=�67   $��5q�6R   �� 5!      $��Descripción:��6   $��Center=�6+   �� 5"      -   5        $	 TxtDescripcion��5"      $	��300��6.   $��Center=�6:   $��5q�6U   �� 5$      $��Fecha Inicio:��6   $��Center=�6,   (  "System.Windows.Controls.DatePicker  5%      -   5        
  Name$
 FechaInicioPicker��5%      $	��150��64   $��Center=�6@   $��5q�6[   �� 5'      $��
Fecha Fin:��6   $��Center=�6)     5(      -   5        $
 FechaFinPicker��5(      $	��150��61   $��Center=�6=   $��5q�6X   �� 5*      $��Precio:��6   $��Center=�6&   �� 5+      -   5        $	 	TxtPrecio��5+      $	��100��6)   $��Center=�65   $��5q�6P   �� 5-      -	   5         ��Name$ 
BtnAgregar��5-      $��Agregar��6)   $	��100��6T   $��5q�6`   �� 5.      -
   5        $ BtnEliminar��5.      $��Eliminar��6*   $	��100��6W   $��5q�6c   �� 5/      -   5        $ BtnActualizar��5/      $��
Actualizar��6,   $	��100��6]   $��5q�6i   50      51      52      