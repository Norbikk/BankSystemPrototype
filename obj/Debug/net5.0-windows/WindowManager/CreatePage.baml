   M S B A M L   `   `   `  ����N  JBankSystemPrototype, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:BankSystemPrototypeBankSystemPrototype  5      $    BankSystemPrototype.CreatePage   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:BankSystemPrototype     5        N� 
Background
  ����� N� Title$ DataPage��5	      $	��600��6   $	��800��6%   .��5
      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ 
Descripton��5      $
��Left=�6(   $��	85,10,0,0q�5      $E��?Введите данные для создания счета ��5      $
��Wrap=�5      $��35(�5      $��Oblique$�5      $
��Bold"�5      $	��Top=�5      $��3��5      $	��771��5      �� 5    
   -   5         ��Name$ 
BackButton��5       $��1��6%   $��3��65   $��
Назад��5!      
�������$��173,0,180,85q�5"   9   $��2��6O   �� 5#   
   -   5        $ NameDescription��5#      $��Center=�6-   $��	0,104,0,0q�6J   $��Имя: ��6]   $
��Wrap=�6j   $	��Top=�6~   $��1��6�   �� 5%   
   -   5         ��Name$ NameBox��5%      $�� ��6#    �� TextWrapping$
 Wrap=�5&      $��	0,123,0,0q�5'      $��Italic$�5(      $��Medium"�5)      $��Center=�5*      $	��Top=�5+      $��15(�5,      $��1��6    �� 5.   
   -   5        $ SurnameDescription��5.      $��Center=�60   $��Фамилия: ��5/      $
��Wrap=�50      $	��Top=�51      $��1��6,   $��1��69   �� 52   
   -   5        $ 
SurnameBox��52      $�� ��53      $
 Wrap=�54      $��0,20,0,0q�55      $��Italic$�56      $��Medium"�57      $��Center=�58      $	��Top=�59      $��15(�5:      $��1��6   $��1��6(   �� 5<   
   -   5        $ SecondnameDescription��5<      $��Center=�63   $��0,55,0,0q�5=      $��Отчество: ��5>      $
��Wrap=�5?      $	��Top=�5@      $��1��6%   $��1��62   �� 5A   
   -   5        $ SecondnameBox��5A      $�� ��5B      $
 Wrap=�5C      $��0,75,0,0q�5D      $��Italic$�5E      $��Medium"�5F      $��Center=�5G      $	��Top=�5H      $��15(�5I      $��1��6   $��1��6(   �� 5K   
   -	   5        $ BirthdayDescription��5K      $
��Left=�61   $��	90,21,0,0q�6L   $!��Дата рождения: ��6_   $
��Wrap=�6v   $	��Top=�6�   $��1��6�   $��2��6�   �� 5M   
   -
   5        $ PhoneNumberText��5M      $
��Left=�6-   $��
86,111,0,0q�6H   $#��Номер Телефона: ��6\   $
��Wrap=�6t   $	��Top=�6�   $��1��6�   $��1��6�   �� 5O   
   -   5        $ PhoneBox��5O      $�� ��6$   $
 Wrap=�5P      $��	0,128,0,0q�5Q      $��Italic$�5R      $��Medium"�5S      $��Center=�5T      $	��Top=�5U      $��15(�5V      $��1��6   $��1��6+   (  "System.Windows.Controls.DatePicker  5X   
   -   5          Name$ 	BirthDate��5X      $��1��6(   $
��Left=�68   $��3,42,0,0q�6S   $	��Top=�6e   $	��266��6}   $��27��6�   $��2��6�   $��2��6�   �� 5Y   
   -   5        $ CreateButton��5Y      $��3��6'   
�������$��Открыть счет��5Z       $��176,0,178,85q�67   $��2��6h   �� 5[   
   -   5        $ AccountNumberText��5[      $��3��5\      $
��Left=�5]      $	��Top=�5^      	 �� TextAlignment$	 Center=�5_      $��168,100,0,0q�5`      $��2��5a      $
��Wrap=�5b      $	��470��5d      $��21��5e      �� 5f   
   -   5        
 ��Name$
 DepositeCheckBox��5f      $#��Депозитный счет��6-   $��1��6G   $
��Left=�6W   $��3,95,0,0q�6r   $��2��6�   $	��Top=�6�   �� 5g   
   -   5        $
 NonDepositeCheckBox��5g      $(��"Не депозитный счет��60   $��1��6M   $
��Left=�6]   $��
138,95,0,0q�6x   $��2��6�   $	��Top=�6�   $��2��6�    � 5h   
   -   5          �Name$ 	MainFrame��5h      $��3��66   $��4��6J   5i      5j      