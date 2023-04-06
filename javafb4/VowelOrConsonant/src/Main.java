import java.awt.desktop.ScreenSleepEvent;
import java.sql.Time;
import java.util.*;
public class Main {
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);
        System.out.print("Gib ein Wort ein: ");
        String userWord = in.next();
        System.out.println("Warte bis das Programm dein Wort auf Vokale und Consonanten testet... ");



        char[] c = userWord.toCharArray();
        for(int i = 0; i < c.length; i++)
    {

        if(c[i] == 'a'){
            System.out.print("Buchstabe " + c[i] + ", an Stelle " + (i + 1) + " ist ein Vokal.\n");
        }
        else if(c[i] == 'e'){
            System.out.print("Buchstabe " + c[i] + ", an Stelle " + (i + 1) + " ist ein Vokal.\n");
        }
        else if(c[i] == 'i'){
            System.out.print("Buchstabe " + c[i] + ", an Stelle " + (i + 1) + " ist ein Vokal.\n");
        }
        else if(c[i] == 'o'){
            System.out.print("Buchstabe " + c[i] + ", an Stelle " + (i + 1) + " ist ein Vokal.\n");
        }
        else if(c[i] == 'u'){
            System.out.print("Buchstabe " + c[i] + ", an Stelle " + (i + 1) + " ist ein Vokal.\n");
        }
        else {
            System.out.print("Buchstabe " + c[i] + ", an Stelle " + (i + 1) + " ist kein Vokal.\n");
        }
    }


    }
}