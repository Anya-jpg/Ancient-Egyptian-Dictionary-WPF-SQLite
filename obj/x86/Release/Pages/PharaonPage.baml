   M S B A M L   `   `   `  ���� T  PEgyptianDictionary-SQLite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:EgyptianDictionary_SQLite.PagesEgyptianDictionary_SQLite.Pages  1    +EgyptianDictionary_SQLite.Pages.PharaohPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ?local-clr-namespace:EgyptianDictionary_SQLite.Pages       N� Title$  PharaonPage�� N� 
FontFamily$ Segoe UI Historic)�.���  � ColumnDefinitions �� $��74 ��� .+��� $��1��.+�� $	��100�� �� $
��auto ��� ��  � RowDefinitions �� $
��auto ��� �� .+��� $��24(�$
��Bold"�$��Center=�$��3��$��0��.��1/Древнеегипетские фараоны�� $��1��.��'%Введите имя фараона:�� $��2��.��USВведите ключевые слова для поиска в описании:�� -   $��TBSearchName��$��2q�$��1��$��1���� -   $��TBSearchWords��$��2q�$��2��$��1���� -   $��BSearh��$��	10,2,10,2q����#28666e
�������
�������$��14(�$
��Bold"�$��1��$��2��.��
Поиск�� -   $��BEdit��$��	10,2,10,2q����#28666e
�������
�������$��14(�$
��Bold"�$��2��$��2��.��Редактировать� $��20��$��8,5,0,0q� �� $	��100 ��� $	��150 ��� $	��190 ��� $	��150 ��� $	��190 ��� $	��100 �.+��� $��0�� �� TextAlignment$ Center=�$��Имя�����#28666e
������� �� 
IsReadOnly . $��1,1,1,1q�
��������� $��1��$ Center=�$$��Имя при рождении�����#28666e
������� . $��0,1,1,1q�
��������� $��2��$ Center=�$��Описание�����#28666e
������� . $��0,1,1,1q�
��������� $��3��$ Center=�$��Тронное имя�����#28666e
������� . $��0,1,1,1q�
��������� $��4��$ Center=�$��Описание�����#28666e
������� . $��0,1,1,1q�
��������� $��5��$ Center=�$��Династия�����#28666e
������� . $��0,1,1,1q�
��������� -   $��LViewPharaohs��$��Visible=�$	��575��
������ $��0,0,0,0q����� .R��� ���#e8c27b$��1q� �� CornerRadius$ 
8, 8, 3, 3��._�� ���#fff2b2 �� $	��100 ��� $	��150 ��� $	��190 ��� $	��150 ��� $	��190 ��� $	��100 �.+��� $��0��$ Center=� �� TextWrapping$
 Wrap=� . 
������ $��0,0,0,0q����#e8c27b���� *Name+�� $��1��$ Center=�$
 Wrap=� . 
������ $��1,0,0,0q����#e8c27b���� *	BirthName+�� $��2��$ Center=�$
 Wrap=� . 
������ $��1,0,0,0q����#e8c27b$
��Left=����� *BirthDescription+�� $��3��$ Center=�$
 Wrap=� . 
������ $��1,0,0,0q����#e8c27b���� *
ThroneName+�� $��4��$ Center=�$
 Wrap=� . 
������ $��1,0,0,0q����#e8c27b���� *ThroneDescription+�� $��5��$ Center=�$
 Wrap=� . 
������ $��1,0,0,0q����#e8c27b���� *	Dynasty+