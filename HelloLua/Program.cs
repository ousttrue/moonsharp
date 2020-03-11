using System;
using MoonSharp.Interpreter;

namespace HelloLua
{
    class Program
    {
        static void Main(string[] args)
        {
            string scriptCode = @"    
		-- defines a factorial function
		function fact (n)
			if (n == 0) then
				return 1
			else
				return n*fact(n - 1)
			end
		end

		return fact(5)";

            var script = new Script();
            var res = script.DoString(scriptCode);

            Console.WriteLine(res);
        }
    }
}
