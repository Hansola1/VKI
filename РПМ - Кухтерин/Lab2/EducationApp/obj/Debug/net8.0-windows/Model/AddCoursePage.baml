   M S B A M L   `   `   `  ����G  CEducationApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:EducationApp.ModelEducationApp.Model  5      &     EducationApp.Model.AddCoursePage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:EducationApp.Model     5        N� Title$  AddCoursePage��5   1    N� 
Background
 �����.��5
      � .+�5   
   �� $��Добавить курс��6   $��40(�6*   $
��Left=�5      $��354,45,0,424q�6)   $
��Bold"�6?   $	��340��6Q   �� 5   
   -   5         ��Name$ add_course_button��5   *   ���	#FFF6DCFF   	topButton#��[  6\   $��Добавить��5   	   $
��Left=�6   $	��233��5   	   $	��NaN��6   
�������
���   �$��Malgun Gothic)�6I   $
��Bold"�6e   $��18(�6w   $��503,442,0,100q�5   	   �� 5   
   -   5        $ cancel_button��5   &   ���	#FFF2CFFF#��[  6T   $��
Назад��5   	   $
��Left=�6   $	��139��5   	   $	��NaN��6   
�������
���   �$��Malgun Gothic)�5   	   $
��Bold"�6$   $��18(�66   $��349,442,0,100q�6D   �� 5   
   $!��Название курса��6   $��25(�6*   $��SemiBold"�68   $
��Left=�6N   $��0,157,0,405q�6i    �� TextAlignment$ Center=�6~   
���   �$	��405��6�   �� 5   
     searchTextbox#��[ 6   $
��Left=�69    �� TextWrapping$
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $	��350��6�   $��42��6�   
���   �$��386,157,0,0q�6�   ���	#FFF8EDFF6�   �� 5   
   $ ��Преподаватель��6   $��25(�6)   $��SemiBold"�67   $
��Left=�6M   $��35,219,0,342q�6h   $ Center=�6~   
���   �$	��339��6�   �� 5   
   #��[ 6   $
��Left=�69   $
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $	��350��6�   $��42��6�   
���   �$��386,219,0,0q�6�   ���	#FFF8EDFF6�   �� 5   
   $#��Время провдения��6   $��25(�6+   $��SemiBold"�69   $
��Left=�6O   $��50,282,0,269q�6j   $ Center=�6�   
���   �$	��336��6�   �� 5   
   #��[ 6   $
��Left=�69   $
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $	��350��6�   $��42��6�   
���   �$��386,282,0,0q�6�   ���	#FFF8EDFF6�   �� 5!   
   $-��'Макс кол-во студентов��6   $��25(�61   $��SemiBold"�6?   $
��Left=�6U   $��76,347,0,203q�6p   $ Center=�6�   
���   �$	��328��6�   �� 5"   
   #��[ 6   $
��Left=�6:   $
 Wrap=�6U   $�� ��6i   $	��Top=�6q   $	��350��6�   $��41��6�   
���   �$��386,347,0,0q�6�   ���	#FFF8EDFF6�    � 5$   
   -   5          �Name$ 	MainFrame��5$        � NavigationUIVisibility$ Hidden=�6#   5%      5&      