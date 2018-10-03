using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orenes.UnitTest.Repositories.Models
{
    public class Match
    {
        public Match()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; private set; }

        public DateTime UtcDate { get; private set; }

        public void SetDate(DateTime date)
        {
            Date = date;
            UtcDate = date.ToUniversalTime();
        }
    }
}
