   M S B A M L   `   `   `  ����Z  VAutoSzerelo_Auto_Szerelo_Kliens, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:AutoSzerelo_Auto_Szerelo_KliensAutoSzerelo_Auto_Szerelo_Kliens  5   	   0    *AutoSzerelo_Auto_Szerelo_Kliens.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:AutoSzerelo_Auto_Szerelo_Kliens     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $��* �6   6)   .+�5   
   o� $��25��6   $��0��6   .@�5      m� $��Fájl��6   $��25��6%   .@�5      m� -   5         m�Name$ Close��5      $��	Kilépés��6*   6Q   5      5      �� 5   
   $��1��6   $��Felvett Munkák��6   $��10q�66   $��Center=�6B   $��25(�6_   $
��Bold"�6m   6�   �� 5   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��	15 0 15 0q�6;   
�������.+�5      �� $��ID��6   $��60��6!   6.   �� 5      $��Ügyfél Név��6   $	��170��6)   67   �� 5      $��Autó Típusa��6   $��80��6*   67   �� 5      $��	Rendszám��6   $��60��6'   64   �� 5      $��
Hozzáadva��6   $	��160��6(   66   �� 5      $��Státusz��6   $��60��6&   63   �� 5      $��	Probléma��6   $	��200��6'   65   5      �� 5   
   -   5         ��Name$ WorksListBox��5   3   $��3��6   $��
15 0 15 15q�6    �� SelectionMode$ Single=�6I   ��5       �� 5!      .R�5"      � .+�5#      �� $ 
Horizontal=�6%   .+�5$      �� $��60��6@   $��0 5 0 5q�6K   ��6(   �� *WorkId+6K   �� 5%      $	��170��6D   $��0 5 0 5q�6P   ��6(   �� *
ClientName+6P   �� 5&      $��80��6A   $��0 5 0 5q�6L   ��6(   �� *	CarType+6L   �� 5'      $��60��6F   $��0 5 0 5q�6Q   ��6(   �� *LicensePlate+6Q   �� 5(      $	��160��6>   $��0 5 0 5q�6J   ��6(   �� *Date+6J   �� 5)      $��60��6?   $��0 5 0 5q�6J   ��6(   �� *State+6J   �� 5*      $	��200��6A   $��0 5 0 5q�6M   ��6(   �� *	Problem+6M   5+      5,      5-      5/      50      51      