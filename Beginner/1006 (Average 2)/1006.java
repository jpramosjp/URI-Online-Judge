import java.io.IOException;
import java.util.Scanner;
import java.text.DecimalFormat;

public class Main {

    public static void main(String[] args) throws IOException {
        Scanner ler = new Scanner(System.in);
        DecimalFormat df = new DecimalFormat("0.0");
        double a = ler.nextDouble();
        double b = ler.nextDouble();
        double c = ler.nextDouble();
       
        
        double result = (a * 2 + b * 3 + c*5)/10;
        System.out.println("MEDIA = " + df.format(result));
        
        
    }
 
}