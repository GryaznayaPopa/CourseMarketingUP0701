   M S B A M L   `   `   `  ����J  FCourseMarketing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CourseMarketingCourseMarketing  5   	   (    "CourseMarketing.EditContractWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:CourseMarketing     5   	     � Title$  EditContractWindow��5   	   $��528.309��6$   $	��800��65      windowStyle#��[  6A   .��5	      � .+�5
   
   �� -   5         ��Name$ NContractBox��5
      $
��Left=�6(   $��23��6C   $��
345,69,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��120��6�   �� 5   
   -   5        $ DateCreationBox��5      $
��Left=�6+   $��23��6F   $��345,110,0,0q�6R   $
 Wrap=�6g   $�� ��6{   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ DateExecBox��5      $
��Left=�6'   $��23��6B   $��345,149,0,0q�6N   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��120��6�   �� 5   
   -   5        $ DescriptionBox��5      $
��Left=�6*   $��39��6E   $��345,227,0,0q�6Q   $
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��209��6�   �� 5   
   $��Клиент��6   $
��Left=�6!   $��
200,25,0,0q�6<   $	��Top=�6P   �� 5   
   $!��Номер договора��6   $
��Left=�6)   $��
200,65,0,0q�6D   $	��Top=�6X   �� 5   
   $%��Дата составления��6   $
��Left=�6+   $��200,106,0,0q�6F   $	��Top=�6[   �� 5   
   $#��Дата исполнения��6   $
��Left=�6+   $��200,145,0,0q�6F   $	��Top=�6[   �� 5   
   $%��Состояние оплаты��6   $
��Left=�6+   $��200,185,0,0q�6F   $	��Top=�6[   �� 5   
   $)��#Подробности заказа��6   $
��Left=�6-   $��200,227,0,0q�6H   $	��Top=�6]   �� 5   
   $��Статус заказа��6   $
��Left=�6(   $��203,293,0,0q�6C   $	��Top=�6X   �� 5   
   $��Услуга��6   $
��Left=�6!   $��203,337,0,0q�6<   $	��Top=�6Q   �� 5   
   -   5         ��Name$ FIOClientCombo��5      $
��Left=�6+   $��
345,25,0,0q�6i   $	��Top=�6}   $	��120��6�    �� SelectedItem 6F   �� *	FIOClient+��5      �� 5      .R�5      �� ��5      `� 5       �� StringFormat$  {0} {1} {2}��6+   .1�5   "   ��  �� Path$
 Name�6*   �� 5   "   $ Surname�6*   �� 5   "   $ 
Patronymic�6*   5      5!      5"      5$      �� 5%   
   -   5        $ PayStatusBox��5%      $
��Left=�6)    �� DisplayMemberPath$ Name_Status_payment��6g   $��345,185,0,0q�6�   $	��Top=�6�   $	��120��6�    6D   �� *	StatusPay+6�   �� 5&   
   -   5        $ StatusContcractBox��5&      $
��Left=�6/   $ Name_Status_Order��6r   $��345,293,0,0q�6�   $	��Top=�6�   $	��120��6�    6J   �� *StatusContract+6�   �� 5'   
   -   5        $ ServiceContractBox��5'      $
��Left=�6/   $��345,341,0,0q�6J   $ Name_Service��6�   $	��Top=�6�   $	��120��6�    6_   �� *	Service+6�   �� 5(   
   -	   5         ��Name$ SaveContractButton��5(      $+��%Сохранить изменения��6-   $
��Left=�6K   $��345,439,0,0q�6f   $	��Top=�6{   $��75��6�   6�   5*      5+      