   M S B A M L   `   `   `  ����N  JElectricalProfiling, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ElectricalProfiling.ViewsElectricalProfiling.Views  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5      +    %ElectricalProfiling.Views.ProfilePage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:ElectricalProfiling.Views     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5        N� Title$  ProfilePage��5	       N� 
Background
 �����.��5      � -   5         �Name$ MainGrid��5      .+�5   
   �� $��Профили��6   $��40(�6#   $��272,30,584,530q�61   $��Times New Roman)�5   	   $
��Bold"�6&   
���   �68   �� 5   
   -   5        
�������   ButtonStyle#��[  5   6   $��
Выйти��5   	   $
��Left=�6   $	��213��64   $	��NaN��6@   
�������
���   �$��Times New Roman)�5      $��30(�69   $��16,531,0,19q�6G    K� ZIndex$ 1��6\   �� 5   
   ���	#FFE4ECF3$��	0,0,842,0q�6(   $ 0��6;   6N   �� 5   
   $��Меню��6   $��40(�6    $��49,62,905,477q�6.   $��Times New Roman)�5   
   
���   �$
��Bold"�6:   �� 5   
   -   5        #��[  5   +   $��Проекты��5   	   $
��Left=�6   $	��122��66   $	��NaN��6B   
�������
���   �$��Times New Roman)�5      $��30(�69   $��49,166,0,384q�6G   $ 1��6]   �� 5   
   
�������$��1,289,842,260q�6$   $ 0��6;   6N   �� 5   
   -   5        #��[  5   (   $��Площади��5      $
��Left=�6   $	��122��6:   $	��NaN��6F   
�������
���   �$��Times New Roman)�5        $��30(�6=   $��49,225,0,325q�6K   $ 1��6a   �� 5"   
   -   5        #��[  5"   +   $��Профили��5#      $
��Left=�6   $	��122��6:   $	��NaN��6F   
�������
���   �$��Times New Roman)�5$       $��30(�6=   $��49,289,0,261q�6K   $ 1��6a   �� 5%   
   -   5        #��[  5%   ,   $��Станции��5&      $
��Left=�6   $	��120��6:   $	��NaN��6F   
�������
���   �$��Times New Roman)�5'       $��32(�6=   $��50,358,0,192q�6K   $ 1��6a   �� 5(   
   -   5        #��[  5(   0   $��Измерения��5)      $
��Left=�6!   $	��141��6<   $	��NaN��6H   
�������
���   �$��Times New Roman)�5*       $��30(�6=   $��49,424,0,126q�6K   $ 1��6a   �� 5,   
   -   5         ��Name$ AreasTabControl��5-   :     
TabControl#��[ 5,      $��267,166,24,19q�69   $��Times New Roman)�6P   $��20(�6m   $
��Bold"�6{   
�������
������ .@�50      �� $��таблица��6     TabItem#��[ 6'   .��51      � 
�������.+�52      &   System.Windows.Controls.DataGrid  -	   5          Name$ Profile_DataGrid��52         AutoGenerateColumns$ False��69   
������ $��0q�6o   ���	#FFEDF3F7  ColumnHeaderStyle   ColumnHeaderStyle# �  53        DataGridCellStyle   	CellStyle# �  6O   $��0q�6   	   
IsReadOnly$
	 True��54      
   Columns
 55      4  .System.Windows.Controls.DataGridCheckBoxColumn  56      -
   5        ProductCheckBox��,  &System.Windows.Controls.DataGridColumn   Header$ C��56   N      CanUserResize$ False��6Y      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6o      HeaderTemplate 57   "   �� 58   &   .R�59   *   �� 5:   '   5<      0  *System.Windows.Controls.DataGridTextColumn  5>      $ Название��61   $	 230 6C   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6O   �� *Name+  5?      $ X��61   $	 100 6<    6H   �� *X+  5@      $ Y��61   $	 100 6<    6H   �� *Y+  5A      $ Проект��61   $	 160 6A    6M   �� *	Project+  5B      $ Площадь��61   $	 160 6B    6N   �� *Area+5D      5E      5F      �� 5I      $��
схема��6   #��[ 6%   $��2,0,-8,0q�6F   .��5J      � 
�������.+�5K      �� -   5         ��Name$ ProfileSelector��5K       $	��204��69   $��38��6E   $��Right=�6Q   $	��Top=�6m   $��	0,12,10,0q�5L      $��Times New Roman)�6(   $��16(�6E   ���	#FF15325B
����������	#FFE4ECF3$	��4,2q�5M   .   $ 2��6=   5O      #  LiveCharts.Wpf.CartesianChart  5Q      -   5          Name$ ProfileChart��5Q   )   $	��770��5R      &   LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$ Right=�5S      ���	#FFF0F6FA5T      5V      5W      5Y      �� 5[   
   -   5         ��Name$ UserControlContainer��5[      $y�	Collapsed=�6/   ���	#80000000$ 5��6]   5\      �� 5^   
   -   5        $ UserControlContainer_edit��5^      $y�	Collapsed=�64   ���	#80000000$ 5��6b   5_      �� 5a   
   -   5        ���	#FFE7EFF4#��[  5a   B   $��Добавить��5b   	   $
��Left=�6   $	��209��67   $	��NaN��6C   
�������
���   �$��Times New Roman)�5c      $��20(�69   $��267,100,0,461q�6G   $ 0��6^   $
��Bold"�6o   �� 5e   
   -   5        ���	#FFE7EFF4#��[  5e   C   $��Изменить��5f   	   $
��Left=�6   $	��209��67   $	��NaN��6C   
�������
���   �$��Times New Roman)�5g      $��20(�69   $��491,99,0,460q�6G   $ 0��6]   $
��Bold"�6n   �� 5i   
   -   5        ���	#FFEDF3F7#��[  5i   D   $��Удалить��5j      $
��Left=�6   $	��209��6:   $	��NaN��6F   
�������
���   �$��Times New Roman)�5k       $��20(�6=   $��717,99,0,460q�6L   $ 0��6b   $
��Bold"�6s    � 5m   
   -   5          �Name$ 	MainFrame��5m        � NavigationUIVisibility$ Hidden=�6#   $��Stretch=�6C   $��Stretch=�6a   $ 10��6~   5n      5o      