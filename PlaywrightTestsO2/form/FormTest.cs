using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlaywrightTests;

public class InputForm
{
  private IPage _page;
  //private ILocator _btnPersonCompany;
  private ILocator _txtName;
  private ILocator _txtSureName;
  // private ILocator _txtPhoneNumber;
  // private readonly ILocator _txtEmail;
  // private readonly ILocator _txtStreet;
  // private readonly ILocator _txtBuildingNumber;
  // private readonly ILocator _txtCity;
  // private readonly ILocator _txtZipCode;
  // private readonly ILocator _btnCountry;
  // private readonly ILocator _chckboxAgreeAll;
  // private readonly ILocator _chckboxAgreeFirst;
  // private readonly ILocator _chckboxAgreeSecond;
  // private readonly ILocator _chckboxAgreeThird;
  // private readonly ILocator _btnAccept;


  public InputForm(IPage page)
  {
    _page = page;
    //_btnPersonCompany = page.Locator("text=súkromná osoba");
    _txtName = page.Locator("#name");
    _txtSureName = page.Locator("#surename");

  }

  // public async Task ClickPerson(){
  //   await _btnPersonCompany.ClickAsync();
  //   // await _page.ScreenshotAsync(new()
  //   // {
  //   //   Path = "./screenshots/10-person.png",
  //   //   FullPage = true,

  //   // });

  // }

  public async Task AddDetails(string name, string surename) {
    await _txtName.FillAsync(name);
    await _txtSureName.FillAsync(surename);

    // await _page.ScreenshotAsync(new()
    // {
    //   Path = "./screenshots/11-person.png",
    //   FullPage = true,

    // });
  }

  


}