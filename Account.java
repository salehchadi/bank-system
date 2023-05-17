public class Account {
    private String accountNumber;
    private double balance ;
    private String type ;
     public Account(String an , double b, String t){
         accountNumber= an;
         balance= b;
         type = t;
     }

    public double getBalance() {
        return balance;
    }

    public String getAccountNumber() {
        return accountNumber;
    }

    public String getType() {
        return type;
    }
}
