   M S B A M L   `   `   `  ����I  EMechanicClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MechanicClientMechanicClient  5   	       MechanicClient.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:MechanicClient     5   	     � Title$  
MyMechanic��5      $	��550��6   $
��1000��6(   ���#464baa.��5	      � $��1,0,-1,0q�6   .+�5
   
   �� $
��Left=�6   $��73��6+   $��	10,10,0,0q�67   $	��Top=�6J   $	��195��6b   $��	/logo.jpg��6n   �� 5   
   -   5         ��Name$ 
EditButton��5      $
��EDIT��6%   ���#01de01$
��Left=�6I   $��Lucida Sans)�6d   $��232,306,0,0q�6}   $	��Top=�6�   $��22��6�   $��43��6�   6�   �� 5   
   $
��Left=�6   $��
27,130,0,0q�6/   $
��Wrap=�6C   
�������$��Lucida Sans)�5      $	��Top=�6-   �� 6F   $�	Customer ��6J   �� 6]    � Language$ hu-hu�6a   $�n��6r   �� 6}   $	�ame��6�   �� 6�   $�:��6�   6�   �� 5   
   $
��Left=�6   $��
27,170,0,0q�6/   $
��Wrap=�6C   
�������$��Lucida Sans)�5      $	��Top=�6-   �� 6F   $�Car name��6J   �� 6\   $ hu-hu�6`   $�:��6q   6}   �� 5   
   $
��Left=�6   $��
27,210,0,0q�6/   $
��Wrap=�6C   
�������$��Lucida Sans)�5      $	��Top=�6-   $��75��6E   �� 6Q   $
�Car ��6U   �� 6c   $ hu-hu�6g   $�t��6x   �� 6�   $	�ype��6�   �� 6�   $�:��6�   6�   �� 5   
   $
��Left=�6   $��
27,250,0,0q�6/   $
��Wrap=�6C   
�������$��Lucida Sans)�5      $	��Top=�6-   �� 6F   $ hu-hu�6J   $�Plate number:��6[   6s   �� 5   
   $
��Left=�6   $��
27,290,0,0q�6/   $
��Wrap=�6C   
�������$��Lucida Sans)�5      $	��Top=�6-   �� 6F   $ hu-hu�6J   $�Status:��6[   6m   �� 5   
   $
��Left=�6   $��
581,43,0,0q�6/   $
��Wrap=�6C   
�������$��Lucida Sans)�5      $��20(�6-   $	��Top=�6;   �� 6T   $ hu-hu�6X   $�Recorded Works��6i   6�   �� 5    
   $
��Left=�6   $��
27,330,0,0q�6/   $
��Wrap=�6C   
�������$��Lucida Sans)�5!      $��Problem description:��6-   $	��Top=�6I   �� 5"   
   -   5         ��Name$ CustomerName��5"      $
��Left=�6*   $��
27,149,0,0q�6E   
�������
���   �$
��Wrap=�6   $	��Top=�6�   $	��170��6�   �� 5#   
   -   5        $ CarName��5#      $
��Left=�6%   $��
27,189,0,0q�6@   
�������
���   �$
��Wrap=�6z   $	��Top=�6�   $	��170��6�   �� 5$   
   -   5        $ CarType��5$      $
��Left=�6%   $��
27,229,0,0q�6@   
�������
���   �$
��Wrap=�6z   $	��Top=�6�   $	��170��6�   �� 5%   
   -   5        $ PlateNumber��5%      $
��Left=�6)   $��
27,269,0,0q�6D   
�������
���   �$
��Wrap=�6~   $	��Top=�6�   $	��170��6�   �� 5&   
   -   5        $ ProblemDescription��5&      $
��Left=�60   $��
27,349,0,0q�6K   
�������
���   �$
��Wrap=�6�   $	��Top=�6�   $	��170��6�   $	��138��6�   �� 5'   
   -   5         ��Name$ Status_ComboBox��5'      $
��Left=�6,   $��
27,304,0,0q�6G   $	��Top=�6[   $	��170��6s   $��24��6   �� 5)   
   -   5         ��Name$ WorkListView��5)      $
��Left=�6J   $	��430��6e   $��
338,67,0,0q�6r   $	��Top=�6�   $	��627��6�   $��2��6�   ��6)   �� *
cardatas+ �� View 5*      �� 5+      .P�5,      �� $��Customer Name��6K    �� DisplayMemberBinding 6%   �� *Name+6K   �� 5-      $��	Car Brand��6N    6%   �� *	CarName+6N   �� 5.      $��Car type��6N    6%   �� *	CarType+6N   �� 5/      $��Plate Number��6R    6%   �� *PlateNumber+6R   �� 50      $��Status��6M    6%   �� *Status+6M   �� 51      $
��Date��6Q    6%   �� *
IntakeDate+6Q   �� 52      $��ProblemDescip��6T    6%   �� *ProblemDescip+6T   53      55      56      57      