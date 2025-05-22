namespace PlaywrightTests;

using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.Xunit;

public class UnitTest2: PageTest
{
    [Fact]
    public async Task HasTitle()
    {
        await Page.GotoAsync("https://demo.playwright.dev/todomvc");
        await Expect(Page.GetByRole(AriaRole.Heading)).ToContainTextAsync("todos");
        // await Expect(Page).ToHaveTitleAsync(new Regex("todos"));
        
    }

    [Fact]
    public async Task AddNewTask1Todo()
    {
        await Page.GotoAsync("https://demo.playwright.dev/todomvc");
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "What needs to be done?" }).ClickAsync();
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "What needs to be done?" }).FillAsync("Add new task on todos web.");
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "What needs to be done?" }).PressAsync("Enter");
    } 

    [Fact]
    public async Task AddNewTask2Todo()
    {
        await Page.GotoAsync("https://demo.playwright.dev/todomvc");
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "What needs to be done?" }).ClickAsync();
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "What needs to be done?" }).FillAsync("Add Second task on todos web.");
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "What needs to be done?" }).PressAsync("Enter");
    }

}