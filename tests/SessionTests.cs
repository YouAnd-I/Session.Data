using Device.Data;
using Identity.Data;
using Xunit;

namespace Session.Data.Tests;

public class SessionTests
{
    [Fact]
    public void Session_CarriesDeviceUserAndToken()
    {
        var device = DeviceId.Create();
        var user = UserId.Create();
        var token = Guid.NewGuid();

        var session = new Session(device, user, token);

        Assert.Equal(device, session.Device);
        Assert.Equal(user, session.User);
        Assert.Equal(token, session.Token);
    }
}
