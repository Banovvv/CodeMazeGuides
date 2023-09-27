using Microsoft.AspNetCore.Mvc;
using UsingKeyedServicesToResolveDependencies.Services;

namespace UsingKeyedServicesToResolveDependencies.Controllers;

[ApiController]
[Route("[controller]")]
public class OnlineEventController : ControllerBase
{
    private readonly OnlineEventOrchestrator _eventOrchestrator;

    public OnlineEventController(OnlineEventOrchestrator eventOrchestrator)
    {
        _eventOrchestrator = eventOrchestrator;
    }

    [HttpGet("EndEvent")]
    public string EndEvent() => _eventOrchestrator.EndEvent();

    [HttpGet("StartEvent")]
    public string StartEvent() => _eventOrchestrator.StartEvent();
}