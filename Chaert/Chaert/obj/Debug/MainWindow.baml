   M S B A M L   `   `   `  ����@  <Chart, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ControlControl  5   	       Chaert.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Control     5   	     � WindowStyle$
  None=�5   	   
������  � AllowsTransparency .  � Title$ 
MainWindow��5
   	   $	��350��6   $	��525��6)   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      CaptionHeight# ZJ�6   %  System.Windows.SystemParameters"   WindowResizeBorderThickness   ResizeBorderThickness# Z 5       � 	Resources 5       �� Source�� 5   
   $ Styles.xaml?�6   %    .��5      �� 
���  ��$��1q�5      ._�5   
   � -   5        	 �Name$	 gird1��5      
 � ShowGridLines
 . ���	#AA888888 J� RenderTransformOrigin$ 
0.39,0.487&�6J    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $��* �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $	��150 �6#   �� 5      $��* �6#   .+�5!      �� $��0��6   $��2��6&    �� Orientation$ 
Horizontal=�6:   $��5q�6S   $��Right=�5"      $	��Top=�5#      .+�5$      �� $��0��6      CaptionButtonStyleKey#���   6%   �� 5%      $��1��6   #���   6%   �� 5&      $��2��6   #���   6%   �� 5'      $��r��6   #���   6%   5(      o� 5*      $��1��6   #��Z��6    $
��Auto��6S   $��2��6`   .@�5+      m� #��Z��6   $��Files��6N   5,         Control.Chart  5.      -   5          Name$ chart��5.      $��3��6)   $��1��66      BackgroundOpacity$	 0.5Q�6F   5=      5>      5?      