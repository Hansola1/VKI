   M S B A M L   `   `   `  ����N  JElectricalProfiling, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ElectricalProfiling.ViewsElectricalProfiling.Views  5      +    %ElectricalProfiling.Views.ProjectPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:ElectricalProfiling.Views     5        N� Title$  ProjectPage��5       N� 
Background
 �����.��5
      � -   5         �Name$ MainGrid��5
      .+�5   
   �� $#��Список проектов��6   $��40(�6+   $��267,47,494,513q�69   $��Times New Roman)�5   	   $
��Bold"�6&   
���   �68   �� 5   
   -   5        
�������   ButtonStyle#��[  5   6   $��
Выйти��5   	   $
��Left=�6   $	��206��64   $	��NaN��6@   
�������
���   �$��Times New Roman)�5      $��30(�69   $��16,531,0,19q�6G    K� ZIndex$ 1��6\   �� 5   
   -   5        ���	#FFE7EFF4#��[  5   C   $��Добавить��5   	   $
��Left=�6   $	��209��67   $	��NaN��6C   
�������
���   �$��Times New Roman)�5      $��20(�69   $��602,54,0,504q�6G   $ 0��6]   $
��Bold"�6n   �� 5   
   -   5         ��Name$ Find_TextBox��5      $��Поиск проекта��5   
   $��Times New Roman)�6     TextBoxStyle#��[ 6<   ���	#FFF0F6FA$��20(�5   !   $��267,107,269,0q�6/   $	��Top=�6F   ���	#FF15325B$��41��5   !   6-   �� 5   
   ���	#FFE4ECF3$��	0,0,842,0q�6(   $ 0��6;   6N   �� 5   
   $��Меню��6   $��40(�6    $��49,62,905,477q�6.   $��Times New Roman)�5   
   
���   �$
��Bold"�6:   �� 5   
   #��[  6   $��Проекты��5    	   $
��Left=�6   $	��122��66   $	��NaN��6B   
�������
���   �$��Times New Roman)�5!      $��30(�69   $��49,166,0,384q�6G   $ 1��6]   �� 5#   
   
�������$��0,166,842,384q�6$   $ 0��6;   6N   �� 5%   
   -   5        #��[  5%   (   $��Площади��5&      $
��Left=�6   $	��122��6:   $	��NaN��6F   
�������
���   �$��Times New Roman)�5'       $��30(�6=   $��49,225,0,325q�6K   $ 1��6a   �� 5(   
   -   5        #��[  5(   +   $��Профили��5)      $
��Left=�6   $	��122��6:   $	��NaN��6F   
�������
���   �$��Times New Roman)�5*       $��30(�6=   $��49,289,0,261q�6K   $ 1��6a   �� 5+   
   -   5        #��[  5+   ,   $��Станции��5,      $
��Left=�6   $	��120��6:   $	��NaN��6F   
�������
���   �$��Times New Roman)�5-       $��32(�6=   $��50,358,0,192q�6K   $ 1��6a   �� 5.   
   -   5        #��[  5.   0   $��Измерения��5/      $
��Left=�6!   $	��141��6<   $	��NaN��6H   
�������
���   �$��Times New Roman)�50       $��30(�6=   $��49,424,0,126q�6K   $ 1��6a   �� 53   
   
�������$��267,166,24,19q�6$    �� CornerRadius$ 10��6;   ._�54      &   System.Windows.Controls.DataGrid  -	   5          Name$ Projects_DataGrid��54         AutoGenerateColumns$ False��62   
������ $��0q�6h   ���	#FFEDF3F7  ColumnHeaderStyle   ColumnHeaderStyle# �  55        DataGridCellStyle	   	CellStyle#	 �  6O   
   Columns
 57      4  .System.Windows.Controls.DataGridCheckBoxColumn  58      -
   5        ProductCheckBox��,  &System.Windows.Controls.DataGridColumn   Header$ C��58   F      CanUserResize$ False��6Q      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6g      HeaderTemplate 59      �� 5:      .R�5;   "   �� 5<      5>      0  *System.Windows.Controls.DataGridTextColumn  5@      $ Название��6)      
IsReadOnly$
 True��6;   $	 230 6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6Y   �� *Name+  5A      $ Заказчик��6)   $
 True��6;   $	 200 6M    6Y   �� *Customer_id+  5B      $ Дата начала��6)   $
 True��6>   $	 150 6P    6\   �� *
Start_date+  5C      $! Дата окончания��6)   $
 True��6A   $	 160 6S    6_   �� *
End_date+5E      5F      �� 5H   
   -   5         ��Name$ UserControlContainer��5H      $y�	Collapsed=�6/   ���	#80000000$ 2��6]   5J      �� 5L   
   -   5        $ UserControlContainer_edit��5L      $y�	Collapsed=�64   ���	#80000000$ 2��6b   5M      �� 5O   
   -   5        ���	#FFEDF3F7#��[  5O   C   $��Изменить��5P      $
��Left=�6    $	��218��6;   $	��NaN��6G   
�������
���   �$��Times New Roman)�5Q       $��20(�6=   $��838,107,0,452q�6K   $ 0��6b   $
��Bold"�6s   �� 5S   
   -   5        ���	#FFEDF3F7#��[  5S   E   $��Удалить��5T      $
��Left=�6   $	��218��6:   $	��NaN��6F   
�������
���   �$��Times New Roman)�5U       $��20(�6=   $��838,54,0,504q�6L   $ 0��6b   $
��Bold"�6s    � 5W   
   -   5          �Name$ 	MainFrame��5W        � NavigationUIVisibility$ Hidden=�6#   $��Stretch=�6C   $��Stretch=�6a   $ 10��6}   5X      5Y      