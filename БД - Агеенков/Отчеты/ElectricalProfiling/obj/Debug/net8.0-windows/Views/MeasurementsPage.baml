   M S B A M L   `   `   `  ����N  JElectricalProfiling, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ElectricalProfiling.ViewsElectricalProfiling.Views  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5	      0    *ElectricalProfiling.Views.MeasurementsPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:ElectricalProfiling.Views     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5	        N� Title$  MeasurementsPage��5       N� 
Background
 �����.��5      � -   5         �Name$ MainGrid��5      .+�5   
   �� $��Измерения��6   $��40(�6%   $��267,30,494,530q�63   $��Times New Roman)�5      $
��Bold"�60   
���   �6B   �� 5   
   -   5        
�������   ButtonStyle#��[  5   6   $��
Выйти��5      $
��Left=�6!   $	��213��6<   $	��NaN��6H   
�������
���   �$��Times New Roman)�5   $   $��30(�6A   $��16,531,0,19q�6O    K� ZIndex$ 1��6d   �� 5   
   ���	#FFE4ECF3$��	0,0,842,0q�6(   $ 0��6;   6N   �� 5   
   $��Меню��6   $��40(�6    $��49,62,905,477q�6.   $��Times New Roman)�5      
���   �$
��Bold"�6C   �� 5   
   -   5        #��[  5   +   $��Проекты��5      $
��Left=�6#   $	��122��6>   $	��NaN��6J   
�������
���   �$��Times New Roman)�5   $   $��30(�6A   $��49,166,0,384q�6O   $ 1��6e   �� 5   
   
�������$��1,424,842,118q�6$   $ 0��6;   6N   �� 5   
   -   5        #��[  5   (   $��Площади��5      $
��Left=�6#   $	��122��6>   $	��NaN��6J   
�������
���   �$��Times New Roman)�5   $   $��30(�6A   $��49,225,0,325q�6O   $ 1��6e   �� 5    
   -   5        #��[  5    +   $��Профили��5!      $
��Left=�6#   $	��122��6>   $	��NaN��6J   
�������
���   �$��Times New Roman)�5"   $   $��30(�6A   $��49,289,0,261q�6O   $ 1��6e   �� 5#   
   -   5        #��[  5#   ,   $��Станции��5$      $
��Left=�6#   $	��120��6>   $	��NaN��6J   
�������
���   �$��Times New Roman)�5%   $   $��32(�6A   $��50,358,0,192q�6O   $ 1��6e   �� 5&   
   -   5        #��[  5&   0   $��Измерения��5'      $
��Left=�6%   $	��141��6@   $	��NaN��6L   
�������
���   �$��Times New Roman)�5(   $   $��30(�6A   $��49,424,0,126q�6O   $ 1��6e   �� 5*   
   -   5         ��Name$ AreasTabControl��5+   B     
TabControl#��[ 5*      $��267,166,24,19q�69   $��Times New Roman)�6P   $��20(�6m   $
��Bold"�6{   
�������
������ .@�5.      �� $��таблица��6     TabItem#��[ 6'   .��5/      � 
�������.+�50      &   System.Windows.Controls.DataGrid  -	   5          Name$ Measurements_DataGrid��50         AutoGenerateColumns$ False��6>   
������ $��0q�6t   ���	#FFEDF3F7  ColumnHeaderStyle   ColumnHeaderStyle# �  51        DataGridCellStyle   	CellStyle# �  6W   $��0q�6�   	   
IsReadOnly$
	 True��52      
   Columns
 53      4  .System.Windows.Controls.DataGridCheckBoxColumn  54      -
   5        ProductCheckBox��,  &System.Windows.Controls.DataGridColumn   Header$ C��54   N      CanUserResize$ False��6Y      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6o      HeaderTemplate 55   "   �� 56   &   .R�57   *   �� 58   '   5:      0  *System.Windows.Controls.DataGridTextColumn  5<      $ Станция��61   $	 150 6B   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6N   �� *StationName+  5=      $ Дата��61   $	 120 6?    6K   �� *MeasurementDate+  5>      $ Тип измерения��61   $	 150 6H    6T   �� *MeasurementType+  5?      $ Значение��61   $	 200 6C    6O   �� *Value+  5@      $ Ед.измер��61   $	 100 6C    6O   �� *Unit+5B      5C      5D      �� 5G      $��
схема��6   #��[ 6%   .��5H      � 
�������.+�5I      �� -   5         ��Name$ MeasurementsSelector��5I       $	��204��6>   $��38��6J   $��Right=�6V   $	��Top=�6r   $��	0,12,10,0q�5J       $��Times New Roman)�63   $��16(�6P   ���	#FF15325B
����������	#FFE4ECF3$	��4,2q�5K   9   $ 2��6H   5M      #  LiveCharts.Wpf.CartesianChart  5P      -   5          Name$ MeasurementsChart��5P   )   $	��770��5Q   )   &   LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$ Right=�5S   )   ���	#FFF0F6FA   Series 5R   )   �� *ChartSeries+5T   )   5V      5W      5Y      �� 5Z   
   -   5         ��Name$ UserControlContainer��5Z      $y�	Collapsed=�6/   ���	#80000000$ 2��6]   5[      �� 5]   
   -   5        $ UserControlContainer_edit��5]      $y�	Collapsed=�64   ���	#80000000$ 2��6b   5^      �� 5`   
   -   5        ���	#FFE7EFF4#��[  5`   F   $��Добавить��5a      $
��Left=�6$   $	��209��6?   $	��NaN��6K   
�������
���   �$��Times New Roman)�5b   $   $��20(�6A   $��267,95,0,465q�6O   $ 0��6e   $
��Bold"�6v   �� 5d   
   -   5        ���	#FFEDF3F7#��[  5d   H   $��Удалить��5e      $
��Left=�6#   $	��209��6>   $	��NaN��6J   
�������
���   �$��Times New Roman)�5f   $   $��20(�6A   $��491,94,0,465q�6P   $ 0��6f   $
��Bold"�6w    � 5h   
   -   5          �Name$ 	MainFrame��5h        � NavigationUIVisibility$ Hidden=�6#   $��Stretch=�6C   $��Stretch=�6a   $ 10��6~   5i      5j      