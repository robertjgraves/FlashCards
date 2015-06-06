using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlashCards
{
    public partial class Subtraction : System.Web.UI.Page
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
                int difference = int.Parse(minuendLabel.Text) - int.Parse(subtrahendLabel.Text);
                checkAnswer(difference, answer);
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

            int augend = getNumber(startingValue, endingValue);
            int addend = getNumber(startingValue, endingValue);
            int minuend = augend + addend;

            minuendLabel.Text = minuend.ToString();
            subtrahendLabel.Text = augend.ToString();
            answerTextBox.Text = "";
            answerTextBox.Focus();
        }

        public int getNumber(int start, int end)
        {
            return rand.Next(start, end);
        }

        public void checkAnswer(int difference, int answer)
        {
            if (difference == answer)
            {
                resultLabel.CssClass = "text-success";
                resultLabel.Text = String.Format("{0} - {1} = {2} and is correct!", minuendLabel.Text, subtrahendLabel.Text, answer);
                int streak = int.Parse(countLabel.Text);
                streak++;
                countLabel.Text = streak.ToString();
                setupCards();
            }
            else
            {
                resultLabel.CssClass = "text-danger";
                resultLabel.Text = String.Format("{0} - {1} = {2}. Your answer of {3} is not correct.", minuendLabel.Text, subtrahendLabel.Text, difference, answer);
                countLabel.Text = "0";
                setupCards();
            }
        }
    }
}