   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.GetSchoolDetails   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  GetSchoolDetails��5   	   $	��630��6"   $
��1200��6/    � 
ResizeMode$ CanMinimize=�6<    � WindowStartupLocation$ CenterScreen=�6U   .��5	      � .+�5   
   �� .+�5      �� -   5         ��Name$ header��5      $�� School Informations��6$   $	��100��6C   
�������$��55(�6c   $��Center=�6q   $	��Top=�6�   $��Italic$�6�   
��� � �
��� d �$��10q�6�   $��Jokerman)�6  �� 5      -   5        $C��=C:\Users\Vignesh\source\repos\WpfApp1\WpfApp1\Image\home2.png��5      $��80��6�   $��70��6�   $
��Left=�6�   $��40,-100,0,0q�6�    J� OpacityMask
 �   �6�   5      � 5   
   -   5         �Name$ GetSchoolDataPage��5      $
��1200��6*   $
�� 500��67   $	��Top=�6E   $��Center=�6]   $��	0,102,0,0q�6z   $y�Hidden=�6�   ��5      �� 5       �� ImageSource$B <C:\Users\Vignesh\source\repos\WpfApp1\WpfApp1\Image\get1.jpg��6    �� Opacity$	 0.5Q�6h   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ SchoolGetValues��5      $	��400��60   $	��Top=�6=   $
��1000��6U   $��100,6,100,0q�6b   	   AutoGenerateColumns$	 False��6x   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 30 6R   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *
SchoolId+6R     5      $ 
SchoolName��6)   $	 180 6\    6=   �� *
SchoolName+6\     5      $ Admin��6)   $	 180 6^    68   �� *School_Admin_Name+6^     5      $ HM Mobile NO��6)   $	 150 6f    6?   �� *HeadMaster_MobilNO+6f     5      $ Total Male Teachers��6)   $	 120 6x    6F   �� *How_Many_Teachers_Gender_Male+6x     5      $ Total Female Teachers��6)   $	 120 6|    6H   �� *!How_Many_Teachers_Gender_Female+6|     5      $ Total Teachers��6)   $ 80 6d    6A   �� *Total_Teachers+6d     5       $ School Location��6)   $	 200 6e    6B   �� *SchoolLocation+6e   5$      � 5)      $��315,394,-21,6q�6   $	��100��6+   .+�5,      �� -   5        $
��Back��5,      $��30(�6)   $��40��67   $	��150��6C   $��Calibri)�6O   $��	UltraBold"�6�   $��Italic$�6�   $��UltraExpanded&�6�   
���   ����	#FFB5B5B5$��2,2,2,2q�6�   $��460,30,296,30q�6   J� Effect 5-      3  -System.Windows.Media.Effects.DropShadowEffect  5.      ��50      �� 51       �� 
TargetType" ��6*   .R�52      �� #��z��6%   #��z��53      #��z��54       �� CornerRadius$ 20��55      ._�57   "   �� $��Center=�63   $��Center=�6P   58      59      5;      �� 5<      -   5        $��Cancel��5<      $��30(�6+   $��40��6:   $	��150��6F   $��Calibri)�6R   $��	UltraBold"�6�   $��Italic$�6�   $��UltraExpanded&�6�   
���   ����	#FFB5B5B5$��2,2,2,2q�6�    J� RenderTransformOrigin$ 0.5,0.5&�6  $��643,30,113,30q�63   5>        5?      ��5A      �� 5B      " ��6*   .R�5C      �� #��z��6%   #��z��5D      #��z��5E      $ 20��5F      ._�5G   "   �� $��Center=�63   $��Center=�6P   5H      5I      5K      5N      5X      �� 5_   
   -   5         ��Name$ 	blurimage��5_   ^   $J��DC:\Users\Vignesh\source\repos\WpfApp1\WpfApp1\Image\getdataimage.png��6   $��-101,102,-100,-9q�6q    5a      -  'System.Windows.Media.Effects.BlurEffect  5b      6   5d      � 5h   
   -   5        $ EnterPassword��5h   ;   $	��500��6   $	��300��6   
�������.+�5i      �� 
��� � �$��1,1,1,1q�6)    5j        5k         
BlurRadius$ 10Q�6'      Color$ green��67      	Direction$	 300Q�6E      ShadowDepth$ 5Q�6U   6i   5m      �� 5n      $��Enter Password��6   $	��498��6-   $��50��69   $��Arial Black)�6E   $��20(�6^   $��Center=�6l   $��Center=�6�   ���	#FF088608���	#FFFB0000$��Center=�6�   $	��Top=�6�    K� ZIndex$ 3��6  $��5,5,5,5q�6'  $
��True��69  $��0,0,0,3q�6^  $��0,1,0,0q�6x  G� 5o      -	   5         G�Name$
 pass��5o      $��101,84,142,176q�6*   $��40��6B   $��15(�6P   $
��Bold"�6^   $��Italic$�6p   $��Microsoft YaHei)�6�   ���	#FFDEAD00 G� SelectionBrush �	#FF0274F3$��Center=�6�   $��Center=�6  $��2,2,2,2q�6<  ��5p      �� 5q       �� Color$
 Snow��6&   $	 0.5Q�63    5s        5t      $ 10Q�6'   $ Black��67   $	 300Q�6E   $ 4Q�6U   6i   5v      �� 5x      $ 5��6   
���   �$��1q�6:   $��367,82,71,174q�6N   
��� � � 5y        5z      $ 10Q�6'   $ green��67   $	 300Q�6E   $ 10Q�6U   6j   5|      �� 5~      -
   5        $D��>C:\Users\Vignesh\source\repos\WpfApp1\WpfApp1\Image\right2.png��5~      $��368,83,72,178q�6�   �� 5�      -   5        $ PassWord_Placeholder��5�   '   $��Password��6   $��
179,87,0,0q�6E   
���   �$
��Left=�6l   $	��Top=�6�   
������  J� Opacity$ .4Q�6�   $��impact)�6�   $��20(�6�   $��UltraExpanded&�6�   $��Italic$�6  $
��Thin"�6  �� 5�      $A��;C:\Users\Vignesh\source\repos\WpfApp1\WpfApp1\Image\end.jpg��6   $	��140��6Y   $	��Top=�6f   $	 .78Q�6~   $��
-2,156,2,0q�6�   5�      5�      5�      