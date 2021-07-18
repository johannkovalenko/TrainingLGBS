//C:\Windows\Microsoft.NET\assembly\GAC_MSIL\

using System;
using System.Windows.Automation;
using System.Runtime.InteropServices;

public class MainClass
{
    [DllImport("user32.dll")] public static extern IntPtr FindWindow(string cl, string nm); 

    public static void Main()
    {
        IntPtr hwndParent = FindWindow("CalcFrame", "Calculator");

        if (hwndParent != IntPtr.Zero)
        {
            AutomationElement elem = AutomationElement.FromHandle(hwndParent);

            PropertyCondition conditionClass = new PropertyCondition(AutomationElement.ClassNameProperty, "Button");
            PropertyCondition conditionName = new PropertyCondition(AutomationElement.NameProperty, "8");

            AndCondition fullCondition = new AndCondition(conditionClass, conditionName);

            AutomationElement subElem = elem.FindFirst(TreeScope.Subtree, fullCondition);

            InvokePattern invoke = subElem.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;

            invoke.Invoke();
        }

        Console.ReadLine();
    }
}

