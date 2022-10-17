using System.Text.RegularExpressions;
using Microsoft.Playwright.NUnit;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : PageTest
{
  [Test]
  public async Task O2()
  {
    // visit o2 homepage
    await Page.GotoAsync("https://www.o2.sk");
    await Expect(Page).ToHaveURLAsync(new Regex("https://www.o2.sk"));
    
    await Page.ScreenshotAsync(new()
    {
      Path = "./screenshots/1-o2-sk.png",
      FullPage = true,
    });

    // find and hover Nasa ponuka
    var handle = Page.Locator("text='Naša ponuka'");
    await handle.HoverAsync();
    await handle.IsVisibleAsync();
    
    await Page.ScreenshotAsync(new()
    {
      Path = "./screenshots/2-nasa-ponuka.png",
      FullPage = true,
    });

    //  click Telefony a zariadenia
    await Page.GetByText("Telefóny a zariadenia").ClickAsync();
    await Expect(Page).ToHaveURLAsync("https://www.o2.sk/ponuka/telefony-a-zariadenia");
    await Page.WaitForTimeoutAsync(1500); //for full page load

    await Page.ScreenshotAsync(new()
    {
      Path = "./screenshots/3-telefony-a-zariadenia.png",
      FullPage = true,
    });

    //choose Mobilne telefony
    var mobile = Page.Locator("text='Mobilné telefóny'");
    await mobile.ClickAsync();
    await Expect(Page).ToHaveURLAsync("https://www.o2.sk/e-shop/produkty/telefony");
    await Page.WaitForTimeoutAsync(3500); //for full page load

    await Page.ScreenshotAsync(new()
    {
      Path = "./screenshots/4-mobilne-telefony.png",
      FullPage = true,

    });

    // choose a device - Apple iPhone 14 256GB Fialovy 
    await Page.GetByText("Apple iPhone 14 256GB Fialový").ClickAsync();
    await Expect(Page).ToHaveURLAsync("https://www.o2.sk/e-shop/produkt/apple-iphone-14-256gb-fialovy");
    await Page.WaitForTimeoutAsync(1500); //for full page load

    await Page.ScreenshotAsync(new()
    {
      Path = "./screenshots/5-vyber-telefonu.png",
      FullPage = true,

    });

    // buy device Kúpiť za plnú sumu and go to next site
    var phone = Page.Locator("text='Kúpiť za plnú sumu'");
    await phone.ClickAsync();
    await Expect(Page).ToHaveURLAsync("https://www.o2.sk/e-shop/nakup/#/?contextHw=apple-iphone-14-256gb-fialovy&paymentMethod=cash");
    await Page.WaitForTimeoutAsync(1500); //for full page load
    
    await Page.ScreenshotAsync(new()
    {
      Timeout = 1500,
      Path = "./screenshots/6-pokracovanie.png",
      FullPage = true,

    });

    // continue as new user
    await Page.Locator("text='Pokračovať ako nový zákazník'").ClickAsync();
    await Expect(Page).ToHaveURLAsync("https://www.o2.sk/e-shop/kosik");

    await Page.ScreenshotAsync(new()
    {
      Path = "./screenshots/7-nakupny-kosik.png",
      FullPage = true,

    });

    // shopping cart
    await Page.Locator("#confirm-shopping-cart").ClickAsync();
    await Page.WaitForTimeoutAsync(1500); //for full page load
    await Page.Locator("#o4-shopping-cart-login-dialog-holder").IsVisibleAsync();

    await Page.ScreenshotAsync(new()
    {
      Path = "./screenshots/7.5-objednavka.png",
      FullPage = true,

    });

    //skip login
    await Page.Locator("text='Preskočiť prihlásenie'").ClickAsync();
    await Expect(Page).ToHaveURLAsync("https://www.o2.sk/e-shop/udaje");

    await Page.ScreenshotAsync(new()
    {
      Path = "./screenshots/8-objednavka.png",
      FullPage = true,

    });

    //test with POM - add items to form
    var inputForm = new InputForm(Page);
    await inputForm.CheckPerson();
    await inputForm.AddNameSureName(name:"Lubomir", surename:"Vaclavik");
    var name = Page.Locator("text='Lubomir'").IsVisibleAsync();
    var surename = Page.Locator("text='Vaclavik'").IsVisibleAsync();
    await inputForm.AddPhoneEmail(phone:"0948528362", email:"vaclaviklubomir@gmail.com");
    await inputForm.AddAdress(street:"Zuzany Chalupovej", building:"10", city: "Bratislava", zip:"85101");
    await inputForm.AddAgreement();

    await Page.ScreenshotAsync(new()
    {
      Path = "./screenshots/9-formular.png",
      FullPage = true,

    });
    await inputForm.Agree();
    await Expect(Page).ToHaveURLAsync("https://www.o2.sk/e-shop/udaje?page=SHIPPING_PAYMENT");

    await Page.ScreenshotAsync(new()
    {
      Path = "./screenshots/10-dorucenie-a-platba.png",
      FullPage = true,

    });

  }
}
