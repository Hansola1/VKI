   M S B A M L   `   `   `  ����H  DCarsharingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CarsharingApp.ViewsCarsharingApp.Views  5      (    "CarsharingApp.Views.ListTravelPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:CarsharingApp.Views     5        N� Title$  
TravelPage��5	      .��5      � $
��1080��6   $	��600��6   
�������.+�5   
   �� $6��0Информация о пользователи��6   $��30(�66   $
��Left=�6D   $��10,10,0,527q�6_   $
��Bold"�6t   $	��440��6�   �� 5   
   $��Фамилия��6   $��20(�6#   $��SemiBold"�61   $
��Left=�6G   $��8,103,0,470q�6b    �� TextAlignment$ Center=�6w   
���   �$��98��6�   �� 5   
   -   5         ��Name$ FirstName_TextBox��5      $
��Left=�6.    �� TextWrapping$
 Wrap=�6I   $�� ��6]   $	��Top=�6e   $	��331��6}   $��31��6�   
���   �$��
117,63,0,0q�6�   ���	#FFF8EDFF6�   �� 5   
   $��Имя��6   $��20(�6   $��SemiBold"�6-   $
��Left=�6C   $��
6,67,0,506q�6^   $ Center=�6r   
���   �$	��100��6�   �� 5   
   -   5        $ LastName_TextBox��5      $
��Left=�6,   $
 Wrap=�6G   $�� ��6[   $	��Top=�6c   $	��333��6{   $��31��6�   
���   �$��117,101,0,0q�6�   ���	#FFF8EDFF6�   �� 5   
   $��20(�6   $��SemiBold"�6"   $
��Left=�68   $��6,148,0,427q�6S   $ Center=�6h   
���   �$	��100��6�   �� 6�    � Language$ ru-ru�6�   $�Отчество��6�   6�   �� 5   
   -   5        $ Surname_TextBox��5      $
��Left=�6+   $
 Wrap=�6F   $�� ��6Z   $	��Top=�6b   $	��333��6z   $��30��6�   
���   �$��117,146,0,0q�6�   ���	#FFF8EDFF6�   �� 5   
   $��20(�6   $��SemiBold"�6"   $
��Left=�68   $��8,193,0,382q�6S   $ Center=�6h   
���   �$��98��6�   �� 6�   $ ru-ru�6�   $�Телефон��6�   6�   �� 5   
   -   5        $ Phone_TextBox��5      $
��Left=�6*   $
 Wrap=�6E   $�� ��6Y   $	��Top=�6a   $	��331��6y   $��30��6�   
���   �$��117,191,0,0q�6�   ���	#FFF8EDFF6�   �� 5   
   $��20(�6   $��SemiBold"�6"   $
��Left=�68   $��6,234,0,339q�6S   $ Center=�6h   
���   �$	��100��6�   �� 6�   $ ru-ru�6�   $�
Почта��6�   6�   �� 5   
   -   5        $ Email_TextBox��5      $
��Left=�6)   $
 Wrap=�6D   $�� ��6X   $	��Top=�6`   $	��333��6x   $��31��6�   
���   �$��117,234,0,0q�6�   ���	#FFF8EDFF6�   �� 5   
   -   5        ���	#FFF6DCFF$ ��Забронировать��5   >   $
��Left=�6V   $��24(�6q   $	��364��5   	   $��50��6   
�������
���   �$��Malgun Gothic)�6H   $
��Bold"�6d   $��582,56,0,494q�5   	   �� 5   
   -   5         ��Name$ Trips_ListView��5      $��19,350,21,10q�6+    �� View 5      �� 5      .P�5       �� $1��+Индификатор транспорта��6%    �� Width$	 170��6E    �� DisplayMemberBinding 6Q   �� *TransportId+�� 5!      $5��/Индификатор пользователя��6%   $	 170��6G    6S   �� *UserId+�� 5"      $��Описание��6%   $	 300��67    6C   �� *Description+�� 5#      $��Дата начала��6%   $	 120��6:    6F   �� *	Startdt+�� 5$      $��Длительность��6%   $	 100��6;    6G   �� *
Duration+�� 5%      $��Стоимость��6%   $	 100��68    6D   �� *	CostValue+�� 5&      $��Оплачено��6%   $ 80��67   	 �� CellTemplate	 5'      �� 5(      .R�5)   "   �� ${�False��6H   
 d� 	IsChecked
 6+   �� *IsPaid+6H   5*      5,      5-      5/      �� 51   
   $.��(Информация о поездках��6   $��30(�62   $
��Left=�6@   $��19,300,0,237q�6[   $
��Bold"�6q   $	��618��6�    � 53   
   -   5          �Name$ 	MainFrame��53        � NavigationUIVisibility$ Hidden=�6#   54      55      