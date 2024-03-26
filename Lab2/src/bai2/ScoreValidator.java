package bai2;

import javax.swing.JOptionPane;

public class ScoreValidator implements IValidator {

    private static final double MIN_SCORE = 0;
    private static final double MAX_SCORE = 10;

    @Override
    public boolean isValid(String input) {
        try {
            double score = Double.parseDouble(input);
            if (score >= MIN_SCORE && score <= MAX_SCORE) {
                return true;
            } else {
                JOptionPane.showMessageDialog(null, "Invalid Score! Please enter a number between" + MIN_SCORE + "and" + MAX_SCORE + ".", "Warning", JOptionPane.WARNING_MESSAGE);
                return false;
            }
        } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog(null, "Invalid Score! Please enter as a real number.", "Warning", JOptionPane.WARNING_MESSAGE);
            return false;
        }
    }
}
