using System;

namespace _04_HTML_Dispatcher
{
    class TestElementBuilder
    {
        public static void Main()
        {
            ElementBuilder list = new ElementBuilder("li");
            Console.WriteLine(list * 3);
            Console.WriteLine();

            ElementBuilder div = new ElementBuilder("div");
            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");
            Console.WriteLine(div * 2);
            Console.WriteLine();

            string image = HTMLDispatcher.CreateImage("images/dog.png", "dog", "dog_img");
            Console.WriteLine(image);

            string url = HTMLDispatcher.CreateURL("https://github.com", "GitHub-OOP-Projects", "C# OOP");
            Console.WriteLine(url);

            string inputField = HTMLDispatcher.CreateInput("submit", "submitBtn", "Submit");
            Console.WriteLine(inputField);
        }
    }
}
