using BaseLibrary.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerLibrary.Repositories.Contracts;

namespace ServerWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController(IGenericRepositoryInterface<Country> genericRepositoryInterface) : GenericController<Country>(genericRepositoryInterface)
    {
    }
}
