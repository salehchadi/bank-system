import java.util.List;

public class Customer {
    private String ssn;
    private String name;
    private String phone;
    private String address;
    private List<Account> accounts;
    private List<Loan> loans;

    public Customer(String s, String n, String ph, String add) {
        ssn = s;
        name = n;
        phone = ph;
        address = add;

    }

    public List<Loan> getLoans() {
        return loans;
    }

    public String getAddress() {
        return address;
    }

    public String getName() {
        return name;
    }

    public List<Account> getAccounts() {
        return accounts;
    }

    public String getPhone() {
        return phone;
    }

    public String getSsn() {
        return ssn;
    }
    public void addLoan(Loan l ){
        loans. add ( l );
    }
    public void addAccount(Account a ){
        accounts. add ( a );
    }
}
