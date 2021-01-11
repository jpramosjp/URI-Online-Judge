import java.io.IOException;
import java.util.Scanner;
import java.lang.Math;
import java.text.DecimalFormat;
public class Main {

    public static void main(String[] args) throws IOException {
        Scanner ler = new Scanner(System.in);
        DecimalFormat df = new DecimalFormat("0.00000");
        double a = ler.nextDouble();
        double b = ler.nextDouble();
        double c = ler.nextDouble();
        double delta = Math.pow(b, 2) -4 * (a*c);
        double result;
        if (a<=0 || delta < 0){
            System.out.println("Impossivel calcular");
        }
        else{
            result =((-b) + Math.sqrt(delta))/(2*a);
            System.out.println("R1 = " + df.format(result));
            result =((-b) - Math.sqrt(delta))/(2*a);
            System.out.println("R2 = " + df.format(result));
        }
    }
 
}