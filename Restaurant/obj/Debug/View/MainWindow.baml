   M S B A M L   `   `   `  ����E  ARestaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Restaurant
Restaurant  5   	       Restaurant.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Restaurant     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
     � Title$  Birria los Diaz��5	   	   $	��600��5
   	   $
��1080��6    � WindowStartupLocation$ CenterScreen=�6)   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   � $��0��6   $��0��6   $	��150��6,      PrimaryHueMidBrush#��[  69   .+�5      �� $��45q�6   $��30(�6$    �� TextAlignment$ Center=�62   $
��Logo��6I   5      �� 5   
   $��0��6   $��1��6'   $
��Auto=�64     PrimaryHueDarkBrush#��[ 6Y   .��5      �� #��[ 6   .+�5      �� 
�������.@�5      �� -   5        .��5      ��  �� Orientation$ 
Horizontal=�6%   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ RoomService=�66   $��Center=�6I   $
��15 7q�6d   $��40��6r   $��40��6~   �� 5      $��Comedor��6(   $��Center=�67   $��5q�6R   $
��Bold"�6]   $��15(�6o   5       5!      �� 5"      .��5#      �� $ 
Horizontal=�6%   .+�5$        $ 
Motorcycle=�66   $��Center=�6H   $
��15 7q�6c   $��40��6r   $��40��6~   �� 5%      $��	Domicilio��6(   $��Center=�69   $��5q�6T   $
��Bold"�6_   $��15(�6q   5&      5'      �� 5(      .��5)      �� $ 
Horizontal=�6%   .+�5*        $ FoodVariant=�66   $��Center=�6I   $
��15 7q�6d   $��40��6s   $��40��6   �� 5+      $��Rapida��6(   $��Center=�66   $��5q�6Q   $
��Bold"�6\   $��15(�6n   5,      5-      �� 5.      .��5/      �� $ 
Horizontal=�6%   .+�50        $ 	Nutrition=�66   $��Center=�6G   $
��15 7q�6b   $��40��6q   $��40��6}   �� 51      $��	Productos��6(   $��Center=�69   $��5q�6T   $
��Bold"�6_   $��15(�6q   52      53      �� 54      .��55      �� $ 
Horizontal=�6%   .+�56        $ Money100=�66   $��Center=�6F   $
��15 7q�6a   $��40��6p   $��40��6|   �� 57      $��Ventas��6(   $��Center=�66   $��5q�6Q   $
��Bold"�6\   $��15(�6n   58      59      �� 5:      .��5;      �� $ 
Horizontal=�6%   .+�5<        $ Settings=�66   $��Center=�6F   $
��15 7q�6a   $��40��6p   $��40��6|   �� 5=      $��Admin��6(   $��Center=�65   $��5q�6P   $
��Bold"�6[   $��15(�6m   5>      5?      5@      5A      5B      � 5C   
   $��1��6   $��2��6    .+�5D      �� .+�5E       � -   5          �Name$
 Main��5E        � Source$ WelcomeView.xaml?�6&   	  � NavigationUIVisibility$	 Hidden=�6@   5F      5G      5H      5I      