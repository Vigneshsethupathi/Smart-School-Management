   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��800��6)    � 
ResizeMode$ CanMinimize=�65    � 	Resources 5	       �� 
TargetType   loginbox �� Property �� Value��%�  &	        �� 5
   
   " ��6   .�5      ��  � ��$ 	0,30,0,30q�6(   �� 5       � ��$ 40��6'   �� 5       � ��$	 250��6&   �� 5       � ��
 �����6+   �� 5       �@J�OpacityMask
 ���_�6,   �� 5       � ��$ Center=�6;   �� 5       � ��$ Center=�69   �� 5       � ��
 �r���6,   �� 5       � ��$ 1q�60   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   �� 5       �� 5!   
   $��0��6   .+�5"      �� -   5         ��Name$ header��5"      $�� School Informations��6$   $	��100��6C   
�������$��55(�6c   $��Center=�6q   $	��Top=�6�   $��Italic$�6�   
��� � �
��� d �$��10q�6�   $��Jokerman)�6  5#      �� 5$   
    �� CornerRadius$ 10��6   
���   �$��2q�67   $��Center=�6K   $	��296��6h   $
�� 270��6t   $��	0,10,0,50q�6�   $��1��6�   ._�5%      �� .+�5&      � $
��auto��6    5(      �� 5)      $	��100 �6(   �� 5*      $��90 �6(   .+�5.      �� -   5        	 ��Name$
	 User��5.   2   
 �� TextWrapping$

 Wrap=�6   $��0��6@   #��[  6O   $
��Bold"�6q   $��Microsoft YaHei)�6�   $��15(�6�   $��Italic$�6�    �� 	MaxLength$ 10��6�   4  .System.Windows.Automation.AutomationProperties   IsRequiredForForm$
 True��6�      
ItemStatus$  ��6�   
������� �� SelectionBrush �	#FF0084FF.��6o  ��5/      �� 50       �� Color$ White��6.    �� Opacity$	 0.5Q�6<   .��51   .    J� Effect 52      3  -System.Windows.Media.Effects.DropShadowEffect  53         
BlurRadius$ 10Q�6/      Color$ Black��6?      	Direction$	 300Q�6M      ShadowDepth$ 10Q�6]      RenderingBias$ Performance=�6n   6�   .��54   *   56      �� 57      -   5        $ User_Placeholder��57   /   $��UserName��6   $��0��6I   $��Center=�6V   $��Center=�6s   
������  J� Opacity$ .4Q�6�   
���   �$��impact)�6�   $��20(�6�   $��UltraExpanded&�6�   $��Italic$�6  $
��Thin"�6  6,  G� 58      -   5         G�Name$
 pass��58   #   $��1��61   $��	0,-40,0,0q�6?   $��40��6R   $	��250��6^   $
 True��6k   $��15(�6�   $
��Bold"�6�   $��Italic$�6�   $��Microsoft YaHei)�6�   
������� G� SelectionBrush �	#FF0274F3$��Center=�6;  $��Center=�6_  ��59      �� 5:      $
 Snow��6.   $	 0.5Q�6;    5<        5=      $ 10Q�6/   $ Black��6?   $	 300Q�6M   $ 10Q�6]   $ Performance=�6n   6�   5?      �� 5B      -   5        $ PassWord_Placeholder��5B   /   $��Password��6   $��	0,-40,0,0q�6M   
���   �$��1��6s   $��Center=�6�   $��Center=�6�   
������ $ .4Q�6�   $��impact)�6�   $��20(�6�   $��UltraExpanded&�6   $��Italic$�6  $
��Thin"�6/  6C  5D      �� 5E      -   5         ��Name$ chkbox��5E      $��Check me��6+   $��14(�6>   $��	5,-30,0,5q�6L   $	��100��6_   $
��Left=�6k   
�������6�   �� 5F      -   5         ��Name$ Submit��5F      $��Login��6)   $��30��69   $��0q�6E   $	��135��6Q   $��Right=�6]   $��0,5,5,20q�6y   $��15(�6�   $
��Bold"�6�   {�6�   ��  �� ElementName$ chkbox�� �� Path$ 	IsChecked� �� Mode$ OneWay=�6�   �� 5G      .+�5H      �� -   5        $ createaccount��5H      $��CreateAccount��64   $��5q�6L   $	��122��6X   $	�� 30��6d   $
��Left=�6q    �� Left$ 4��6�   
  �� Top$	  -50��6�   $��15(�6�   $��Oblique$�6�   $��Center=�6�   6�   5I      ��5J      �� 5K      ! �� ImageSource$D! >C:\Users\Vignesh\source\repos\WpfApp1\WpfApp1\Image\login2.jpg��6!   $ .7Q�6n   5N      5O      ��5P   
   �� 5Q      $J! DC:\Users\Vignesh\source\repos\WpfApp1\WpfApp1\Image\SchoolImage3.jpg��6   $ .3Q�6l   5U      5W      