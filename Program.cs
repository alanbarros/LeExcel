using LeExcel;
using SpreadSheetParser.Models;
using SpreadSheetParser.Extensions;

var file = new FileInfo("Book.xlsx");

List<ContractSheet> contracts = new SheetFile<ContractSheet>(file)
    .Parse<ContractSheet>();

List<AssigneeSheet> assignees = new SheetFile<AssigneeSheet>(file)
    .Parse<AssigneeSheet>();

contracts.Join(assignees,
    c => c.AssigneeCode,
    c => c.CACode, (c, c2) => new { c, c2 })
    .ToList()
    .ForEach(x =>
        Console.WriteLine($"{x.c.ContractNumber} - {x.c2.Name}")
    );