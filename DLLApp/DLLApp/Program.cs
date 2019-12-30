using System.Runtime.InteropServices;

namespace DLLApp
{
    class Program
    {
        [DllImport("DLLfile.dll")]
        static extern int main(); //DLL内で定義された関数

        static void Main(string[] args)
        {
            main(); //C言語のmain関数を実行する 
        }
    }
}
