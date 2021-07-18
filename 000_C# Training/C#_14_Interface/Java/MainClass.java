import java.util.Scanner;
import java.util.HashMap;

public class MainClass
{
    public static void main(String[] args)
    {
        HashMap<String, Vendor> vendors = new HashMap<String, Vendor>();

        vendors.put("Klockmann", new Klockmann());
        vendors.put("Bundespolizei", new Bundespolizei());
        
        for (String vendor : vendors.keySet())
            vendors.get(vendor).ReadPdf();

        new Scanner(System.in).nextLine();
    }
}

interface Vendor
{
    void ReadPdf();
    //void NextFunction();
}

class Klockmann implements Vendor
{
    public void ReadPdf()
    {
        System.out.println("Clock gun");
        HelperFunction();
    }

    public void HelperFunction()
    {
    }
}

class Bundespolizei implements Vendor
{
    public void ReadPdf()
    {
        System.out.println("Haende hoch");
    }
}