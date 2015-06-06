using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlashCards
{
    public partial class Addition : System.Web.UI.Page
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
            int answer;

            bool result = int.TryParse(answerTextBox.Text, out answer);

            if (result)
            {
                int sum = int.Parse(addend1Label.Text) + int.Parse(addend2Label.Text);
                checkAnswer(sum, answer);
            }
            else
            {
                resultLabel.Text = "Please enter a valid answer!";
                resultLabel.CssClass = "text-warning";
            }
        }

        public void setupCards()
        {
            int startingValue = 1;
            int endingValue = 10;

            int addend1 = getNumber(startingValue, endingValue);
            int addend2 = getNumber(startingValue, endingValue);

            addend1Label.Text =  addend1.ToString();
            addend2Label.Text = addend2.ToString();
            answerTextBox.Text = "";
            answerTextBox.Focus();
        }

        public int getNumber(int start, int end)
        {
            return rand.Next(start, end);
        }

        public void checkAnswer(int sum, int answer)
        {
            if (sum == answer)
            {
                resultLabel.CssClass = "text-success";
                resultLabel.Text = String.Format("{0} + {1} = {2} and is correct!", addend1Label.Text, addend2Label.Text, answer);
                int streak = int.Parse(countLabel.Text);
                streak++;
                countLabel.Text = streak.ToString();
                setupCards();
            }
            else
            {
                resultLabel.CssClass = "text-danger";
                resultLabel.Text = String.Format("{0} + {1} = {2}. Your answer of {3} is not correct.", addend1Label.Text, addend2Label.Text, sum, answer);
                countLabel.Text = "0";
                setupCards();
            }
        }
    }
}