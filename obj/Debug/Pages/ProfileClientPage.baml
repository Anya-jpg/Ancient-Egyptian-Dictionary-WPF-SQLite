   M S B A M L   `   `   `  ����T  PEgyptianDictionary-SQLite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:EgyptianDictionary_SQLite.PagesEgyptianDictionary_SQLite.Pages  5      7    1EgyptianDictionary_SQLite.Pages.ProfileClientPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:EgyptianDictionary_SQLite.Pages     5        N� Title$  ProfileClientPage��5	       N� 
FontFamily$ Segoe UI Historic)�5
       N� FontSize$ 14(�5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��80 �6   6,   �� 5      6!   .+�5   
   �� $��1��5      
������ .+�5      �� $��24(�5      $
��Bold"�5      $��Center=�5      .��6.   Личный кабинет6>   � 5       5      �� 5      6)   �� 5      6)    � RowDefinitions 5      �� 5      6&   �� 5      6&   �� 5       6&   �� 5!      6&   �� 5"      6&   �� 5#      6&   �� 5$      6&   �� 5%      6&   .+�5'      �� $��Center=�5(       �� TextAlignment$ Center=�5)      $��0��5*      $��0��5+      Тип аккаунта:61   �� 5,      $��Center=�5-      $��1��5.      $��0��5/      Фото профиля:50      �� 51      $��Center=�52      $��0��53      $��2��54      Логин:6*   �� 55      $��Center=�56      $��1��57      $��2��58      Пароль:6+   �� 59      $��Center=�5:      $��0��5;      $��4��5<      	Имя:6(   �� 5=      $��Center=�5>      $��1��5?      $��4��5@      	Пол:6(   �� 5A      -   5        $��TBType��5A      ���#28666e$��30��5C       �� 
IsReadOnly . $��10q�5E      $��0��5F      $��1��5G      6)   �� 5H      -   5        $��TBPhoto��5H       �� 	MaxLength$ 2��5I      $��50(�5J      $��4q�5K      ���#28666e
�������$��Center=�5N       �� TextAlignment$ Center=�5O      $��64��5P      $��64��5Q       . $��10q�5S      $��1��5T      $��1��5U      6)   �� 5V      -   5        $��TBLogin��5V      ���#28666e . $��10q�5Y      $��0��5Z      $��3��5[      6)   �� 5\      -   5        $��
TBPassword��5]      ���#28666e . $��10q�5`      $��1��5a      $��3��5b      6$   �� 5c      -   5        $��TBName��5c      ���#28666e . $��10q�5f      $��0��5g      $��5��5h      6)   �� 5i      -   5        $��CBGender��5i      ���#28666e{�.  $��10q�5l      $��1��5m      $��5��5n      .@�5o      �� -   5        $��CBMale��5o   #   $��Мужской��61   6E   �� 5p      -   5        $��CBFemale��5p   #   $��Женский��63   6G   5q      �� 5r      -	   5        $��BEdit��5r      ���#28666e
�������
�������$��10q�5v      $��0��5w      $��6��5x      $��30��5y      $	��Top=�5z      .��5{   -   Редактировать6<   �� 5|      -
   5        $��BSave��5|      
����������#28666e���#28666e$��10q�5�      $y�	Collapsed=�5�      $��30��5�      $��0��5�      $��6��5�      .��6&   Сохранить61   �� 5�      -   5        $��Delete��5�      ���#28666e
�������
�������$��10q�5�      $��30��5�      $��1��5�      $��6��5�      .��6&   Удалить аккаунт67   5�      � 5�      $��50��6   $y�Visible=�6   .+�5�      �� 	 �� Orientation$	 
Horizontal=�6   $
��10 0q�66   .+�5�      �� -   5        

 J� Uid$
 0��5�      $5��/Создать заявку на перевод��5�      $��25��5�      $	��295��5�      $��0,0,0,0q�5�      ���#e8c27b
���   ���5�      Z� 5�      �� 5�      -   5        $
 1��5�      $+��%Отправленные заявки��5�      $��25��5�      $	��295��6)   $��1,0,0,0q�5�      ���#e8c27b
���   ���5�      Z� 5�      �� 5�      -   5        $
 2��5�      $)��#Выполненные заявки��5�      $��25��5�      $	��295��5�      $��1,0,0,0q�5�      ���#e8c27b
