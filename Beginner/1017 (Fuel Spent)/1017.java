import java.io.IOException;
import java.util.Scanner;
import java.text.DecimalFormat;

public class Main {

    public static void main(String[] args) throws IOException {
        Scanner ler = new Scanner(System.in);
        DecimalFormat df = new DecimalFormat("0.000");

        double x = ler.nextDouble();
        double y = ler.nextDouble();
        
        System.out.println(df.format((x*y)/12));
        
    }
 
}