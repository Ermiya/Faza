
namespace ERP.PMS.Business.Attribute
{
    
    public class ExcelColumnAttribute : System.Attribute
    {
        private string[] _columnNames = {};

        public ExcelColumnAttribute(params string[] columnNames)
        {
            _columnNames = columnNames;
        }
    }
}