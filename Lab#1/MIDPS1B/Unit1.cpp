//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
#include "stdio.h"
#include "dos.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"

struct date d;
struct time t;

class Cronos {
private:
    int minute;
    int secunde;
    int zecimi;
public:
    Cronos(){
      this->minute = 0;
      this->secunde = 0;
      this->zecimi = 0;
    }
    void incCronos(){
      this->zecimi++;
      if(this->zecimi == 10){
        this->zecimi = 0;
        this->secunde++;
      }
      if(this->secunde == 60){
        this->secunde = 0;
        this->minute++;
      }
    }
    void zeroCronos(){
      this->minute = 0;
      this->secunde = 0;
      this->zecimi = 0;
    }
    int getM(){
      return this->minute;
    }
    int getS(){
      return this->secunde;
    }
    int getZ(){
      return this->zecimi;
    }
};

Cronos cronometru;

TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
  Timer2->Enabled = false;
  char buf[30];
  sprintf(buf,"%02d min  %02d sec  %02d zec",cronometru.getM(),
  cronometru.getS(),cronometru.getZ());
  Edit2->Text = (AnsiString)buf;
  getdate(&d);
  gettime(&t);
  sprintf(buf,"%02d-%02d-%4d %02d:%02d:%02d",d.da_day,d.da_mon,d.da_year,
  t.ti_hour,t.ti_min,t.ti_sec);
  Edit1->Text=(AnsiString)buf;

}
//---------------------------------------------------------------------------

void __fastcall TForm1::Timer1Timer(TObject *Sender)
{
  char buf[20];
  getdate(&d);
  gettime(&t);
  sprintf(buf,"%02d-%02d-%4d %02d:%02d:%02d",d.da_day,d.da_mon,d.da_year,
  t.ti_hour,t.ti_min,t.ti_sec);
  Edit1->Text=(AnsiString)buf;
  
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button4Click(TObject *Sender)
{
  Close();
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Timer2Timer(TObject *Sender)
{
   cronometru.incCronos();
   char buf[30];
   sprintf(buf,"%02d min  %02d sec  %02d zec",cronometru.getM(),
   cronometru.getS(),cronometru.getZ());
   Edit2->Text = (AnsiString)buf;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button1Click(TObject *Sender)
{
  Timer2->Enabled = true;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button2Click(TObject *Sender)
{
  Timer2->Enabled = false;        
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button3Click(TObject *Sender)
{
  cronometru.zeroCronos();
  char buf[30];
  sprintf(buf,"%02d min  %02d sec  %02d zec",cronometru.getM(),
  cronometru.getS(),cronometru.getZ());
  Edit2->Text = (AnsiString)buf;
}
//---------------------------------------------------------------------------
