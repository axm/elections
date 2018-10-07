using Microsoft.AspNetCore.Mvc;
using Spartan.Elections.Web.Api.v1.Common;
using Spartan.Elections.Web.Persons.Requests;
using System;
using System.Threading.Tasks;

namespace Spartan.Elections.Web.Persons.Controllers
{
    [ApiVersion(Versions.V1)]
    [Route(Routes.Persons)]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        [HttpPost]
        public async Task<CreatePersonResponse> Create(CreatePersonRequest request)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public async Task<EditPersonResponse> Edit(EditPersonRequest request)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<ArchivePersonResponse> Archive(ArchivePersonRequest request)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<SearchPersonsResponse> Search(SearchPersonsRequest request)
        {
            throw new NotImplementedException();
        }
    }
}