	import java.io.IOException;
import java.util.Scanner;
import java.text.DecimalFormat;
import java.lang.Math;

public class Main {

    public static void main(String[] args) throws IOException {
        DecimalFormat df = new DecimalFormat("0.0000");
        Scanner ler = new Scanner(System.in);

        double x1 = ler.nextDouble();
        double y1 = ler.nextDouble();
        double x2 = ler.nextDouble();
        double y2 = ler.nextDouble();

        System.out.println(df.format((Math.sqrt(Math.pow(x1-x2,2) + Math.pow(y1 -y2, 2)))));
        
    }
 
}