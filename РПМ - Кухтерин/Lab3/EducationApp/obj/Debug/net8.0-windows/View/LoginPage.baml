   M S B A M L   `   `   `  ����G  CEducationApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:EducationApp.ViewEducationApp.View  5      !    EducationApp.View.LoginPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:EducationApp.View     5        N� Title$  AddCoursePage��5   1    N� 
Background
 �����.��5
      � $	��600��6   $
��1080��6   $��
17,0,-17,0q�6%   .+�5   
   �� $ ��Вход в аккаунт��6   $��50(�6+   $��Center=�69   $��
0,67,0,447q�6V   $
��Bold"�6j   $	��378��6|   �� 5   
   -   5        ���	#FFF6DCFF   	topButton#��[  5   <   $��
Войти��5   	   $
��Left=�6   $��24(�64   $	��269��5   	   $��50��6   
�������
���   �$��Malgun Gothic)�6H   $
��Bold"�6d   $��444,356,0,194q�5   	   �� 5   
   $��30��6   $��
Логин��6    $��25(�6-   $��SemiBold"�6;   $
��Left=�6Q   $��318,229,0,341q�6l    �� TextAlignment$ Center=�6�   
���   �$	��122��6�   �� 5   
   -   5         ��Name$ Login_TextBox��5        searchTextbox#��[ 6)   $
��Left=�6P    �� TextWrapping$
 Wrap=�6k   $�� ��6   $	��Top=�6�   $	��272��6�   $��42��6�   
���   �$��446,225,0,0q�6�   ���	#FFF8EDFF6�   �� 5   
   $��30��6   $��Пароль��6    $��25(�6.   $��SemiBold"�6<   $
��Left=�6R   $��330,286,0,284q�6m   $ Center=�6�   
���   �$	��110��6�   �� 5   
   -   5        $ Password_TextBox��5      #��[ 6,   $
��Left=�6S   $
 Wrap=�6n   $�� ��6�   $	��Top=�6�   $	��274��6�   $��42��6�   
���   �$��444,282,0,0q�6�   ���	#FFF8EDFF6�   �� 5   
   $��20(�6   $
��Left=�6#   $��356,449,0,83q�6>   $
��Bold"�6T   $	��334��5   
   ���	#FFE2E2E2�� 6.    � Language$ ru-ru�62   $�*��6C   ���	#FFC2C2C26L   �� 6e   ���	#FFC2C2C2$:�4данные для входа в админскую��6�   �� 6�   �� 6�   $�панель��5   
   ���	#FFC2C2C26   �� 61   $� ��65   ���	#FFC2C2C26>   �� 6W   ���	#FFC2C2C2$4�.запросить у разработчика��6r   6�    � 5   
   -   5          �Name$ 	MainFrame��5        � NavigationUIVisibility$ Hidden=�6#   5      5      