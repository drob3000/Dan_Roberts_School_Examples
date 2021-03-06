/*
 * Author: Dan Roberts, University of Phoenix Copyright 2012
 * Current Release Date: Monday March 12, 2012
 * Version: 1.1.0
 * Submitted for PRG421 Java Programming II | course at the University of Phoenix
 * 
 * Quality Control Reviewed by: Jason Burden, Terry Walsh
 * Quality Control review available on request
 * 
 * Development tools: Developed with NETBEANS 7.0.1 and JDK 1.6
 * Program originally packaged with [Mortgage Calculator] project folder
 * 
 * Scope: 
 * Service Request 3
 * Change Request 7
 * Write the program in Java (with a graphical user interface) and have it calculate 
 * and display the mortgage payment amount from user input of the amount of the 
 * mortgage and the user's selection from a menu of available mortgage loans: 
 *
 * - 7 years at 5.35%
 * - 15 years at 5.5%
 * - 30 years at 5.75%
 * 
 * Use an array for the mortgage data for the different loans. Read the interest 
 * rates to fill the array from a sequential file. Display the mortgage payment 
 * amount followed by the loan balance and interest paid for each payment over 
 * the term of the loan. Add graphics in the form of a chart. Allow the user to 
 * loop back and enter a new amount and make a new selection or quit. 

 * Validation:
 * Output values successfully compared to the following website.
 * http://www.bankrate.com/calculators/mortgages/loan-calculator.aspx
 * 
 * Note:
 * Loan Calculation Formula adapted from 
 * Dr. Bradley Purdy University of Phoenix
 * 
 */
package MortgageCalculatorCR7;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.util.Scanner;
import javax.swing.JFrame;
import javax.swing.JOptionPane;

public class NewJFrameCR7 extends javax.swing.JFrame {

    /** Creates new form NewJFrameCR7 */
    public NewJFrameCR7() {
        initComponents();
    }

