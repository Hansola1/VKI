   M S B A M L   `   `   `  ����N  JElectricalProfiling, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ElectricalProfiling.ViewsElectricalProfiling.Views  5      ,    &ElectricalProfiling.Views.StationsPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:ElectricalProfiling.Views     5        N� Title$  StationsPage��5       N� 
Background
 �����.��5
      � -   5         �Name$ MainGrid��5
      .+�5   
   �� $��Станции��6   $��40(�6#   $��267,47,494,513q�61   $��Times New Roman)�5   	   $
��Bold"�6&   
���   �68   �� 5   
   -   5        
�������   ButtonStyle#��[  5   6   $��
Выйти��5   	   $
��Left=�6   $	��213��64   $	��NaN��6@   
�������
���   �$��Times New Roman)�5      $��30(�69   $��16,531,0,19q�6G    K� ZIndex$ 1��6\   �� 5   
   -   5        ���	#FFE7EFF4#��[  5   B   $��Добавить��5   	   $
��Left=�6   $	��209��67   $	��NaN��6C   
�������
���   �$��Times New Roman)�5      $��20(�69   $��837,63,0,497q�6G   $ 1��6]   $
��Bold"�6n   �� 5   
   ���	#FFE4ECF3$��	0,0,842,0q�6(   $ 0��6;   6N   �� 5   
   $��Меню��6   $��40(�6    $��49,62,905,477q�6.   $��Times New Roman)�5   
   
���   �$
��Bold"�6:   �� 5   
   -   5        #��[  5   +   $��Проекты��5   	   $
��Left=�6   $	��122��66   $	��NaN��6B   
�������
���   �$��Times New Roman)�5      $��30(�69   $��49,166,0,384q�6G   $ 1��6]   �� 5   
   
�������$��1,358,842,187q�6$   $ 0��6;   6N   �� 5    
   -   5        #��[  5    (   $��Площади��5!      $
��Left=�6   $	��122��6:   $	��NaN��6F   
�������
���   �$��Times New Roman)�5"       $��30(�6=   $��49,225,0,325q�6K   $ 1��6a   �� 5$   
   -   5        #��[  5$   +   $��Профили��5%      $
��Left=�6   $	��122��6:   $	��NaN��6F   
�������
���   �$��Times New Roman)�5&       $��30(�6=   $��49,289,0,261q�6K   $ 1��6a   �� 5'   
   -   5        #��[  5'   ,   $��Станции��5(      $
��Left=�6   $	��120��6:   $	��NaN��6F   
�������
���   �$��Times New Roman)�5)       $��32(�6=   $��50,358,0,192q�6K   $ 1��6a   �� 5*   
   -   5        #��[  5*   0   $��Измерения��5+      $
��Left=�6!   $	��141��6<   $	��NaN��6H   
�������
���   �$��Times New Roman)�5,       $��30(�6=   $��49,424,0,126q�6K   $ 1��6a   �� 5/   
   
�������$��267,124,24,19q�6$    �� CornerRadius$ 10��6;   ._�50      &   System.Windows.Controls.DataGrid  -	   5          Name$ Stations_DataGrid��50         AutoGenerateColumns$ False��62   
������ $��0q�6h   ���	#FFEDF3F7  ColumnHeaderStyle   ColumnHeaderStyle# �  51        DataGridCellStyle   	CellStyle# �  6C   	   Columns	 53      4  .System.Windows.Controls.DataGridCheckBoxColumn  54      -
   5        ProductCheckBox��,  &System.Windows.Controls.DataGridColumn
   Header$
 C��54   J      CanUserResize$ False��6U      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6k      HeaderTemplate 55      �� 56   "   .R�57   &   �� 58   #   5:      0  *System.Windows.Controls.DataGridTextColumn  5<      $%
 Название станции��6)      
IsReadOnly$
 True��6C   $	 200 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6a   �� *StationNames+  5=      $
 Профиль��6-   $
 True��6>   $	 200 6P    6\   �� *ProfileName+  5>      $
 Координаты��6-   $
 True��6A   $	 200 6S    6_   �� *Coordinates+  5?      $
 Высота��6-   $
 True��6=   $	 100 6O    6[   �� *	Elevation+5A      5B      �� 5D   
   -   5         ��Name$ UserControlContainer��5D      $y�	Collapsed=�6/   ���	#80000000$ 2��6]   5E      �� 5G   
   -   5        $ UserControlContainer_edit��5G      $y�	Collapsed=�64   ���	#80000000$ 2��6b   5H      �� 5J   
   -   5        ���	#FFEDF3F7#��[  5J   D   $��Удалить��5K      $
��Left=�6   $	��209��6:   $	��NaN��6F   
�������
���   �$��Times New Roman)�5L       $��20(�6=   $��612,63,0,496q�6L   $ 1��6b   $
��Bold"�6s    � 5N   
   -   5          �Name$ 	MainFrame��5N        � NavigationUIVisibility$ Hidden=�6#   $��Stretch=�6C   $��Stretch=�6a   $ 10��6~   5O      5P      