using Device.Data;
using User.Data;

namespace Session.Data;

public readonly record struct Session(
    DeviceId Device,
    UserId User,
    Guid Token
);