���   ���5�      Z� 5�      5�      � 5�      -   5         �Name$ 
GridCursor��5�      $	��295��5�      $��5��5�      ���#28666e$
��Left=�5�      $��Bottom=�5�      $
��10 0q�5�      5�      � 5�      -   5        $��
GridCreate��5�      $y�Visible=�5�      $��0,15,0,0q�5�       5�      �� 5�      $
��auto �6'   66   �� 5�      6)    5�      �� 5�      6&   �� 5�      6&   �� 5�      6&   �� 5�      6&   .+�5�      �� $��10q�6   $��0��5�      $��0��5�      %#Текст для перевода:6?   �� 5�      $��10q�6   $��0��5�      $��1��5�      Задание:64   �� 5�      $��10q�6   $��0��5�      $��2��5�      Переводчик:67   �� 5�      -   5        $��TBText��5�      $	��100��5�      $��10q�5�       �� AcceptsReturn . ���#28666e$��1��5�      $��0��5�      6)   �� 5�      -   5        $��TBTask��5�       . $��50��5�      ���#28666e$��10q�5�      $��1��5�      $��1��5�      6*   �� 5�      -   5        $��CBTranslator��5�      $��10q�5�      ���#28666e$��1��5�      $��2��5�      ��5�      �� 5�      .R�5�      �  5�   "   �� 5�   &   �� 5�   &   �� 5�   &   .+�5�   "   �� $
��auto��5�   %   $��0��5�   %   $
��Left=�5�   %   $��1q�5�   %   ��5�   %   �� *Name+,5�   3   �� 5�   "   $
��auto��5�   %   $��1��5�   %   $
��Left=�5�   %   $��1q�6@   ��5�   %   �� *	Education+,5�   N   �� 5�   "   $
��auto��5�   %   $��2��5�   %   $
��Left=�5�   A   $��1q�6\   ��6%   �� *
Experience+6i   5�      5�      5�      �� 5�      -   5        $��BCreate��5�      ���#28666e
�������
�������$��10q�5�      $��30��5�      $��2��5�      $��3��5      .��5  /   !Отправить заявку6A   5     � 5     -   5        $��GridSend��5     $y�	Collapsed=�5     $��0,10,0,0q�5     .+�5     �� .+�5     � $��8,0,0,0q�5      5	     �� 5
     $	��400 �60   6>   �� 5     $	��250 �6/   6=   �� 5     $	��250 �6/   6=   .+�5     �� $��0��5  $   $ Center=�5  $    �� TextWrapping$
 Wrap=�5  $   $(��"Текст для перевода��5  $   ���#28666e
������� . $��1,1,1,1q�5  $   
�������5  :   �� 5     $��1��6"   $ Center=�5  $   $
 Wrap=�5  $   $��Задание��5  $   ���#28666e
������� . $��1,1,1,1q�5  $   
�������5   :   �� 5!     $��2��6"   $ Center=�5"  $   $
 Wrap=�5#  $   $��Переводчик��5$  $   ���#28666e
������� . $��1,1,1,1q�5(  $   
�������5)  :   5+     �� 5,     -   5        $��	LViewSend��5,     $	��535��5-     
������ $��0,0,0,0q�5/     ��50     �� 51     .R�52  "   �� ���#e8c27b$��1q�6?    �� CornerRadius$ 
8, 8, 3, 3��6S   ._�53  &   �  54  *   �� 55  .   $	��400 �6@   6N   �� 56  .   $	��250 �6?   6M   �� 57  .   $	��250 �6?   6M   .+�59  *   �� $��0��5:  -    . 
������ $��0,0,0,0q�5=  -   ���#e8c27b$
 Wrap=�5?  -   $
��Left=�5A  -   ��5@  -   �� *OriginalText+5A  J   �� 5B  *   $��1��5C  -    . 
������ $��1,0,0,0q�5F  -   ���#e8c27b��5H  ,   �� *Task+6D   �� 5I  *    . 
������ $��1,0,0,0q�5L  -   ���#e8c27b$��2��5N  -   ��5O  ,   �� *TranslatorName+6N   5P  '   5Q  #   5R     5T     5U     5V     � 5W     -   5        $��
GridResult��5W     $y�	Collapsed=�5X     $��0,10,0,0q�5Y     .+�5Z     �� .+�5[     � $��8,0,0,0q�6    5\     �� 5]     $	��300 �60   6>   �� 5^     $	��200 �6/   6=   �� 5_     $	��150 �6/   6=   �� 5`     $	��250 �6/   6=   .+�5b     �� $��0��5c  $   $ Center=�5d  $   $
 Wrap=�5e  $   $(��"Текст для перевода��5f  $   ���#28666e
������� . $��1,1,1,1q�5j  $   
�������5k  :   �� 5l     $��1��6"   $ Center=�5m  $   $
 Wrap=�5n  $   $��Задание��5o  $   ���#28666e
������� . $��1,1,1,1q�5s  $   
�������5t  :   �� 5u     $��2��6"   $ Center=�5v  $   $
 Wrap=�5w  $   $��Переводчик��5x  $   ���#28666e
������� . $��1,1,1,1q�5|  $   
�������5}  :   �� 5~     $��3��6"   $ Center=�5  $   $
 Wrap=�5�  $   $��Результат��5�  $   ���#28666e
������� . $��1,1,1,1q�5�  $   
�������5�  :   5�     �� 5�     -   5        $��LViewResult��5�     $	��535��5�     
������ $��0,0,0,0q�5�     ��5�     �� 5�     .R�5�  "   �� ���#e8c27b$��1q�6?   $ 
8, 8, 3, 3��6S   ._�5�  &   �  5�  *   �� 5�  .   $	��300 �6@   6N   �� 5�  .   $	��200 �6?   6M   �� 5�  .   $	��150 �6?   6M   �� 5�  .   $	��250 �6?   6M   .+�5�  *   �� $��0��5�  -    . 
������ $��0,0,0,0q�5�  -   ���#e8c27b$
 Wrap=�5�  -   $
��Left=�5�  -   ��5�  -   �� *OriginalText+5�  J   �� 5�  *   $��1��5�  -    . 
������ $��1,0,0,0q�5�  -   ���#e8c27b��5�  ,   �� *Task+6D   �� 5�  *    . 
������ $��1,0,0,0q�5�  -   ���#e8c27b$��2��5�  -   ��5�  ,   �� *TranslatorName+6N   �� 5�  *    . 
������ $��1,0,0,0q�5�  -   ���#e8c27b$��3��5�  -   ��5�  ,   �� *Result+6F   5�  '   5�  #   5�     5�     5�     5�     5�     5�     5�     