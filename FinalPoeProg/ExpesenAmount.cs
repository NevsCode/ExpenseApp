using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
namespace FinalPoeProg
{
    class ExpesenAmounts : Expense
    {
        public void ExpenseDatails(MainWindow mainWindow)
        {
            try
            {
                for (int i = 0; i < 1; i++)
                {
                    if (mainWindow.TBxtotalamount.Text != "")
                    {
                        Total_income[i] = Convert.ToDouble(mainWindow.TBxtotalamount.Text);
                        //the while loop it checking if the income it bigger then the tax
                        if (Convert.ToDouble(mainWindow.TBxtax.Text) < Convert.ToDouble(mainWindow.TBxtotalamount.Text))
                        {
                            Estimated_monthly_tax[i] = Convert.ToDouble(mainWindow.TBxtax.Text);
                        }
                        else
                        {
                            MessageBox.Show("Your monthly tax can not be more then your monthly income");
                        }

                        Estimated_spend_groceries[i] = Convert.ToDouble(mainWindow.TBxgroceries.Text);

                        spend_water_lights[i] = Convert.ToDouble(mainWindow.TBxwatrelight.Text);

                        travel_cost[i] = Convert.ToDouble(mainWindow.TBxtravel.Text);

                        cellPhone_telephone[i] = Convert.ToDouble(mainWindow.TBxcell_telephone.Text);

                        other_expense[i] = Convert.ToDouble(mainWindow.TBxotherexpenses.Text);

                    }
                    else
                    {
                        MessageBox.Show("Fill in all the textboxs");
                    }

                }


            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

    }
}
