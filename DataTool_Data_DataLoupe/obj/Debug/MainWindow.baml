   M S B A M L   `   `   `  ����R  NDataTool_Data_DataLoupe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:DataTool_Data_DataLoupeDataTool_Data_DataLoupe  5   	   G(clr-namespace:CircularProgressBarExampleCircularProgressBarExample  5   	   E ARadialMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM5clr-namespace:RadialMenu.Controls;assembly=RadialMenuRadialMenu.Controls 5   	   (    "DataTool_Data_DataLoupe.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:DataTool_Data_DataLoupe     5   	   <local_p(clr-namespace:CircularProgressBarExample     5   	   JControls5clr-namespace:RadialMenu.Controls;assembly=RadialMenu     5   	     � Title$  
MainWindow��5
   	   $	��350��6   $	��350��6)   .��5      � .+�5   
   �� -   5         ��Name$ startupImage��5      $��Aicon/logo.png��6&   $y�Visible=�6>   $
��Fill=�6S   {�. $	��Top=�6s   $
��Left=�6�    J� OpacityMask 5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Black��6#   � 5      $ 	#FFFFDDDD��6#    � Offset$ 1Q�65   5      5      $  RadialMenu.Controls.RadialMenu  5   
   -   5          Name$ 
radialMenu��5         IsOpen .  	   CentralItem	 5      /  )RadialMenu.Controls.RadialMenuCentralItem  5      -   5        .��5      �� .+�5      �� $��Aicon/close.png��6    $��32��69   $��32��6D   $y�Visible=�6P   �� 5      $��Close��6$   $��1,0,0,0q�61   5      5      
   Content.
 5"      (  "RadialMenu.Controls.RadialMenuItem  -   5          Name$ Import��5"   ;   .��5#      �� .+�5$      �� $��Aicon/install.png��6   $��32��67   $��32��6B   $y�Visible=�6N   �� 5%      $��Import��6    5&      5'        5*      -   5        .��5+      �� .+�5,      �� $��Aicon/data.png��6   $��32��64   $��32��6?   $y�Visible=�6K   �� 5-      $��Param Editor��6    
���   �64   5.      5/        52      -   5        .��53      �� .+�54      �� $��Aicon/learning.png��6   $��32��68   $��32��6C   $y�Visible=�6O   �� 55      $��
Extraction��6    
���   �62   56      57        5:      -   5        .��5;      �� .+�5<      �� $��Aicon/scatter.png��6   $��32��67   $��32��6B   $y�Visible=�6N   �� 5=      $��	Visualize��6    
���   �61   5>      5?        5A      -   5        .��5B      �� .+�5C      �� $��Aicon/dataset.png��6   $��32��67   $��32��6B   $y�Visible=�6N   �� 5D      $��Analyse��6    
���   �6/   5E      5F        5H      -	   5        .��5I      �� .+�5J      �� $��Aicon/drift.png��6   $��32��65   $��32��6@   $y�Visible=�6L   �� 5K      $��Drift Check��6    
���   �63   5L      5M      5N        5P   
   -
   5        $ radialmenu_analyse��5P       .  	 5Q        5R      -   5        .��5S      �� .+�5T      �� $��Aicon/back.png��6    $��32��68   $��32��6C   $y�Visible=�6O   �� 5U      $
��Back��6$   $��1,0,0,0q�60   5V      5X      .
 5]        -   5        .��5^      �� .+�5_      �� $��Aicon/data.png��6   $��32��64   $��32��6?   $y�Visible=�6K   �� 5`      $��	Param Set��6    
���   �61   5a      5b        5e      -   5        .��5f      �� .+�5g      �� $��Aicon/chose.png��6   $��32��65   $��32��6@   $y�Visible=�6L   �� 5h      $��	Redundant��6    
���   �61   5i      5j        5l      -   5        .��5m      �� .+�5n      �� $��Aicon/rule_check.png��6   $��32��6:   $��32��6E   $y�Visible=�6Q   �� 5o      $��	Cleansing��6    
���   �61   5p      5q      5s      4   .CircularProgressBarExample.CircularProgressBar  5u   
   -   5          Name$ progressbar��5u   &   $	��260��6\   $	��260��5v   %      StrokeThickness$ 5Q�62   
�������
���z���$y�Hidden=�5w   >      Value 5u   <   �� *ProgressValue+5w   >   5y      5z      