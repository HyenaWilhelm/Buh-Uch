   M S B A M L   `   `   `  ����R  NУчёт бюджета, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Учёт_бюджетаУчёт_бюджета  5   	   (    "Учёт_бюджета.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Учёт_бюджета     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � -   5         � ColumnDefinitions 5
   
   �� 5      $��4* �6   �� 5       � RowDefinitions 5   
   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$
 MyDG��5         AutoGenerateColumns$ False��6!    J� RenderTransformOrigin$ 0.517,0.495&�6?   $��0��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   MinWidth$ 80Q�6>      Header$ ФИО��6L   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� *name+6L   4  .System.Windows.Controls.DataGridComboBoxColumn  5      -   5        DGColumn��$ Тип записи��5   e   $	 120Q�6y   
   SelectedItemBinding
 6;   �� *	entrytype+6y     5      $	 120Q�6?   $% Количество денег��6N   	 6%   �� *money+6N   4  .System.Windows.Controls.DataGridCheckBoxColumn  5         
Visibility$ Visible=�6G      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6\      CanUserResize$
 True��6h   $ 50Q�6}   $ 
Вычет��6�   	 6)   �� *	deduction+6�     5      $ Дата записи��6]   $	 120Q�6r   	 6%   �� *date+ �� StringFormat$ {0:dd.MM.yyyy}��6r      	CellStyle 5      �� 5      .@�5      �� $	��120��6   $	��120��6#    �� MaxDropDownHeight$	 120��60   5      �� 5   
   -   5         ��Name$ 
DatePicker��5       �� ItemStringFormat$ 
dd.MM.yyyy��6'   $	��120��6E   $��Center=�6Q   $	��Top=�6n   $��1��6�   $ 0.515,0.458&�6�   $��0,10,0,0q�6�   �� 5   
   -   5        $!��Удалить запись��5      $��1��6*   $��28��6:   $	��Top=�6F   $��0,60,0,0q�6^   $��Center=�6p   $��98��6�   $ 0.49,-0.434&�6�   �� 5    
   -   5        $#��Добавить запись��5       $��1��6+   $��28��6;   $	��Top=�6G   $��	0,107,0,0q�6v   $��Center=�6�   $	��120��6�   �� 5!   
   -   5         ��Name$ 
MyInputBox��5!       �� TextWrapping$
 Wrap=�6&   $��28��6:   $	��160��6F   $��Center=�6R   $��1��6�   5"      5#      