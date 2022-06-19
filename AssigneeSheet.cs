using System.ComponentModel;
using SpreadSheetParser.Models;

namespace LeExcel
{
    [DisplayName("Cessionarios")]
    public class AssigneeSheet : SheetObject
    {
        [DisplayName("Codigo CA")]
        public String CACode { get; set; }

        [DisplayName("Nome")]
        public String Name { get; set; }

        [DisplayName("CNPJ")]
        public String CNPJ { get; set; }

        public AssigneeSheet(SheetHeader header, SheetRow row) : base(header, row)
        {
            if (TryBuildObject<AssigneeSheet>(this) is false)
                throw new ArgumentException("Could not create a sample object");
        }

    }
}