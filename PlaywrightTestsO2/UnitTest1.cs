using System.Text.RegularExpressions;
using Microsoft.Playwright.NUnit;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : PageTest
{

  // [SetUp]
  // public async Task Setup()
  // {
  //   await Page.GotoAsync("https://www.o2.sk");
  // }

  // [Test]
  // public async Task ChodNaO2Sk()
  
  // {
  //   // Expect page to have URL.
  //   await Page.GotoAsync("https://www.o2.sk");
  //   await Expect(Page).ToHaveURLAsync(new Regex("https://www.o2.sk"));
    
  //   // await Page.ScreenshotAsync(new()
  //   // {
  //   //   Path = "./screenshots/1-o2-sk.png",
  //   //   FullPage = true,
  //   // });

  // }

  [Test]
  public async Task O2()
  {
    await Page.GotoAsync("https://www.o2.sk");
    await Expect(Page).ToHaveURLAsync(new Regex("https://www.o2.sk"));
    
    // await Page.ScreenshotAsync(new()
    // {
    //   Path = "./screenshots/1-o2-sk.png",
    //   FullPage = true,
    // });


    // find and hover Nasa ponuka
    var handle = Page.Locator("text='Naša ponuka'");
    await handle.HoverAsync();
    
    // await Page.ScreenshotAsync(new()
    // {
    //   Path = "./screenshots/2-nasa-ponuka.png",
    //   FullPage = true,
    // });

    //  click Telefony a zariadenia
    await Page.GetByText("Telefóny a zariadenia").ClickAsync();
    await Page.WaitForTimeoutAsync(500);

    await Page.ScreenshotAsync(new()
    {
      Path = "./screenshots/3-telefony-a-zariadenia.png",
      FullPage = true,
    });

    //choose Mobilne telefony
    await Page.GetByText("Mobilné telefóny").ClickAsync();
    // var mobile = Page.Locator("text='Mobilné telefóny'");
    // await mobile.ClickAsync();
    await Expect(Page).ToHaveURLAsync("https://www.o2.sk/e-shop/produkty/telefony");
    await Page.WaitForTimeoutAsync(1500);

    // await Page.ScreenshotAsync(new()
    // {
    //   Path = "./screenshots/4-mobilne-telefony.png",
    //   FullPage = true,

    // });

    // choose a device - Apple iPhone 14 256GB Fialovy 
    await Page.GetByText("Apple iPhone 14 256GB Fialový").ClickAsync();
    await Expect(Page).ToHaveURLAsync("https://www.o2.sk/e-shop/produkt/apple-iphone-14-256gb-fialovy");
    await Page.WaitForTimeoutAsync(500);

    // await Page.ScreenshotAsync(new()
    // {
    //   Path = "./screenshots/5-vyber-telefonu.png",
    //   FullPage = true,

    // });

    // buy device Kúpiť za plnú sumu and go to next site
    var phone = Page.Locator("text='Kúpiť za plnú sumu'");
    await phone.ClickAsync();
    await Expect(Page).ToHaveURLAsync("https://www.o2.sk/e-shop/nakup/#/?contextHw=apple-iphone-14-256gb-fialovy&paymentMethod=cash");
    await Page.WaitForTimeoutAsync(1500);
    
    // await Page.ScreenshotAsync(new()
    // {
    //   Path = "./screenshots/6-pokracovanie.png",
    //   FullPage = true,

    // });

    // continue as new user
    await Page.Locator("text='Pokračovať ako nový zákazník'").ClickAsync();
    await Expect(Page).ToHaveURLAsync("https://www.o2.sk/e-shop/kosik");

    // await Page.ScreenshotAsync(new()
    // {
    //   Path = "./screenshots/7-nakupny-kosik.png",
    //   FullPage = true,

    // });

    // shopping cart
    await Page.Locator("#confirm-shopping-cart").ClickAsync();
    await Page.WaitForTimeoutAsync(500);

    //skip login
    await Page.Locator("text='Preskočiť prihlásenie'").ClickAsync();
    await Expect(Page).ToHaveURLAsync("https://www.o2.sk/e-shop/udaje");

    // await Page.ScreenshotAsync(new()
    // {
    //   Path = "./screenshots/8-objednavka.png",
    //   FullPage = true,

    // });

    //test with POM
    InputForm inputForm = new InputForm(Page);
    //await inputForm.ClickPerson();

    // await Page.ScreenshotAsync(new()
    // {
    //   Path = "./screenshots/9.png",
    //   FullPage = true,

    // });

    await inputForm.AddDetails(name:"Lubomir", surename:"Vaclavik");









  
    // await Page.ScreenshotAsync(new()
    // {
    //   Path = "./screenshots/9-person.png",
    //   FullPage = true,

    // });

    //await Page.Locator("súkromná osoba").ClickAsync();
    //   await page.locator('a:has-text("súkromná osoba")').click();
    //   await page
    //     .locator('input[name="customerInfo\\.primaryContact\\.firstName"]')
    //     .click();
    //   await page
    //     .locator('input[name="customerInfo\\.primaryContact\\.firstName"]')
    //     .fill("Ľubomír");
    //   await page
    //     .locator('input[name="customerInfo\\.primaryContact\\.lastName"]')
    //     .click();
    //   await page
    //     .locator('input[name="customerInfo\\.primaryContact\\.lastName"]')
    //     .fill("Václavik");
    //   await page
    //     .locator('input[name="customerInfo\\.primaryContact\\.lastName"]')
    //     .press("Tab");
    //   await page
    //     .locator('input[name="customerInfo\\.primaryContact\\.contactPhone"]')
    //     .click();
    //   await page
    //     .locator('input[name="customerInfo\\.primaryContact\\.contactPhone"]')
    //     .fill("0948528362");
    //   await page
    //     .locator('input[name="customerInfo\\.primaryContact\\.email"]')
    //     .click();
    //   await page
    //     .locator('input[name="customerInfo\\.primaryContact\\.email"]')
    //     .fill("vaclaviklubomir@gmail.com");
    //   await page
    //     .locator('input[name="customerInfo\\.primaryContact\\.address\\.street"]')
    //     .click();
    //   await page
    //     .locator('input[name="customerInfo\\.primaryContact\\.address\\.street"]')
    //     .fill("Zuzany");
    //   await page
    //     .getByRole("option", {
    //       name: "Zuzany Chalupovej, Bratislava-Petržalka, 851 07",
    //     })
    //     .click();
    //   await page
    //     .locator(
    //       'input[name="customerInfo\\.primaryContact\\.address\\.houseNumber"]'
    //     )
    //     .click();
    //   await page
    //     .locator(
    //       'input[name="customerInfo\\.primaryContact\\.address\\.houseNumber"]'
    //     )
    //     .fill("10B");
    //   await page
    //     .locator('input[name="customerInfo\\.primaryContact\\.address\\.city"]')
    //     .click();
    //   await page
    //     .locator(
    //       'input[name="customerInfo\\.primaryContact\\.address\\.houseNumber"]'
    //     )
    //     .click();
    //   await page
    //     .getByLabel("Súhlasím so všetkými nižšie uvedenými možnosťami.")
    //     .check();

  }
}
