import java.io.IOException;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) throws IOException {
        Scanner ler = new Scanner(System.in);
        int x = ler.nextInt();

        if(x>0 && x <=12){

            if(x == 1){
                System.out.println("January");
            }
            else if (x == 2){
                System.out.println("February");
            }
            else if (x ==3){
                System.out.println("March");
            }
            else if (x ==4){
                System.out.println("April");
            }
            else if (x ==5){
                System.out.println("May");
            }
            else if (x ==6){
                System.out.println("June");
            }
            else if (x ==7){
                System.out.println("July");
            }
            else if (x ==8){
                System.out.println("August");
            }
            else if (x ==9){
                System.out.println("September");
            }
            else if (x ==10){
                System.out.println("October");
            }
            else if (x ==11){
                System.out.println("November");
            }
            else if (x ==12){
                System.out.println("December");
            }
        }
        
       

    }
 
}