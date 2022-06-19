using LeExcel;
using SpreadSheetParser.Models;

var file = new FileInfo("Book.xlsx");

List<ContractSheet> contracts = SheetReader.ReadStream<ContractSheet>(file.OpenRead());
List<AssigneeSheet> assignees = SheetReader.ReadStream<AssigneeSheet>(file.OpenRead());

contracts.Join(assignees,
    c => c.AssigneeCode,
    c => c.CACode, (c, c2) => new { c, c2 })
    .ToList()
    .ForEach(x =>
        Console.WriteLine($"{x.c.ContractNumber} - {x.c2.Name}")
    );