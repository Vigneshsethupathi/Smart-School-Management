   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	        WpfApp1.GetTeachersDetails   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  GetTeachersDetails��5   	   $	��630��6$   $
��1200��61    � 
ResizeMode$ CanMinimize=�6>    � WindowStartupLocation$ CenterScreen=�6W   .��5	      � .+�5   
   �� .+�5      �� -   5         ��Name$ header��5      $�� School Informations��6$   $	��100��6C   
�������$��55(�6c   $��Center=�6q   $	��Top=�6�   $��Italic$�6�   
��� � �
��� d �$��10q�6�   $��Jokerman)�6  �� 5      -   5        $C��=C:\Users\Vignesh\source\repos\WpfApp1\WpfApp1\Image\home2.png��5      $��80��6�   $��70��6�   $
��Left=�6�   $��40,-100,0,0q�6�    J� OpacityMask
 �   �6�   5      � 5   
   $
��1200��6   $
�� 500��6   $	��Top=�6,   $��Center=�6D   $��	0,102,0,0q�6a   ��5      �� 5       �� ImageSource$B <C:\Users\Vignesh\source\repos\WpfApp1\WpfApp1\Image\get1.jpg��6    �� Opacity$	 0.5Q�6h   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ TeachersGetValues��5   $   $	��400��6   $	��Top=�6?   $
��1000��6W   $��100,6,100,0q�6d      AutoGenerateColumns$ False��6z   $y�Hidden=�6�   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Id��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 30 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *
TeachersId+6T     5      $
 TeachersName��6)   $	 180 6`    6?   �� *TeachersName+6`     5      $
 TeachersAge��6)   $ 80 6^    6>   �� *TeachersAge+6^     5      $
 Teachers MobileNo��6)   $	 120 6j    6D   �� *Teachers_MobileNo+6j     5      $
 Gender��6)   $ 80 6T    69   �� *Gender+6T     5      $$
 currently workking school Name��6)   $	 180 6�    6Q   �� * currently_workking_school_Name+6�     5      $
 which Class_Teaching��6)   $	 120 6p    6G   �� *which_Class_Teaching+6p     5       $
 Joining Date��6)   $ 80 6`    6?   �� *Joining_Date+6`     5!      $
 Teachers salary��6)   $	 200 6f    6B   �� *Teachers_salary+6f     5"      $
 Staying Location��6)   $	 200 6h    6C   �� *Staying_Location+6h   5'      � 5)      $��315,394,-21,6q�6   $	��100��6+   .+�5,      �� -   5        $
��Back��5,      $��30(�6)   $��40��67   $	��150��6C   $��Calibri)�6O   $��	UltraBold"�6�   $��Italic$�6�   $��UltraExpanded&�6�   
���   ����	#FFB5B5B5$��2,2,2,2q�6�   $��460,30,296,30q�6   J� Effect 5-      3  -System.Windows.Media.Effects.DropShadowEffect  5.      ��50      �� 51       �� 
TargetType" ��6*   .R�52      �� #��z��6%   #��z��53      #��z��54       �� CornerRadius$ 20��55      ._�57   "   �� $��Center=�63   $��Center=�6P   58      59      5;      �� 5<      -   5        $��Cancel��5<      $��30(�6+   $��40��6:   $	��150��6F   $��Calibri)�6R   $��	UltraBold"�6�   $��Italic$�6�   $��UltraExpanded&�6�   
���   ����	#FFB5B5B5$��2,2,2,2q�6�    J� RenderTransformOrigin$ 0.5,0.5&�6  $��643,30,113,30q�63   5>        5?      ��5A      �� 5B      " ��6*   .R�5C      �� #��z��6%   #��z��5D   *   #��z��5E   *   $ 20��5F   *   ._�5G   "   �� $��Center=�63   $��Center=�6P   5H      5I      5K      5N      5O      �� 5R   
   -   5         ��Name$ 	blurimage��5R   ^   $J��DC:\Users\Vignesh\source\repos\WpfApp1\WpfApp1\Image\getdataimage.png��6   $��-154,104,-187,0q�6q    5T      -  'System.Windows.Media.Effects.BlurEffect  5U      6   5W      � 5[   
   -   5         �Name$ EnterPasswordTeacher��5[   ;   $	��500��6   $	��300��6   
�������.+�5\      �� 
��� � �$��1,1,1,1q�6)    5]        5^         
BlurRadius$ 10Q�6'      Color$ green��67      	Direction$	 300Q�6E      ShadowDepth$ 5Q�6U   6i   5`      �� 5a      $��Enter Password��6   $	��498��6-   $��50��69   $��Arial Black)�6E   $��20(�6^   $��Center=�6l   $��Center=�6�   ���	#FF088608���	#FFFB0000$��Center=�6�   $	��Top=�6�    K� ZIndex$ 3��6  $��5,5,5,5q�6'  $
��True��69  $��0,0,0,3q�6^  $��0,1,0,0q�6x  G� 5b      -   5         G�Name$
 Pass��5b      $��101,84,142,176q�6*   $��40��6B   $��15(�6P   $
��Bold"�6^   $��Italic$�6p   $��Microsoft YaHei)�6�   ���	#FFDEAD00 G� SelectionBrush �	#FF0274F3$��Center=�6�   $��Center=�6  $��2,2,2,2q�6<  ��5c      �� 5d       �� Color$
 Snow��6&   $	 0.5Q�63    5f        5g      $ 10Q�6'   $ Black��67   $	 300Q�6E   $ 4Q�6U   6i   5i      �� 5k      $ 5��6   
���   �$��1q�6:   $��367,82,71,174q�6N   
��� � � 5l        5m      $ 10Q�6'   $ green��67   $	 300Q�6E   $ 10Q�6U   6j   5o      �� 5q      -	   5        $D��>C:\Users\Vignesh\source\repos\WpfApp1\WpfApp1\Image\right2.png��5q      $��368,83,72,178q�6�   �� 5s      -
   5        $ Pass_Placeholder��5s   '   $��Password��6   $��
179,87,0,0q�6A   
���   �$
��Left=�6h   $	��Top=�6�   
������  J� Opacity$ .4Q�6�   $��impact)�6�   $��20(�6�   $��UltraExpanded&�6�   $��Italic$�6�   $
��Thin"�6  �� 5u      $A��;C:\Users\Vignesh\source\repos\WpfApp1\WpfApp1\Image\end.jpg��6   $	��140��6Y   $	��Top=�6f   $	 .78Q�6~   $��
-2,156,2,0q�6�   5v      5w      5x      