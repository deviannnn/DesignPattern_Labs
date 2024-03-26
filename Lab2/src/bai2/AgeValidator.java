package bai2;

import javax.swing.JOptionPane;

public class AgeValidator implements IValidator {

    private static final int MIN_AGE = 1;
    private static final int MAX_AGE = 50;

    @Override
    public boolean isValid(String input) {
        try {
            int age = Integer.parseInt(input);
            if (age >= MIN_AGE && age <= MAX_AGE) {
                return true;
            } else {
                JOptionPane.showMessageDialog(null, "Invalid Age! Please enter an integer between" + MIN_AGE + " and " + MAX_AGE + ".", "Warning", JOptionPane.WARNING_MESSAGE);
                return false;
            }
        } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog(null, "Invalid Age! Please enter as an integer.", "Warning", JOptionPane.WARNING_MESSAGE);
            return false;
        }
    }
}
