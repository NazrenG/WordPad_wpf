   M S B A M L   `   `   `  ����F  BWordPad_wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WordPad_wpfWordPad_wpf  5   	       WordPad_wpf.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WordPad_wpf     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � 
����� �.+�5
   
   � $��80��6   $	��Top=�6    .+�5      �� $
��File��6   $��10 30q�6#   $��0q�62   �� 5      -   5        $	��txt��5      $��
0 20 25 20q�6"   $	��250��66   
�����_� � DataContext$ select a file��6Y   �� 5      -   5        $��btn_open��5      $��35��6&   $��35��61   $��	0 20 0 20q�6=   
���   �.��5      �� $#��Images\icons8-triangle-32.png��6   5      �� 5      -   5        $��checkbox��5      $��75��6'   $��35��62   $��35 20 25 20q�6>   $��	Auto Save��6S    d� 	IsChecked$ FalseY�5      �� 5      -   5        $��btn_save��5      $��35��6&   $��35��61   $��	0 20 0 20q�6=   
���   �.��5      �� $$��Images\icons8-less-than-30.png��6   5      �� 5      -   5        $��btn_cut��5      $��35��6%   $��35��60   $��
50 20 0 20q�6<   
���   �.��5      �� $��Images\icons8-cut-50.png��6   5      �� 5      -   5        $��btn_copy��5      $��35��6&   $��35��61   $��
10 20 0 20q�6=   
���   �.��5      �� $��Images\icons8-copy-50.png��6   5      �� 5       -   5        $��	btn_paste��5       $��35��6'   $��35��62   $��
10 20 0 20q�6>   
���   �.��5"      �� $ ��Images\icons8-paste-50.png��6   5#      �� 5$      -   5         ��Name$ btn_selectAll��5$      $��
50 20 0 20q�6-   
���   �.��5&      �� $%��Images\icons8-select-all-50.png��6   5'      5)      �� 5*   
   -	   5        $��rich_txt��5*      $��0,83,0,0q�6&   68   5,      5-      