using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
namespace FinalPoeProg
{
    class Display : Expense
    {
        public void DisplayExpensess(MainWindow mainWindow)
        {
            for(int i = 0; i < 1; i++)
            {
                mainWindow.TBxdisplay.Text = "Monthly income : R " + Convert.ToString(Total_income[i]) 
                                              + "\nMonthly tax : R " + Convert.ToString(Estimated_monthly_tax[i])
                                              + "\nGroceries : R " + Convert.ToString(Estimated_spend_groceries[i])
                                              + "\nWater and lights : R " + Convert.ToString(spend_water_lights[i])
                                              + "\nTravel costs (including petrol) : R " + Convert.ToString(travel_cost[i])
                                              + "\nCell phone and telephone : R " + Convert.ToString(cellPhone_telephone[i])
                                              + "\nOther expenses : R " + Convert.ToString(other_expense[i]);
            }

        }

        public void RemainingAmount(MainWindow mainWindow)
        {
            try
            {
                for (int i = 0; i < 1; i++)
                {
                    renting_amount[i] = Convert.ToDouble(mainWindow.TBxrenting.Text);
                    double total_remaining = Total_income[i] - Estimated_monthly_tax[i] 
                                            - Estimated_spend_groceries[i] - travel_cost[i]
                                            - cellPhone_telephone[i] - spend_water_lights[i] 
                                            - other_expense[i] - renting_amount[i];
                    mainWindow.TBxcaldisplay.Text = "Renting Amount : R " + renting_amount[i] + "\nRemaining total = " + " R " + Convert.ToString(total_remaining);
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }



    }
}
