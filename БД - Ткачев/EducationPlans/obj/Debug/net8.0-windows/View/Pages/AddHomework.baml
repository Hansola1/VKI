   M S B A M L   `   `   `  ����I  EEducationPlans, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:EducationPlans.View.PagesEducationPlans.View.Pages  5      +    %EducationPlans.View.Pages.AddHomework   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:EducationPlans.View.Pages     5        N� 
Background
  �����.��5	      � -   5         �Name$ MainGrid��5	      $	��600��6   $
��1080��6*   .+�5
   
   �� $��Добавить ДЗ��6   $��50(�6'   $��346,51,425,491q�65   $��Times New Roman)�5      ���	#FF140000 K� ZIndex$ 1��6H   $
��Bold"�6Y   �� 5   
   $��Название:��6   $��30(�6%   $��251,244,701,298q�63   $��Times New Roman)�5      ���	#FF140000$ 1��6H   �� 5   
   -   5         ��Name$ startDateTextBox��5      $��Сдать до:��6,   $��Times New Roman)�6=      TextBoxStyle#��[  5      ���	#FFF0F6FA$��28(�6O   $��253,164,253,0q�6]   $	��Top=�5      ���	#FF15325B$��51��6A   $ 1��6M   �� 5   
   -   5        $ titleHomeworkTextBox��5      $�� ��60   $��Times New Roman)�68   #��[  5      ���	#FFF0F6FA$��28(�6M   $��394,234,253,0q�6[   $	��Top=�5      ���	#FF15325B$��58��6?   $ 1��6K   �� 5   
   -   5        $  descriptionHomeworkTextBox��5      $�� ��66   $��Times New Roman)�6>   #��[  5   	   ���	#FFF0F6FA$��28(�6F   $��394,302,253,0q�6T   ���	#FF15325B$��58��6�   $ 1��6�   $	��Top=�6�   �� 5   
   -   5         ��Name$ SubjectSelector��5      $	��431��6,   $��36��68   $
��Left=�6D   $	��Top=�6_   $��394,377,0,0q�5      $��Times New Roman)�6(   $��16(�6E   ���	#FF15325B���	#FFFF0808$	��4,2q�5      $ 5��6!   ��5      �� 5        �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5!      �  � Color$ 	#FFF0F0F0��6#   � 5"      $ 	#FFE5E5E5��6#    � Offset$ 1Q�65   5#      5%      �� 5(   
   -   5        ���	#FFF0F6FA  ButtonStyle#��[ 5(   9   $��
Назад��5)      $
��Left=�6!   $	��255��6<   $	��NaN��6H   
�������
���   �$��Times New Roman)�5*   $   $��30(�6A   $��253,450,0,95q�6O   $ 1��6e   �� 5,   
   -   5        ���	#FFF0F6FA#��[ 5,   9   $��Добавить��5-      $
��Left=�6$   $	��312��6?   $	��NaN��6K   
�������
���   �$��Times New Roman)�5.   $   $��30(�6A   $��513,450,0,95q�6O   $ 1��6e   �� 5/   
   $��30(�6   $��251,307,691,252q�6"   $��Times New Roman)�50      ���	#FF140000$ 1��6A   �� 6S   	 � Language$	 ru-ru�6W   $�Описание��6h   �� 6z   $�:��6~   6�   �� 51   
   $��30(�6   $��251,377,704,182q�6"   $��Times New Roman)�52      ���	#FF140000$ 1��6A   �� 6S   $	 ru-ru�6W   $�Предмет��6h   �� 6y   $�:��6}   6�    � 54   
   -   5        
  �Name$
 	MainFrame��54        � NavigationUIVisibility$ Hidden=�6#   $��Stretch=�6C   $��Stretch=�6a   $ 10��6}   55      56      