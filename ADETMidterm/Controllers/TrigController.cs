/**
 * Name: Denise Julianne Gozum
 * Section: BSCS 3-1N
**/

using Microsoft.AspNetCore.Mvc;

namespace ADETMidterm.Controllers
{
    [ApiController]
    [Route("Trigonometry")]
    public class TrigoController : ControllerBase
    {
        [HttpPost]
        public ActionResult<TrigoResult> Post([FromBody] TrigoInput input)
        {
            var sin = Math.Sin(input.Angle);
            var cos = Math.Cos(input.Angle);
            var tan = Math.Tan(input.Angle);

            sin = Math.Round(sin, 3, MidpointRounding.AwayFromZero);
            cos = Math.Round(cos, 3, MidpointRounding.AwayFromZero);
            tan = Math.Round(tan, 3, MidpointRounding.AwayFromZero);

            var result = new TrigoResult { Sin = sin, Cos = cos, Tan = tan };
            return result;
        }
    }
}