   M S B A M L   `   `   `  ����N  JElectricalProfiling, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ElectricalProfiling.ViewsElectricalProfiling.Views  5      )    #ElectricalProfiling.Views.AreasPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:ElectricalProfiling.Views     5        N� Title$  	AreasPage��5	       N� 
Background
 �����.��5      � $	��600��6   $
��1080��6   .+�5   
   �� $#��Список площадей��6   $��40(�6+   $��267,38,481,508q�69   $��Times New Roman)�6Q   $
��Bold"�6n   
���   �6�   �� 5   
   -   5        
�������   ButtonStyle#��[  5   6   $��
Выйти��5   	   $
��Left=�6   $	��206��64   $	��NaN��6@   
�������
���   �$��Times New Roman)�5      $��30(�69   $��16,531,0,19q�6G    K� ZIndex$ 1��6\   �� 5   
   -   5        ���	#FFEDF3F7#��[  5   ?   $��Добавить��5   	   $
��Left=�6   $	��194��67   $	��NaN��6C   
�������
���   �$��Times New Roman)�5      $��20(�69   $��862,50,0,508q�6G   $ 1��6]   $
��Bold"�6n   �� 5   
   ���	#FFE4ECF3$��	0,0,842,0q�6(   $ 0��6;   6N   �� 5   
   $��Меню��6   $��40(�6    $��49,62,905,477q�6.   $��Times New Roman)�6E   
���   �$
��Bold"�6u   �� 5   
   -   5        #��[  5   -   $��Проекты��5      $
��Left=�6   $	��122��6:   $	��NaN��6F   
�������
���   �$��Times New Roman)�5       $��30(�6=   $��49,166,0,384q�6K   $ 1��6a   �� 5   
   
�������$��0,225,842,325q�6$   $ 0��6;   6N   �� 5   
   #��[  6   $��Площади��5      $
��Left=�6   $	��122��6:   $	��NaN��6F   
�������
���   �$��Times New Roman)�5        $��30(�6=   $��49,225,0,325q�6K   $ 1��6a   �� 5!   
   #��[  6   $��Профили��5"      $
��Left=�6   $	��122��6:   $	��NaN��6F   
�������
���   �$��Times New Roman)�5#       $��30(�6=   $��49,289,0,261q�6K   $ 1��6a   �� 5$   
   #��[  6   $��Станции��5%      $
��Left=�6   $	��120��6:   $	��NaN��6F   
�������
���   �$��Times New Roman)�5&       $��32(�6=   $��50,358,0,192q�6K   $ 1��6a   �� 5'   
   #��[  6   $��Измерения��5(      $
��Left=�6!   $	��141��6<   $	��NaN��6H   
�������
���   �$��Times New Roman)�5)       $��30(�6=   $��49,424,0,126q�6K   $ 1��6a   �� 5,   
   
�������$��267,113,24,19q�6$    �� CornerRadius$ 10��6;   ._�5-      &   System.Windows.Controls.DataGrid  -   5          Name$ Catalog_DataGrid��5-         AutoGenerateColumns$ False��61   
������ $��0q�6g   ���	#FFEDF3F7   Columns 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn   Header$	 №��6)      
IsReadOnly$
 True��64   	   CanUserResize$	 False��6F   
   Width5  /System.Windows.Controls.DataGridLengthConverter$

 auto 6\     ColumnHeaderStyle   HeaderStyle# [ 6i     50      $ Название��6)   $
 True��6;   $	
 300 6M   # [ 6Y     51      $ Заказчик��6)   $
 True��6;   $	
 170 6M   # [ 6Y     52      $ Дата начала��6)   $
 True��6>   $

 auto 6P   # [ 6]     53      $! Дата окончания��6)   $
 True��6A   $

 auto 6S   # [ 6`   55      56       � 58   
   -   5          �Name$ 	MainFrame��58        � NavigationUIVisibility$ Hidden=�6#   59      5:      