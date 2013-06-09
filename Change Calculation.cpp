/* -----------------------------------------------------------------------------
** Name	                :  Dan Roberts
** Date Created	        :  04/11/2011
** Description	        :  Change calculation
** Modification History	:
** Name	                Date	        Description
** -----------------------------------------------------------------------------
** Dan Roberts     	04/11/2011	      Initial Version
** -----------------------------------------------------------------------------
*/

#include <stdio.h>
#include <stdlib.h>
#include <math.h>

    float amountDue =(0.0);
    float amountRecieved =(0.0);
    float change =(0.0);
    float changetw =(0.0);
    int twenty =(0);
    int ten =(0);
    int five =(0);
    int dollars =(0);
    int quarters =(0);
    int dimes =(0);
    int nickels =(0);
    int pennies =(0);
    
    int main (void) 
{
    //set input from the user and caculate change due
    
    printf ("This program caculates change due from a sell \n");
    printf ("Casher has no bills large than a twenty \n\n\n");
    printf ("Please enter the amount of purchase: ");
    scanf ("%f", &amountDue);
    printf ("\n\t   Please enter amount paid: ");
    scanf ("%f", &amountRecieved);
    change = (amountRecieved - amountDue);
    printf ("\n\t\t\t Change Due: %.2f\n",change);
   

    // Convert change to intger to set up mod function
    
    int balance = int (round(change*100));
    twenty = balance/2000;
    int twentyBal = balance % 2000;
    ten = twentyBal/1000;
    int tenBal = twentyBal % 1000;
    five = tenBal/500;
    int fiveBal = tenBal % 500;
    dollars = fiveBal/100;
    int dollarBal = fiveBal % 100;
    quarters = dollarBal/25;
    int quarterBal = dollarBal % 25;
    dimes = quarterBal/10;
    int dimeBal = quarterBal % 10;
    nickels = dimeBal/5;
    int nickelBal = dimeBal % 5;
    pennies = nickelBal/1;
    
    // Output of values by denomination
    
    printf ("\n\n\t\t Change by denomination is:  \n\n");
    printf ("\t\t\t  Twenty = %d\n",twenty);
    printf ("\t\t\t     Ten = %d\n",ten);
    printf ("\t\t\t    Five = %d\n",five);
    printf ("\t\t\t  Dollar = %d\n",dollars);
    printf ("\t\t\tQuarters = %d\n",quarters);
    printf ("\t\t\t   Dimes = %d\n",dimes); 
    printf ("\t\t\t Nickels = %d\n",nickels);
    printf ("\t\t\t Pennies = %d\n",pennies);
    
    system ("pause");
    exit (0);
}
