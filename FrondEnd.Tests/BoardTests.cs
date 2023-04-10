using AngleSharp.Dom;
using Bunit;
using FrontEnd.Pages;
using Microsoft.AspNetCore.Components;

namespace FrondEnd.Tests;

public class FrontEndTests
{
    private TestContext _testContext;
    private IRenderedComponent<Board> _renderedComponent;
    
    [Fact]
    public void PageHasCanvasElement()
    {
        _testContext = new TestContext();
        _testContext.JSInterop.Mode = JSRuntimeMode.Loose;
        
        _renderedComponent = _testContext.RenderComponent<Board>();
        var canvasBoard = _renderedComponent.Find("canvas");
        Assert.NotNull(canvasBoard);
    }
}