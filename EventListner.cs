Using System;
namespace EventSample{
    public delegate void buttonClick();
    public class button(){
        public event buttonClick Onclick;
        public void Click(){
            Console.writeline("clicked");
            if(OnClick ! = null);
            OnClick.invoke();

        }publc class Subscriber{
            public void HandleClick(){
                Console.writeline("Handled");
            }
        }
    }
    Class Program{
    static void Main(String[]args){
        Button button = new Button();
        Subscriber subs = new Subscriber();
        button.OnClick +=subs.HandleClick;

        button.Click();
    }
}

}