   M S B A M L   `   `   `  ���� T  PEgyptianDictionary-SQLite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:EgyptianDictionary_SQLite.PagesEgyptianDictionary_SQLite.Pages  3    -EgyptianDictionary_SQLite.Pages.PhonogramPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ?local-clr-namespace:EgyptianDictionary_SQLite.Pages       N� Title$  PhonogramPage�� N� 
FontFamily$ Segoe UI Historic)�.���  � ColumnDefinitions �� $��74 ��� .+��� $��1��.+�� $	��150�� �� $
��auto ��� ��  � RowDefinitions �� $
��auto ��� �� �� .+��� $��24(�$
��Bold"�$��Center=�$��3��$��0��.��75Древнеегипетские фонограммы�� $��1��.��64Введите иероглиф на Юникоде:�� $��2��.��IGВведите код или его часть по Гардинеру:�� $��3��.��ECВведите транслитерацию или ее часть:�� -   $��TBSearchUnicode��$��5q�$��1��$��1���� -   $��TBSearchGardiner��$��5q�$��2��$��1���� -   $��TBSearchTransliteration��$��5q�$��3��$��1���� -   $��BSearh��$��20q����#28666e
�������
�������$��14(�$
��Bold"�$��2��$��1��$��2��.��
Поиск�� -   $��BEdit��$��
20,0,20,00q����#28666e
�������
�������$��14(�$
��Bold"�$��2��$��3��$��2��.��Редактировать� $��50��$��0,0,0,20q�.+���  �� Orientation$ 
Horizontal=�$��Center=�$��40,0,0,0q�.+��� -   
 J� Uid$ 0��$��Алфавит��$��25��$	��284��
���   �$��0,0,0,0q����#e8c27b��Z� �� -   $ 1��$)��#Двусогласные знаки��$��25��$	��284��
���   �$��1,0,0,0q����#e8c27b��Z� �� -   $ 2��$+��%Трехсогласные знаки��$��25��$	��284��
���   �$��1,0,0,0q����#e8c27b��Z� � -	    �Name$ 
GridCursor��$	��284��$��5�����#28666e$��Bottom=�$
��Left=�$��40,0,0,0q�� $��20��$��196,0,151,0q� �� $	��100 ��� $	��150 ��� $	��150 ��� $	��150 �.+��� $��0�� �� TextAlignment$ Center=�$��Иероглиф�����#28666e
������� �� 
IsReadOnly . $��1,1,1,1q�
��������� $��1��$ Center=�$��Код Гардинера�����#28666e
������� . $��0,1,1,1q�
��������� $��2��$ Center=�$"��Транслитерация�����#28666e
������� . $��0,1,1,1q�
��������� $��3��$ Center=�$��Manuel de Codage�����#28666e
������� . $��0,1,1,1q�
��������� -
   $��LViewPhonogram��$��Visible=�$	��535��$��188,0,151,0q�
������ $��0,0,0,0q����� .R��� ���#e8c27b$��1q�	 �� CornerRadius$	 
8, 8, 3, 3��._�� ���#fff2b2 �� $	��100 ��� $	��150 ��� $	��150 ��� $	��150 �.+��� $��0��$ Center=�
 �� TextWrapping$

 Wrap=� . 
������ $��0,0,0,0q����#e8c27b$��50(�$��75������ *Glyph+�� $��1��$ Center=�$

 Wrap=� . 
������ $��1,0,0,0q����#e8c27b$��75������ *GardinerCode+�� $��2��$ Center=�$

 Wrap=� . 
������ $��1,0,0,0q����#e8c27b$��75������ *Transliteration+�� $��3��$ Center=�$

 Wrap=� . 
������ $��1,0,0,0q����#e8c27b$��75������ *ManuelCotage+