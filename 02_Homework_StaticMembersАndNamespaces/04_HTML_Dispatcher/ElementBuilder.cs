using System;

namespace _04_HTML_Dispatcher
{
    class ElementBuilder
    {
        private string elementName;
        private string attribute;
        private string content;

        public string ElementName
        {
            get
            {
                return this.elementName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Element value cannot be empty.");
                }
                this.elementName = value;
            }
        }

        //The class constructor should take the element's name as argument.
        public ElementBuilder(string elementName)
        {
            this.ElementName = elementName;
        }

        //Write a method AddAttribute(attribute, value) that adds an attribute and value to the element. 
        public void AddAttribute(string attribute, string attributeValue){
            this.attribute += " " + attribute + "=" + "\"" + attributeValue + "\"";
        }

        //Write a method AddContent(string) that inserts content inside the current tag (e.g. <div>Text</div>).
        public void AddContent(string content){
            this.content += content;
        }

        //Overload the * operator for ElementBuilder objects. 
        //The operator should multiply the string value of the element n times and return the result as string.
        //(e.g. <li></li> * 3 = <li></li><li></li><li></li>)
        public static string operator *(ElementBuilder elemStr, int n){
            string multipliedElemStr = "";
            for (int i = 0; i < n; i++)
            {
                multipliedElemStr += elemStr;
            }
                return multipliedElemStr;
        }

        public override string ToString()
        {
            return String.Format("<{0}{1}>{2}</{0}>", this.elementName, this.attribute, this.content);
        }
        
    }
}
