using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Client.Services
{
    public class MockOrderService : IOrderService
    {
        public void PlaceOrder(List<string> dishes)
        {
            //WriteAllLines会删除已有文件的内容，然后在写入文件
            File.WriteAllLines(@"D:\order.txt", dishes.ToArray());
        }
    }
}
