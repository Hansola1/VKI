   M S B A M L   `   `   `  ����I  EEducationPlans, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:EducationPlans.View.PagesEducationPlans.View.Pages  5      -    'EducationPlans.View.Pages.AddLessonPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:EducationPlans.View.Pages     5        N� Title$  SchedulePage��5       N� 
Background
 �����.��5
      � -   5         �Name$ MainGrid��5
      $	��600��6   $
��1080��6*   .+�5   
   �� $%��Добавить занятие��6   $��50(�6,   $��333,48,333,494q�6:   $��Times New Roman)�5      ���	#FF140000 K� ZIndex$ 1��6H   $
��Bold"�6Y   �� 5   
   $��Группа:��6   $��30(�6#   $��263,213,701,329q�61   $��Times New Roman)�5      ���	#FF140000$ 1��6H   �� 5   
   -   5         ��Name$ startDateTextBox��5      $��Дата начала��6,   $��Times New Roman)�6?      TextBoxStyle#��[  5      ���	#FFF0F6FA$��28(�6O   $��254,133,548,0q�6]   $	��Top=�5      ���	#FF15325B$��51��6A   $ 1��6M   �� 5   
   -   5        $ endDateTextBox��5      $��Дата конца��6*   $��Times New Roman)�6<   #��[  5      ���	#FFF0F6FA$��28(�6O   $��546,133,256,0q�6]   $	��Top=�5      ���	#FF15325B$��51��6A   $ 1��6M   �� 5   
   -   5         ��Name$ ClassSelector��5      $	��431��6*   $��41��66   $
��Left=�6B   $	��Top=�6]   $��393,276,0,0q�5      $��Times New Roman)�6(   $��16(�6E   ���	#FF15325B���	#FFFF0808$	��4,2q�6�   $ 5��6�   �� 5   
   -   5        $ GroupSelector��5      $	��431��6*   $��35��66   $��Right=�6B   $	��Top=�6^   $��0,213,256,0q�5       $��Times New Roman)�6(   $��16(�6E   ���	#FF15325B���	#FFFF0808$	��4,2q�5!   +   $ 5��69    �� Text$ Группа��5"      �� 5%   
   -   5        $ SubjectSelector��5%      $	��431��6,   $��36��68   $
��Left=�6D   $	��Top=�6_   $��393,346,0,0q�5&      $��Times New Roman)�6(   $��16(�6E   ���	#FF15325B���	#FFFF0808$	��4,2q�5'      $ 5��6!   ��5(      �� 5)       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5*      � 	 � Color$	 	#FFF0F0F0��6#   � 5+      $	 	#FFE5E5E5��6#   
 � Offset$
 1Q�65   5,      5.      �� 50   
   -   5        $ teacherTextBox��50      $ ��Преподаватель��6*   $��Times New Roman)�6?   #��[  51      ���	#FFF0F6FA$��28(�6O   $��254,410,254,0q�6]   $	��Top=�52      ���	#FF15325B$��51��6A   $ 1��6M   �� 54   
   -   5        ���	#FFF0F6FA  ButtonStyle#��[ 54   9   $��
Назад��55      $
��Left=�6!   $	��255��6<   $	��NaN��6H   
�������
���   �$��Times New Roman)�56   $   $��30(�6A   $��254,484,0,61q�6O   $ 1��6e   �� 58   
   -	   5        ���	#FFF0F6FA#��[ 58   9   $��Добавить��59      $
��Left=�6$   $	��312��6?   $	��NaN��6K   
�������
���   �$��Times New Roman)�5:   $   $��30(�6A   $��514,484,0,61q�6O   $ 1��6e   �� 5;   
   $��30(�6   $��263,276,701,283q�6"   $��Times New Roman)�5<      ���	#FF140000$ 1��6A   �� 6S    � Language$ ru-ru�6W   $�Кабинет��6h   �� 6y   $�:��6}   6�   �� 5=   
   $��30(�6   $��263,346,692,213q�6"   $��Times New Roman)�5>      ���	#FF140000$ 1��6A   �� 6S   $ ru-ru�6W   $�Предмет��6h   �� 6y   $�:��6}   6�    � 5@   
   -
   5          �Name$ 	MainFrame��5@        � NavigationUIVisibility$ Hidden=�6#   $��Stretch=�6C   $��Stretch=�6a   $ 10��6}   5A      5B      