   M S B A M L   `   `   `  ����T  PEgyptianDictionary-SQLite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:EgyptianDictionary_SQLite.Windows!EgyptianDictionary_SQLite.Windows  5   	   5    /EgyptianDictionary_SQLite.Windows.PharaohWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:EgyptianDictionary_SQLite.Windows     5   	     � Title$1  +Редактирование фараона��5   	   $	��450��6(   $	��800��65    � 
ResizeMode$ NoResize=�5	   
    � WindowStartupLocation$ CenterScreen=�5
   	   $��Segoe UI Historic)�5   	   $��16(�5   	   ���#fff2b2 � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       '�� G     �� 5   
   " ��6   .�5      ��  � ��$ 8q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 8q�6'   5      5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5    
   �� 5!      $
��auto �6   �� 5"      .+�5$   
   �� $��Имя��6   �� 5%   
   $$��Имя при рождении��6   $��1��6,   �� 5&   
   $?��9Расшифровка имени при рождении��6   $��2��6:   �� 5'   
   $��Тронное имя��6   $��3��6'   �� 5(   
   $8��2Расшифровка тронного имени��6   $��4��66   �� 5)   
   $��Династия��6   $��5��6$   �� 5+   
   $��1��6(   ��6   �� *Name+6(   �� 5,   
   $��1��6-   $��1��6=   ��6   �� *	BirthName+6=   �� 5-   
   $��1��64   $��2��6D   ��6   �� *BirthDescription+6D   �� 5.   
   $��1��6.   $��3��6>   ��6   �� *
ThroneName+6>   �� 5/   
   $��1��65   $��4��6E   ��6   �� *ThroneDescription+6E   �� 50   
   $��1��6+   $��5��6;   ��6   �� *	Dynasty+6;   �� 52   
   $��Center=�6   	 �� Orientation$	 
Horizontal=�62   $��6��6K   $��2��6X   .+�53      �� -   5        ���#28666e
�������
�������$��35��57      $	��100��58      $��	25,0,25,0q�59      
 �� 	IsDefault
 . $��60��5:   7   .��6E   OK6I   �� 5;      ���#28666e
�������
�������$��35��5?      $	��100��5@      $��	25,0,25,0q�5A       �� IsCancel . $��60��5B   !   .��6/   Отмена67   5C      5D      5E      