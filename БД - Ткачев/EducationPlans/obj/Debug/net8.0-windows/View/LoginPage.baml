   M S B A M L   `   `   `  ����I  EEducationPlans, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:EducationPlans.ViewEducationPlans.View  5      #    EducationPlans.View.LoginPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:EducationPlans.View     5        N� Title$  	LoginPage��5       N� 
Background
 �����.��5
      � -   5         �Name$ MainGrid��5
      .+�5   
   �� $ ��Вход в аккаунт��6   $��50(�6*   $��368,61,368,476q�68   $��Times New Roman)�5   	   $
��Bold"�6&   
���   �68   �� 5   
   -   5        ���	#FFE7EFF4   ButtonStyle#��[  5   <   $��
Войти��5   	   $��Center=�6   $	��398��66   $	��NaN��6B   
�������
���   �$��Times New Roman)�5      $��26(�69   $��
0,489,0,57q�6G   $
��Bold"�6[   �� 5   
   -   5         ��Name$ nameTextBox��5      $��Имя��5   
   $��Times New Roman)�6     TextBoxStyle#��[ 62   ���	#FFF0F6FA$��20(�5   !   $��341,166,341,0q�6/   $	��Top=�6F   ���	#FF15325B$��41��5   !   �� 5   
   -   5        $ loginTextBox��5      $��
Логин��5      $��Times New Roman)�6   #��[ 67   ���	#FFF0F6FA$��20(�5   $   $��341,230,341,0q�62   $	��Top=�6I   ���	#FF15325B$��41��5   $   �� 5   
   -   5        $ passwordTextBox��5      $��Пароль��5      $��Times New Roman)�6   #��[ 68   ���	#FFF0F6FA$��20(�5   $   $��341,289,341,0q�62   $	��Top=�6I   ���	#FF15325B$��41��5   $   �� 5!   
   -   5        $ specializationTextBox��5!      $ ��Специализация��5"      $��Times New Roman)�6"   #��[ 6?   ���	#FFF0F6FA$��20(�5#   $   $��341,347,341,0q�62   $	��Top=�6I   ���	#FF15325B$��41��5$   $   �� 5&   
   -   5        $ groupTextBox��5&      $��Группа��5'   
   $��Times New Roman)�6   #��[ 65   ���	#FFF0F6FA$��20(�5(   !   $��341,403,341,0q�6/   $	��Top=�6F   ���	#FF15325B$��45��5)   !   �� 5+   
   $
��Left=�6   $��758,351,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   $	��274��5,      $��Times New Roman)�6    $��14(�6=   ���	#FFACC6D7$����*Eсли вы преподаватель, то укажите специализацию, но не указывайте группу��5-      $��
UltraLight"�6e   $��WordEllipsis=�6}   �� 5/   
   $
��Left=�6   $��758,409,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   $	��250��50      $��Times New Roman)�6    $��14(�6=   ���	#FFACC6D7$��y*Eсли вы студент, то укажите группу, но не указывайте специализацию��51      $��
UltraLight"�6_   $��WordEllipsis=�6w    � 53   
   -   5          �Name$ 	MainFrame��53        � NavigationUIVisibility$ Hidden=�6#   $��Stretch=�6C   $��Stretch=�6a    K� ZIndex$ 10��6}   54      55      