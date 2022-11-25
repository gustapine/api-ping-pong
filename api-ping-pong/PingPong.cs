namespace ping_pong_api;

public class PingPong
{
    public string msg { get; set; }

    public PingPong(string ehPingPong)
    {
        switch (ehPingPong.ToLower().Trim())
        {
            case "pong": msg = "Ping"; break;
            case "ping": msg = "Pong"; break;
            default: msg = "-1"; break;
        }
    }
}
