/* -----------------------------------------------------------------------------
** Name	                :  Dan Roberts
** Date Created	        :  04/18/2011
** Description	        : Currency Conversion
** Modification History	:
** Name	                Date	        Description
** -----------------------------------------------------------------------------
** Dan Roberts     	04/18/2011	      Initial Version
** -----------------------------------------------------------------------------
*/

#include <stdio.h>
#include <stdlib.h>

         float usd = (0.0);  // Setup initial value for the American currency.
         float eur = (0.69275); // Setup initial value for the Euro currency.
         float gbp = (0.61228); // Setup initial value for the British currency.
         float aud = (0.94594);  // Setup initial value for the Australian currency.
         float jpy = (83.08);  // Setup initial value for the Japanese currency.
         float mxn = (11.6488);  // Setup initial value for the Mexican currency.
         float value = (0.0); // User entered value of currency.
         char selection;

         
int main ()
{

    printf (" This currency conversion will convert currency from the following");
    printf ("\n list of curency to U.S. dollars, the value of the conversion ");
    printf ("\n valid as of April 17, 2011. \n\n");
    
             while (selection != 'Q' && selection != 'q') 
{  
          
          // sets up the user selection menu.
          printf ("\n\t\t For the Euro (EUR) select E: \n");
          printf ("\t\t For the British Pound (GPB) select G: \n");
          printf ("\t\t For the Australian Dollar (AUD) select A: \n");
          printf ("\t\t For the Japanese Yen (JPY) select J: \n");
          printf ("\t\t For the Mexican Peso (MXN) select M: \n");
          printf ("\t\t To exit this program select Q: \n");
          printf ("\t\t Enter your selection: ");
          scanf ("%s", &selection);   

// for the Euro this loop will run to calculate the exchange rate.
if (selection == 'E' || selection == 'e')
{
   printf ("\n\t You have select the Euro, Please enter amount: ");
   scanf ("%f", &value);
   usd = ( value / eur);
   printf ("\t The amount in U.S. Dollars =  %.2f\n\n", usd);
}
          
// for the British this loop will run to calculate the exchange rate.
else if (selection == 'G' || selection == 'g')
{
     printf ("\n\t You have select the British pound, Please enter amount: ");
     scanf ("%f", &value);
     usd = ( value / gbp);
     printf ("\t The amount in U.S. Dollars =  %.2f\n\n", usd);
}
          
// for the Australian this loop will run to calculate the exchange rate.
else if (selection == 'A' || selection == 'a')
{
     printf ("\n\t You have select the Australian Dollar, Please enter amount: ");
     scanf ("%f", &value);
     usd = ( value / aud);
     printf ("\t The amount in U.S. Dollars =  %.2f\n\n", usd);
}
          
// for the Japanese Yen this loop will run to calculate the exchange rate.
else if (selection == 'J' || selection == 'j')
{
     printf ("\n\t You have select the Japanese Yen, Please enter amount: ");
     scanf ("%f", &value);
     usd = ( value / jpy);
     printf ("\t The amount in U.S. Dollars =  %.2f\n\n", usd);
}
          
// for the Mexican Peso this loop will run to calculate the exchange rate.
else if (selection == 'M' || selection == 'm')
{
     printf ("\n\t You have select the Mexican Peso, Please enter amount: ");
     scanf ("%f", &value);
     usd = ( value / mxn);
     printf ("\t The amount in U.S. Dollars =  %.2f\n\n", usd);
}
}
    system ("pause");
    exit (0);
}
