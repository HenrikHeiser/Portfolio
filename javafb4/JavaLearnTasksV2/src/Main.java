import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        System.out.println("This is a converter from Seconds to hours, minutes and seconds. ");
        System.out.print("Type in your seconds: ");
        int seconds = in.nextInt();
        Converter(seconds);

    }
    public static void Converter(int a) {
        int hours = a / 3600;
        int minutes = (a % 3600) / 60;
        int seconds = (a % 3600) % 60;
System.out.print("Deine angegeben Sekunden betragen " + hours + " Stunden, " + minutes + " Minuten & "
                + seconds + " Sekunden.");
    }
}