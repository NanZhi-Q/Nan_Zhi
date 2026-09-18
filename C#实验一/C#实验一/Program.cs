using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1. 设计一个对整型摤组排摫的摪法void SortArray(int[] myArray, bool flag)flag 为true表示摦小到大排摫，否则是摦大到小排摫。不允许在函摤内部直接输出排摫结果。直接上传函摤代码，上传源代码要凗格式整齐，便于阅读。（第1空，3分）
//2.编写一个类用来处理个摥银行账户: 只考虑账号和余额两个变量，存款、摨款和转账摪法。给出类的代码，不需要测试代码 ，上传源代码要凗格式整齐，便于阅读。（第2空，3分）分析这样设计类的原因。（第3空，3分）
//3. 实验总结，要凗具体一点，比如出现问题的分析解决，代码的理解。（第4空，3分）
namespace C_实验一
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 55, 66, 33, 7, 8, 42, 10, 100, 50 };
            SortArray(arr,false);
            Console.WriteLine("arr.length = " +arr.Length);
            for(int i = 0;i<arr.Length;i++)
            {
                Console.WriteLine("arr[" + i + "[" + " = " + arr[i]);
            }
        }
        static void SortArray(int[] myArray, bool flag)
        {
            if (flag) Array.Sort(myArray);
            else
            {
                Array.Sort(myArray);
                Array.Reverse(myArray);
            }
        }
        class Account
        {
            public string AccountName;//账户名字
            public decimal Balance;//余额

            //存款方法
            public void Deposit(decimal money)
            {
                if (money > 0)
                    Balance += money;
            }

            //取款方法
            public void Withdraw(decimal money)
            {
                if (money > 0 && money <= Balance)
                    Balance -= money;
            }

            //转账方法
            public void Transfer(Account target, decimal money)
            {
                if (target != null && money > 0 && money <= Balance)
                {
                    Balance -= money;
                    target.Balance += money;
                }
            }
        }
    }
}
