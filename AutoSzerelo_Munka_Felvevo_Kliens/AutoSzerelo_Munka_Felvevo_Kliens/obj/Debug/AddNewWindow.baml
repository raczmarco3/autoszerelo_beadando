   M S B A M L   `   `   `  ����[  WAutoSzerelo_Munka_Felvevo_Kliens, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:AutoSzerelo_Munka_Felvevo_Kliens AutoSzerelo_Munka_Felvevo_Kliens  5   	   3    -AutoSzerelo_Munka_Felvevo_Kliens.AddNewWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:AutoSzerelo_Munka_Felvevo_Kliens     5   	     � Title$  AddNewWindow��5   	   $	��310��6   $	��400��6+    � WindowStartupLocation$ CenterScreen=�67   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   6,   �� 5      $��* �6   6)   �� 5      $
��auto �6   6,   .+�5   
   �� $��0��6   $��Új munka hozzáadása:��6   $��Center=�6<   $
��Bold"�6`   $��20(�6r   $��10q�6�   6�   � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $	��100 �6#   61   �� 5      $��* �6#   6/    5      �� 5      $
��auto �6    60   �� 5      $
��auto �6    60   �� 5      $
��auto �6    60   �� 5      $
��auto �6    60   .+�5      �� $��0��6   $��0��6$   $��Ügyfél Neve:��61   $
��Bold"�6H   $��2 8 8 8q�6Z   6m   �� 5      -   5         ��Name$ 
ClientName��5   ?   $��1��6   $��0��6&   $��10q�63   6U   �� 5      $��0��6   $��1��6$   $��Autó típusa:��61   $
��Bold"�6H   $��2 8 8 8q�6Z   6m   �� 5       -   5        $ CarType��5    ?   $��1��6   $��1��6&   $��10q�63   6R   �� 5"      $��0��6   $��2��6$   $��
Rendszám:��61   $
��Bold"�6E   $��2 8 8 8q�6W   6j   �� 5#      -   5        $ LicensePlate��5#   ?   $��1��6   $��2��6&   $��10q�63   6W   �� 5%      $��0��6   $��3��6$   $��
Probléma:��61   $
��Bold"�6E   $��2 8 8 8q�6W   6j   �� 5&      -   5        $ Problem��5&   ?   $��1��6   $��3��6&   $��10q�63   6R   5'      �� 5(   
   -   5        $��Hozzáadás��5(      $��2��6%   $	��110��62   $��Right=�6>   $��10q�6Z   $��5q�6f   6�   5)      5*      