Option Strict

Imports System
Imports System.Collections.Generic

module MainModule
    public sub Main()
        dim vendors as new Dictionary(of string, Vendor)
        dim vendor as string

        vendors.Add("Klockmann", new Klockmann)
        vendors.Add("Bundespolizei", new Bundespolizei)
        
        for each vendor in vendors.Keys
            vendors(vendor).ReadPdf
        next vendor

        Console.ReadLine()
    end sub
end module

public interface Vendor
    sub ReadPdf()
    'sub NextFunction()
end interface

public class Klockmann
    implements Vendor

    sub ReadPdf() implements Vendor.ReadPdf
        Console.WriteLine("Clock gun")
        HelperFunction()
    end sub

    sub HelperFunction()
    end sub
end class

public class Bundespolizei
    implements Vendor

    sub ReadPdf() implements Vendor.ReadPdf
        Console.WriteLine("Haende hoch")
    end sub
end class
