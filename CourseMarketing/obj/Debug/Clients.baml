   M S B A M L   `   `   `  ����J  FCourseMarketing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CourseMarketingCourseMarketing  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       CourseMarketing.Clients   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:CourseMarketing     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	   -   5          � Title$  Clients��5	   	   $	��450��6   $��990.809��6&      windowStyle#��[  6M   .��5
      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ GridClientsData��5      $
��Left=�6,   $	��286��6G   $��
10,123,0,0q�6T   $	��Top=�6h   $	��813��6�      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 №��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 60   �� *	NumberC+  5      $ Имя��6%    62   �� *Name+  5      $ Фамилия��6%    66   �� *	Surname+  5      $ Отчество��6%    67   �� *
Patronymic+  5      $/ )Наименование компании��6%    6D   �� *NameCompany+  5      $! Номер телефона��6%    6=   �� *PhoneNumber+  5      $' !Электронная почта��6%    6@   �� *Email+4  .System.Windows.Controls.DataGridTemplateColumn  5      $" Редактирование��6)      CellTemplate 5      �� 5      .R�5      �� -   5        $"��Редактирование��5   =   
 � Tag 6%   �� *	NumberC+6X   5      5        5      $ Удаление��6)    5      �� 5      .R�5      �� -   5        $��Удаление��5   =    6%   �� *	NumberC+6R   5      5!      5#      �� 5$   
   -   5         ��Name$ ButtonBackMenu��5$      $��
Назад��6)   $
��Left=�69   $��842,304,0,0q�6T   $	��Top=�6i   $��94��6�   6�   �� 5%   
   -   5        $ ButtonCloseClient��5%      $��
Выход��6,   $
��Left=�6<   $��842,358,0,0q�6W   $	��Top=�6l   $��94��6�   6�   �� 5&   
   -   5        $ AddClientButton��5&      $%��Добавить клиента��6*   $
��Left=�6E   $��	10,81,0,0q�6`   $	��Top=�6s   $	��135��6�   $��37��6�   6�   �� 5'   
   -   5        	 ��Name$	 SearchBoxClient��5'      $
��Left=�6+   $��26��6F   $��
357,81,0,0q�6R   
 �� TextWrapping$

 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��193��6�   6�   �� 5(   
   -	   5         ��Name$ FiltrClientCombo��5(      $
��Left=�6O    �� DisplayMemberPath$ Surname��6j   $��
796,28,0,0q�6�   $	��Top=�6�   $	��120��6�    �� SelectedItem 6.   �� *	ClientM+��6�   �� *My+5*      �� 5+   
   $"��Поиск компании:��6   $
��Left=�6*   $��
235,81,0,0q�6E   $	��Top=�6Y   �� 5,   
   -
   5        $ CancelFiltrClient��5,      $'��!Отмена фильтрации��6,   $
��Left=�6H   $��
796,66,0,0q�6c   $	��Top=�6w   $	��120��6�   6�   �� 5-   
   $&�� Фильтр по фамилии��6   $
��Left=�6,   $��
670,28,0,0q�6G   $	��Top=�6[   50      51      