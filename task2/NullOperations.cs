using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class NullOperations
    {

        public void PerformNullChecks()
        {
            // Declare a string variable and assign null
            string username = null;

            // 1️⃣ Check using Ternary Operator (? :)
            string message = (username == null) ? "Username is not available" : username;
            Console.WriteLine(message);

            // 2️⃣ Check using Null-Coalescing Operator (??)
            Console.WriteLine(username ?? "Username is not available");

            // 3️⃣ Use Null-Coalescing Assignment Operator (??=)
            username ??= "DefaultUser";
            Console.WriteLine($"Updated username: {username}");
        }

    }
}
