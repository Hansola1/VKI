   M S B A M L   `   `   `  ����G  CEducationApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:EducationApp.View.oldEducationApp.View.old  5      +    %EducationApp.View.old.EditStudentPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:EducationApp.View.old     5        N� Title$  EditStudentPage��5	       N� 
Background
 �����.��5      � $	��600��6   $
��1080��6   .+�5   
   �� $1��+Редактировать студента��6   $��40(�63   $
��Left=�5      $��304,45,0,424q�6'   $
��Bold"�6=   $	��506��6O   �� 5   
   -   5         ��Name$ save_button��5   $   ���	#FFF6DCFF   	topButton#��[  6P   $*��$Cохранить изменения��5   	   $
��Left=�6'   $	��233��5   	   $	��NaN��6   
�������
���   �$��Malgun Gothic)�6I   $
��Bold"�6e   $��18(�6w   $��503,442,0,100q�5   	   �� 5   
   -   5        $ cancel_button��5   &   ���	#FFF2CFFF#��[  6T   $��
Назад��5   	   $
��Left=�6   $	��139��5   	   $	��NaN��6   
�������
���   �$��Malgun Gothic)�5   	   $
��Bold"�6$   $��18(�66   $��349,442,0,100q�6D   �� 5   
   $��Имя��6   $��25(�6   $��SemiBold"�6-   $
��Left=�6C   $��202,157,0,414q�6^    �� TextAlignment$ Center=�6u   
���   �$��51��6�   �� 5   
     searchTextbox#��[ 6   $
��Left=�69    �� TextWrapping$
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $	��350��6�   $��42��6�   
���   �$��386,157,0,0q�6�   ���	#FF325EE2���	#FFF8EDFF6�   �� 5   
   $��Фамилия��6   $��25(�6#   $��SemiBold"�61   $
��Left=�6G   $��187,219,0,342q�6b   $ Center=�6y   
���   �$	��142��6�   �� 5   
   #��[ 6   $
��Left=�69   $
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $	��350��6�   $��42��6�   
���   �$��386,219,0,0q�6�   ���	#FFF8EDFF6�   �� 5   
   $��Email��6   $��25(�6!   $��SemiBold"�6/   $
��Left=�6E   $��202,282,0,269q�6`   $ Center=�6w   
���   �$��78��6�   �� 5    
   #��[ 6   $
��Left=�69   $
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $	��350��6�   $��42��6�   
���   �$��386,282,0,0q�6�   ���	#FFF8EDFF6�   �� 5"   
   $��Курс��6   $��25(�6    $��SemiBold"�6.   $
��Left=�6D   $��202,347,0,203q�6_   $ Center=�6v   
���   �$��64��6�   �� 5#   
   #��[ 6   $
��Left=�6:   $
 Wrap=�6U   $�� ��6i   $	��Top=�6q   $	��350��6�   $��41��6�   
���   �$��386,347,0,0q�6�   ���	#FFF8EDFF6�    � 5%   
   -   5          �Name$ 	MainFrame��5%        � NavigationUIVisibility$ Hidden=�6#   5&      5'      