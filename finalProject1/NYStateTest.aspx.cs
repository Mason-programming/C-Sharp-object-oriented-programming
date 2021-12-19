using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text; 

namespace finalProject1
{
    

    public partial class NYStateTest : System.Web.UI.Page
    {

       public object[] Answers = new object[20];
        TextBox[] text = new TextBox[20]; 

       
       
        protected void Page_Load(object sender, EventArgs e)
        {
            Label5.Text = Calendar1.TodaysDate.DayOfWeek.ToString() + ", " + Calendar1.TodaysDate.Month.ToString() + " " + Calendar1.TodaysDate.Day.ToString
                () + ", " + Calendar1.TodaysDate.Year.ToString();
            TextBox1.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            text[0] = TextBox4;
            text[1] = TextBox5;
            text[2] = TextBox6;
            text[3] = TextBox7;
            text[4] = TextBox8;
            text[5] = TextBox9;
            text[6] = TextBox10;
            text[7] = TextBox11;
            text[8] = TextBox12;
            text[9] = TextBox13;
            text[10] = TextBox14;
            text[11] = TextBox15;
            text[12] = TextBox16;
            text[13] = TextBox17;
            text[14] = TextBox18;
            text[15] = TextBox19;
            text[16] = TextBox20;
            text[17] = TextBox21;
            text[18] = TextBox22;
            text[19] = TextBox23;
            int noAnswer = 0; 

            int score = 0; 
            Answers[0] = "B";
            Answers[1] = "D";
            Answers[2] = "A";
            Answers[3] = "A";
            Answers[4] = "C";
            Answers[5] = "A";
            Answers[6] = "B";
            Answers[7] = "A";
            Answers[8] = "C";
            Answers[9] = "D";
            Answers[10] = "B";
            Answers[11] = "C";
            Answers[12] = "D";
            Answers[13] = "A";
            Answers[14] = "D";
            Answers[15] = "C";
            Answers[16] = "C";
            Answers[17] = "A";
            Answers[18] = "D";
            Answers[19] = "A";

            string[] s = Answers.Cast<string>().ToArray();

            for(int i = 0; i < s.Length; i++)
            {
                if (text[i].Text == "") noAnswer ++; 
                
                if (text[i].Text == "A" || text[i].Text == "B" || text[i].Text == "C" || text[i].Text == "D")
                {
                    if (s[i] == text[i].Text) score++;
                }
                else Label4.Text = "Please Enter: A, B, C, D"; 

            }
        
            Label1.Text = score.ToString(); 
            if(score <= 10)
            {
                Label2.Text = "You Fail, Please Try Again!";
            }else if(score >= 11)
            {
                Label2.Text = "You Pass, Congratulations";
            }

            if(noAnswer >= 1)
            {
                Label2.Text = "";
                Label1.Text = ""; 
                Label3.Text = "INVALID INPUT: PLEASE FILL OUT ALL BLANKS";
            }
            using (StreamWriter testData = new StreamWriter(Server.MapPath("~/data.txt")))
            {
                testData.WriteLine(" "+ TextBox1.Text + " " + TextBox2.Text + " " + TextBox3.Text + ": Correct Answers " + Label1.Text + " Pass or Fail" + Label2.Text + " Exam Date: " + Label5.Text);
            }

            string[] lines = System.IO.File.ReadAllLines(Server.MapPath("~/data.txt"));
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label3.Text = ""; 
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";
            TextBox13.Text = "";
            TextBox14.Text = "";
            TextBox15.Text = "";
            TextBox16.Text = "";
            TextBox17.Text = "";
            TextBox18.Text = "";
            TextBox19.Text = "";
            TextBox20.Text = "";
            TextBox21.Text = "";
            TextBox22.Text = ""; 
            TextBox23.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = ""; 

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

            

        }
    }
}