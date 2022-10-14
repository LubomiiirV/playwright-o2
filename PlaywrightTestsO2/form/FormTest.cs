using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlaywrightTests;

public class InputForm
{
  private IPage _page;
  public InputForm(IPage page) => _page = page;
  //private ILocator _btnPersonCompany => _page.Locator(");
  private ILocator _name => _page.Locator("#name");
  private ILocator _sureName => _page.Locator("#surname");

  private ILocator _phoneNumber => _page.Locator("#residentPhoneNumber");
  private ILocator _email => _page.Locator("");
  private ILocator _streetName => _page.Locator("");
  private ILocator _buildingNumber => _page.Locator("");
  private ILocator _cityName => _page.Locator("");
  private ILocator _zipCode => _page.Locator("");
  private ILocator _countryName => _page.Locator("");
  private ILocator _chckboxAgreeAll => _page.Locator("");
  private ILocator _chckboxAgreeFirst => _page.Locator("");
  private ILocator _chckboxAgreeSecond => _page.Locator("");
  private ILocator _chckboxAgreeThird => _page.Locator("");
  private ILocator _btnAccept => _page.Locator("");
  



  // public async Task ClickPerson(){
  //   await _btnPersonCompany.ClickAsync();
  //   // await _page.ScreenshotAsync(new()
  //   // {
  //   //   Path = "./screenshots/10-person.png",
  //   //   FullPage = true,

  //   // });

  // }

  public async Task AddDetails(string name, string surename, string phonenumber) {
    await _name.FillAsync(name);
    await _sureName.FillAsync(surename);
    await _phoneNumber.FillAsync(phonenumber);

    
  }

  


}