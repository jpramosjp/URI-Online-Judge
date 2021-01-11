import java.io.IOException;
import java.util.Scanner;
import java.text.DecimalFormat;

public class Main {

    public static void main(String[] args) throws IOException {
        Scanner ler = new Scanner(System.in);
        DecimalFormat df = new DecimalFormat("0.00000");
        double a = 0.0;
        double b = 0.0;
        a = ler.nextDouble();
        b = ler.nextDouble();
        
        double result = (a * 3.5 + b * 7.5)/11;
        System.out.println("MEDIA = " + df.format(result));
        
        
    }
 
}