package bai2;

import javax.swing.JOptionPane;

public class NameValidator implements IValidator {

    @Override
    public boolean isValid(String input) {
        boolean valid = input != null && !input.isEmpty() && input.matches("^[a-zA-Z\\s]+$");
        if (!valid) {
            JOptionPane.showMessageDialog(null, "Invalid Name! Please enter that includes only letters and spaces.", "Warning", JOptionPane.WARNING_MESSAGE);
            return false;
        }
        return true;
    }
}
