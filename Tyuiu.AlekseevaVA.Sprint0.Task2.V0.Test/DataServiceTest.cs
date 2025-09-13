using Tyuiu.AlekseevaVA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.AlekseevaVA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ChekGetMessageValid()
        {
            var name = "Вика";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Вика", res);
        }
    }
}
