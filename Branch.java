import java.util.List;

public class Branch {
    private int branchNumber;
    private String address ;
    private List<Customer>customers;
    private List<Loan>loans;
    public Branch(int num, String add){
        branchNumber= num;
        address = add;

    }

    public String getAddress() {
        return address;
    }

    public int getBranchNumber() {
        return branchNumber;
    }

    public List<Customer> getCustomers() {
        return customers;
    }

    public List<Loan> getLoans() {
        return loans;
    }
    public void addCustomer (Customer c ){
        customers.add(c);
    }

    public void addLoan(Loan l ){
        loans. add ( l );
    }
}

