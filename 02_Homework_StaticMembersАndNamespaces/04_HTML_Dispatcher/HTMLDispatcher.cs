using System;

namespace _04_HTML_Dispatcher
{
    class HTMLDispatcher
    {
        //Write a static class HTMLDispatcher that holds 3 static methods,
        //which takes a set of arguments and return the HTML element as string:

        //first method -> CreateImage() takes image source, alt and title.
        public static string CreateImage(string imageSource, string alt, string title)
        {
            ElementBuilder img = new ElementBuilder("img");
            img.AddAttribute("src", imageSource);
            img.AddAttribute("alt", alt);
            img.AddAttribute("title", title);
            
            return img.ToString();
        }

        //second method -> CreateURL() tekes url, title and text.
        public static string CreateURL(string url, string title, string text){
            ElementBuilder urlObj = new ElementBuilder("a");
            urlObj.AddAttribute("href", url);
            urlObj.AddAttribute("title", title);
            urlObj.AddContent(text);

            return urlObj.ToString();
        }

        //third method -> CreateInput() takes input type, name and value.
        public static string CreateInput(string inputType, string inputName, string inputValue)
        {
            ElementBuilder input = new ElementBuilder("input");
            input.AddAttribute("type", inputType);
            input.AddAttribute("name", inputName);
            input.AddAttribute("value", inputValue);

            return input.ToString();
        }
    }
}
