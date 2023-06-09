using Pomogotchi.API.Controllers;
using Pomogotchi.Application.Timer;
using Pomogotchi.Domain;
using Pomogotchi.Persistence;

namespace Pomogotchi.API.Extensions.SessionExtension
{
    public class BreakSession : SessionType
    {
        const string SESSION_CONFIG_KEY = "break_session";

        public BreakSession(Session parameters, Action<Session>? paramsUpdate) : base(parameters, paramsUpdate){}
        public BreakSession(Session parameters) : base(parameters){}

        public override SessionType GetNextSession()
        {
            return new WorkSession(Parameters, _userOnParamsChanged);
        }

        public override void LoadConfig(IConfigExtension configLoader)
        {
            Parameters = configLoader.GetParamAs<Session>(SESSION_CONFIG_KEY);
        }
    }
}