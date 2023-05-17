public class Loan {
    private String loanNumber ;
    private String loanType;
    private double loanAmount;
    private Customer customer;
    private Employee employee;
    public Loan(String ln , String lt , double la){
        loanAmount = la;
        loanNumber= ln;
        loanType= lt;

    }

    public Customer getCustomer() {
        return customer;
    }

    public double getLoanAmount() {
        return loanAmount;
    }

    public Employee getEmployee() {
        return employee;
    }

    public String getLoanNumber() {
        return loanNumber;
    }

    public String getLoanType() {
        return loanType;
    }

    public void setCustomer(Customer customer) {
        this.customer = customer;
    }

    public void setEmployee(Employee employee) {
        this.employee = employee;
    }
}
