using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midps_calc_mvc
{
     public partial class View : UserControl
     {
          Model model;

          public View()
          {
               InitializeComponent();
               model = new Model();
          }

          private void b0_Click(object sender, EventArgs e)
          {
               model.Number_Click(0);
               Display.Text = model.getResult();
          }

          private void bdot_Click(object sender, EventArgs e)
          {
               model.Dot_Click();
               Display.Text = model.getResult();
          }

          private void bplus_Click(object sender, EventArgs e)
          {
               model.Plus_Click();
               Display.Text = model.getResult();
          }

          private void bequ_Click(object sender, EventArgs e)
          {
               model.Equal_Click();
               Display.Text = model.getResult();
          }

          private void b1_Click(object sender, EventArgs e)
          {
               model.Number_Click(1);
               Display.Text = model.getResult();
          }

          private void b2_Click(object sender, EventArgs e)
          {
               model.Number_Click(2);
               Display.Text = model.getResult();
          }

          private void b3_Click(object sender, EventArgs e)
          {
               model.Number_Click(3);
               Display.Text = model.getResult();
          }

          private void bminus_Click(object sender, EventArgs e)
          {
               model.Minus_Click();
               Display.Text = model.getResult();
          }

          private void b4_Click(object sender, EventArgs e)
          {
               model.Number_Click(4);
               Display.Text = model.getResult();
          }

          private void b5_Click(object sender, EventArgs e)
          {
               model.Number_Click(5);
               Display.Text = model.getResult();
          }

          private void b6_Click(object sender, EventArgs e)
          {
               model.Number_Click(6);
               Display.Text = model.getResult();
          }

          private void bmul_Click(object sender, EventArgs e)
          {
               model.Multiply_Click();
               Display.Text = model.getResult();
          }

          private void bpow_Click(object sender, EventArgs e)
          {
               model.Power_Click();
               Display.Text = model.getResult();
          }

          private void b7_Click(object sender, EventArgs e)
          {
               model.Number_Click(7);
               Display.Text = model.getResult();
          }

          private void b8_Click(object sender, EventArgs e)
          {
               model.Number_Click(8);
               Display.Text = model.getResult();
          }

          private void b9_Click(object sender, EventArgs e)
          {
               model.Number_Click(9);
               Display.Text = model.getResult();
          }

          private void bdev_Click(object sender, EventArgs e)
          {
               model.Devide_Click();
               Display.Text = model.getResult();
          }

          private void blog_Click(object sender, EventArgs e)
          {
               model.Log_Click();
               Display.Text = model.getResult();
          }

          private void bback_Click(object sender, EventArgs e)
          {
               if (Display.Text != "")
               {
                    model.Back_Click();
                    Display.Text = model.getResult();
               }
          }

          private void bclear_Click(object sender, EventArgs e)
          {
               model.Clear_Click();
               Display.Text = model.getResult();
          }

          private void bnega_Click(object sender, EventArgs e)
          {
               model.Negate_Click();
               Display.Text = model.getResult();
          }

          private void bsqrt_Click(object sender, EventArgs e)
          {
               model.Sqrt_Click();
               Display.Text = model.getResult();
          }
     }
}
