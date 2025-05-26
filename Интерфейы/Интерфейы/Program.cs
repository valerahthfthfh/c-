using System;

namespace classWork
{
    public interface IWeapon
    {
        void Output();
        void Input(string view);
    }

    public interface IDescendantOne : IWeapon
    {
        
    }

    public interface IDescendantTwo : IWeapon
    {
        
    }

    public class TextOutput : IDescendantOne
    {
        public void Output()
        {
            Console.Write("Hello! - ");
        }

        
        public void Input(string view)
        {
            throw new NotImplementedException(); /* this is a special construct in C#, which means 
                                                  * that the method formally exists (as required by an interface or 
                                                  * abstract class), but its implementation has not yet been written.
                                                  */
        }
    }

    public class TextInput : IDescendantTwo
    {
        public void Input(string view)
        {
            Console.WriteLine(view);
        }

        public void Output()
        {
            throw new NotImplementedException();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IDescendantOne output = new TextOutput();
            output.Output();

            IDescendantTwo input = new TextInput();
            input.Input("is it right or wrong?");

        }
    }
}