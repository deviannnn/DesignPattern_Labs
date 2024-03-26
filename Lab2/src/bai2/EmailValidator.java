package bai2;

import java.util.regex.Pattern;
import javax.swing.JOptionPane;

public class EmailValidator implements IValidator {

    @Override
    public boolean isValid(String input) {
        String emailRegex = "^[a-zA-Z0-9_+&*-]+(?:\\.[a-zA-Z0-9_+&*-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,7}$";

        boolean valid = Pattern.matches(emailRegex, input);
        if (!valid) {
            JOptionPane.showMessageDialog(null, "Invalid Email! Please enter a valid one.", "Warning", JOptionPane.WARNING_MESSAGE);
            return false;
        }
        return true;
    }
}
