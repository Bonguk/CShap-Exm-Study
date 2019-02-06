using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharpWin
{
    public enum Operators { Add, Sub, Multi, Div } // 열거형 연산자 


    public partial class Calculator : Form
    {

        public int Result = 0;
        public bool isNewNum = true;
        public Operators Opt = Operators.Add;

        public Calculator()
        {
            InitializeComponent();
        }
        
        private void NumButton1_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender; // 오브젝트 타입인 Sender를 버튼 형태로 변형
            SetNum(numButton.Text);
        }

        public void SetNum(string num)
        {
            if (isNewNum)
            {
                NumScreen.Text = num;
                isNewNum = false;
            }
            else if (NumScreen.Text == "0")
            {
                NumScreen.Text = num;
            }
            else
            {
                NumScreen.Text = NumScreen.Text + num;
            }

        }

        private void NumPlus_Click(object sender, EventArgs e)
        {
            if (isNewNum == false) // 예외 처리 
            {
                int num = int.Parse(NumScreen.Text);
                if (Opt == Operators.Add)
                    Result = Result + num;
                else if (Opt == Operators.Sub)
                    Result = Result - num;
                else if (Opt == Operators.Multi)
                    Result = Result * num;
                else if (Opt == Operators.Div)
                    Result = Result / num;

                NumScreen.Text = Result.ToString();
                isNewNum = true; // 새로운 숫자가 입력되게 하는 변수
            }

            Button optButton = (Button)sender;
            if (optButton.Text == "+")
                Opt = Operators.Add;
            else if (optButton.Text == "-")
                Opt = Operators.Sub;
            else if (optButton.Text == "*")
                Opt = Operators.Multi;
            else if (optButton.Text == "/")
                Opt = Operators.Div;

            // 연산자 버튼 - 숫자 완성, 변수와 숫자를 저장된 연산자로 연산, 결과를 변수에 저장, 현재 연산자를 저장.
        }

        private void NumClear(object sender, EventArgs e)
        {
            Result = 0;
            isNewNum = true;
            Opt = Operators.Add;

            NumScreen.Text = "0";
        }


    }
}
