using System;

namespace inheritance_demo
{
    public class privateA
    {
        private int value = 10;

        public class privateB : privateA
        {
            public int getValue() => this.value;
        }
    }

    public class privateC : privateA
    {
        //public int getValue() => this.value;
    }

    public class PrivateExample
    {
        public static void PrivateMain()
        {
            var b = new privateA.privateB();
            Console.WriteLine(b.getValue());
        }
    }
}