   M S B A M L   `   `   `  ����I  EEducationPlans, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:EducationPlans.ViewEducationPlans.View  5      %    EducationPlans.View.JournalPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:EducationPlans.View     5        N� Title$  JournalPage��5       N� 
Background
 �����.��5
      � -   5         �Name$ MainGrid��5
      $	��600��6   $
��1080��6*   .+�5   
   �� $��Журнал��6   $��50(�6"   $��267,27,330,516q�60   $��Times New Roman)�5   	   $
��Bold"�6&   
���   �68   �� 5   
   ���	#FFE4ECF3$��	0,0,842,0q�6(    K� ZIndex$ 0��6;   6N   �� 5   
   $��Меню��6   $��40(�6    $��49,62,905,477q�6.   $��Times New Roman)�5   
   
���   �$
��Bold"�6:   �� 5   
   -   5           ButtonStyle#��[  5      $��Расписание��5      $
��Left=�6"   $	��158��6=   $	��NaN��6I   
�������
���   �$��Times New Roman)�5       $��30(�6=   $��40,166,0,384q�6K   $ 1��6a   �� 5   
   -   5        #��[  5   &   $��Журнал��5      $
��Left=�6   $	��122��69   $	��NaN��6E   
�������
���   �$��Times New Roman)�5       $��30(�6=   $��49,225,0,325q�6K   $ 1��6a   �� 5   
   -   5        #��[  5   '   $��Дом.раб��5   	   $
��Left=�6   $	��122��66   $	��NaN��6B   
�������
���   �$��Times New Roman)�5      $��30(�6:   $��49,285,0,274q�6H   $ 1��6^   �� 5   
   -   5        
�������#��[  5   5   $��
Выйти��5   	   $
��Left=�6   $	��206��64   $	��NaN��6@   
�������
���   �$��Times New Roman)�5       $��30(�69   $��16,531,0,19q�6G   $ 1��6\   �� 5"   
   
�������$��0,225,842,318q�6$   $ 0��6;   6N   �� 5%   
   
�������$��267,109,24,19q�6$    �� CornerRadius$ 10��6;   ._�5&      &   System.Windows.Controls.DataGrid  -   5          Name$ Schedule_DataGrid��5&         AutoGenerateColumns$ False��62   
������ $��0q�6h   ���	#FFEDF3F7  ColumnHeaderStyle   ColumnHeaderStyle# �  5'        DataGridCellStyle   	CellStyle# �  6O   	   Columns	 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Предмет��6)      
IsReadOnly$
 True��6:      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6X   ��   5*      $ 
 Преподаватель��6)   $
 True��6@   $	 150 6R    6^   ��   5+      $
 Оценка��6)   $
 True��69   $	 110 6K    6W   �� 5-      5.       � 50   
   -   5          �Name$ 	MainFrame��50        � NavigationUIVisibility$ Hidden=�6#   $��Stretch=�6C   $��Stretch=�6a   $ 10��6}   51      52      