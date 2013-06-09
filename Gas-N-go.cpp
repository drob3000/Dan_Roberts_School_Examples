/* -----------------------------------------------------------------------------
** Name	                :  Dan Roberts
** Date Created	        :  04/18/2011
** Description	        :  Gas-N-Go
** Modification History	:
** Name	                Date	        Description
** -----------------------------------------------------------------------------
** Dan Roberts     	04/18/2011	      Initial Version
** -----------------------------------------------------------------------------
*/

#include <stdio.h>
#include <stdlib.h>


         float leaded = (4.00);
         float unleaded = (4.50);
         float fedTax = (0.10);
         float salesTax = (0.05);
         float gasNgo = (1.00);
         float fullService = (2.00);
         float gallons = (0.0);
         int gasSelection =(0);
         char service = ' ';  


         
int main (void)
{


    // Introduce the program statement and the variables for the program
    // What service the customer is selecting and the type of gas purchased.
    printf (" The program calculates the amount of charges for gasoline\n");
    printf (" and services including Sales Tax and Federal Gas Tax \n");
    printf (" There is no service charge for self service Gasoline \n");
    printf (" There is a $1.00 charge for Gas N Go \n");
    printf (" There is a $2.00 charge for Full Service \n");
    printf (" Leaded Gasoline is $4.00 per gallon \n");
    printf (" Unleaded Gasoline is $4.50 per gallon \n\n");
    printf ("\t For self service please select S \n");
    printf ("\t For Gas N Go please select G \n");
    printf ("\t For full service please select F \n");  
    printf ("\t Please select the service level: "); 
    scanf ("%c", &service);
    printf (" \n\n\t Please select the type of gasoline\n");
    printf ("\t Select 1 for leaded Gasoline \n");
    printf ("\t Select 2 for unleaded Gasoline \n");
    printf ("\t Please select gasoline grade: ");
    scanf (" %d", &gasSelection);

    // switch function to allow for multiple selections gasoline selection
    // is incorporated in the case file. 
     switch (service)
   {
          case 'S':
          case 's':
               if (gasSelection == 1)
{
    // Outputs the customers selection of gasoline and service           
    printf ("\n\t You have selected self service \n");
    printf ("\t you have selected leaded gasoline \n");
    printf ("\t enter number of gallons purchased: ");
    scanf (" %f", &gallons);
    // Calculates the federal tax due on the gasoline purchase
    float fTax = (leaded * gallons) * fedTax;
    // Calculates the sales tax due on the purchase
    float sTax = (leaded * gallons) * salesTax;
    // Calculates the total purchase
    float total = (leaded * gallons) + fTax + sTax;
    // Outputs the total due from the customer
    printf ("\n\t your amount due is: $ %.2f\n", total);
    break;
}
          else if (gasSelection == 2)
{
    // Outputs the customers selection of gasoline and service
    printf ("\n\t You have selected self service \n");
    printf ("\t you have selected unleaded gasoline \n");
    printf ("\t enter number of gallons purchased: ");
    scanf (" %f", &gallons);
    // Calculates the federal tax due on the gasoline purchase
    float fTax = (unleaded * gallons) * fedTax;
    // Calculates the sales tax due on the purchase
    float sTax = (unleaded * gallons) * salesTax;
    // Calculates the total purchase
    float total = (unleaded * gallons) + fTax + sTax;
    // Outputs the total due from the customer
    printf ("\n\t your amount due is: $ %.2f\n", total);
    break;
}
           case 'G':
           case 'g':
           if (gasSelection == 1)
{
    // Outputs the customers selection of gasoline and service
    printf ("\n\t You have selected Gas N Go \n");
    printf ("\t you have selected leaded gasoline \n");
    printf ("\t enter number of gallons purchased: ");
    scanf (" %f", &gallons);
    // Calculates the federal tax due on the gasoline purchase
    float fTax = (leaded * gallons) * fedTax;
    // Calculates the sales tax due on the purchase
    float sTax = (leaded * gallons + gasNgo) * salesTax;
    // Calculates the total purchase
    float total = (leaded * gallons + gasNgo) + fTax + sTax;
    // Outputs the total due from the customer
    printf ("\n\t your amount due is: $ %.2f\n", total);
    break;
}
    else if (gasSelection == 2)
{
    // Outputs the customers selection of gasoline and service
    printf ("\n\t You have selected Gas N Go \n");
    printf ("\t you have selected unleaded gasoline \n");
    printf ("\t enter number of gallons purchased: ");
    scanf (" %f", &gallons);
    // Calculates the federal tax due on the gasoline purchase
    float fTax = (unleaded * gallons) * fedTax;
    // Calculates the sales tax due on the purchase
    float sTax = (unleaded * gallons + gasNgo) * salesTax;
    // Calculates the total purchase
    float total = (unleaded * gallons + gasNgo) + fTax + sTax;
    // Outputs the total due from the customer
    printf ("\n\t your amount due is: $ %.2f\n", total);
    break;
}
           case 'F':
           case 'f':
           if (gasSelection == 1)
{
    // Outputs the customers selection of gasoline and service
    printf ("\n\t You have selected full service \n");
    printf ("\t you have selected leaded gasoline \n");
    printf ("\t enter number of gallons purchased: ");
    scanf (" %f", &gallons);
    // Calculates the federal tax due on the gasoline purchase
    float fTax = (leaded * gallons) * fedTax;
    // Calculates the sales tax due on the purchase
    float sTax = (leaded * gallons + fullService) * salesTax;
    // Calculates the total purchase
    float total = (leaded * gallons + fullService) + fTax + sTax;
    // Outputs the total due from the customer
    printf ("\n\t your amount due is: $ %.2f\n", total);
    break;
}
    else if (gasSelection == 2)
{
    // Outputs the customers selection of gasoline and service
    printf ("\n\t You have selected full service \n");
    printf ("\t you have selected unleaded gasoline \n");
    printf ("\t enter number of gallons purchased: ");
    scanf (" %f", &gallons);
    // Calculates the federal tax due on the gasoline purchase
    float fTax = ((unleaded * gallons) * fedTax);
    // Calculates the sales tax due on the purchase
    float sTax = (unleaded * gallons + fullService) * salesTax;
    // Calculates the total purchase
    float total = (unleaded * gallons + fullService) + fTax + sTax;
    // Outputs the total due from the customer
    printf ("\n\t Your amount due is: $ %.2f\n", total);
    break;
}
          default:
                  printf( "\n\n\t Invalid Service Selection\n\n\n");
}
      system ("pause");
    exit (0);
}
