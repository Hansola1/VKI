   M S B A M L   `   `   `  ����G  CEducationApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:EducationApp.ViewEducationApp.View  5      #    EducationApp.View.ListRequest   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:EducationApp.View     5        N� Title$  ListRequest��5	       N� 
Background
 �����.��5      � $	��600��6   $
��1080��6   .+�5   
   �� $-��'Список заявок на курс��6   $��40(�62   $
��Left=�5      $��256,10,0,526q�6'   $
��Bold"�6=   $	��444��6O   �� 5   
   -   5        ���	#FFF2CFFF   	topButton#��[  5   =   $��
Назад��5      $
��Left=�6   $	��276��5      $	��NaN��6   
�������
���   �$��Malgun Gothic)�5      $
��Bold"�6    $��18(�62   $��354,442,0,108q�6@   �� 5   
   -   5         ��Name$ CourseRequest_ListView��5      $��41,79,50,180q�64   
���   ����	#FFFBF2FF
������� �� View 5      �� 5      .P�5      �� $��Имя студента��6%    �� Width$	 450��6i    �� DisplayMemberBinding 6<   �� *StudentName+6i   �� 5      $��Дата заявки��6%   $	 200��6g    6:   �� *DateRequest+6g   �� 5      $��Статус заявки��6%   $	 330��6d    6<   �� *Status+6d   5      5       � 5   
   -   5          �Name$ 	MainFrame��5        � NavigationUIVisibility$ Hidden=�6#   5      5      