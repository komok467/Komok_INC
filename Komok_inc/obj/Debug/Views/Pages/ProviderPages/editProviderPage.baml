   M S B A M L   `   `   `  ����D  @Komok_inc, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:Komok_inc.Views.Pages.ProviderPages#Komok_inc.Views.Pages.ProviderPages  5      :    4Komok_inc.Views.Pages.ProviderPages.editProviderPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:Komok_inc.Views.Pages.ProviderPages     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   %     N� Title$  editProviderPage��6      MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      .��5      � .+�5   
   �� -   5         ��Name$ txtTitle��5      $
��Left=�6$   $��	45,87,0,0q�6?    �� TextWrapping$
 Wrap=�6R   $	��Top=�6f   $	��335��6~   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Наименоване��5       % !MaterialDesignFloatingHintTextBox#��[ 5      �� 5   
   -   5         ��Name$ comboBoxCountry��5      $
��Left=�6,   $��
45,147,0,0q�6G   $	��Top=�6[   $	��335��6s   $ Страна��5       & "MaterialDesignFloatingHintComboBox#��[ 5      .@�5      �� .��6   
Китай6"   �� 5      .��6   Россия6#   �� 5      .��6   США6    �� 5      .��6   Канада6#   �� 5      .��6   #!Саудовская Аравия6.   �� 5      .��6   Эквадор6$   �� 5       .��6   Франция6$   �� 5!      .��6   Германия6%   �� 5"      .��6   Финляндия6&   5#      �� 5$   
   -   5        $ txtCity��5$      $
��Left=�6#   $��
45,201,0,0q�6>   $
 Wrap=�6R   $	��Top=�6f   $	��335��6~   $ 
Город��5%      #��[ 5&      �� 5'   
   -   5        $ txtEmail��5'      $
��Left=�6$   $��
45,260,0,0q�6?   $
 Wrap=�6S   $	��Top=�6g   $	��335��6   $ E-Mail��5(      #��[ 5)      �� 5*   
   -   5        	 ��Name$	 	logoImage��5*      $
��Left=�6#   $	��178��6>   $��465,125,0,0q�6K   $	��Top=�6`   $	��270��6x   �� 5+   
   -   5        
 ��Name$
 
buttonBack��5+      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5,      $��
Назад��5.      $
��Left=�6!   $��
45,345,0,0q�6<   $	��Top=�6P   $	��145��6h   $��45��6t   �� 5/   
   -   5        $
 
buttonDone��5/      $ 15��50      $��
Готов��52      $
��Left=�6   $��235,345,0,0q�68   $	��Top=�6M   $	��145��6e   $��45��6q   �� 53   
   -   5        $
 
buttonLoad��53      $ 15��54      $��Выбрать��56      $
��Left=�6   $��525,319,0,0q�6:   $	��Top=�6O   $	��145��6g   $��45��6s   58      59      