   M S B A M L   `   `   `  ����M  ILibraryApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:LibraryApplication.ViewsLibraryApplication.Views  5      +    %LibraryApplication.Views.EditBookPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:LibraryApplication.Views     5        N� Title$  EditBookPage��5	      .��5      � 
�������$	��400��6   $	��600��6+   .+�5   
   �� -   5        $��Сохранить��5      $��16(�6>   $��131,360,0,10q�6L   $
��Left=�6b   $	��158��6}   ���	#FFC7D2DA���	#FF020202$��Times New Roman)�6�   �� 5   
   -   5        $��Закрыть��5      $��16(�6=   $��300,360,0,10q�6K   $
��Left=�6a   $	��141��6|   ���	#FFC7D2DA���	#FF020202$��Times New Roman)�6�   �� 5   
   -   5         ��Name$ BookArticleNumber_TextBox��5   F   $��Times New Roman)�6   ���	#FFE1E8ED$��12(�6i   $��177,30,75,0q�6w   $	��Top=�6�   $��21��6�    �� 
IsReadOnly$ False��6�   �� 5   
   $��Times New Roman)�6   $��15(�61   $��177,8,245,370q�6?    J� RenderTransformOrigin$ 0.482,0.228&�6V   $ ��Артикул книги:��6z   �� 5   
   -   5        $ BookTitle_TextBox��5   F   $��Times New Roman)�6   ���	#FFE1E8ED$��12(�6a   $��177,78,75,0q�6o   $	��Top=�6�   $��21��6�   �� 5   
   $��Times New Roman)�6   $��15(�61   $��177,56,245,322q�6?   $ 0.482,0.228&�6W   $"��Название книги:��6{   �� 5   
   -   5        $ BookGenre_TextBox��5   F   $��Times New Roman)�6   ���	#FFE1E8ED$��12(�6a   $��177,126,75,0q�6o   $	��Top=�6�   $��20��6�   �� 5   
   $��Times New Roman)�6   $��15(�61   $��177,103,245,274q�6?   $ 0.482,0.228&�6X   $��Жанр книги:��6|   �� 5   
   -   5        $ BookDescription_TextBox��5   F   $��Times New Roman)�6   ���	#FFE1E8ED$��12(�6g   $��177,173,75,0q�6u   $	��Top=�6�   $��21��6�   �� 5   
   $��Times New Roman)�6   $��15(�61   $��177,151,245,227q�6?   $ 0.482,0.228&�6X   $"��Описание книги:��6|   �� 5   
   -   5        $ ReturnDate_TextBox��5   F   $��Times New Roman)�6   ���	#FFE1E8ED$��12(�6b   $��177,221,75,0q�6p   $	��Top=�6�   $��21��6�   �� 5   
   $��Times New Roman)�6   $��15(�61   $��177,198,245,179q�6?   $ 0.482,0.228&�6X   $+��%Дата возврата книги:��6|   �� 5   
   -   5        $ IssueDate_TextBox��5   F   $��Times New Roman)�6   ���	#FFE1E8ED$��12(�6a   $��177,264,75,0q�6o   $	��Top=�6�   $��21��6�   �� 5   
   $��Times New Roman)�6   $��15(�61   $��177,242,245,136q�6?   $ 0.482,0.228&�6X   $'��!Дата выдачи книги:��6|   �� 5   
   -	   5        $ BookStatus_TextBox��5   F   $��Times New Roman)�6   ���	#FFE1E8ED$��12(�6b   $��177,311,75,0q�6p   $	��Top=�6�   $��24��6�   �� 5   
   $��Times New Roman)�6   $��15(�61   $��177,285,245,89q�6?   $ 0.482,0.228&�6W   $��Статус книги:��6{   �� 5   
   -
   5        $ ReaderName_TextBox��5   F   $��Times New Roman)�6   ���	#FFE1E8ED$��12(�6b   $��65,30,434,0q�6p   $	��Top=�6�   $��20��6�   �� 5   
   $��Times New Roman)�6   $��15(�61   $��65,10,469,373q�6?   $ 0.482,0.228&�6V   $��Читатель:��6z    � 5   
   -   5          �Name$ 	MainFrame��5        � NavigationUIVisibility$ Hidden=�6#   5       5!      