import java.util.*;
public class Main {
    public static void main(String[] args) {
        List <String> StringsList = new ArrayList<String>();
        StringsList.add("Audi");
        StringsList.add("Mercedes-Benz");
        StringsList.add("BMW");
        StringsList.add("Volkswagen");
        System.out.print("List before reversing: \n" + StringsList);
        Collections.reverse(StringsList);
        System.out.print("\nList after reversing: \n" + StringsList);

    }
}