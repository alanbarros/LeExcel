using System.ComponentModel;
using SpreadSheetParser.Models;

namespace LeExcel
{
    [DisplayName("Contratos Cedidos")]
    public class ContractSheet : SheetObject
    {
        [DisplayName("Operacao")]
        public Double Operacao { get; set; }

        [DisplayName("Numero Documento")]
        public String NumeroDocumento { get; set; }

        [DisplayName("Numero Contrato")]
        public String ContractNumber { get; set; }

        [DisplayName("Codigo Cessionario")]
        public String AssigneeCode { get; set; }

        [DisplayName("Valor")]
        public Double Valor { get; set; }

        public ContractSheet(SheetHeader header, SheetRow row) : base(header, row)
        {
            if (TryBuildObject<ContractSheet>(this) is false)
                throw new ArgumentException("Could not create a sample object");
        }

    }
}