using System.ComponentModel;
using SpreadSheetParser.Models;

namespace LeExcel
{
    [DisplayName("Contratos Cedidos")]
    public class ContratoSheet : SheetObject
    {
        [DisplayName("Operacao")]
        public Double Operacao { get; set; }

        [DisplayName("Numero Documento")]
        public String NumeroDocumento { get; set; }

        [DisplayName("Numero Contrato")]
        public String NumeroContrato { get; set; }

        [DisplayName("Codigo Cessionario")]
        public String CodigoCessionario { get; set; }

        [DisplayName("Valor")]
        public Double Valor { get; set; }

        public ContratoSheet(SheetHeader header, SheetRow row) : base(header, row)
        {
            if (TryBuildObject<ContratoSheet>(this) is false)
                throw new ArgumentException("Could not create a sample object");
        }

    }
}