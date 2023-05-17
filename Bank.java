import javax.swing.text.AbstractDocument;
import java.util.List;

public class Bank{
    private String name;
    private String code;
    private String address;
    private List<Branch> branches;
    public Bank ( String n, String c , String a){
        name = n ;
        code = c ;
        address = a ;
    }

    public String getName() {
        return name;
    }

    public String getCode() {
        return code;
    }

    public String getAddress() {
        return address;
    }

    public List<Branch> getBranches() {
        return branches;
    }
    public void addBranches (Branch b){
        branches.add(b);
    }
}
