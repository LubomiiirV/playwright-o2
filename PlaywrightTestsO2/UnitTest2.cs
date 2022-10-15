using System.Text.RegularExpressions;
using Microsoft.Playwright.NUnit;

namespace PlaywrightTests;

// [Parallelizable(ParallelScope.Self)]
// [TestFixture]
public class Test2 : PageTest
{
  [Test]
  public async Task O2()
  {
    await Page.GotoAsync("https://www.o2.sk");
    await Expect(Page).ToHaveURLAsync(new Regex("https://www.o2.sk"));
    
    await Page.ScreenshotAsync(new()
    {
      Path = "./screenshots/bonus-1-o2-sk.png",
      FullPage = true,
    });

    // find and hover Nasa ponuka
    var handle = Page.Locator("text='Naša ponuka'");
    await handle.HoverAsync();

    await handle.IsVisibleAsync();
    
    await Page.ScreenshotAsync(new()
    {
      Path = "./screenshots/bonus-2-nasa-ponuka.png",
      FullPage = true,
    });

    //  click Pre domaácnosť
    await Page.GetByText("Pre domácnosť").ClickAsync();

    await Expect(Page).ToHaveURLAsync("https://www.o2.sk/ponuka/pre-domacnost");
    
    await Page.WaitForTimeoutAsync(1500);

    await Page.ScreenshotAsync(new()
    {
      Path = "./screenshots/bonus-3-pre-domacnost.png",
      FullPage = true,
    });

    //choose Prejsť na O2 Internat na doma
    var homeInternet = Page.Locator("text='Prejsť na O2 Internet na doma'");
    await homeInternet.ClickAsync();
    await Expect(Page).ToHaveURLAsync("https://www.o2.sk/ponuka/pre-domacnost/internet-na-doma");
    
    await Page.WaitForTimeoutAsync(1500);

    await Page.ScreenshotAsync(new()
    {
      Path = "./screenshots/bonus-4-internet-na-doma.png",
      FullPage = true,

    });

    // choose Overte dostupnosť na vašej adrese
    await Page.GetByText("Overte dostupnosť na vašej adrese").ClickAsync();
    await Page.Locator(".z-ind-column z-ind-intro").IsVisibleAsync();
    
    await Page.WaitForTimeoutAsync(1500);

    await Page.ScreenshotAsync(new()
    {
      Path = "./screenshots/bonus-5-overte-popup.png",
      FullPage = true,

    });

    //  overit dostupnost internetu na doma pre lubovolnu adresu
    //await Page.GetByText("Zadajte obec alebo mesto").FillAsync("Bratislava");
    //await Page.Locator("#z-ind-form.z-ind-input-street").FillAsync("Zuzany Chalupovej");
    //await Page.Locator("#z-ind-form.z-ind-input-street-number").FillAsync("10b");

    await Page.ScreenshotAsync(new()
    {
      Timeout = 1500,
      Path = "./screenshots/bonus-6-zadanie adresy.png",
      FullPage = true,

    });

    //await Page.Locator(".btn btn-blue btn-block btn-shadow").ClickAsync();

    await Page.ScreenshotAsync(new()
    {
      Timeout = 1500,
      Path = "./screenshots/bonus-7-potvrdenie.png",
      FullPage = true,

    });
  }
}
