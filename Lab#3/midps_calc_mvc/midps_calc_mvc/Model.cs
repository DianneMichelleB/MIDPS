using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midps_calc_mvc
{
     class Model
     {
          double First_operand;
          double Second_operand;
          string Operation;
          string Result;
          bool Dot;

          public string getResult()
          {
               return Result;
          }

          public void Clear_Click()
          {
               Result = "";
               Dot = false;
          }

          public void Back_Click()
          {
               if (Result != "")
               {
                    Result = Result.Remove(Result.Length - 1);
               }
          }

          public void Number_Click(double Number)
          {
               Result += Number.ToString();
          }

          public void Equal_Click()
          {
               if (Result != "")
               {
                    Second_operand = Convert.ToDouble(Result);

                    switch (Operation)
                    {
                         case "+": Result = Convert.ToString(First_operand + Second_operand); break;
                         case "-": Result = Convert.ToString(First_operand - Second_operand); break;
                         case "*": Result = Convert.ToString(First_operand * Second_operand); break;
                         case "/": Result = Convert.ToString(First_operand / Second_operand); break;
                         case "^": Result = Convert.ToString(Math.Pow(First_operand, Second_operand)); break;
                         default: return;
                    }
                    Operation = "NaN";
               }
          }

          public void Plus_Click()
          {
               if (Result != "")
               {
                    First_operand = Convert.ToDouble(Result);
                    Second_operand = 0;
                    Operation = "+";
                    Result = "";
                    Dot = false;
               }
          }

          public void Minus_Click()
          {
               if (Result != "")
               {
                    First_operand = Convert.ToDouble(Result);
                    Second_operand = 0;
                    Operation = "-";
                    Result = "";
                    Dot = false;
               }
          }

          public void Multiply_Click()
          {
               if (Result != "")
               {
                    First_operand = Convert.ToDouble(Result);
                    Second_operand = 0;
                    Operation = "*";
                    Result = "";
                    Dot = false;
               }
          }

          public void Devide_Click()
          {
               if (Result != "")
               {
                    First_operand = Convert.ToDouble(Result);
                    Second_operand = 0;
                    Operation = "/";
                    Result = "";
                    Dot = false;
               }
          }

          public void Dot_Click()
          {
               if (Result != "")
               {
                    if (!Dot)
                    {
                         Result += ".";
                         Dot = true;
                    }
                    else
                    {
                         return;
                    }
               }
          }

          public void Negate_Click()
          {
               if (Result != "")
               {
                    First_operand = Convert.ToDouble(Result);
                    First_operand = -First_operand;
                    Result = Convert.ToString(First_operand);
               }
          }

          public void Sqrt_Click()
          {
               if (Result != "")
               {
                    First_operand = Convert.ToDouble(Result);
                    First_operand = Math.Sqrt(First_operand);
                    Result = Convert.ToString(First_operand);
               }
          }

          public void Power_Click()
          {
               if (Result != "")
               {
                    First_operand = Convert.ToDouble(Result);
                    Second_operand = 0;
                    Operation = "^";
                    Result = "";
                    Dot = false;
               }
          }

          public void Log_Click()
          {
               if (Result != "")
               {
                    First_operand = Convert.ToDouble(Result);
                    First_operand = Math.Log10(First_operand);
                    Result = Convert.ToString(First_operand);
               }
          }
     }
}
