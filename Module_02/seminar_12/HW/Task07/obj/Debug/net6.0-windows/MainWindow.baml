   M S B A M L   `   `   `  ����A  =Task07, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task07Task07  5   	       Task07.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Task07     5   	     � Title$  
MainWindow��5   	   $	��478��6   $	��795��6)   .��5	      � $��Center=�6   
����ح�$��Center=�6?    � ShowGridLines$
 True��6Z   $	��400��6o   $	��400��6}    J� RenderTransformOrigin$ 0.5,0.5&�6�    � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� -   5        $��sliderY��5   .   $��0��6   $��0��6    � Minimum$ 0Q�6=    � Maximum$	 320Q�6l    �� Orientation$ Vertical=�6z   $��10q�6�   �� 5   
   -   5        $��sliderX��5   .   $��1��6   $��1��6   $ 0Q�6=   $	 320Q�6m   $ 
Horizontal=�6{   $��10q�6�   �� 5   
   -   5        $��button��5      $��Clear��6   $��1��5   	   $��0��6   �� 5   
   -   5        $��canvas��5   I   $��1��6   $��0��6!   
����p��.+�5      � -   5        $��polyline��5      
������� � FillRule$ EvenOdd=�6=   $��4��6P   	 � Points		 �    6p   5      5      5      