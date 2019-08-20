using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossTabDemo1 {
    public class DataItems {
        public static List<DataItem> GetData() {
            List<DataItem> dataList = new List<DataItem>();
            dataList.Add(new DataItem(1, "Michael Adams", "Accruals", "Sick leave next month", 540));
            dataList.Add(new DataItem(1, "Michael Adams", "Accruals", "Sick leave for pregnancy", 1230));
            dataList.Add(new DataItem(1, "Michael Adams", "Accruals", "Sick leave previous mohth", 850));
            dataList.Add(new DataItem(1, "Michael Adams", "Accruals", "Sick leave current mohth", 0));
            dataList.Add(new DataItem(1, "Michael Adams", "Accruals", "Deposit repayment", 0));

            dataList.Add(new DataItem(1001, "Alfreds Futterkiste", "Accruals", "Sick leave next month", 0));
            dataList.Add(new DataItem(1001, "Alfreds Futterkiste", "Accruals", "Sick leave for pregnancy", 0));
            dataList.Add(new DataItem(1001, "Alfreds Futterkiste", "Accruals", "Sick leave previous mohth", 5450));
            dataList.Add(new DataItem(1001, "Alfreds Futterkiste", "Accruals", "Sick leave current mohth", 0));
            dataList.Add(new DataItem(1001, "Alfreds Futterkiste", "Accruals", "Deposit repayment", 0));

            dataList.Add(new DataItem(1002, "Maria Anders", "Accruals", "Sick leave next month", 100));
            dataList.Add(new DataItem(1002, "Maria Anders", "Accruals", "Sick leave for pregnancy", 0));
            dataList.Add(new DataItem(1002, "Maria Anders", "Accruals", "Sick leave previous mohth", 0));
            dataList.Add(new DataItem(1002, "Maria Anders", "Accruals", "Sick leave current mohth", 100));
            dataList.Add(new DataItem(1002, "Maria Anders", "Accruals", "Deposit repayment", 0));

            dataList.Add(new DataItem(1003, "John Smith", "Accruals", "Sick leave next month", 0));
            dataList.Add(new DataItem(1003, "John Smith", "Accruals", "Sick leave for pregnancy", 0));
            dataList.Add(new DataItem(1003, "John Smith", "Accruals", "Sick leave previous mohth", 0));
            dataList.Add(new DataItem(1003, "John Smith", "Accruals", "Sick leave current mohth", 0));
            dataList.Add(new DataItem(1003, "John Smith", "Accruals", "Deposit repayment", 0));

            dataList.Add(new DataItem(1, "Michael Adams", "Withholding", "Sick leave next month", -40));
            dataList.Add(new DataItem(1, "Michael Adams", "Withholding", "Sick leave for pregnancy", -230));
            dataList.Add(new DataItem(1, "Michael Adams", "Withholding", "Sick leave previous mohth", -800));
            dataList.Add(new DataItem(1, "Michael Adams", "Withholding", "Sick leave current mohth", 0));

            dataList.Add(new DataItem(1001, "Alfreds Futterkiste", "Withholding", "Sick leave next month", 0));
            dataList.Add(new DataItem(1001, "Alfreds Futterkiste", "Withholding", "Sick leave for pregnancy", 0));
            dataList.Add(new DataItem(1001, "Alfreds Futterkiste", "Withholding", "Sick leave previous mohth", -450));
            dataList.Add(new DataItem(1001, "Alfreds Futterkiste", "Withholding", "Sick leave current mohth", 0));

            dataList.Add(new DataItem(1002, "Maria Anders", "Withholding", "Sick leave next month", -50));
            dataList.Add(new DataItem(1002, "Maria Anders", "Withholding", "Sick leave for pregnancy", 0));
            dataList.Add(new DataItem(1002, "Maria Anders", "Withholding", "Sick leave previous mohth", 0));
            dataList.Add(new DataItem(1002, "Maria Anders", "Withholding", "Sick leave current mohth", 0));

            dataList.Add(new DataItem(1003, "John Smith", "Withholding", "Sick leave next month", 0));
            dataList.Add(new DataItem(1003, "John Smith", "Withholding", "Sick leave for pregnancy", 0));
            dataList.Add(new DataItem(1003, "John Smith", "Withholding", "Sick leave previous mohth", 0));
            dataList.Add(new DataItem(1003, "John Smith", "Withholding", "Sick leave current mohth", 0));

            return dataList;
        }
    }
    public class DataItem {
        public DataItem(int id, string fullName, string type, string subTypeName, int value) {
            TypeName = type;
            SubTypeName = subTypeName;
            Id = id;
            FullName = fullName;
            Value = value;
        }
        public string TypeName { get; set; }
        public string SubTypeName { get; set; }
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Value { get; set; }
        public string FakeData1 { get; set; } = null;
        public string FakeData2 { get; set; } = null;
    }
}
