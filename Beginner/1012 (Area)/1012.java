import java.io.IOException;
import java.util.Scanner;
import java.text.DecimalFormat;

public class Main {

    public static void main(String[] args) throws IOException {
        Scanner ler = new Scanner(System.in);
        DecimalFormat df = new DecimalFormat("0.000");

        double a = ler.nextDouble();
        double b = ler.nextDouble();
        double c = ler.nextDouble();

        System.out.println("TRIANGULO: " + df.format((a * c)/2));
        System.out.println("CIRCULO: " + df.format(3.14159 * c * c));
        System.out.println("TRAPEZIO: " + df.format(((a+b)*c)/2));
        System.out.println("QUADRADO: " + df.format(b*b));
        System.out.println("RETANGULO: " + df.format(a*b));
        
    }
 
}