using System;
using Shared.Dtos;
using Shared.Enums;

namespace ExperimentsWithRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            DtoBase dto = new DtoBase(1, DateTimeOffset.Now, "Test", EventType.Concert, "Music hall");
            var (id, date) = dto;
        }
    }
}