package bai2;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import javax.swing.JOptionPane;

public class BirthdayValidator implements IValidator {

    private static final int MAX_YEAR = 50;
    private static final String DATE_FORMAT = "dd-MM-yyyy";

    @Override
    public boolean isValid(String input) {
        SimpleDateFormat dateFormat = new SimpleDateFormat(DATE_FORMAT);
        dateFormat.setLenient(false);

        try {
            Calendar currentDate = Calendar.getInstance();

            Calendar birthday = Calendar.getInstance();
            birthday.setTime(dateFormat.parse(input));

            if (birthday.before(currentDate) && birthday.after(get100YearsAgo())) {
                return true;
            } else {
                JOptionPane.showMessageDialog(null, "Invalid Birthday! Please enter a valid date within the last " + MAX_YEAR + " years.", "Warning", JOptionPane.WARNING_MESSAGE);
                return false;
            }
        } catch (ParseException e) {
            JOptionPane.showMessageDialog(null, "Invalid Birthday! Please enter as dd-mm-yyyy format.", "Warning", JOptionPane.WARNING_MESSAGE);
            return false;
        }
    }

    private Calendar get100YearsAgo() {
        Calendar calendar = Calendar.getInstance();
        calendar.add(Calendar.YEAR, -1 * MAX_YEAR);
        return calendar;
    }
}
