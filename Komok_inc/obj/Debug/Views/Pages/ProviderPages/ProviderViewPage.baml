   M S B A M L   `   `   `  ����D  @Komok_inc, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:Komok_inc.Views.Pages.ProviderPages#Komok_inc.Views.Pages.ProviderPages  5      :    4Komok_inc.Views.Pages.ProviderPages.ProviderViewPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:Komok_inc.Views.Pages.ProviderPages     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
      -   5          N� Title$  ProviderViewPage��5	         MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataProviderView��5         AutoGenerateColumns .  $
��Left=�5      $	��375��6.   $��
10,115,0,0q�6;   $	��Top=�6O   $
��1060��6g      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 0.4* 6H   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   �� *ID+6H     5      $ Наименовние��6%   $	 * 6T   
 6:   �� *Title+6T     5      $ Страна��6%   $	 * 6Q   
 65   �� *	Country+6Q     5      $ 
Город��6%   $	 * 6M   
 64   �� *City+6M     5      $ E-mail��6%   $	 * 6O   
 65   �� *Email+6O   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Логотип��6)   $	 * 6:      CellTemplate 5      �� 5       .R�5!      �� ��6$   �� *Logo+5"      5$      5&      �� 5'   
   -   5         ��Name$ 	txtSearch��5'      $
��Left=�6%   $��	40,42,0,0q�6@    �� TextWrapping$
 Wrap=�6S   $	��Top=�6g   $	��345��6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Поиск��5(       % !MaterialDesignFloatingHintTextBox#��[ 5)      6M   �� 5+   
   -   5         ��Name$ buttonCreate��5+      +	  %MaterialDesignThemes.Wpf.ButtonAssist 	  CornerRadius$ 15��5,      $��Создать��5-      $
��Left=�6#   $��229,530,0,0q�6>   $	��Top=�5.      $	��195��6)   $��35��65   5/      �� 50   
   -   5        $ 
buttonEdit��50      $ 15��51      $ ��Редактировать��52      $
��Left=�6%   $��444,530,0,0q�6@   $	��Top=�53      $	��195��6%   $��35��61   54      �� 55   
   -   5        $ buttonRemove��55      $ 15��56      $��Удалить��57      $
��Left=�6   $��875,530,0,0q�6:   $	��Top=�58      $	��195��6%   $��35��61   59      �� 5:   
   -   5        $ buttonExport��5:      $ 15��5;      $��Выгрузить��5<      $
��Left=�6!   $��662,530,0,0q�6<   $	��Top=�5=      $	��195��6%   $��35��61   5>      �� 5?   
   -   5        $ 
buttonBack��5?      $ 15��5@      $��
Назад��5A      $
��Left=�6   $��
10,530,0,0q�68   $	��Top=�5B      $	��195��6%   $��35��61   5C      5E      5F      