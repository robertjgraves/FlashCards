using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlashCards
{
    public partial class Default : System.Web.UI.Page
    {
        Random rand = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                setupCards();
            }
           
        }

        protected void checkAnswerButton_Click(object sender, EventArgs e)
        {
            if(answerTextBox.Text != "")
            {
                int product = int.Parse(multiplicandLabel.Text) * int.Parse(multiplierLabel.Text);
                int answer = int.Parse(answerTextBox.Text);

                checkAnswer(product, answer);
            }
            
            else
            {
                resultLabel.Text = "Please enter a value.";
            }
        }

        public void setupCards()
        {
            int startingValue = 2;
            int endingValue = 10;

            int multiplicand = getNumber(startingValue, endingValue);
            int multiplier = getNumber(startingValue, endingValue);

            multiplicandLabel.Text = multiplicand.ToString();
            multiplierLabel.Text = multiplier.ToString();
            answerTextBox.Text = "";
            answerTextBox.Focus();
        }

        public int getNumber(int start, int end)
        {
            return rand.Next(start, end);
        }

        public void checkAnswer(int product, int answer)
        {
            if (product == answer)
            {
                resultLabel.Text = "You are correct!";
                int streak = int.Parse(countLabel.Text);
                streak++;
                countLabel.Text = streak.ToString();
            }
            else
            { 
                resultLabel.Text = String.Format("This answer is {0}.", product);
                countLabel.Text = "0";
            }
        }

        protected void newCard_Click(object sender, EventArgs e)
        {
            setupCards();
        }
    }
}