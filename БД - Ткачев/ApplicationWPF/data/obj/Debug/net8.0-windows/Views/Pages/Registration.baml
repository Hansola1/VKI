   M S B A M L   `   `   `  ����?  ;data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:data.Views.Pagesdata.Views.Pages  5      #    data.Views.Pages.Registration   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:data.Views.Pages     5        N� 
Background
  ����� N� Title$ Registration��5	      .��5      � .+�5   
   �� $��Регистрация��6   $��50(�6'   $
��Bold"�65   $��Center=�6G   $	��Top=�5      
���   �$	��310��69   $��0,36,0,0q�6E   �� 5   
   $��Имя��6   $��30(�6   $��SemiBold"�6-   $
��Left=�6C   $	��Top=�5      
���   �$	��120��69   $��298,200,0,0q�6E   �� 5   
   -   5         ��Name$ name_TextBox��5      $��25(�6)      searchTextbox#��[  67   $
��Left=�6^    �� TextWrapping$
 Wrap=�6y   $�� ��5      $	��300��6   $��52��6    
���   ����	#FFF8EDFF$��450,206,0,0q�5   $   $	��Top=�69   �� 5   
   $��
Логин��6   $��30(�6!   $��SemiBold"�6/   $
��Left=�6E   $	��Top=�5      
���   �$	��120��69   $��298,258,0,0q�6E   �� 5   
   -   5        $ login_TextBox��5      $��25(�6*   #��[  68   $
��Left=�6_   $
 Wrap=�6z   $�� ��5      $	��300��6   $��52��6    
���   ����	#FFF8EDFF$��450,264,0,0q�5   $   $	��Top=�69   �� 5   
   $��Пароль��6   $��30(�6"   $��SemiBold"�60   $
��Left=�6F   $	��Top=�5   	   
���   �$	��120��64   $��298,318,0,0q�6@   �� 5    
   -   5        $ password_TextBox��5       $��25(�6-   #��[  6;   $
��Left=�6b   $
 Wrap=�6}   $�� ��5!   	   $	��300��6   $��52��6   
���   ����	#FFF8EDFF$��450,324,0,0q�5"       $	��Top=�65   �� 5$   
   $��
Почта��6   $��30(�6!   $��SemiBold"�6/   $
��Left=�6E   $	��Top=�5%   	   
���   �$	��120��64   $��298,375,0,0q�6@   �� 5'   
   -   5        $ email_TextBox��5'      $��25(�6*   #��[  68   $
��Left=�6_   $
 Wrap=�6z   $�� ��5(   
   $	��300��6   $��52��6   
���   ����	#FFF8EDFF$��450,381,0,0q�5)       $	��Top=�65   �� 5+   
   $��Возраст��6   $��30(�6#   $��SemiBold"�61   $
��Left=�6G   $	��Top=�5,   	   
���   �$	��120��64   $��298,432,0,0q�6@   �� 5.   
   -   5        $ age_TextBox��5.      $��25(�6(   #��[  66   $
��Left=�6]   $
 Wrap=�6x   $�� ��5/   	   $	��300��6   $��52��6   
���   ����	#FFF8EDFF$��450,438,0,0q�50       $	��Top=�65   �� 52   
   $��Пол��6   $��30(�6   $��SemiBold"�6-   $
��Left=�6C   $	��Top=�53   	   
���   �$��78��64   $��298,489,0,0q�6?   �� 55   
   -   5        $ sex_TextBox��55      $��25(�6(   #��[  66   $
��Left=�6]   $
 Wrap=�6x   $�� ��56   	   $	��300��6   $��52��6   
���   ����	#FFF8EDFF$��450,495,0,0q�57       $	��Top=�65   �� 59   
   -   5        ���	#FFF2CFFF  	topButton#��[ 59   :   $*��$Зарегистрироваться��5:   
   $	��Top=�6(   $	��420��6@   $��62��6L   
�������
���   �$��Malgun Gothic)�5;      $
��Bold"�68   $��25(�6J   $��Center=�6X   $��	0,594,0,0q�6u   �� 5=   
   -   5        ���	#FFE2E2E2#��[ 5=   <   $��
Войти��5>      $	��Top=�6   $	��210��66   $��62��6B   
�������
���   �$��Malgun Gothic)�5?       $
��Bold"�6;   $��25(�6M   $
��Left=�6[   $��522,124,0,0q�6v   �� 5@   
   $��30(�6   $��SemiBold"�6"   $
��Left=�68   $	��Top=�5A      
���   �$	��219��68   $��298,133,0,0q�6D   �� 6Z    � Language$ ru-ru�6^   $�Есть аккаунт?��6o   6�    � 5C   
   -	   5          �Name$ 	MainFrame��5C        � NavigationUIVisibility$ Hidden=�6#   5D      5E      