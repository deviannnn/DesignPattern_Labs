package bai2;

import javax.swing.JTextField;

public class ValidatorTextField extends JTextField {

    private IValidator validator;

    public ValidatorTextField() {
        super();
    }

    public ValidatorTextField(IValidator validator) {
        super();
        this.validator = validator;
    }

    public void setValidator(IValidator validator) {
        this.validator = validator;
    }

    public boolean check() {
        return validator.isValid(getText());
    }
}
