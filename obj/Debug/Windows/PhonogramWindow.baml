   M S B A M L   `   `   `  ����T  PEgyptianDictionary-SQLite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:EgyptianDictionary_SQLite.Windows!EgyptianDictionary_SQLite.Windows  5   	   7    1EgyptianDictionary_SQLite.Windows.PhonogramWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:EgyptianDictionary_SQLite.Windows     5   	     � Title$7  1Редактирование фонограммы��5   	   $	��500��6+   $	��700��68    � 
ResizeMode$ NoResize=�5	   
    � WindowStartupLocation$ CenterScreen=�5
   	   $��Segoe UI Historic)�5   	   $��16(�5   	   ���#fff2b2 � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       '�� G     �� 5   
   " ��6   .�5      ��  � ��$ 8q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 8q�6'   5      5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5       .+�5"   
   �� $��Иероглиф��6   �� 5#   
   $��Код Гардинера��6   $��1��6)   �� 5$   
   $"��Транслитерация��6   $��2��6*   �� 5%   
   $��Manuel de Cotage��6   $��3��6,   �� 5'   
   $��32(�6*   $��1��68   ��6   �� *Glyph+68   �� 5(   
   $��1��60   $��1��6@   ��6   �� *GardinerCode+6@   �� 5)   
   $��1��63   $��2��6C   ��6   �� *Transliteration+6C   �� 5*   
   $��1��60   $��3��6@   ��6   �� *ManuelCotage+6@   �� 5,   
   $��Center=�6   	 �� Orientation$	 
Horizontal=�62   $��4��6K   $��2��6X   .+�5-      �� -   5        ���#28666e
�������
�������$��35��51      $	��100��52      $��	25,0,25,0q�53      
 �� 	IsDefault
 . $��60��54   7   .��6E   OK6I   �� 55      ���#28666e
�������
�������$��35��59      $	��100��5:      $��	25,0,25,0q�5;       �� IsCancel . $��60��5<   !   .��6/   Отмена67   5=      5>      5?      