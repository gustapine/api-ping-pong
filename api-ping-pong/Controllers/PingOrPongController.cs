using Microsoft.AspNetCore.Mvc;

namespace ping_pong_api.Controllers;

[ApiController]
[Route("[controller]")]
public class PingPongController : ControllerBase
{
    private readonly ILogger<PingPongController> _logger;

    public PingPongController(ILogger<PingPongController> logger)
    {
        _logger = logger;
    }

    [HttpGet("{ehPingPong}")]
    public PingPong Get(string ehPingPong)
    {
        var pingPong = new PingPong(ehPingPong);

        return pingPong;
    }
}
