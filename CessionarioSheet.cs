using System.ComponentModel;
using SpreadSheetParser.Models;

namespace LeExcel
{
    [DisplayName("Cessionarios")]
    public class CessionarioSheet : SheetObject
    {
        [DisplayName("Codigo CA")]
        public String CodigoCA { get; set; }

        [DisplayName("Nome")]
        public String Nome { get; set; }

        [DisplayName("CNPJ")]
        public String CNPJ { get; set; }

        public CessionarioSheet(SheetHeader header, SheetRow row) : base(header, row)
        {
            if (TryBuildObject<CessionarioSheet>(this) is false)
                throw new ArgumentException("Could not create a sample object");
        }

    }
}