using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
namespace FinalPoeProg
{
    class Homeloan : Expense
    {
        public void HomeExpense(MainWindow mainWindow)
        {
            try
            {
                //accepting differents input from the use and storing it in a arrays
                //the for arechecking the conditions of the arrays
                for (int i = 0; i < 1; i++)
                {
                    price_property[i] = Convert.ToDouble(mainWindow.TBxmonthlyrepay.Text);

                    total_desposit[i] = Convert.ToDouble(mainWindow.TBxdeposit.Text);

                    interest_rate[i] = Convert.ToDouble(mainWindow.TBxinterestRate.Text);

                    if (Convert.ToDouble( mainWindow.TBxmonthlyrepay.Text) >= 240)
                    {
                        number_months[i] = Convert.ToInt32(mainWindow.TBxmonthlyrepay.Text);
                    }
                    else if (Convert.ToDouble(mainWindow.TBxmonthlyrepay.Text) >= 360)
                    {
                        number_months[i] = Convert.ToInt32(mainWindow.TBxmonthlyrepay.Text);
                    }
                    else
                    {
                        MessageBox.Show("You enter a wrong number");
                       
                    }
                    // calculating values and amount of loan 

                    double remaining_payment = price_property[i] - total_desposit[i];
                    double interest = interest_rate[i] / 100;

                    double years = number_months[i] / 12;

                    double first_step = 1 + interest * years;
                    double payments = remaining_payment * first_step;

                    double monthly_payments = payments / number_months[i];
                    double answer = Math.Round(monthly_payments,2);
                    monthly_repayment[i] = answer;
                    double third_gross_monthly = Total_income[0] / 3;

                    if(answer > third_gross_monthly)
                    {
                        MessageBox.Show("the home loan repayment is more then third of your total gross monthly income therefor the approval of the home loan is unlikely");
                    }

                    double total_remaining = Total_income[0] - Estimated_monthly_tax[0] - Estimated_spend_groceries[0] - travel_cost[0]
                        - cellPhone_telephone[0] - spend_water_lights[0] - other_expense[0] - total_desposit[0] - answer;
                    mainWindow.TBxcaldisplay.Text = "Remaining total = " + " R " + total_remaining;

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

    }

}
