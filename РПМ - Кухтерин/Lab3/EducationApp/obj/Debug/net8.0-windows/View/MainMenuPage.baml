   M S B A M L   `   `   `  ����G  CEducationApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:EducationApp.ViewEducationApp.View  5      $    EducationApp.View.MainMenuPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:EducationApp.View     5        N� Title$  MainMenuPage��5	       N� 
Background
 �����.��5      � $	��600��6   $
��1080��6   .+�5   
   �� $/��)Управление студентами��6   $��50(�62   $
��Left=�5      $��250,60,0,269q�6-   $
��Bold"�6C   �� 5   
   $��панель админа��6   $��40(�6*   
�������$
��Left=�5      $��390,120,0,269q�6)   $
��Bold"�6@   �� 5   
   $	��Top=�6   $��-10,226,10,0q�6-   $	��291��6C   .+�5      �� -   5         ��Name$ add_student��5   /   ���	#FFF2CFFF   	topButton#��[  6[   $'��!Добавить студента��5      $��Center=�6/   $	��376��5      $��50��6   
�������
���   �$��Malgun Gothic)�5      $
��Bold"�6.   $��18(�6@   $��0,0,0,10q�5      �� 5      -   5        ���	#FFF2CFFF#��[  5   F   $1��+Добавить преподаватель��5      $��Center=�62   $	��376��5      $��50��6   
�������
���   �$��Malgun Gothic)�5      $
��Bold"�6,   $��18(�6>   $��0,0,0,10q�5      �� 5      -   5        ���	#FFF2CFFF#��[  5   G   $-��'Список заявок на курс��5       $��Center=�61   $	��376��5!      $��50��6   
�������
���   �$��Malgun Gothic)�5"      $
��Bold"�6,   $��18(�6>   $��0,0,0,10q�5#      �� 5%      -   5        $ course_list��5%   *   ���	#FFF2CFFF#��[  6V   $��Список курсов��5&      $��Center=�6,   $	��376��5'      $��50��6   
�������
���   �$��Malgun Gothic)�5(      $
��Bold"�6.   $��18(�6@   �� 5*      -   5        ���	#FFF2CFFF#��[  5*   @   $��Статистика��5+      $��Center=�6)   $	��376��5,      $��50��6   $��10q�6+   
�������
���   �$��Malgun Gothic)�5-      $
��Bold"�6.   $��18(�6@   5.       � 50   
   -   5          �Name$ 	MainFrame��50        � NavigationUIVisibility$ Hidden=�6#   51      52      