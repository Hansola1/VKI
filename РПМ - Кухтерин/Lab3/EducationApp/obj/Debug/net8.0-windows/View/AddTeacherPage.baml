   M S B A M L   `   `   `  ����G  CEducationApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:EducationApp.ViewEducationApp.View  5      &     EducationApp.View.AddTeacherPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:EducationApp.View     5        N� Title$  AddStudentPage��5	       N� 
Background
 �����.��5      � $	��600��6   $
��1080��6   .+�5   
   �� $1��+Добавить преподавателя��6   $��40(�63   $
��Left=�5      $��296,61,0,408q�6'   $
��Bold"�6=   $	��532��6O   �� 5   
   -   5         ��Name$ add_student_button��5   +   ���	#FFF6DCFF   	topButton#��[  6^   $��Добавить��5   	   $
��Left=�6   $	��177��5   	   $	��NaN��6   
�������
���   �$��Malgun Gothic)�6I   $
��Bold"�6e   $��18(�6w   $��625,433,0,109q�5   	   �� 5   
   -   5        $ cancel_button��5   -   ���	#FFF2CFFF#��[  6[   $��
Назад��5   	   $
��Left=�6   $	��103��5   	   $	��NaN��6   
�������
���   �$��Malgun Gothic)�5   	   $
��Bold"�6$   $��18(�66   $��268,433,0,109q�6D   �� 5   
   $��Имя��6   $��25(�6   $��SemiBold"�6-   $
��Left=�6C   $��305,201,0,370q�6^    �� TextAlignment$ Center=�6u   
���   �$��51��6�   �� 5   
   -   5         ��Name$ Name_TextBox��5        searchTextbox#��[ 6(   $
��Left=�6O    �� TextWrapping$
 Wrap=�6j   $�� ��6~   $	��Top=�6�   $	��350��6�   $��42��6�   
���   ����	#FFF8EDFF$��452,192,0,0q�6�   �� 5   
   -   5        $ edit_student��5   ,   ���	#FFF2CFFF#��[  6Y   $/��)Редактировать препода��5      $
��Left=�63   $	��244��5      $	��NaN��6   
�������
���   �$��Malgun Gothic)�6S   $
��Bold"�6o   $��18(�6�   $��376,433,0,108q�5      �� 5!   
   $��
Логин��6   $��25(�6!   $��SemiBold"�6/   $
��Left=�6E   $ Center=�6`   
���   �$��72��6�   $��304,258,0,300q�6�   �� 5"   
   -   5        $ Login_TextBox��5"      #��[ 6)   $
��Left=�6P   $
 Wrap=�6k   $�� ��6   $	��Top=�6�   $	��350��6�   $��42��6�   
���   �$��452,258,0,0q�6�   ���	#FFF8EDFF6�   �� 5$   
   $��Пароль��6   $��25(�6"   $��SemiBold"�60   $
��Left=�6F   $��305,315,0,235q�6a   $ Center=�6x   
���   �$��89��6�   �� 5%   
   -   5        $ Password_TextBox��5%      #��[ 6,   $
��Left=�6T   $
 Wrap=�6o   $�� ��6�   $	��Top=�6�   $	��350��6�   $��41��6�   
���   �$��452,314,0,0q�6�   ���	#FFF8EDFF6�    � 5'   
   -   5          �Name$ 	MainFrame��5'        � NavigationUIVisibility$ Hidden=�6#   5(      5)      