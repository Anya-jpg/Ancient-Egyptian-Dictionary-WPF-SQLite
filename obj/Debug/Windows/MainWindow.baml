   M S B A M L   `   `   `  ����T  PEgyptianDictionary-SQLite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:EgyptianDictionary_SQLiteEgyptianDictionary_SQLite  5   	   *    $EgyptianDictionary_SQLite.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:EgyptianDictionary_SQLite     5   	   -   5          � Title$  
MainWindow��5      $	��800��5	   	   $
��1000��5
   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   $��Segoe UI Historic)�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $��25 �6   6*   �� 5      6   .+�5   
   � ���#033f63.+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�5      .+�5      �� -   5        $��20��5      $��20��5      $
��Bold"�5      
������ $��0q�5      
�������$��0,0,5,0q�5       .��5!   1   —64   �� 5"      -   5        $��20��5"      $��20��5#      $
��Bold"�5$      
������ $��0q�5&      
�������.��5(   .   🞪62   5)      5*      � 5+   
   ���#fff2b2$��1��6$   .+�5-      � -   5         �Name$ BG��5-      .+�5.       � -   5        $��Frame��5.        � Source$  /Pages/DictionaryPage.xaml?�6%     � NavigationUIVisibility$ Hidden=�6I   6k   5/      � 52      -   5        $ nav_pnl��52      $
��Left=�53      $��74��54      ���#28666e.+�56      �� -   5        	 ��Name$	 st_pnl��56      .+�58      � $��90��6   .+�5:      �� $��1��6%   $��0��5;   %   $��
73,-20,0,0q�5<   %   $��M E N U��5=   %   
�������$��22(�5?   %   
������ $
��Left=�5A   %   $��Center=�5B   %      
font_style#��[  5C   %   
 J� Effect
 5E      3  -System.Windows.Media.Effects.DropShadowEffect  5F   "      
BlurRadius$ 10Q�64      ShadowDepth$ 1Q�5G   4      	Direction$	 -90Q�5H   4      Color$ White��5I   4   5K      d� 5M      -   5         d�Name$ Tg_Btn��5M   '   $��0��5N   '   $��Center=�5O   '   $
��Left=�5P   '   $��
20,-20,0,0q�5Q   '   $��30��5R   '   $��30��5S   '   $��0q�5T   '     tb_style#��[ 5U   '   ��5W      �� 5X   "    �� ImageSource$ /Assets/tgBtn_default.png��6-    j� Stretch$
 None=�5Y   -    � Triggers 5\      :� 5]   "    :� RoutedEvent$ ToggleButton.Unchecked��6/   .[�5^   &   �� .��5_   *   �� -	   5         ��Name$ HideStackPanel��5_   5   .��5`   .   W�  �� 
TargetName$ nav_pnl��5a   1    �� TargetProperty$ Width�5b   1    g� 	BeginTime$ 0:0:0X�5c   1    W� From$	 230X�5d   1   	 W� To$ 74X�6<    g� Duration$ 0:0:0.2D�5e   1   5f   /   5g   +   5h   '   5i   #   :� 5j   "   $ ToggleButton.Checked��6/   .[�5k   &   �� .��5l   *   �� -
   5        $ ShowStackPanel��5l   5   .��5m   .   W� $ nav_pnl��5n   1   $ Width�5o   1   $ 0:0:0X�5p   1   $ 74X�5q   1   $	 230X�6;   $ 0:0:0.3D�5r   1   5s   /   5t   +   5u   '   5v   #   5x      5y      �� 5{      -   5         ��Name$ LV��5{       
