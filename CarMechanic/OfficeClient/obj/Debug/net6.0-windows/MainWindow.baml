   M S B A M L   `   `   `  ����G  COfficeClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:OfficeClientOfficeClient  5   	       OfficeClient.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:OfficeClient     5   	     � Title$  
MyMechanic��5   	   $	��550��6   $
��1000��6)   ���#464baa.��5
      � $��1,0,-1,0q�6    � ColumnDefinitions 5   
   �� 5      $	��17* �6   �� 5      $	��33* �6   .+�5   
   �� $
��Left=�6   $��73��6+   $��	10,10,0,0q�67   $	��Top=�6J   $	��195��6b   $��	/logo.jpg��6n   �� 5   
   $
��Left=�6   $��
27,130,0,0q�6/   $
��Wrap=�6C   
�������$��Lucida Sans)�5      $	��Top=�6-   �� 6F   $�	Customer ��6J   �� 6]    � Language$ hu-hu�6a   $�n��6r   �� 6}   $	�ame��6�   �� 6�   $�:��6�   6�   �� 5   
   $
��Left=�6   $��
27,170,0,0q�6/   $
��Wrap=�6C   
�������$��Lucida Sans)�5      $	��Top=�6-   �� 6F   $�Car name��6J   �� 6\   $ hu-hu�6`   $�:��6q   6}   �� 5   
   $
��Left=�6   $��
27,210,0,0q�6/   $
��Wrap=�6C   
�������$��Lucida Sans)�5      $	��Top=�6-   $��75��6E   �� 6Q   $
�Car ��6U   �� 6c   $ hu-hu�6g   $�t��6x   �� 6�   $	�ype��6�   �� 6�   $�:��6�   6�   �� 5   
   $
��Left=�6   $��
27,250,0,0q�6/   $
��Wrap=�6C   
�������$��Lucida Sans)�5      $	��Top=�6-   �� 6F   $ hu-hu�6J   $�Plate number:��6[   6s   �� 5   
   $
��Left=�6   $��
27,290,0,0q�6/   $
��Wrap=�6C   
�������$��Lucida Sans)�5      $	��Top=�6-   �� 6F   $ hu-hu�6J   $�Problem description:��6[   6z   �� 5   
   $
��Left=�6   $��
233,38,0,0q�6/   $
��Wrap=�6C   
�������$��Lucida Sans)�5       $��20(�6-   $	��Top=�6;   $��1��6S   �� 6d   $ hu-hu�6h   $�Recorded Works��6y   6�   �� 5"   
   -   5         ��Name$ CustomerName��5"      $
��Left=�6(   $��
27,146,0,0q�6C    �� TextWrapping$
 Wrap=�6W   $	��Top=�6k   $	��165��6�   �� 5#   
   -   5        $ CarName��5#      $
��Left=�6#   $��
27,186,0,0q�6>   $
 Wrap=�6R   $	��Top=�6f   $	��165��6~   �� 5$   
   -   5        $ CarType��5$      $
��Left=�6#   $��
27,226,0,0q�6>   $
 Wrap=�6R   $	��Top=�6f   $	��165��6~   �� 5%   
   -   5        $ PlateNumber��5%      $
��Left=�6'   $��
27,266,0,0q�6B   $
 Wrap=�6V   $	��Top=�6j   $	��165��6�   �� 5&   
   -   5        $ ProblemDescription��5&      $
��Left=�6.   $��
27,306,0,0q�6I   $
 Wrap=�6]   $	��Top=�6q   $	��165��6�   $	��191��6�   �� 5(   
   -   5         ��Name$ 	AddButton��5(      $	��ADD��6$   ���#01de01$
��Left=�6G   $��Lucida Sans)�6b   $��237,180,0,0q�6{   $	��Top=�6�   $��20��6�   $��43��6�   6�   �� 5)   
   -   5        $ 
EditButton��5)      $
��EDIT��6%   ���#01de01$
��Left=�6I   $��Lucida Sans)�6d   $��237,241,0,0q�6}   $	��Top=�6�   $��22��6�   $��43��6�   6�   �� 5*   
   -   5        $ DeleteButton��5*      $��DELETE��6'   
���  ��$
��Left=�6I   $��Lucida Sans)�6d   $��233,372,0,0q�6}   $	��Top=�6�   $��30��6�   $��51��6�   6�   �� 5,   
   -	   5         ��Name$ WorkListView��5,      $
��Left=�6J   $	��430��6e   $��
338,67,0,0q�6r   $	��Top=�6�   $	��627��6�   $��2��6�   ��6)   �� *
cardatas+ �� View 5-      �� 5.      .P�5/      �� $��Customer Name��6K    �� DisplayMemberBinding 6%   �� *Name+6K   �� 50      $��	Car Brand��6N    6%   �� *	CarName+6N   �� 51      $��Car type��6N    6%   �� *	CarType+6N   �� 52      $��Plate Number��6R    6%   �� *PlateNumber+6R   �� 53      $��Status��6M    6%   �� *Status+6M   �� 54      $
��Date��6Q    6%   �� *
IntakeDate+6Q   �� 55      $��ProblemDescip��6T    6%   �� *ProblemDescip+6T   56      58      59      5:      