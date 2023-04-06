import java.util.*;

public class Main {
    public static void main(String[] args) {
        int height;
        int radius;
        Scanner in = new Scanner(System.in);
        System.out.print("Please type in the Height of your cylinder in cm2: ");
        height = in.nextInt();
        System.out.print("Please type in the radius of your cylinder in cm2: ");
        radius = in.nextInt();
        CylinderVolume(radius, height);

    }
    public static void CylinderVolume(int radius, int height){
        double pi = Math.PI;
        double A = radius * radius * pi;
        double volume = A * height;
        System.out.print("The Volume of your cylinder is: " + volume + "cm2");
    }
}