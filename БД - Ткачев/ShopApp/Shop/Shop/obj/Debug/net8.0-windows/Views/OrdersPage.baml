   M S B A M L   `   `   `  ����?  ;Shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Shop.Views
Shop.Views  5          Shop.Views.OrdersPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Shop.Views     5      $	��600��5      $
��1080��6%     N� 
Background
  �����.��5	      � $	��600��6   $
��1080��6   .+�5
   
    � -   5          �Name$ 	MainFrame��5
        � NavigationUIVisibility$ Hidden=�6#    K� ZIndex$ 1��6C   �� 5   
   $3��-Список всех моих покупок��6   $
��Left=�63   $��20,5,0,0q�6N   $	��Top=�6`   $��30(�5      $	��386��6   �� 5   
   -   5         ��Name$ searchTextBox��5      $
��Left=�6)   $��	26,60,0,0q�6D    �� TextWrapping$
 Wrap=�6W   $	��Top=�5      $	��446��6*   $��30��66   $��20(�6B   $��
Поиск��6P   �� 5   
   $��Цена��6   $
��Left=�6   $��
495,20,0,0q�6:   $	��Top=�6N   $��20(�6f   $��73��6t   $��36��6   �� 5   
   -   5         ��Name$ 
CostFilter��5      $	��157��6'   $
��Left=�63   $��501,60,0,510q�6N   .@�5      �� $!��По возрастанию��6   
 � Tag$ 	Ascending��64   �� 5      $��По убыванию��6   $ 
Descending��61   5      �� 5   
   $��Дата��6   $
��Left=�6   $��
665,20,0,0q�6:   $	��Top=�6N   $��20(�6f   $��75��6t   $��36��6   �� 5   
   -   5        $ 
DateFilter��5      $	��160��6'   $
��Left=�63   $��669,60,0,510q�6N   .@�5      �� $!��По возрастанию��6   $ 	Ascending��64   �� 5      $��По убыванию��6   $ 
Descending��61   5      �� 5    
   $*��$Стоимость более 29.999��6   $
��Left=�64   $��
855,69,0,0q�6O   $	��Top=�5!   '    d� 	IsChecked$ FalseY�6?   $	��181��6Q   $��14(�6]   �� 5%   
   
�������$��26,103,24,23q�6$   ._�5&      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 OrdersDataGrid��5&      
   AutoGenerateColumns$
 False��6/   ���	#FFE3E3E3   Columns 5'      0  *System.Windows.Controls.DataGridTextColumn  5(      ,  &System.Windows.Controls.DataGridColumn   Header$# Название товара��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 700 6b      
IsReadOnly$
 True��6n   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *ProductName+6n     5)      $ Цена��6)   $	 150 6Q   $
 True��6]    67   �� *Price+6]     5*      $ Дата покупки��6)   $	 190 6]   $
 True��6i    6?   �� *	OrderDate+6i   5,      5-      5.      5/      