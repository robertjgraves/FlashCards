using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlashCards
{
    public partial class Division : System.Web.UI.Page
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
                int quotient = int.Parse(dividendLabel.Text) / int.Parse(divisorLabel.Text);
                checkAnswer(quotient, answer);
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

            int multiplicand = getNumber(startingValue, endingValue);
            int multiplier = getNumber(startingValue, endingValue);
            int dividend = multiplicand * multiplier;

            dividendLabel.Text = dividend.ToString();
            divisorLabel.Text = multiplier.ToString();
            answerTextBox.Text = "";
            answerTextBox.Focus();
        }

        public int getNumber(int start, int end)
        {
            return rand.Next(start, end);
        }

        public void checkAnswer(int quotient, int answer)
        {
            if (quotient == answer)
            {
                resultLabel.CssClass = "text-success";
                resultLabel.Text = String.Format("{0} ÷ {1} = {2} and is correct!", dividendLabel.Text, divisorLabel.Text, answer);
                int streak = int.Parse(countLabel.Text);
                streak++;
                countLabel.Text = streak.ToString();
                setupCards();
            }
            else
            {
                resultLabel.CssClass = "text-danger";
                resultLabel.Text = String.Format("{0} ÷ {1} = {2}. Your answer of {3} is not correct.", dividendLabel.Text, divisorLabel.Text, quotient, answer);
                countLabel.Text = "0";
                setupCards();
            }
        }
    }
}