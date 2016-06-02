object Form1: TForm1
  Left = 710
  Top = 236
  Width = 503
  Height = 195
  Caption = 'MIDPS 1-A'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 216
    Top = 16
    Width = 5
    Height = 13
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clRed
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = [fsBold]
    ParentFont = False
  end
  object Label2: TLabel
    Left = 216
    Top = 40
    Width = 11
    Height = 13
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = [fsBold, fsItalic]
    ParentFont = False
  end
  object Up: TButton
    Left = 16
    Top = 8
    Width = 89
    Height = 33
    Caption = 'UP'
    TabOrder = 0
    OnClick = UpClick
  end
  object Down: TButton
    Left = 16
    Top = 104
    Width = 89
    Height = 33
    Caption = 'DOWN'
    TabOrder = 1
    OnClick = DownClick
  end
  object Edit1: TEdit
    Left = 128
    Top = 64
    Width = 121
    Height = 21
    TabOrder = 2
    Text = 'Edit1'
  end
  object Exit: TButton
    Left = 256
    Top = 104
    Width = 89
    Height = 33
    Caption = 'Exit'
    TabOrder = 3
    OnClick = ExitClick
  end
end
