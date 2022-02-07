using System;

namespace generics
{
    class Program
    {

        public class sample<T>
        {
            private T data;
            public T value
            {
                get
                {
                    return this.data;
                }
                set
                {
                    this.data = value;
                }

            }

        }
        static void Main(string[] args)
        {

            sample<string> name = new sample<string>();
            name.value = "akshitha pinishetty";

            sample<float> version = new sample<float>();
            version.value = 2.0f;
            Console.WriteLine(name.value);
            Console.WriteLine(version.value);
        }
    }
}
