   M S B A M L   `   `   `  ����G  CEducationApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:EducationApp.ViewEducationApp.View  5      &     EducationApp.View.ListCoursePage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:EducationApp.View     5        N� Title$  ListCoursetPage��5	       N� 
Background
 �����.��5      � $	��600��6   $
��1080��6   .+�5   
   �� $��Список курсов��6   $��40(�6*   $
��Left=�5      $��354,10,0,424q�6'   $
��Bold"�6=   $	��346��6O   �� 5   
   -   5         ��Name$ add_course_button��5   *   ���	#FFF6DCFF   	topButton#��[  6\   $��Добавить курс��5      $
��Left=�6   $	��195��5      $��50��6   
�������
���   �$��Malgun Gothic)�6F   $
��Bold"�6b   $��18(�6t   $��285,442,0,108q�5      �� 5   
   -   5        ���	#FFF2CFFF#��[  5   D   $��Удалить курс��5      $
��Left=�6   $	��211��5      $	��NaN��6   
�������
���   �$��Malgun Gothic)�5      $
��Bold"�6"   $��18(�64   $��485,442,0,108q�6B   �� 5   
   -   5        ���	#FFF2CFFF#��[  5   =   $��
Назад��5      $
��Left=�6   $	��114��5      $	��NaN��6   
�������
���   �$��Malgun Gothic)�5      $
��Bold"�6    $��18(�62   $��701,442,0,108q�6@   �� 5   
   -   5         ��Name$ Courses_ListView��5      $��41,79,50,180q�6.   
���   ����	#FFFBF2FF
������� �� View 5      �� 5       .P�5!      �� $!��Название курса��6%    �� Width$	 270��6j    �� DisplayMemberBinding 6=   �� *TitleCourse+6j   �� 5"      $ ��Преподаватель��6%   $	 350��6g    6<   �� *	TeacherID+6g   �� 5#      $%��Время проведения��6%   $	 160��6e    6?   �� *Time+6e   �� 5$      $-��'Макс кол-во студентов��6%   $	 200��6q    6D   �� *MaxStudents+6q   5%      5'       � 5(   
   -   5          �Name$ 	MainFrame��5(        � NavigationUIVisibility$ Hidden=�6#   5)      5*      