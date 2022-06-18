using LeExcel;
using SpreadSheetParser.Models;
using SpreadSheetParser.Extensions;

var sheet1 = new SheetFile<ContratoSheet>(new FileInfo("Book.xlsx"));
var sheet2 = new SheetFile<CessionarioSheet>(new FileInfo("Book.xlsx"));

List<ContratoSheet> contratos = sheet1.BuildSheet<ContratoSheet>();
List<CessionarioSheet> cessionarios = sheet2.BuildSheet<CessionarioSheet>();


contratos.Join(cessionarios,
    c => c.CodigoCessionario,
    c => c.CodigoCA, (c, c2) => new { c, c2 })
    .ToList()
    .ForEach(x =>
        Console.WriteLine($"{x.c.NumeroContrato} - {x.c2.Nome}")
    );