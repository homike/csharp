using System;

namespace Attr
{
class AttrSample
{
    public void Run()
    {
        Type widgetType = typeof(Widget);

        //Gets every Help defined for the Widget type
        object[] widgetClassAttributes = widgetType.GetCustomAttributes(typeof(Help), false);
        if (widgetClassAttributes.Length > 0)
        {
            Help attr = (Help)widgetClassAttributes[0];
            Console.WriteLine($"Widget class help URL : {attr.Url} - Related topic : {attr.Topic}");
        }

        System.Reflection.MethodInfo displayMethod = widgetType.GetMethod(nameof(Widget.Display));

        //Gets every Help defined for the Widget.Display method
        object[] displayMethodAttributes = displayMethod.GetCustomAttributes(typeof(Help), false);

        if (displayMethodAttributes.Length > 0)
        {
            Help attr = (Help)displayMethodAttributes[0];
            Console.WriteLine($"Display method help URL : {attr.Url} - Related topic : {attr.Topic}");
        }

        Console.ReadLine();
    }
}

[Help("https://docs.microsoft.com/")]
public class Widget
{
    [Help("https://docs.microsoft.com/", Topic = "Display")]
    public void Display(string text) {}
}

public class  Help: Attribute
{
    string url;
    string topic;

    public Help(string url)
    {
        this.url = url;
    }


    public string Url => url;

    public string Topic
    {
        get
        {
            return topic;
        }
        set
        {
            topic = value;
        }
    }
}
}
