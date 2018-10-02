using System.Threading.Tasks;
using Elections.Candidates.Data;
using Spartan.Candidates.Types.Commands;
using Spartan.UnitTesting;
using AutoFixture;
using System;
using System.Data;
using Moq;

namespace Spartan.Candidates.Data.Tests
{
    class CandidatesRepositoryTests
    {
        public class CandidatesRepository_CreateCandidate : BaseSpartanAsyncTest<CandidatesRepository>
        {
            private CreateCandidateRequest _request;

            protected override void NonContextualBefore()
            {
                _request = AutoFixture.Create<CreateCandidateRequest>();

                GetMock<IDbContainer>()
                    .Setup(_ => _.GetReadWriteConnection())
                    .ReturnsAsync(GetMock<IDbTransaction>().Object);
                GetMock<IDbTransaction>()
                    .Setup(_ => _.Connection)
                    .Returns(GetMock<IDbConnection>().Object);
            }

            protected override async Task NonContextualActAsync() => await Sut.CreateCandidate(_request);

            public void when_request_is_null()
            {
                before = () => _request = null;

                it[$"Throws {nameof(ArgumentNullException)}"] = expect<ArgumentNullException>();
            }

            public void when_called()
            {

            }
        }
    }
}
