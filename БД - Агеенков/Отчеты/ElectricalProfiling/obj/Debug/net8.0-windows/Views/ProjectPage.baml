   M S B A M L   `   `   `  ����N  JElectricalProfiling, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ElectricalProfiling.ViewsElectricalProfiling.Views  5      +    %ElectricalProfiling.Views.ProjectPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:ElectricalProfiling.Views     5        N� Title$  ProjectPage��5	       N� 
Background
 �����.��5      � -   5         �Name$ MainGrid��5      $	��600��6   $
��1080��6*   .+�5   
   �� $#��Список проектов��6   $��40(�6+   $��267,47,494,513q�69   $��Times New Roman)�6Q   $
��Bold"�6n   
���   �6�   �� 5   
   -   5        
�������   ButtonStyle#��[  5   6   $��
Выйти��5   	   $
��Left=�6   $	��206��64   $	��NaN��6@   
�������
���   �$��Times New Roman)�5      $��30(�69   $��16,531,0,19q�6G    K� ZIndex$ 1��6\   �� 5   
   -   5        ���	#FFE7EFF4#��[  5   C   $��Добавить��5   	   $
��Left=�6   $	��209��67   $	��NaN��6C   
�������
���   �$��Times New Roman)�5      $��20(�69   $��602,54,0,504q�6G   $ 1��6]   $
��Bold"�6n   �� 5   
   -   5         ��Name$ Find_TextBox��5      $��Поиск проекта��6C   $��Times New Roman)�6Y     TextBoxStyle#��[ 6v   ���	#FFF0F6FA$��20(�6�   $��267,107,269,0q�6�   $	��Top=�6�   ���	#FF15325B$��41��6  �� 5   
   ���	#FFE4ECF3$��	0,0,842,0q�6(   $ 0��6;   6N   �� 5   
   $��Меню��6   $��40(�6    $��49,62,905,477q�6.   $��Times New Roman)�6E   
���   �$
��Bold"�6u   �� 5   
   #��[  6   $��Проекты��5      $
��Left=�6   $	��122��6:   $	��NaN��6F   
�������
���   �$��Times New Roman)�5       $��30(�6=   $��49,166,0,384q�6K   $ 1��6a   �� 5   
   
�������$��0,166,842,384q�6$   $ 0��6;   6N   �� 5    
   -   5        #��[  5    )   $��Площади��5!      $
��Left=�6   $	��122��6:   $	��NaN��6F   
�������
���   �$��Times New Roman)�5"       $��30(�6=   $��49,225,0,325q�6K   $ 1��6a   �� 5#   
   #��[  6   $��Профили��5$      $
��Left=�6   $	��122��6:   $	��NaN��6F   
�������
���   �$��Times New Roman)�5%       $��30(�6=   $��49,289,0,261q�6K   $ 1��6a   �� 5&   
   #��[  6   $��Станции��5'      $
��Left=�6   $	��120��6:   $	��NaN��6F   
�������
���   �$��Times New Roman)�5(       $��32(�6=   $��50,358,0,192q�6K   $ 1��6a   �� 5)   
   #��[  6   $��Измерения��5*      $
��Left=�6!   $	��141��6<   $	��NaN��6H   
�������
���   �$��Times New Roman)�5+       $��30(�6=   $��49,424,0,126q�6K   $ 1��6a   �� 5.   
   
�������$��267,166,24,19q�6$    �� CornerRadius$ 10��6;   ._�5/      &   System.Windows.Controls.DataGrid  -   5          Name$ Projects_DataGrid��5/         AutoGenerateColumns$ False��62   
������ $��0q�6h   ���	#FFEDF3F7  ColumnHeaderStyle   ColumnHeaderStyle# �  50        DataGridCellStyle	   	CellStyle#	 �  6O   
   Columns
 52      4  .System.Windows.Controls.DataGridCheckBoxColumn  53      -   5        ProductCheckBox��,  &System.Windows.Controls.DataGridColumn   Header$ C��53   F      CanUserResize$ False��6Q      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6g      HeaderTemplate 54      �� 55      .R�56   "   �� 57      59      0  *System.Windows.Controls.DataGridTextColumn  5;      $ Название��6)      
IsReadOnly$
 True��6;   $	 230 6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6Y   �� *Name+  5<      $ Заказчик��6)   $
 True��6;   $	 200 6M    6Y   �� *Customer_id+  5=      $ Дата начала��6)   $
 True��6>   $	 150 6P    6\   �� *
Start_date+  5>      $! Дата окончания��6)   $
 True��6A   $	 160 6S    6_   �� *
End_date+5@      5A      �� 5C   
   -   5         ��Name$ UserControlContainer��5C      $y�	Collapsed=�6/   ���	#80000000$ 2��6]   5E      �� 5G   
   -	   5        $ UserControlContainer_edit��5G      $y�	Collapsed=�64   ���	#80000000$ 2��6b   5H      �� 5J   
   -
   5        ���	#FFEDF3F7#��[  5J   C   $��Изменить��5K      $
��Left=�6    $	��218��6;   $	��NaN��6G   
�������
���   �$��Times New Roman)�5L       $��20(�6=   $��838,107,0,452q�6K   $ 1��6b   $
��Bold"�6s   �� 5M   
   -   5        ���	#FFEDF3F7#��[  5M   E   $��Удалить��5N      $
��Left=�6   $	��218��6:   $	��NaN��6F   
�������
���   �$��Times New Roman)�5O       $��20(�6=   $��838,54,0,504q�6L   $ 1��6b   $
��Bold"�6s    � 5Q   
   -   5          �Name$ 	MainFrame��5Q        � NavigationUIVisibility$ Hidden=�6#   5R      5S      