������ 
������ $��Disabled=�5~       .@�5�      �� -   5        $��LV_Alphabet��5�   '   $
��Left=�6:   $��0,0,0,20q�5�   '   .��5�      �� $ 
Horizontal=�6)   $	��230��5�   )   .+�5�   "   �� $��/Assets/img_alphabet.png��6(   $��7,0,0,0q�5�   (   �� 5�   "   $��Фонограммы��6,   $��25,0,0,0q�5�   ,   #��[  5�   ,   5�       � ToolTip 5�      _� 5�   "   -   5         _�Name$ tt_alphabet��5�   *   $��Фонограммы��5�   *     tt_style#��[ 5�   *   5�      �� 5�      -   5        $��LV_Dictionary��5�   '   $
��Left=�6<   $��0,0,0,20q�5�   '   .��5�      �� $ 
Horizontal=�6)   $	��230��5�   )   .+�5�   "   �� $ ��/Assets/img_dictionary.png��6(   $��7,0,0,0q�5�   (   �� 5�   "   $��Словарь��6,   $��25,0,0,0q�5�   ,   #��[  5�   ,   5�       5�      _� 5�   "   -   5        $ tt_dictionary��5�   *   $��Словарь��5�   *   #��[ 5�   *   5�      �� 5�      -   5        $��LV_Pharaons��5�   '   $
��Left=�6:   $��0,0,0,20q�5�   '   .��5�      �� $ 
Horizontal=�6)   $	��230��5�   )   .+�5�   "   �� $��/Assets/img_pharaoh.png��6(   $��7,0,0,0q�5�   (   �� 5�   "   $��Фараоны��6,   $��25,0,0,0q�5�   ,   #��[  5�   ,   5�       5�      _� 5�   "   -   5        $ 
tt_pharaon��5�   *   $��Фараоны��5�   *   #��[ 5�   *   5�      �� 5�      -   5        $��LV_Gods��5�   '   $
��Left=�66   $��0,0,0,20q�5�   '   .��5�      �� $ 
Horizontal=�6)   $	��230��5�   )   .+�5�   "   �� $��/Assets/img_god.png��6(   $��7,0,0,0q�5�   (   �� 5�   "   $��Божества��6,   $��25,0,0,0q�5�   ,   #��[  5�   ,   5�       5�      _� 5�   "   -   5        $ tt_gods��5�   *   $��Божества��5�   *   #��[ 5�   *   5�      �� 5�      -   5        $��
LV_Profile��5�   '   $
��Left=�69   $��
0,270,0,20q�5�   '   .��5�      �� $ 
Horizontal=�6)   $	��230��5�   )   .+�5�   "   �� -   5        $��TBPhoto��5�   *    �� 	MaxLength$ 1��5�      $��32(�5�      $��3q�5�      ���#e8c27b
�������$��Center=�5�      $��-8q�5�      $��Center=�5�       �� TextAlignment$ Center=�5�      $��40��5�      $��40��5�      $��12,0,0,0q�5�        �� 
IsReadOnly  . 5�   /   �� 5�   "   $��Профиль��6,   $��25,0,0,0q�5�   ,   #��[  5�   ,   5�       5�      _� 5�   "   -   5        $ 
tt_profile��5�   *   $��Профиль��5�   *   #��[ 5�   *   5�      �� 5�      -   5        $��LV_Exit��5�   '   $
��Left=�66   $��0,0,0,20q�5�   '   .��5�      �� $ 
Horizontal=�6)   $	��230��5�   )   .+�5�   "   �� $��/Assets/img_logout.png��6(   $��7,0,0,0q�5�   (   �� 5�   "   $��Авторизация��6,   $��25,0,0,0q�5�   ,   #��[  5�   ,   5�       5�      _� 5�   "   -   5        $ tt_exit��5�   *   $��Авторизация��5�   *   #��[ 5�   *   5�      ��5�      �� 5�      ! �� 
TargetType"! ��6$   .�5   "   �� " �� Property" � ��# �� Value# 5  &   �� 5  *   $ �� 
TargetType"$ ��6:   .R�5  .   �� % ��Name$% Bd��65   $��50��5  5   #��z��5  5   #��z��5  5   #��z��5  5   & �� Padding#& z��5  5   ' J� SnapsToDevicePixels' . ._�5
  2   �� #��z��6C   #' z' 5  C   #��z��5  C   5  /   ( �� Triggers( 5  .   ]� 5  2   ) ]� 
Conditions) 5  6   �� 5  :   * �� Property* �@J�IsMouseOver+ �� Value+ . 6[   ./�5  6   �� , �� 
TargetName$, Bd��5  =   " � ��# �#43838c5  =   5  3   5  +   5  #   5     5     5     5     5      5!     5"     