   M S B A M L   `   `   `  ����G  CEducationApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:EducationApp.ViewEducationApp.View  5      &     EducationApp.View.StatisticsPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:EducationApp.View     5        N� Title$  StatisticsPage��5	       N� 
Background
 �����.��5      � $	��600��6   $
��1080��6   .+�5   
   �� $:��4Статистика по пользователям��6   $��40(�68   $��Center=�5      $��
0,10,0,526q�61   $
��Bold"�6E   $	��599��6W   �� 5   
   -   5        ���	#FFF2CFFF   	topButton#��[  5   =   $��
Назад��5      $
��Left=�6"   $	��259��5      $	��NaN��6   
�������
���   �$��Malgun Gothic)�5      $
��Bold"�6,   $��18(�6>   $��404,508,0,38q�6L   �� 5   
   -   5         ��Name$ Statistics_ListView��5      $��41,101,51,147q�61   
���   ����	#FFFBF2FF
������� �� View 5      �� 5      .P�5      �� $7��1Общее кол-во пользователей��6%    �� Width$	 500��6u    �� DisplayMemberBinding 6I   �� *
TotalCount+6u   �� 5      $$��Кол-во студентов��6%   $	 200��6m    6?   �� *StudentCount+6m   �� 5      $.��(Кол-во преподавателей��6%   $	 200��6r    6D   �� *TeacherCount+6r   5      5       � 5   
   -   5          �Name$ 	MainFrame��5        � NavigationUIVisibility$ Hidden=�6#   5      5      