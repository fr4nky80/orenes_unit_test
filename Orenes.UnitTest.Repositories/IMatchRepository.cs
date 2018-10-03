using System;
using Orenes.UnitTest.Repositories.Models;

namespace Orenes.UnitTest.Repositories
{
    public interface IMatchRepository
    {
        Match GetMatchById(Guid id);
    }
}