    /** This method is called from within the constructor to
     * initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is
     * always regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        input_jPanel = new javax.swing.JPanel();
        loan_jLabel = new javax.swing.JLabel();
        term_jLabel = new javax.swing.JLabel();
        interest_jLabel = new javax.swing.JLabel();
        loan_jTextField = new javax.swing.JTextField();
        term_jTextField = new javax.swing.JTextField();
        interest_jTextField = new javax.swing.JTextField();
        menu_jLabel = new javax.swing.JLabel();
        menu_jComboBox = new javax.swing.JComboBox();
        Legend_jLabel = new javax.swing.JLabel();
        totPay_jLabel = new javax.swing.JLabel();
        totInt_jLabel = new javax.swing.JLabel();
        quit_jButton = new javax.swing.JButton();
        calculate_jButton = new javax.swing.JButton();
        clear_jButton = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        input_jPanel.setBorder(javax.swing.BorderFactory.createTitledBorder(null, "Input Data", javax.swing.border.TitledBorder.DEFAULT_JUSTIFICATION, javax.swing.border.TitledBorder.DEFAULT_POSITION, new java.awt.Font("Tahoma", 2, 11), new java.awt.Color(204, 0, 0))); // NOI18N

        loan_jLabel.setText("Enter the amount of the loan in Dollars:");

        term_jLabel.setText("Enter the lenght of the loan in Years:");

        interest_jLabel.setText("Enter the amount of the Interest is Percentage:");

        menu_jLabel.setText("Or Select the Interest and Term of the loan:");

        menu_jComboBox.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Make a Selection", "7 Years at 5.35% ", "15 Years at 5.5%", "30 Years at 5.75%" }));
        menu_jComboBox.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                menu_jComboBoxActionPerformed(evt);
            }
        });

        Legend_jLabel.setText("Chart Legend: ");

        totPay_jLabel.setFont(new java.awt.Font("Tahoma", 1, 11)); // NOI18N
        totPay_jLabel.setForeground(java.awt.Color.green);
        totPay_jLabel.setText("Total Payments is in Green");

        totInt_jLabel.setFont(new java.awt.Font("Tahoma", 1, 11)); // NOI18N
        totInt_jLabel.setForeground(java.awt.Color.blue);
        totInt_jLabel.setText("Total Interest is in Blue");

        javax.swing.GroupLayout input_jPanelLayout = new javax.swing.GroupLayout(input_jPanel);
        input_jPanel.setLayout(input_jPanelLayout);
        input_jPanelLayout.setHorizontalGroup(
            input_jPanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(input_jPanelLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(input_jPanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(input_jPanelLayout.createSequentialGroup()
                        .addGroup(input_jPanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                            .addComponent(loan_jLabel, javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(term_jLabel, javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(interest_jLabel, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(menu_jLabel, javax.swing.GroupLayout.Alignment.LEADING))
                        .addGap(23, 23, 23)
                        .addGroup(input_jPanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(loan_jTextField, javax.swing.GroupLayout.DEFAULT_SIZE, 120, Short.MAX_VALUE)
                            .addComponent(interest_jTextField, javax.swing.GroupLayout.DEFAULT_SIZE, 120, Short.MAX_VALUE)
                            .addComponent(term_jTextField, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 120, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(menu_jComboBox, javax.swing.GroupLayout.PREFERRED_SIZE, 165, javax.swing.GroupLayout.PREFERRED_SIZE)))
                    .addGroup(input_jPanelLayout.createSequentialGroup()
                        .addComponent(Legend_jLabel)
                        .addGap(18, 18, 18)
                        .addComponent(totPay_jLabel)
                        .addGap(18, 18, 18)
                        .addComponent(totInt_jLabel)))
                .addContainerGap(28, Short.MAX_VALUE))
        );

        input_jPanelLayout.linkSize(javax.swing.SwingConstants.HORIZONTAL, new java.awt.Component[] {interest_jTextField, loan_jTextField, menu_jComboBox, term_jTextField});

        input_jPanelLayout.setVerticalGroup(
            input_jPanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(input_jPanelLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(input_jPanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(loan_jLabel)
                    .addComponent(loan_jTextField, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(input_jPanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(term_jLabel)
                    .addComponent(term_jTextField, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(input_jPanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(interest_jLabel)
                    .addComponent(interest_jTextField, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(input_jPanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(menu_jLabel)
                    .addComponent(menu_jComboBox, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(input_jPanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(Legend_jLabel)
                    .addComponent(totPay_jLabel)
                    .addComponent(totInt_jLabel))
                .addContainerGap(17, Short.MAX_VALUE))
        );

        input_jPanelLayout.linkSize(javax.swing.SwingConstants.VERTICAL, new java.awt.Component[] {interest_jTextField, loan_jTextField, menu_jComboBox, term_jTextField});

        quit_jButton.setText("Quit");
        quit_jButton.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                quit_jButtonMouseClicked(evt);
            }
        });

        calculate_jButton.setText("Calculate");
        calculate_jButton.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                calculate_jButtonMouseClicked(evt);
            }
        });

        clear_jButton.setText("Clear");
        clear_jButton.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                clear_jButtonMouseClicked(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(input_jPanel, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(calculate_jButton)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 275, Short.MAX_VALUE)
                        .addComponent(clear_jButton)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(quit_jButton)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(input_jPanel, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(quit_jButton)
                    .addComponent(calculate_jButton)
                    .addComponent(clear_jButton))
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void quit_jButtonMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_quit_jButtonMouseClicked
        //Create the quit button to exit the program.
        System.exit(0);
    }//GEN-LAST:event_quit_jButtonMouseClicked

    private void clear_jButtonMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_clear_jButtonMouseClicked
        // Clears data for the new calculation.
        loan_jTextField.setText("");
        interest_jTextField.setText("");
        term_jTextField.setText("");
    }//GEN-LAST:event_clear_jButtonMouseClicked

    private void calculate_jButtonMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_calculate_jButtonMouseClicked
        // Call Calculate method, create table and output the data
        getLoanValues();
        displayAmortization();
    }//GEN-LAST:event_calculate_jButtonMouseClicked

    private void menu_jComboBoxActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_menu_jComboBoxActionPerformed
        // Combo box selection
        loan = menu_jComboBox.getSelectedIndex();
        years = term[loan];
        interest = per[loan];

    }//GEN-LAST:event_menu_jComboBoxActionPerformed

    public void getLoanValues() {


        try { // collect the principal data and exception for invalid data
            principal = Double.parseDouble(loan_jTextField.getText());
        } catch (NumberFormatException e) { // displays error if other than double is entered
            JOptionPane.showMessageDialog(message, "Please enter a whole number in Principal");
            loan_jTextField.setText("");
        }

        if (loan == 0) {
            try { // collect the interest data and exception for invalid data
                interest = Double.parseDouble(interest_jTextField.getText());
            } catch (NumberFormatException e) { // displays error if other than double is entered
                JOptionPane.showMessageDialog(message, "Please enter a whole number in Interest or make a selection");
                interest_jTextField.setText("");
            }
            try { // collect the term data and exception for invalid data
                years = Integer.parseInt(term_jTextField.getText());
            } catch (NumberFormatException e) { // displays error if other than double is entered
                JOptionPane.showMessageDialog(message, "Please enter a Integer number in Term or make a selection");
                term_jTextField.setText("");
            }
        }
    }

    public void displayAmortization() {

        (new Thread(new table(principal, interest, years))).start();
    }

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(NewJFrameCR7.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(NewJFrameCR7.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(NewJFrameCR7.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(NewJFrameCR7.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {

            public void run() {
                new NewJFrameCR7().setVisible(true);
            }
        });
    }
    JFrame message;
    double principal;
    double interest;
    int years;
    int[] term = {0, 7, 15, 30};
    double[] per = {0, 5.35, 5.5, 5.75};
    int loan;
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel Legend_jLabel;
    private javax.swing.JButton calculate_jButton;
    private javax.swing.JButton clear_jButton;
    private javax.swing.JPanel input_jPanel;
    private javax.swing.JLabel interest_jLabel;
    private javax.swing.JTextField interest_jTextField;
    private javax.swing.JLabel loan_jLabel;
    private javax.swing.JTextField loan_jTextField;
    private javax.swing.JComboBox menu_jComboBox;
    private javax.swing.JLabel menu_jLabel;
    private javax.swing.JButton quit_jButton;
    private javax.swing.JLabel term_jLabel;
    private javax.swing.JTextField term_jTextField;
    private javax.swing.JLabel totInt_jLabel;
    private javax.swing.JLabel totPay_jLabel;
    // End of variables declaration//GEN-END:variables
}
