using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using tco_net.TwoCheckout;

public partial class _Default : System.Web.UI.Page
{
    String cc_number = "4111111111111111";
    String exp_month = "12";
    String exp_year = "2019";
    String cvv = "123";
    String total = "25.00";
    String first_name = "Test";
    String last_name = "Testing";
    String fullname = "";
    String address = "123 Main St";
    String email = "test@email.com";
    String phone = "555-555-5555";
    String city = "Columbus";
    String state = "OH";
    String zip = "43230";
    String country = "USA";
    String currency = "USD";

    protected void Page_Load(object sender, EventArgs e)
    {
        hideForms();
        showCustomerForm();
    }

    private void populateCustomerForm()
    {
        txt_first_name.Text = first_name;
        txt_last_name.Text = last_name;
        txt_email.Text = email;
        txt_phone.Text = phone;
        txt_address.Text = address;
        txt_city.Text = city;
        txt_state.Text = state;
        txt_zip.Text = zip;
        txt_country.Text = country;
        txt_currency.Text = currency;
    }

    private void showCustomerForm()
    {
        hideForms();
        customer_form.Visible = true;
        populateCustomerForm();
    }

    protected void btn_customer_submit_Click(object sender, EventArgs e)
    {
        showPayMethodForm();
    }

    protected void hideForms()
    {
        customer_form.Visible = false;
        pay_method_form.Visible = false;
        json_text.Visible = false;
    }

    private void showPayMethodForm()
    {
        hideForms();
        pay_method_form.Visible = true;
        populatePayMethodForm();
    }

    private void populatePayMethodForm()
    {
        txt_cc_number.Text = cc_number;
        txt_cvv.Text = cvv;
        txt_exp_month.Text = exp_month;
        txt_exp_year.Text = exp_year;
        txt_total.Text = "$" + total;   
    }

    protected void btn_complete_sale_submit_Click(object sender, EventArgs e)
    {
        Dictionary<String, Object> payload = buildPayload();
        TwoCheckout.TwoCheckout.sellerId = "208364";
        TwoCheckout.TwoCheckout.privateKey = "2222";
        TwoCheckout.TwoCheckout.sandbox = false;

        //Debug Purposes
        hideForms();
        json_text.Visible = true;
        json_payload.Text = "";
        json_response.Text = "";
        json_payload.Text = ConvertToJson(payload);

        Sale sale = Sale.create(payload);
        json_response.Text = ConvertToJson(sale);
    }

    private Dictionary<string, object> buildPayload()
    {
        Dictionary<String, Object> customer_data = new Dictionary<String, Object>();
        Dictionary<String, Object> address_data = new Dictionary<String, Object>();
        Dictionary<String, Object> payment_method_data = new Dictionary<String, Object>();
        Dictionary<String, Object> credit_card_data = new Dictionary<String, Object>();
        Dictionary<String, Object> sale_data = new Dictionary<String, Object>();

        fullname = first_name + " " + last_name;
        address_data.Add("name", fullname);
        address_data.Add("address_1", address);
        address_data.Add("city", city);
        address_data.Add("state", state);
        address_data.Add("country_code", country);
        address_data.Add("postal_code", zip);

        credit_card_data.Add("number", cc_number);
        credit_card_data.Add("cvv", cvv);
        credit_card_data.Add("exp_month", int.Parse(exp_month));
        credit_card_data.Add("exp_year", int.Parse(exp_year));

        payment_method_data.Add("address", address_data);
        payment_method_data.Add("credit_card", credit_card_data);

        customer_data.Add("email", email);
        customer_data.Add("phone", phone);
        customer_data.Add("currency", currency);
        customer_data.Add("payment_method", payment_method_data);

        sale_data.Add("amount", Convert.ToDecimal(total));

        String merch_id = txt_merchID.Text;
        sale_data.Add("merchant_order_id", merch_id);
        sale_data.Add("customer", customer_data);

        return sale_data;
    }

    public static string ConvertToJson(object args)
    {
        return Newtonsoft.Json.JsonConvert.SerializeObject(args, Formatting.Indented, new Newtonsoft.Json.JsonSerializerSettings { DefaultValueHandling = Newtonsoft.Json.DefaultValueHandling.Ignore });
    }
}