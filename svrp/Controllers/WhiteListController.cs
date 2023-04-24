using core.Entities;
using infrastructure.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace svrp.Controllers
{
    public class WhiteListController : BaseApiController
    {
        private readonly SvrpContext _Context;

        public WhiteListController(SvrpContext svrpContext)
        {
            this._Context = svrpContext;
        }

        [HttpGet]
        public ActionResult<IReadOnlyList<WhiteListForms>> GetWhitelists()
        {
            var WihteLists = _Context.WhiteListForms.ToList();

            if (WihteLists == null) return BadRequest();

            return Ok(WihteLists);

        }

        [HttpPost]
        public async Task<ActionResult<WhiteListForms>> CreateWhiteList(WhiteListForms whiteListForms)
        {
            if(whiteListForms == null) return BadRequest();

            _Context.Add(whiteListForms);

            return Ok();
        }
        
    }
}
