using Moq;
using Orenes.UnitTest.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Orenes.UnitTest.Example
{
    public class MatchUnitTest
    {

        [Fact]
        public void date_setter_utc_date_not_equals()
        {


            //Arrange
            Repositories.Models.Match match = new Repositories.Models.Match();

            //Act
            match.SetDate(DateTime.Now);

            //Assert
            Assert.NotEqual(match.Date, match.UtcDate);
            Assert.Equal(match.Date.ToUniversalTime(), match.UtcDate);

        }

        [Fact]
        public void moq_repository_equals_get_match_and_object_match()
        {

            //Arrange
            Repositories.Models.Match match = new Repositories.Models.Match();

            var moqRepository = new Mock<IMatchRepository>();
            moqRepository.Setup(p => p.GetMatchById(match.Id)).Returns(match);

            //Act
            var match2 = moqRepository.Object.GetMatchById(match.Id);

            //Assert
            Assert.NotNull(match2);
            Assert.Equal(match.Id, match.Id);


        }
    }
}
