using Microsoft.Playwright;

namespace PlaywrightTests;

public class InputForm
{
  private IPage _page;
  public InputForm(IPage page) => _page = page;
  private ILocator _person => _page.Locator("class:has-text('súkromná osoba')");
  private ILocator _name => _page.Locator("#name");
  private ILocator _sureName => _page.Locator("#surname");
  private ILocator _phoneNumber => _page.Locator("#residentPhoneNumber");
  private ILocator _email => _page.Locator("#residentEmail");
  private ILocator _streetName => _page.Locator("#street");
  private ILocator _buildingNumber => _page.Locator("#houseNumber");
  private ILocator _cityName => _page.Locator("#city");
  private ILocator _zipCode => _page.Locator("#zip");
  private ILocator _countryName => _page.Locator("#countrySelect");
  private ILocator _chckboxAgreeAll => _page.Locator("#bulk_agreement");
  private ILocator _btnAccept => _page.Locator("text='Potvrdiť'");

  public async Task CheckPerson() {
      await _person.IsVisibleAsync();
    }

  public async Task AddNameSureName(string name, string surename) {
    await _name.FillAsync(name);
    await _sureName.FillAsync(surename);
  }

  public async Task AddPhoneEmail(string phone, string email) {
    await _phoneNumber.FillAsync(phone);
    await _email.FillAsync(email);
  }

  public async Task AddAdress(string street, string building, string city, string zip) {
    await _streetName.FillAsync(street);
    await _buildingNumber.FillAsync(building);
    await _cityName.FillAsync(city);
    await _zipCode.FillAsync(zip);
  }

  public async Task AddAgreement() {
    await _chckboxAgreeAll.ClickAsync();
  }

  public async Task Agree() {
    await _btnAccept.ClickAsync();
  }

}