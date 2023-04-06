import java.util.Arrays;
import java.util.Scanner;
import java.util.regex.Pattern;

public class Main {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        System.out.print("Type in your sentence: ");
        String userValue = in.nextLine();
        String[] words = userValue.split(" ");
        //System.out.println(Arrays.toString(words));

        for(int i = 0; i < words.length; i++ ){
            //using String split function
            System.out.print(words[i] + "\n");
        }
        System.out.print("There are " + words.length + " words in the sentence.");
    }
}