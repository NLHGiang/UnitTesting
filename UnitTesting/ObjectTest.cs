using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class ObjectTest
    {
        [TestMethod]
        public void Test_Datas_Count_ReturnNotNull()
        {
            ObjectService service = new ObjectService();
            var datas = service.InputDatas();

            bool isNull = datas == null;

            Assert.IsFalse(isNull);
        }

        [TestMethod]
        public void Test_Datas_Count_ReturnNull()
        {
            ObjectService service = new ObjectService();
            var datas = service.Datas;

            Assert.IsNull(datas);
        }
    }
}
