   M S B A M L   `   `   `  ����M  ILibraryApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LibraryApplicationLibraryApplication  5   	   #    LibraryApplication.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:LibraryApplication     5   	     � Title$  
MainWindow��5   	   $	��600��6   $
��1080��6*   .��5	      � -   5         �Name$ MainGrid��5	      $	��600��6   $
��1080��6+   .+�5   
   �� -   5         ��Name$ Find_TextBox��5      $��Поиск книги��6C   $��Times New Roman)�6W   ���	#FFF0F6FA$��20(�5      $��10,18,583,0q�6    $	��Top=�65   ���	#FF15325B$��32��6d   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Books_DataGrid��5         AutoGenerateColumns$ False��6+   
������ $��0q�6a   ���	#FFEDF3F7$��10,72,10,10q�6�      Columns 5      4  .System.Windows.Controls.DataGridCheckBoxColumn  5      -   5        BookCheckBox��,  &System.Windows.Controls.DataGridColumn   Header$ C��5   ?      CanUserResize$ False��6J      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6`   	   HeaderTemplate	 5      �� 5      .R�5      �� 5      5      0  *System.Windows.Controls.DataGridTextColumn  5      $ Артикуль��6%   
   
IsReadOnly$

 True��67   $ 60 6I   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6T   �� *ArticleNumber+  5      $ Название��6%   $

 True��67   $	 300 6I    6U   �� *Title+  5      $ Жанр��6%   $

 True��63   $	 100 6E    6Q   �� *Genre+  5      $ Описание��6%   $

 True��67   $	 200 6I    6U   �� *Description+  5      $ Дата выдачи��6%   $

 True��6:   $	 100 6L    6X   �� *	IssueDate+  5      $ Дата возврата��6%   $

 True��6<   $	 100 6N    6Z   �� *
ReturnDate+  5      $! Статус наличия��6%   $

 True��6=   $	 100 6O    6[   �� *Status+  5      $ Читатель��6%   $

 True��67   $	 100 6I    6U   �� *
ReaderName+5       �� 5"   
   -   5        ���	#FFEDF3F7$��Изменить��5#      $
��Left=�6    $	��165��6;   $��40��6G   
�������
���   �$��Times New Roman)�5$       $��20(�6=   $��540,14,0,546q�6K   $
��Bold"�6b    J� RenderTransformOrigin$ 0.5,0.5&�6t   5%      �� 5&   
   -   5        ���	#FFEDF3F7$��Добавить��5'      $
��Left=�6    $	��165��6;   $��40��6G   
�������
���   �$��Times New Roman)�5(       $��20(�6=   $��723,14,0,546q�6K   $
��Bold"�6b   $ 0.5,0.5&�6t   �� 5)   
   -   5        ���	#FFEDF3F7$��Удалить��5*      $
��Left=�6   $	��165��6:   $��40��6F   
�������
���   �$��Times New Roman)�5+       $��20(�6=   $��905,14,0,546q�6K   $
��Bold"�6b   $ 0.5,0.5&�6t    � 5-   
   -   5          �Name$ 	MainFrame��5-        � NavigationUIVisibility$ Hidden=�6#   5.      5/      