   M S B A M L   `   `   `  ���� T  PEgyptianDictionary-SQLite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:EgyptianDictionary_SQLite.Windows!EgyptianDictionary_SQLite.Windows  8    2EgyptianDictionary_SQLite.Windows.DictionaryWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Alocal/clr-namespace:EgyptianDictionary_SQLite.Windows       � Title$5  /Редактирование иероглифа��$	��700��$	��800�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�$��Segoe UI Historic)�$��16(����#fff2b2 � 	Resources  �� 
TargetType �� Property �� Value��%X   '��       '�� "     �� " ��.���  � ��$ 8q��� " ��.���  � ��$ 8q�.���  � RowDefinitions �� $
��auto ��� �� �� $
��auto ��� �� $
��auto ��� $
��auto ���  � ColumnDefinitions �� $
��auto ��� .+��� $��Иероглиф���� $��Юникод��$��1���� $��Код Гардинера��$��2���� $��Описание��$��3���� $��Фонограмма��$��4���� $"��Транслитерация��$��5���� $��Заметки��$��6���� $��32(�$��1������ *Glyph+�� $��1��$��1������ *	Unicode+�� $��1��$��2������ *GardinerCode+�� $	��100��	 �� AcceptsReturn	 . 
 �� TextWrapping$

 Wrap=�$��1��$��3������ *Description+�� $��1��$��4������ *	Phonogram+�� $	��100��	 . $

 Wrap=�$��1��$��5������ *Transliteration+�� $	��100��	 . $

 Wrap=�$��1��$��6������ *Notes+�� $��Center=� �� Orientation$ 
Horizontal=�$��7��$��2��.+��� -   ���#28666e
�������
�������$��35��$	��100��$��	25,0,25,0q� �� 	IsDefault . $��60��.��OK�� ���#28666e
�������
�������$��35��$	��100��$��	25,0,25,0q� �� IsCancel . $��60��.��Отмена