   M S B A M L   `   `   `  ���� T  PEgyptianDictionary-SQLite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:EgyptianDictionary_SQLiteEgyptianDictionary_SQLite  *    $EgyptianDictionary_SQLite.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     9local'clr-namespace:EgyptianDictionary_SQLite       � Title$  
MainWindow��$	��800��$
��1000�� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=�$��Segoe UI Historic)�.���  � RowDefinitions �� $��25 ��� .+�� ���#033f63.+���  �� Orientation$ 
Horizontal=�$��Right=�.+��� -   $��20��$��20��$
��Bold"�
������ $��0q�
�������$��0,0,5,0q�.��—�� -   $��20��$��20��$
��Bold"�
������ $��0q�
�������.��🞪� ���#fff2b2$��1��.+�� -    �Name$ BG��.+� � -   $��Frame��  � Source$ Pages/GodsPage.xaml?�  � NavigationUIVisibility$ Hidden=�� -   $ nav_pnl��$
��Left=�$��74�����#28666e.+��� -   	 ��Name$	 st_pnl��.+�� $��90��.+��� $��1��$��0��$��
73,-20,0,0q�$��M E N U��
�������$��22(�
������ $
��Left=�$��Center=�   
font_style#��[  
 J� Effect
 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 10Q�   ShadowDepth$ 1Q�   	Direction$	 -90Q�   Color$ White��d� -    d�Name$ Tg_Btn��$��0��$��Center=�$
��Left=�$��
20,-20,0,0q�$��30��$��30��$��0q�  tb_style#��[ ����  �� ImageSource$ Assets/tgBtn_default.png�� j� Stretch$
 None=� � Triggers :�  :� RoutedEvent$ ToggleButton.Unchecked��.[��� .���� -    ��Name$ HideStackPanel��.��W�  �� 
TargetName$ nav_pnl�� �� TargetProperty$ Width� g� 	BeginTime$ 0:0:0X� W� From$	 230X�	 W� To$ 74X� g� Duration$ 0:0:0.2D�:� $ ToggleButton.Checked��.[��� .���� -	   $ ShowStackPanel��.��W� $ nav_pnl��$ Width�$ 0:0:0X�$ 74X�$	 230X�$ 0:0:0.3D��� -
    ��Name$ LV��
������ 
������ $��Disabled=�.@��� -   $��LV_Alphabet��$
��Left=�$��0,0,0,20q�.���� $ 
Horizontal=�$	��230��.+��� $��Assets/img_alphabet.png��$��7,0,0,0q��� $��Фонограммы��$��25,0,0,0q�#��[   � ToolTip _� -    _�Name$ tt_alphabet��$��Фонограммы��  tt_style#��[ �� -   $��LV_Dictionary��$
��Left=�$��0,0,0,20q�.���� $ 
Horizontal=�$	��230��.+��� $��Assets/img_dictionary.png��$��7,0,0,0q��� $��Словарь��$��25,0,0,0q�#��[   _� -   $ tt_dictionary��$��Словарь��#��[ �� -   $��LV_Pharaons��$
��Left=�$��0,0,0,20q�.���� $ 
Horizontal=�$	��230��.+��� $��Assets/img_pharaoh.png��$��7,0,0,0q��� $��Фараоны��$��25,0,0,0q�#��[   _� -   $ 
tt_pharaon��$��Фараоны��#��[ �� -   $��LV_Gods��$
��Left=�$��0,0,0,20q�.���� $ 
Horizontal=�$	��230��.+��� $��Assets/img_god.png��$��7,0,0,0q��� $��Божества��$��25,0,0,0q�#��[   _� -   $ tt_gods��$��Божества��#��[ �� -   $��
LV_Profile��$
��Left=�$��
0,270,0,20q�.���� $ 
Horizontal=�$	��230��.+��� -   $��TBPhoto�� �� 	MaxLength$ 1��$��32(�$��3q����#e8c27b
�������$��Center=�$��-8q�$��Center=� �� TextAlignment$ Center=�$��40��$��40��$��12,0,0,0q�  �� 
IsReadOnly  . �� $��Профиль��$��25,0,0,0q�#��[   _� -   $ 
tt_profile��$��Профиль��#��[ �� -   $��LV_Exit��$
��Left=�$��0,0,0,20q�.���� $ 
Horizontal=�$	��230��.+��� $��Assets/img_logout.png��$��7,0,0,0q��� $��
Выйти��$��25,0,0,0q�#��[   _� -   $ tt_exit��$��
Выйти��#��[ ���� ! �� 
TargetType"! ��.��� " �� Property" � ��# �� Value# �� $ �� 
TargetType"$ ��.R��� % ��Name$% Bd��$��50��#��z��#��z��#��z��& �� Padding#& z��' J� SnapsToDevicePixels' . ._��� #��z��#' z' #��z��( �� Triggers( ]� ) ]� 
Conditions) �� * �� Property* �@J�IsMouseOver+ �� Value+ . ./��� , �� 
TargetName$, Bd��" � ��# �#43838c