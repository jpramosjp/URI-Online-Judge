import java.io.IOException;
import java.util.Scanner;
import java.text.DecimalFormat;

public class Main {

    public static void main(String[] args) throws IOException {
        Scanner ler = new Scanner(System.in);
        DecimalFormat df = new DecimalFormat("0.000");

        double r = ler.nextDouble();
        
        
        double result = (4.0/3)*3.14159*(r*r*r);
        System.out.println("VOLUME = " + df.format(result));
        
    }
 
}