   M S B A M L   `   `   `  ����N  JElectricalProfiling, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ElectricalProfiling.ViewsElectricalProfiling.Views  5      )    #ElectricalProfiling.Views.AreasPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:ElectricalProfiling.Views     5        N� Title$  	AreasPage��5       N� 
Background
 �����.��5
      � -   5         �Name$ MainGrid��5
      .+�5   
   �� $��Площади��6   $��40(�6#   $��267,47,494,513q�61   $��Times New Roman)�5   	   $
��Bold"�6&   
���   �68   �� 5   
   -   5        
�������   ButtonStyle#��[  5   6   $��
Выйти��5   	   $
��Left=�6   $	��213��64   $	��NaN��6@   
�������
���   �$��Times New Roman)�5      $��30(�69   $��16,531,0,19q�6G    K� ZIndex$ 1��6\   �� 5   
   -   5         ��Name$ Find_TextBox��5      $��Поиск площади��5   
   $��Times New Roman)�6     TextBoxStyle#��[ 6<   ���	#FFF0F6FA$��20(�5   !   $��267,107,269,0q�6/   $	��Top=�6F   ���	#FF15325B$��41��5   !   6-   �� 5   
   ���	#FFE4ECF3$��	0,0,842,0q�6(   $ 0��6;   6N   �� 5   
   $��Меню��6   $��40(�6    $��49,62,905,477q�6.   $��Times New Roman)�5   
   
���   �$
��Bold"�6:   �� 5   
   -   5        #��[  5   +   $��Проекты��5   	   $
��Left=�6   $	��122��66   $	��NaN��6B   
�������
���   �$��Times New Roman)�5      $��30(�69   $��49,166,0,384q�6G   $ 1��6]   �� 5   
   
�������$��0,227,842,322q�6$   $ 0��6;   6N   �� 5!   
   -   5        #��[  5!   (   $��Площади��5"      $
��Left=�6   $	��122��6:   $	��NaN��6F   
�������
���   �$��Times New Roman)�5#       $��30(�6=   $��49,225,0,325q�6K   $ 1��6a   �� 5%   
   -   5        #��[  5%   +   $��Профили��5&      $
��Left=�6   $	��122��6:   $	��NaN��6F   
�������
���   �$��Times New Roman)�5'       $��30(�6=   $��49,289,0,261q�6K   $ 1��6a   �� 5(   
   -   5        #��[  5(   ,   $��Станции��5)      $
��Left=�6   $	��120��6:   $	��NaN��6F   
�������
���   �$��Times New Roman)�5*       $��32(�6=   $��50,358,0,192q�6K   $ 1��6a   �� 5+   
   -   5        #��[  5+   0   $��Измерения��5,      $
��Left=�6!   $	��141��6<   $	��NaN��6H   
�������
���   �$��Times New Roman)�5-       $��30(�6=   $��49,424,0,126q�6K   $ 1��6a   �� 5/   
   -	   5         ��Name$ AreasTabControl��50   :     
TabControl#��[ 5/      $��267,166,24,19q�69   $��Times New Roman)�6P   $��20(�6m   $
��Bold"�6{   
�������
������ .@�53      �� $��таблица��6     TabItem#��[ 6'   .��54      � 
�������.+�55      &   System.Windows.Controls.DataGrid  -
   5          Name$ Area_DataGrid��55         AutoGenerateColumns$ False��66   
������ $��0q�6l   ���	#FFEDF3F7  ColumnHeaderStyle   ColumnHeaderStyle# �  56        DataGridCellStyle	   	CellStyle#	 �  6O   $��0q�6   
   
IsReadOnly$

 True��57         Columns 58      4  .System.Windows.Controls.DataGridCheckBoxColumn  59      -   5        ProductCheckBox��,  &System.Windows.Controls.DataGridColumn   Header$ C��59   N      CanUserResize$ False��6Y      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6o      HeaderTemplate 5:   "   �� 5;   &   .R�5<   *   �� 5=   '   5?      0  *System.Windows.Controls.DataGridTextColumn  5A      $ Название��61   $	 230 6C   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6O   �� *Name+  5B      $ X��61   $	 200 6<    6H   �� *X+  5C      $ Y��61   $	 150 6<    6H   �� *Y+  5D      $ Проект��61   $	 160 6A    6M   �� *	Project+5F      5G      5H      �� 5K      $��
схема��6   #��[ 6%   $��2,0,-8,0q�6F   .��5L      � 
�������.+�5M      �� -   5         ��Name$ AreaSelector��5M       $	��204��66   $��38��6B   $��Right=�6N   $	��Top=�6j   $��	0,12,10,0q�5N      $��Times New Roman)�6.   $��16(�6K   ���	#FF15325B
����������	#FFE4ECF3$	��4,2q�5O   4   $ 2��6C   5Q      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5T      #  LiveCharts.Wpf.CartesianChart  5R      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5T      -   5          Name$ 	AreaChart��5R   )   $��10,60,10,10q�6<   &   LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$ Right=�5S      5T      5V      5W      5X      �� 5Z   
   -   5         ��Name$ UserControlContainer��5Z      $y�	Collapsed=�6/   ���	#80000000$ 2��6]   5[      �� 5]   
   -   5        $ UserControlContainer_edit��5]      $y�	Collapsed=�64   ���	#80000000$ 2��6b   5^      �� 5`   
   -   5        ���	#FFE7EFF4#��[  5`   ?   $��Добавить��5a   	   $
��Left=�6   $	��209��67   $	��NaN��6C   
�������
���   �$��Times New Roman)�5b      $��20(�69   $��831,53,0,507q�6G   $ 1��6]   $
��Bold"�6n   �� 5d   
   -   5        ���	#FFE7EFF4#��[  5d   @   $��Изменить��5e   	   $
��Left=�6   $	��209��67   $	��NaN��6C   
�������
���   �$��Times New Roman)�5f      $��20(�69   $��602,54,0,504q�6G   $ 0��6]   $
��Bold"�6n   �� 5h   
   -   5        ���	#FFEDF3F7#��[  5h   A   $��Удалить��5i      $
��Left=�6   $	��209��6:   $	��NaN��6F   
�������
���   �$��Times New Roman)�5j       $��20(�6=   $��831,104,0,455q�6L   $ 1��6c   $
��Bold"�6t    � 5l   
   -   5          �Name$ 	MainFrame��5l        � NavigationUIVisibility$ Hidden=�6#   $ 10��6D   $��0,2,0,-2q�6V   5m      5n      